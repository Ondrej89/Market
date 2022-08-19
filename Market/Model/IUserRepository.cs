using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Market.Model
{
    public interface IUserRepository
    {
        bool AutenticateUser(NetworkCredential credential);
        void Add(UserModel userModel);
        void Edit(UserModel userModel);
        void Remove(int id);
        UserModel GetById(int id);
        UserModel getByUsername(string username);
        IEnumerable<UserModel> GetByAll();
        //...
    }
}
