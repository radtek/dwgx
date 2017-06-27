using System;
namespace DWGX.Model
{
	/// <summary>
	/// 实体类News 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class News
	{
		public News()
		{}
		#region Model
		private int _id;
		private string _ctitle;
		private string _clittletitle;
		private string _ctitlecolor;
		private string _ctitleb;
		private string _ctitleu;
		private string _ctitlesize;
		private string _ctitleshow;
		private DateTime? _dcreatetime;
		private int? _iviewcount;
		private string _ccontent;
		private int? _itypeid;
		private int _icreatorid;
		private string _cpicpath;
		private string _cvideopath;
		private bool _isput;
		private string _cputpicpath;
		private bool _ispic;
		private bool _isscrollpic;
		private string _curl;
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
		public string cTitle
		{
			set{ _ctitle=value;}
			get{return _ctitle;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string cLittleTitle
		{
			set{ _clittletitle=value;}
			get{return _clittletitle;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string cTitleColor
		{
			set{ _ctitlecolor=value;}
			get{return _ctitlecolor;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string cTitleB
		{
			set{ _ctitleb=value;}
			get{return _ctitleb;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string cTitleU
		{
			set{ _ctitleu=value;}
			get{return _ctitleu;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string cTitleSize
		{
			set{ _ctitlesize=value;}
			get{return _ctitlesize;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string cTitleShow
		{
			set{ _ctitleshow=value;}
			get{return _ctitleshow;}
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
		public int? iViewCount
		{
			set{ _iviewcount=value;}
			get{return _iviewcount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string cContent
		{
			set{ _ccontent=value;}
			get{return _ccontent;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? iTypeId
		{
			set{ _itypeid=value;}
			get{return _itypeid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int iCreatorId
		{
			set{ _icreatorid=value;}
			get{return _icreatorid;}
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
		public string cVideoPath
		{
			set{ _cvideopath=value;}
			get{return _cvideopath;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool isPut
		{
			set{ _isput=value;}
			get{return _isput;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string cPutPicPath
		{
			set{ _cputpicpath=value;}
			get{return _cputpicpath;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool isPic
		{
			set{ _ispic=value;}
			get{return _ispic;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool isScrollPic
		{
			set{ _isscrollpic=value;}
			get{return _isscrollpic;}
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

    public class viewNews : News
    {
        public string cTypeName;
    }
}

