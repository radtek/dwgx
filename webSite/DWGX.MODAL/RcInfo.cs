using System;
namespace DWGX.Model
{
	/// <summary>
	/// RcInfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class RcInfo
	{
		public RcInfo()
		{}
		#region Model
		private int _id;
		private string _companyname="";
		private string _jobname;
		private string _jobtype;
		private int _amount;
		private int? _sex=2;
		private int? _age=0;
		private string _rofs="不限";
		private string _major="不限";
		private string _jobobject="不限";
		private string _titlerequire="不限";
		private string _staturerequire="不限";
		private string _arearequire="不限";
		private string _certificatesrequire="不限";
		private DateTime _createtime= DateTime.Now;
		private string _significantinterval="长期有效";
		private string _jobaddr;
		private string _salary="面议";
		private string _compnyaddr;
		private string _phone;
		private string _others;
		private DateTime _updatetime= DateTime.Now;
		/// <summary>
		/// 
		/// </summary>
		public int id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 公司名称
		/// </summary>
		public string companyName
		{
			set{ _companyname=value;}
			get{return _companyname;}
		}
		/// <summary>
		/// 招聘职位
		/// </summary>
		public string jobName
		{
			set{ _jobname=value;}
			get{return _jobname;}
		}
		/// <summary>
		/// 用工形式
		/// </summary>
		public string jobType
		{
			set{ _jobtype=value;}
			get{return _jobtype;}
		}
		/// <summary>
		/// 招聘人数
		/// </summary>
		public int amount
		{
			set{ _amount=value;}
			get{return _amount;}
		}
		/// <summary>
		/// 性别要求
		/// </summary>
		public int? sex
		{
			set{ _sex=value;}
			get{return _sex;}
		}
		/// <summary>
		/// 年龄要求
		/// </summary>
		public int? age
		{
			set{ _age=value;}
			get{return _age;}
		}
		/// <summary>
		/// 学历要求
		/// </summary>
		public string rofs
		{
			set{ _rofs=value;}
			get{return _rofs;}
		}
		/// <summary>
		/// 专业要求
		/// </summary>
		public string major
		{
			set{ _major=value;}
			get{return _major;}
		}
		/// <summary>
		/// 用人对象
		/// </summary>
		public string jobobject
		{
			set{ _jobobject=value;}
			get{return _jobobject;}
		}
		/// <summary>
		/// 职称要求
		/// </summary>
		public string titleRequire
		{
			set{ _titlerequire=value;}
			get{return _titlerequire;}
		}
		/// <summary>
		/// 身高要求
		/// </summary>
		public string statureRequire
		{
			set{ _staturerequire=value;}
			get{return _staturerequire;}
		}
		/// <summary>
		/// 地域要求
		/// </summary>
		public string areaRequire
		{
			set{ _arearequire=value;}
			get{return _arearequire;}
		}
		/// <summary>
		/// 证书要求
		/// </summary>
		public string certificatesRequire
		{
			set{ _certificatesrequire=value;}
			get{return _certificatesrequire;}
		}
		/// <summary>
		/// 发布时间
		/// </summary>
		public DateTime createTime
		{
			set{ _createtime=value;}
			get{return _createtime;}
		}
		/// <summary>
		/// 有效时间
		/// </summary>
		public string significantInterval
		{
			set{ _significantinterval=value;}
			get{return _significantinterval;}
		}
		/// <summary>
		/// 工作地点
		/// </summary>
		public string jobAddr
		{
			set{ _jobaddr=value;}
			get{return _jobaddr;}
		}
		/// <summary>
		/// 待遇要求
		/// </summary>
		public string salary
		{
			set{ _salary=value;}
			get{return _salary;}
		}
		/// <summary>
		/// 公司地址
		/// </summary>
		public string compnyAddr
		{
			set{ _compnyaddr=value;}
			get{return _compnyaddr;}
		}
		/// <summary>
		/// 联系电话
		/// </summary>
		public string phone
		{
			set{ _phone=value;}
			get{return _phone;}
		}
		/// <summary>
		/// 其它要求
		/// </summary>
		public string others
		{
			set{ _others=value;}
			get{return _others;}
		}
		/// <summary>
		/// datetime
		/// </summary>
		public DateTime updateTime
		{
			set{ _updatetime=value;}
			get{return _updatetime;}
		}
		#endregion Model

	}
}

