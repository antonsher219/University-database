using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace DataSerializer
{
    [XmlRoot("University")]
    public class University
    {
        [XmlElement("city")]
        public string City { get; set; }
        [XmlElement("univname")]
        public string Name { get; set; }
        [XmlElement("fullunivname")]
        public string FullName { get; set; }
        [XmlElement("univadress")]
        public string Adress { get; set; }
        [XmlArray("listoftests")]
        [XmlArrayItem("testitem")]
        public List<string> Tests { get; set; }
        [XmlArray("listoffaculties")]
        [XmlArrayItem("facultyitem")]
        public List<Faculty> Faculties { get; set; } = new List<Faculty>();
        public University(string city, string name, string adress, List<Faculty> faculties, List<string> tests)
        {
            City = city;
            Name = name;
            Adress = adress;
            Faculties = faculties;
            Tests = tests;
        }
        public University()
        {
            City = "";
            Name = "";
            Adress = "";
            Faculties = new List<Faculty>();
            Tests = new List<string>();
        }
    }
}
