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
    
    public partial class SpecializationAdd : Form
    {
        List<Speciality> specialitiesList = new List<Speciality>();
        public Controller specialityController;
        public SpecializationAdd()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            try
            {
                Speciality speciality = new Speciality();
                bool gofar = true;
                if (nameBoxOfSpecializationBox.Text.Trim() == "" || testbox.Text.Trim()==""||
                    contestsbox.Text.Trim() == "" || budgplbox.Text.Trim() == "" || pdaybox.Text.Trim() == "")
                {
                    MessageBox.Show("Поля с пометкой '*' обязательны для заполнения", 
                                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    gofar = false;
                }
                if (phalfbox.Text == "")
                {
                    speciality.ExtrPayment = 0;
                }
                else
                {
                    speciality.ExtrPayment = Convert.ToDouble(phalfbox.Text);
                }

                if (gofar == true)
                {
                    speciality.Name = nameBoxOfSpecializationBox.Text;
                    speciality.Test = testbox.Text;
                    speciality.LastYearContest = Convert.ToDouble(contestsbox.Text);
                    speciality.BudgetPlaces = Convert.ToDouble(budgplbox.Text);
                    speciality.DayPayment = Convert.ToDouble(pdaybox.Text);
                    speciality.Description = infobox.Text;
                    specialityController.UniversitiesList[specialityController.UniversitiesList.Count - 1].
                        Faculties[specialityController.UniversitiesList[specialityController.UniversitiesList.Count - 1].
                        Faculties.Count - 1].Speciality.Add(speciality);
                }
                    nameBoxOfSpecializationBox.Clear();
                    testbox.Clear();
                    contestsbox.Clear();
                    budgplbox.Clear();
                    pdaybox.Clear();
                    phalfbox.Clear();
                    infobox.Clear();
                
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void save_Click(object sender, EventArgs e)
        {
            specialityController.Save(specialityController.UniversitiesList);
            this.Close();        
        }

    }
}
