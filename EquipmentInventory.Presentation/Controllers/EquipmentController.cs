﻿using EquipmentInventory.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EquipmentInventory.Presentation.Controllers
{
    public class EquipmentController : Controller
    {
        private EquipmentLogic _equipmentLogic;
        public EquipmentController(EquipmentLogic equipmentLogic)
        {
            _equipmentLogic = equipmentLogic;
        }
        // GET: Equipment
        public ActionResult Index()
        {
            var equipments = _equipmentLogic.GetAllEquipments();
            return View(equipments);
        }

        // GET: Equipment/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Equipment/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Equipment/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Equipment/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Equipment/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Equipment/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Equipment/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
