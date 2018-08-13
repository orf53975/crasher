namespace crasher
{
    partial class GUI
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelStatus = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelMREConnection = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.labelMachineName = new System.Windows.Forms.Label();
            this.labelMacAdress = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            this.panelStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(80)))));
            this.panelHeader.Controls.Add(this.label2);
            this.panelHeader.Controls.Add(this.label1);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelHeader.Location = new System.Drawing.Point(0, 423);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1087, 70);
            this.panelHeader.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Copperplate Gothic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Super Orbit Ion Cannon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(918, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Developed by Luca Di Bello";
            // 
            // panelStatus
            // 
            this.panelStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(100)))));
            this.panelStatus.Controls.Add(this.labelMacAdress);
            this.panelStatus.Controls.Add(this.label11);
            this.panelStatus.Controls.Add(this.labelMachineName);
            this.panelStatus.Controls.Add(this.label8);
            this.panelStatus.Controls.Add(this.label7);
            this.panelStatus.Controls.Add(this.label6);
            this.panelStatus.Controls.Add(this.labelMREConnection);
            this.panelStatus.Controls.Add(this.label5);
            this.panelStatus.Controls.Add(this.label4);
            this.panelStatus.Controls.Add(this.label3);
            this.panelStatus.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelStatus.Font = new System.Drawing.Font("Roboto Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelStatus.Location = new System.Drawing.Point(0, 0);
            this.panelStatus.Margin = new System.Windows.Forms.Padding(10);
            this.panelStatus.Name = "panelStatus";
            this.panelStatus.Size = new System.Drawing.Size(356, 423);
            this.panelStatus.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 30);
            this.label3.TabIndex = 0;
            this.label3.Text = "Connection status to \r\nMaster-Cannon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Total cannons";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Cannon status";
            // 
            // labelMREConnection
            // 
            this.labelMREConnection.AutoSize = true;
            this.labelMREConnection.Font = new System.Drawing.Font("Roboto Mono", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMREConnection.ForeColor = System.Drawing.Color.Red;
            this.labelMREConnection.Location = new System.Drawing.Point(256, 50);
            this.labelMREConnection.Name = "labelMREConnection";
            this.labelMREConnection.Size = new System.Drawing.Size(49, 15);
            this.labelMREConnection.TabIndex = 3;
            this.labelMREConnection.Text = "Failed";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto Mono", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(256, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "Failed";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto Mono", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(256, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 15);
            this.label7.TabIndex = 5;
            this.label7.Text = "Failed";
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(150)))));
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(356, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(731, 423);
            this.panelMain.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 358);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 15);
            this.label8.TabIndex = 6;
            this.label8.Text = "Cannon name";
            // 
            // labelMachineName
            // 
            this.labelMachineName.AutoSize = true;
            this.labelMachineName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelMachineName.Font = new System.Drawing.Font("Roboto Mono", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMachineName.ForeColor = System.Drawing.Color.Red;
            this.labelMachineName.Location = new System.Drawing.Point(132, 358);
            this.labelMachineName.Name = "labelMachineName";
            this.labelMachineName.Size = new System.Drawing.Size(35, 15);
            this.labelMachineName.TabIndex = 7;
            this.labelMachineName.Text = "None";
            this.labelMachineName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMacAdress
            // 
            this.labelMacAdress.AutoSize = true;
            this.labelMacAdress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelMacAdress.Font = new System.Drawing.Font("Roboto Mono", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMacAdress.ForeColor = System.Drawing.Color.Red;
            this.labelMacAdress.Location = new System.Drawing.Point(132, 392);
            this.labelMacAdress.Name = "labelMacAdress";
            this.labelMacAdress.Size = new System.Drawing.Size(35, 15);
            this.labelMacAdress.TabIndex = 9;
            this.labelMacAdress.Text = "None";
            this.labelMacAdress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 392);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 15);
            this.label11.TabIndex = 8;
            this.label11.Text = "Cannon address";
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1087, 493);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelStatus);
            this.Controls.Add(this.panelHeader);
            this.Name = "GUI";
            this.Text = "S.O.I.C | b0.0.1 | When you are aspiring to the highest place";
            this.Load += new System.EventHandler(this.GUI_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelStatus.ResumeLayout(false);
            this.panelStatus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelStatus;
        private System.Windows.Forms.Label labelMacAdress;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelMachineName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelMREConnection;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelMain;
    }
}