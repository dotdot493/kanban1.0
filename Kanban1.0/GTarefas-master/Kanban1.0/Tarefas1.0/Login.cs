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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = tbnome.Text;
            string senha = tbsenha.Text;
            if ((nome == "admin") && (senha == "admin"))
            {





                FPrincipal fhome = new FPrincipal();
                this.Visible = false;
                fhome.ShowDialog();
            }
            else
            {
                MessageBox.Show(this, "senha incorreta!!!", "sistema Zé", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }
        }
    }
}
