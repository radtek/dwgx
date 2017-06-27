using System;
namespace DWGX.Model
{
	/// <summary>
	/// 实体类AdPic 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class AdPic
	{
		public AdPic()
		{}
		#region Model
		private int _id;
		private int? _idesc;
		private string _cwidth;
		private string _cheight;
		private string _clink;
		private string _calt;
		private string _ctext;
		private string _ctype;
		private string _cpath;
		private int? _cshow;
		private DateTime? _dcreatetime;
		/// <summary>
		/// 
		/// </summary>
		public int Id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? iDesc
		{
			set{ _idesc=value;}
			get{return _idesc;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string cWidth
		{
			set{ _cwidth=value;}
			get{return _cwidth;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string cHeight
		{
			set{ _cheight=value;}
			get{return _cheight;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string cLink
		{
			set{ _clink=value;}
			get{return _clink;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string cAlt
		{
			set{ _calt=value;}
			get{return _calt;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string cText
		{
			set{ _ctext=value;}
			get{return _ctext;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string cType
		{
			set{ _ctype=value;}
			get{return _ctype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string cPath
		{
			set{ _cpath=value;}
			get{return _cpath;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? cShow
		{
			set{ _cshow=value;}
			get{return _cshow;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dCreateTime
		{
			set{ _dcreatetime=value;}
			get{return _dcreatetime;}
		}
		#endregion Model

	}
}

