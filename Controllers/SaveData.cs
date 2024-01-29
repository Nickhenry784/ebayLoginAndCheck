using System.Data.SQLite;

namespace ebayLoginAndCheck.Controllers
{
    public class SaveData
    {
        SQLiteConnection _con = new SQLiteConnection();

        ReaderWriterLock locker = new ReaderWriterLock();


        public void createConection()
        {
            var CurrentDirectory = Directory.GetCurrentDirectory();
            Directory.CreateDirectory(CurrentDirectory + @"\Data");
            string _strConnect = "Data Source=" + CurrentDirectory + "\\Data\\Database";
            _con = new SQLiteConnection(_strConnect);
            _con.Open();
        }

        public void closeConnection()
        {
            _con.Close();
        }

        public void createTableAccountEbay()
        {
            string sql = "CREATE TABLE IF NOT EXISTS tbl_accountEbay (username nvarchar(50) NOT NULL PRIMARY KEY, password nvarchar(50), status nvarchar(50), proxy nvarchar(50), quality nvarchar(50), log nvarchar(100))";
            createConection();
            SQLiteCommand command = new SQLiteCommand(sql, _con);
            command.ExecuteNonQuery();
            closeConnection();
        }

        public void createTablesetting()
        {
            string sql = "CREATE TABLE IF NOT EXISTS tbl_setting (apiCaptcha nvarchar(100) NOT NULL PRIMARY KEY, apiTelegram nvarchar(50), idGroup nvarchar(50))";
            createConection();
            SQLiteCommand command = new SQLiteCommand(sql, _con);
            command.ExecuteNonQuery();
            closeConnection();
        }

        public SQLiteDataReader loadDatasetting()
        {
            createConection();
            string sql = "select * from tbl_setting";
            SQLiteCommand command = new SQLiteCommand(sql, _con);
            SQLiteDataReader reader = command.ExecuteReader();
            return reader;
        }


        public void savesetting(string apiCaptcha, string apiTelegram, string idGroup)
        {
            try
            {
                locker.AcquireWriterLock(int.MaxValue);
                try
                {
                    string strInsert = string.Format("INSERT INTO tbl_setting(apiCaptcha, apiTelegram, idGroup) VALUES(\'" + apiCaptcha + "\',\'" + apiTelegram + "\',\'" + idGroup + "\')");
                    createConection();
                    SQLiteCommand command = new SQLiteCommand(strInsert, _con);
                    command.ExecuteNonQuery();
                    closeConnection();
                }
                catch (Exception err)
                {
                    Console.WriteLine(err.ToString());
                }
            }
            finally
            {
                locker.ReleaseWriterLock();
            }
        }

        public void deleteTablesetting()
        {
            try
            {
                locker.AcquireWriterLock(int.MaxValue);
                try
                {
                    string strDelete = string.Format("DELETE FROM tbl_setting");
                    createConection();
                    SQLiteCommand command = new SQLiteCommand(strDelete, _con);
                    command.ExecuteNonQuery();
                    closeConnection();
                }
                catch (Exception ex) { }
            }
            finally
            {
                locker.ReleaseWriterLock();
            }
        }

        public SQLiteDataReader loadDataAccountEbay()
        {
            createConection();
            string sql = "select * from tbl_accountEbay";
            SQLiteCommand command = new SQLiteCommand(sql, _con);
            SQLiteDataReader reader = command.ExecuteReader();
            return reader;
        }

        public SQLiteDataReader getQuality(string username)
        {
            createConection();
            string sql = "select quality from tbl_accountEbay WHERE username=\'" + username + "\'";
            SQLiteCommand command = new SQLiteCommand(sql, _con);
            SQLiteDataReader reader = command.ExecuteReader();
            return reader;
        }

        public void updateStatusByID(string username, string status)
        {
            try
            {
                locker.AcquireWriterLock(int.MaxValue);
                try
                {
                    string strUpdate = string.Format("UPDATE tbl_accountEbay SET status=\'" + status + "\' WHERE username=\'" + username + "\'");
                    createConection();
                    SQLiteCommand command = new SQLiteCommand(strUpdate, _con);
                    command.ExecuteNonQuery();
                    closeConnection();
                }
                catch { }
            }
            finally
            {
                locker.ReleaseWriterLock();
            }
        }

        public void updateProxyByID(string username, string proxy)
        {
            try
            {
                locker.AcquireWriterLock(int.MaxValue);
                try
                {
                    string strUpdate = string.Format("UPDATE tbl_accountEbay SET proxy=\'" + proxy + "\' WHERE username=\'" + username + "\'");
                    createConection();
                    SQLiteCommand command = new SQLiteCommand(strUpdate, _con);
                    command.ExecuteNonQuery();
                    closeConnection();
                }
                catch { }
            }
            finally
            {
                locker.ReleaseWriterLock();
            }
        }

