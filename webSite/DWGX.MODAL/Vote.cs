using System;
namespace DWGX.Model
{
	/// <summary>
	/// 实体类Vote 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class Vote
	{
		public Vote()
		{}
		#region Model
		private int _id;
		private string _ctitle;
		private DateTime? _dcreatetime;
		private int? _icreatorid;
		private string _ctype;
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
		public DateTime? dCreateTime
		{
			set{ _dcreatetime=value;}
			get{return _dcreatetime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? iCreatorID
		{
			set{ _icreatorid=value;}
			get{return _icreatorid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string cType
		{
			set{ _ctype=value;}
			get{return _ctype;}
		}
		#endregion Model

	}
}

