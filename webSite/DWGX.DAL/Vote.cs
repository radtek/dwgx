using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using DWGX.Data;


namespace DWGX.DAL
{
	/// <summary>
	/// 数据访问类Vote。
	/// </summary>
	public class Vote
	{
		public Vote()
		{}
		#region  成员方法

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return SqlHelper.GetMaxID("ID", "tb_Vote"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from tb_Vote");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			return SqlHelper.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(DWGX.Model.Vote model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into tb_Vote(");
			strSql.Append("cTitle,dCreateTime,iCreatorID,cType)");
			strSql.Append(" values (");
			strSql.Append("@cTitle,@dCreateTime,@iCreatorID,@cType)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@cTitle", SqlDbType.VarChar,100),
					new SqlParameter("@dCreateTime", SqlDbType.DateTime),
					new SqlParameter("@iCreatorID", SqlDbType.Int,4),
					new SqlParameter("@cType", SqlDbType.VarChar,50)};
			parameters[0].Value = model.cTitle;
			parameters[1].Value = model.dCreateTime;
			parameters[2].Value = model.iCreatorID;
			parameters[3].Value = model.cType;

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
		/// 更新一条数据
		/// </summary>
		public void Update(DWGX.Model.Vote model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update tb_Vote set ");
			strSql.Append("cTitle=@cTitle,");
			strSql.Append("dCreateTime=@dCreateTime,");
			strSql.Append("iCreatorID=@iCreatorID,");
			strSql.Append("cType=@cType");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@cTitle", SqlDbType.VarChar,100),
					new SqlParameter("@dCreateTime", SqlDbType.DateTime),
					new SqlParameter("@iCreatorID", SqlDbType.Int,4),
					new SqlParameter("@cType", SqlDbType.VarChar,50)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.cTitle;
			parameters[2].Value = model.dCreateTime;
			parameters[3].Value = model.iCreatorID;
			parameters[4].Value = model.cType;

			SqlHelper.ExecuteSql(strSql.ToString(),parameters);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from tb_Vote ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			SqlHelper.ExecuteSql(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public DWGX.Model.Vote GetVote(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,cTitle,dCreateTime,iCreatorID,cType from tb_Vote ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			DWGX.Model.Vote model=new DWGX.Model.Vote();
			using (SqlDataReader reader=SqlHelper.ExecuteReader(strSql.ToString(),parameters))
			{
				if (reader.HasRows)
				{
					reader.Read();
					model.ID = reader.GetInt32(0);
					model.cTitle = reader.GetString(1);
					model.dCreateTime = reader.GetDateTime(2);
					model.iCreatorID = reader.GetInt32(3);
					model.cType = reader.GetString(4);
					return model;
				}
				else
				{
				return null;
				}
			}
		}

		/// <summary>
		/// 根据字段取数据列表
		/// </summary>
		public DataSet GetList(string strField, string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  " + strField + " ");
			strSql.Append(" FROM tb_Vote ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return SqlHelper.Query(strSql.ToString());
		}

		/// <summary>
		/// 取得每页记录
		/// </summary>
		/// <param name="p_pageIndex">当前页</param>
		/// <param name="p_pageSize">分页大小</param>
		/// <param name="p_recordCount">返回总记录数</param>
		/// <param name="strWhere">查询条件</param>
		/// <returns>IList Vote</returns>
		public IList<DWGX.Model.Vote> GetVotes(int p_pageIndex, int p_pageSize, string strWhere, out int p_recordCount)
		{
			IList<DWGX.Model.Vote> listVotes = new List<DWGX.Model.Vote>();
			string sTable = "tb_Vote";
			string sPkey = "id";
			string sField = "ID,cTitle,dCreateTime,iCreatorID,cType";
			string sCondition = strWhere;
			string sOrder = "ID Desc";
			int iSCounts = 0;
			using (SqlDataReader reader = SqlHelper.RunProcedureMe(sTable, sPkey, sField, p_pageIndex, p_pageSize, sCondition, sOrder, iSCounts, out p_recordCount))
			{
				//计算总页数
				if (p_recordCount > 0)
				{
                    int pageCount = 10;//BasePage.CalcPageCount(p_recordCount, p_pageSize, ref p_pageIndex);
                }
				else
				{
					return listVotes;
				}
				while (reader.Read())
				{
						DWGX.Model.Vote objVote = new DWGX.Model.Vote();
						objVote.ID = reader.GetInt32(0);
						objVote.cTitle = reader.GetString(1);
						objVote.dCreateTime = reader.GetDateTime(2);
						objVote.iCreatorID = reader.GetInt32(3);
						objVote.cType = reader.GetString(4);
						listVotes.Add(objVote);
				}
			}
			return listVotes;
		}

		#endregion  成员方法
	}
}

