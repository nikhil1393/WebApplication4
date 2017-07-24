using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication4.Models
{
    public class UsersC
    {
        public List<UserModels> _userList = new List<UserModels>();

        public UsersC()
        {

            _userList.Add(new UserModels
            {


                Name = "Hello",
                Age = "abc",
                no = "123"

            });
        }

    public void addUser(UserModels mod){
            _userList.Add(mod);
        }

   
}
                
         }






