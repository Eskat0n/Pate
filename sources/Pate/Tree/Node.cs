namespace Pate.Tree
{
    using System.Collections.Generic;

    public class Node
    {
        private readonly ParametersHash _parametersHash = new ParametersHash();
        private readonly IList<Node> _children = new List<Node>();

        public string Name { get; private set; }

        public Node Parent { get; private set; }

        public IEnumerable<Node> Children
        {
            get { return _children; }
        }

        public IParametersHash Parameters
        {
            get { return _parametersHash; }
        }

        public dynamic DynamicParameters
        {
            get { return _parametersHash; }
        }

        public bool IsRoot
        {
            get { return Parent == null; }
        }
    }
}