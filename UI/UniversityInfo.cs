using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BL;
using DataSerializer;

namespace UserInterface
{
    public partial class UniversityInfo : Form
    {
        public Controller univInfoController = new Controller();
        
        public UniversityInfo()
        {
            InitializeComponent();
            facultyAddBtn.Visible = facultyDelBtn.Visible = 
                specAddBtn.Visible = specDelBtn.Visible = Controller.Root;
        }

       
        private void facultyBox_Click(object sender, EventArgs e)
        {
            boxofspec.Items.Clear();
            boxcashd.Clear();
            boxcashh.Clear();
            boxbudpl.Clear();
            boxrate.Clear();
            infobox.Clear();
            facadressbox.Clear();
            boxofdirect.Clear();
            testsbox.Clear();
            if (boxoffac.SelectedIndex != -1)
            {
                Faculty fac = new Faculty();
                foreach (var university in univInfoController.UniversitiesList)
                    foreach (var faculty in university.Faculties)
                        if (faculty.Name == Convert.ToString(boxoffac.Items[boxoffac.SelectedIndex]))
                        {
                            fac = faculty;
                            break;
                        }
                if(!Equals(fac.Speciality, null))
                for (int i = 0; i < fac.Speciality.Count; i++)
                    boxofspec.Items.Add(fac.Speciality[i].Name);
            }
        }

        private void spezializationBox_Click(object sender, EventArgs e)
        {
            boxcashd.Clear();
            boxcashh.Clear();
            boxbudpl.Clear();
            boxrate.Clear();
            infobox.Clear();
            facadressbox.Clear();
            boxofdirect.Clear();
            testsbox.Clear();
            if (boxofspec.SelectedIndex != -1)
            {
                Speciality spec = new Speciality();
                Faculty fac = new Faculty();
                foreach (var university in univInfoController.UniversitiesList)
                    foreach (var faculty in university.Faculties)
                        foreach (var speсiality in faculty.Speciality)
                            if (speсiality.Name == Convert.ToString(boxofspec.Items[boxofspec.SelectedIndex]))
                            {
                                fac = faculty;
                                spec = speсiality;
                                break;
                            }
                boxcashh.Text = spec.ExtrPayment == 0 ? "-" : spec.ExtrPayment.ToString();
                boxcashd.Text = spec.DayPayment.ToString();
                boxbudpl.Text = spec.BudgetPlaces.ToString();
                boxrate.Text = spec.LastYearContest.ToString();
                facadressbox.Text = fac.Adress;
                infobox.Text = spec.Description;
                boxofdirect.Text = fac.Direction;
                testsbox.Text = spec.Test;
            }
        }
        
        private void UniversityInfo_Load(object sender, EventArgs e)
        {

        }

        private void facultyAddBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < univInfoController.UniversitiesList.Count; i++)
            {
                if(univInfoController.UniversitiesList[i].FullName == namebox.Text)
                {
                    var temp = univInfoController.UniversitiesList[i];

                    univInfoController.UniversitiesList[i] = 
                        univInfoController.UniversitiesList[univInfoController.UniversitiesList.Count - 1];

                    univInfoController.UniversitiesList[univInfoController.UniversitiesList.Count - 1] = temp;
                    FacultyAdd adfc = new FacultyAdd();
                    adfc.facultyController = this.univInfoController;
                    adfc.ShowDialog();
                    boxoffac.Items.Clear();
                    foreach(var faculty in univInfoController.UniversitiesList[i].Faculties)
                    {
                        boxoffac.Items.Add(faculty.Name);
                    }
                }
            }
            univInfoController.Save(univInfoController.UniversitiesList);
        }

        private void facultyDelBtn_Click(object sender, EventArgs e)
        {
            if (boxoffac.SelectedIndex != -1)
            {
                var result = MessageBox.Show("Удалить выбраный факультет?" +
                    " При удалении он исчезнет из базы и не подлежит востановлению.",
                    "Удаление факультета", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if(result == DialogResult.Yes)
                {
                    foreach (var university in univInfoController.UniversitiesList)
                    {
                        if (university.FullName == namebox.Text)
                        {
                            university.Faculties.RemoveAt(boxoffac.SelectedIndex);
                            boxoffac.Items.Clear();
                            foreach (var faculty in university.Faculties)
                                boxoffac.Items.Add(faculty.Name);
                            break;
                        }
                    }
                    univInfoController.Save(univInfoController.UniversitiesList);
                }
            }
        }

        private void specAddBtn_Click(object sender, EventArgs e)
        {
            if(boxoffac.SelectedIndex != -1)
            {
                for (int i = 0; i < univInfoController.UniversitiesList.Count; i++)
                {
                    if (univInfoController.UniversitiesList[i].FullName == namebox.Text)
                    {
                        var temp = univInfoController.UniversitiesList[i].Faculties[boxoffac.SelectedIndex];

                        univInfoController.UniversitiesList[i].Faculties[boxoffac.SelectedIndex] =
                            univInfoController.UniversitiesList[i].Faculties[univInfoController.
                            UniversitiesList[i].Faculties.Count - 1];

                        univInfoController.UniversitiesList[i].Faculties[univInfoController.UniversitiesList[i]
                            .Faculties.Count - 1] = temp;
                        SpecializationAdd addSpecialization = new SpecializationAdd();
                        addSpecialization.specialityController = this.univInfoController;
                        addSpecialization.ShowDialog();
                        temp = univInfoController.UniversitiesList[i].Faculties[boxoffac.SelectedIndex];

                        univInfoController.UniversitiesList[i].Faculties[boxoffac.SelectedIndex] =
                            univInfoController.UniversitiesList[i].Faculties[univInfoController.UniversitiesList[i].
                            Faculties.Count - 1];

                        univInfoController.UniversitiesList[i].Faculties[univInfoController.UniversitiesList[i].
                            Faculties.Count - 1] = temp;

                        boxofspec.Items.Clear();
                        foreach(var speciality in univInfoController.UniversitiesList[i].Faculties[boxoffac.SelectedIndex].Speciality)
                        {
                            boxofspec.Items.Add(speciality.Name);
                        }
                        break;
                    }
                }
                univInfoController.Save(univInfoController.UniversitiesList);
            }
        }

        private void spezDelBtn_Click(object sender, EventArgs e)
        {
            if (boxoffac.SelectedIndex != -1 && boxofspec.SelectedIndex != -1)
            {
                var result = MessageBox.Show("Удалить выбраую специальность?" +
                    " При удалении она исчезнет из базы и не подлежит востановлению.",
                    "Удаление специальности", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    foreach (var university in univInfoController.UniversitiesList)
                    {
                        if (university.FullName == namebox.Text)
                        {
                            university.Faculties[boxoffac.SelectedIndex].Speciality.
                                RemoveAt(boxofspec.SelectedIndex);
                            boxofspec.Items.Clear();
                            foreach (var speciality in university.Faculties[boxoffac.SelectedIndex].Speciality)
                            {
                                boxofspec.Items.Add(speciality.Name);
                                break;
                            }
                        }
                    }
                    univInfoController.Save(univInfoController.UniversitiesList);
                }
            }
        }
    }
}
