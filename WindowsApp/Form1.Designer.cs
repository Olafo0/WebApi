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
            components = new System.ComponentModel.Container();
            AllEmployee = new Button();
            SpecificEmployee = new Button();
            AddEmployee = new Button();
            RemoveEmployee = new Button();
            label1 = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // AllEmployee
            // 
            AllEmployee.BackColor = Color.White;
            AllEmployee.BackgroundImageLayout = ImageLayout.None;
            AllEmployee.Cursor = Cursors.Hand;
            AllEmployee.FlatStyle = FlatStyle.Popup;
            AllEmployee.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            AllEmployee.ForeColor = SystemColors.ActiveBorder;
            AllEmployee.Location = new Point(199, 144);
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
            SpecificEmployee.BackColor = Color.White;
            SpecificEmployee.BackgroundImageLayout = ImageLayout.None;
            SpecificEmployee.Cursor = Cursors.Hand;
            SpecificEmployee.FlatStyle = FlatStyle.Popup;
            SpecificEmployee.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            SpecificEmployee.ForeColor = SystemColors.ActiveBorder;
            SpecificEmployee.Location = new Point(199, 227);
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
            AddEmployee.BackColor = Color.White;
            AddEmployee.BackgroundImageLayout = ImageLayout.None;
            AddEmployee.Cursor = Cursors.Hand;
            AddEmployee.FlatStyle = FlatStyle.Popup;
            AddEmployee.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            AddEmployee.ForeColor = SystemColors.ActiveBorder;
            AddEmployee.Location = new Point(199, 312);
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
            RemoveEmployee.BackColor = Color.White;
            RemoveEmployee.BackgroundImageLayout = ImageLayout.None;
            RemoveEmployee.Cursor = Cursors.Hand;
            RemoveEmployee.FlatStyle = FlatStyle.Popup;
            RemoveEmployee.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            RemoveEmployee.ForeColor = SystemColors.ActiveBorder;
            RemoveEmployee.Location = new Point(199, 399);
            RemoveEmployee.Margin = new Padding(3, 2, 3, 2);
            RemoveEmployee.Name = "RemoveEmployee";
            RemoveEmployee.Size = new Size(234, 50);
            RemoveEmployee.TabIndex = 3;
            RemoveEmployee.Text = "Remove an employee";
            RemoveEmployee.UseVisualStyleBackColor = false;
            RemoveEmployee.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(245, 66);
            label1.Name = "label1";
            label1.Size = new Size(146, 31);
            label1.TabIndex = 5;
            label1.Text = "Main menu";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 12F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(647, 544);
            Controls.Add(label1);
            Controls.Add(RemoveEmployee);
            Controls.Add(AddEmployee);
            Controls.Add(SpecificEmployee);
            Controls.Add(AllEmployee);
            Font = new Font("SimSun", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Employee manager";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AllEmployee;
        private Button SpecificEmployee;
        private Button AddEmployee;
        private Button RemoveEmployee;
        private Label label1;
        private ErrorProvider errorProvider1;
    }
}