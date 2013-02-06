namespace Pate.Vocabulars
{
    using System.Collections.Generic;

    public interface IVocabulary
    {
        IEnumerable<string> NodeNames { get; }

        bool Contains(string nodeName);
    }
}