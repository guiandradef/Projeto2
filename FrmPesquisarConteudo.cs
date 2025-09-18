using System;
using System.Data;
using System.Windows.Forms;

namespace AvaliacaoStreaming
{
    public partial class FrmPesquisarConteudo : Form
    {
        public FrmPesquisarConteudo()
        {
            InitializeComponent();
        }

        private void FrmPesquisarConteudo_Load(object sender, EventArgs e)
        {
            CarregarDadosGrid();
 
        }

        private void CarregarDadosGrid()
        {
            AcessoDados db = new AcessoDados();
            dgv.DataSource = db.ListarConteudos();
            FormatarGrid();
        }

        private void FormatarGrid()
        {
            if (dgv.ColumnCount > 0)
            {
                dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgv.Columns["ID"].HeaderText = "ID";
                dgv.Columns["titulo"].HeaderText = "Título";
                dgv.Columns["genero"].HeaderText = "Categoria";
                dgv.Columns["ano"].HeaderText = "Ano";
                dgv.Columns["nota_media"].HeaderText = "Nota Média";

                dgv.Columns["ID"].Visible = false;
            }
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            string campo = "";
            if (cmbCampo.SelectedItem != null)
            {
                switch (cmbCampo.SelectedItem.ToString())
                {
                    case "Título": campo = "titulo"; break;
                    case "Categoria": campo = "genero"; break;
                    case "Ano": campo = "ano"; break;
                    case "Nota": campo = "nota_media"; break;
                    case "ID": campo = "ID"; break;
                }
            }
            else
            {
                MessageBox.Show("Selecione um campo de pesquisa.", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string criterio = txtBusca.Text.Trim();

            AcessoDados db = new AcessoDados();
            dgv.DataSource = db.PesquisarConteudo(campo, criterio);

            FormatarGrid();
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            txtBusca.Clear();
            cmbCampo.SelectedIndex = -1;
            dgv.DataSource = null;
            dgv.Rows.Clear();
            dgv.Refresh();

        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string titulo = dgv.Rows[e.RowIndex].Cells["titulo"].Value.ToString();
                MessageBox.Show("Selecionado: " + titulo);
            }
        }

        private void BtnVoltarPesquisarConteudo_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmPrincipal frm = new FrmPrincipal();
            frm.ShowDialog();
            this.Close();

        }
    }
}
