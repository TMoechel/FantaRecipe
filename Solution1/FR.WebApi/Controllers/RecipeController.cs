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
        public void Get()
        {
            var config = new Configuration().Configure();
            new SchemaExport(config).Create(false, true);

            ISession session = NHibernateHelper.GetCurrentSession();
            try
            {
                using (ITransaction tx = session.BeginTransaction())
                {
                    var recipe = new Recipe
                    {
                        Name = "Sweet Cream",
                        Stars = 5,
                        Description = "very delicision",
                    };

                    session.Save(recipe);
                    tx.Commit();
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
        public void Post([FromBody]string value)
        {
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
