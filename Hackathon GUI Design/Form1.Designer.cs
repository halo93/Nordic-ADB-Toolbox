namespace Hackathon_GUI_Design
{
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnDI = new System.Windows.Forms.Button();
            this.btnDS = new System.Windows.Forms.Button();
            this.btnTM = new System.Windows.Forms.Button();
            this.mainpanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.mainpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.btnReport);
            this.panel1.Controls.Add(this.btnDI);
            this.panel1.Controls.Add(this.btnDS);
            this.panel1.Controls.Add(this.btnTM);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(229, 600);
            this.panel1.TabIndex = 0;
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.Gray;
            this.btnReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnReport.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReport.ForeColor = System.Drawing.Color.White;
            this.btnReport.Location = new System.Drawing.Point(0, 148);
            this.btnReport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(229, 40);
            this.btnReport.TabIndex = 5;
            this.btnReport.Text = "Report (Premium Feature)";
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnDI
            // 
            this.btnDI.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnDI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDI.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDI.ForeColor = System.Drawing.Color.White;
            this.btnDI.Location = new System.Drawing.Point(0, 100);
            this.btnDI.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDI.Name = "btnDI";
            this.btnDI.Size = new System.Drawing.Size(229, 40);
            this.btnDI.TabIndex = 4;
            this.btnDI.Text = "Device Info";
            this.btnDI.UseVisualStyleBackColor = false;
            this.btnDI.Click += new System.EventHandler(this.btnDI_Click);
            // 
            // btnDS
            // 
            this.btnDS.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnDS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDS.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDS.ForeColor = System.Drawing.Color.White;
            this.btnDS.Location = new System.Drawing.Point(0, 52);
            this.btnDS.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDS.Name = "btnDS";
            this.btnDS.Size = new System.Drawing.Size(229, 40);
            this.btnDS.TabIndex = 2;
            this.btnDS.Text = "Device Status";
            this.btnDS.UseVisualStyleBackColor = false;
            this.btnDS.Click += new System.EventHandler(this.btnDS_Click);
            // 
            // btnTM
            // 
            this.btnTM.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnTM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTM.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTM.ForeColor = System.Drawing.Color.White;
            this.btnTM.Location = new System.Drawing.Point(0, 4);
            this.btnTM.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTM.Name = "btnTM";
            this.btnTM.Size = new System.Drawing.Size(229, 40);
            this.btnTM.TabIndex = 3;
            this.btnTM.Text = "Launch App";
            this.btnTM.UseVisualStyleBackColor = false;
            this.btnTM.Click += new System.EventHandler(this.btnTM_Click);
            // 
            // mainpanel
            // 
            this.mainpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.mainpanel.Controls.Add(this.richTextBox1);
            this.mainpanel.Controls.Add(this.label1);
            this.mainpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainpanel.Location = new System.Drawing.Point(229, 0);
            this.mainpanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(707, 600);
            this.mainpanel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(35, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(631, 43);
            this.label1.TabIndex = 3;
            this.label1.Text = "Welcome to Nordic ADB Toolkit";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(115, 155);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(489, 120);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 600);
            this.Controls.Add(this.mainpanel);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Nordic ADB Tool Kit for Oculus Quest";
            this.panel1.ResumeLayout(false);
            this.mainpanel.ResumeLayout(false);
            this.mainpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button btnReport;
        private Button btnDI;
        private Button btnDS;
        private Button btnTM;
        private Panel mainpanel;
        private Label label1;
        private RichTextBox richTextBox1;
    }
}