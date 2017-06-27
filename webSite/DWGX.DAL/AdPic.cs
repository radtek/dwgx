using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using DWGX.Data;

namespace DWGX.DAL
{
	/// <summary>
	/// 数据访问类AdPic。
	/// </summary>
	public class AdPic
	{
		public AdPic()
		{}
		#region  成员方法

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return SqlHelper.GetMaxID("Id", "tb_AdPic"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from tb_AdPic");
			strSql.Append(" where Id=@Id ");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)};
			parameters[0].Value = Id;

			return SqlHelper.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(DWGX.Model.AdPic model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into tb_AdPic(");
			strSql.Append("iDesc,cWidth,cHeight,cLink,cAlt,cText,cType,cPath,cShow,dCreateTime)");
			strSql.Append(" values (");
			strSql.Append("@iDesc,@cWidth,@cHeight,@cLink,@cAlt,@cText,@cType,@cPath,@cShow,@dCreateTime)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@iDesc", SqlDbType.Int,4),
					new SqlParameter("@cWidth", SqlDbType.VarChar,50),
					new SqlParameter("@cHeight", SqlDbType.VarChar,50),
					new SqlParameter("@cLink", SqlDbType.VarChar,100),
					new SqlParameter("@cAlt", SqlDbType.VarChar,100),
					new SqlParameter("@cText", SqlDbType.VarChar,100),
					new SqlParameter("@cType", SqlDbType.VarChar,10),
					new SqlParameter("@cPath", SqlDbType.VarChar,100),
					new SqlParameter("@cShow", SqlDbType.Int,4),
					new SqlParameter("@dCreateTime", SqlDbType.DateTime)};
			parameters[0].Value = model.iDesc;
			parameters[1].Value = model.cWidth;
			parameters[2].Value = model.cHeight;
			parameters[3].Value = model.cLink;
			parameters[4].Value = model.cAlt;
			parameters[5].Value = model.cText;
			parameters[6].Value = model.cType;
			parameters[7].Value = model.cPath;
			parameters[8].Value = model.cShow;
			parameters[9].Value = model.dCreateTime;

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
		public void Update(DWGX.Model.AdPic model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update tb_AdPic set ");
			strSql.Append("iDesc=@iDesc,");
			strSql.Append("cWidth=@cWidth,");
			strSql.Append("cHeight=@cHeight,");
			strSql.Append("cLink=@cLink,");
			strSql.Append("cAlt=@cAlt,");
			strSql.Append("cText=@cText,");
			strSql.Append("cType=@cType,");
			strSql.Append("cPath=@cPath,");
			strSql.Append("cShow=@cShow,");
			strSql.Append("dCreateTime=@dCreateTime");
			strSql.Append(" where Id=@Id ");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4),
					new SqlParameter("@iDesc", SqlDbType.Int,4),
					new SqlParameter("@cWidth", SqlDbType.VarChar,50),
					new SqlParameter("@cHeight", SqlDbType.VarChar,50),
					new SqlParameter("@cLink", SqlDbType.VarChar,100),
					new SqlParameter("@cAlt", SqlDbType.VarChar,100),
					new SqlParameter("@cText", SqlDbType.VarChar,100),
					new SqlParameter("@cType", SqlDbType.VarChar,10),
					new SqlParameter("@cPath", SqlDbType.VarChar,100),
					new SqlParameter("@cShow", SqlDbType.Int,4),
					new SqlParameter("@dCreateTime", SqlDbType.DateTime)};
			parameters[0].Value = model.Id;
			parameters[1].Value = model.iDesc;
			parameters[2].Value = model.cWidth;
			parameters[3].Value = model.cHeight;
			parameters[4].Value = model.cLink;
			parameters[5].Value = model.cAlt;
			parameters[6].Value = model.cText;
			parameters[7].Value = model.cType;
			parameters[8].Value = model.cPath;
			parameters[9].Value = model.cShow;
			parameters[10].Value = model.dCreateTime;

			SqlHelper.ExecuteSql(strSql.ToString(),parameters);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(int Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from tb_AdPic ");
			strSql.Append(" where Id=@Id ");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)};
			parameters[0].Value = Id;

			SqlHelper.ExecuteSql(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public DWGX.Model.AdPic GetAdPic(int Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 Id,iDesc,cWidth,cHeight,cLink,cAlt,cText,cType,cPath,cShow,dCreateTime from tb_AdPic ");
			strSql.Append(" where Id=@Id ");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)};
			parameters[0].Value = Id;

			DWGX.Model.AdPic model=new DWGX.Model.AdPic();
			using (SqlDataReader reader=SqlHelper.ExecuteReader(strSql.ToString(),parameters))
			{
				if (reader.HasRows)
				{
					reader.Read();
					model.Id = reader.GetInt32(0);
					model.iDesc = reader.GetInt32(1);
					model.cWidth = reader.GetString(2);
					model.cHeight = reader.GetString(3);
					model.cLink = reader.GetString(4);
					model.cAlt = reader.GetString(5);
					model.cText = reader.GetString(6);
					model.cType = reader.GetString(7);
					model.cPath = reader.GetString(8);
					model.cShow = reader.GetInt32(9);
					model.dCreateTime = reader.GetDateTime(10);
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
			strSql.Append(" FROM tb_AdPic ");
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
		/// <returns>IList AdPic</returns>
		public IList<DWGX.Model.AdPic> GetAdPics(int p_pageIndex, int p_pageSize, string strWhere, out int p_recordCount)
		{
			IList<DWGX.Model.AdPic> listAdPics = new List<DWGX.Model.AdPic>();
			string sTable = "tb_AdPic";
			string sPkey = "id";
			string sField = "Id,iDesc,cWidth,cHeight,cLink,cAlt,cText,cType,cPath,cShow,dCreateTime";
			string sCondition = strWhere;
			string sOrder = "ID Desc";
			int iSCounts = 0;
			using (SqlDataReader reader = SqlHelper.RunProcedureMe(sTable, sPkey, sField, p_pageIndex, p_pageSize, sCondition, sOrder, iSCounts, out p_recordCount))
			{
				//计算总页数
				if (p_recordCount > 0)
				{
                    int pageCount = 10;// BasePage.CalcPageCount(p_recordCount, p_pageSize, ref p_pageIndex);
				}
				else
				{
					return listAdPics;
				}
				while (reader.Read())
				{
						DWGX.Model.AdPic objAdPic = new DWGX.Model.AdPic();
						objAdPic.Id = reader.GetInt32(0);
						objAdPic.iDesc = reader.GetInt32(1);
						objAdPic.cWidth = reader.GetString(2);
						objAdPic.cHeight = reader.GetString(3);
						objAdPic.cLink = reader.GetString(4);
						objAdPic.cAlt = reader.GetString(5);
						objAdPic.cText = reader.GetString(6);
						objAdPic.cType = reader.GetString(7);
						objAdPic.cPath = reader.GetString(8);
						objAdPic.cShow = reader.GetInt32(9);
						objAdPic.dCreateTime = reader.GetDateTime(10);
						listAdPics.Add(objAdPic);
				}
			}
			return listAdPics;
		}

		#endregion  成员方法
	}
}

