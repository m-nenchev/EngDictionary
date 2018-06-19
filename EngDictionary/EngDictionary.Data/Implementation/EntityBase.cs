using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngDictionary.Data.Implementation
{
    internal class EntityBase : IWord 
    {
        Guid id = Guid.NewGuid();

        string text = "subject";

        string translation = "table";

        public EntityBase()
        {
            Guid.NewGuid();
        }
        public EntityBase(Guid Id)
        {
           Id = this.Id;
        }

        public Guid Id { get; }
       

        public string Text
        {
            get
            {
                return text;
            }
        }
      

        public string Translation
        {
            get

            {
                return translation;
            }
        }
        

    }
}
