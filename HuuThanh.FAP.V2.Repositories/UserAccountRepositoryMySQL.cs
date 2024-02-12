using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuuThanh.FAP.V2.Repositories
{
    public class UserAccountRepositoryMySQL : IUserAccountRepository
    {
        private List<UserAccount> _users = new List<UserAccount>() 
        {
            new UserAccount() {UserName = "phuuthanh2003", Password = "1234"},
            new UserAccount() {UserName = "jack", Password = "5to?i"},
        };
        public UserAccount? Search(string username)
        {
            return _users.FirstOrDefault(x =>  x.UserName == username);
        }
    }
}
