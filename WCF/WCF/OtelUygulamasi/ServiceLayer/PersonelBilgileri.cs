using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    [DataContract]
    public class PersonelBilgileri
    {
        [DataMember]
        public int PersonelId { get; set; }
        [DataMember]
        public string Ad { get; set; }
        [DataMember]
        public string Soyad { get; set; }
        [DataMember]
        public string Bolum { get; set; }
        [DataMember]
        public string Cinsiyet { get; set; }
        [DataMember]
        public string Telefon { get; set; }
        [DataMember]
        public string Mail { get; set; }
        [DataMember]
        public string TcNo { get; set; }
        [DataMember]
        public string Maas { get; set; }
        [DataMember]
        public DateTime GirisTarihi { get; set; }
        [DataMember]
        public DateTime CikisTarihi { get; set; }
    }
}
