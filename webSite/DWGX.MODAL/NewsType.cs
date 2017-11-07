using System;
namespace DWGX.Model
{
	/// <summary>
	/// NewsType:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class NewsType
	{
		public NewsType()
		{}
		#region Model
		private int _id;
		private string _ctypename;
		private int? _iclassid;
		private int? _idesc=0;
		private DateTime? _dcreatetime= DateTime.Now;
		private string _cpic;
		private int? _ishow=0;
		private int _parentid=0;
		private string _linkurl;
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
		public string cTypeName
		{
			set{ _ctypename=value;}
			get{return _ctypename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? iClassId
		{
			set{ _iclassid=value;}
			get{return _iclassid;}
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
		public DateTime? dCreateTime
		{
			set{ _dcreatetime=value;}
			get{return _dcreatetime;}
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
		public int? iShow
		{
			set{ _ishow=value;}
			get{return _ishow;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int parentid
		{
			set{ _parentid=value;}
			get{return _parentid;}
		}
		/// <summary>
		/// 该类别的外部链接URL
		/// </summary>
		public string linkUrl
		{
			set{ _linkurl=value;}
			get{return _linkurl;}
		}
		#endregion Model

	}
}

