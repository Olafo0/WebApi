namespace WindowsApp
{
    partial class Form4
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
            AddBtn = new Button();
            textBoxMD = new TextBox();
            textBoxLN = new TextBox();
            textBoxFN = new TextBox();
            textBoxJobID = new TextBox();
            textBoxBD = new TextBox();
            textBoxSala = new TextBox();
            textBoxPhone = new TextBox();
            textBoxC = new TextBox();
            textBoxSA = new TextBox();
            textBoxHD = new TextBox();
            textBoxManID = new TextBox();
            textBoxDepID = new TextBox();
            textBoxSP = new TextBox();
            textBoxCountryID = new TextBox();
            textBoxPC = new TextBox();
            ClearBtn = new Button();
            label2 = new Label();
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
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(50, 22);
            label1.Name = "label1";
            label1.Size = new Size(414, 36);
            label1.TabIndex = 3;
            label1.Text = "Employee Registration";
            // 
            // AddBtn
            // 
            AddBtn.BackColor = Color.FromArgb(128, 255, 128);
            AddBtn.Cursor = Cursors.Hand;
            AddBtn.Location = new Point(951, 481);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(196, 89);
            AddBtn.TabIndex = 4;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += AddBtn_Click;
            // 
            // textBoxMD
            // 
            textBoxMD.Location = new Point(200, 135);
            textBoxMD.Name = "textBoxMD";
            textBoxMD.Size = new Size(174, 31);
            textBoxMD.TabIndex = 5;
            // 
            // textBoxLN
            // 
            textBoxLN.Location = new Point(200, 198);
            textBoxLN.Name = "textBoxLN";
            textBoxLN.Size = new Size(174, 31);
            textBoxLN.TabIndex = 6;
            // 
            // textBoxFN
            // 
            textBoxFN.Location = new Point(200, 82);
            textBoxFN.Name = "textBoxFN";
            textBoxFN.Size = new Size(174, 31);
            textBoxFN.TabIndex = 7;
            // 
            // textBoxJobID
            // 
            textBoxJobID.Location = new Point(200, 251);
            textBoxJobID.Name = "textBoxJobID";
            textBoxJobID.Size = new Size(174, 31);
            textBoxJobID.TabIndex = 10;
            // 
            // textBoxBD
            // 
            textBoxBD.Location = new Point(200, 367);
            textBoxBD.Name = "textBoxBD";
            textBoxBD.Size = new Size(174, 31);
            textBoxBD.TabIndex = 9;
            // 
            // textBoxSala
            // 
            textBoxSala.Location = new Point(200, 304);
            textBoxSala.Name = "textBoxSala";
            textBoxSala.Size = new Size(174, 31);
            textBoxSala.TabIndex = 8;
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(591, 251);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(174, 31);
            textBoxPhone.TabIndex = 16;
            // 
            // textBoxC
            // 
            textBoxC.Location = new Point(591, 367);
            textBoxC.Name = "textBoxC";
            textBoxC.Size = new Size(174, 31);
            textBoxC.TabIndex = 15;
            // 
            // textBoxSA
            // 
            textBoxSA.Location = new Point(591, 304);
            textBoxSA.Name = "textBoxSA";
            textBoxSA.Size = new Size(174, 31);
            textBoxSA.TabIndex = 14;
            // 
            // textBoxHD
            // 
            textBoxHD.Location = new Point(591, 82);
            textBoxHD.Name = "textBoxHD";
            textBoxHD.Size = new Size(174, 31);
            textBoxHD.TabIndex = 13;
            // 
            // textBoxManID
            // 
            textBoxManID.Location = new Point(591, 198);
            textBoxManID.Name = "textBoxManID";
            textBoxManID.Size = new Size(174, 31);
            textBoxManID.TabIndex = 12;
            // 
            // textBoxDepID
            // 
            textBoxDepID.Location = new Point(591, 135);
            textBoxDepID.Name = "textBoxDepID";
            textBoxDepID.Size = new Size(174, 31);
            textBoxDepID.TabIndex = 11;
            // 
            // textBoxSP
            // 
            textBoxSP.Location = new Point(973, 82);
            textBoxSP.Name = "textBoxSP";
            textBoxSP.Size = new Size(174, 31);
            textBoxSP.TabIndex = 19;
            // 
            // textBoxCountryID
            // 
            textBoxCountryID.Location = new Point(973, 198);
            textBoxCountryID.Name = "textBoxCountryID";
            textBoxCountryID.Size = new Size(174, 31);
            textBoxCountryID.TabIndex = 18;
            // 
            // textBoxPC
            // 
            textBoxPC.Location = new Point(973, 135);
            textBoxPC.Name = "textBoxPC";
            textBoxPC.Size = new Size(174, 31);
            textBoxPC.TabIndex = 17;
            // 
            // ClearBtn
            // 
            ClearBtn.BackColor = Color.IndianRed;
            ClearBtn.Cursor = Cursors.Hand;
            ClearBtn.Location = new Point(951, 614);
            ClearBtn.Name = "ClearBtn";
            ClearBtn.Size = new Size(196, 89);
            ClearBtn.TabIndex = 21;
            ClearBtn.Text = "Clear";
            ClearBtn.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 82);
            label2.Name = "label2";
            label2.Size = new Size(106, 25);
            label2.TabIndex = 22;
            label2.Text = "First Name :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 138);
            label3.Name = "label3";
            label3.Size = new Size(123, 25);
            label3.TabIndex = 23;
            label3.Text = "Middle Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(81, 257);
            label4.Name = "label4";
            label4.Size = new Size(70, 25);
            label4.TabIndex = 25;
            label4.Text = "Job Id :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(47, 198);
            label5.Name = "label5";
            label5.Size = new Size(104, 25);
            label5.TabIndex = 24;
            label5.Text = "Last Name :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(57, 367);
            label6.Name = "label6";
            label6.Size = new Size(99, 25);
            label6.TabIndex = 27;
            label6.Text = "Birth Data :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(83, 304);
            label7.Name = "label7";
            label7.Size = new Size(68, 25);
            label7.TabIndex = 26;
            label7.Text = "Salary :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(511, 367);
            label8.Name = "label8";
            label8.Size = new Size(51, 25);
            label8.TabIndex = 33;
            label8.Text = "City :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(426, 304);
            label9.Name = "label9";
            label9.Size = new Size(136, 25);
            label9.TabIndex = 32;
            label9.Text = "Street Address :";
            label9.Click += label9_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(491, 254);
            label10.Name = "label10";
            label10.Size = new Size(71, 25);
            label10.TabIndex = 31;
            label10.Text = "Phone :";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(450, 201);
            label11.Name = "label11";
            label11.Size = new Size(112, 25);
            label11.TabIndex = 30;
            label11.Text = "Manager Id :";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(425, 141);
            label12.Name = "label12";
            label12.Size = new Size(137, 25);
            label12.TabIndex = 29;
            label12.Text = "Department Id :";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(467, 82);
            label13.Name = "label13";
            label13.Size = new Size(95, 25);
            label13.TabIndex = 28;
            label13.Text = "Hire Data :";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(845, 198);
            label17.Name = "label17";
            label17.Size = new Size(105, 25);
            label17.TabIndex = 36;
            label17.Text = "Country Id :";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(835, 138);
            label18.Name = "label18";
            label18.Size = new Size(115, 25);
            label18.TabIndex = 35;
            label18.Text = "Postal Code :";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(818, 88);
            label19.Name = "label19";
            label19.Size = new Size(132, 25);
            label19.TabIndex = 34;
            label19.Text = "State Province :";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1257, 764);
            Controls.Add(label17);
            Controls.Add(label18);
            Controls.Add(label19);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(label13);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(ClearBtn);
            Controls.Add(textBoxSP);
            Controls.Add(textBoxCountryID);
            Controls.Add(textBoxPC);
            Controls.Add(textBoxPhone);
            Controls.Add(textBoxC);
            Controls.Add(textBoxSA);
            Controls.Add(textBoxHD);
            Controls.Add(textBoxManID);
            Controls.Add(textBoxDepID);
            Controls.Add(textBoxJobID);
            Controls.Add(textBoxBD);
            Controls.Add(textBoxSala);
            Controls.Add(textBoxFN);
            Controls.Add(textBoxLN);
            Controls.Add(textBoxMD);
            Controls.Add(AddBtn);
            Controls.Add(label1);
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button AddBtn;
        private TextBox textBoxMD;
        private TextBox textBoxLN;
        private TextBox textBoxFN;
        private TextBox textBoxJobID;
        private TextBox textBoxBD;
        private TextBox textBoxSala;
        private TextBox textBoxPhone;
        private TextBox textBoxC;
        private TextBox textBoxSA;
        private TextBox textBoxHD;
        private TextBox textBoxManID;
        private TextBox textBoxDepID;
        private TextBox textBoxSP;
        private TextBox textBoxCountryID;
        private TextBox textBoxPC;
        private Button ClearBtn;
        private Label label2;
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
        private Label label17;
        private Label label18;
        private Label label19;
    }
}