using UnityEngine.UI;

using KCore;
using KScene;
using KData;

namespace KView
{
	public sealed partial class LoadingProgressWindow : KUIWindow
	{
		/// Params Define

		/// <summary>
		/// 
		/// </summary>
		private Text text;

		
		/// <summary>
		/// 在Awake时调用,先于BindEvent调用
		/// </summary>
		protected override void InitializeComponent()
		{
		
			///Params Assignment
			text = tran.GetComponentByName<Text>("Text");

		}
	}
}
