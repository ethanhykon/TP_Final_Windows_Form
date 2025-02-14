using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TP_Final_Windows_Form
{
    public partial class Form3 : Form
    {
        DataGridView DGV_edit;
        string id;
       
        string dbconn = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\hykonenclub\\source\\repos\\TP_Final_Windows_Form\\TP_Final_Windows_Form\\Database1.mdf;Integrated Security=True";

        string txt_editnom;
        
        string DT_editsortie;
        string enum_editprix;
        


        public Form3(string id, string txt_editnom,  string DT_editsortie, string enum_editprix, DataGridView DGV_edit)
        {
            InitializeComponent();

            this.txt_editnom = txt_editnom;
           
            this.DT_editsortie = DT_editsortie;
            this.enum_editprix = enum_editprix;
            
            
            this.id = id;
            this.DGV_edit = DGV_edit;
            // declaration des variable pour pré remplir les champs 
            decimal enum_editprix_dec = Convert.ToDecimal(enum_editprix);
            DateTime DT_editsortie_DT = Convert.ToDateTime(DT_editsortie);

            this.num_prix.DecimalPlaces = 2;
            this.num_prix.Increment = 0.01M;
            this.num_prix.Minimum = 0.00M;
            this.num_prix.Maximum = 999999999.99M;
            
            // parametre pour ajouter les valeurs dans les champs
            this.num_prix.Value = enum_editprix_dec;
            this.dtp_date.Value = DT_editsortie_DT;
            this.txt_nom.Text = txt_editnom;
            

            this.combo_genre.Items.AddRange(new object[] { "FPS", "TPS", "RPG", "GACHA", "Visual novel", "Jeux de platformes" });
            this.combo_dispo.Items.AddRange(new object[] { "Disponible", "Prêté", "Vendu" });

        }

        private void BTN_edit_Click(object sender, EventArgs e)
        {
            // on récupere les nouvelle valeurs
            string release = this.dtp_date.Value.ToString("dd-MM-yyyy");
            string genre = this.combo_genre.Text;
            string dispo = this.combo_dispo.Text;
            string nom = this.txt_nom.Text.Trim();
            decimal pr = this.num_prix.Value;
            string prix = pr.ToString();


            if (nom == string.Empty || genre == string.Empty || dispo == string.Empty || prix == string.Empty)
            {
                MessageBox.Show("éreur");

            }
            else
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(dbconn))
                    {

                        conn.Open();
                        string req = "UPDATE Jeux  SET Nom = @Nom, Genre = @Genre, date_de_sortie = @date_de_sortie,  Prix_en_euros = @Prix_en_euros, Disponibilité = @Disponibilité WHERE ID = @ID";
                        SqlCommand cmd = new SqlCommand(req, conn);
                        cmd.Parameters.AddWithValue("@Nom", nom);
                        cmd.Parameters.AddWithValue("@Genre", genre);
                        cmd.Parameters.AddWithValue("@date_de_sortie", this.dtp_date.Value);
                        cmd.Parameters.AddWithValue("@Prix_en_euros", prix);
                        cmd.Parameters.AddWithValue("@Disponibilité", dispo);
                        cmd.Parameters.AddWithValue("@ID", id);
                        cmd.ExecuteNonQuery();

                        DGV_edit.DataSource = Class1.Reload();
                        MessageBox.Show("Modification éffectué");

                        conn.Close();

                    }




                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
