using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfTranslationLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class TranslationService : ITranslationService
    {
        public CompositeType TranslateToPigLatin(string value)
        {
            CompositeType ct = new CompositeType() { OriginalStr = value, TranslationStr = "Imaginary Translation", TimeStamp = DateTime.Now };
            return ct;
        }

        public CompositeType TranslateToRussian(string value)
        {
            CompositeType ct = new CompositeType() { OriginalStr = value, TranslationStr = "Imaginary The following is russian:", TimeStamp = DateTime.Now };
            return ct;
        }

    }
}
