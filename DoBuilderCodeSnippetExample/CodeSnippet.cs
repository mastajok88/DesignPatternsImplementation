using System;
using System.Collections.Generic;
using System.Text;

namespace DoBuilderCodeSnippetExample
{
    public class CodeSnippet
    {
        public string ClassName { get; set; }

        public ICollection<ClassField> Fields = new List<ClassField>();

        private const int IndentSize = 2;

        public CodeSnippet()
        {
            
        }

        public CodeSnippet(string className)
        {
            ClassName = className ?? throw new ArgumentNullException(nameof(className));
        }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();
            var indent = new string(' ', IndentSize);
            stringBuilder.AppendLine($"public class {this.ClassName}");
            stringBuilder.AppendLine("{");
            foreach (var field in Fields)
            {
                var formattedField = $"{indent}public {field.PropertyType} {field.PropertyName};";
                stringBuilder.AppendLine(formattedField);
            }
            stringBuilder.AppendLine("}");
            return stringBuilder.ToString();
        }
    }
}
