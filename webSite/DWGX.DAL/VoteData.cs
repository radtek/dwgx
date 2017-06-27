using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using DWGX.Data;


namespace DWGX.DAL
{
	/// <summary>
	/// ���ݷ�����VoteData��
	/// </summary>
	public class VoteData
	{
		public VoteData()
		{}
		#region  ��Ա����

		/// <summary>
		/// �õ����ID
		/// </summary>
		public int GetMaxId()
		{
		return SqlHelper.GetMaxID("ID", "tb_VoteData"); 
		}

		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from tb_VoteData");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			return SqlHelper.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// ����һ������
		/// </summary>
		public int Add(DWGX.Model.VoteData model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into tb_VoteData(");
			strSql.Append("cName,iCount,dCreateTime,iVoteID)");
			strSql.Append(" values (");
			strSql.Append("@cName,@iCount,@dCreateTime,@iVoteID)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@cName", SqlDbType.VarChar,50),
					new SqlParameter("@iCount", SqlDbType.Int,4),
					new SqlParameter("@dCreateTime", SqlDbType.DateTime),
					new SqlParameter("@iVoteID", SqlDbType.Int,4)};
			parameters[0].Value = model.cName;
			parameters[1].Value = model.iCount;
			parameters[2].Value = model.dCreateTime;
			parameters[3].Value = model.iVoteID;

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
		public void Update(DWGX.Model.VoteData model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update tb_VoteData set ");
			strSql.Append("cName=@cName,");
			strSql.Append("iCount=@iCount,");
			strSql.Append("dCreateTime=@dCreateTime,");
			strSql.Append("iVoteID=@iVoteID");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@cName", SqlDbType.VarChar,50),
					new SqlParameter("@iCount", SqlDbType.Int,4),
					new SqlParameter("@dCreateTime", SqlDbType.DateTime),
					new SqlParameter("@iVoteID", SqlDbType.Int,4)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.cName;
			parameters[2].Value = model.iCount;
			parameters[3].Value = model.dCreateTime;
			parameters[4].Value = model.iVoteID;

			SqlHelper.ExecuteSql(strSql.ToString(),parameters);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from tb_VoteData ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			SqlHelper.ExecuteSql(strSql.ToString(),parameters);
		}


		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public DWGX.Model.VoteData GetVoteData(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,cName,iCount,dCreateTime,iVoteID from tb_VoteData ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			DWGX.Model.VoteData model=new DWGX.Model.VoteData();
			using (SqlDataReader reader=SqlHelper.ExecuteReader(strSql.ToString(),parameters))
			{
				if (reader.HasRows)
				{
					reader.Read();
					model.ID = reader.GetInt32(0);
					model.cName = reader.GetString(1);
					model.iCount = reader.GetInt32(2);
					model.dCreateTime = reader.GetDateTime(3);
					model.iVoteID = reader.GetInt32(4);
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
			strSql.Append(" FROM tb_VoteData ");
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
		/// <returns>IList VoteData</returns>
		public IList<DWGX.Model.VoteData> GetVoteDatas(int p_pageIndex, int p_pageSize, string strWhere, out int p_recordCount)
		{
			IList<DWGX.Model.VoteData> listVoteDatas = new List<DWGX.Model.VoteData>();
			string sTable = "tb_VoteData";
			string sPkey = "id";
			string sField = "ID,cName,iCount,dCreateTime,iVoteID";
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
					return listVoteDatas;
				}
				while (reader.Read())
				{
						DWGX.Model.VoteData objVoteData = new DWGX.Model.VoteData();
						objVoteData.ID = reader.GetInt32(0);
						objVoteData.cName = reader.GetString(1);
						objVoteData.iCount = reader.GetInt32(2);
						objVoteData.dCreateTime = reader.GetDateTime(3);
						objVoteData.iVoteID = reader.GetInt32(4);
						listVoteDatas.Add(objVoteData);
				}
			}
			return listVoteDatas;
		}

		#endregion  ��Ա����
	}
}

