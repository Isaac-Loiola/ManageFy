using ManageFyClass.DAL;
using ManageFyClass.DAL.DAO;
using System.Security.AccessControl;

namespace ManageFyDesk
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void guna2HtmlLabel4_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            Context context = new();

            Generico<Conta> generico = new(context);
        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            Categoria categoria = new();
        }
    }
}
