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

		public string Welcome(string name, int id = 0)
		{
			return HttpUtility.HtmlEncode($"Hello {name}, number is: {id}");
		}
	}
}