﻿using HamimiProofei.dao;
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

namespace HamimiProofei
{
    public partial class FrmCadastro : Form
    {
        
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);


        public static FrmPrincipal FormPrincipal
        {
            get
            {
                if (_formPrincipal == null)
                {
                    _formPrincipal = new FrmPrincipal();
                }
                return _formPrincipal;
            }
        }

        private static FrmPrincipal _formPrincipal;


        public FrmCadastro()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }

        private const int cGrip = 16;
        private const int cCaption = 32;

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);
                if (pos.Y < cCaption)
                {
                    m.Result = (IntPtr)2;
                    return;
                }
                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17;
                    return;
                }
            }
            base.WndProc(ref m);
        }

        private void FrmCadastro_Load(object sender, EventArgs e)
        {
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.Size = new Size(this.Width, this.Height);
        }

        private const int CS_DropShadow = 0x00020000;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DropShadow;
                return cp;
            }
        }

        private void btnAvançar_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            adminDao adminDao = new adminDao();
            bool valEmail = txtEmail.Text.Contains("@gmail.com") || txtEmail.Text.Contains("@yahoo.com.br") || txtEmail.Text.Contains("@hotmail.com") || txtEmail.Text.Contains("@outlook.com");

            if (txtUser.Text == "")
            {
                MessageBox.Show("Insira o Nome de Usuário!");
            }
            else if (txtEmail.Text == "")
            {
                MessageBox.Show("Insira o Email do Usuário!");
            }
            else if (valEmail == false)
            {
                MessageBox.Show("Email inválido! \n\nFormatos Aceitos: \n- @gmail.com \n- @yahoo.com.br \n- @hotmail.com \n- @outlook.com");
            }
            else if (txtSenha.Text == "")
            {
                MessageBox.Show("Insira a Senha do Usuário!");
            }
            else if (txtSenha.Text.Length < 6)
            {
                MessageBox.Show("A Senha Deve Ter de 6 a 20 Caracteres!");
            }
            else if (txtSenha2.Text == "")
            {
                MessageBox.Show("Confirme sua Senha!");
            }
            else if (txtSenha.Text != txtSenha2.Text)
            {
                MessageBox.Show("As Senhas não Condizem!");
            }
            else if (txtAccessK.Text == "")
            {
                MessageBox.Show("Insira a Chave de Acesso!");
            }
            else if (txtAccessK.Text != "FrywUHApPUgPYXKPYQS4")
            {
                MessageBox.Show("Chave de Acesso Incorreta!");
            }
            else
            {
                admin.setNomeAdmin(txtUser.Text);
                admin.setEmailAdmin(txtEmail.Text);
                admin.setSenhaAdmin(txtSenha.Text);

                admin = adminDao.valNomeAdmin(admin);
                admin = adminDao.valEmailAdmin(admin);

                if (admin.getValNomeAdmin() != null)
                {
                    MessageBox.Show("Esse Nome de Usuário Já Está Sendo Usado!");
                }
                else if (admin.getValEmailAdmin() != null)
                {
                    MessageBox.Show("Esse Email Já Está Sendo Usado");
                }
                else
                {
                    adminDao.inserir(admin);
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                FrmCadastro.FormPrincipal.Location = this.Location;
                FrmCadastro.FormPrincipal.Width = this.Width;
                FrmCadastro.FormPrincipal.Height = this.Height;
                FrmCadastro.FormPrincipal.StartPosition = FormStartPosition.Manual;
                FrmCadastro.FormPrincipal.FormClosing += delegate { this.Show(); };
                FrmCadastro.FormPrincipal.Show();
                this.Hide();
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                FrmCadastro.FormPrincipal.Location = this.Location;
                FrmCadastro.FormPrincipal.StartPosition = FormStartPosition.Manual;
                FrmCadastro.FormPrincipal.WindowState = FormWindowState.Maximized;
                FrmCadastro.FormPrincipal.FormClosing += delegate { this.Show(); };
                FrmCadastro.FormPrincipal.Show();
                this.Hide();
            }
        }

        private void FrmCadastro_Resize(object sender, EventArgs e)
        {
            int formAltura = this.Height;
            int formLargura = this.Width;

            //txtPesquisar.Text = "Altura: " + Convert.ToString(formAlturaA) + " Largura: "+Convert.ToString(formLarguraA) + " " + Convert.ToString(dtgAnimes.Location);

            panel1.Size = new Size(215, formAltura);
            BtnAnimeList.Location = new Point(BtnAnimeList.Location.X, 154 + 10);
            BtnAnimeGer.Location = new Point(BtnAnimeGer.Location.X, 154 + 20 + BtnAnimeList.Height);


            iframeFake.Size = new Size(formLargura - 215, formAltura - 29);

            int formCentroA = (formAltura - panel6.Height) / 2;
            int formCentroL = (formLargura - panel1.Width) / 2;


            txtSenha.Location = new Point(((formLargura - panel1.Width - 20 - lblSenha.Width - txtSenha.Width) / 2) + 20 + lblSenha.Width, formCentroA - (txtUser.Height / 2));
            lblSenha.Location = new Point(txtSenha.Location.X - lblSenha.Width - 20, txtSenha.Location.Y);

            txtEmail.Location = new Point(txtSenha.Location.X, txtSenha.Location.Y - 20 - txtEmail.Height);
            lblEmail.Location = new Point(lblSenha.Location.X, txtSenha.Location.Y - 20 - lblEmail.Height);

            txtSenha2.Location = new Point(txtSenha.Location.X, txtSenha.Location.Y + 20 + txtSenha2.Height);
            lblSenha2.Location = new Point(lblSenha.Location.X, txtSenha.Location.Y + 20 + txtSenha2.Height);

            txtUser.Location = new Point(txtSenha.Location.X, txtEmail.Location.Y - 20 - txtUser.Height);
            lblUser.Location = new Point(lblSenha.Location.X, txtEmail.Location.Y - 20 - txtUser.Height);

            txtAccessK.Location = new Point(txtSenha.Location.X, txtSenha2.Location.Y + 20 + txtAccessK.Height);
            lblAccessK.Location = new Point(lblSenha.Location.X, txtSenha2.Location.Y + 20 + txtAccessK.Height);

            lblCadastro.Location = new Point(formCentroL - (lblCadastro.Width / 2), txtUser.Location.Y - 30 - lblCadastro.Height);

            btnLogin.Location = new Point(txtAccessK.Location.X + txtAccessK.Width - btnLogin.Width, txtAccessK.Location.Y + 25 + txtAccessK.Height);
            btnAvançar.Location = new Point(btnLogin.Location.X - 20 - btnAvançar.Width, btnLogin.Location.Y);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMini_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
                btnMax.Image = Image.FromFile("D:\\Programas_Simples\\Escola\\Visual_Studio\\HamimiProofei\\imagens\\quadradoDuplo.png");
            }
            else if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
                btnMax.Image = Image.FromFile("D:\\Programas_Simples\\Escola\\Visual_Studio\\HamimiProofei\\imagens\\quaudu.png"); ;
            }
        }

        private void panel6_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void panel6_MouseUp(object sender, MouseEventArgs e)
        {
            if (FrmCadastro.MousePosition.Y <= 1)
            {
                WindowState = FormWindowState.Maximized;
            }
            dragging = false;
        }

        private void panel6_MouseMove(object sender, MouseEventArgs e)
        {

            if (dragging)
            {
                WindowState = FormWindowState.Normal;
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);
            }
        }

        private void panel6_Paint(object sender, EventArgs e)
        {
            panel6.Width = iframeFake.Width;
        }

        private void panel7_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void panel7_MouseUp(object sender, MouseEventArgs e)
        {
            if (FrmCadastro.MousePosition.Y <= 1)
            {
                WindowState = FormWindowState.Maximized;
            }
            dragging = false;
        }

        private void panel7_MouseMove(object sender, MouseEventArgs e)
        {

            if (dragging)
            {
                WindowState = FormWindowState.Normal;
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);
            }
        }

        private void FrmCadastro_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
