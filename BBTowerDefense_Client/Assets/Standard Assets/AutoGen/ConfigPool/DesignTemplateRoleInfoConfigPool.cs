using UnityEngine;
using System.Collections;
using System.Collections.Generic;

using SimpleJSON;
using KCore;

namespace KData
{

	public class DesignTemplateRoleInfoConfigPool
	{
		
		private static List<DesignTemplateRoleInfoConfig> dataList = new List<DesignTemplateRoleInfoConfig>();

		/// <summary>
		/// 按主键读取
		/// </summary>
		public static DesignTemplateRoleInfoConfig GetByKey(int key)
		{
			for (int i = 0; i < dataList.Count; i++)
			{
				if (dataList[i].role_id == key)
				{
					return dataList[i];
				}
			}

			return null;
		}

		/// <summary>
		/// 配置表所有数据
		/// </summary>
		public static List<DesignTemplateRoleInfoConfig> GetList()
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
			Debug.Log("DesignTemplateRoleInfoConfigPool|url|" + w.url);

			string content = w.text;
			Debug.Log("DesignTemplateRoleInfoConfigPool|content|" + content);
			
			List<DesignTemplateRoleInfoConfig> tmpList = new List<DesignTemplateRoleInfoConfig>();
			string[] allLines = content.Replace("\r", "").Split(new char[] { '\n' });
			Debug.Log("allLines|" + allLines.Length);
			for (int l = 0; l < allLines.Length; l++)
			{
				if (allLines[l].Trim().Length == 0)
				{
					continue;
				}

				JSONNode jsonObject = JSON.Parse(allLines[l]);
				
				DesignTemplateRoleInfoConfig config = new DesignTemplateRoleInfoConfig();
				
					config.role_id = jsonObject["role_id"].AsInt;
					config.role_name = jsonObject["role_name"].Value;
					config.role_type = jsonObject["role_type"].AsInt;
					config.role_story = jsonObject["role_story"].Value;
					var tmp_init_item = jsonObject["init_item"].AsArray;
					for (int i = 0; i < tmp_init_item.Count; i++)
					{
						config.init_item.Add(tmp_init_item[i].AsInt);
					}
				
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
			Debug.LogError("DesignTemplateRoleInfoConfigPool|error|" + w.url);
		}
		
	}

}
