using System;
namespace DWGX.Model
{
	/// <summary>
	/// ʵ����User ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	[Serializable]
	public class User
	{
		public User()
		{}
		#region Model
		private int _id;
		private string _name;
		private string _nickname;
		private string _password;
		private DateTime _adddate;
		private DateTime _lastlogintime;
		private string _lastloginip;
		private int _logincount;
		private bool _isvalid;
		private string _limit;
		/// <summary>
		/// �û�ID
		/// </summary>
		public int id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// ��¼��
		/// </summary>
		public string name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// �û��ǳ�
		/// </summary>
		public string nickName
		{
			set{ _nickname=value;}
			get{return _nickname;}
		}
		/// <summary>
		/// �û�����
		/// </summary>
		public string passWord
		{
			set{ _password=value;}
			get{return _password;}
		}
		/// <summary>
		/// ����ʱ��
		/// </summary>
		public DateTime addDate
		{
			set{ _adddate=value;}
			get{return _adddate;}
		}
		/// <summary>
		/// ����¼ʱ��
		/// </summary>
		public DateTime lastLoginTime
		{
			set{ _lastlogintime=value;}
			get{return _lastlogintime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string lastLoginIP
		{
			set{ _lastloginip=value;}
			get{return _lastloginip;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int loginCount
		{
			set{ _logincount=value;}
			get{return _logincount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool isValid
		{
			set{ _isvalid=value;}
			get{return _isvalid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Limit
		{
			set{ _limit=value;}
			get{return _limit;}
		}
		#endregion Model

	}
}

