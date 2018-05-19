using UnityEngine;
using System.Collections;
using System.Collections.Generic;

using SimpleJSON;
using KCore;

namespace KData
{

	public class MessagesMsgSCConfigPool
	{
		
		private static List<MessagesMsgSCConfig> dataList = new List<MessagesMsgSCConfig>();

		/// <summary>
		/// 按主键读取
		/// </summary>
		public static MessagesMsgSCConfig GetByKey(int key)
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
		public static List<MessagesMsgSCConfig> GetList()
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
			Debug.Log("MessagesMsgSCConfigPool|url|" + w.url);

			string content = w.text;
			Debug.Log("MessagesMsgSCConfigPool|content|" + content);
			
			List<MessagesMsgSCConfig> tmpList = new List<MessagesMsgSCConfig>();
			string[] allLines = content.Replace("\r", "").Split(new char[] { '\n' });
			Debug.Log("allLines|" + allLines.Length);
			for (int l = 0; l < allLines.Length; l++)
			{
				if (allLines[l].Trim().Length == 0)
				{
					continue;
				}

				JSONNode jsonObject = JSON.Parse(allLines[l]);
				
				MessagesMsgSCConfig config = new MessagesMsgSCConfig();
				
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
			Debug.LogError("MessagesMsgSCConfigPool|error|" + w.url);
		}
		
	}

}
