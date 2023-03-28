using System.Xml.Linq;
using WikiGC.Models;

namespace WikiGC.Repositories.Repository
{
    public class UserRepository
    {
        public static Usuario Get(string nome, string password)
        {
            var users = new List<Usuario>();
            users.Add(new Usuario { Id = 1, Name = "Admin", Password = "123", Role = "admin" });
            users.Add(new Usuario { Id = 2, Name = "User", Password = "123", Role = "user" });
            return users.FirstOrDefault(x => x.Name.ToLower() == nome.ToLower() && x.Password == password);
        }
    }
}
