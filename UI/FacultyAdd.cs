using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DataSerializer;
using BL;
using System.Text.RegularExpressions;

namespace UserInterface
{
    public partial class FacultyAdd : Form
    {
        List<Faculty> fac = new List<Faculty>();
        public Controller facultyController;
      
        public FacultyAdd()
        {
            InitializeComponent();
        }

        private void save_Click(object sender, EventArgs e)
        {
            Faculty faculty = new Faculty();
            string error = "";
            bool empty = false;
            Regex rgxWord = new Regex("^[А-Яа-я ]+$", RegexOptions.IgnoreCase);
            Regex rgxNumWord = new Regex("^[А-Яа-я0-9 ]+$", RegexOptions.IgnoreCase);
            if (facnamebox.Text.Trim() == "" || newfacadressbox.Text.Trim() == "" || newfacdirbox.Text.Trim() == "")
            {
                empty = true;
                MessageBox.Show("Все поля обязательны для заполнения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (!rgxWord.IsMatch(facnamebox.Text.Trim()) && facnamebox.Text.Trim() != "" && !empty)
                error += "Название факультета должна состоять " +
                    "только из букв русского алфавита\n";
            if (!rgxWord.IsMatch(newfacdirbox.Text.Trim()) && newfacdirbox.Text.Trim() != "" && !empty)
                error += "Направление факультета должно состоять " +
                    "только из букв русского алфавита\n";
            if (!rgxNumWord.IsMatch(newfacadressbox.Text.Trim()) && newfacadressbox.Text.Trim() != "" && !empty)
                error += "Адрес должен состоять только из цифр " +
                    "и букв русского алфавита\n";
            if (error == "")
            {
                faculty.Name = facnamebox.Text.Trim();
                faculty.Adress = newfacadressbox.Text.Trim();
                faculty.Direction = newfacdirbox.Text.Trim();
                facultyController.UniversitiesList[facultyController.UniversitiesList.Count - 1].Faculties.Add(faculty);
                SpecializationAdd addSpec = new SpecializationAdd();
                addSpec.specialityController = this.facultyController;
                addSpec.ShowDialog();
                facnamebox.Clear();
                newfacadressbox.Clear();
                newfacdirbox.Clear();
            }
            else
            {
                MessageBox.Show(error,"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
