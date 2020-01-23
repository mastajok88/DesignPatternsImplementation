using System;
using System.Collections.Generic;
using System.Text;

namespace DoBuilderCodeSnippetExample
{
    public abstract class CodeSnippetBuilder
    {
        protected CodeSnippet CodeSnippet = new CodeSnippet();

        public CodeSnippetBuilder(string className)
        {
            this.CodeSnippet.ClassName = className;
        }
    }
}
