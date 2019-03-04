using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Bloggportal.Models
{
    public class UserMethods
    {
        public List<UserDetail> GetUserList(out string errormsg)
        {
            // Skapa sql-anslutning
            SqlConnection dbConnection = new SqlConnection();

            // Koppla mot SQL-server
            dbConnection.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=aspnet-Bloggportal-0BF468BC-4EBB-4218-BBC7-619A83AD7C9F;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            // SQL-sträng för att lägga till i databasen
            String sqlstring = "SELECT Id, UserName, Email FROM AspNetUsers" +
                "";
            SqlCommand dbCommand = new SqlCommand(sqlstring, dbConnection);

            // Skapa en adapter
            SqlDataAdapter myAdapter = new SqlDataAdapter(dbCommand);
            DataSet myDS = new DataSet();

            List<UserDetail> UserList = new List<UserDetail>();

            try
            {
                dbConnection.Open();

                // Fyller dataset
                myAdapter.Fill(myDS, "myUser");

                int count = 0;
                int i = 0;
                count = myDS.Tables["myUser"].Rows.Count;

                if (count > 0)
                {
                    while (i < count)
                    {
                        UserDetail ud = new UserDetail();
                        ud.Id = myDS.Tables["myUser"].Rows[i]["Id"].ToString();
                        ud.UserName = myDS.Tables["myUser"].Rows[i]["UserName"].ToString();
                        ud.Email = myDS.Tables["myUser"].Rows[i]["Email"].ToString();

                        i++;
                        UserList.Add(ud);
                    }

                    errormsg = "";
                    return UserList;
                }
                else
                {
                    errormsg = "Det hämtades inga poster";
                    return (null);
                }
            }
            catch (Exception e)
            {
                errormsg = e.Message;
                return null;
            }
            finally
            {
                dbConnection.Close();
            }
        }

        public List<PostDetail> GetUserPosts(out string errormsg, string userId)
        {
            // Skapa sql-anslutning
            SqlConnection dbConnection = new SqlConnection();

            // Koppla mot SQL-server
            dbConnection.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=aspnet-Bloggportal-0BF468BC-4EBB-4218-BBC7-619A83AD7C9F;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            // SQL-sträng för att lägga till i databasen
            String sqlstring = "SELECT * FROM Posts WHERE Creator = @userId";
            SqlCommand dbCommand = new SqlCommand(sqlstring, dbConnection);

            dbCommand.Parameters.Add("userId", SqlDbType.NVarChar, 450).Value = userId;

            // Skapa en adapter
            SqlDataAdapter myAdapter = new SqlDataAdapter(dbCommand);
            DataSet myDS = new DataSet();

            List<PostDetail> PostList = new List<PostDetail>();

            try
            {
                dbConnection.Open();

                // Fyller dataset
                myAdapter.Fill(myDS, "myPost");

                int count = 0;
                int i = 0;
                count = myDS.Tables["myPost"].Rows.Count;

                if (count > 0)
                {
                    while (i < count)
                    {
                        PostDetail pd = new PostDetail();
                        pd.Id = Convert.ToInt32(myDS.Tables["myPost"].Rows[i]["Id"]);
                        pd.Header = myDS.Tables["myPost"].Rows[i]["Header"].ToString();
                        pd.Content = myDS.Tables["myPost"].Rows[i]["Content"].ToString();
                        pd.CreationDate = myDS.Tables["myPost"].Rows[i]["CreationDate"].ToString();

                        i++;
                        PostList.Add(pd);
                    }

                    errormsg = "";
                    return PostList;
                }
                else
                {
                    errormsg = "Det hämtades inga poster";
                    return (null);
                }
            }
            catch (Exception e)
            {
                errormsg = e.Message;
                return null;
            }
            finally
            {
                dbConnection.Close();
            }
        }

    }
}
