namespace WindowsApp
{
    partial class Form3
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
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            textBoxFN = new TextBox();
            textBoxMN = new TextBox();
            textBoxLN = new TextBox();
            textBoxJobID = new TextBox();
            textBoxDepId = new TextBox();
            textBoxHD = new TextBox();
            textBoxBD = new TextBox();
            textBoxS = new TextBox();
            textBoxCity = new TextBox();
            textBoxAdd = new TextBox();
            textBoxPhone = new TextBox();
            textBoxManID = new TextBox();
            textBoxCountryId = new TextBox();
            textBoxPC = new TextBox();
            textBoxSP = new TextBox();
            idCB = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(50, 28);
            label1.Name = "label1";
            label1.Size = new Size(509, 36);
            label1.TabIndex = 3;
            label1.Text = "View specifc Employee (ID)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 99);
            label2.Name = "label2";
            label2.Size = new Size(90, 25);
            label2.TabIndex = 5;
            label2.Text = "Select ID :";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 255, 192);
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(322, 93);
            button1.Name = "button1";
            button1.Size = new Size(163, 36);
            button1.TabIndex = 6;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(66, 215);
            label3.Name = "label3";
            label3.Size = new Size(106, 25);
            label3.TabIndex = 7;
            label3.Text = "First Name :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(66, 270);
            label4.Name = "label4";
            label4.Size = new Size(123, 25);
            label4.TabIndex = 8;
            label4.Text = "Middle Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(66, 329);
            label5.Name = "label5";
            label5.Size = new Size(104, 25);
            label5.TabIndex = 9;
            label5.Text = "Last Name :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(66, 390);
            label6.Name = "label6";
            label6.Size = new Size(70, 25);
            label6.TabIndex = 10;
            label6.Text = "Job Id :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(353, 390);
            label7.Name = "label7";
            label7.Size = new Size(137, 25);
            label7.TabIndex = 14;
            label7.Text = "Department Id :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(353, 329);
            label8.Name = "label8";
            label8.Size = new Size(93, 25);
            label8.TabIndex = 13;
            label8.Text = "Hire date :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(353, 270);
            label9.Name = "label9";
            label9.Size = new Size(97, 25);
            label9.TabIndex = 12;
            label9.Text = "Birth date :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(353, 215);
            label10.Name = "label10";
            label10.Size = new Size(68, 25);
            label10.TabIndex = 11;
            label10.Text = "Salary :";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(712, 391);
            label11.Name = "label11";
            label11.Size = new Size(47, 25);
            label11.TabIndex = 18;
            label11.Text = "City ";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(712, 330);
            label12.Name = "label12";
            label12.Size = new Size(86, 25);
            label12.TabIndex = 17;
            label12.Text = "Address :";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(712, 271);
            label13.Name = "label13";
            label13.Size = new Size(71, 25);
            label13.TabIndex = 16;
            label13.Text = "Phone :";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(712, 216);
            label14.Name = "label14";
            label14.Size = new Size(117, 25);
            label14.TabIndex = 15;
            label14.Text = "Manager Id : ";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(1024, 330);
            label16.Name = "label16";
            label16.Size = new Size(105, 25);
            label16.TabIndex = 21;
            label16.Text = "Country Id :";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(1024, 271);
            label17.Name = "label17";
            label17.Size = new Size(120, 25);
            label17.TabIndex = 20;
            label17.Text = "Postal Code : ";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(1024, 216);
            label18.Name = "label18";
            label18.Size = new Size(132, 25);
            label18.TabIndex = 19;
            label18.Text = "State Province :";
            // 
            // textBoxFN
            // 
            textBoxFN.Location = new Point(202, 212);
            textBoxFN.Name = "textBoxFN";
            textBoxFN.Size = new Size(145, 31);
            textBoxFN.TabIndex = 22;
            // 
            // textBoxMN
            // 
            textBoxMN.Location = new Point(202, 264);
            textBoxMN.Name = "textBoxMN";
            textBoxMN.Size = new Size(145, 31);
            textBoxMN.TabIndex = 23;
            // 
            // textBoxLN
            // 
            textBoxLN.Location = new Point(202, 323);
            textBoxLN.Name = "textBoxLN";
            textBoxLN.Size = new Size(145, 31);
            textBoxLN.TabIndex = 24;
            // 
            // textBoxJobID
            // 
            textBoxJobID.Location = new Point(202, 384);
            textBoxJobID.Name = "textBoxJobID";
            textBoxJobID.Size = new Size(145, 31);
            textBoxJobID.TabIndex = 25;
            // 
            // textBoxDepId
            // 
            textBoxDepId.Location = new Point(497, 385);
            textBoxDepId.Name = "textBoxDepId";
            textBoxDepId.Size = new Size(145, 31);
            textBoxDepId.TabIndex = 29;
            // 
            // textBoxHD
            // 
            textBoxHD.Location = new Point(497, 324);
            textBoxHD.Name = "textBoxHD";
            textBoxHD.Size = new Size(145, 31);
            textBoxHD.TabIndex = 28;
            // 
            // textBoxBD
            // 
            textBoxBD.Location = new Point(497, 265);
            textBoxBD.Name = "textBoxBD";
            textBoxBD.Size = new Size(145, 31);
            textBoxBD.TabIndex = 27;
            // 
            // textBoxS
            // 
            textBoxS.Location = new Point(497, 213);
            textBoxS.Name = "textBoxS";
            textBoxS.Size = new Size(145, 31);
            textBoxS.TabIndex = 26;
            // 
            // textBoxCity
            // 
            textBoxCity.Location = new Point(835, 388);
            textBoxCity.Name = "textBoxCity";
            textBoxCity.Size = new Size(145, 31);
            textBoxCity.TabIndex = 33;
            // 
            // textBoxAdd
            // 
            textBoxAdd.Location = new Point(835, 327);
            textBoxAdd.Name = "textBoxAdd";
            textBoxAdd.Size = new Size(145, 31);
            textBoxAdd.TabIndex = 32;
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(835, 268);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(145, 31);
            textBoxPhone.TabIndex = 31;
            // 
            // textBoxManID
            // 
            textBoxManID.Location = new Point(835, 216);
            textBoxManID.Name = "textBoxManID";
            textBoxManID.Size = new Size(145, 31);
            textBoxManID.TabIndex = 30;
            // 
            // textBoxCountryId
            // 
            textBoxCountryId.Location = new Point(1171, 327);
            textBoxCountryId.Name = "textBoxCountryId";
            textBoxCountryId.Size = new Size(145, 31);
            textBoxCountryId.TabIndex = 36;
            // 
            // textBoxPC
            // 
            textBoxPC.Location = new Point(1171, 268);
            textBoxPC.Name = "textBoxPC";
            textBoxPC.Size = new Size(145, 31);
            textBoxPC.TabIndex = 35;
            // 
            // textBoxSP
            // 
            textBoxSP.Location = new Point(1171, 216);
            textBoxSP.Name = "textBoxSP";
            textBoxSP.Size = new Size(145, 31);
            textBoxSP.TabIndex = 34;
            // 
            // idCB
            // 
            idCB.DropDownStyle = ComboBoxStyle.DropDownList;
            idCB.FormattingEnabled = true;
            idCB.Location = new Point(150, 96);
            idCB.Name = "idCB";
            idCB.Size = new Size(155, 33);
            idCB.TabIndex = 37;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1372, 590);
            Controls.Add(idCB);
            Controls.Add(textBoxCountryId);
            Controls.Add(textBoxPC);
            Controls.Add(textBoxSP);
            Controls.Add(textBoxCity);
            Controls.Add(textBoxAdd);
            Controls.Add(textBoxPhone);
            Controls.Add(textBoxManID);
            Controls.Add(textBoxDepId);
            Controls.Add(textBoxHD);
            Controls.Add(textBoxBD);
            Controls.Add(textBoxS);
            Controls.Add(textBoxJobID);
            Controls.Add(textBoxLN);
            Controls.Add(textBoxMN);
            Controls.Add(textBoxFN);
            Controls.Add(label16);
            Controls.Add(label17);
            Controls.Add(label18);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(label13);
            Controls.Add(label14);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label16;
        private Label label17;
        private Label label18;
        private TextBox textBoxFN;
        private TextBox textBoxMN;
        private TextBox textBoxLN;
        private TextBox textBoxJobID;
        private TextBox textBoxDepId;
        private TextBox textBoxHD;
        private TextBox textBoxBD;
        private TextBox textBoxS;
        private TextBox textBoxCity;
        private TextBox textBoxAdd;
        private TextBox textBoxPhone;
        private TextBox textBoxManID;
        private TextBox textBoxCountryId;
        private TextBox textBoxPC;
        private TextBox textBoxSP;
        private ComboBox idCB;
    }
}