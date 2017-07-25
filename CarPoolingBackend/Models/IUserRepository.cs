using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPoolingBackend.Models
{
    public interface IUserRepository
    {
        IEnumerable<User> GetAll();
        User Get(string customerID);
        User Add(User item);
        void Remove(string customerID);
        bool Update(User item);
    }
}
