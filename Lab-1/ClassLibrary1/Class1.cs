using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public interface ITranslator
    {
        string Translate(string in_str);
        string GetStudent();
        string GetId();
    }
}
