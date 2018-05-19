using UnityEngine;
using System.Collections;

namespace KData
{

	public class ConfigLoaderAutoGen
	{

		public static IEnumerator LoadAllData()
		{
			//yield return DesignTemplateRoleInfoConfigPool.LoadData("/Configs/DesignTemplateRoleInfo.json");
			

			yield return DesignTemplateRoleInfoConfigPool.LoadData("/Configs/DesignTemplateRoleInfo.json");
			
			yield return 1;
		}
	}

}
