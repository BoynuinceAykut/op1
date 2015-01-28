using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OgrenciPortal.UI.Models
{
    public class ModelKayitVeGirisUI : ViewModelSession
    {
        public ModelOgrenciIlkKayit modelOgrenciIKayit { get; set; }
        public ModelOgrenciGiris modelogrencigiris { get; set; }

    }
}