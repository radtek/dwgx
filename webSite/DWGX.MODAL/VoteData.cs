using System;
namespace DWGX.Model
{
	/// <summary>
	/// 实体类VoteData 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class VoteData
	{
		public VoteData()
		{}
		#region Model
		private int _id;
		private string _cname;
		private int? _icount;
		private DateTime? _dcreatetime;
		private int? _ivoteid;
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
		public string cName
		{
			set{ _cname=value;}
			get{return _cname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? iCount
		{
			set{ _icount=value;}
			get{return _icount;}
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
		public int? iVoteID
		{
			set{ _ivoteid=value;}
			get{return _ivoteid;}
		}
		#endregion Model

	}
}

