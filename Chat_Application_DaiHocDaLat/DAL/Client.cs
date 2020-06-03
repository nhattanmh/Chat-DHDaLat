using Chat_Application_DaiHocDaLat.BLL;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Drawing.Imaging;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chat_Application_DaiHocDaLat.DAL
{
   public class Client
    {
        private Account account;
        public Account Account
        {
            get
            {
                return account;
            }

            set
            {
                account = value;
            }
        }

        public bool Login(string name, string password)
        {

            // Account = new Account(name);
            //Send("login|" + name + "|" + password);
            String query = "select * from Account where name=N'"+name+"' and password=N'"+password+"'";
          DataTable result=  DataProvider.Instance.ExecuteQuery(query);
            return result.Rows.Count > 0;
        }

        public void setStatusOnline(String name)
        {
            string query = "Update Account set status=1 where name=N'" + name + "'";
            DataProvider.Instance.ExecuteNonQuery(query);
        }
        public void setStatusOffline(String name)
        {
            string query = "Update Account set status=0 where name=N'" + name + "'";
            DataProvider.Instance.ExecuteNonQuery(query);
        }
        public DataTable DisplayClientOnline()
        {
            DataTable data = new DataTable();
            string query = "select name from Account where role=0 and status=1";
            data =DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
    }
    }