        public void updateQualityByID(string username, string quality)
        {
            try
            {
                locker.AcquireWriterLock(int.MaxValue);
                try
                {
                    string strUpdate = string.Format("UPDATE tbl_accountEbay SET quality=\'" + quality + "\' WHERE username=\'" + username + "\'");
                    createConection();
                    SQLiteCommand command = new SQLiteCommand(strUpdate, _con);
                    command.ExecuteNonQuery();
                    closeConnection();
                }
                catch { }
            }
            finally
            {
                locker.ReleaseWriterLock();
            }
        }

        public void saveAccount(string username, string password, string status, string proxy, string quality, string log)
        {
            try
            {
                locker.AcquireWriterLock(int.MaxValue);
                try
                {
                    string strInsert = string.Format("INSERT INTO tbl_accountEbay(username, password, status, proxy, quality, log) VALUES(\'" + username + "\',\'" + password + "\',\'" + status + "\',\'" + proxy + "\',\'" + quality + "\',\'" + log + "\')");
                    createConection();
                    SQLiteCommand command = new SQLiteCommand(strInsert, _con);
                    command.ExecuteNonQuery();
                    closeConnection();
                }
                catch (Exception err)
                {
                    Console.WriteLine(err.ToString());
                }
            }
            finally
            {
                locker.ReleaseWriterLock();
            }
        }

        public void deleteProfileByAccount(string username)
        {
            try
            {
                locker.AcquireWriterLock(int.MaxValue);
                try
                {
                    string strDelete = string.Format("DELETE FROM tbl_accountEbay");
                    if (!string.IsNullOrEmpty(username))
                    {
                        strDelete = string.Format("DELETE FROM tbl_accountEbay WHERE username=\'" + username + "\'");
                    }
                    createConection();
                    SQLiteCommand command = new SQLiteCommand(strDelete, _con);
                    command.ExecuteNonQuery();
                    closeConnection();
                }
                catch (Exception ex) { }
            }
            finally
            {
                locker.ReleaseWriterLock();
            }
        }

        public void createTableCC()
        {
            string sql = "CREATE TABLE IF NOT EXISTS tbl_cc ([id] integer NOT NULL PRIMARY KEY AUTOINCREMENT, vs nvarchar(50), status nvarchar(50))";
            createConection();
            SQLiteCommand command = new SQLiteCommand(sql, _con);
            command.ExecuteNonQuery();
            closeConnection();
        }

        public SQLiteDataReader loadDataCC()
        {
            createConection();
            string sql = "select * from tbl_cc";
            SQLiteCommand command = new SQLiteCommand(sql, _con);
            SQLiteDataReader reader = command.ExecuteReader();
            return reader;
        }

        public void saveCC(string vs, string status)
        {
            try
            {
                locker.AcquireWriterLock(int.MaxValue);
                try
                {
                    string strInsert = string.Format("INSERT INTO tbl_cc(vs,status) VALUES(\'" + vs + "\',\'" + status + "\')");
                    createConection();
                    SQLiteCommand command = new SQLiteCommand(strInsert, _con);
                    command.ExecuteNonQuery();
                    closeConnection();
                }
                catch { }
            }
            finally
            {
                locker.ReleaseWriterLock();
            }
        }

        public void deleteTableCC(string vs)
        {
            try
            {
                locker.AcquireWriterLock(int.MaxValue);
                try
                {
                    string strDelete = string.Format("DELETE FROM tbl_cc");
                    if (!string.IsNullOrEmpty(vs))
                    {
                        strDelete = string.Format("DELETE FROM tbl_cc WHERE vs=\'" + vs + "\'");
                    }
                    createConection();
                    SQLiteCommand command = new SQLiteCommand(strDelete, _con);
                    command.ExecuteNonQuery();
                    closeConnection();
                }
                catch (Exception ex) { }
            }
            finally
            {
                locker.ReleaseWriterLock();
            }
        }

        public void updateStatusCC(string vs, string status)
        {
            try
            {
                locker.AcquireWriterLock(int.MaxValue);
                try
                {
                    string strUpdate = string.Format("UPDATE tbl_cc SET status=\'" + status + "\' WHERE vs=\'" + vs + "\'");
                    createConection();
                    SQLiteCommand command = new SQLiteCommand(strUpdate, _con);
                    command.ExecuteNonQuery();
                    closeConnection();
                }
                catch
                {
                    Console.WriteLine("Err");
                }
            }
            finally
            {
                locker.ReleaseWriterLock();
            }
        }
    }
}
