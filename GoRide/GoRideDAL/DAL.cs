using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using GoRide;
using System.Configuration;



namespace GoRideDAL
{
    public class DAL
    {
        SqlConnection con;
        SqlCommand cmdInsertUser, cmdSelectUser,;
        SqlDataAdapter daSelectUsers;
        public DAL()
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["cpsConn"].ConnectionString);
            cmdInsertUser = new SqlCommand("procInsertUser", con);
            cmdInsertUser.Parameters.Add("@Name", SqlDbType.VarChar, 50);
            cmdInsertUser.Parameters.Add("@UserID", SqlDbType.VarChar, 50);
            cmdInsertUser.Parameters.Add("@Password", SqlDbType.VarChar, 15);
            cmdInsertUser.Parameters.Add("@Age", SqlDbType.Int);
            cmdInsertUser.Parameters.Add("@Gender", SqlDbType.VarChar, 15);
            cmdInsertUser.Parameters.Add("@Phone", SqlDbType.Int);
            cmdInsertUser.Parameters.Add("@Address", SqlDbType.VarChar, 50);
            cmdInsertUser.CommandType = CommandType.StoredProcedure;

            cmdSelectUser = new SqlCommand("procSelectAllUser", con);
            cmdSelectUser.CommandType = CommandType.StoredProcedure;

        }
        public bool InsertUserToDatabase(Model User)
        {
            bool bInserted = false;
            try
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
                con.Open();

                cmdInsertUser.Parameters[0].Value = User.User_Name;
                cmdInsertUser.Parameters[1].Value = User.User_UserID;
                cmdInsertUser.Parameters[2].Value = User.User_Password;
                cmdInsertUser.Parameters[3].Value = User.User_Age;
                cmdInsertUser.Parameters[4].Value = User.User_Gender;
                cmdInsertUser.Parameters[5].Value = User.User_Phone;
                cmdInsertUser.Parameters[6].Value = User.User_Address;
              


                if (cmdInsertUser.ExecuteNonQuery() == 1)
                    bInserted = true;
                return bInserted;
            }
            catch (SqlException se)
            {
                bInserted = false;

            }
            finally
            {
                con.Close();
            }
            return bInserted;
        }

        public List<Model> GetAllUsersFromDatabase()
        {
            List<Model> Users = new List<Model>();
            Model User = null;
            daSelectUsers = new SqlDataAdapter();
            daSelectUsers.SelectCommand = cmdSelectUser;
            DataSet dsUser = new DataSet();
            try
            {
                daSelectUsers.Fill(dsUser);
                foreach (DataRow dr in dsUser.Tables[0].Rows)
                {
                    User = new Model();
                    User.User_Name = dr[0].ToString();
                    User.User_UserID = dr[1].ToString();
                    User.User_Password = dr[2].ToString();
                    User.User_Age = Convert.ToInt32(dr[3].ToString());
                    User.User_Gender = dr[4].ToString();
                    User.User_Phone = Convert.ToInt32(dr[5].ToString());
                    User.User_Address = dr[6].ToString();
                    Users.Add(User);
                }
            }
            catch (Exception)
            {

                User = null;
            }
            return Users;

        }
    }
}
