﻿namespace TP_Final_Windows_Form
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
            DGV_main = new DataGridView();
            BTN_add = new Button();
            ((System.ComponentModel.ISupportInitialize)DGV_main).BeginInit();
            SuspendLayout();
            // 
            // DGV_main
            // 
            DGV_main.AccessibleName = "DGV_main";
            DGV_main.AllowUserToAddRows = false;
            DGV_main.AllowUserToDeleteRows = false;
            DGV_main.AllowUserToResizeColumns = false;
            DGV_main.AllowUserToResizeRows = false;
            DGV_main.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DGV_main.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_main.EditMode = DataGridViewEditMode.EditOnF2;
            DGV_main.Location = new Point(179, 26);
            DGV_main.Margin = new Padding(3, 2, 3, 2);
            DGV_main.Name = "DGV_main";
            DGV_main.ReadOnly = true;
            DGV_main.RowHeadersWidth = 51;
            DGV_main.Size = new Size(476, 209);
            DGV_main.TabIndex = 0;
            DGV_main.CellContentClick += DGV_main_CellContentClick_1;
            // 
            // BTN_add
            // 
            BTN_add.Location = new Point(326, 298);
            BTN_add.Margin = new Padding(3, 2, 3, 2);
            BTN_add.Name = "BTN_add";
            BTN_add.Size = new Size(162, 22);
            BTN_add.TabIndex = 1;
            BTN_add.Text = "Ajouter un jeu";
            BTN_add.UseVisualStyleBackColor = true;
            BTN_add.Click += BTN_add_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(940, 338);
            Controls.Add(BTN_add);
            Controls.Add(DGV_main);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)DGV_main).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DGV_main;
        private Button BTN_add;
    }
}
