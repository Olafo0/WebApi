﻿namespace WindowsApp
{
    partial class Form5
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
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            idsCB = new ComboBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 192, 192);
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(307, 93);
            button1.Name = "button1";
            button1.Size = new Size(163, 37);
            button1.TabIndex = 10;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 100);
            label2.Name = "label2";
            label2.Size = new Size(84, 25);
            label2.TabIndex = 9;
            label2.Text = "Enter ID :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(34, 28);
            label1.Name = "label1";
            label1.Size = new Size(452, 36);
            label1.TabIndex = 7;
            label1.Text = "Remove an Employee (ID)";
            // 
            // idsCB
            // 
            idsCB.DropDownStyle = ComboBoxStyle.DropDownList;
            idsCB.FormattingEnabled = true;
            idsCB.Location = new Point(155, 92);
            idsCB.Name = "idsCB";
            idsCB.Size = new Size(126, 33);
            idsCB.TabIndex = 12;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(571, 172);
            Controls.Add(idsCB);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form5";
            Text = "Form5";
            Load += Form5_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label2;
        private Label label1;
        private ComboBox idCB;
        private ComboBox idsCB;
    }
}