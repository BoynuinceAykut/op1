using OgrenciPortal.DataTransferObject.Common;
using OgrenciPortal.Provider;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OgrenciPortal.Business.Common
{
    public class UyelikVeGirisManager
    {
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
    }
}
