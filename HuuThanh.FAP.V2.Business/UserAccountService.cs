using HuuThanh.FAP.V2.Repositories;

namespace HuuThanh.FAP.V2.Business
{
    public class UserAccountService
    {
        //UI nhìn: em đưa anh 
        private IUserAccountRepository _repo = new UserAccountRepositoryMySQL();
        public bool CheckLogin(string username, string password)
        {
            UserAccount userAccount = _repo.Search(username);
            if( userAccount != null)
                if (userAccount.Password == password )
                    return true;
            return false;
        }
    }
}
