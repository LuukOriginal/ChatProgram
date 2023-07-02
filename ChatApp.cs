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
                //First time use (send post request to server to create new user, or if already existing use existing user)
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

                //Saves the id for the account that we just logged onto in the application
                Properties.Settings.Default.UserId = userId;
                Properties.Settings.Default.Save();

                MessageBox.Show("LOGGED IN: " + userId);
            }
            else
            {
                MessageBox.Show("Logged in to user with id:" + Properties.Settings.Default.UserId);
            }

            DateTime curTime = DateTime.Now;

            //Creating some example messages
            newMessage("Hallo John!", curTime.AddSeconds(-20), true);
            newMessage("Oh hallo Bob!", curTime.AddSeconds(-15));
            newMessage("Hoe gaat het?", curTime.AddSeconds(-10), true);
            newMessage("Prima joh", curTime.AddSeconds(-5));
        }

        private void Add_Btn_Click(object sender, EventArgs e)
        {
            string value = "";
            if (InputBox("Add Friend", "Enter your friends id here:", ref value, true) == DialogResult.OK)
            {
                //Not implemented yet, this is going to be the button to be able to add other users
                MessageBox.Show(value);
            }
        }

        public static DialogResult InputBox(string title, string promptText, ref string value, bool onlyNumber = false)
        {
            //Handles part of the popup window where you need to input some text
            InputDialog dialog = new InputDialog(title, promptText, value, onlyNumber);

            dialog.Text = title;

            DialogResult dialogResult = dialog.ShowDialog();

            value = dialog.inputText;

            return dialogResult;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Resets the stored id, and closes the application, next time you open you need to login again
            Properties.Settings.Default.Reset();
            Application.Exit();
        }


        private void newMessage(string message, DateTime time, bool isClient = false)
        {
            //Creates the messages that show up in the chat window
            message = $"{time.ToString("HH:mm")} - {message}";
            Panel MessageContainer = new Panel();
            MessageWindow.Controls.Add(MessageContainer);
            MessageWindow.Controls.SetChildIndex(MessageContainer, 0);
            MessageContainer.Dock = DockStyle.Top;
            MessageContainer.Height = 55;

            Panel MessagePanel = new Panel();
            MessageContainer.Controls.Add(MessagePanel);
            MessagePanel.Dock = isClient ? DockStyle.Left : DockStyle.Right; //if isClient is true then the message gets aligned to the left, else it will align to the right
            MessagePanel.BackColor = isClient ? Color.FromArgb(31, 38, 45) : Color.FromArgb(38, 39, 46); //Changes the color depending on whether the message is from the client or server

            TextBox Message = new TextBox();
            MessagePanel.Controls.Add(Message);
            Message.Multiline = true;
            Message.Text = message;
            Message.ForeColor = isClient ? Color.FromArgb(112, 192, 175) : Color.Gainsboro; //Changes the text color depending on who sent it (Client/Server)
            Message.BorderStyle = BorderStyle.None;
            Message.ReadOnly = true;
            Message.BackColor = Message.Parent.BackColor;

            Size textBounds = TextRenderer.MeasureText(message, Message.Font);
            MessageContainer.Height = textBounds.Height + 10;
            MessagePanel.Width = textBounds.Width + 10;
            Message.Size = textBounds;

            Message.Location = new Point(Message.Location.X + 5, Message.Location.Y + 5);

            Panel EmptySpace = new Panel(); //Adds a small gap between the messages to seperate the messages.
            EmptySpace.Dock = DockStyle.Top;
            EmptySpace.Height = 5;
            MessageWindow.Controls.Add(EmptySpace);
            MessageWindow.Controls.SetChildIndex(EmptySpace, 0);

            Tooltip.SetToolTip(Message, time.ToString()); //Shows the time and date the message got sent when hovering over
        }

        private void MessageInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return) //Check if the message got sent
            {
                e.Handled = true; //Prevent the beep noise from windows.
                if(MessageInput.Text.Replace(" ", string.Empty).Length > 0) //Check if the message is not just spacebars or empty
                {
                    newMessage(MessageInput.Text, DateTime.Now, true); //Create the message
                    MessageInput.Clear(); //Clear the textbox
                }
            }
        }
    }
}
