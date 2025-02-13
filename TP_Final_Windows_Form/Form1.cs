using System.ComponentModel.Design.Serialization;
using System.Windows.Forms;

namespace TP_Final_Windows_Form
{
    public partial class Form1 : Form
    {
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


        }

        private void BTN_add_Click(object sender, EventArgs e)
        {
            Form2 Form_add = new Form2(DGV_main);
            Form_add.Show();
        }
    }
}
