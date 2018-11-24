using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace DataSerializer
{

    [XmlRoot("Faculty")]
    public class Faculty
    {
        [XmlArray("listofspecialties")]
        [XmlArrayItem("specialityitem")]
        public List<Speciality> Speciality { get; set; } = new List<Speciality>();
        [XmlElement("facname")]
        public string Name { get; set; }
        [XmlElement("facadress")]
        public string Adress { get; set; }
        [XmlElement("directioninstud")]
        public string Direction { get; set; }
        public Faculty(string name, string adress, string direction, List<Speciality> speciality)
        {
            Name = name;
            Adress = adress;
            Direction = direction;
            Speciality = speciality;
        }
        public Faculty() { }
    }
}