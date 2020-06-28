using IronPython.Hosting;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace chatbotWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Get Response
        /// </summary>
        /// <param name="msg"></param>
        /// <returns></returns>
        public JsonResult GetResponse(string msg)
        {
            var client = new RestClient("http://127.0.0.1:4000/get?msg=" + msg);
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            request.AddHeader("Authorization", "Bearer -884D9m2piWhEKgecAIKRd7EmdlQb27U1_tZ8zYCBKAbbk9CmgSXJ89gUR-1maJBG3NXw2w1CW6grqLQUQywpYslY2HGYPJ6lEPUUwNmy0_WP3D1gpC17kCYNrrfIJheCSHpnq1hNHnQGCPV2_5GRW5Jm7CMdbFKL4Cus1WYBLzRKYIqfd1Ebovxvil5OI4WuZLG2wzHnZTPREssGAsUDgiQEnjaVunmr9XwzeZPYRKhziQY8jkDCLDo3FXcOQI7oTI-O7y-wpMe84RqS4_AKchgRH13h2Qvkl6NXgjnakAjlesYLKZyQmSRl4vtiA6c");
            IRestResponse response = client.Execute(request);

            return Json(response.Content, JsonRequestBehavior.AllowGet);

        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}