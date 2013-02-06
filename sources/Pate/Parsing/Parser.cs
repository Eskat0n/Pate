namespace Pate.Parsing
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Tree;
    using Vocabulars;

    public class Parser
    {
        public IEnumerable<Node> Parse(string templateContent, IVocabulary vocabulary)
        {
            var templateLines = templateContent.Split(new[] {"\n"}, StringSplitOptions.RemoveEmptyEntries)
                ;
            return Parse(templateLines, vocabulary);
        }

        public IEnumerable<Node> Parse(IEnumerable<string> templateLines, IVocabulary vocabulary)
        {
            var nodeList = new List<Node>();

            var trimmedLines = templateLines
                .Select(x => x.TrimEnd('\r', '\t', ' '));

            foreach (var line in trimmedLines)
            {
                vocabulary.Contains(line);
            }            

            return nodeList.AsReadOnly();
        }
    }
}