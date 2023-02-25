namespace HotelManageSystem
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.guyuanButton = new System.Windows.Forms.Button();
            this.roomButton = new System.Windows.Forms.Button();
            this.gukeButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.guyuanButton);
            this.panel1.Controls.Add(this.roomButton);
            this.panel1.Controls.Add(this.gukeButton);
            this.panel1.Location = new System.Drawing.Point(22, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(132, 667);
            this.panel1.TabIndex = 0;
            // 
            // guyuanButton
            // 
            this.guyuanButton.BackColor = System.Drawing.SystemColors.Control;
            this.guyuanButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.guyuanButton.Location = new System.Drawing.Point(8, 218);
            this.guyuanButton.Name = "guyuanButton";
            this.guyuanButton.Size = new System.Drawing.Size(115, 44);
            this.guyuanButton.TabIndex = 2;
            this.guyuanButton.Text = "雇员管理";
            this.guyuanButton.UseVisualStyleBackColor = false;
            this.guyuanButton.Click += new System.EventHandler(this.guyuanButton_Click);
            // 
            // roomButton
            // 
            this.roomButton.BackColor = System.Drawing.SystemColors.Control;
            this.roomButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.roomButton.Location = new System.Drawing.Point(8, 127);
            this.roomButton.Name = "roomButton";
            this.roomButton.Size = new System.Drawing.Size(115, 44);
            this.roomButton.TabIndex = 1;
            this.roomButton.Text = "客房管理";
            this.roomButton.UseVisualStyleBackColor = false;
            this.roomButton.Click += new System.EventHandler(this.roomButton_Click);
            // 
            // gukeButton
            // 
            this.gukeButton.BackColor = System.Drawing.SystemColors.Control;
            this.gukeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gukeButton.Location = new System.Drawing.Point(8, 33);
            this.gukeButton.Name = "gukeButton";
            this.gukeButton.Size = new System.Drawing.Size(115, 44);
            this.gukeButton.TabIndex = 0;
            this.gukeButton.Text = "顾客管理";
            this.gukeButton.UseVisualStyleBackColor = false;
            this.gukeButton.Click += new System.EventHandler(this.gukeButton_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(177, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(902, 667);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 712);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "宾馆管理系统";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button gukeButton;
        private Panel panel2;
        private Button roomButton;
        private Button guyuanButton;
    }
}