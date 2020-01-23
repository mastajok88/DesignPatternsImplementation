using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace DoCopyConstructorsPrototype
{
    public static class ExtensionMethods
    {
        public static T DeepCopy<T>(this T self)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(ms, self);
                ms.Seek(0, SeekOrigin.Begin);
                object copy = formatter.Deserialize(ms);
                return (T) copy;
            }
        }

        public static T DeepCopyXml<T>(this T self)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                var xmlSerializer = new XmlSerializer(typeof(T));
                xmlSerializer.Serialize(ms, self);
                ms.Position = 0;
                return (T) xmlSerializer.Deserialize(ms);
            }
        }
    }
}