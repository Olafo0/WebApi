namespace WindowsApp
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
            AllEmployee = new Button();
            SpecificEmployee = new Button();
            AddEmployee = new Button();
            RemoveEmployee = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // AllEmployee
            // 
            AllEmployee.BackColor = Color.Thistle;
            AllEmployee.Font = new Font("SimSun", 9F, FontStyle.Bold, GraphicsUnit.Point);
            AllEmployee.Location = new Point(355, 93);
            AllEmployee.Margin = new Padding(3, 2, 3, 2);
            AllEmployee.Name = "AllEmployee";
            AllEmployee.Size = new Size(234, 53);
            AllEmployee.TabIndex = 0;
            AllEmployee.Text = "View all employees";
            AllEmployee.UseVisualStyleBackColor = false;
            AllEmployee.Click += button1_Click;
            // 
            // SpecificEmployee
            // 
            SpecificEmployee.BackColor = Color.Thistle;
            SpecificEmployee.Font = new Font("SimSun", 9F, FontStyle.Bold, GraphicsUnit.Point);
            SpecificEmployee.Location = new Point(355, 176);
            SpecificEmployee.Margin = new Padding(3, 2, 3, 2);
            SpecificEmployee.Name = "SpecificEmployee";
            SpecificEmployee.Size = new Size(234, 50);
            SpecificEmployee.TabIndex = 1;
            SpecificEmployee.Text = "View a specific employee (ID)";
            SpecificEmployee.UseVisualStyleBackColor = false;
            SpecificEmployee.Click += button2_Click;
            // 
            // AddEmployee
            // 
            AddEmployee.BackColor = Color.Thistle;
            AddEmployee.Font = new Font("SimSun", 9F, FontStyle.Bold, GraphicsUnit.Point);
            AddEmployee.Location = new Point(355, 261);
            AddEmployee.Margin = new Padding(3, 2, 3, 2);
            AddEmployee.Name = "AddEmployee";
            AddEmployee.Size = new Size(234, 50);
            AddEmployee.TabIndex = 2;
            AddEmployee.Text = "Add a new employee";
            AddEmployee.UseVisualStyleBackColor = false;
            AddEmployee.Click += button3_Click;
            // 
            // RemoveEmployee
            // 
            RemoveEmployee.BackColor = Color.Thistle;
            RemoveEmployee.Font = new Font("SimSun", 9F, FontStyle.Bold, GraphicsUnit.Point);
            RemoveEmployee.Location = new Point(355, 348);
            RemoveEmployee.Margin = new Padding(3, 2, 3, 2);
            RemoveEmployee.Name = "RemoveEmployee";
            RemoveEmployee.Size = new Size(234, 50);
            RemoveEmployee.TabIndex = 3;
            RemoveEmployee.Text = "Remove an employee";
            RemoveEmployee.UseVisualStyleBackColor = false;
            RemoveEmployee.Click += button4_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Cursor = Cursors.No;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(33, 84);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(279, 187);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Source Code Pro ExtraLight", 14F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(12, 30);
            label1.Name = "label1";
            label1.Size = new Size(339, 36);
            label1.TabIndex = 5;
            label1.Text = "Employee Main menu";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(647, 544);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(RemoveEmployee);
            Controls.Add(AddEmployee);
            Controls.Add(SpecificEmployee);
            Controls.Add(AllEmployee);
            Font = new Font("SimSun", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Main Menu";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AllEmployee;
        private Button SpecificEmployee;
        private Button AddEmployee;
        private Button RemoveEmployee;
        private PictureBox pictureBox1;
        private Label label1;
    }
}