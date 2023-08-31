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
        /// Добавление работника
        /// </summary>
        /// <param name="name"></param>
        /// <param name="number"></param>
        /// <param name="jobTitle"></param>
        /// <param name="department"></param>
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
        /// <param name="id"></param>
        public User GetUser(Guid id)
        {
           return myContext.Users.FirstOrDefault(x => x.Id == id);
        }

    }
}
