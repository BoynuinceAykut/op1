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

        [HttpPost]
        public ActionResult OgrenciKayit(ModelKayitVeGirisUI model)
        {
            try
            {
                // TODO: Add insert logic here
                
                
                OgrenciIlkKayitDTO dto = new OgrenciIlkKayitDTO();
                dto.Adi = model.modelOgrenciIKayit.Adi;
                dto.Email = model.modelOgrenciIKayit.Email;
                dto.Sifre = model.modelOgrenciIKayit.Sifre;
                dto.Soyadi = model.modelOgrenciIKayit.Soyadi;

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
        // POST: /UyeVeGiris/OgrenciGiris
        [HttpPost]
        public ActionResult OgrenciGiris(ModelKayitVeGirisUI model)
        {
            try
            {
                // TODO: Add insert logic here

                OgrenciGirisDTO dto = new OgrenciGirisDTO();
                dto.Email = model.modelogrencigiris.Email;
                dto.Sifre = model.modelogrencigiris.Sifre;

                SessionKullaniciDTO sonuc = UyelikVeGirisManager.OgrenciGiris(dto);
                if (sonuc != null)
                {
                    //ViewModelSession msession = new ViewModelSession();
                    
                    //    msession.Adi = sonuc.Adi;
                    //    msession.Email = sonuc.Email;
                    //    msession.guid = sonuc.guid;
                    //    msession.Soyadi = sonuc.Soyadi;
                    
                    //Session["Kullanici"] = sonuc;
                    return RedirectToAction("Index", "Home");
                }
                else
                    return View();
            }
            catch
            {
                return View();
            }
        }
    }
}
