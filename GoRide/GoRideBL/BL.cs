using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoRideDAL;
using GoRide;

namespace GoRideBL
{
   public class BL
    {
       DAL dal;
       public BL()
       {
           dal = new DAL();
    }
        public bool InsertUser (Model User)
        {
            bool bResult=dal.InsertUserToDatabase( User);
            return bResult;
        }
        public List<Model> GetUsers()
        {
            return dal.GetAllUsersFromDatabase();
        }

        public void GetUsers(Model usr)
        {
            throw new NotImplementedException();
        }
    }
}

