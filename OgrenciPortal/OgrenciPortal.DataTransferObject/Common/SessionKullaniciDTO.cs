using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OgrenciPortal.DataTransferObject.Common
{
    public class SessionKullaniciDTO
    {
        public Guid guid { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string Email { get; set; }
    }
}
