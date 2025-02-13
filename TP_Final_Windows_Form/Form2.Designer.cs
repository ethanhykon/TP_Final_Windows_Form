namespace TP_Final_Windows_Form
{
    partial class Form2
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
            BTN_add = new Button();
            lbl_nom = new Label();
            lbl_prix = new Label();
            txt_nom = new TextBox();
            combo_genre = new ComboBox();
            dtp_date = new DateTimePicker();
            combo_dispo = new ComboBox();
            lbl_date = new Label();
            lbl_genre = new Label();
            lbl_dispo = new Label();
            num_prix = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)num_prix).BeginInit();
            SuspendLayout();
            // 
            // BTN_add
            // 
            BTN_add.Location = new Point(266, 373);
            BTN_add.Name = "BTN_add";
            BTN_add.Size = new Size(216, 29);
            BTN_add.TabIndex = 0;
            BTN_add.Text = "Ajouter ";
            BTN_add.UseVisualStyleBackColor = true;
            BTN_add.Click += BTN_add_Click;
            // 
            // lbl_nom
            // 
            lbl_nom.AutoSize = true;
            lbl_nom.Location = new Point(143, 49);
            lbl_nom.Name = "lbl_nom";
            lbl_nom.Size = new Size(84, 20);
            lbl_nom.TabIndex = 1;
            lbl_nom.Text = "nom du jeu";
            // 
            // lbl_prix
            // 
            lbl_prix.AutoSize = true;
            lbl_prix.Location = new Point(160, 245);
            lbl_prix.Name = "lbl_prix";
            lbl_prix.Size = new Size(56, 20);
            lbl_prix.TabIndex = 2;
            lbl_prix.Text = "prix (€)";
            
            // 
            // txt_nom
            // 
            txt_nom.Location = new Point(254, 46);
            txt_nom.Name = "txt_nom";
            txt_nom.Size = new Size(254, 27);
            txt_nom.TabIndex = 4;
            // 
            // combo_genre
            // 
            combo_genre.DisplayMember = "test3";
            combo_genre.DropDownStyle = ComboBoxStyle.DropDownList;
            combo_genre.FormattingEnabled = true;
            combo_genre.Location = new Point(254, 110);
            combo_genre.Name = "combo_genre";
            combo_genre.Size = new Size(254, 28);
            combo_genre.TabIndex = 6;
            // 
            // dtp_date
            // 
            dtp_date.Location = new Point(254, 180);
            dtp_date.Name = "dtp_date";
            dtp_date.Size = new Size(254, 27);
            dtp_date.TabIndex = 7;
           
            // 
            // combo_dispo
            // 
            combo_dispo.DropDownStyle = ComboBoxStyle.DropDownList;
            combo_dispo.FormattingEnabled = true;
            combo_dispo.Location = new Point(254, 302);
            combo_dispo.Name = "combo_dispo";
            combo_dispo.Size = new Size(254, 28);
            combo_dispo.TabIndex = 8;
            // 
            // lbl_date
            // 
            lbl_date.AutoSize = true;
            lbl_date.Location = new Point(130, 180);
            lbl_date.Name = "lbl_date";
            lbl_date.Size = new Size(101, 20);
            lbl_date.TabIndex = 9;
            lbl_date.Text = "date de sortie";
            // 
            // lbl_genre
            // 
            lbl_genre.AutoSize = true;
            lbl_genre.Location = new Point(147, 110);
            lbl_genre.Name = "lbl_genre";
            lbl_genre.Size = new Size(47, 20);
            lbl_genre.TabIndex = 10;
            lbl_genre.Text = "genre";
            // 
            // lbl_dispo
            // 
            lbl_dispo.AutoSize = true;
            lbl_dispo.Location = new Point(139, 310);
            lbl_dispo.Name = "lbl_dispo";
            lbl_dispo.Size = new Size(88, 20);
            lbl_dispo.TabIndex = 11;
            lbl_dispo.Text = "disponiblité";
            // 
            // num_prix
            // 
            num_prix.Location = new Point(254, 245);
            num_prix.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
            num_prix.Name = "num_prix";
            num_prix.Size = new Size(254, 27);
            num_prix.TabIndex = 12;
            // 
            // Form2
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
            Controls.Add(BTN_add);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)num_prix).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BTN_add;
        private Label lbl_nom;
        private Label lbl_prix;
        private TextBox txt_nom;
        private ComboBox combo_genre;
        private DateTimePicker dtp_date;
        private ComboBox combo_dispo;
        private Label lbl_date;
        private Label lbl_genre;
        private Label lbl_dispo;
        private NumericUpDown num_prix;
    }
}