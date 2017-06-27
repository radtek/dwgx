using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using DWGX.Data;
using BCW.Common;


namespace DWGX.DAL
{
	/// <summary>
	/// 数据访问类News。
	/// </summary>
	public class News
	{
		public News()
		{}
		#region  成员方法

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return SqlHelper.GetMaxID("ID", "tb_News"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from tb_News");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			return SqlHelper.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(DWGX.Model.News model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into tb_News(");
			strSql.Append("cTitle,cLittleTitle,cTitleColor,cTitleB,cTitleU,cTitleSize,cTitleShow,dCreateTime,iViewCount,cContent,iTypeId,iCreatorId,cPicPath,cVideoPath,isPut,cPutPicPath,isPic,isScrollPic,cUrl)");
			strSql.Append(" values (");
			strSql.Append("@cTitle,@cLittleTitle,@cTitleColor,@cTitleB,@cTitleU,@cTitleSize,@cTitleShow,@dCreateTime,@iViewCount,@cContent,@iTypeId,@iCreatorId,@cPicPath,@cVideoPath,@isPut,@cPutPicPath,@isPic,@isScrollPic,@cUrl)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@cTitle", SqlDbType.VarChar,200),
					new SqlParameter("@cLittleTitle", SqlDbType.VarChar,200),
					new SqlParameter("@cTitleColor", SqlDbType.NVarChar,20),
					new SqlParameter("@cTitleB", SqlDbType.VarChar,2),
					new SqlParameter("@cTitleU", SqlDbType.VarChar,2),
					new SqlParameter("@cTitleSize", SqlDbType.VarChar,10),
					new SqlParameter("@cTitleShow", SqlDbType.VarChar,50),
					new SqlParameter("@dCreateTime", SqlDbType.DateTime),
					new SqlParameter("@iViewCount", SqlDbType.Int,4),
					new SqlParameter("@cContent", SqlDbType.Text),
					new SqlParameter("@iTypeId", SqlDbType.Int,4),
					new SqlParameter("@iCreatorId", SqlDbType.Int,4),
					new SqlParameter("@cPicPath", SqlDbType.VarChar,200),
					new SqlParameter("@cVideoPath", SqlDbType.VarChar,200),
					new SqlParameter("@isPut", SqlDbType.Bit,1),
					new SqlParameter("@cPutPicPath", SqlDbType.VarChar,50),
					new SqlParameter("@isPic", SqlDbType.Bit,1),
					new SqlParameter("@isScrollPic", SqlDbType.Bit,1),
					new SqlParameter("@cUrl", SqlDbType.VarChar,500)};
			parameters[0].Value = model.cTitle;
			parameters[1].Value = model.cLittleTitle;
			parameters[2].Value = model.cTitleColor;
			parameters[3].Value = model.cTitleB;
			parameters[4].Value = model.cTitleU;
			parameters[5].Value = model.cTitleSize;
			parameters[6].Value = model.cTitleShow;
			parameters[7].Value = model.dCreateTime;
			parameters[8].Value = model.iViewCount;
			parameters[9].Value = model.cContent;
			parameters[10].Value = model.iTypeId;
			parameters[11].Value = model.iCreatorId;
			parameters[12].Value = model.cPicPath;
			parameters[13].Value = model.cVideoPath;
			parameters[14].Value = model.isPut;
			parameters[15].Value = model.cPutPicPath;
			parameters[16].Value = model.isPic;
			parameters[17].Value = model.isScrollPic;
			parameters[18].Value = model.cUrl;

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
		public void Update(DWGX.Model.News model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update tb_News set ");
			strSql.Append("cTitle=@cTitle,");
			strSql.Append("cLittleTitle=@cLittleTitle,");
			strSql.Append("cTitleColor=@cTitleColor,");
			strSql.Append("cTitleB=@cTitleB,");
			strSql.Append("cTitleU=@cTitleU,");
			strSql.Append("cTitleSize=@cTitleSize,");
			strSql.Append("cTitleShow=@cTitleShow,");
			strSql.Append("dCreateTime=@dCreateTime,");
			strSql.Append("iViewCount=@iViewCount,");
			strSql.Append("cContent=@cContent,");
			strSql.Append("iTypeId=@iTypeId,");
			strSql.Append("iCreatorId=@iCreatorId,");
			strSql.Append("cPicPath=@cPicPath,");
			strSql.Append("cVideoPath=@cVideoPath,");
			strSql.Append("isPut=@isPut,");
			strSql.Append("cPutPicPath=@cPutPicPath,");
			strSql.Append("isPic=@isPic,");
			strSql.Append("isScrollPic=@isScrollPic,");
			strSql.Append("cUrl=@cUrl");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@cTitle", SqlDbType.VarChar,200),
					new SqlParameter("@cLittleTitle", SqlDbType.VarChar,200),
					new SqlParameter("@cTitleColor", SqlDbType.NVarChar,20),
					new SqlParameter("@cTitleB", SqlDbType.VarChar,2),
					new SqlParameter("@cTitleU", SqlDbType.VarChar,2),
					new SqlParameter("@cTitleSize", SqlDbType.VarChar,10),
					new SqlParameter("@cTitleShow", SqlDbType.VarChar,50),
					new SqlParameter("@dCreateTime", SqlDbType.DateTime),
					new SqlParameter("@iViewCount", SqlDbType.Int,4),
					new SqlParameter("@cContent", SqlDbType.Text),
					new SqlParameter("@iTypeId", SqlDbType.Int,4),
					new SqlParameter("@iCreatorId", SqlDbType.Int,4),
					new SqlParameter("@cPicPath", SqlDbType.VarChar,200),
					new SqlParameter("@cVideoPath", SqlDbType.VarChar,200),
					new SqlParameter("@isPut", SqlDbType.Bit,1),
					new SqlParameter("@cPutPicPath", SqlDbType.VarChar,50),
					new SqlParameter("@isPic", SqlDbType.Bit,1),
					new SqlParameter("@isScrollPic", SqlDbType.Bit,1),
					new SqlParameter("@cUrl", SqlDbType.VarChar,500)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.cTitle;
			parameters[2].Value = model.cLittleTitle;
			parameters[3].Value = model.cTitleColor;
			parameters[4].Value = model.cTitleB;
			parameters[5].Value = model.cTitleU;
			parameters[6].Value = model.cTitleSize;
			parameters[7].Value = model.cTitleShow;
			parameters[8].Value = model.dCreateTime;
			parameters[9].Value = model.iViewCount;
			parameters[10].Value = model.cContent;
			parameters[11].Value = model.iTypeId;
			parameters[12].Value = model.iCreatorId;
			parameters[13].Value = model.cPicPath;
			parameters[14].Value = model.cVideoPath;
			parameters[15].Value = model.isPut;
			parameters[16].Value = model.cPutPicPath;
			parameters[17].Value = model.isPic;
			parameters[18].Value = model.isScrollPic;
			parameters[19].Value = model.cUrl;

			SqlHelper.ExecuteSql(strSql.ToString(),parameters);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from tb_News ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			SqlHelper.ExecuteSql(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public DWGX.Model.News GetNews(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,cTitle,cLittleTitle,cTitleColor,cTitleB,cTitleU,cTitleSize,cTitleShow,dCreateTime,iViewCount,cContent,iTypeId,iCreatorId,cPicPath,cVideoPath,isPut,cPutPicPath,isPic,isScrollPic,cUrl from tb_News ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			DWGX.Model.News model=new DWGX.Model.News();
			using (SqlDataReader reader=SqlHelper.ExecuteReader(strSql.ToString(),parameters))
			{
				if (reader.HasRows)
				{
					reader.Read();
					model.ID = reader.GetInt32(0);
					model.cTitle = reader.GetString(1);
					model.cLittleTitle = reader.GetString(2);
					model.cTitleColor = reader.GetString(3);
					model.cTitleB = reader.GetString(4);
					model.cTitleU = reader.GetString(5);
					model.cTitleSize = reader.GetString(6);
					model.cTitleShow = reader.GetString(7);
					model.dCreateTime = reader.GetDateTime(8);
					model.iViewCount = reader.GetInt32(9);
					model.cContent = reader.GetString(10);
					model.iTypeId = reader.GetInt32(11);
					model.iCreatorId = reader.GetInt32(12);
					model.cPicPath = reader.GetString(13);
					model.cVideoPath = reader.GetString(14);
					model.isPut = reader.GetBoolean(15);
					model.cPutPicPath = reader.GetString(16);
					model.isPic = reader.GetBoolean(17);
					model.isScrollPic = reader.GetBoolean(18);
					model.cUrl = reader.GetString(19);
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
			strSql.Append(" FROM tb_News ");
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
		/// <returns>IList News</returns>
		public IList<DWGX.Model.News> GetNewss(int p_pageIndex, int p_pageSize, string strWhere, out int p_recordCount)
		{
			IList<DWGX.Model.News> listNewss = new List<DWGX.Model.News>();
			string sTable = "tb_News";
			string sPkey = "id";
			string sField = "ID,cTitle,cLittleTitle,cTitleColor,cTitleB,cTitleU,cTitleSize,cTitleShow,dCreateTime,iViewCount,cContent,iTypeId,iCreatorId,cPicPath,cVideoPath,isPut,cPutPicPath,isPic,isScrollPic,cUrl";
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
					return listNewss;
				}
				while (reader.Read())
				{
						DWGX.Model.News objNews = new DWGX.Model.News();
						objNews.ID = reader.GetInt32(0);
						objNews.cTitle = reader.GetString(1);
						objNews.cLittleTitle = reader.GetString(2);
						objNews.cTitleColor = reader.GetString(3);
						objNews.cTitleB = reader.GetString(4);
						objNews.cTitleU = reader.GetString(5);
						objNews.cTitleSize = reader.GetString(6);
						objNews.cTitleShow = reader.GetString(7);
						objNews.dCreateTime = reader.GetDateTime(8);
						objNews.iViewCount = reader.GetInt32(9);
						objNews.cContent = reader.GetString(10);
						objNews.iTypeId = reader.GetInt32(11);
						objNews.iCreatorId = reader.GetInt32(12);
						objNews.cPicPath = reader.GetString(13);
						objNews.cVideoPath = reader.GetString(14);
						objNews.isPut = reader.GetBoolean(15);
						objNews.cPutPicPath = reader.GetString(16);
						objNews.isPic = reader.GetBoolean(17);
						objNews.isScrollPic = reader.GetBoolean(18);
						objNews.cUrl = reader.GetString(19);
						listNewss.Add(objNews);
				}
			}
			return listNewss;
		}

        public IList<DWGX.Model.viewNews> GetNewsPages(int p_pageIndex, int p_pageSize, string strWhere, out int p_recordCount)
        {
            IList<DWGX.Model.viewNews> listViewNews = new List<DWGX.Model.viewNews>();

            // 计算记录数
            string countString = "SELECT COUNT(*) FROM v_news where " + strWhere + "";

            p_recordCount = Convert.ToInt32(SqlHelper.GetSingle(countString));

            if (p_recordCount > 0)
            {
                int pageCount = BasePage.CalcPageCount(p_recordCount, p_pageSize, ref p_pageIndex);
            }
            else
            {
                return listViewNews;
            }

            // 取出相关记录
            string queryString = "";

            queryString = "select * from v_news where " + strWhere + "order by dCreateTime desc";
            using (SqlDataReader reader = SqlHelper.ExecuteReader(queryString))
            {
                int stratIndex = (p_pageIndex - 1) * p_pageSize;
                int endIndex = p_pageIndex * p_pageSize;
                int k = 0;

                while (reader.Read())
                {
                    if (k >= stratIndex && k < endIndex)
                    {
                        Model.viewNews vNews = new Model.viewNews();
                        vNews.ID = reader.GetInt32(0);
                        vNews.cTitle = reader.GetString(1);
                        vNews.iTypeId = reader.GetInt32(2);
                        vNews.cTypeName = reader.GetString(3);
                        vNews.isPut = reader.GetBoolean(4);
                        vNews.isScrollPic = reader.GetBoolean(5);
                        vNews.isPic = reader.GetBoolean(6);
                        vNews.iViewCount = reader.GetInt32(7);
                        vNews.dCreateTime = reader.GetDateTime(8);

                        listViewNews.Add(vNews);
                    }
                    if (k == endIndex)
                        break;

                    k++;
                }
            }

            return listViewNews;
        }


        #endregion  成员方法
    }
}

