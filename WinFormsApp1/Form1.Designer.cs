namespace WinFormsApp1;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
        lUsername = new System.Windows.Forms.Label();
        label1 = new System.Windows.Forms.Label();
        panel1 = new System.Windows.Forms.Panel();
        button1 = new System.Windows.Forms.Button();
        label2 = new System.Windows.Forms.Label();
        txtusername = new System.Windows.Forms.TextBox();
        txtpassword = new System.Windows.Forms.TextBox();
        button2 = new System.Windows.Forms.Button();
        create = new System.Windows.Forms.LinkLabel();
        panel1.SuspendLayout();
        SuspendLayout();
        // 
        // lUsername
        // 
        lUsername.Font = new System.Drawing.Font("Sitka Text Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lUsername.Location = new System.Drawing.Point(25, 99);
        lUsername.Name = "lUsername";
        lUsername.Size = new System.Drawing.Size(100, 23);
        lUsername.TabIndex = 0;
        lUsername.Text = "Username";
        lUsername.Click += label1_Click;
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Sitka Text Semibold", 16F, System.Drawing.FontStyle.Bold);
        label1.Location = new System.Drawing.Point(70, 9);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(175, 43);
        label1.TabIndex = 2;
        label1.Text = "Welcome Back ";
        // 
        // panel1
        // 
        panel1.Controls.Add(button1);
        panel1.Controls.Add(label1);
        panel1.Dock = System.Windows.Forms.DockStyle.Top;
        panel1.Location = new System.Drawing.Point(0, 0);
        panel1.Name = "panel1";
        panel1.Size = new System.Drawing.Size(314, 57);
        panel1.TabIndex = 3;
        // 
        // button1
        // 
        button1.Location = new System.Drawing.Point(293, 2);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(21, 22);
        button1.TabIndex = 7;
        button1.Text = "X";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click_1;
        // 
        // label2
        // 
        label2.Font = new System.Drawing.Font("Sitka Text Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label2.Location = new System.Drawing.Point(25, 144);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(100, 23);
        label2.TabIndex = 4;
        label2.Text = "Password";
        // 
        // txtusername
        // 
        txtusername.Font = new System.Drawing.Font("Sitka Text Semibold", 12F, System.Drawing.FontStyle.Bold);
        txtusername.Location = new System.Drawing.Point(125, 96);
        txtusername.Name = "txtusername";
        txtusername.Size = new System.Drawing.Size(171, 28);
        txtusername.TabIndex = 5;
        // 
        // txtpassword
        // 
        txtpassword.Font = new System.Drawing.Font("Sitka Text Semibold", 12F, System.Drawing.FontStyle.Bold);
        txtpassword.Location = new System.Drawing.Point(125, 141);
        txtpassword.Name = "txtpassword";
        txtpassword.PasswordChar = '*';
        txtpassword.Size = new System.Drawing.Size(171, 28);
        txtpassword.TabIndex = 6;
        // 
        // button2
        // 
        button2.Font = new System.Drawing.Font("Sitka Text Semibold", 12F, System.Drawing.FontStyle.Bold);
        button2.Location = new System.Drawing.Point(35, 192);
        button2.Name = "button2";
        button2.Size = new System.Drawing.Size(258, 38);
        button2.TabIndex = 7;
        button2.Text = "Log In";
        button2.UseVisualStyleBackColor = true;
        button2.Click += button2_Click;
        // 
        // create
        // 
        create.Location = new System.Drawing.Point(180, 236);
        create.Name = "create";
        create.Size = new System.Drawing.Size(112, 23);
        create.TabIndex = 8;
        create.TabStop = true;
        create.Text = "Create an account";
        create.LinkClicked += create_LinkClicked;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)224)), ((int)((byte)224)));
        ClientSize = new System.Drawing.Size(314, 261);
        Controls.Add(create);
        Controls.Add(button2);
        Controls.Add(txtpassword);
        Controls.Add(txtusername);
        Controls.Add(label2);
        Controls.Add(panel1);
        Controls.Add(lUsername);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Form1";
        panel1.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.LinkLabel create;

    private System.Windows.Forms.Button button2;

    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtusername;
    private System.Windows.Forms.TextBox txtpassword;

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Panel panel1;

    private System.Windows.Forms.Button button1;

    private System.Windows.Forms.Label lUsername;

    #endregion
}