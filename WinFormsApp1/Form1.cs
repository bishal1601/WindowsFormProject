using Microsoft.Extensions.DependencyInjection;
using WinFormsApp1.Services.Interfaces;

namespace WinFormsApp1;

public partial class Form1 : Form
{
    private readonly IUserService _userService;

    
    public Form1(IUserService userService)
    {
        InitializeComponent();
        _userService = userService;
    }

    private void label1_Click(object sender, EventArgs e)
    {
        // You can implement additional logic here if needed
    }

    private void button1_Click(object sender, EventArgs e)
    {
        MessageBox.Show("Hello World!");
    }

    private void button1_Click_1(object sender, EventArgs e)
    {
        this.Close();
    }

    private void button2_Click(object sender, EventArgs e)
    {
        try
        {
            var username = txtusername.Text;
            var password = txtpassword.Text;
            var isusernameenter = string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password);
            if (isusernameenter)
            {
                MessageBox.Show("Enter username and password");
                return;
            }

            if (username == "admin" && password == "admin")
            {
                MessageBox.Show("You are logged in");
            }
            else
            {
                MessageBox.Show("Wrong username or password");
            }
        }
        catch (Exception exception)
        {
            Console.WriteLine(exception);
            throw;
        }
    }

    private void create_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        // Resolve UserRegisterForm from DI container
        var register = Program.ServiceProvider.GetService<UserRegisterForm>();
        if (register != null)
        {
            this.Hide();
            register.ShowDialog();
            this.Show();
        }
        else
        {
            MessageBox.Show("Error: Could not load the registration form.");
        }
    }
}