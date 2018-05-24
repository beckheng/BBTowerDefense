using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

using KCore;
using KData;
using KView;

namespace KScene
{

	/// <summary>
	/// 场景逻辑层
	/// </summary>
	[DisallowMultipleComponent]
	public sealed class SplashSceneManager : KSceneManager
	{


		public override void LoadData()
		{
			StartCoroutine(KAssetBundle.LoadPersistentAB(new string[] {
				KAssetBundle.GetViewPah(typeof(LoadingProgressWindow).Name)
			}, onSucc));
		}

		private void onSucc()
		{
			LoadingProgressWindow loadingProgressWindow = KAssetBundle.InstantiateView<LoadingProgressWindow>();
			loadingProgressWindow.SetContent(null);

			KSceneManager.SwitchScene();
		}
	}

}

