﻿using System;
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
    //[EnableCors("*", "*", "*")]
    //[EnableCorsAttribute("*", "*", "*")]

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
        
        [HttpPost]
        //[Route("api/register/{fname}/{lname}/{uname}/{password}/{email}/{phonenumber}/{address}")]
        [Route("api/register")]
        public string Register(string fname, string lname, string uname, string password, string email, string phonenumber, string address)
        {
            try
            {
                DBUserDataContext db = new DBUserDataContext();
                User user = new User();
                var checkUserName = db.Users.Where(x => x.U_name == uname).SingleOrDefault();
                var checkEmail = db.Users.Where(x => x.U_email == email).SingleOrDefault();

                if(checkUserName != null)
                {
                    return "Username exist";
                }
                else if(checkEmail != null)
                    {
                        return "Email exist";
                    }
                    else
                    {
                        user.U_id = "";
                        user.U_Fname = fname;
                        user.U_Lname = lname;
                        user.U_name = uname;
                        user.U_email = email;
                        user.U_status = "true";
                        user.U_add = address;
                        user.U_contact = phonenumber;
                        user.U_created = DateTime.Now;
                        user.U_pass = password;
                        db.Users.InsertOnSubmit(user);
                        db.SubmitChanges();
                        return "Success";
                    }
            }
            catch
            {
                return "Fail";
            }
        } 
    }
}
