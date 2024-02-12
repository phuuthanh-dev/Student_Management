using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuuThanh.FAP.V2.Repositories
{
    public interface IUserAccountRepository
    {
        //public List<UserAccount> GetAll();
        //public void Add(UserAccount account);
        //public void Update(UserAccount account);
        //public void Delete(string username);
        public UserAccount Search(string username);
    }
}
