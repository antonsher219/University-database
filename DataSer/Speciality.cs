using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace DataSerializer
{
    [XmlRoot("Speciality")]
    public class Speciality
    {
        [XmlElement("specname")]
        public string Name { get; set; }
        [XmlElement("addinfo")]
        public string Description { get; set; }
        [XmlElement("payfordaystud")]
        public double DayPayment { get; set; }
        [XmlElement("payforhalfstud")]
        public double ExtrPayment { get; set; }
        [XmlElement("budgeplaces")]
        public double BudgetPlaces { get; set; }
        [XmlElement("contest")]
        public double LastYearContest { get; set; }
        [XmlElement("test")]
        public string Test { get; set; }
        public Speciality(string name, string description,
                           double dayPayment, double extrPayment,
                           double budgetPlaces, double lastYearContest)
        {
            Name = name;
            Description = description;
            DayPayment = dayPayment;
            ExtrPayment = extrPayment;
            BudgetPlaces = budgetPlaces;
            LastYearContest = lastYearContest;
        }
        public Speciality() { }
    }
}
