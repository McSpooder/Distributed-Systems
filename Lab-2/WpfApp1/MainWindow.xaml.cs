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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.AspNetCore.SignalR.Client;


namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        protected HubConnection connection;
        public MainWindow()
        {
            InitializeComponent();
            MessageTextBox.IsEnabled = false;
            btnSend.IsEnabled = false;
            //connection = new HubConnectionBuilder().WithUrl("http://150.237.201.206:5000/ChatHub").Build(); //uses kestrel instead of iisexpress
            connection = new HubConnectionBuilder().WithUrl("http://localhost:51259/ChatHub").Build();
            connection.On<string, string>("GetMessage",
                new Action<string, string>((username, message) =>
                GetMessage(username, message)));
            connection.On<string>("UserDisconnected",
                new Action<string>((username) => UserDisconnected(username)));
            connection.On<string>("RemoveUserMessages",
                new Action<string>((username) => RemoveUserMessages(username)));

        }

        private void GetMessage(string username, string message)
        {
            this.Dispatcher.Invoke(() =>
            {
                var chat = $"{username}: {message}";
                MessageListBox.Items.Add(chat);
                
            });
        }

        private void UserDisconnected(string username)
        {
            this.Dispatcher.Invoke(() =>
            {
                var chat = $"{username}: disconnected from the chat :(";
                MessageListBox.Items.Add(chat);
            });
        }

        private void RemoveUserMessages(string username)
        {
            for (var i = 0; i < MessageListBox.Items.Count; i++)
            {
                if (MessageListBox.Items[i].ToString().Contains(username))
                {
                    MessageListBox.Items.RemoveAt(i);
                }
            }
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                await connection.StartAsync();
                MessageListBox.Items.Add("Connection opened");
                UsernameTextBox.IsEnabled = false;
                btnConnect.IsEnabled = false;
                btnDisconnect.IsEnabled = true;
                MessageTextBox.IsEnabled = true;
                btnSend.IsEnabled = true;
            }
            catch
            {
                MessageListBox.Items.Add("Connection failed");
            }
        }

        private async void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                await connection.InvokeAsync("BroadcastMessage", UsernameTextBox.Text, MessageTextBox.Text);
                MessageTextBox.Text = "";
            }
            catch (Exception ex)
            {
                MessageListBox.Items.Add(ex.Message);
            }
        }

        private async void BtnDisconnect_Click(object sender, RoutedEventArgs e)
        {
            await connection.InvokeAsync("BroadcastDisconnect", UsernameTextBox.Text);

            btnDisconnect.IsEnabled = false;
            btnConnect.IsEnabled = true;
            UsernameTextBox.IsEnabled = true;
            MessageTextBox.IsEnabled = false;
            btnSend.IsEnabled = false;

            await connection.StopAsync();

        }

        private void MessageTextBox_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageTextBox.Text = "";
        }

        private void MessageTextBox_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MessageTextBox.Text = "";
        }

        private void MessageTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            MessageTextBox.Text = "";
        }
    }
}
