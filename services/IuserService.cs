using ju.entity;

namespace ju.services
{
    public interface IuserService
    {
      
            void AddUser(User user);
            User ValidteUser(string email, string password);
           
     

    }
}
