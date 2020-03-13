using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Umbraco.Core.Services;
using Umbraco.Web.Models;
using Umbraco.Web.Mvc;
using Umbraco.Core;
using Umbraco.Web.Security;
using Umbraco.Core.Services.Implement;
using HouseOfCode.Web.Models;

namespace HouseOfCode.Web.Controllers
{
    public class MembersController : SurfaceController
    {
        [HttpPost]
        public JsonResult LoginProcedure(string email, string password)
        {
            var message = "";
            if (Membership.ValidateUser(email, password))
            {
                FormsAuthentication.SetAuthCookie(email, false);
                message = "Success";
            }
            else
            {
                message = "Login failed";
            }

            return Json(message);
        }

        public ActionResult LogOut()
        {
            Session.Clear();
            FormsAuthentication.SignOut();

            return RedirectToUmbracoPage(1064);
        }

        [HttpPost]
        public  JsonResult Register(string name,string email, string password, string repassword)
        {
            RegisterModelVM register = new RegisterModelVM() { Email = email, Name = name, Password = password, Repassword = repassword };

            var message = "";
            if(register.isModelValid())
            {
                var model = RegisterModel.CreateModel();
                var memberService = Services.MemberService;
                var member = memberService.CreateMemberWithIdentity(email, email, name, "Member");
                memberService.Save(member);
                memberService.SavePassword(member, password);
                Members.Login(email, password);

                message = "Success";
            }
            else
            {
                message = "Fail";
            }

            return Json(message);
        }
    }
}