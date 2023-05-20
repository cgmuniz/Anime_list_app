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

namespace HamimiProofei
{
    public partial class FrmPrincipal : Form
    {
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);


        public static FrmCadastro FormCadastro
        {
            get
            {
                if (_formCadastro == null)
                {
                    _formCadastro = new FrmCadastro();
                }
                return _formCadastro;
            }
        }

        private static FrmCadastro _formCadastro;

        public static FrmImagem FormImagem
        {
            get
            {
                if (_formImagem == null)
                {
                    _formImagem = new FrmImagem();
                }
                return _formImagem;
            }
        }

        private static FrmImagem _formImagem;


        public FrmPrincipal()
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
                if(pos.Y < cCaption)
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

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
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

        private void BtnAnimeList_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnAnimeList_MouseEnter(object sender, EventArgs e)
        {
            if (BtnAnimeList.BackColor != Color.FromArgb(240, 240, 240))
            {
                BtnAnimeList.ForeColor = Color.Black;
            }
        }

        private void BtnAnimeList_MouseLeave(object sender, EventArgs e)
        {
            if (BtnAnimeList.BackColor != Color.FromArgb(240, 240, 240))
            {
                BtnAnimeList.ForeColor = Color.White;
            }
        }

        private void BtnAnimeGer_Click_1(object sender, EventArgs e)
        {

        }
        private void BtnAnimeGer_MouseEnter(object sender, EventArgs e)
        {
            if (BtnAnimeGer.BackColor != Color.FromArgb(240, 240, 240))
            {
                BtnAnimeGer.ForeColor = Color.Black;
            }
        }

        private void BtnAnimeGer_MouseLeave(object sender, EventArgs e)
        {
            if (BtnAnimeGer.BackColor != Color.FromArgb(240, 240, 240))
            {
                BtnAnimeGer.ForeColor = Color.White;
            }
        }

        private void panel3_Paint(object sender, EventArgs e)
        {

        }

        private void lblLogin_Click(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void panel6_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void panel6_MouseUp(object sender, MouseEventArgs e)
        {
            if(FrmPrincipal.MousePosition.Y <= 1)
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

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void panel7_MouseUp(object sender, MouseEventArgs e)
        {
            if (FrmPrincipal.MousePosition.Y <= 1)
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

        private void btnSair_Click(object sender, EventArgs e)
        {

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

        public void iframeFake_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmPrincipal_Resize(object sender, EventArgs e)
        {
            int formAltura = this.Height;
            int formLargura = this.Width;

            panel1.Size = new Size(215, formAltura);
            BtnAnimeList.Location = new Point(BtnAnimeList.Location.X, 154 + 10);
            BtnAnimeGer.Location = new Point(BtnAnimeGer.Location.X, 154 + 20 + BtnAnimeList.Height);


            iframeFake.Size = new Size(formLargura - 215, formAltura - 29);

            int formCentroA = (formAltura - panel6.Height) / 2;
            int formCentroL = (formLargura - panel1.Width) / 2;

            lblLogin.Location = new Point(formCentroL - (lblLogin.Width / 2), (formCentroA - 100));

            txtUser.Location = new Point(formCentroL - (txtUser.Width / 2), (formCentroA - 25));
            txtSenha.Location = new Point(formCentroL - (txtSenha.Width / 2), (formCentroA + 25));

            lblUser.Location = new Point(formCentroL - (txtUser.Width / 2) - lblUser.Width - 10, (formCentroA - 25));
            lblSenha.Location = new Point(formCentroL - (txtSenha.Width / 2) - lblSenha.Width - 10, (formCentroA + 25));

            btnCadastrar.Location = new Point(formCentroL - (txtUser.Width / 2), (formCentroA + 70));
            btnLogar.Location = new Point(formCentroL - (txtSenha.Width / 2) + txtUser.Width - btnLogar.Width, (formCentroA + 70));
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {

            Admin admin = new Admin();
            adminDao adminDao = new adminDao();

            if (txtUser.Text == "")
            {
                MessageBox.Show("Insira o Nome de Usuário!");
            }
            else if (txtSenha.Text == "")
            {
                MessageBox.Show("Insira a Senha do Usuário!");
            }
            else
            {
                admin.setNomeAdmin(txtUser.Text);
                admin.setSenhaAdmin(txtSenha.Text);

                admin = adminDao.valNomeAdmin(admin);
                admin = adminDao.valSenhaAdmin(admin);

                if (admin.getValNomeAdmin() == null)
                {
                    MessageBox.Show("Usuário Nâo Cadastrado!");
                }
                else if (admin.getValSenhaAdmin() == null)
                {
                    MessageBox.Show("Senha Incorreta!");
                }
                else
                {
                    if (this.WindowState == FormWindowState.Normal)
                    {
                        FrmPrincipal.FormImagem.Location = this.Location;
                        FrmPrincipal.FormImagem.Width = this.Width;
                        FrmPrincipal.FormImagem.Height = this.Height;
                        FrmPrincipal.FormImagem.StartPosition = FormStartPosition.Manual;
                        FrmPrincipal.FormImagem.FormClosing += delegate { this.Show(); };
                        FrmPrincipal.FormImagem.Show();
                        this.Hide();
                    }
                    else if (this.WindowState == FormWindowState.Maximized)
                    {
                        FrmPrincipal.FormImagem.Location = this.Location;
                        FrmPrincipal.FormImagem.StartPosition = FormStartPosition.Manual;
                        FrmPrincipal.FormImagem.WindowState = FormWindowState.Maximized;
                        FrmPrincipal.FormImagem.FormClosing += delegate { this.Show(); };
                        FrmPrincipal.FormImagem.Show();
                        this.Hide();
                    }
                }
            }

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            if (this.WindowState == FormWindowState.Normal)
            {
                FrmPrincipal.FormCadastro.Location = this.Location;
                FrmPrincipal.FormCadastro.Width = this.Width;
                FrmPrincipal.FormCadastro.Height = this.Height;
                FrmPrincipal.FormCadastro.StartPosition = FormStartPosition.Manual;
                FrmPrincipal.FormCadastro.FormClosing += delegate { this.Show(); };
                FrmPrincipal.FormCadastro.Show();
                this.Hide();
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                FrmPrincipal.FormCadastro.Location = this.Location;
                FrmPrincipal.FormCadastro.StartPosition = FormStartPosition.Manual;
                FrmPrincipal.FormCadastro.WindowState = FormWindowState.Maximized;
                FrmPrincipal.FormCadastro.FormClosing += delegate { this.Show(); };
                FrmPrincipal.FormCadastro.Show();
                this.Hide();
            }
        }

        private void FrmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
