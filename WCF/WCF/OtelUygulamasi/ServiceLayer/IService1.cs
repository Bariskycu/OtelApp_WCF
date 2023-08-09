using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiceLayer
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        int UpdateMusteriB(MusteriBilgileri b);
        [OperationContract]
        int DeleteMusteriB(MusteriBilgileri b);
        [OperationContract]
        int KullaniciKayit(KullaniciKayitEt k);
        [OperationContract]
        int Personelekle(PersonelBilgileri p);
        [OperationContract]
        int DeletePersonelB(PersonelBilgileri p);
        [OperationContract]
        int UpdatePersonelB(PersonelBilgileri p);
        [OperationContract]
        int DeleteMutfakU(MutfakU m);
        [OperationContract]
        int MutfakUekle(MutfakU m);
        [OperationContract]
        int UpdateMutfakU(MutfakU m);
        [OperationContract]
        int OdaUekle(OdaU o);
        [OperationContract]
        int UpdateOdaU(OdaU o);
        [OperationContract]
        int DeleteOdaU(OdaU o);




    }

    
    
}
