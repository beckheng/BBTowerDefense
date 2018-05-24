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
	public sealed class MainSceneManager : KSceneManager
	{

		MainWindow mainWindow = null;

		public override void LoadData()
		{
			Debug.Log("xxxx");
			Debug.LogError("MainSceneManager|do|nothing");

			StartCoroutine(KAssetBundle.LoadPersistentAB(new string[] { "View/mainwindow" }, onSucc, onError));
		}

		private void onError()
		{
			Debug.Log("fuck|error");
		}

		private void onSucc()
		{
			mainWindow = KAssetBundle.InstantiateView<MainWindow>("mainwindow");
			Debug.Log(Time.frameCount + "|after|instantiate");
			mainWindow.SetContent(null);
			Debug.Log(Time.frameCount + "|after|setdata");
		}
	}

}

