using OgrenciPortal.Business.Common;
using OgrenciPortal.DataTransferObject.Common;
using OgrenciPortal.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OgrenciPortal.UI.Controllers
{
    public class UyeVeGirisController : Controller
    {
        //
        // GET: /UyeVeGiris/

        public ActionResult Index()
        {

            return View();
        }

        //
        // GET: /UyeVeGiris/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /UyeVeGiris/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /UyeVeGiris/Create

        [HttpPost]
        public ActionResult Create(ModelOgrenciIlkKayit model)
        {
            try
            {
                // TODO: Add insert logic here

                OgrenciIlkKayitDTO dto = new OgrenciIlkKayitDTO();
                dto.Adi = model.Adi;
                dto.Email = model.Email;
                dto.Sifre = model.Sifre;
                dto.Soyadi = model.Soyadi;

                bool sonuc = UyelikVeGirisManager.OgrenciIlkKayit(dto);
                if (sonuc)
                    return RedirectToAction("Index");
                else
                    return View();
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /UyeVeGiris/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /UyeVeGiris/Edit/5

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

        //
        // GET: /UyeVeGiris/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /UyeVeGiris/Delete/5

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
