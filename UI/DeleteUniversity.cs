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

namespace UserInterface
{
    public partial class DeleteUniversity : Form
    {
        public Controller deleteUniverController;
        public DeleteUniversity()
        {
            InitializeComponent();
        }

        private void deleteUniv_Click(object sender, EventArgs e)
        {
            if (universitiesListToDelete.SelectedIndex != -1)
            {
                var result = MessageBox.Show("Удалить выбраный университет?" +
                    " При удалении он исчезнет из базы университетов и не подлежит востановлению.",
                    "Удаление университета",MessageBoxButtons.YesNo,MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                {
                    for (int i = 0; i < deleteUniverController.UniversitiesList.Count; i++)
                        if (universitiesListToDelete.SelectedItem.ToString() == deleteUniverController.UniversitiesList[i].Name)
                        {
                            deleteUniverController.UniversitiesList.Remove(deleteUniverController.UniversitiesList[i]);
                            break;
                        }
                    deleteUniverController.Save(deleteUniverController.UniversitiesList);
                    universitiesListToDelete.Items.Clear();
                    for (int i = 0; i < deleteUniverController.UniversitiesList.Count; i++)
                        universitiesListToDelete.Items.Add(deleteUniverController.UniversitiesList[i].Name);
                }
               
            }
        }
        
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
