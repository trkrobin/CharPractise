using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using MvcApplication1.Models;

namespace MvcApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult ShowGoogle()
        {
            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult ShowPie() {
            List<DataPoint> dataPoints = new List<DataPoint>();

            dataPoints.Add(new DataPoint("Samsung", 25));
            dataPoints.Add(new DataPoint("Micromax", 13));
            dataPoints.Add(new DataPoint("Lenovo", 8));
            dataPoints.Add(new DataPoint("Intex", 7));
            dataPoints.Add(new DataPoint("Reliance", 6.8));
            dataPoints.Add(new DataPoint("Others", 40.2));

            ViewBag.DataPoints = JsonConvert.SerializeObject(dataPoints);

            return View();
        }

        public ActionResult ShowLine() { 

            List<DataPoint> dataPoints1 = new List<DataPoint>();
			List<DataPoint> dataPoints2 = new List<DataPoint>();
			List<DataPoint> dataPoints3 = new List<DataPoint>();
 
			dataPoints1.Add(new DataPoint("Jan", 72));
			dataPoints1.Add(new DataPoint("Feb", 67));
			dataPoints1.Add(new DataPoint("Mar", 55));
			dataPoints1.Add(new DataPoint("Apr", 42));
			dataPoints1.Add(new DataPoint("May", 40));
			dataPoints1.Add(new DataPoint("Jun", 35));
 
			dataPoints2.Add(new DataPoint("Jan", 48));
			dataPoints2.Add(new DataPoint("Feb", 56));
			dataPoints2.Add(new DataPoint("Mar", 50));
			dataPoints2.Add(new DataPoint("Apr", 47));
			dataPoints2.Add(new DataPoint("May", 65));
			dataPoints2.Add(new DataPoint("Jun", 69));
				
			dataPoints3.Add(new DataPoint("Jan", 38));
			dataPoints3.Add(new DataPoint("Feb", 46));
			dataPoints3.Add(new DataPoint("Mar", 55));
			dataPoints3.Add(new DataPoint("Apr", 70));
			dataPoints3.Add(new DataPoint("May", 77));
			dataPoints3.Add(new DataPoint("Jun", 91));
 
			ViewBag.DataPoints1 = JsonConvert.SerializeObject(dataPoints1);
			ViewBag.DataPoints2 = JsonConvert.SerializeObject(dataPoints2);
			ViewBag.DataPoints3 = JsonConvert.SerializeObject(dataPoints3);
 
			return View();
        }

        public ActionResult ShowChart()
        {
            List<DataPoint> dataPoints = new List<DataPoint>();

            dataPoints.Add(new DataPoint("Albert", 10));
            dataPoints.Add(new DataPoint("Tim", 30));
            dataPoints.Add(new DataPoint("Wilson", 17));
            dataPoints.Add(new DataPoint("Joseph", 39));
            dataPoints.Add(new DataPoint("Robert", 30));
            dataPoints.Add(new DataPoint("Sophia", 25));
            dataPoints.Add(new DataPoint("Emma", 15));

            ViewBag.DataPoints = JsonConvert.SerializeObject(dataPoints);

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
