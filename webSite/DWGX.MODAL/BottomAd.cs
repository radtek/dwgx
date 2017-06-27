using System;
namespace DWGX.Model
{
	/// <summary>
	/// BottomAd:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class BottomAd
	{
		public BottomAd()
		{}
		#region Model
		private int _id;
		private string _cpath;
		private DateTime _addtime;
		private string _curl;
		/// <summary>
		/// 自增Id
		/// </summary>
		public int id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 图片路径
		/// </summary>
		public string cPath
		{
			set{ _cpath=value;}
			get{return _cpath;}
		}
		/// <summary>
		/// 时间
		/// </summary>
		public DateTime addTime
		{
			set{ _addtime=value;}
			get{return _addtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string cUrl
		{
			set{ _curl=value;}
			get{return _curl;}
		}
		#endregion Model

	}
}

