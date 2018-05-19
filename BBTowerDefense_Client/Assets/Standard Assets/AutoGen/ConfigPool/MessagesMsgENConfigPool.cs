using UnityEngine;
using System.Collections;
using System.Collections.Generic;

using SimpleJSON;
using KCore;

namespace KData
{

	public class MessagesMsgENConfigPool
	{
		
		private static List<MessagesMsgENConfig> dataList = new List<MessagesMsgENConfig>();

		/// <summary>
		/// 按主键读取
		/// </summary>
		public static MessagesMsgENConfig GetByKey(int key)
		{
			for (int i = 0; i < dataList.Count; i++)
			{
				if (dataList[i].msg_id == key)
				{
					return dataList[i];
				}
			}

			return null;
		}

		/// <summary>
		/// 配置表所有数据
		/// </summary>
		public static List<MessagesMsgENConfig> GetList()
		{
			return dataList;
		}
		
		/// <summary>
		/// 从AB加载配置表
		/// </summary>
		public static IEnumerator LoadData(string jsonFilePath)
		{
			yield return KAssetBundle.LoadFromStreamAssets(jsonFilePath, OnLoadDataSucc, OnLoadDataError);
		}
		
		/// <summary>
		/// 配置表加载成功的回调
		/// </summary>
		private static void OnLoadDataSucc(WWW w)
		{
			Debug.Log("MessagesMsgENConfigPool|url|" + w.url);

			string content = w.text;
			Debug.Log("MessagesMsgENConfigPool|content|" + content);
			
			List<MessagesMsgENConfig> tmpList = new List<MessagesMsgENConfig>();
			string[] allLines = content.Replace("\r", "").Split(new char[] { '\n' });
			Debug.Log("allLines|" + allLines.Length);
			for (int l = 0; l < allLines.Length; l++)
			{
				if (allLines[l].Trim().Length == 0)
				{
					continue;
				}

				JSONNode jsonObject = JSON.Parse(allLines[l]);
				
				MessagesMsgENConfig config = new MessagesMsgENConfig();
				
					config.msg_id = jsonObject["msg_id"].AsInt;
					config.msg_text = jsonObject["msg_text"].Value;
				
				tmpList.Add(config);
			}

			dataList.Clear();
			dataList = tmpList;
			
			AssetBundle ab = w.assetBundle;
			if (ab != null)
			{
				//确保不会异常
				ab.Unload(true);
			}
		}
		
		/// <summary>
		/// 配置表加载失败的回调
		/// </summary>
		private static void OnLoadDataError(WWW w)
		{
			Debug.LogError("MessagesMsgENConfigPool|error|" + w.url);
		}
		
	}

}
