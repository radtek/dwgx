using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using DWGX.Data;//Please add references
namespace DWGX.DAL
{
	/// <summary>
	/// 数据访问类:NewsType
	/// </summary>
	public partial class NewsType
	{
		public NewsType()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return SqlHelper.GetMaxID("ID", "tb_NewsType"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from tb_NewsType");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			return SqlHelper.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(DWGX.Model.NewsType model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into tb_NewsType(");
			strSql.Append("cTypeName,iClassId,iDesc,dCreateTime,cPic,iShow,parentid)");
			strSql.Append(" values (");
			strSql.Append("@cTypeName,@iClassId,@iDesc,@dCreateTime,@cPic,@iShow,@parentid)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@cTypeName", SqlDbType.VarChar,50),
					new SqlParameter("@iClassId", SqlDbType.Int,4),
					new SqlParameter("@iDesc", SqlDbType.Int,4),
					new SqlParameter("@dCreateTime", SqlDbType.DateTime),
					new SqlParameter("@cPic", SqlDbType.VarChar,50),
					new SqlParameter("@iShow", SqlDbType.Int,4),
					new SqlParameter("@parentid", SqlDbType.Int,4)};
			parameters[0].Value = model.cTypeName;
			parameters[1].Value = model.iClassId;
			parameters[2].Value = model.iDesc;
			parameters[3].Value = model.dCreateTime;
			parameters[4].Value = model.cPic;
			parameters[5].Value = model.iShow;
			parameters[6].Value = model.parentid;

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
		public bool Update(DWGX.Model.NewsType model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update tb_NewsType set ");
			strSql.Append("cTypeName=@cTypeName,");
			strSql.Append("iClassId=@iClassId,");
			strSql.Append("iDesc=@iDesc,");
			strSql.Append("dCreateTime=@dCreateTime,");
			strSql.Append("cPic=@cPic,");
			strSql.Append("iShow=@iShow,");
			strSql.Append("parentid=@parentid");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@cTypeName", SqlDbType.VarChar,50),
					new SqlParameter("@iClassId", SqlDbType.Int,4),
					new SqlParameter("@iDesc", SqlDbType.Int,4),
					new SqlParameter("@dCreateTime", SqlDbType.DateTime),
					new SqlParameter("@cPic", SqlDbType.VarChar,50),
					new SqlParameter("@iShow", SqlDbType.Int,4),
					new SqlParameter("@parentid", SqlDbType.Int,4),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.cTypeName;
			parameters[1].Value = model.iClassId;
			parameters[2].Value = model.iDesc;
			parameters[3].Value = model.dCreateTime;
			parameters[4].Value = model.cPic;
			parameters[5].Value = model.iShow;
			parameters[6].Value = model.parentid;
			parameters[7].Value = model.ID;

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
		public bool Delete(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from tb_NewsType ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

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
		public bool DeleteList(string IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from tb_NewsType ");
			strSql.Append(" where ID in ("+IDlist + ")  ");
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
		public DWGX.Model.NewsType GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,cTypeName,iClassId,iDesc,dCreateTime,cPic,iShow,parentid from tb_NewsType ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			DWGX.Model.NewsType model=new DWGX.Model.NewsType();
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
		public DWGX.Model.NewsType DataRowToModel(DataRow row)
		{
			DWGX.Model.NewsType model=new DWGX.Model.NewsType();
			if (row != null)
			{
				if(row["ID"]!=null && row["ID"].ToString()!="")
				{
					model.ID=int.Parse(row["ID"].ToString());
				}
				if(row["cTypeName"]!=null)
				{
					model.cTypeName=row["cTypeName"].ToString();
				}
				if(row["iClassId"]!=null && row["iClassId"].ToString()!="")
				{
					model.iClassId=int.Parse(row["iClassId"].ToString());
				}
				if(row["iDesc"]!=null && row["iDesc"].ToString()!="")
				{
					model.iDesc=int.Parse(row["iDesc"].ToString());
				}
				if(row["dCreateTime"]!=null && row["dCreateTime"].ToString()!="")
				{
					model.dCreateTime=DateTime.Parse(row["dCreateTime"].ToString());
				}
				if(row["cPic"]!=null)
				{
					model.cPic=row["cPic"].ToString();
				}
				if(row["iShow"]!=null && row["iShow"].ToString()!="")
				{
					model.iShow=int.Parse(row["iShow"].ToString());
				}
				if(row["parentid"]!=null && row["parentid"].ToString()!="")
				{
					model.parentid=int.Parse(row["parentid"].ToString());
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
			strSql.Append("select ID,cTypeName,iClassId,iDesc,dCreateTime,cPic,iShow,parentid ");
			strSql.Append(" FROM tb_NewsType ");
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
			strSql.Append(" ID,cTypeName,iClassId,iDesc,dCreateTime,cPic,iShow,parentid ");
			strSql.Append(" FROM tb_NewsType ");
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
			strSql.Append("select count(1) FROM tb_NewsType ");
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
				strSql.Append("order by T.ID desc");
			}
			strSql.Append(")AS Row, T.*  from tb_NewsType T ");
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
			parameters[0].Value = "tb_NewsType";
			parameters[1].Value = "ID";
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

