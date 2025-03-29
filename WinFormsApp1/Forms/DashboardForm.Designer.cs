using System.ComponentModel;

namespace WinFormsApp1;

partial class DashboardForm
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
        panel1 = new System.Windows.Forms.Panel();
        lwelcome = new System.Windows.Forms.Label();
        menuStrip1 = new System.Windows.Forms.MenuStrip();
        Master = new System.Windows.Forms.ToolStripMenuItem();
        newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
        toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
        toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
        toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
        toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
        panel1.SuspendLayout();
        menuStrip1.SuspendLayout();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.Controls.Add(lwelcome);
        panel1.Controls.Add(menuStrip1);
        panel1.Dock = System.Windows.Forms.DockStyle.Top;
        panel1.Location = new System.Drawing.Point(0, 0);
        panel1.Name = "panel1";
        panel1.Size = new System.Drawing.Size(800, 35);
        panel1.TabIndex = 0;
        // 
        // lwelcome
        // 
        lwelcome.BackColor = System.Drawing.Color.Transparent;
        lwelcome.Dock = System.Windows.Forms.DockStyle.Right;
        lwelcome.Font = new System.Drawing.Font("Sitka Text Semibold", 12F);
        lwelcome.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
        lwelcome.Location = new System.Drawing.Point(586, 0);
        lwelcome.Name = "lwelcome";
        lwelcome.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
        lwelcome.Size = new System.Drawing.Size(214, 35);
        lwelcome.TabIndex = 0;
        lwelcome.Text = "welcome";
        lwelcome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // menuStrip1
        // 
        menuStrip1.BackColor = System.Drawing.Color.Transparent;
        menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
        menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { Master });
        menuStrip1.Location = new System.Drawing.Point(0, 0);
        menuStrip1.Name = "menuStrip1";
        menuStrip1.Size = new System.Drawing.Size(800, 35);
        menuStrip1.TabIndex = 1;
        menuStrip1.Text = "menuStrip1";
        // 
        // Master
        // 
        Master.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { newToolStripMenuItem });
        Master.Font = new System.Drawing.Font("Sitka Text Semibold", 12F);
        Master.Name = "Master";
        Master.Size = new System.Drawing.Size(77, 31);
        Master.Text = "Master";
        Master.Click += Master_Click;
        // 
        // newToolStripMenuItem
        // 
        newToolStripMenuItem.Font = new System.Drawing.Font("Sitka Text Semibold", 10F);
        newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
        newToolStripMenuItem.Name = "newToolStripMenuItem";
        newToolStripMenuItem.ShowShortcutKeys = false;
        newToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
        newToolStripMenuItem.Text = "Product";
        newToolStripMenuItem.Click += newToolStripMenuItem_Click;
        // 
        // toolStripMenuItem1
        // 
        toolStripMenuItem1.Name = "toolStripMenuItem1";
        toolStripMenuItem1.Size = new System.Drawing.Size(32, 19);
        // 
        // toolStripMenuItem2
        // 
        toolStripMenuItem2.Name = "toolStripMenuItem2";
        toolStripMenuItem2.Size = new System.Drawing.Size(32, 19);
        // 
        // toolStripMenuItem3
        // 
        toolStripMenuItem3.Name = "toolStripMenuItem3";
        toolStripMenuItem3.Size = new System.Drawing.Size(32, 19);
        // 
        // toolStripMenuItem4
        // 
        toolStripMenuItem4.Name = "toolStripMenuItem4";
        toolStripMenuItem4.Size = new System.Drawing.Size(32, 19);
        // 
        // toolStripMenuItem5
        // 
        toolStripMenuItem5.Name = "toolStripMenuItem5";
        toolStripMenuItem5.Size = new System.Drawing.Size(32, 19);
        // 
        // DashboardForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(panel1);
        MainMenuStrip = menuStrip1;
        Text = "DashboardForm";
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        menuStrip1.ResumeLayout(false);
        menuStrip1.PerformLayout();
        ResumeLayout(false);
    }

    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;

    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;

    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;

    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;

    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;

    private System.Windows.Forms.ToolStripMenuItem Master;
    private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;

    private System.Windows.Forms.MenuStrip menuStrip1;

    private System.Windows.Forms.Label lwelcome;

    private System.Windows.Forms.Panel panel1;

    #endregion
}