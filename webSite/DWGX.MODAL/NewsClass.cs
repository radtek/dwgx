using System;
namespace DWGX.Model
{
	/// <summary>
	/// ʵ����NewsClass ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	[Serializable]
	public class NewsClass
	{
		public NewsClass()
		{}
		#region Model
		private int _id;
		private string _cclassname;
		private DateTime? _douttime;
		private DateTime? _dcreatetime;
		private string _cpic;
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
		public string cClassName
		{
			set{ _cclassname=value;}
			get{return _cclassname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dOutTime
		{
			set{ _douttime=value;}
			get{return _douttime;}
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
		#endregion Model

	}
}

