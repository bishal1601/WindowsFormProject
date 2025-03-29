using System.ComponentModel;

namespace WinFormsApp1;

partial class UserRegisterForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        label1 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        label3 = new System.Windows.Forms.Label();
        label4 = new System.Windows.Forms.Label();
        label5 = new System.Windows.Forms.Label();
        label6 = new System.Windows.Forms.Label();
        label7 = new System.Windows.Forms.Label();
        txtname = new System.Windows.Forms.TextBox();
        txtaddresh = new System.Windows.Forms.TextBox();
        txtemail = new System.Windows.Forms.TextBox();
        txtpassword = new System.Windows.Forms.TextBox();
        txtusername = new System.Windows.Forms.TextBox();
        button1 = new System.Windows.Forms.Button();
        button2 = new System.Windows.Forms.Button();
        txtcontact = new System.Windows.Forms.MaskedTextBox();
        SuspendLayout();
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Sitka Text Semibold", 16F, System.Drawing.FontStyle.Bold);
        label1.Location = new System.Drawing.Point(128, 18);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(160, 38);
        label1.TabIndex = 0;
        label1.Text = "Register User";
        // 
        // label2
        // 
        label2.Font = new System.Drawing.Font("Sitka Text Semibold", 12F);
        label2.Location = new System.Drawing.Point(39, 81);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(127, 31);
        label2.TabIndex = 1;
        label2.Text = "Full Name";
        // 
        // label3
        // 
        label3.Font = new System.Drawing.Font("Sitka Text Semibold", 12F);
        label3.Location = new System.Drawing.Point(39, 112);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(127, 31);
        label3.TabIndex = 2;
        label3.Text = "Address";
        // 
        // label4
        // 
        label4.Font = new System.Drawing.Font("Sitka Text Semibold", 12F, System.Drawing.FontStyle.Bold);
        label4.Location = new System.Drawing.Point(39, 143);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(127, 31);
        label4.TabIndex = 3;
        label4.Text = "Contact No.";
        label4.Click += label4_Click;
        // 
        // label5
        // 
        label5.Font = new System.Drawing.Font("Sitka Text Semibold", 12F);
        label5.Location = new System.Drawing.Point(39, 174);
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(127, 31);
        label5.TabIndex = 4;
        label5.Text = "E-mail Address";
        // 
        // label6
        // 
        label6.Font = new System.Drawing.Font("Sitka Text Semibold", 12F);
        label6.Location = new System.Drawing.Point(39, 205);
        label6.Name = "label6";
        label6.Size = new System.Drawing.Size(127, 31);
        label6.TabIndex = 5;
        label6.Text = "Username";
        // 
        // label7
        // 
        label7.Font = new System.Drawing.Font("Sitka Text Semibold", 12F);
        label7.Location = new System.Drawing.Point(39, 236);
        label7.Name = "label7";
        label7.Size = new System.Drawing.Size(127, 31);
        label7.TabIndex = 6;
        label7.Text = "Password";
        // 
        // txtname
        // 
        txtname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        txtname.Font = new System.Drawing.Font("Sitka Text Semibold", 12F);
        txtname.Location = new System.Drawing.Point(172, 83);
        txtname.Name = "txtname";
        txtname.Size = new System.Drawing.Size(199, 28);
        txtname.TabIndex = 1;
        // 
        // txtaddresh
        // 
        txtaddresh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        txtaddresh.Font = new System.Drawing.Font("Sitka Text Semibold", 12F);
        txtaddresh.Location = new System.Drawing.Point(172, 114);
        txtaddresh.Name = "txtaddresh";
        txtaddresh.Size = new System.Drawing.Size(199, 28);
        txtaddresh.TabIndex = 7;
        // 
        // txtemail
        // 
        txtemail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        txtemail.Font = new System.Drawing.Font("Sitka Text Semibold", 12F);
        txtemail.Location = new System.Drawing.Point(172, 176);
        txtemail.Name = "txtemail";
        txtemail.Size = new System.Drawing.Size(199, 28);
        txtemail.TabIndex = 9;
        // 
        // txtpassword
        // 
        txtpassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        txtpassword.Font = new System.Drawing.Font("Sitka Text Semibold", 12F);
        txtpassword.Location = new System.Drawing.Point(172, 238);
        txtpassword.Name = "txtpassword";
        txtpassword.PasswordChar = '*';
        txtpassword.Size = new System.Drawing.Size(199, 28);
        txtpassword.TabIndex = 11;
        // 
        // txtusername
        // 
        txtusername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        txtusername.Font = new System.Drawing.Font("Sitka Text Semibold", 12F);
        txtusername.Location = new System.Drawing.Point(172, 207);
        txtusername.Name = "txtusername";
        txtusername.Size = new System.Drawing.Size(199, 28);
        txtusername.TabIndex = 10;
        // 
        // button1
        // 
        button1.BackColor = System.Drawing.Color.Red;
        button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
        button1.Font = new System.Drawing.Font("Sitka Text Semibold", 12F);
        button1.ForeColor = System.Drawing.Color.White;
        button1.Location = new System.Drawing.Point(39, 294);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(165, 40);
        button1.TabIndex = 12;
        button1.Text = "Close";
        button1.UseVisualStyleBackColor = false;
        button1.Click += button1_Click;
        // 
        // button2
        // 
        button2.BackColor = System.Drawing.Color.FromArgb(((int)((byte)0)), ((int)((byte)192)), ((int)((byte)0)));
        button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
        button2.Font = new System.Drawing.Font("Sitka Text Semibold", 12F);
        button2.ForeColor = System.Drawing.Color.White;
        button2.Location = new System.Drawing.Point(206, 294);
        button2.Name = "button2";
        button2.Size = new System.Drawing.Size(165, 40);
        button2.TabIndex = 13;
        button2.Text = "Submit";
        button2.UseVisualStyleBackColor = false;
        button2.Click += button2_Click;
        // 
        // txtcontact
        // 
        txtcontact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        txtcontact.Font = new System.Drawing.Font("Sitka Text Semibold", 12F);
        txtcontact.Location = new System.Drawing.Point(172, 145);
        txtcontact.Mask = "0000000000";
        txtcontact.Name = "txtcontact";
        txtcontact.Size = new System.Drawing.Size(199, 28);
        txtcontact.TabIndex = 14;
        // 
        // UserRegisterForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(404, 367);
        ControlBox = false;
        Controls.Add(txtcontact);
        Controls.Add(button2);
        Controls.Add(button1);
        Controls.Add(txtpassword);
        Controls.Add(txtusername);
        Controls.Add(txtemail);
        Controls.Add(txtaddresh);
        Controls.Add(txtname);
        Controls.Add(label7);
        Controls.Add(label6);
        Controls.Add(label5);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "UserRegisterForm";
        Load += UserRegisterForm_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.MaskedTextBox txtcontact;

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;

    private System.Windows.Forms.TextBox txtaddresh;
    private System.Windows.Forms.TextBox txtemail;
    private System.Windows.Forms.TextBox txtpassword;
    private System.Windows.Forms.TextBox txtusername;

    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.TextBox txtname;

    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;

    private System.Windows.Forms.Label label1;

    #endregion
}