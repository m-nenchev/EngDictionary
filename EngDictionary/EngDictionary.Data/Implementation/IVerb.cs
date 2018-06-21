using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngDictionary.Data.Implementation
{
   public interface  IVerb
    {
       string IsRegular { get; set; }

       string PastSimple { get; set; }

       string PastParticiple { get; set; }
    }
}
