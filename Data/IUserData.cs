using System.Collections.Generic;
using System.Threading.Tasks;
using Markets.Models;

namespace Markets.Data
{
    public interface IUserData
    {

        UserModel GetPerson(string name);
        void UpsertPerson(UserModel user);
    }
}