using System;

namespace EngDictionary.Data
{
    public interface IWord
    {
         Guid Id { get; }
         string Text { get; set; }
         string Translation { get; set; }
    } 
}
