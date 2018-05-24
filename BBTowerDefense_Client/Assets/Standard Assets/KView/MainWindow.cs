using UnityEngine;
using UnityEngine.UI;

using KCore;
using KScene;
using KData;

namespace KView
{

	[DisallowMultipleComponent]
	public partial class MainWindow : KUIWindow
	{
		
		/// <summary>
		/// 在Awake时调用,在InitializeComponent后调用
		/// </summary>
		protected override void BindEvent()
		{
			
		}
		
		protected override bool OnClosing()
		{
			return true;
		}

		/// <summary>
		/// 内部调用此方法来设置数据
		/// </summary>
		protected override void SetData(object data)
		{
		}
		
		
	}
	
}
