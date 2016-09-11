using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FPP.Models;
using FPP_Library;

namespace FPP.Controllers
{
    public class FireController : Controller
    {
        // GET: Fire
        public ActionResult Index(string id="", string fromDate="", string untilDate="", int HR=0)
        {
            string filepath = HttpContext.Request.PhysicalApplicationPath;

            Utils.Utilities api = new Utils.Utilities();
            //           api.CSVPath = "http://www.data.gov.cy/mof/papd/dataportal/dataportal.nsf/64FAC10FF8FD5287C2257FFB00351285/$file/FOREST%20FIRES%20IN%20CYPRUS%202010-2015.csv";
             //api.CSVPath = filepath + @"App_Data\AllFires.csv";
            ViewData["test"] = api.CSVPath;
            //Markers AllMarkers=api.getAllFirePositionsFromCSV();
            Markers AllMarkers = api.getAllFirePositions(id, fromDate, untilDate, HR);
            FPP_Library.Model m = new Model();
            List<FPP_Library.ForecastPoint> AllForecastPoints = m.ForecastPoints.ToList(); 
            ViewData["Markers"] = AllMarkers;
            ViewData["id"] = id;
            ViewData["fromDate"] = fromDate;
            ViewData["untilDate"] = untilDate;
            ViewData["HR"] = HR;
            ViewData["AllForecastPoints"] = AllForecastPoints;


            return View();
        }

        public ActionResult forecast()
        {
            DateTime TheDate = new DateTime().Date;
            Utils.Utilities api = new Utils.Utilities();
            List<ForecastPoint> AllForecastPoints = api.getAllForecast(TheDate);
            ViewData["ForecastPoints"] = AllForecastPoints;
            return View();
        } 



    }
}