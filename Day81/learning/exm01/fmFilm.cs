using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace exm01
{
    public partial class fmFilm : Form
    {
        private DatabaseConnection dbConnection;
        private SqlConnection connection = new SqlConnection();
        private DataSet dataSet;
        private DataTable dataTableFilm;
        private DataTable dataTableRealisator;
        HelperClass helperClass = new HelperClass();
        string dsRealisator = "dsRealisator";
        string dsFilm = "dsFilm";
        public fmFilm()
        {
            InitializeComponent();
        }

        private void fmFilm_Load_1(object sender, EventArgs e)
        {
            dataSet = DatabaseConnection.Instance.dataSet;
            dataTableRealisator = dataSet.Tables[dsRealisator];
            dataTableFilm = dataSet.Tables[dsFilm];
            dgvFilm.DataSource = dataTableFilm;
            dgvFilm.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            helperClass.comboFiller(cbxfilm, dataTableRealisator, "realisator_Name", "id_realisator");

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string id = txbId.Text;
            string title = txbTitle.Text;
            string length = txbLength.Text;
            string releasedDate = dtpDate.Text;
            string comboFilm = cbxfilm.Text;
        }

        private void txbId_TextChanged(object sender, EventArgs e)
        {
            //SqlDataAdapter da = new SqlDataAdapter("SELECT DISTINCT Film.id_film, Film.titre_film, Film.duree_film, Film.dataSortie_film, realisateur.Nom_realisateur as Nom_realisateur FROM Film INNER JOIN realisateur ON Film.Id_realisateur = realisateur.Id_realisateur", cc.cnx);
            //cc.connecter();
            //rToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Q;
            //SqlDataAdapter da = new SqlDataAdapter("SELECT DISTINCT Film.id_film, Film.titre_film, Film.duree_film, Film.dataSortie_film, realisateur.Nom_realisateur as Nom_realisateur FROM Film INNER JOIN realisateur ON Film.Id_realisateur = realisateur.Id_realisateur", cc.cnx);
            //da.Fill(cc.ds, "Film");
            //dataGridView1.DataSource = cc.ds.Tables["Film"];
            //cc.FillComboSearchCode(comboBox1);


            //comboBox1.DataSource = cc.ds.Tables["realisateur"];
            //comboBox1.DisplayMember = "Nom_realisateur";
            //comboBox1.ValueMember = "Id_realisateur";


            //if (cc.ds.Tables.Count > 1)
            //{
            //    MessageBox.Show(cc.ds.Tables.Count.ToString());
            //}
            //cc.deconnecter();
        }

        private void txbId_KeyPress(object sender, KeyPressEventArgs e)
        {
            helperClass.allowIntOnly(e);
        }
    }
}
