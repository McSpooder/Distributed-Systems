using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfTranslationLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface ITranslationService
    {
        [OperationContract]
        CompositeType TranslateToPigLatin(string value);
        [OperationContract]
        CompositeType TranslateToRussian(string value);

        // TODO: Add your service operations here
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "WcfTranslationLibrary.ContractType".
    [DataContract]
    public class CompositeType
    {
        string originalStr = "";
        string translationStr = "";
        DateTime timeStamp; 

        [DataMember]
        public string OriginalStr
        {
            get { return originalStr; }
            set { originalStr = value; }
        }

        [DataMember]
        public string TranslationStr
        {
            get { return translationStr; }
            set { translationStr = value; }
        }

        [DataMember]
        public DateTime TimeStamp
        {
            get { return timeStamp; }
            set { timeStamp = value; }
        }
    }
}
