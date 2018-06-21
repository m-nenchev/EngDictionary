using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngDictionary.Data.Implementation
{
    internal class Verb :  EntityBase,IWord,IVerb
    {
        public new Guid Id { get; }


        public new string Text { get; set; }


        public new string Translation { get; set; }

        public string IsRegular { get; set; }

        public string PastSimple { get; set; }

        public string PastParticiple { get; set; }

        public Verb(Guid id) : base(id)
        {

        }
       
    }
}
