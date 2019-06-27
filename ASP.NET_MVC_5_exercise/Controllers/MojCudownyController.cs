using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.NET_MVC_5_exercise.Controllers
{
	public class MojCudownyController : Controller
	{
		// GET: MojCudowny
		public string Index()
		{
			return "Oh, ale cudny tekst z mojego controlera";
		}

		public string Welcome()
		{
			return "Witojcie";
		}
	}
}