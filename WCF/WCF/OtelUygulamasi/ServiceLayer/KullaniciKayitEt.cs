using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    [DataContract]
    public class KullaniciKayitEt
    {
        [DataMember]
        public string Ad { get; set; }
        [DataMember]
        public string soyad { get; set; }
        [DataMember]
        public string telefon { get; set; }
        [DataMember]
        public string Mail { get; set; }
        [DataMember]
        public string KullaniciAdi { get; set; }
        [DataMember]
        public string KullaniciSifre { get; set; }
        [DataMember]
        public DateTime GirisTarihi { get; set; }

    }
}
