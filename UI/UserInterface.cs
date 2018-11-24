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
using System.Threading;
using System.Text.RegularExpressions;

namespace UserInterface
{
    public partial class UserInterface : Form
    {
        public Controller controller = new Controller();
        public UserInterface(bool root)
        {
            InitializeComponent();
            addunivbt.Visible = changeunivbt.Visible = renew.Visible = Controller.Root;
        }
        
        private void UserInterface_Load(object sender, EventArgs e)
        {
            List<string> cities = controller.GetCities();
            for (int i = 0; i < cities.Count; i++)
                citybox.Items.Add(cities[i]);
            List<string> univ = controller.GetUnivNames();
            for (int i = 0; i < univ.Count; i++)
                univbox.Items.Add(univ[i]);
            List<string> direc = controller.GetDirection();
            for (int i = 0; i < direc.Count; i++)
                direcbox.Items.Add(direc[i]);
            List<string> facnames = controller.GetFacultyNames();
            for (int i = 0; i < facnames.Count; i++)
                facultbox.Items.Add(facnames[i]);
            List<string> specnames = controller.GetSpecialtyNames();
            for (int i = 0; i < specnames.Count; i++)
                specbox.Items.Add(specnames[i]);
        }

        private void universitiesBox_DoubleClick(object sender, EventArgs e)
        {
            if (universitiesbox.SelectedIndex != -1)
            {
                UniversityInfo univerInfo = new UniversityInfo();
                string[] stringbox = new string[2];
                univerInfo.namebox.Text = Convert.ToString(universitiesbox.Items[universitiesbox.SelectedIndex]);
                stringbox = univerInfo.namebox.Text.Split(',');
                if (stringbox.Length == 1)
                {
                    University univer = new University();
                    for (int i = 0; i < controller.UniversitiesList.Count; i++)
                        if (controller.UniversitiesList[i].Name == univerInfo.namebox.Text)
                            univer = controller.UniversitiesList[i];

                    univerInfo.namebox.Text = univer.FullName;
                    univerInfo.adressbox.Text = univer.Adress;
                    univerInfo.citybox.Text = univer.City;
                    for (int i = 0; i < univer.Faculties.Count; i++)
                        univerInfo.boxoffac.Items.Add(univer.Faculties[i].Name);
                    univerInfo.ShowDialog();
                }
                else
                {
                    univerInfo.namebox.Text = stringbox[0];
                    University univer = new University();
                    for (int i = 0; i < controller.UniversitiesList.Count; i++)
                        if (controller.UniversitiesList[i].Name == stringbox[0])
                            univer = controller.UniversitiesList[i];
                    univerInfo.namebox.Text = univer.FullName;
                    univerInfo.adressbox.Text = univer.Adress;
                    univerInfo.citybox.Text = univer.City;
                    for (int i = 0; i < univer.Faculties.Count; i++)
                        univerInfo.boxoffac.Items.Add(univer.Faculties[i].Name);
                    univerInfo.ShowDialog();
                }
            }
        }


