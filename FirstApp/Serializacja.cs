using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace FirstApp
{
    public class Serializacja
    {
        public string SerializeToString<T>(T obiekt)
        {
            XmlSerializer xmlSerializr = new XmlSerializer(obiekt.GetType());            
            using (StringWriter textWriter = new StringWriter())
            {
                try
                {
                    xmlSerializr.Serialize(textWriter, obiekt);            
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                return textWriter.ToString();
            }            
        }        

    }
}
