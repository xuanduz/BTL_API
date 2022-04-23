using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Net;
using WebBanQA.Models;

namespace WebBanQA.Controllers
{
    // khi them moi controller thi phai go cai dong nay
    [EnableCors("*", "*", "*")]

    public class HomeController : ApiController
    {
        //https://localhost:44314/api/home
        [HttpGet]
        [Route("api/home/topSaleProduct/{number}")]
        public IEnumerable<Product> GetTopSaleProduct(int number)
        {
            DBProductDataContext db = new DBProductDataContext();
            return db.Products.OrderByDescending(x => x.P_discount).Take(number).ToList();
        }

        [HttpGet]
        [Route("api/login/{username}/{password}")]
        public bool Login(string username, string password)
        {
            DBUserDataContext db = new DBUserDataContext();
            var res = db.Users.Where(x => x.U_name == username && x.U_pass == password).FirstOrDefault();
            if (res == null)
            {
                return false;
            }
            return true;
        }
        
    }
}
