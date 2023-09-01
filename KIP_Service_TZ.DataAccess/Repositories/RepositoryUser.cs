using KIP_Service_TZ.DataAccess.Models;

namespace KIP_Service_TZ.DataAccess.Repositories
{
    public class RepositoryUser
    {
        private readonly MyContext myContext;

        public RepositoryUser(MyContext context)
        {
            myContext = context;
        }
        /// <summary>
        /// Добавление пользоваетля
        /// </summary>
        
        public User AddUser(string name)
        {
            User user = new User
            {
                Name = name,
                Id = Guid.NewGuid()
            };

            myContext.Users.Add(user);

            myContext.SaveChanges();

            return user;
        }

        /// <summary>
        /// Получение пользователя
        /// </summary>
     
        public User GetUser(Guid id)
        {
           return myContext.Users.FirstOrDefault(x => x.Id == id);
        }

    }
}
