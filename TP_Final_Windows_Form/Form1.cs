using Microsoft.Data.SqlClient;
using System.ComponentModel.Design.Serialization;
using System.Windows.Forms;

namespace TP_Final_Windows_Form
{

    public partial class Form1 : Form
    {
        string stringconnection = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\hykonenclub\\source\\repos\\TP_Final_Windows_Form\\TP_Final_Windows_Form\\Database1.mdf;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
            DGV_main.DataSource = Class1.Reload();

            DataGridViewButtonColumn btn_modif = new DataGridViewButtonColumn();
            btn_modif.HeaderText = "modifier";
            btn_modif.Text = "modifier";
            btn_modif.Name = "modifier";
            btn_modif.UseColumnTextForButtonValue = true;
            DGV_main.Columns.Add(btn_modif);

            DataGridViewButtonColumn btn_suppr = new DataGridViewButtonColumn();
            btn_suppr.HeaderText = "supprimer";
            btn_suppr.Text = "supprimer";
            btn_suppr.Name = "supprimer";
            btn_suppr.UseColumnTextForButtonValue = true;
            DGV_main.Columns.Add(btn_suppr);

            DGV_main.Columns["ID"].Visible = false; 


        }

        private void BTN_add_Click(object sender, EventArgs e)
        {
            Form2 Form_add = new Form2(DGV_main);
            Form_add.Show();
        }



        private void DGV_main_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DGV_main.Columns["supprimer"].Index && e.RowIndex >= 0)
            {
                DialogResult result = MessageBox.Show(
                    "Voulez vous supprimer cette colonne ?",
                    "confirmation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question


                    );
                if (result == DialogResult.Yes)
                {
                    try
                    {                   
                        DataGridViewRow row = DGV_main.Rows[e.RowIndex];
                        string id = row.Cells["ID"].Value.ToString(); 
                        using (SqlConnection conn = new SqlConnection(stringconnection))
                        {
                            conn.Open();
                            string req = "DELETE FROM Jeux WHERE ID = @ID";
                            SqlCommand cmd = new SqlCommand(req, conn);
                            cmd.Parameters.AddWithValue("@ID", id);



                            cmd.ExecuteNonQuery();
                        }
                        DGV_main.Rows.RemoveAt(e.RowIndex);


                        MessageBox.Show("ligne supprimée !");

                        Class1.Reload();


                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);


                    }





                }

            }
            else if (e.ColumnIndex == DGV_main.Columns["modifier"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow row = DGV_main.Rows[e.RowIndex];
                 string id = row.Cells["ID"].Value.ToString();
                string txt_nom = row.Cells["Nom"].Value.ToString();
                
                string DT_sortie = row.Cells["date_de_sortie"].Value.ToString();
                string enum_prix = row.Cells["Prix_en_euros"].Value.ToString();
                
                Form3 newform = new Form3(id, txt_nom, DT_sortie, enum_prix,  DGV_main); 

                 newform.Show();



            }


        }

        
    }
}
