using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;


namespace DataSerializer
{
    [XmlRoot("UniverContainer")]
      public class UniversitiesContainer
    {
        [XmlArray("listofuniversities")]
        [XmlArrayItem("universityitem")]
        public List<University> Universities { get; set; }
        public UniversitiesContainer() { }
    }

}
