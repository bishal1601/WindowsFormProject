using System.Text.RegularExpressions;
using WinFormsApp1.Dto;
using WinFormsApp1.Services.Interfaces;

namespace WinFormsApp1;

public partial class UserRegisterForm : Form
{
    private readonly IUserService _userService;
    public UserRegisterForm(IUserService userService)
    {
        InitializeComponent();
        _userService = userService;
    }

    private void label4_Click(object sender, EventArgs e)
    {
        
    }

    private void UserRegisterForm_Load(object sender, EventArgs e)
    {
        
    }

    private void button1_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void button2_Click(object sender, EventArgs e)
    {
        try
        {
            var isformdataenter = string.IsNullOrEmpty(txtcontact.Text) ||
                                  string.IsNullOrEmpty(txtemail.Text) ||
                                  string.IsNullOrEmpty(txtaddresh.Text) ||
                                  string.IsNullOrEmpty(txtname.Text) ||
                                  string.IsNullOrEmpty(txtpassword.Text) ||
                                  string.IsNullOrEmpty(txtusername.Text);

            if (isformdataenter)
            {
                MessageBox.Show("Enter all fields");
                return;
            }

            if (!IsValidEmail(txtemail.Text))
            {
                MessageBox.Show("Please enter a valid email address");
                return;
            }
            var dto = new UsersDto()
                {
                    Address = txtaddresh.Text,
                    FullName = txtusername.Text,
                    Contact = txtcontact.Text,
                    Username = txtusername.Text,
                    Email = txtemail.Text,
                    Password = txtpassword.Text,
                };
                _userService.Create(dto);
                MessageBox.Show("User created successfully");
                this.Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }
    private bool IsValidEmail(string email)
    {
        var emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
        return Regex.IsMatch(email, emailPattern);
    }
}