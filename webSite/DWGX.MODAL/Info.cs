using System;
namespace DWGX.Model
{
	/// <summary>
	/// 实体类Info 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class Info
	{
		public Info()
		{}
		#region Model
		private int _id;
		private string _ccontent;
		private string _cmemo;
        private int _ishow;
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
		public string cContent
		{
			set{ _ccontent=value;}
			get{return _ccontent;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string cMemo
		{
			set{ _cmemo=value;}
			get{return _cmemo;}
		}

        /// <summary>
        /// 
        /// </summary>
        public int iShow
        {
            set { _ishow = value; }
            get { return _ishow; }
        }

        #endregion Model

    }
}

