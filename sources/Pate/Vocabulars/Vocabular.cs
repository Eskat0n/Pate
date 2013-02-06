namespace Pate.Vocabulars
{
    using System.Collections.Generic;

    public class UnrestrictedVocabulary : IVocabulary
    {
        private readonly HashSet<string> _nodeNames;

        public UnrestrictedVocabulary(IEnumerable<string> nodeNames)
        {
            _nodeNames = new HashSet<string>(nodeNames);
        }

        public IEnumerable<string> NodeNames
        {
            get { return _nodeNames; }
        }

        public bool Contains(string nodeName)
        {
            return _nodeNames.Contains(nodeName);
        }
    }
}