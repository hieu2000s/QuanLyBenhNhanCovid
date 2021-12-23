using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hệ_thống_quản_lý_bệnh_nhân_covid_19.Handlers
{
    public class UserLoginHandler
    {
        public UserLoginHandler()
        {

        }
        private static Account _userData { get; set; }

        public Account UserData => _userData;

        public void Login(Account acc)
        {
            _userData = acc;
        }

        public void Logout (){
            _userData = null;
        }
    }
}
