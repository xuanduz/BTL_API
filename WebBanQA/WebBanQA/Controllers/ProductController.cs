using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;
using WebBanQA.Models;
using WebBanQA.Models.Class;
using WebBanQA.Models.MultiTable;
using style = WebBanQA.Models.style;

namespace WebBanQA.Controllers
{
    [EnableCors("*", "*", "*")]
    public class ProductController : ApiController
    {
        private IEnumerable<ColorModel> temp;

        // GET: Product
        [HttpGet]
        [Route("api/detailProduct/{slug}")]
        public Models.MultiTable.Product GetDetailProductBySlug(string slug)
        {
            DBDetailProductDataContext db = new DBDetailProductDataContext();
            return db.Products.Where(x => x.P_slug == slug).FirstOrDefault();
        }

        [HttpGet]
        [Route("api/randomProduct/{number}")]
        public IEnumerable<Models.Product> GetRandomProduct(int number)
        {
            DBProductDataContext db = new DBProductDataContext();
            return db.Products.OrderBy(x => Guid.NewGuid()).Take(number).ToList();
        }

        [HttpGet]
        [Route("api/getStyle")]
        public IEnumerable<style> GetStyle()
        {
            DBStyleDataContext db = new DBStyleDataContext();
            return db.styles.ToList();
        }

        [HttpGet]
        [Route("api/getColor")]
        public IEnumerable<ColorModel> GetColor()
        {
            DBColorDataContext db = new DBColorDataContext();
            var res = from co in db.Colors
                      group co by new { co.COL_slug, co.COL_name } into temp
                      select new ColorModel()
                      {
                          COL_slug = temp.Key.COL_slug,
                          COL_name = temp.Key.COL_name
                      };
            return res.ToList();
        }

        [HttpGet]
        [Route("api/getSize")]
        public IEnumerable<SizeModel> GetSize()
        {
            DBSizeDataContext db = new DBSizeDataContext();
            var res = from co in db.Sizes
                      group co by co.S_name into temp
                      select new SizeModel()
                      {
                          S_name = temp.Key
                      };
            return res.ToList();
        }
    }
}