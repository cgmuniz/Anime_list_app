using HamimiProofei.dao;
using HamimiProofei.model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace HamimiProofei
{
    public partial class FormVerificaSenha : Form
    {
        public String puxaNome;


        public FormVerificaSenha()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtSenhaAdmin.Clear();
            this.Hide();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            adminDao adminDao = new adminDao();

            admin.setNomeAdmin(puxaNome);

            admin.setSenhaAdmin(txtSenhaAdmin.Text);

            admin = adminDao.valSenhaAdmin(admin);

            if (admin.getValSenhaAdmin() != null || txtSenhaAdmin.Text == "FrywUHApPUgPYXKPYQS4")
            {
                admin = adminDao.selectId(admin);
                adminDao.excluir(admin);

                txtSenhaAdmin.Clear();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Senha Ou Chave De Acesso Incorreta!");
                txtSenhaAdmin.Clear();
            }
        }
    }
}
