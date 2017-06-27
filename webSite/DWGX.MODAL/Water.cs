using System;
namespace DWGX.Model
{
	/// <summary>
	/// 实体类Water 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class Water
	{
		public Water()
		{}
		#region Model
		private int _id;
		private string _cword;
		private string _cpicpath;
		private int? _iruntype;
		private bool _isstart;
		private int? _ipos;
		private int? _iquality;
		private string _cfontname;
		private int? _ifontsize;
		private string _cfontcolor;
		private string _cpic;
		private int? _itransparency;
		/// <summary>
		/// 
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string cWord
		{
			set{ _cword=value;}
			get{return _cword;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string cPicPath
		{
			set{ _cpicpath=value;}
			get{return _cpicpath;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? iRunType
		{
			set{ _iruntype=value;}
			get{return _iruntype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool isStart
		{
			set{ _isstart=value;}
			get{return _isstart;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? iPos
		{
			set{ _ipos=value;}
			get{return _ipos;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? iQuality
		{
			set{ _iquality=value;}
			get{return _iquality;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string cFontName
		{
			set{ _cfontname=value;}
			get{return _cfontname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? iFontSize
		{
			set{ _ifontsize=value;}
			get{return _ifontsize;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string cFontColor
		{
			set{ _cfontcolor=value;}
			get{return _cfontcolor;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string cPic
		{
			set{ _cpic=value;}
			get{return _cpic;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? iTransparency
		{
			set{ _itransparency=value;}
			get{return _itransparency;}
		}
		#endregion Model

	}
}

