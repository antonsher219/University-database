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
using System.Threading;

namespace UserInterface
{
    public partial class Login : Form
    {
        Controller controller = new Controller();
        public Login()
        {
            InitializeComponent();
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            if (loginbox.Text == controller.login && passwordbox.Text == controller.password)
            {
                Thread thread = new Thread(new ThreadStart(OpenA));
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
                Controller.Root = true;
                this.Close();
            }
            else                    
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        
        private void OpenA()
        {
            Application.Run(new UserInterface(Controller.Root));
        }

        private void CancelBtn_Click(object sender, EventArgs e)
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

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
