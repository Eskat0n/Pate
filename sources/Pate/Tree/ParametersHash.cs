namespace Pate.Tree
{
    using System.Collections.Generic;
    using System.Dynamic;

    internal class ParametersHash : DynamicObject, IParametersHash
    {
        private readonly IDictionary<string, Parameter> _dictionary = new Dictionary<string, Parameter>();

        public string this[string parameterName]
        {
            get { return _dictionary[parameterName].RawValue; }
        }
    }
}