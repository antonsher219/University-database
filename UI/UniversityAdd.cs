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
using System.Text.RegularExpressions;

namespace UserInterface
{

    public partial class UniversityAdd : Form
    {
        public Controller univerController;
        public UniversityAdd()
        {
            InitializeComponent();
        }


        private void addButton_Click(object sender, EventArgs e)
        {
            string error = "";
            bool empty = false;
            Regex rgxWord = new Regex("^[А-Яа-я ]+$", RegexOptions.IgnoreCase);
            Regex rgxNumWord = new Regex("^[А-Яа-я0-9 ]+$", RegexOptions.IgnoreCase);
            
            if (univboxadd.Text.Trim() == "" || fullnamebox.Text.Trim() == "" ||
                adressboxadd.Text.Trim() == "" || cityboxadd.Text.Trim() == "")
            {
                empty = true;
                error += "Все поля обязательны для заполнения\n";
            }
            if (!rgxWord.IsMatch(univboxadd.Text.Trim()) && univboxadd.Text.Trim() != "" && !empty)
                error += "Аббревиатура университета должна состоять " +
                    "только из букв русского алфавита\n";
            if (!rgxWord.IsMatch(fullnamebox.Text.Trim()) && fullnamebox.Text.Trim() != "" && !empty)
                error += "Название университета должно состоять " +
                    "только из букв русского алфавита\n";
            if (!rgxWord.IsMatch(cityboxadd.Text.Trim()) && cityboxadd.Text.Trim() != "" && !empty)
                error += "Название города должно состоять только " +
                    "из букв русского алфавита\n";
            if (!rgxNumWord.IsMatch(adressboxadd.Text.Trim()) && adressboxadd.Text.Trim() != "" && !empty)
                error += "Адрес должен состоять только из цифр " +
                    "и букв русского алфавита\n";
            foreach (var univer in univerController.UniversitiesList)
            {
                if (univboxadd.Text.Trim().ToLower() == univer.Name.ToLower() && empty)
                {
                    error = "Университет уже есть в базе";
                    break;
                }
            }
            if (error == "")
            {
                University university = new University();
                university.Name = univboxadd.Text.Trim();
                university.FullName = fullnamebox.Text.Trim();
                university.City = cityboxadd.Text.Trim();
                university.Adress = adressboxadd.Text.Trim();
                univerController.UniversitiesList.Add(university);
                FacultyAdd adfc = new FacultyAdd();
                adfc.facultyController = this.univerController;
                adfc.ShowDialog();
            }
            else
            {
                MessageBox.Show(error,
                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
