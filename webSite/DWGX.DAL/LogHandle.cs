using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using DWGX.Data;


namespace DWGX.DAL
{
	/// <summary>
	/// 数据访问类LogHandle。
	/// </summary>
	public class LogHandle
	{
		public LogHandle()
		{}
		#region  成员方法

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return SqlHelper.GetMaxID("ID", "tb_LogHandle"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from tb_LogHandle");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			return SqlHelper.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(DWGX.Model.LogHandle model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into tb_LogHandle(");
			strSql.Append("iCreatorID,dCreateTime,cIP,cMemo)");
			strSql.Append(" values (");
			strSql.Append("@iCreatorID,@dCreateTime,@cIP,@cMemo)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@iCreatorID", SqlDbType.Int,4),
					new SqlParameter("@dCreateTime", SqlDbType.DateTime),
					new SqlParameter("@cIP", SqlDbType.VarChar,50),
					new SqlParameter("@cMemo", SqlDbType.VarChar,200)};
			parameters[0].Value = model.iCreatorID;
			parameters[1].Value = model.dCreateTime;
			parameters[2].Value = model.cIP;
			parameters[3].Value = model.cMemo;

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
		public void Update(DWGX.Model.LogHandle model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update tb_LogHandle set ");
			strSql.Append("iCreatorID=@iCreatorID,");
			strSql.Append("dCreateTime=@dCreateTime,");
			strSql.Append("cIP=@cIP,");
			strSql.Append("cMemo=@cMemo");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@iCreatorID", SqlDbType.Int,4),
					new SqlParameter("@dCreateTime", SqlDbType.DateTime),
					new SqlParameter("@cIP", SqlDbType.VarChar,50),
					new SqlParameter("@cMemo", SqlDbType.VarChar,200)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.iCreatorID;
			parameters[2].Value = model.dCreateTime;
			parameters[3].Value = model.cIP;
			parameters[4].Value = model.cMemo;

			SqlHelper.ExecuteSql(strSql.ToString(),parameters);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from tb_LogHandle ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			SqlHelper.ExecuteSql(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public DWGX.Model.LogHandle GetLogHandle(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,iCreatorID,dCreateTime,cIP,cMemo from tb_LogHandle ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			DWGX.Model.LogHandle model=new DWGX.Model.LogHandle();
			using (SqlDataReader reader=SqlHelper.ExecuteReader(strSql.ToString(),parameters))
			{
				if (reader.HasRows)
				{
					reader.Read();
					model.ID = reader.GetInt32(0);
					model.iCreatorID = reader.GetInt32(1);
					model.dCreateTime = reader.GetDateTime(2);
					model.cIP = reader.GetString(3);
					model.cMemo = reader.GetString(4);
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
			strSql.Append(" FROM tb_LogHandle ");
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
		/// <returns>IList LogHandle</returns>
		public IList<DWGX.Model.LogHandle> GetLogHandles(int p_pageIndex, int p_pageSize, string strWhere, out int p_recordCount)
		{
			IList<DWGX.Model.LogHandle> listLogHandles = new List<DWGX.Model.LogHandle>();
			string sTable = "tb_LogHandle";
			string sPkey = "id";
			string sField = "ID,iCreatorID,dCreateTime,cIP,cMemo";
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
					return listLogHandles;
				}
				while (reader.Read())
				{
						DWGX.Model.LogHandle objLogHandle = new DWGX.Model.LogHandle();
						objLogHandle.ID = reader.GetInt32(0);
						objLogHandle.iCreatorID = reader.GetInt32(1);
						objLogHandle.dCreateTime = reader.GetDateTime(2);
						objLogHandle.cIP = reader.GetString(3);
						objLogHandle.cMemo = reader.GetString(4);
						listLogHandles.Add(objLogHandle);
				}
			}
			return listLogHandles;
		}

		#endregion  成员方法
	}
}

