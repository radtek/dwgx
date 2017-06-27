using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using DWGX.Data;

namespace DWGX.DAL
{
	/// <summary>
	/// ���ݷ�����Info��
	/// </summary>
	public class Info
	{
		public Info()
		{}
		#region  ��Ա����

		/// <summary>
		/// �õ����ID
		/// </summary>
		public int GetMaxId()
		{
		return SqlHelper.GetMaxID("ID", "tb_Info"); 
		}

		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from tb_Info");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			return SqlHelper.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// ����һ������
		/// </summary>
		public int Add(DWGX.Model.Info model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into tb_Info(");
			strSql.Append("cContent,cMemo)");
			strSql.Append(" values (");
			strSql.Append("@cContent,@cMemo)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@cContent", SqlDbType.Text),
					new SqlParameter("@cMemo", SqlDbType.VarChar,200)};
			parameters[0].Value = model.cContent;
			parameters[1].Value = model.cMemo;

			object obj = SqlHelper.GetSingle(strSql.ToString(),parameters);
			if (obj == null)
			{
				return 1;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// ����һ������
		/// </summary>
		public void Update(DWGX.Model.Info model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update tb_Info set ");
			strSql.Append("cContent=@cContent,");
			strSql.Append("cMemo=@cMemo");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@cContent", SqlDbType.Text),
					new SqlParameter("@cMemo", SqlDbType.VarChar,200)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.cContent;
			parameters[2].Value = model.cMemo;

			SqlHelper.ExecuteSql(strSql.ToString(),parameters);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from tb_Info ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			SqlHelper.ExecuteSql(strSql.ToString(),parameters);
		}


		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public DWGX.Model.Info GetInfo(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,cContent,cMemo from tb_Info ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			DWGX.Model.Info model=new DWGX.Model.Info();
			using (SqlDataReader reader=SqlHelper.ExecuteReader(strSql.ToString(),parameters))
			{
				if (reader.HasRows)
				{
					reader.Read();
					model.ID = reader.GetInt32(0);
					model.cContent = reader.GetString(1);
					model.cMemo = reader.GetString(2);
					return model;
				}
				else
				{
				return null;
				}
			}
		}

		/// <summary>
		/// �����ֶ�ȡ�����б�
		/// </summary>
		public DataSet GetList(string strField, string strWhere,string strOrder="")
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  " + strField + " ");
			strSql.Append(" FROM tb_Info ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
            if (strOrder.Trim() != "")
                strSql.Append(" Order By "+strOrder);
            return SqlHelper.Query(strSql.ToString());
		}

		/// <summary>
		/// ȡ��ÿҳ��¼
		/// </summary>
		/// <param name="p_pageIndex">��ǰҳ</param>
		/// <param name="p_pageSize">��ҳ��С</param>
		/// <param name="p_recordCount">�����ܼ�¼��</param>
		/// <param name="strWhere">��ѯ����</param>
		/// <returns>IList Info</returns>
		public IList<DWGX.Model.Info> GetInfos(int p_pageIndex, int p_pageSize, string strWhere, out int p_recordCount)
		{
			IList<DWGX.Model.Info> listInfos = new List<DWGX.Model.Info>();
			string sTable = "tb_Info";
			string sPkey = "id";
			string sField = "ID,cContent,cMemo";
			string sCondition = strWhere;
			string sOrder = "ID Desc";
			int iSCounts = 0;
			using (SqlDataReader reader = SqlHelper.RunProcedureMe(sTable, sPkey, sField, p_pageIndex, p_pageSize, sCondition, sOrder, iSCounts, out p_recordCount))
			{
				//������ҳ��
				if (p_recordCount > 0)
				{
                    int pageCount = 10;//BasePage.CalcPageCount(p_recordCount, p_pageSize, ref p_pageIndex);
                }
				else
				{
					return listInfos;
				}
				while (reader.Read())
				{
						DWGX.Model.Info objInfo = new DWGX.Model.Info();
						objInfo.ID = reader.GetInt32(0);
						objInfo.cContent = reader.GetString(1);
						objInfo.cMemo = reader.GetString(2);
						listInfos.Add(objInfo);
				}
			}
			return listInfos;
		}

		#endregion  ��Ա����
	}
}

