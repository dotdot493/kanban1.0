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
    public partial class FPrincipal : Form
    {
        public FPrincipal()
        {
            InitializeComponent();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FCadStatus fCadStatus = new FCadStatus();
            fCadStatus.ShowDialog();
            this.Hide();

        }

        private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FCadTarefa fCadTarefa = new FCadTarefa();
            fCadTarefa.ShowDialog();
            this.tarefaTableAdapter.Fill(this.gtarefasDataSet.Tarefa);
        }

        private void cadastrarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FCadRespon fCadRespon = new FCadRespon();
            fCadRespon.ShowDialog();
            this.Hide();
        }

        private void tarefaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tarefaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gtarefasDataSet);

        }

        private void FPrincipal_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'gtarefasDataSet.Tarefa'. Você pode movê-la ou removê-la conforme necessário.
            this.tarefaTableAdapter.Fill(this.gtarefasDataSet.Tarefa);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
           this.tableAdapterManager.UpdateAll(this.gtarefasDataSet);
           tarefaDataGridView.Update();
            tarefaDataGridView.Refresh();
           
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sobre Tela = new Sobre();
            Tela.Show();
            this.Hide();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void statusToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void entrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login Tela = new Login();
            Tela.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
