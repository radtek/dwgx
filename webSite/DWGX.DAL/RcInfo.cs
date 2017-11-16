using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using DWGX.Data;//Please add references
namespace DWGX.DAL
{
	/// <summary>
	/// 数据访问类:RcInfo
	/// </summary>
	public partial class RcInfo
	{
		public RcInfo()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(DWGX.Model.RcInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into tb_RcInfo(");
			strSql.Append("companyName,jobName,jobType,amount,sex,age,rofs,major,jobobject,titleRequire,statureRequire,areaRequire,certificatesRequire,createTime,significantInterval,jobAddr,salary,compnyAddr,phone,others,updateTime)");
			strSql.Append(" values (");
			strSql.Append("@companyName,@jobName,@jobType,@amount,@sex,@age,@rofs,@major,@jobobject,@titleRequire,@statureRequire,@areaRequire,@certificatesRequire,@createTime,@significantInterval,@jobAddr,@salary,@compnyAddr,@phone,@others,@updateTime)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@companyName", SqlDbType.NVarChar,100),
					new SqlParameter("@jobName", SqlDbType.NVarChar,100),
					new SqlParameter("@jobType", SqlDbType.NVarChar,50),
					new SqlParameter("@amount", SqlDbType.Int,4),
					new SqlParameter("@sex", SqlDbType.Int,4),
					new SqlParameter("@age", SqlDbType.Int,4),
					new SqlParameter("@rofs", SqlDbType.NVarChar,100),
					new SqlParameter("@major", SqlDbType.NVarChar,500),
					new SqlParameter("@jobobject", SqlDbType.NVarChar,50),
					new SqlParameter("@titleRequire", SqlDbType.NVarChar,50),
					new SqlParameter("@statureRequire", SqlDbType.NVarChar,50),
					new SqlParameter("@areaRequire", SqlDbType.NVarChar,100),
					new SqlParameter("@certificatesRequire", SqlDbType.NVarChar,100),
					new SqlParameter("@createTime", SqlDbType.DateTime),
					new SqlParameter("@significantInterval", SqlDbType.NVarChar,100),
					new SqlParameter("@jobAddr", SqlDbType.NVarChar,500),
					new SqlParameter("@salary", SqlDbType.NVarChar,50),
					new SqlParameter("@compnyAddr", SqlDbType.NVarChar,500),
					new SqlParameter("@phone", SqlDbType.NVarChar,100),
					new SqlParameter("@others", SqlDbType.NVarChar,1000),
					new SqlParameter("@updateTime", SqlDbType.DateTime)};
			parameters[0].Value = model.companyName;
			parameters[1].Value = model.jobName;
			parameters[2].Value = model.jobType;
			parameters[3].Value = model.amount;
			parameters[4].Value = model.sex;
			parameters[5].Value = model.age;
			parameters[6].Value = model.rofs;
			parameters[7].Value = model.major;
			parameters[8].Value = model.jobobject;
			parameters[9].Value = model.titleRequire;
			parameters[10].Value = model.statureRequire;
			parameters[11].Value = model.areaRequire;
			parameters[12].Value = model.certificatesRequire;
			parameters[13].Value = model.createTime;
			parameters[14].Value = model.significantInterval;
			parameters[15].Value = model.jobAddr;
			parameters[16].Value = model.salary;
			parameters[17].Value = model.compnyAddr;
			parameters[18].Value = model.phone;
			parameters[19].Value = model.others;
			parameters[20].Value = model.updateTime;

			object obj = SqlHelper.GetSingle(strSql.ToString(),parameters);
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(DWGX.Model.RcInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update tb_RcInfo set ");
			strSql.Append("companyName=@companyName,");
			strSql.Append("jobName=@jobName,");
			strSql.Append("jobType=@jobType,");
			strSql.Append("amount=@amount,");
			strSql.Append("sex=@sex,");
			strSql.Append("age=@age,");
			strSql.Append("rofs=@rofs,");
			strSql.Append("major=@major,");
			strSql.Append("jobobject=@jobobject,");
			strSql.Append("titleRequire=@titleRequire,");
			strSql.Append("statureRequire=@statureRequire,");
			strSql.Append("areaRequire=@areaRequire,");
			strSql.Append("certificatesRequire=@certificatesRequire,");
			strSql.Append("createTime=@createTime,");
			strSql.Append("significantInterval=@significantInterval,");
			strSql.Append("jobAddr=@jobAddr,");
			strSql.Append("salary=@salary,");
			strSql.Append("compnyAddr=@compnyAddr,");
			strSql.Append("phone=@phone,");
			strSql.Append("others=@others,");
			strSql.Append("updateTime=@updateTime");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@companyName", SqlDbType.NVarChar,100),
					new SqlParameter("@jobName", SqlDbType.NVarChar,100),
					new SqlParameter("@jobType", SqlDbType.NVarChar,50),
					new SqlParameter("@amount", SqlDbType.Int,4),
					new SqlParameter("@sex", SqlDbType.Int,4),
					new SqlParameter("@age", SqlDbType.Int,4),
					new SqlParameter("@rofs", SqlDbType.NVarChar,100),
					new SqlParameter("@major", SqlDbType.NVarChar,500),
					new SqlParameter("@jobobject", SqlDbType.NVarChar,50),
					new SqlParameter("@titleRequire", SqlDbType.NVarChar,50),
					new SqlParameter("@statureRequire", SqlDbType.NVarChar,50),
					new SqlParameter("@areaRequire", SqlDbType.NVarChar,100),
					new SqlParameter("@certificatesRequire", SqlDbType.NVarChar,100),
					new SqlParameter("@createTime", SqlDbType.DateTime),
					new SqlParameter("@significantInterval", SqlDbType.NVarChar,100),
					new SqlParameter("@jobAddr", SqlDbType.NVarChar,500),
					new SqlParameter("@salary", SqlDbType.NVarChar,50),
					new SqlParameter("@compnyAddr", SqlDbType.NVarChar,500),
					new SqlParameter("@phone", SqlDbType.NVarChar,100),
					new SqlParameter("@others", SqlDbType.NVarChar,1000),
					new SqlParameter("@updateTime", SqlDbType.DateTime),
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = model.companyName;
			parameters[1].Value = model.jobName;
			parameters[2].Value = model.jobType;
			parameters[3].Value = model.amount;
			parameters[4].Value = model.sex;
			parameters[5].Value = model.age;
			parameters[6].Value = model.rofs;
			parameters[7].Value = model.major;
			parameters[8].Value = model.jobobject;
			parameters[9].Value = model.titleRequire;
			parameters[10].Value = model.statureRequire;
			parameters[11].Value = model.areaRequire;
			parameters[12].Value = model.certificatesRequire;
			parameters[13].Value = model.createTime;
			parameters[14].Value = model.significantInterval;
			parameters[15].Value = model.jobAddr;
			parameters[16].Value = model.salary;
			parameters[17].Value = model.compnyAddr;
			parameters[18].Value = model.phone;
			parameters[19].Value = model.others;
			parameters[20].Value = model.updateTime;
			parameters[21].Value = model.id;

			int rows=SqlHelper.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from tb_RcInfo ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			int rows=SqlHelper.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from tb_RcInfo ");
			strSql.Append(" where id in ("+idlist + ")  ");
			int rows=SqlHelper.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public DWGX.Model.RcInfo GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,companyName,jobName,jobType,amount,sex,age,rofs,major,jobobject,titleRequire,statureRequire,areaRequire,certificatesRequire,createTime,significantInterval,jobAddr,salary,compnyAddr,phone,others,updateTime from tb_RcInfo ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			DWGX.Model.RcInfo model=new DWGX.Model.RcInfo();
			DataSet ds=SqlHelper.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public DWGX.Model.RcInfo DataRowToModel(DataRow row)
		{
			DWGX.Model.RcInfo model=new DWGX.Model.RcInfo();
			if (row != null)
			{
				if(row["id"]!=null && row["id"].ToString()!="")
				{
					model.id=int.Parse(row["id"].ToString());
				}
				if(row["companyName"]!=null)
				{
					model.companyName=row["companyName"].ToString();
				}
				if(row["jobName"]!=null)
				{
					model.jobName=row["jobName"].ToString();
				}
				if(row["jobType"]!=null)
				{
					model.jobType=row["jobType"].ToString();
				}
				if(row["amount"]!=null && row["amount"].ToString()!="")
				{
					model.amount=int.Parse(row["amount"].ToString());
				}
				if(row["sex"]!=null && row["sex"].ToString()!="")
				{
					model.sex=int.Parse(row["sex"].ToString());
				}
				if(row["age"]!=null && row["age"].ToString()!="")
				{
					model.age=int.Parse(row["age"].ToString());
				}
				if(row["rofs"]!=null)
				{
					model.rofs=row["rofs"].ToString();
				}
				if(row["major"]!=null)
				{
					model.major=row["major"].ToString();
				}
				if(row["jobobject"]!=null)
				{
					model.jobobject=row["jobobject"].ToString();
				}
				if(row["titleRequire"]!=null)
				{
					model.titleRequire=row["titleRequire"].ToString();
				}
				if(row["statureRequire"]!=null)
				{
					model.statureRequire=row["statureRequire"].ToString();
				}
				if(row["areaRequire"]!=null)
				{
					model.areaRequire=row["areaRequire"].ToString();
				}
				if(row["certificatesRequire"]!=null)
				{
					model.certificatesRequire=row["certificatesRequire"].ToString();
				}
				if(row["createTime"]!=null && row["createTime"].ToString()!="")
				{
					model.createTime=DateTime.Parse(row["createTime"].ToString());
				}
				if(row["significantInterval"]!=null)
				{
					model.significantInterval=row["significantInterval"].ToString();
				}
				if(row["jobAddr"]!=null)
				{
					model.jobAddr=row["jobAddr"].ToString();
				}
				if(row["salary"]!=null)
				{
					model.salary=row["salary"].ToString();
				}
				if(row["compnyAddr"]!=null)
				{
					model.compnyAddr=row["compnyAddr"].ToString();
				}
				if(row["phone"]!=null)
				{
					model.phone=row["phone"].ToString();
				}
				if(row["others"]!=null)
				{
					model.others=row["others"].ToString();
				}
				if(row["updateTime"]!=null && row["updateTime"].ToString()!="")
				{
					model.updateTime=DateTime.Parse(row["updateTime"].ToString());
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select id,companyName,jobName,jobType,amount,sex,age,rofs,major,jobobject,titleRequire,statureRequire,areaRequire,certificatesRequire,createTime,significantInterval,jobAddr,salary,compnyAddr,phone,others,updateTime ");
			strSql.Append(" FROM tb_RcInfo ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return SqlHelper.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" id,companyName,jobName,jobType,amount,sex,age,rofs,major,jobobject,titleRequire,statureRequire,areaRequire,certificatesRequire,createTime,significantInterval,jobAddr,salary,compnyAddr,phone,others,updateTime ");
			strSql.Append(" FROM tb_RcInfo ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return SqlHelper.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM tb_RcInfo ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = SqlHelper.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.id desc");
			}
			strSql.Append(")AS Row, T.*  from tb_RcInfo T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return SqlHelper.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "tb_RcInfo";
			parameters[1].Value = "id";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return SqlHelper.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

