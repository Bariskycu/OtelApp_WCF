using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    [DataContract]
    public class MusteriBilgileri
    {
        [DataMember]
        public int MusteriId { get; set; }
        [DataMember]
        public string Adi { get; set; }
        [DataMember]
        public string Soyadi { get; set; }
        [DataMember]
        public string Cinsiyet { get; set; }
        [DataMember]
        public string Telefon { get; set; }
        [DataMember]
        public string Mail { get; set; }
        [DataMember]
        public string TcNo { get; set; }
        [DataMember]
        public string OdaNo { get; set; }
        [DataMember]
        public string Ucret { get; set; }
        [DataMember]
        public DateTime GirisTarihi { get; set; }
        [DataMember]
        public DateTime CikisTarihi { get; set; }
    }
}
