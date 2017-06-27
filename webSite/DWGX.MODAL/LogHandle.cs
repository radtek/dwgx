using System;
namespace DWGX.Model
{
	/// <summary>
	/// 实体类LogHandle 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class LogHandle
	{
		public LogHandle()
		{}
		#region Model
		private int _id;
		private int? _icreatorid;
		private DateTime? _dcreatetime;
		private string _cip;
		private string _cmemo;
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
		public int? iCreatorID
		{
			set{ _icreatorid=value;}
			get{return _icreatorid;}
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
		public string cIP
		{
			set{ _cip=value;}
			get{return _cip;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string cMemo
		{
			set{ _cmemo=value;}
			get{return _cmemo;}
		}
		#endregion Model

	}
}

