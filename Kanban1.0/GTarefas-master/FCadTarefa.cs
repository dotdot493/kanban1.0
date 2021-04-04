using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GTarefas
{
    public partial class FCadTarefa : Form
    {
        public FCadTarefa()
        {
            InitializeComponent();
        }

        private void tarefaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tarefaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gtarefasDataSet);

        }

        private void FCadTarefa_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'gtarefasDataSet.responsavel'. Você pode movê-la ou removê-la conforme necessário.
            this.responsavelTableAdapter.Fill(this.gtarefasDataSet.responsavel);
            // TODO: esta linha de código carrega dados na tabela 'gtarefasDataSet.Status'. Você pode movê-la ou removê-la conforme necessário.
            this.statusTableAdapter.Fill(this.gtarefasDataSet.Status);
            // TODO: esta linha de código carrega dados na tabela 'gtarefasDataSet.Tarefa'. Você pode movê-la ou removê-la conforme necessário.
            this.tarefaTableAdapter.Fill(this.gtarefasDataSet.Tarefa);
            this.tarefaBindingSource.AddNew();
        }

        private void fKStatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BTSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                tarefaBindingSource.EndEdit();
                tableAdapterManager.UpdateAll(gtarefasDataSet);
                Close();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void descricaoLabel_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void visualizarTarefasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FPrincipal Tela = new FPrincipal();
            Tela.Show();
            this.Hide();
        }

        private void cadastrarStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sobre Tela = new Sobre();
            Tela.Show();
            this.Hide();

        }
    }
}
