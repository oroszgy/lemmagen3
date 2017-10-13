using System.Collections.Generic;

namespace LemmaSharp
{
    public class SerializationModel
    {
        public bool matchWholeWord;
        public string suffixCondition;
        public string ruleFrom;
        public string ruleTo;
        public List<SerializationModel> childNodes;
    }
}