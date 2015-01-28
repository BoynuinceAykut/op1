using OgrenciPortal.DataTransferObject.Common;
using OgrenciPortal.Provider;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace OgrenciPortal.Business.Common
{
    public class UyelikVeGirisManager
    {
        /// <summary>
        /// Öğrenci Kayıt işlemi yapar.
        /// </summary>
        /// <param name="mdlOgr"></param>
        /// <returns></returns>
        public static bool OgrenciIlkKayit(OgrenciIlkKayitDTO mdlOgr)
        {
            bool sonuc = false;
            DataLayer servis = new DataLayer();
            try
            {
                Hashtable param = new Hashtable();
                param.Add("@Adi", mdlOgr.Adi);
                param.Add("@Soyadi", mdlOgr.Soyadi);
                param.Add("@Email", mdlOgr.Email);
                param.Add("@Sifre", mdlOgr.Sifre);
                int gelenCevap = servis.SorguCalistir("prc_OgrenciIlkKayit", param, System.Data.CommandType.StoredProcedure);
                if (gelenCevap > 0)
                    sonuc = true;
                else
                    sonuc = false;
            }
            catch (Exception ex)
            {
                sonuc = false;
                //TODO : LOG KAYIT YAPILACAK.
            }
            return sonuc;
        }

        /// <summary>
        /// Öğrenci Giriş Yapar
        /// </summary>
        /// <param name="mdlOgr"></param>
        /// <returns></returns>
        public static SessionKullaniciDTO OgrenciGiris(OgrenciGirisDTO mdlOgr)
        {
            SessionKullaniciDTO sesKul = new SessionKullaniciDTO();
            DataLayer servis = new DataLayer();
            try
            {
                
                Hashtable param = new Hashtable();
                param.Add("@Email", mdlOgr.Email);
                param.Add("@Sifre", mdlOgr.Sifre);
                DataTable gelenCevap = servis.Getir("prc_OgrenciGirisKontrol", param,CommandType.StoredProcedure);
                if (gelenCevap.Rows.Count > 0)
                {
                    sesKul.guid = Guid.Parse(gelenCevap.Rows[0]["OgrenciGuid"].ToString());
                    sesKul.Adi = gelenCevap.Rows[0]["Adi"].ToString();
                    sesKul.Soyadi = gelenCevap.Rows[0]["Soyadi"].ToString();
                    sesKul.Email = gelenCevap.Rows[0]["Email"].ToString();
                }
                else
                    sesKul = null;
            }
            catch (Exception ex)
            {
                sesKul = null;
                //TODO : LOG KAYIT YAPILACAK.
            }
            return sesKul;
        }
    }
}
