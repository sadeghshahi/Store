using System.Linq;
using System.Web.Http;
using Store.Models;
using Store.Services.DAL;

namespace Store.Services.Controllers
{
    public class ProductsController : ApiController
    {
        private readonly StoreDbContext _db = new StoreDbContext();

        //1- GET: api/Products
        public IHttpActionResult GetProducts()
        {
            return Ok(_db.Products.ToList());
        }

        //2- GET: api/Products/5
        public IHttpActionResult GetProduct(int id)
        {
            Product product = _db.Products.Find(id);
            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }

        //3- POST: api/Products
        public IHttpActionResult PostProduct(Product product)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _db.Products.Add(product);
            _db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new {id = product.Id}, product);
        }

        //4- GET: api/GetCountries
        public IHttpActionResult GetCountries()
        {
            return Ok(_db.Countries);
        }

        //5- GET: api/GetCategories
        public IHttpActionResult GetCategories()
        {
            return Ok(_db.Categories);
        }

        //6- GET: api/Companies
        public IHttpActionResult GetCompanies()
        {
            return Ok(_db.Companies.ToList());
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _db.Dispose();
            }

            base.Dispose(disposing);
        }
    }
}