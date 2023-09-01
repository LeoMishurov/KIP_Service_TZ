using KIP_Service_TZ.DataAccess.Models;

namespace KIP_Service_TZ.DataAccess.Repositories
{
    public class RepositoryQuery
    {
        private readonly MyContext myContext;

        public RepositoryQuery(MyContext context)
        {
            myContext = context;
        }

        /// <summary>
        /// Добавление запроса
        /// </summary>   
		
        public Query AddQuery(Query query)
        {
            query.Id = Guid.NewGuid();

            myContext.Queries.Add(query);

            myContext.SaveChanges();

            return query;
        }

        /// <summary>
        /// Получение запроса
        /// </summary>
        
        public Query GetQuery(Guid id)
        {
           return myContext.Queries.FirstOrDefault(x => x.Id == id);
        }

    }
}
