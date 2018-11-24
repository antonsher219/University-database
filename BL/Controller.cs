using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataSerializer;

namespace BL
{

    public class Controller
    {
        public List<University> UniversitiesList;
        public static bool Root { get; set; } = false;
        public string login = "anton";
        public string password = "sher";
        public Controller()
        {
            UniversitiesList = Load();
        }
        public void Save(UniversitiesContainer univerController)
        {
            DataSerialize.SaveToXml(univerController, "xml.xml");
        }
        public List<University> Load()
        {
            UniversitiesContainer universitiesContainer = DataSerialize.LoadFromXml("xml.xml");
            List<University> universities = new List<University>();
            foreach(var univer in universitiesContainer.Universities)
                universities.Add(univer);
            return universities;


        }

        public List<string> Search(string univName, string univCity,
                                       double costFrom, double costTo,
                                       bool isCheckedDay, bool isCheckedHalf, string direction,
                                       string facultyName, string specialName,
                                       double rateFrom, double rateTo, Dictionary<string, double> @params)
        {
            bool isThereAnyTests = true;
            if (@params.Values.Max() == 0)
            {
                isThereAnyTests = false;
            }
            
            List<string> cour = null;
            List<string> filteredUniv = new List<string>();
            if(!Equals(UniversitiesList,null))
                foreach (var university in UniversitiesList)
                {
                    if(!Equals(university.Faculties, null))
                    foreach (var faculty in university.Faculties)
                    {
                        if(!Equals(faculty.Speciality, null))
                        foreach (var speciality in faculty.Speciality)
                        {
                            if ((univName == "" || university.Name.ToLower().Contains(univName.ToLower())) &&
                                (univCity == "" || university.City.ToLower().Contains(univCity.ToLower())) &&
                                (facultyName == "" || faculty.Name.ToLower().Contains(facultyName.ToLower())) &&
                                (specialName == "" || speciality.Name.ToLower().Contains(specialName.ToLower())) &&
                                (direction == "" || faculty.Direction.ToLower().Contains(direction.ToLower())) &&
                                (costFrom == 0 || costFrom < speciality.DayPayment) &&
                                (costFrom == 0 || costFrom < speciality.ExtrPayment) &&
                                (costTo == 0 || costTo > speciality.DayPayment) &&
                                (costTo == 0 || costTo > speciality.ExtrPayment) &&
                                (rateFrom == 0 || rateFrom < speciality.LastYearContest) &&
                                (rateTo == 0 || rateTo > speciality.LastYearContest) &&
                                (!isCheckedDay || speciality.DayPayment != 0) &&
                                (!isCheckedHalf || speciality.ExtrPayment != 0) &&
                                (!filteredUniv.Contains(university.Name)))

                                if (isThereAnyTests)
                                {
                                    cour = new List<string>(speciality.Test.Split(','));
                                    double mylevel = 0;
                                    for (int l = 0; l < cour.Count; l++)
                                    {
                                        if(@params.ContainsKey(cour[l]))
                                        mylevel += @params[cour[l]];
                                    }

                                    if ((mylevel >= speciality.LastYearContest) && 
                                        (!filteredUniv.Contains(university.Name)))
                                    {
                                        filteredUniv.Add(university.Name);
                                        Sort(filteredUniv);
                                    }
                                }
                                else
                                {
                                    filteredUniv.Add(university.Name);
                                    Sort(filteredUniv);
                                }
                        }

                    }
                }
            return filteredUniv;
        }
        
        public void Save(List<University> universities)
        {
            UniversitiesContainer univerContainer = new UniversitiesContainer();
            univerContainer.Universities = universities;
            DataSerialize.SaveToXml(univerContainer, "xml.xml");
        }
        

        public List<string> GetCities()
        {
            
            List<string> citynames = new List<string>();
            if (!Equals(UniversitiesList, null))
            {
                foreach (var university in UniversitiesList)
                {
                    if (citynames.Contains(university.City) == false)
                    {
                        citynames.Add(university.City);
                    }
                }
            }
            Sort(citynames);
            return citynames;
        }

        public List<string> GetUnivNames()
        {
            List<string> universityNamesList = new List<string>();
            if (!Equals(UniversitiesList, null))
            {
                for (int i = 0; i < UniversitiesList.Count; i++)
                {
                    universityNamesList.Add(UniversitiesList[i].Name);
                }
            }
            Sort(universityNamesList);
            return universityNamesList;
        }

        public List<string> GetDirection()
        {
           
            List<string> directionsList = new List<string>();
            if (!Equals(UniversitiesList, null))
            {
                foreach (var university in UniversitiesList)
                {
                    if (!Equals(university.Faculties, null))
                        foreach (var faculty in university.Faculties)
                        {
                            if (!directionsList.Contains(faculty.Direction))
                            {
                                directionsList.Add(faculty.Direction);
                            }
                        }
                }
            }
            Sort(directionsList);
            return directionsList;
        }

        public List<string> GetFacultyNames()
        {
            List<string> facultyNamesList = new List<string>();

            if(!Equals(UniversitiesList, null))
            {
                foreach (var university in UniversitiesList)
                {
                    if (!Equals(university.Faculties, null))
                        foreach (var faculty in university.Faculties)
                        {
                            if (!facultyNamesList.Contains(faculty.Name))
                            {
                                facultyNamesList.Add(faculty.Name);
                            }
                        }
                }
            }
            Sort(facultyNamesList);
            return facultyNamesList;
        }

        public List<string> GetSpecialtyNames()
        {
            List<string> specialtyNamesList = new List<string>();
            foreach (var university in UniversitiesList)
            {
                if (!Equals(university.Faculties, null))
                {
                    foreach (var faculty in university.Faculties)
                    {
                        if(!Equals(faculty.Speciality, null))
                        {
                            foreach (var speciality in faculty.Speciality)
                            {
                                if (!Equals(speciality.Name, null))
                                {
                                    if (!specialtyNamesList.Contains(speciality.Name))
                                    {
                                        specialtyNamesList.Add(speciality.Name);
                                    }
                                }
                            }
                        }
                    }
                }

            }
            Sort(specialtyNamesList);
            return specialtyNamesList;
        }

        public void Sort(List<string> facultyNames)
        {
            facultyNames.Sort();
        }
    }
}
