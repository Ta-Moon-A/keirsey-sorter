using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KeirseySorter.Models;

namespace KeirseySorter.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            if (Session["AnsweredData"] != null)
            {
                var list = (List<QuestionViewModel>)Session["AnsweredData"];
                list.Clear();
            }

            return View();
        }


    }
}