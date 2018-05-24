using UnityEngine.UI;

using KCore;
using KScene;
using KData;

namespace KView
{
	public sealed partial class MainWindow : KUIWindow
	{
		/// Params Define

		/// <summary>
		/// 
		/// </summary>
		private Image bgImage;

		/// <summary>
		/// 
		/// </summary>
		private Button startGameButton;

		/// <summary>
		/// 
		/// </summary>
		private Button aboutUSButton;

		
		/// <summary>
		/// 在Awake时调用,先于BindEvent调用
		/// </summary>
		protected override void InitializeComponent()
		{
		
			///Params Assignment
			bgImage = tran.GetComponentByName<Image>("BgImage");
			startGameButton = tran.GetComponentByName<Button>("StartGameButton");
			aboutUSButton = tran.GetComponentByName<Button>("AboutUSButton");

		}
	}
}
