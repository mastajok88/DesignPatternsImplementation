using System;
using System.Collections.Generic;
using System.Text;

namespace DoBuilderCodeSnippetExample
{
    public class ClassField
    {
        public string PropertyName { get; set; }
        public string PropertyType { get; set; }

        public ClassField(string propertyName, string propertyType)
        {
            PropertyName = propertyName ?? throw new ArgumentNullException(nameof(propertyName));
            PropertyType = propertyType ?? throw new ArgumentNullException(nameof(propertyType));
        }
    }
}
