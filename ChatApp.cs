using ChatProgram.Handlers;
using Newtonsoft.Json;
using System;
using System.Windows.Forms;
using System.Drawing;

namespace ChatProgram
{
    public partial class ChatApp : Form
    {
        EndpointHandler Api = new EndpointHandler("http://localhost:8080");

        public ChatApp()
        {
            InitializeComponent();
        }

        class User
        {
            public string _id;
            public string username;
        }

        private void ChatApp_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.UserId == string.Empty)
            {
                //First time use (send post request to server to create new user)
                string userId;
                while (true)
                {
                    string userName = "";
                    if (InputBox("Setup", "Choose a username:", ref userName) == DialogResult.OK)
                    {
                        if (userName.Replace(" ", string.Empty) == string.Empty) continue;

                        string userRaw = Api.GetUser(userName);
                        User user = JsonConvert.DeserializeObject<User>(userRaw);

                        if(user._id != null)
                        {
                            userId = user._id;
                        }
                        else
                        {
                            userId = Api.CreateUser(userName);
                        }

                        break;
                    }
                }

                MessageBox.Show("LOGGED IN: " + userId);

                Properties.Settings.Default.UserId = userId;
                Properties.Settings.Default.Save();

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

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reset();
            Application.Exit();
        }


        private void SentMessage(string message, int time)
        {
            Panel MessageContainer = new Panel();
            MessagePanel.Controls.Add(MessageContainer);
            MessageContainer.Dock = DockStyle.Top;
            MessageContainer.Size = new Size(0,55);
            MessageContainer.BackColor = Color.White;
            Panel Message = new Panel();
        }
    }
}
