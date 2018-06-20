using System;

namespace EngDictionary.Data.Implementation
{
    internal class EntityBase : IWord 
    {
        public EntityBase(Guid id)
        {
           Id = id;
        }

        public Guid Id { get; }
       

        public string Text { get; set; }
      

        public string Translation { get; set; }
    }
}
