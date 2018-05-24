using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

using KCore;
using KData;

namespace KScene
{

	/// <summary>
	/// 场景逻辑层
	/// </summary>
	[DisallowMultipleComponent]
	public sealed class FightSceneManager : KSceneManager
	{

		public override void LoadData()
		{
			Debug.LogError("FightSceneManager|do|nothing");
		}

	}

}

