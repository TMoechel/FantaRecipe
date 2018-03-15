using System.Collections.Generic;
using System.Web.Http;
using FR.DomainModel;
using FR.WebApi.InfraStructure;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;

namespace FR.WebApi.Controllers
{
    public class RecipeController : ApiController
    {
        // GET api/values
        public IEnumerable<Recipe> Get()
        {
            ISession session = NHibernateHelper.GetCurrentSession();
            IEnumerable<Recipe> RecipeList;
            try
            {
                using (ITransaction tx = session.BeginTransaction())
                {
                    RecipeList = session.QueryOver<Recipe>().List();
                    tx.Commit();

                    return RecipeList;
                }
            }
            finally
            {
                NHibernateHelper.CloseSession();
            }
           
        }

        // GET api/values/5
        //http://localhost:60165/api/recipe/5

        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public Recipe Post(Recipe recipe)
        {
            return recipe;
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
