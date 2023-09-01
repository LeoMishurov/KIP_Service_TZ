using KIP_Service_TZ.DataAccess.Models;
using KIP_Service_TZ.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIP_Service_TZ.Logic
{
    public class UserLogic
    {
        private readonly RepositoryUser repositoryUser;

        public UserLogic(RepositoryUser repositoryUser)
        {
            this.repositoryUser = repositoryUser;
        }

	/// <summary>
        /// Добавление пользователя
        /// </summary>
		 
        public User AddUser(string name)
        {
            return repositoryUser.AddUser(name);
        }

	/// <summary>
        /// Получение пользователя
        /// </summary>

        public User GetUser(Guid id)
        {
            return repositoryUser.GetUser(id);
        }
    }
}
