namespace DoBuilderCodeSnippetExample
{
    public class CodeClassBuilder : CodeSnippetBuilder
    {
        
        public CodeClassBuilder(string className) : base(className)
        {
        }

        public CodeClassBuilder AddField(string fieldName, string fieldType)
        {
            CodeSnippet.Fields.Add(new ClassField(fieldName, fieldType));
            return this;
        }

        public CodeSnippet Build()
        {
            return CodeSnippet;
        }
    }
}