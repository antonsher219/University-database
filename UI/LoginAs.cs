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
    public partial class LoginAs : Form
    {
        public LoginAs()
        {
            InitializeComponent();
        }
        
        private void adminButton_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(OpenAdminLogin));
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            this.Close();
        }

        private void userButton_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(OpenGuest));
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            Controller.Root = false;
            this.Close();
        }
        private void OpenGuest()
        {
            Application.Run(new UserInterface(Controller.Root));
        }

        private void OpenAdminLogin()
        {
            Application.Run(new Login());
        }

        private void LoginAs_Load(object sender, EventArgs e)
        {

        }
    }
}
