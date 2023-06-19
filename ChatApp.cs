using ChatProgram.Handlers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatProgram
{
    public partial class ChatApp : Form
    {
        EndpointHandler Api = new EndpointHandler("http://localhost:8080");

        public ChatApp()
        {
            InitializeComponent();
        }

        private void ChatApp_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.UserId == string.Empty)
            {
                //First time use (send post request to server to create new user)
                string UserId = Api.CreateUser("LuukOriginal");
                Properties.Settings.Default.UserId = UserId;
                Properties.Settings.Default.Save();
                MessageBox.Show("Account Created!");
            }
            else
            {
                MessageBox.Show("Logged in to user with id:" + Properties.Settings.Default.UserId);
            }
        }

        private void Add_Btn_Click(object sender, EventArgs e)
        {
            string value = "";
            if (InputBox("Add Friend", "Enter your friends id here:", ref value, true) == DialogResult.OK)
            {
                MessageBox.Show(value);
            }
        }

        public static DialogResult InputBox(string title, string promptText, ref string value, bool onlyNumber = false)
        {
            InputDialog dialog = new InputDialog(title, promptText, value, onlyNumber);

            dialog.Text = title;

            DialogResult dialogResult = dialog.ShowDialog();

            value = dialog.inputText;

            return dialogResult;
        }

    }
}
