namespace TP_Final_Windows_Form
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
            num_prix = new NumericUpDown();
            lbl_dispo = new Label();
            lbl_genre = new Label();
            lbl_date = new Label();
            combo_dispo = new ComboBox();
            dtp_date = new DateTimePicker();
            combo_genre = new ComboBox();
            txt_nom = new TextBox();
            lbl_prix = new Label();
            lbl_nom = new Label();
            BTN_edit = new Button();
            ((System.ComponentModel.ISupportInitialize)num_prix).BeginInit();
            SuspendLayout();
            // 
            // num_prix
            // 
            num_prix.Location = new Point(335, 246);
            num_prix.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
            num_prix.Name = "num_prix";
            num_prix.Size = new Size(254, 27);
            num_prix.TabIndex = 34;
            // 
            // lbl_dispo
            // 
            lbl_dispo.AutoSize = true;
            lbl_dispo.Location = new Point(220, 311);
            lbl_dispo.Name = "lbl_dispo";
            lbl_dispo.Size = new Size(88, 20);
            lbl_dispo.TabIndex = 33;
            lbl_dispo.Text = "disponiblité";
            // 
            // lbl_genre
            // 
            lbl_genre.AutoSize = true;
            lbl_genre.Location = new Point(228, 111);
            lbl_genre.Name = "lbl_genre";
            lbl_genre.Size = new Size(47, 20);
            lbl_genre.TabIndex = 32;
            lbl_genre.Text = "genre";
            // 
            // lbl_date
            // 
            lbl_date.AutoSize = true;
            lbl_date.Location = new Point(211, 181);
            lbl_date.Name = "lbl_date";
            lbl_date.Size = new Size(101, 20);
            lbl_date.TabIndex = 31;
            lbl_date.Text = "date de sortie";
            // 
            // combo_dispo
            // 
            combo_dispo.DropDownStyle = ComboBoxStyle.DropDownList;
            combo_dispo.FormattingEnabled = true;
            combo_dispo.Location = new Point(335, 303);
            combo_dispo.Name = "combo_dispo";
            combo_dispo.Size = new Size(254, 28);
            combo_dispo.TabIndex = 30;
            // 
            // dtp_date
            // 
            dtp_date.Location = new Point(335, 181);
            dtp_date.Name = "dtp_date";
            dtp_date.Size = new Size(254, 27);
            dtp_date.TabIndex = 29;
            // 
            // combo_genre
            // 
            combo_genre.DisplayMember = "test3";
            combo_genre.DropDownStyle = ComboBoxStyle.DropDownList;
            combo_genre.FormattingEnabled = true;
            combo_genre.Location = new Point(335, 111);
            combo_genre.Name = "combo_genre";
            combo_genre.Size = new Size(254, 28);
            combo_genre.TabIndex = 28;
            // 
            // txt_nom
            // 
            txt_nom.Location = new Point(335, 47);
            txt_nom.Name = "txt_nom";
            txt_nom.Size = new Size(254, 27);
            txt_nom.TabIndex = 27;
            // 
            // lbl_prix
            // 
            lbl_prix.AutoSize = true;
            lbl_prix.Location = new Point(241, 246);
            lbl_prix.Name = "lbl_prix";
            lbl_prix.Size = new Size(56, 20);
            lbl_prix.TabIndex = 26;
            lbl_prix.Text = "prix (€)";
            // 
            // lbl_nom
            // 
            lbl_nom.AutoSize = true;
            lbl_nom.Location = new Point(224, 50);
            lbl_nom.Name = "lbl_nom";
            lbl_nom.Size = new Size(84, 20);
            lbl_nom.TabIndex = 25;
            lbl_nom.Text = "nom du jeu";
            // 
            // BTN_edit
            // 
            BTN_edit.Location = new Point(347, 374);
            BTN_edit.Name = "BTN_edit";
            BTN_edit.Size = new Size(216, 29);
            BTN_edit.TabIndex = 24;
            BTN_edit.Text = "modifier";
            BTN_edit.UseVisualStyleBackColor = true;
            BTN_edit.Click += BTN_edit_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(num_prix);
            Controls.Add(lbl_dispo);
            Controls.Add(lbl_genre);
            Controls.Add(lbl_date);
            Controls.Add(combo_dispo);
            Controls.Add(dtp_date);
            Controls.Add(combo_genre);
            Controls.Add(txt_nom);
            Controls.Add(lbl_prix);
            Controls.Add(lbl_nom);
            Controls.Add(BTN_edit);
            Name = "Form3";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)num_prix).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown num_prix;
        private Label lbl_dispo;
        private Label lbl_genre;
        private Label lbl_date;
        private ComboBox combo_dispo;
        private DateTimePicker dtp_date;
        private ComboBox combo_genre;
        private TextBox txt_nom;
        private Label lbl_prix;
        private Label lbl_nom;
        private Button BTN_edit;
    }
}