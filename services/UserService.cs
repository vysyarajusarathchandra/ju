using ju.Database;
using ju.entity;

namespace ju.services
{
    public class UserService : IuserService
    {
        private readonly Mycontext context=null;
        public UserService(Mycontext context)
        {
            this.context = context;
        }
        public void AddUser(User user)
        {
            try
            {
                if (user != null)
                {
                    context.Users.Add(user);
                    context.SaveChanges();
                
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        public User ValidteUser(string email, string password)
        {
            return context.Users.SingleOrDefault(u => u.Email == email && u.Password == password);
        }
    }
}
