using EquipmentInventory.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EquipmentInventory.Presentation.Controllers
{
    public class HomeController : Controller
    {
        private EquipmentLogic _equipmentLogic;
        public HomeController(EquipmentLogic equipmentLogic)
        {
            _equipmentLogic = equipmentLogic;
        }
        public ActionResult Index()
        {
            var equipments = _equipmentLogic.GetAllEquipments();
            return View(equipments);
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