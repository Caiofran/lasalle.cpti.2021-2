using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace View
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            //FrmCadPessoa form = new FrmCadPessoa();
            InitializeComponent();
        }

        /*private void btnok_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Você apertou no botão ok");
            FrmCadPessoa form = new FrmCadPessoa();

            //this.Visible = false;

            //form.Show();
            form.ShowDialog();

            //this.Visible = true;

            //MessageBox.Show("Chegou aqui!!!");
        }*/

        /*private void MensagemNaTela(object sender, EventArgs e)
        {
            MessageBox.Show("Novo método funcionando!!");
            Pessoa p = new Pessoa();

            int a = 2;
            int b = 3;
            int res = a + b;
            p.CPF = res;

            //MessageBox.Show("Resutado " + res);
            MessageBox.Show("CPF: " + p.CPF);
        }*/

        /*private void btncancel_Click(object sender, EventArgs e)
        {

        }*/

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            FrmLogin formLogin = new FrmLogin();
            //this.Visible = false;
            this.Hide();

            if (formLogin.ShowDialog() == DialogResult.OK)
            {
                //this.Visible = true;
                User u = (User)formLogin.Tag;
                itbUsuarioLogado.Text = u.Usuario; 
                this.Show();
            }
            else
            {
                this.Close();
            }
        }
    }
}
