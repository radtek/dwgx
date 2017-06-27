using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using DWGX.Data;


namespace DWGX.DAL
{
	/// <summary>
	/// ���ݷ�����NewsClass��
	/// </summary>
	public class NewsClass
	{
		public NewsClass()
		{}
		#region  ��Ա����

		/// <summary>
		/// �õ����ID
		/// </summary>
		public int GetMaxId()
		{
		return SqlHelper.GetMaxID("ID", "tb_NewsClass"); 
		}

		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from tb_NewsClass");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			return SqlHelper.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// ����һ������
		/// </summary>
		public int Add(DWGX.Model.NewsClass model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into tb_NewsClass(");
			strSql.Append("cClassName,dOutTime,dCreateTime,cPic)");
			strSql.Append(" values (");
			strSql.Append("@cClassName,@dOutTime,@dCreateTime,@cPic)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@cClassName", SqlDbType.VarChar,50),
					new SqlParameter("@dOutTime", SqlDbType.DateTime),
					new SqlParameter("@dCreateTime", SqlDbType.DateTime),
					new SqlParameter("@cPic", SqlDbType.VarChar,100)};
			parameters[0].Value = model.cClassName;
			parameters[1].Value = model.dOutTime;
			parameters[2].Value = model.dCreateTime;
			parameters[3].Value = model.cPic;

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
		public void Update(DWGX.Model.NewsClass model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update tb_NewsClass set ");
			strSql.Append("cClassName=@cClassName,");
			strSql.Append("dOutTime=@dOutTime,");
			strSql.Append("dCreateTime=@dCreateTime,");
			strSql.Append("cPic=@cPic");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@cClassName", SqlDbType.VarChar,50),
					new SqlParameter("@dOutTime", SqlDbType.DateTime),
					new SqlParameter("@dCreateTime", SqlDbType.DateTime),
					new SqlParameter("@cPic", SqlDbType.VarChar,100)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.cClassName;
			parameters[2].Value = model.dOutTime;
			parameters[3].Value = model.dCreateTime;
			parameters[4].Value = model.cPic;

			SqlHelper.ExecuteSql(strSql.ToString(),parameters);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from tb_NewsClass ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			SqlHelper.ExecuteSql(strSql.ToString(),parameters);
		}


		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public DWGX.Model.NewsClass GetNewsClass(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,cClassName,dOutTime,dCreateTime,cPic from tb_NewsClass ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			DWGX.Model.NewsClass model=new DWGX.Model.NewsClass();
			using (SqlDataReader reader=SqlHelper.ExecuteReader(strSql.ToString(),parameters))
			{
				if (reader.HasRows)
				{
					reader.Read();
					model.ID = reader.GetInt32(0);
					model.cClassName = reader.GetString(1);
					model.dOutTime = reader.GetDateTime(2);
					model.dCreateTime = reader.GetDateTime(3);
					model.cPic = reader.GetString(4);
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
		public DataSet GetList(string strField, string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  " + strField + " ");
			strSql.Append(" FROM tb_NewsClass ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return SqlHelper.Query(strSql.ToString());
		}

		/// <summary>
		/// ȡ��ÿҳ��¼
		/// </summary>
		/// <param name="p_pageIndex">��ǰҳ</param>
		/// <param name="p_pageSize">��ҳ��С</param>
		/// <param name="p_recordCount">�����ܼ�¼��</param>
		/// <param name="strWhere">��ѯ����</param>
		/// <returns>IList NewsClass</returns>
		public IList<DWGX.Model.NewsClass> GetNewsClasss(int p_pageIndex, int p_pageSize, string strWhere, out int p_recordCount)
		{
			IList<DWGX.Model.NewsClass> listNewsClasss = new List<DWGX.Model.NewsClass>();
			string sTable = "tb_NewsClass";
			string sPkey = "id";
			string sField = "ID,cClassName,dOutTime,dCreateTime,cPic";
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
					return listNewsClasss;
				}
				while (reader.Read())
				{
						DWGX.Model.NewsClass objNewsClass = new DWGX.Model.NewsClass();
						objNewsClass.ID = reader.GetInt32(0);
						objNewsClass.cClassName = reader.GetString(1);
						objNewsClass.dOutTime = reader.GetDateTime(2);
						objNewsClass.dCreateTime = reader.GetDateTime(3);
						objNewsClass.cPic = reader.GetString(4);
						listNewsClasss.Add(objNewsClass);
				}
			}
			return listNewsClasss;
		}

		#endregion  ��Ա����
	}
}

