using System;
using System.Windows.Forms;

namespace Admin_Tool
{
    partial class AdminTool
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.components = new System.ComponentModel.Container();
            this.remedyBtn = new System.Windows.Forms.Button();
            this.remedyTextBox = new System.Windows.Forms.TextBox();
            this.scRequestBtn = new System.Windows.Forms.Button();
            this.scTextBox = new System.Windows.Forms.TextBox();
            this.copyBtn = new System.Windows.Forms.Button();
            this.copyTextBox = new System.Windows.Forms.TextBox();
            this.raBox = new System.Windows.Forms.GroupBox();
            this.mobileBtn = new System.Windows.Forms.Button();
            this.hubBtn = new System.Windows.Forms.Button();
            this.adminBtn = new System.Windows.Forms.Button();
            this.zebulonBtn = new System.Windows.Forms.Button();
            this.warrenBtn = new System.Windows.Forms.Button();
            this.sandersBtn = new System.Windows.Forms.Button();
            this.rdBtn = new System.Windows.Forms.Button();
            this.rockVxBtn = new System.Windows.Forms.Button();
            this.rockGmsBtn = new System.Windows.Forms.Button();
            this.providenceBtn = new System.Windows.Forms.Button();
            this.merionWestBtn = new System.Windows.Forms.Button();
            this.merionEastBtn = new System.Windows.Forms.Button();
            this.navyYardBtn = new System.Windows.Forms.Button();
            this.missBtn = new System.Windows.Forms.Button();
            this.lincolnBtn = new System.Windows.Forms.Button();
            this.clipboardLabel = new System.Windows.Forms.Label();
            this.timerRefresh = new System.Windows.Forms.Timer(this.components);
            this.raBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // remedyBtn
            // 
            this.remedyBtn.Location = new System.Drawing.Point(12, 12);
            this.remedyBtn.Name = "remedyBtn";
            this.remedyBtn.Size = new System.Drawing.Size(179, 23);
            this.remedyBtn.TabIndex = 0;
            this.remedyBtn.Text = "Reopen Remedy Ticket";
            this.remedyBtn.UseVisualStyleBackColor = true;
            this.remedyBtn.Click += new System.EventHandler(this.remedyBtn_Click);
            // 
            // remedyTextBox
            // 
            this.remedyTextBox.Location = new System.Drawing.Point(197, 14);
            this.remedyTextBox.Name = "remedyTextBox";
            this.remedyTextBox.Size = new System.Drawing.Size(171, 20);
            this.remedyTextBox.TabIndex = 1;
            // 
            // scRequestBtn
            // 
            this.scRequestBtn.Location = new System.Drawing.Point(12, 41);
            this.scRequestBtn.Name = "scRequestBtn";
            this.scRequestBtn.Size = new System.Drawing.Size(179, 23);
            this.scRequestBtn.TabIndex = 2;
            this.scRequestBtn.Text = "Check Request ID";
            this.scRequestBtn.UseVisualStyleBackColor = true;
            this.scRequestBtn.Click += new System.EventHandler(this.scRequestBtn_Click);
            // 
            // scTextBox
            // 
            this.scTextBox.Location = new System.Drawing.Point(197, 43);
            this.scTextBox.Name = "scTextBox";
            this.scTextBox.Size = new System.Drawing.Size(171, 20);
            this.scTextBox.TabIndex = 3;
            // 
            // copyBtn
            // 
            this.copyBtn.Location = new System.Drawing.Point(15, 173);
            this.copyBtn.Name = "copyBtn";
            this.copyBtn.Size = new System.Drawing.Size(75, 23);
            this.copyBtn.TabIndex = 4;
            this.copyBtn.Text = "Copy";
            this.copyBtn.UseVisualStyleBackColor = true;
            this.copyBtn.Click += new System.EventHandler(this.copyBtn_Click);
            // 
            // copyTextBox
            // 
            this.copyTextBox.Location = new System.Drawing.Point(96, 175);
            this.copyTextBox.Multiline = true;
            this.copyTextBox.Name = "copyTextBox";
            this.copyTextBox.Size = new System.Drawing.Size(244, 20);
            this.copyTextBox.TabIndex = 5;
            // 
            // raBox
            // 
            this.raBox.Controls.Add(this.clipboardLabel);
            this.raBox.Controls.Add(this.mobileBtn);
            this.raBox.Controls.Add(this.copyTextBox);
            this.raBox.Controls.Add(this.hubBtn);
            this.raBox.Controls.Add(this.copyBtn);
            this.raBox.Controls.Add(this.adminBtn);
            this.raBox.Controls.Add(this.zebulonBtn);
            this.raBox.Controls.Add(this.warrenBtn);
            this.raBox.Controls.Add(this.sandersBtn);
            this.raBox.Controls.Add(this.rdBtn);
            this.raBox.Controls.Add(this.rockVxBtn);
            this.raBox.Controls.Add(this.rockGmsBtn);
            this.raBox.Controls.Add(this.providenceBtn);
            this.raBox.Controls.Add(this.merionWestBtn);
            this.raBox.Controls.Add(this.merionEastBtn);
            this.raBox.Controls.Add(this.navyYardBtn);
            this.raBox.Controls.Add(this.missBtn);
            this.raBox.Controls.Add(this.lincolnBtn);
            this.raBox.Location = new System.Drawing.Point(12, 70);
            this.raBox.Name = "raBox";
            this.raBox.Size = new System.Drawing.Size(355, 212);
            this.raBox.TabIndex = 6;
            this.raBox.TabStop = false;
            this.raBox.Text = "Common Resolving Agencies";
            // 
            // mobileBtn
            // 
            this.mobileBtn.Location = new System.Drawing.Point(235, 144);
            this.mobileBtn.Name = "mobileBtn";
            this.mobileBtn.Size = new System.Drawing.Size(105, 23);
            this.mobileBtn.TabIndex = 14;
            this.mobileBtn.Text = "MOBILE";
            this.mobileBtn.UseVisualStyleBackColor = true;
            this.mobileBtn.Click += new System.EventHandler(this.btn_Click);
            // 
            // hubBtn
            // 
            this.hubBtn.Location = new System.Drawing.Point(126, 144);
            this.hubBtn.Name = "hubBtn";
            this.hubBtn.Size = new System.Drawing.Size(103, 23);
            this.hubBtn.TabIndex = 13;
            this.hubBtn.Text = "RTP-HUB";
            this.hubBtn.UseVisualStyleBackColor = true;
            this.hubBtn.Click += new System.EventHandler(this.btn_Click);
            // 
            // adminBtn
            // 
            this.adminBtn.Location = new System.Drawing.Point(15, 144);
            this.adminBtn.Name = "adminBtn";
            this.adminBtn.Size = new System.Drawing.Size(105, 23);
            this.adminBtn.TabIndex = 12;
            this.adminBtn.Text = "ADMIN";
            this.adminBtn.UseVisualStyleBackColor = true;
            this.adminBtn.Click += new System.EventHandler(this.btn_Click);
            // 
            // zebulonBtn
            // 
            this.zebulonBtn.Location = new System.Drawing.Point(235, 115);
            this.zebulonBtn.Name = "zebulonBtn";
            this.zebulonBtn.Size = new System.Drawing.Size(105, 23);
            this.zebulonBtn.TabIndex = 11;
            this.zebulonBtn.Text = "ZEBULON";
            this.zebulonBtn.UseVisualStyleBackColor = true;
            this.zebulonBtn.Click += new System.EventHandler(this.btn_Click);
            // 
            // warrenBtn
            // 
            this.warrenBtn.Location = new System.Drawing.Point(235, 86);
            this.warrenBtn.Name = "warrenBtn";
            this.warrenBtn.Size = new System.Drawing.Size(105, 23);
            this.warrenBtn.TabIndex = 10;
            this.warrenBtn.Text = "WARREN";
            this.warrenBtn.UseVisualStyleBackColor = true;
            this.warrenBtn.Click += new System.EventHandler(this.btn_Click);
            // 
            // sandersBtn
            // 
            this.sandersBtn.Location = new System.Drawing.Point(235, 57);
            this.sandersBtn.Name = "sandersBtn";
            this.sandersBtn.Size = new System.Drawing.Size(105, 23);
            this.sandersBtn.TabIndex = 9;
            this.sandersBtn.Text = "SANDERS";
            this.sandersBtn.UseVisualStyleBackColor = true;
            this.sandersBtn.Click += new System.EventHandler(this.btn_Click);
            // 
            // rdBtn
            // 
            this.rdBtn.Location = new System.Drawing.Point(235, 28);
            this.rdBtn.Name = "rdBtn";
            this.rdBtn.Size = new System.Drawing.Size(105, 23);
            this.rdBtn.TabIndex = 8;
            this.rdBtn.Text = "RD-5";
            this.rdBtn.UseVisualStyleBackColor = true;
            this.rdBtn.Click += new System.EventHandler(this.btn_Click);
            // 
            // rockVxBtn
            // 
            this.rockVxBtn.Location = new System.Drawing.Point(126, 115);
            this.rockVxBtn.Name = "rockVxBtn";
            this.rockVxBtn.Size = new System.Drawing.Size(103, 23);
            this.rockVxBtn.TabIndex = 7;
            this.rockVxBtn.Text = "ROCK VX";
            this.rockVxBtn.UseVisualStyleBackColor = true;
            this.rockVxBtn.Click += new System.EventHandler(this.btn_Click);
            // 
            // rockGmsBtn
            // 
            this.rockGmsBtn.Location = new System.Drawing.Point(126, 86);
            this.rockGmsBtn.Name = "rockGmsBtn";
            this.rockGmsBtn.Size = new System.Drawing.Size(103, 23);
            this.rockGmsBtn.TabIndex = 6;
            this.rockGmsBtn.Text = "ROCK GMS";
            this.rockGmsBtn.UseVisualStyleBackColor = true;
            this.rockGmsBtn.Click += new System.EventHandler(this.btn_Click);
            // 
            // providenceBtn
            // 
            this.providenceBtn.Location = new System.Drawing.Point(126, 57);
            this.providenceBtn.Name = "providenceBtn";
            this.providenceBtn.Size = new System.Drawing.Size(103, 23);
            this.providenceBtn.TabIndex = 5;
            this.providenceBtn.Text = "U PROVIDENCE";
            this.providenceBtn.UseVisualStyleBackColor = true;
            this.providenceBtn.Click += new System.EventHandler(this.btn_Click);
            // 
            // merionWestBtn
            // 
            this.merionWestBtn.Location = new System.Drawing.Point(126, 28);
            this.merionWestBtn.Name = "merionWestBtn";
            this.merionWestBtn.Size = new System.Drawing.Size(103, 23);
            this.merionWestBtn.TabIndex = 4;
            this.merionWestBtn.Text = "UM WEST";
            this.merionWestBtn.UseVisualStyleBackColor = true;
            this.merionWestBtn.Click += new System.EventHandler(this.btn_Click);
            // 
            // merionEastBtn
            // 
            this.merionEastBtn.Location = new System.Drawing.Point(15, 115);
            this.merionEastBtn.Name = "merionEastBtn";
            this.merionEastBtn.Size = new System.Drawing.Size(105, 23);
            this.merionEastBtn.TabIndex = 3;
            this.merionEastBtn.Text = "UM EAST";
            this.merionEastBtn.UseVisualStyleBackColor = true;
            this.merionEastBtn.Click += new System.EventHandler(this.btn_Click);
            // 
            // navyYardBtn
            // 
            this.navyYardBtn.Location = new System.Drawing.Point(15, 86);
            this.navyYardBtn.Name = "navyYardBtn";
            this.navyYardBtn.Size = new System.Drawing.Size(105, 23);
            this.navyYardBtn.TabIndex = 2;
            this.navyYardBtn.Text = "NAVY YARD";
            this.navyYardBtn.UseVisualStyleBackColor = true;
            this.navyYardBtn.Click += new System.EventHandler(this.btn_Click);
            // 
            // missBtn
            // 
            this.missBtn.Location = new System.Drawing.Point(15, 57);
            this.missBtn.Name = "missBtn";
            this.missBtn.Size = new System.Drawing.Size(105, 23);
            this.missBtn.TabIndex = 1;
            this.missBtn.Text = "MISSISSAUGA";
            this.missBtn.UseVisualStyleBackColor = true;
            this.missBtn.Click += new System.EventHandler(this.btn_Click);
            // 
            // lincolnBtn
            // 
            this.lincolnBtn.Location = new System.Drawing.Point(15, 28);
            this.lincolnBtn.Name = "lincolnBtn";
            this.lincolnBtn.Size = new System.Drawing.Size(105, 23);
            this.lincolnBtn.TabIndex = 0;
            this.lincolnBtn.Text = "LINCOLN";
            this.lincolnBtn.UseVisualStyleBackColor = true;
            this.lincolnBtn.Click += new System.EventHandler(this.btn_Click);
            // 
            // clipboardLabel
            // 
            this.clipboardLabel.AutoSize = true;
            this.clipboardLabel.Location = new System.Drawing.Point(305, 12);
            this.clipboardLabel.Name = "clipboardLabel";
            this.clipboardLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.clipboardLabel.Size = new System.Drawing.Size(35, 13);
            this.clipboardLabel.TabIndex = 15;
            this.clipboardLabel.Text = "label1";
            this.clipboardLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timerRefresh
            // 
            this.timerRefresh.Tick += new System.EventHandler(this.btn_Click);
            // 
            // AdminTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 295);
            this.Controls.Add(this.raBox);
            this.Controls.Add(this.scTextBox);
            this.Controls.Add(this.scRequestBtn);
            this.Controls.Add(this.remedyTextBox);
            this.Controls.Add(this.remedyBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AdminTool";
            this.Text = "Form1";
            this.raBox.ResumeLayout(false);
            this.raBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnCopy(object sender, MouseEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button remedyBtn;
        private System.Windows.Forms.TextBox remedyTextBox;
        private System.Windows.Forms.Button scRequestBtn;
        private System.Windows.Forms.TextBox scTextBox;
        private System.Windows.Forms.Button copyBtn;
        private System.Windows.Forms.TextBox copyTextBox;
        private System.Windows.Forms.GroupBox raBox;
        private System.Windows.Forms.Button hubBtn;
        private System.Windows.Forms.Button adminBtn;
        private System.Windows.Forms.Button zebulonBtn;
        private System.Windows.Forms.Button warrenBtn;
        private System.Windows.Forms.Button sandersBtn;
        private System.Windows.Forms.Button rdBtn;
        private System.Windows.Forms.Button rockVxBtn;
        private System.Windows.Forms.Button rockGmsBtn;
        private System.Windows.Forms.Button providenceBtn;
        private System.Windows.Forms.Button merionWestBtn;
        private System.Windows.Forms.Button merionEastBtn;
        private System.Windows.Forms.Button navyYardBtn;
        private System.Windows.Forms.Button missBtn;
        private System.Windows.Forms.Button lincolnBtn;
        private System.Windows.Forms.Button mobileBtn;
        private Label clipboardLabel;
        private Timer timerRefresh;
    }
}

