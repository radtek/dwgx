using System;
using System.Data;
using System.Collections.Generic;
namespace DWGX.BLL
{
	/// <summary>
	/// ҵ���߼���AdPic ��ժҪ˵����
	/// </summary>
	public class AdPic
	{
		private readonly DWGX.DAL.AdPic dal=new DWGX.DAL.AdPic();
		public AdPic()
		{}
		#region  ��Ա����

		/// <summary>
		/// �õ����ID
		/// </summary>
		public int GetMaxId()
		{
			return dal.GetMaxId();
		}

		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(int Id)
		{
			return dal.Exists(Id);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public int  Add(DWGX.Model.AdPic model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Update(DWGX.Model.AdPic model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete(int Id)
		{
			
			dal.Delete(Id);
		}

		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public DWGX.Model.AdPic GetAdPic(int Id)
		{
			
			return dal.GetAdPic(Id);
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
		/// <returns>IList AdPic</returns>
		public IList<DWGX.Model.AdPic> GetAdPics(int p_pageIndex, int p_pageSize, string strWhere, out int p_recordCount)
		{
			return dal.GetAdPics(p_pageIndex, p_pageSize, strWhere, out p_recordCount);
		}

		#endregion  ��Ա����
	}
}

