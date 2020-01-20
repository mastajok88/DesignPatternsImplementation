using System.Collections.Generic;

namespace DoBuilderCodeSnippetExample
{
    public class CodeSnippet
    {
        public string ClassName { get; set; }

        public IEnumerable<ClassField> Fields { get; set; }
    }
}
