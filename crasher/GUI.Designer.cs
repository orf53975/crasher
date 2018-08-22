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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelStatus = new System.Windows.Forms.Panel();
            this.labelTotalCannons = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelMacAdress = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.labelMachineName = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelMREConnection = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.checkBoxThreads = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.buttonStartAttack = new System.Windows.Forms.Button();
            this.listViewAttack = new System.Windows.Forms.ListView();
            this.columnHeaderId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderUrl = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAttackType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panelHeader.SuspendLayout();
            this.panelStatus.SuspendLayout();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(80)))));
            this.panelHeader.Controls.Add(this.label2);
            this.panelHeader.Controls.Add(this.label1);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelHeader.Location = new System.Drawing.Point(0, 473);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1087, 70);
            this.panelHeader.TabIndex = 0;
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
            // panelStatus
            // 
            this.panelStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(100)))));
            this.panelStatus.Controls.Add(this.labelTotalCannons);
            this.panelStatus.Controls.Add(this.label9);
            this.panelStatus.Controls.Add(this.labelMacAdress);
            this.panelStatus.Controls.Add(this.label11);
            this.panelStatus.Controls.Add(this.labelMachineName);
            this.panelStatus.Controls.Add(this.label8);
            this.panelStatus.Controls.Add(this.label7);
            this.panelStatus.Controls.Add(this.labelMREConnection);
            this.panelStatus.Controls.Add(this.label5);
            this.panelStatus.Controls.Add(this.label3);
            this.panelStatus.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelStatus.Font = new System.Drawing.Font("Roboto Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelStatus.Location = new System.Drawing.Point(0, 0);
            this.panelStatus.Margin = new System.Windows.Forms.Padding(10);
            this.panelStatus.Name = "panelStatus";
            this.panelStatus.Size = new System.Drawing.Size(356, 473);
            this.panelStatus.TabIndex = 1;
            // 
            // labelTotalCannons
            // 
            this.labelTotalCannons.AutoSize = true;
            this.labelTotalCannons.Font = new System.Drawing.Font("Roboto Mono", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalCannons.ForeColor = System.Drawing.Color.Red;
            this.labelTotalCannons.Location = new System.Drawing.Point(256, 90);
            this.labelTotalCannons.Name = "labelTotalCannons";
            this.labelTotalCannons.Size = new System.Drawing.Size(49, 15);
            this.labelTotalCannons.TabIndex = 11;
            this.labelTotalCannons.Text = "Failed";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 15);
            this.label9.TabIndex = 10;
            this.label9.Text = "Total cannons";
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 358);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 15);
            this.label8.TabIndex = 6;
            this.label8.Text = "Cannon name";
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Cannon status";
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
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(150)))));
            this.panelMain.Controls.Add(this.checkBoxThreads);
            this.panelMain.Controls.Add(this.label4);
            this.panelMain.Controls.Add(this.trackBar1);
            this.panelMain.Controls.Add(this.buttonStartAttack);
            this.panelMain.Controls.Add(this.listViewAttack);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(356, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(731, 473);
            this.panelMain.TabIndex = 2;
            // 
            // checkBoxThreads
            // 
            this.checkBoxThreads.AutoSize = true;
            this.checkBoxThreads.Checked = true;
            this.checkBoxThreads.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxThreads.Font = new System.Drawing.Font("Roboto Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxThreads.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.checkBoxThreads.Location = new System.Drawing.Point(37, 330);
            this.checkBoxThreads.Name = "checkBoxThreads";
            this.checkBoxThreads.Size = new System.Drawing.Size(103, 19);
            this.checkBoxThreads.TabIndex = 10;
            this.checkBoxThreads.Text = "Use threads";
            this.checkBoxThreads.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(34, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Attack force";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(196, 278);
            this.trackBar1.Minimum = 5;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(416, 45);
            this.trackBar1.TabIndex = 2;
            this.trackBar1.Value = 5;
            // 
            // buttonStartAttack
            // 
            this.buttonStartAttack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonStartAttack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonStartAttack.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonStartAttack.Location = new System.Drawing.Point(248, 338);
            this.buttonStartAttack.Name = "buttonStartAttack";
            this.buttonStartAttack.Size = new System.Drawing.Size(167, 54);
            this.buttonStartAttack.TabIndex = 1;
            this.buttonStartAttack.Text = "Start Attack";
            this.buttonStartAttack.UseVisualStyleBackColor = false;
            this.buttonStartAttack.Click += new System.EventHandler(this.buttonStartAttack_Click);
            // 
            // listViewAttack
            // 
            this.listViewAttack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(24)))), ((int)(((byte)(160)))));
            this.listViewAttack.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderId,
            this.columnHeaderUrl,
            this.columnHeaderAttackType,
            this.columnHeaderTime});
            this.listViewAttack.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewAttack.ForeColor = System.Drawing.Color.Silver;
            this.listViewAttack.FullRowSelect = true;
            this.listViewAttack.Location = new System.Drawing.Point(13, 12);
            this.listViewAttack.MultiSelect = false;
            this.listViewAttack.Name = "listViewAttack";
            this.listViewAttack.Size = new System.Drawing.Size(706, 251);
            this.listViewAttack.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listViewAttack.TabIndex = 0;
            this.listViewAttack.UseCompatibleStateImageBehavior = false;
            this.listViewAttack.View = System.Windows.Forms.View.Details;
            this.listViewAttack.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.listViewAttack_ColumnWidthChanging);
            this.listViewAttack.Resize += new System.EventHandler(this.listViewAttack_Resize);
            // 
            // columnHeaderId
            // 
            this.columnHeaderId.Text = "Id";
            this.columnHeaderId.Width = 114;
            // 
            // columnHeaderUrl
            // 
            this.columnHeaderUrl.Text = "Url";
            this.columnHeaderUrl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderUrl.Width = 216;
            // 
            // columnHeaderAttackType
            // 
            this.columnHeaderAttackType.Text = "Attack Type";
            this.columnHeaderAttackType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderAttackType.Width = 204;
            // 
            // columnHeaderTime
            // 
            this.columnHeaderTime.Text = "Time (s)";
            this.columnHeaderTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderTime.Width = 165;
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1087, 543);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelStatus);
            this.Controls.Add(this.panelHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GUI";
            this.Text = "S.O.I.C | b0.0.1 | When you are aspiring to the highest place";
            this.Load += new System.EventHandler(this.GUI_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelStatus.ResumeLayout(false);
            this.panelStatus.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
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
        private System.Windows.Forms.Label labelMREConnection;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.ColumnHeader columnHeaderId;
        private System.Windows.Forms.ColumnHeader columnHeaderUrl;
        private System.Windows.Forms.ColumnHeader columnHeaderAttackType;
        private System.Windows.Forms.ColumnHeader columnHeaderTime;
        private System.Windows.Forms.Label labelTotalCannons;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.ListView listViewAttack;
        private System.Windows.Forms.Button buttonStartAttack;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.CheckBox checkBoxThreads;
    }
}