using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using DWGX.Data;


namespace DWGX.DAL
{
	/// <summary>
	/// 数据访问类Water。
	/// </summary>
	public class Water
	{
		public Water()
		{}
		#region  成员方法

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return SqlHelper.GetMaxID("ID", "tb_Water"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from tb_Water");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			return SqlHelper.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(DWGX.Model.Water model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into tb_Water(");
			strSql.Append("cWord,cPicPath,iRunType,isStart,iPos,iQuality,cFontName,iFontSize,cFontColor,cPic,iTransparency)");
			strSql.Append(" values (");
			strSql.Append("@cWord,@cPicPath,@iRunType,@isStart,@iPos,@iQuality,@cFontName,@iFontSize,@cFontColor,@cPic,@iTransparency)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@cWord", SqlDbType.VarChar,50),
					new SqlParameter("@cPicPath", SqlDbType.VarChar,50),
					new SqlParameter("@iRunType", SqlDbType.Int,4),
					new SqlParameter("@isStart", SqlDbType.Bit,1),
					new SqlParameter("@iPos", SqlDbType.Int,4),
					new SqlParameter("@iQuality", SqlDbType.Int,4),
					new SqlParameter("@cFontName", SqlDbType.VarChar,50),
					new SqlParameter("@iFontSize", SqlDbType.Int,4),
					new SqlParameter("@cFontColor", SqlDbType.VarChar,50),
					new SqlParameter("@cPic", SqlDbType.VarChar,50),
					new SqlParameter("@iTransparency", SqlDbType.Int,4)};
			parameters[0].Value = model.cWord;
			parameters[1].Value = model.cPicPath;
			parameters[2].Value = model.iRunType;
			parameters[3].Value = model.isStart;
			parameters[4].Value = model.iPos;
			parameters[5].Value = model.iQuality;
			parameters[6].Value = model.cFontName;
			parameters[7].Value = model.iFontSize;
			parameters[8].Value = model.cFontColor;
			parameters[9].Value = model.cPic;
			parameters[10].Value = model.iTransparency;

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
		public void Update(DWGX.Model.Water model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update tb_Water set ");
			strSql.Append("cWord=@cWord,");
			strSql.Append("cPicPath=@cPicPath,");
			strSql.Append("iRunType=@iRunType,");
			strSql.Append("isStart=@isStart,");
			strSql.Append("iPos=@iPos,");
			strSql.Append("iQuality=@iQuality,");
			strSql.Append("cFontName=@cFontName,");
			strSql.Append("iFontSize=@iFontSize,");
			strSql.Append("cFontColor=@cFontColor,");
			strSql.Append("cPic=@cPic,");
			strSql.Append("iTransparency=@iTransparency");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@cWord", SqlDbType.VarChar,50),
					new SqlParameter("@cPicPath", SqlDbType.VarChar,50),
					new SqlParameter("@iRunType", SqlDbType.Int,4),
					new SqlParameter("@isStart", SqlDbType.Bit,1),
					new SqlParameter("@iPos", SqlDbType.Int,4),
					new SqlParameter("@iQuality", SqlDbType.Int,4),
					new SqlParameter("@cFontName", SqlDbType.VarChar,50),
					new SqlParameter("@iFontSize", SqlDbType.Int,4),
					new SqlParameter("@cFontColor", SqlDbType.VarChar,50),
					new SqlParameter("@cPic", SqlDbType.VarChar,50),
					new SqlParameter("@iTransparency", SqlDbType.Int,4)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.cWord;
			parameters[2].Value = model.cPicPath;
			parameters[3].Value = model.iRunType;
			parameters[4].Value = model.isStart;
			parameters[5].Value = model.iPos;
			parameters[6].Value = model.iQuality;
			parameters[7].Value = model.cFontName;
			parameters[8].Value = model.iFontSize;
			parameters[9].Value = model.cFontColor;
			parameters[10].Value = model.cPic;
			parameters[11].Value = model.iTransparency;

			SqlHelper.ExecuteSql(strSql.ToString(),parameters);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from tb_Water ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			SqlHelper.ExecuteSql(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public DWGX.Model.Water GetWater(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,cWord,cPicPath,iRunType,isStart,iPos,iQuality,cFontName,iFontSize,cFontColor,cPic,iTransparency from tb_Water ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			DWGX.Model.Water model=new DWGX.Model.Water();
			using (SqlDataReader reader=SqlHelper.ExecuteReader(strSql.ToString(),parameters))
			{
				if (reader.HasRows)
				{
					reader.Read();
					model.ID = reader.GetInt32(0);
					model.cWord = reader.GetString(1);
					model.cPicPath = reader.GetString(2);
					model.iRunType = reader.GetInt32(3);
					model.isStart = reader.GetBoolean(4);
					model.iPos = reader.GetInt32(5);
					model.iQuality = reader.GetInt32(6);
					model.cFontName = reader.GetString(7);
					model.iFontSize = reader.GetInt32(8);
					model.cFontColor = reader.GetString(9);
					model.cPic = reader.GetString(10);
					model.iTransparency = reader.GetInt32(11);
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
			strSql.Append(" FROM tb_Water ");
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
		/// <returns>IList Water</returns>
		public IList<DWGX.Model.Water> GetWaters(int p_pageIndex, int p_pageSize, string strWhere, out int p_recordCount)
		{
			IList<DWGX.Model.Water> listWaters = new List<DWGX.Model.Water>();
			string sTable = "tb_Water";
			string sPkey = "id";
			string sField = "ID,cWord,cPicPath,iRunType,isStart,iPos,iQuality,cFontName,iFontSize,cFontColor,cPic,iTransparency";
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
					return listWaters;
				}
				while (reader.Read())
				{
						DWGX.Model.Water objWater = new DWGX.Model.Water();
						objWater.ID = reader.GetInt32(0);
						objWater.cWord = reader.GetString(1);
						objWater.cPicPath = reader.GetString(2);
						objWater.iRunType = reader.GetInt32(3);
						objWater.isStart = reader.GetBoolean(4);
						objWater.iPos = reader.GetInt32(5);
						objWater.iQuality = reader.GetInt32(6);
						objWater.cFontName = reader.GetString(7);
						objWater.iFontSize = reader.GetInt32(8);
						objWater.cFontColor = reader.GetString(9);
						objWater.cPic = reader.GetString(10);
						objWater.iTransparency = reader.GetInt32(11);
						listWaters.Add(objWater);
				}
			}
			return listWaters;
		}

		#endregion  成员方法
	}
}