        private void search_Click_1(object sender, EventArgs e)//поиск
        {
            universitiesbox.Items.Clear();

            try
            {

                Dictionary<string, double> tests = new Dictionary<string, double>();//создаем словарь из всех тестов
                tests.Add("УЯиЛ", ukrbox.Text == String.Empty ? 0 : Convert.ToDouble(ukrbox.Text));
                tests.Add("ИУ", histukrbox.Text == String.Empty ? 0 : Convert.ToDouble(histukrbox.Text));
                tests.Add("Б", biologbox.Text == String.Empty ? 0 : Convert.ToDouble(biologbox.Text));
                tests.Add("Х", chembox.Text == String.Empty ? 0 : Convert.ToDouble(chembox.Text));
                tests.Add("Ф", physbox.Text == String.Empty ? 0 : Convert.ToDouble(physbox.Text));
                tests.Add("ВИ", worldhistbox.Text == String.Empty ? 0 : Convert.ToDouble(worldhistbox.Text));
                tests.Add("Г", geogrbox.Text == String.Empty ? 0 : Convert.ToDouble(geogrbox.Text));
                tests.Add("РЯ", rusbox.Text == String.Empty ? 0 : Convert.ToDouble(rusbox.Text));
                tests.Add("ИЯ", langbox.Text == String.Empty ? 0 : Convert.ToDouble(langbox.Text));
                tests.Add("М", mathbox.Text == String.Empty ? 0 : Convert.ToDouble(mathbox.Text));
                tests.Add("БА", attestatbox.Text == String.Empty ? 0 : Convert.ToDouble(attestatbox.Text));
               
                bool isMore = false;
                bool isLess = false;
                string error = "";
                if (tests.Values.Max() != 0)
                {
                    if (tests.Values.Max() > 200)
                    {
                        error += "Результат тестирования не может превышать 200 баллов\n";
                        isMore = true;
                    }
                    /*Нахождение минимального введенного теста*/
                    double[] values = tests.Values.ToArray();
                    double min = values[0];
                    for (int i = 1; i < values.Length; i++)
                    {
                        if (min > values[i] && values[i] != 0 || min == 0)
                            min = values[i];
                    }
                    if (min < 113 && min != 0)
                    {
                        error += "Результат тестирования не может быть меньше 113 баллов\n";
                        isLess = true;
                    }
                }
               
                if (isMore == false && isLess == false)//если все с введенными данными нормально
                {
                    bool isCheckedd = dayformofstud.Checked;
                    bool isCheckedh = halfstudy.Checked;
                    List<string> univname = controller.Search(univbox.Text, citybox.Text,
                                            cashfrombox.Text == String.Empty ? 0 : Convert.ToDouble(cashfrombox.Text),
                                            cashtobox.Text == String.Empty ? 0 : Convert.ToDouble(cashtobox.Text),
                                            isCheckedd, isCheckedh, direcbox.Text, facultbox.Text,
                                            specbox.Text, ratefrombox.Text == String.Empty ? 0 : Convert.ToDouble(ratefrombox.Text),
                                            ratetobox.Text == String.Empty ? 0 : Convert.ToDouble(ratetobox.Text), tests);
                    for (int i = 0; i < univname.Count; i++)
                        universitiesbox.Items.Add(univname[i]);
                }
                else if(!Equals(error, ""))
                {
                    MessageBox.Show(error, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void adduniv_Click(object sender, EventArgs e)//добавление университета
        {
            UniversityAdd university = new UniversityAdd();
            university.univerController = this.controller;
            university.Show();
        }

        private void UserInterface_KeyDown(object sender, KeyEventArgs e)//кнопка поиска, чтоб реализовывалась через enter
        {
            if (e.KeyCode == Keys.Enter)
                search_Click_1(sender, e);
        }

        private void changeuniv_Click(object sender, EventArgs e)//удаление
        {
            DeleteUniversity delUniver = new DeleteUniversity();
            delUniver.deleteUniverController = this.controller;
            List<string> unname = new List<string>();
            for (int i = 0; i < controller.UniversitiesList.Count; i++)
                unname.Add(controller.UniversitiesList[i].Name);
            controller.Sort(unname);
            for (int i = 0; i < unname.Count; i++)
                delUniver.universitiesListToDelete.Items.Add(unname[i]);
            delUniver.ShowDialog();
        }
        
        private void forusingbt_Click(object sender, EventArgs e)//справка
        {
            Manual fu = new Manual();
            fu.Show();
        }

        private void renew_Click(object sender, EventArgs e)//обновление полей
        {
            citybox.Items.Clear();
            univbox.Items.Clear();
            direcbox.Items.Clear();
            facultbox.Items.Clear();
            specbox.Items.Clear();
            List<string> cities = controller.GetCities();
            for (int i = 0; i < cities.Count; i++)
                citybox.Items.Add(cities[i]);
            List<string> univ = controller.GetUnivNames();
            for (int i = 0; i < univ.Count; i++)
                univbox.Items.Add(univ[i]);
            List<string> direc = controller.GetDirection();
            for (int i = 0; i < direc.Count; i++)
                direcbox.Items.Add(direc[i]);
            List<string> facnames = controller.GetFacultyNames();
            for (int i = 0; i < facnames.Count; i++)
                facultbox.Items.Add(facnames[i]);
            List<string> specnames = controller.GetSpecialtyNames();
            for (int i = 0; i < specnames.Count; i++)
                specbox.Items.Add(specnames[i]);
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(LoginAs));
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            this.Close();
        }

        private void LoginAs()
        {
            Application.Run(new LoginAs());
        }
    }
}