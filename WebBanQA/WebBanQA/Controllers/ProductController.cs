using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;
using WebBanQA.Models;

namespace WebBanQA.Controllers
{
    [EnableCors("*", "*", "*")]
    public class ProductController : ApiController
    {
        // GET: Product
        [HttpGet]
        [Route("api/product/{slug}")]
        public Product GetProductBySlug(string slug)
        {
            DBProductDataContext db = new DBProductDataContext();
            return db.Products.Where(x => x.P_slug == slug).FirstOrDefault();
        }
    }
}