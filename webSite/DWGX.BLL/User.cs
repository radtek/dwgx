using System;
using System.Data;
using System.Collections.Generic;
namespace DWGX.BLL
{
	/// <summary>
	/// ҵ���߼���User ��ժҪ˵����
	/// </summary>
	public class User
	{
        
		private readonly DWGX.DAL.User dal=new DWGX.DAL.User();
		public User()
		{}
		#region  ��Ա����
		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(int id)
		{
			return dal.Exists(id);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public int  Add(DWGX.Model.User model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Update(DWGX.Model.User model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete(int id)
		{
			
			dal.Delete(id);
		}

		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public DWGX.Model.User GetUser(int id)
		{
			
			return dal.GetUser(id);
		}

        public DWGX.Model.User GetUser(string name)
        {

            return dal.GetUser(name);
        }

        /// <summary>
        /// �����ֶ�ȡ�����б�
        /// </summary>
        public DataSet GetList(string strField, string strWhere)
		{
			return dal.GetList(strField, strWhere);
		}

		/// <summary>
		/// ȡ��ÿҳ��¼
		/// </summary>
		/// <param name="p_pageIndex">��ǰҳ</param>
		/// <param name="p_pageSize">��ҳ��С</param>
		/// <param name="p_recordCount">�����ܼ�¼��</param>
		/// <param name="strWhere">��ѯ����</param>
		/// <returns>IList User</returns>
		public IList<Model.User> GetUsers(int p_pageIndex, int p_pageSize, string strWhere, out int p_recordCount)
		{
			return dal.GetUsers(p_pageIndex, p_pageSize, strWhere, out p_recordCount);
		}

		#endregion  ��Ա����
	}
}

