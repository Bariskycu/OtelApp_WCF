using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    [DataContract]
    public class MutfakU
    {
        [DataMember]
        public int MutfakUId { get; set; }
        [DataMember]
        public string UrunAdi { get; set; }
        [DataMember]
        public string Kategori { get; set; }
        [DataMember]
        public string Adet { get; set; }
        [DataMember]
        public string Fiyat { get; set; }
        [DataMember]
        public string Firma { get; set; }
        [DataMember]
        public DateTime GelisTarihi { get; set; }
    }
}
