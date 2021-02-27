using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SimpleChat
{
    /// <summary>
    /// Interaction logic for ChatWindow.xaml
    /// </summary>
    public partial class ChatWindow : Window
    {
        ChatManager _chatManager;
        User _user;
        
        public ChatWindow(ChatManager chatManager, User user)
        {
            InitializeComponent();
            _chatManager = chatManager;
            _user = user;

            _chatManager.OnUserNumberChanged += SetNewCountUser;
            _user.OnReceived += Received;
            this.Title = _user.Username;
        }

        public void Received(Message message)
        {
            if (message.Initiator.Username != _user.Username)
                MessageReceived(message);
        }

        public void SetNewCountUser(object sender, int count)
        {
            UserNumberChanged(count);
        }

        // YOU DON'T NEED TO EDIT THE CODE BELOW, UNLESS YOU WANT TO CHANGE
        // THE VISUAL APPEARANCE OF YOUR APPLICATION - YOU ARE FREE TO DO THIS
        private void UserNumberChanged(int number)
        {
            textBlockUsersNum.Text = number.ToString() + " active users";
        }

        private void VisualizeNewMessage(string message, string initiator)
        {
            // Other user's message
            if (initiator != null)
            {
                listBoxMessages.Items.Add(new ListBoxItem
                {
                    Content = new TextBlock
                    {
                        TextWrapping = TextWrapping.Wrap,
                        Text = initiator + " says:",
                        TextAlignment = TextAlignment.Right
                    },
                    Background = new SolidColorBrush(Colors.Bisque),
                    HorizontalContentAlignment = System.Windows.HorizontalAlignment.Stretch
                });
            }

            listBoxMessages.Items.Add(new ListBoxItem
            {
                Content = new TextBlock
                {
                    TextWrapping = TextWrapping.Wrap,
                    Text = message,
                    TextAlignment = initiator != null ? TextAlignment.Right : TextAlignment.Left
                },
                HorizontalContentAlignment = System.Windows.HorizontalAlignment.Stretch
            });

            listBoxMessages.SelectedIndex = listBoxMessages.Items.Count - 1;
            listBoxMessages.ScrollIntoView(listBoxMessages.SelectedItem);
        }

        private void MessageReceived(Message message)
        {
            VisualizeNewMessage(message.Data, message.Initiator.Username);
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
        }

        private void buttonSend_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxMessage.Text))
            { 
                _user.Send(textBoxMessage.Text);

                VisualizeNewMessage(textBoxMessage.Text, null);
                textBoxMessage.Clear();
            }
        }

        private void buttonJoin_Click(object sender, RoutedEventArgs e)
        {
            _chatManager.AddUser(_user);
            buttonJoin.IsEnabled = false;
            buttonLeave.IsEnabled = true;
        }

        private void buttonLeave_Click(object sender, RoutedEventArgs e)
        {
            _chatManager.RemoveUser(_user);
            buttonJoin.IsEnabled = true;
            buttonLeave.IsEnabled = false;
        }
    }
}
