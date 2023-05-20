using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HamimiProofei
{
    public partial class FrmImagem : Form
    {

        private bool dragging = false;
        private Point startPoint = new Point(0, 0);

        public static TblAdmin TabelaAdmin
        {
            get
            {
                if (_tabelaAdmin == null)
                {
                    _tabelaAdmin = new TblAdmin();
                }
                return _tabelaAdmin;
            }
        }

        private static TblAdmin _tabelaAdmin;

        public static FrmGerenciador FormGerenciador
        {
            get
            {
                if (_formGerenciador == null)
                {
                    _formGerenciador = new FrmGerenciador();
                }
                return _formGerenciador;
            }
        }

        private static FrmGerenciador _formGerenciador;

        public static FrmCadastroLogado FormCadastroLogado
        {
            get
            {
                if (_formCadastroLogado == null)
                {
                    _formCadastroLogado = new FrmCadastroLogado();
                }
                return _formCadastroLogado;
            }
        }

        private static FrmCadastroLogado _formCadastroLogado;

        public static FrmAnimeList FormAnimeList
        {
            get
            {
                if (_formAnimeList == null)
                {
                    _formAnimeList = new FrmAnimeList();
                }
                return _formAnimeList;
            }
        }

        private static FrmAnimeList _formAnimeList;

        public FrmImagem()
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

        private void FrmImagem_Load(object sender, EventArgs e)
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

        private void picBoxCenter_Click(object sender, EventArgs e)
        {
               
        }

        private void BtnAnimeList_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                FrmImagem.FormAnimeList.Location = this.Location;
                FrmImagem.FormAnimeList.Width = this.Width;
                FrmImagem.FormAnimeList.Height = this.Height;
                FrmImagem.FormAnimeList.StartPosition = FormStartPosition.Manual;
                FrmImagem.FormAnimeList.FormClosing += delegate { this.Show(); };
                FrmImagem.FormAnimeList.Show();
                this.Hide();
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                FrmImagem.FormAnimeList.Location = this.Location;
                FrmImagem.FormAnimeList.StartPosition = FormStartPosition.Manual;
                FrmImagem.FormAnimeList.WindowState = FormWindowState.Maximized;
                FrmImagem.FormAnimeList.FormClosing += delegate { this.Show(); };
                FrmImagem.FormAnimeList.Show();
                this.Hide();
            }
        }

        private void FrmImagem_Resize(object sender, EventArgs e)
        {
            int formAltura = this.Height;
            int formLargura = this.Width;

            int formAlturaA = iframeSus.Height;
            int formLarguraA = iframeSus.Width;

            iframeSus.Size = new Size(formLarguraA, formAlturaA);

            //txtPesquisar.Text = "Altura: " + Convert.ToString(formAlturaA) + " Largura: "+Convert.ToString(formLarguraA) + " " + Convert.ToString(dtgAnimes.Location);

            panel1.Size = new Size(215, formAltura);
            BtnAnimeList.Location = new Point(BtnAnimeList.Location.X, 154 + 10);
            BtnAnimeGer.Location = new Point(BtnAnimeGer.Location.X, 154 + 20 + BtnAnimeList.Height);


            iframeSus.Size = new Size(formLargura - 215, formAltura - 29);


            ImagemCentral.Location = new Point((formLarguraA - ImagemCentral.Width) / 2, (formAlturaA - ImagemCentral.Height) / 2);
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
            if (FrmImagem.MousePosition.Y <= 1)
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
            panel6.Width = iframeSus.Width;
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
            if (FrmImagem.MousePosition.Y <= 1)
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

        private void BtnCadastro_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                FrmImagem.FormCadastroLogado.Location = this.Location;
                FrmImagem.FormCadastroLogado.Width = this.Width;
                FrmImagem.FormCadastroLogado.Height = this.Height;
                FrmImagem.FormCadastroLogado.StartPosition = FormStartPosition.Manual;
                FrmImagem.FormCadastroLogado.FormClosing += delegate { this.Show(); };
                FrmImagem.FormCadastroLogado.Show();
                this.Hide();
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                FrmImagem.FormCadastroLogado.Location = this.Location;
                FrmImagem.FormCadastroLogado.StartPosition = FormStartPosition.Manual;
                FrmImagem.FormCadastroLogado.WindowState = FormWindowState.Maximized;
                FrmImagem.FormCadastroLogado.FormClosing += delegate { this.Show(); };
                FrmImagem.FormCadastroLogado.Show();
                this.Hide();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Tem certeza que deseja sair?", "Caixa de Confirmação", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Restart();
                Environment.Exit(0);
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void BtnAnimeGer_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                FrmImagem.FormGerenciador.Location = this.Location;
                FrmImagem.FormGerenciador.Width = this.Width;
                FrmImagem.FormGerenciador.Height = this.Height;
                FrmImagem.FormGerenciador.StartPosition = FormStartPosition.Manual;
                FrmImagem.FormGerenciador.FormClosing += delegate { this.Show(); };
                FrmImagem.FormGerenciador.Show();
                this.Hide();
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                FrmImagem.FormGerenciador.Location = this.Location;
                FrmImagem.FormGerenciador.StartPosition = FormStartPosition.Manual;
                FrmImagem.FormGerenciador.WindowState = FormWindowState.Maximized;
                FrmImagem.FormGerenciador.FormClosing += delegate { this.Show(); };
                FrmImagem.FormGerenciador.Show();
                this.Hide();
            }
        }

        private void FrmImagem_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                FrmImagem.TabelaAdmin.Location = this.Location;
                FrmImagem.TabelaAdmin.Width = this.Width;
                FrmImagem.TabelaAdmin.Height = this.Height;
                FrmImagem.TabelaAdmin.StartPosition = FormStartPosition.Manual;
                FrmImagem.TabelaAdmin.FormClosing += delegate { this.Show(); };
                FrmImagem.TabelaAdmin.Show();
                FrmImagem.TabelaAdmin.AtualizaTabelaAdm();
                this.Hide();
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                FrmImagem.TabelaAdmin.Location = this.Location;
                FrmImagem.TabelaAdmin.StartPosition = FormStartPosition.Manual;
                FrmImagem.TabelaAdmin.WindowState = FormWindowState.Maximized;
                FrmImagem.TabelaAdmin.FormClosing += delegate { this.Show(); };
                FrmImagem.TabelaAdmin.Show();
                FrmImagem.TabelaAdmin.AtualizaTabelaAdm();
                this.Hide();
            }
        }
    }
}
