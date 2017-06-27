using System;
using System.Configuration;
using System.Security.Cryptography;
using System.IO;


namespace DWGX.Data
{
    
    public class PubConstant
    {        
        /// <summary>
        /// ��ȡ�����ַ�������վʹ�ã�
        /// </summary>
        public static string ConnectionString
        {           
            get 
            {
                string DataBaseServer = GetConnectionString("server"); 
                string DataBaseName = GetConnectionString("database");
                string DataBaseUid = GetConnectionString("uid");
                string DataBasePwd = GetConnectionString("pwd");

                //string _connectionString = "server=" + DataBaseServer + ";database=" + DataBaseName + ";uid=" + DataBaseUid + ";pwd=" + DataBasePwd + ";";
                string _connectionString = "data source=" + DataBaseServer + ";UID=" + DataBaseUid + ";pwd=" + DataBasePwd + ";Initial Catalog=" + DataBaseName + ";";
                return _connectionString;
            }
        }

        /// <summary>
        /// ��ȡ�����ַ����������Ա����ʹ�ã�
        /// </summary>
        public static string ConnectionStringUser
        {
            get
            {
                string DataBaseServer = string.Empty;
                DataBaseServer = GetConnectionString("server");
                if (!string.IsNullOrEmpty(DataBaseServer))
                {
                    string DataBaseName = GetConnectionString("database");
                    string DataBaseUid = GetConnectionString("uid");
                    string DataBasePwd = GetConnectionString("pwd");

                    string _connectionString = "server=" + DataBaseServer + ";database=" + DataBaseName + ";uid=" + DataBaseUid + ";pwd=" + DataBasePwd + ";";
                    return _connectionString;
                }
                else
                {
                    return ConnectionString;
                }
            }
        }



        /// <summary>
        /// ��ȡ�����ַ����������Ա����ʹ�ã�
        /// </summary>
        public static string ConnectionStringBook
        {
            get
            {
                string DataBaseServer = string.Empty;
                DataBaseServer = GetConnectionString("DataBaseServerBook");
                if (!string.IsNullOrEmpty(DataBaseServer))
                {

                    string DataBaseName = GetConnectionString("DataBaseNameBook");
                    string DataBaseUid = GetConnectionString("DataBaseUidBook");
                    string DataBasePwd = GetConnectionString("DataBasePwdBook");

                    string _connectionString = "server=" + DataBaseServer + ";database=" + DataBaseName + ";uid=" + DataBaseUid + ";pwd=" + DataBasePwd + ";";
                    return _connectionString;
                }
                else
                {
                    return ConnectionString;
                }
            }
        }

        /// <summary>
        /// �õ�web.config������������ݿ������ַ�����
        /// </summary>
        /// <param name="configName"></param>
        /// <returns></returns>
        public static string GetConnectionString(string configName)
        {
            string connectionString = ConfigurationManager.AppSettings[configName];

            return connectionString;
        }

    }
}
