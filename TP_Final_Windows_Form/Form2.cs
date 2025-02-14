using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_Final_Windows_Form
{
    public partial class Form2 : Form
    {
        string dbconn = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\hykonenclub\\source\\repos\\TP_Final_Windows_Form\\TP_Final_Windows_Form\\Database1.mdf;Integrated Security=True";
        DataGridView DGV;
        public Form2(DataGridView DGV)
        {
            InitializeComponent(); 
            this.DGV = DGV;
           // ajout des paramètre des combo box  numération
            this.num_prix.DecimalPlaces = 2; 
            this.num_prix.Increment = 0.01M;  
            this.num_prix.Minimum = 0.00M;   
            this.num_prix.Maximum = 999999999.99M;  
            
            this.combo_genre.Items.AddRange(new object[] { "FPS", "TPS", "RPG", "GACHA", "Visual novel", "Jeux de platformes" });
            this.combo_dispo.Items.AddRange(new object[] { "Disponible", "Prêté", "Vendu"});
           
        } 

        private void BTN_add_Click(object sender, EventArgs e)
        {
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
                        string req = "INSERT INTO Jeux (Nom, Genre, date_de_sortie, Prix_en_euros, Disponibilité)  VALUES (@Nom, @Genre, @date_de_sortie, @Prix_en_euros, @Disponibilité)";
                        SqlCommand cmd = new SqlCommand(req, conn);
                        cmd.Parameters.AddWithValue("@Nom", nom);
                        cmd.Parameters.AddWithValue("@Genre", genre);
                        cmd.Parameters.AddWithValue("@date_de_sortie", this.dtp_date.Value);
                        cmd.Parameters.AddWithValue("@Prix_en_euros", prix);
                        cmd.Parameters.AddWithValue("@Disponibilité", dispo);
                        
                        cmd.ExecuteNonQuery();
                        
                        DGV.DataSource = Class1.Reload();
                        MessageBox.Show("Jeu ajouté");
                        
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
