﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.NET_MVC_5_exercise.Controllers
{
	public class HelloWorldController : Controller
	{
		// 
		// GET: /HelloWorld/ 

		public ActionResult Index()
		{
			return View();
		}

		// 
		// GET: /HelloWorld/Welcome/ 

		public ActionResult Welcome(string name, int num = 0)
		{
			ViewBag.Message = "Hello " + name;
			ViewBag.NumTimes = num;

			return View();
		}
	}
}