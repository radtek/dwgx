using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using DWGX.Data;

namespace DWGX.DAL
{
	/// <summary>
	/// 数据访问类User。
	/// </summary>
	public class User
	{
		public User()
		{}
		#region  成员方法

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from tb_User");
			strSql.Append(" where id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = id;

			return SqlHelper.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(DWGX.Model.User model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into tb_User(");
			strSql.Append("name,nickName,passWord,addDate,lastLoginTime,lastLoginIP,loginCount,isValid,Limit)");
			strSql.Append(" values (");
			strSql.Append("@name,@nickName,@passWord,@addDate,@lastLoginTime,@lastLoginIP,@loginCount,@isValid,@Limit)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@name", SqlDbType.NVarChar,50),
					new SqlParameter("@nickName", SqlDbType.NVarChar,50),
					new SqlParameter("@passWord", SqlDbType.NVarChar,100),
					new SqlParameter("@addDate", SqlDbType.DateTime),
					new SqlParameter("@lastLoginTime", SqlDbType.DateTime),
					new SqlParameter("@lastLoginIP", SqlDbType.NVarChar,50),
					new SqlParameter("@loginCount", SqlDbType.Int,4),
					new SqlParameter("@isValid", SqlDbType.Bit,1),
					new SqlParameter("@Limit", SqlDbType.NVarChar,2000)};
			parameters[0].Value = model.name;
			parameters[1].Value = model.nickName;
			parameters[2].Value = model.passWord;
			parameters[3].Value = model.addDate;
			parameters[4].Value = model.lastLoginTime;
			parameters[5].Value = model.lastLoginIP;
			parameters[6].Value = model.loginCount;
			parameters[7].Value = model.isValid;
			parameters[8].Value = model.Limit;

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
		public void Update(DWGX.Model.User model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update tb_User set ");
			strSql.Append("name=@name,");
			strSql.Append("nickName=@nickName,");
			strSql.Append("passWord=@passWord,");
			strSql.Append("addDate=@addDate,");
			strSql.Append("lastLoginTime=@lastLoginTime,");
			strSql.Append("lastLoginIP=@lastLoginIP,");
			strSql.Append("loginCount=@loginCount,");
			strSql.Append("isValid=@isValid,");
			strSql.Append("Limit=@Limit");
			strSql.Append(" where id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4),
					new SqlParameter("@name", SqlDbType.NVarChar,50),
					new SqlParameter("@nickName", SqlDbType.NVarChar,50),
					new SqlParameter("@passWord", SqlDbType.NVarChar,100),
					new SqlParameter("@addDate", SqlDbType.DateTime),
					new SqlParameter("@lastLoginTime", SqlDbType.DateTime),
					new SqlParameter("@lastLoginIP", SqlDbType.NVarChar,50),
					new SqlParameter("@loginCount", SqlDbType.Int,4),
					new SqlParameter("@isValid", SqlDbType.Bit,1),
					new SqlParameter("@Limit", SqlDbType.NVarChar,2000)};
			parameters[0].Value = model.id;
			parameters[1].Value = model.name;
			parameters[2].Value = model.nickName;
			parameters[3].Value = model.passWord;
			parameters[4].Value = model.addDate;
			parameters[5].Value = model.lastLoginTime;
			parameters[6].Value = model.lastLoginIP;
			parameters[7].Value = model.loginCount;
			parameters[8].Value = model.isValid;
			parameters[9].Value = model.Limit;

			SqlHelper.ExecuteSql(strSql.ToString(),parameters);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from tb_User ");
			strSql.Append(" where id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = id;

			SqlHelper.ExecuteSql(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public DWGX.Model.User GetUser(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,name,nickName,passWord,addDate,lastLoginTime,lastLoginIP,loginCount,isValid,Limit from tb_User ");
			strSql.Append(" where id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = id;

			DWGX.Model.User model=new DWGX.Model.User();
			using (SqlDataReader reader=SqlHelper.ExecuteReader(strSql.ToString(),parameters))
			{
				if (reader.HasRows)
				{
					reader.Read();
					model.id = reader.GetInt32(0);
					model.name = reader.GetString(1);
					model.nickName = reader.GetString(2);
					model.passWord = reader.GetString(3);
					model.addDate = reader.GetDateTime(4);
					model.lastLoginTime = reader.GetDateTime(5);
					model.lastLoginIP = reader.GetString(6);
					model.loginCount = reader.GetInt32(7);
					model.isValid = reader.GetBoolean(8);
					model.Limit = reader.GetString(9);
					return model;
				}
				else
				{
				return null;
				}
			}
		}

        /// <summary>
		/// 得到一个对象实体
		/// </summary>
		public DWGX.Model.User GetUser(string name)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 id,name,nickName,passWord,addDate,lastLoginTime,lastLoginIP,loginCount,isValid,Limit from tb_User ");
            strSql.Append(" where name=@name ");
            SqlParameter[] parameters = {
                    new SqlParameter("@name", SqlDbType.NVarChar,50)};
            parameters[0].Value = name;

            DWGX.Model.User model = new DWGX.Model.User();
            using (SqlDataReader reader = SqlHelper.ExecuteReader(strSql.ToString(), parameters))
            {
                if (reader.HasRows)
                {
                    reader.Read();
                    model.id = reader.GetInt32(0);
                    model.name = reader.GetString(1);
                    model.nickName = reader.GetString(2);
                    model.passWord = reader.GetString(3);
                    model.addDate = reader.GetDateTime(4);
                    model.lastLoginTime = reader.GetDateTime(5);
                    model.lastLoginIP = reader.GetString(6);
                    model.loginCount = reader.GetInt32(7);
                    model.isValid = reader.GetBoolean(8);
                    model.Limit = reader.GetString(9);
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
			strSql.Append(" FROM tb_User ");
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
		/// <returns>IList User</returns>
		public IList<DWGX.Model.User> GetUsers(int p_pageIndex, int p_pageSize, string strWhere, out int p_recordCount)
		{
			IList<DWGX.Model.User> listUsers = new List<DWGX.Model.User>();
			string sTable = "tb_User";
			string sPkey = "id";
			string sField = "id,name,nickName,passWord,addDate,lastLoginTime,lastLoginIP,loginCount,isValid,Limit";
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
					return listUsers;
				}
				while (reader.Read())
				{
						DWGX.Model.User objUser = new DWGX.Model.User();
						objUser.id = reader.GetInt32(0);
						objUser.name = reader.GetString(1);
						objUser.nickName = reader.GetString(2);
						objUser.passWord = reader.GetString(3);
						objUser.addDate = reader.GetDateTime(4);
						objUser.lastLoginTime = reader.GetDateTime(5);
						objUser.lastLoginIP = reader.GetString(6);
						objUser.loginCount = reader.GetInt32(7);
						objUser.isValid = reader.GetBoolean(8);
						objUser.Limit = reader.GetString(9);
						listUsers.Add(objUser);
				}
			}
			return listUsers;
		}

		#endregion  成员方法
	}
}

