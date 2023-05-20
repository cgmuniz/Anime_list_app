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
    public partial class FrmGerenciador : Form
    {

        private bool dragging = false;
        private Point startPoint = new Point(0, 0);

        private OpenFileDialog abrir = new OpenFileDialog();


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


        public FrmGerenciador()
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

        private void FrmGerenciador_Load(object sender, EventArgs e)
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

        private void FrmGerenciador_Resize(object sender, EventArgs e)
        {
            ResizeConfig();
            ResizeConfig();
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
            ResizeConfig();
            ResizeConfig();
        }

        private void panel6_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void panel6_MouseUp(object sender, MouseEventArgs e)
        {
            if (FrmGerenciador.MousePosition.Y <= 1)
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
            if (FrmGerenciador.MousePosition.Y <= 1)
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

        private void BtnAnimeList_Click(object sender, EventArgs e)
        {

            if (this.WindowState == FormWindowState.Normal)
            {
                FrmGerenciador.FormAnimeList.Location = this.Location;
                FrmGerenciador.FormAnimeList.Width = this.Width;
                FrmGerenciador.FormAnimeList.Height = this.Height;
                FrmGerenciador.FormAnimeList.StartPosition = FormStartPosition.Manual;
                FrmGerenciador.FormAnimeList.FormClosing += delegate { this.Show(); };
                FrmGerenciador.FormAnimeList.Show();
                FormAnimeList.AtualizaTabelaAnime();
                this.Hide();
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                FrmGerenciador.FormAnimeList.Location = this.Location;
                FrmGerenciador.FormAnimeList.StartPosition = FormStartPosition.Manual;
                FrmGerenciador.FormAnimeList.WindowState = FormWindowState.Maximized;
                FrmGerenciador.FormAnimeList.FormClosing += delegate { this.Show(); };
                FrmGerenciador.FormAnimeList.Show();
                FormAnimeList.AtualizaTabelaAnime();
                this.Hide();
            }
        }

        private void BtnCadastro_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                FrmGerenciador.FormCadastroLogado.Location = this.Location;
                FrmGerenciador.FormCadastroLogado.Width = this.Width;
                FrmGerenciador.FormCadastroLogado.Height = this.Height;
                FrmGerenciador.FormCadastroLogado.StartPosition = FormStartPosition.Manual;
                FrmGerenciador.FormCadastroLogado.FormClosing += delegate { this.Show(); };
                FrmGerenciador.FormCadastroLogado.Show();
                this.Hide();
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                FrmGerenciador.FormCadastroLogado.Location = this.Location;
                FrmGerenciador.FormCadastroLogado.StartPosition = FormStartPosition.Manual;
                FrmGerenciador.FormCadastroLogado.WindowState = FormWindowState.Maximized;
                FrmGerenciador.FormCadastroLogado.FormClosing += delegate { this.Show(); };
                FrmGerenciador.FormCadastroLogado.Show();
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

        private void ptbFoto_Click(object sender, EventArgs e)
        {
            abrir.Filter = "JPG Files|*.jpg|PNG Files|*.png";
            if (abrir.ShowDialog() == DialogResult.OK)
            {
                string foto = abrir.FileName.ToString();
                txtImagem.Text = foto;
                ptbFoto.Image = Image.FromFile(abrir.FileName);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Anime anime = new Anime();
            animeDao animeDao = new animeDao();

            if (txtImagem.Text == "")
            {
                MessageBox.Show("Insira a Imagem do Anime!");
            }
            else if (txtNomeAnime.Text == "")
            {
                MessageBox.Show("Insira o Nome do Anime!");
            }
            else if (txtNomeAnime.Text.Length <= 2)
            {
                MessageBox.Show("O Nome do Anime Deve Ter Mais de 2 Caracteres!");
            }
            else if (txtEstudio.Text == "")
            {
                MessageBox.Show("Insira o Estudio do Anime!");
            }
            else if (txtNumEps.Text == "")
            {
                MessageBox.Show("Insira o Número de Episódios do Anime!");
            }
            else if (txtSinopse.Text == "")
            {
                MessageBox.Show("Insira o Sinopse do Anime!");
            }
            else
            {
                byte[] fotoAnime = null;
                FileStream file = new FileStream(this.txtImagem.Text, FileMode.Open, FileAccess.Read);
                BinaryReader reader = new BinaryReader(file);
                fotoAnime = reader.ReadBytes((int)file.Length);

                anime.setNomeAnime(txtNomeAnime.Text);
                anime.setEstudio(txtEstudio.Text);
                anime.setNumEps(int.Parse(txtNumEps.Text)); //Convertido para inteiro
                anime.setDataLanc(dtpData.Text);
                anime.setSinopse(txtSinopse.Text);
                anime.setFotoAnime(fotoAnime);

                anime = animeDao.valAnime(anime);

                if (anime.getValAnime() == null)
                {
                    animeDao.inserir(anime);
                }
                else
                {
                    MessageBox.Show("O Anime de Nome '" + anime.getValAnime() + "' Já Está Cadastrado no Banco de Dados!");
                }

            }
        }

        public void ResizeConfig()
        {
            int formAltura = this.Height;
            int formLargura = this.Width;
            int formAlturaA = iframeFake.Height;
            int formLarguraA = iframeFake.Width;

            iframeFake.Size = new Size(formLarguraA, formAlturaA);

            panel1.Size = new Size(215, formAltura);
            BtnAnimeList.Location = new Point(BtnAnimeList.Location.X, 154 + 10);
            BtnAnimeGer.Location = new Point(BtnAnimeGer.Location.X, 154 + 20 + BtnAnimeList.Height);
            iframeFake.Size = new Size(formLargura - 215, formAltura - 29);

            if (formAltura > 640 & formLargura > 1184)
            {
                //Posição
                lblNumEps.Location = new Point((formLarguraA - lblNumEps.Width) / 2 - 40, (formAltura - lblNumEps.Height) / 2 - 140);
                txtNumEps.Location = new Point(lblNumEps.Location.X + lblNumEps.Width + 15, lblNumEps.Location.Y);


                lblEstudio.Location = new Point(lblNumEps.Location.X, lblNumEps.Location.Y - lblEstudio.Height - 20);
                txtEstudio.Location = new Point(txtNumEps.Location.X - (txtEstudio.Width - txtNumEps.Width), lblNumEps.Location.Y - lblEstudio.Height - 20);

                lblNome.Location = new Point(lblEstudio.Location.X, lblEstudio.Location.Y - 20 - lblNome.Height);
                txtNomeAnime.Location = new Point(txtEstudio.Location.X, lblNome.Location.Y);

                ptbFoto.Location = new Point(lblNome.Location.X - ptbFoto.Width - 20, lblNome.Location.Y);
                txtImagem.Location = new Point(ptbFoto.Location.X, ptbFoto.Location.Y + 15 + ptbFoto.Height);

                dtpData.Location = new Point(txtNumEps.Location.X, txtNumEps.Location.Y + 20 + txtNumEps.Height);
                lblDataLanc.Location = new Point(lblNumEps.Location.X, lblNumEps.Location.Y + 20 + txtNumEps.Height);

                lblSinopse.Location = new Point(lblDataLanc.Location.X, lblDataLanc.Location.Y + 20 + lblDataLanc.Height);
                txtSinopse.Location = new Point(txtNomeAnime.Location.X + txtNomeAnime.Width - txtSinopse.Width, lblSinopse.Location.Y);

                btnSalvar.Location = new Point(txtSinopse.Location.X + txtSinopse.Width - btnSalvar.Width, txtImagem.Location.Y + txtImagem.Height - btnSalvar.Height);
                btnLimpar.Location = new Point(btnSalvar.Location.X - 15 - btnLimpar.Width, btnSalvar.Location.Y);
                lblCadastro.Location = new Point(ptbFoto.Location.X + (txtNomeAnime.Location.X + txtNomeAnime.Width - ptbFoto.Location.X - lblCadastro.Width) / 2, txtNomeAnime.Location.Y - 40 - lblCadastro.Height);
            }

            if (formAltura <= 640 || formLargura <= 1184)
            {
                //Redefinindo o tamanho dos objetos
                lblCadastro.Font = new Font("Century Gothic", 18);
                txtNomeAnime.MinimumSize = new Size(507 * 1 / 2, 24);
                txtNomeAnime.Width = txtNomeAnime.Width * 1 / 2;

                txtNumEps.MinimumSize = new Size(380 * 1 / 2, 24);
                txtNumEps.Width = txtNumEps.Width * 1 / 2;

                txtEstudio.MinimumSize = new Size(507 * 1 / 2, 24);
                txtEstudio.Width = txtEstudio.Width * 1 / 2;

                txtNomeAnime.MinimumSize = new Size(507 * 1 / 2, 24);
                txtNomeAnime.Width = txtNomeAnime.Width * 1 / 2;

                txtNomeAnime.MinimumSize = new Size(507 * 1 / 2, 24);
                txtNomeAnime.Width = txtNomeAnime.Width * 1 / 2;

                lblNome.Font = new Font("Century Gothic", 11);
                lblEstudio.Font = new Font("Century Gothic", 11);
                lblNumEps.Font = new Font("Century Gothic", 11);
                lblDataLanc.Font = new Font("Century Gothic", 11);
                lblSinopse.Font = new Font("Century Gothic", 11);

                ptbFoto.Size = new Size(300 * 1 / 2, 420 * 1 / 2);
                ptbFoto.MaximumSize = new Size(300 * 1 / 2, 420 * 1 / 2);
                ptbFoto.MinimumSize = new Size(300 * 1 / 2, 420 * 1 / 2);

                txtImagem.Width = 300 * 1 / 2;

                dtpData.MinimumSize = new Size(380 * 1 / 2, 24);
                dtpData.Width = dtpData.Width * 1 / 2;

                txtSinopse.Size = new Size(506 / 2, 186 / 2);
                txtSinopse.MinimumSize = new Size(507 * 1 / 2, 186 * 1 / 2);

                btnSalvar.Size = new Size(btnSalvar.Width * 1 / 2, btnSalvar.Height * 1 / 2);

                //Fim

                //Redefinindo posições menores
                lblNumEps.Location = new Point((formLarguraA - lblNumEps.Width) / 2 - 20, (formAltura - lblNumEps.Height) / 2 - 70);
                txtNumEps.Location = new Point(lblNumEps.Location.X + lblNumEps.Width + 15, lblNumEps.Location.Y);



                lblEstudio.Location = new Point(lblNumEps.Location.X, lblNumEps.Location.Y - lblEstudio.Height - 20);
                txtEstudio.Location = new Point(txtNumEps.Location.X - (txtEstudio.Width - txtNumEps.Width), lblNumEps.Location.Y - lblEstudio.Height - 20);

                lblNome.Location = new Point(lblEstudio.Location.X, lblEstudio.Location.Y - 20 - lblNome.Height);
                txtNomeAnime.Location = new Point(txtEstudio.Location.X, lblNome.Location.Y);

                ptbFoto.Location = new Point(lblNome.Location.X - ptbFoto.Width - 20, lblNome.Location.Y);
                txtImagem.Location = new Point(ptbFoto.Location.X, ptbFoto.Location.Y + 15 + ptbFoto.Height);

                dtpData.Location = new Point(txtNumEps.Location.X, txtNumEps.Location.Y + 20 + txtNumEps.Height);
                lblDataLanc.Location = new Point(lblNumEps.Location.X, lblNumEps.Location.Y + 20 + txtNumEps.Height);

                lblSinopse.Location = new Point(lblDataLanc.Location.X, lblDataLanc.Location.Y + 20 + lblDataLanc.Height);
                txtSinopse.Location = new Point(txtNomeAnime.Location.X + txtNomeAnime.Width - txtSinopse.Width, lblSinopse.Location.Y);

                btnSalvar.Location = new Point(txtSinopse.Location.X + txtSinopse.Width - btnSalvar.Width, txtSinopse.Location.Y + txtSinopse.Height + 30);
                btnLimpar.Location = new Point(btnSalvar.Location.X - 15 - btnLimpar.Width, btnSalvar.Location.Y);
                lblCadastro.Location = new Point(ptbFoto.Location.X + (txtNomeAnime.Location.X + txtNomeAnime.Width - ptbFoto.Location.X - lblCadastro.Width) / 2, ptbFoto.Location.Y - lblCadastro.Height - 30);

            }
            else if (txtImagem.Width == 150 & (formAltura >= 640 || formLargura >= 1184))
            {
                //Redefinindo o tamanho dos objetos
                lblCadastro.Font = new Font("Century Gothic", 19);
                txtNomeAnime.MinimumSize = new Size(507, 24);
                txtNomeAnime.Width = txtNomeAnime.Width * 2;

                txtNumEps.MinimumSize = new Size(380, 24);
                txtNumEps.Width = txtNumEps.Width * 2;

                txtEstudio.MinimumSize = new Size(507, 24);
                txtEstudio.Width = txtEstudio.Width * 2;

                txtNomeAnime.MinimumSize = new Size(507, 24);
                txtNomeAnime.Width = txtNomeAnime.Width * 2;

                txtNomeAnime.MinimumSize = new Size(507, 24);
                txtNomeAnime.Width = txtNomeAnime.Width * 2;

                lblNome.Font = new Font("Century Gothic", 14);
                lblEstudio.Font = new Font("Century Gothic", 14);
                lblNumEps.Font = new Font("Century Gothic", 14);
                lblDataLanc.Font = new Font("Century Gothic", 14);
                lblSinopse.Font = new Font("Century Gothic", 14);

                ptbFoto.Size = new Size(300, 420);
                ptbFoto.MaximumSize = new Size(300, 420);
                ptbFoto.MinimumSize = new Size(300, 420);

                txtImagem.Width = 300;

                dtpData.MinimumSize = new Size(380, 24);
                dtpData.Width = dtpData.Width * 2;

                txtSinopse.Size = new Size(506, 186);
                txtSinopse.MinimumSize = new Size(507, 186);

                btnSalvar.Size = new Size(btnSalvar.Width * 2, btnSalvar.Height * 2);

                //Fim        

                //Posição
                lblNumEps.Location = new Point((formLarguraA - lblNumEps.Width) / 2 - 40, (formAltura - lblNumEps.Height) / 2 - 140);
                txtNumEps.Location = new Point(lblNumEps.Location.X + lblNumEps.Width + 15, lblNumEps.Location.Y);


                lblEstudio.Location = new Point(lblNumEps.Location.X, lblNumEps.Location.Y - lblEstudio.Height - 20);
                txtEstudio.Location = new Point(txtNumEps.Location.X - (txtEstudio.Width - txtNumEps.Width), lblNumEps.Location.Y - lblEstudio.Height - 20);

                lblNome.Location = new Point(lblEstudio.Location.X, lblEstudio.Location.Y - 20 - lblNome.Height);
                txtNomeAnime.Location = new Point(txtEstudio.Location.X, lblNome.Location.Y);

                ptbFoto.Location = new Point(lblNome.Location.X - ptbFoto.Width - 20, lblNome.Location.Y);
                txtImagem.Location = new Point(ptbFoto.Location.X, ptbFoto.Location.Y + 15 + ptbFoto.Height);

                dtpData.Location = new Point(txtNumEps.Location.X, txtNumEps.Location.Y + 20 + txtNumEps.Height);
                lblDataLanc.Location = new Point(lblNumEps.Location.X, lblNumEps.Location.Y + 20 + txtNumEps.Height);

                lblSinopse.Location = new Point(lblDataLanc.Location.X, lblDataLanc.Location.Y + 20 + lblDataLanc.Height);
                txtSinopse.Location = new Point(txtNomeAnime.Location.X + txtNomeAnime.Width - txtSinopse.Width, lblSinopse.Location.Y);

                lblCadastro.Location = new Point(ptbFoto.Location.X + (txtNomeAnime.Location.X + txtNomeAnime.Width - ptbFoto.Location.X - lblCadastro.Width) / 2, txtNomeAnime.Location.Y - 40 - lblCadastro.Height);
                btnSalvar.Location = new Point(txtSinopse.Location.X + txtSinopse.Width - btnSalvar.Width, txtImagem.Location.Y + txtImagem.Height - btnSalvar.Height);
                btnLimpar.Location = new Point(btnSalvar.Location.X - 15 - btnLimpar.Width, btnSalvar.Location.Y);
            }

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNomeAnime.Clear();
            txtEstudio.Clear();
            txtNumEps.Clear();
            txtSinopse.Clear();

            DateTime Date = new DateTime(2001, 01, 01);
            dtpData.Value = Date;

            ptbFoto.Image = null;
            txtImagem.Clear();
        }

        private void FrmGerenciador_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                FrmGerenciador.TabelaAdmin.Location = this.Location;
                FrmGerenciador.TabelaAdmin.Width = this.Width;
                FrmGerenciador.TabelaAdmin.Height = this.Height;
                FrmGerenciador.TabelaAdmin.StartPosition = FormStartPosition.Manual;
                FrmGerenciador.TabelaAdmin.FormClosing += delegate { this.Show(); };
                FrmGerenciador.TabelaAdmin.Show();
                FrmGerenciador.TabelaAdmin.AtualizaTabelaAdm();
                this.Hide();
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                FrmGerenciador.TabelaAdmin.Location = this.Location;
                FrmGerenciador.TabelaAdmin.StartPosition = FormStartPosition.Manual;
                FrmGerenciador.TabelaAdmin.WindowState = FormWindowState.Maximized;
                FrmGerenciador.TabelaAdmin.FormClosing += delegate { this.Show(); };
                FrmGerenciador.TabelaAdmin.Show();
                FrmGerenciador.TabelaAdmin.AtualizaTabelaAdm();
                this.Hide();
            }
        }
    }
}
