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
    public partial class FrmAnimeList : Form
    {

        private bool dragging = false;
        private Point startPoint = new Point(0, 0);

        private int contaShowAll = 0;

        private OpenFileDialog abrir = new OpenFileDialog();

        MySqlConnection conn = ConexaoBD.obterConexao();
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataAdapter da = new MySqlDataAdapter();
        DataTable dt = new DataTable();


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



        public FrmAnimeList()
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

        private void FrmAnimeList_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bancoanimesDataSet.tblanime'. Você pode movê-la ou removê-la conforme necessário.
            this.tblanimeTableAdapter.Fill(this.bancoanimesDataSet.tblanime);
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

        private void dtgAnimes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Anime anime = new Anime();
            animeDao animeDao = new animeDao();

            if (e.RowIndex >= 0 && dtgAnimes.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dtgAnimes.CurrentRow.Selected = true;
                txtPesquisar.Text = dtgAnimes.Rows[e.RowIndex].Cells["nomeAnimeDesign"].FormattedValue.ToString();
                anime.setNomeAnime(txtPesquisar.Text);
                anime = animeDao.selecionar(anime);
            }

            if (e.RowIndex < 0 || anime.getFotoAnime() == null)
            {
                ptbFoto.Image = null;
                ptbFoto.Visible = false;

                txtNomeAnime.Visible = false;

                lblEstudio.Visible = false;
                txtEstudio.Visible = false;

                lblNumEps.Visible = false;
                txtNumEps.Visible = false;

                lblDataLanc.Visible = false;
                txtDataLanc.Visible = false;

                lblSinopse.Visible = false;
                txtSinopse.Visible = false;

                btnEditar.Visible = false;
            }
            else
            {
                dtgAnimes.Visible = false;
                this.contaShowAll = 0;

                MemoryStream memory = new MemoryStream(anime.getFotoAnime()); // Guarda uma quantidade de bytes referente a uma variavel de armazenamento
                ptbFoto.Image = System.Drawing.Image.FromStream(memory); // Coloca na PictureBox a imagem que está dentro do objeto MemoryStream em formato binário
                ptbFoto.Visible = true;

                txtNomeAnime.Text = anime.getNomeAnime();
                txtEstudio.Text = anime.getEstudio();
                txtNumEps.Text = anime.getNumEps().ToString();
                txtDataLanc.Text = anime.getDataLanc();
                txtSinopse.Text = anime.getSinopse();
                dtpData.Value = anime.getDataPicker();

                txtNomeAnime.Visible = true;
                txtNomeAnime.BorderStyle = BorderStyle.None;

                lblEstudio.Visible = true;
                txtEstudio.Visible = true;

                lblNumEps.Visible = true;
                txtNumEps.Visible = true;

                lblDataLanc.Visible = true;
                txtDataLanc.Visible = true;

                lblSinopse.Visible = true;
                txtSinopse.Visible = true;

                btnEditar.Visible = true;
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            string query;

            try {
                query = "SELECT nomeAnime FROM tblAnime";

                cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = query;
                da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);

                dtgAnimes.DataSource = dt;
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

            this.dtgAnimes.Sort(this.dtgAnimes.Columns[0], ListSortDirection.Ascending);

            btnSalvar.Visible = false;
            btnEditar.Visible = false;
            btnExcluir.Visible = false;
            btnCancelar.Visible = false;
            ptbFoto.Visible = false;
            lblEstudio.Visible = false;
            lblNumEps.Visible = false;
            lblDataLanc.Visible = false;
            lblSinopse.Visible = false;
            txtNomeAnime.Visible = false;
            txtEstudio.Visible = false;
            txtNumEps.Visible = false;
            dtpData.Visible = false;
            txtSinopse.Visible = false;
            txtImagem.Visible = false;
            txtDataLanc.Visible = false;

            if (this.contaShowAll == 0)
            {
                dtgAnimes.Visible = true;
                this.contaShowAll = 1;
            }
            else if (this.contaShowAll == 1)
            {
                dtgAnimes.Visible = false;
                this.contaShowAll = 0;
            }

        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void FrmAnimeList_Resize(object sender, EventArgs e)
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
            if (FrmAnimeList.MousePosition.Y <= 1)
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
            if (FrmAnimeList.MousePosition.Y <= 1)
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
                FrmAnimeList.FormCadastroLogado.Location = this.Location;
                FrmAnimeList.FormCadastroLogado.Width = this.Width;
                FrmAnimeList.FormCadastroLogado.Height = this.Height;
                FrmAnimeList.FormCadastroLogado.StartPosition = FormStartPosition.Manual;
                FrmAnimeList.FormCadastroLogado.FormClosing += delegate { this.Show(); };
                FrmAnimeList.FormCadastroLogado.Show();
                this.Hide();
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                FrmAnimeList.FormCadastroLogado.Location = this.Location;
                FrmAnimeList.FormCadastroLogado.StartPosition = FormStartPosition.Manual;
                FrmAnimeList.FormCadastroLogado.WindowState = FormWindowState.Maximized;
                FrmAnimeList.FormCadastroLogado.FormClosing += delegate { this.Show(); };
                FrmAnimeList.FormCadastroLogado.Show();
                this.Hide();
            }
        }

        private void BtnAnimeGer_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                FrmAnimeList.FormGerenciador.Location = this.Location;
                FrmAnimeList.FormGerenciador.Width = this.Width;
                FrmAnimeList.FormGerenciador.Height = this.Height;
                FrmAnimeList.FormGerenciador.StartPosition = FormStartPosition.Manual;
                FrmAnimeList.FormGerenciador.FormClosing += delegate { this.Show(); };
                FrmAnimeList.FormGerenciador.Show();
                this.Hide();
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                FrmAnimeList.FormGerenciador.Location = this.Location;
                FrmAnimeList.FormGerenciador.StartPosition = FormStartPosition.Manual;
                FrmAnimeList.FormGerenciador.WindowState = FormWindowState.Maximized;
                FrmAnimeList.FormGerenciador.FormClosing += delegate { this.Show(); };
                FrmAnimeList.FormGerenciador.Show();
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Anime anime = new Anime();
            animeDao animeDao = new animeDao();

            if (txtPesquisar.Text.Length >= 3 && String.IsNullOrWhiteSpace(txtPesquisar.Text) == false)
            {
                anime.setNomeAnime(txtPesquisar.Text);

                using (var cmd = new MySqlCommand("SELECT count(nomeAnime) FROM tblAnime WHERE nomeAnime like '%" + anime.getNomeAnime() + "%';", conn))
                {
                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    string query;

                    if (count > 1)
                    {
                        query = "SELECT nomeAnime FROM tblAnime where nomeAnime like '%" + anime.getNomeAnime() + "%';";

                        cmd.Connection = conn;
                        cmd.CommandText = query;
                        da = new MySqlDataAdapter();
                        da.SelectCommand = cmd;
                        dt = new DataTable();
                        da.Fill(dt);

                        dtgAnimes.DataSource = dt;
                        dtgAnimes.Visible = true;

                        this.contaShowAll = 0;

                        btnSalvar.Visible = false;
                        btnEditar.Visible = false;
                        btnExcluir.Visible = false;
                        btnCancelar.Visible = false;
                        ptbFoto.Visible = false;
                        lblEstudio.Visible = false;
                        lblNumEps.Visible = false;
                        lblDataLanc.Visible = false;
                        lblSinopse.Visible = false;
                        txtNomeAnime.Visible = false;
                        txtEstudio.Visible = false;
                        txtNumEps.Visible = false;
                        dtpData.Visible = false;
                        txtSinopse.Visible = false;
                        txtImagem.Visible = false;
                        txtDataLanc.Visible = false;

                        this.dtgAnimes.Sort(this.dtgAnimes.Columns[0], ListSortDirection.Ascending);
                    }
                    else
                    {
                        anime = animeDao.selecionar(anime);

                        if (anime.getFotoAnime() == null && ptbFoto.Visible == true)
                        {

                        }
                        else if (anime.getFotoAnime() == null)
                        {
                            ptbFoto.Image = null;
                            ptbFoto.Visible = false;

                            txtNomeAnime.Visible = false;

                            lblEstudio.Visible = false;
                            txtEstudio.Visible = false;

                            lblNumEps.Visible = false;
                            txtNumEps.Visible = false;

                            lblDataLanc.Visible = false;
                            txtDataLanc.Visible = false;

                            lblSinopse.Visible = false;
                            txtSinopse.Visible = false;

                            btnEditar.Visible = false;
                        }
                        else
                        {
                            dtgAnimes.Visible = false;
                            this.contaShowAll = 0;

                            MemoryStream memory = new MemoryStream(anime.getFotoAnime()); // Guarda uma quantidade de bytes referente a uma variavel de armazenamento
                            ptbFoto.Image = System.Drawing.Image.FromStream(memory); // Coloca na PictureBox a imagem que está dentro do objeto MemoryStream em formato binário
                            ptbFoto.Visible = true;

                            txtNomeAnime.Text = anime.getNomeAnime();
                            txtEstudio.Text = anime.getEstudio();
                            txtNumEps.Text = anime.getNumEps().ToString();
                            txtDataLanc.Text = anime.getDataLanc();
                            txtSinopse.Text = anime.getSinopse();
                            dtpData.Value = anime.getDataPicker();

                            txtNomeAnime.Visible = true;
                            txtNomeAnime.BorderStyle = BorderStyle.None;

                            lblEstudio.Visible = true;
                            txtEstudio.Visible = true;

                            lblNumEps.Visible = true;
                            txtNumEps.Visible = true;

                            lblDataLanc.Visible = true;
                            txtDataLanc.Visible = true;

                            lblSinopse.Visible = true;
                            txtSinopse.Visible = true;

                            btnEditar.Visible = true;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("insira um anime!");
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

            txtPesquisar.Location = new Point((formLarguraA - txtPesquisar.Width) / 2, txtPesquisar.Location.Y);
            txtPesquisar.Size = new Size((dtgAnimes.Width), txtPesquisar.Height);
            btnShowAll.Location = new Point(txtPesquisar.Location.X, btnShowAll.Location.Y);
            dtgAnimes.Location = new Point(txtPesquisar.Location.X, dtgAnimes.Location.Y);
            dtgAnimes.Size = new Size(dtgAnimes.Width, dtgAnimes.Height);

            btnBuscar.Location = new Point(btnShowAll.Location.X + btnShowAll.Width + 25, btnShowAll.Location.Y);

            //Largura: 1180 Altura: 666
            ptbFoto.Location = new Point(btnShowAll.Location.X, btnShowAll.Location.Y + btnShowAll.Height + 20);
            txtImagem.Location = new Point(ptbFoto.Location.X, ptbFoto.Location.Y + ptbFoto.Height + 10);

            txtNomeAnime.Location = new Point(ptbFoto.Location.X + ptbFoto.Width + 30, ptbFoto.Location.Y);
            lblEstudio.Location = new Point(txtNomeAnime.Location.X, txtNomeAnime.Location.Y + txtNomeAnime.Height + 15);
            txtEstudio.Location = new Point(txtNomeAnime.Location.X + txtNomeAnime.Width - txtEstudio.Width, lblEstudio.Location.Y - 2);

            lblNumEps.Location = new Point(lblEstudio.Location.X, lblEstudio.Location.Y + txtEstudio.Height + 15);
            txtNumEps.Location = new Point(txtEstudio.Location.X + txtEstudio.Width - txtNumEps.Width, lblNumEps.Location.Y - 4);

            lblDataLanc.Location = new Point(lblNumEps.Location.X, lblNumEps.Location.Y + txtNumEps.Height + 15);
            dtpData.Location = new Point(txtNumEps.Location.X + txtNumEps.Width - dtpData.Width, lblDataLanc.Location.Y - 4);
            txtDataLanc.Location = new Point(txtNumEps.Location.X + txtNumEps.Width - dtpData.Width, lblDataLanc.Location.Y - 4);

            lblSinopse.Location = new Point(lblDataLanc.Location.X, lblDataLanc.Location.Y + dtpData.Height + 15);
            txtSinopse.Location = new Point(lblSinopse.Location.X, lblSinopse.Location.Y + lblSinopse.Height + 15);

            if (formLargura <= 1180 || formAltura <= 666)
            {
                txtPesquisar.Size = new Size(917 * 3 / 5 + 10, 25);
                txtPesquisar.MinimumSize = new Size(917 * 3 / 5 + 10, 25);
                txtPesquisar.MaximumSize = new Size(917 * 3 / 5 + 10, 25);
                dtgAnimes.MaximumSize = new Size(917 * 3 / 5, 437 - 30);
                dtgAnimes.MinimumSize = new Size(917 * 3 / 5, 437 - 30);
                dtgAnimes.Size = new Size(917 * 3 / 5, 437 - 30);

                ptbFoto.Size = new Size(285 / 2, 380 / 2);
                txtNomeAnime.Width = txtPesquisar.Location.X + txtPesquisar.Width - txtNomeAnime.Location.X;
                txtEstudio.Width = 536 / 2;
                txtNumEps.Width = 428 / 2;
                dtpData.Width = 434 / 2;
                txtDataLanc.Width = 434 / 2;
                txtSinopse.Width = txtNomeAnime.Width;
                txtImagem.Width = 285 / 2;

                btnExcluir.Size = new Size(btnExcluir.Height, 30);
                btnSalvar.Size = new Size(btnExcluir.Height, 30);
                btnCancelar.Size = new Size(btnExcluir.Height, 30);
                btnEditar.Size = new Size(btnExcluir.Height, 30);

                txtCancelar.Location = new Point(txtImagem.Location.X, txtImagem.Location.Y + 30);
                txtCancelar.Width = txtImagem.Width;

                btnCancelar.Location = new Point(txtSinopse.Location.X + txtSinopse.Width - btnCancelar.Width, txtSinopse.Location.Y + txtSinopse.Height + 15);
                btnEditar.Location = new Point(txtSinopse.Location.X + txtSinopse.Width - btnCancelar.Width, txtSinopse.Location.Y + txtSinopse.Height + 15);
                btnSalvar.Location = new Point(btnCancelar.Location.X - 10 - btnSalvar.Width, btnCancelar.Location.Y);
                btnExcluir.Location = new Point(btnSalvar.Location.X - 10 - btnExcluir.Width, btnSalvar.Location.Y);
            }
            else if (formLargura > 1180 || formAltura > 666)
            {
                txtPesquisar.Size = new Size(917, 25);
                txtPesquisar.MinimumSize = new Size(917, 25);
                txtPesquisar.MaximumSize = new Size(917, 25);
                dtgAnimes.MaximumSize = new Size(917, 437);
                dtgAnimes.MinimumSize = new Size(917, 437);
                dtgAnimes.Size = new Size(917 * 3 / 5, 437);

                ptbFoto.Size = new Size(285, 380);
                txtNomeAnime.Width = 602;
                txtEstudio.Width = 536;
                txtNumEps.Width = 428;
                dtpData.Width = 434;
                txtDataLanc.Width = 434;
                txtSinopse.Width = 602;
                txtImagem.Width = 285;

                btnExcluir.MinimumSize = new Size(90, 30);
                btnSalvar.MinimumSize = new Size(90, 30);
                btnCancelar.MinimumSize = new Size(90, 30);
                btnEditar.MinimumSize = new Size(90, 30);
                btnExcluir.Size = new Size(btnExcluir.Height, 30);
                btnSalvar.Size = new Size(btnSalvar.Height, 30);
                btnCancelar.Size = new Size(btnCancelar.Height, 30);
                btnEditar.Size = new Size(btnCancelar.Height, 30);

                txtCancelar.Location = new Point(txtSinopse.Location.X, txtSinopse.Location.Y + txtSinopse.Height + 15);
                txtCancelar.Width = 160;

                btnCancelar.Location = new Point(txtSinopse.Location.X + txtSinopse.Width - btnCancelar.Width, txtImagem.Location.Y + txtImagem.Height - btnCancelar.Height);
                btnEditar.Location = new Point(txtSinopse.Location.X + txtSinopse.Width - btnCancelar.Width, txtImagem.Location.Y + txtImagem.Height - btnCancelar.Height);
                btnSalvar.Location = new Point(btnCancelar.Location.X - 10 - btnSalvar.Width, btnCancelar.Location.Y);
                btnExcluir.Location = new Point(btnSalvar.Location.X - 10 - btnExcluir.Width, btnSalvar.Location.Y);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtPesquisar.Visible = true;
            btnBuscar.Visible = true;
            btnShowAll.Visible = true;

            Anime anime = new Anime();
            animeDao animeDao = new animeDao();

            anime.setNomeAnime(txtCancelar.Text);

            anime = animeDao.selecionar(anime);

            if (anime.getFotoAnime() == null)
            {
                ptbFoto.Image = null;
            }
            else
            {
                MemoryStream memory = new MemoryStream(anime.getFotoAnime()); // Guarda uma quantidade de bytes referente a uma variavel de armazenamento
                ptbFoto.Image = System.Drawing.Image.FromStream(memory); // Coloca na PictureBox a imagem que está dentro do objeto MemoryStream em formato binário
                ptbFoto.Visible = true;

                txtNomeAnime.Text = anime.getNomeAnime();
                txtEstudio.Text = anime.getEstudio();
                txtNumEps.Text = anime.getNumEps().ToString();
                txtDataLanc.Text = anime.getDataLanc();
                txtSinopse.Text = anime.getSinopse();
                dtpData.Value = anime.getDataPicker();

                txtNomeAnime.ReadOnly = true;
                txtNomeAnime.BackColor = Color.FromArgb(62, 66, 73);
                txtNomeAnime.ForeColor = Color.WhiteSmoke;
                txtNomeAnime.BorderStyle = BorderStyle.None;

                txtEstudio.ReadOnly = true;
                txtEstudio.BackColor = Color.FromArgb(62, 66, 73);
                txtEstudio.ForeColor = Color.WhiteSmoke;

                txtNumEps.ReadOnly = true;
                txtNumEps.BackColor = Color.FromArgb(62, 66, 73);
                txtNumEps.ForeColor = Color.WhiteSmoke;

                txtDataLanc.Visible = true;

                dtpData.Visible = false;

                txtSinopse.ReadOnly = true;
                txtSinopse.BackColor = Color.FromArgb(62, 66, 73);
                txtSinopse.ForeColor = Color.WhiteSmoke;

                ptbFoto.Enabled = false;
                ptbFoto.Cursor = Cursors.Default;
                ptbFoto.BackColor = Color.FromArgb(62, 66, 73);

                txtImagem.Clear();
                txtImagem.Visible = false;

                btnEditar.Visible = true;
                btnCancelar.Visible = false;
                btnSalvar.Visible = false;
                btnExcluir.Visible = false;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            txtCancelar.Text = txtNomeAnime.Text;

            txtPesquisar.Visible = false;
            txtPesquisar.Clear();
            btnBuscar.Visible = false;
            btnShowAll.Visible = false;


            txtNomeAnime.ReadOnly = false;
            txtNomeAnime.BackColor = Color.White;
            txtNomeAnime.ForeColor = Color.Black;
            txtNomeAnime.BorderStyle = BorderStyle.FixedSingle;

            txtEstudio.ReadOnly = false;
            txtEstudio.BackColor = Color.White;
            txtEstudio.ForeColor = Color.Black;
            txtEstudio.BorderStyle = BorderStyle.FixedSingle;

            txtNumEps.ReadOnly = false;
            txtNumEps.BackColor = Color.White;
            txtNumEps.ForeColor = Color.Black;
            txtNumEps.BorderStyle = BorderStyle.FixedSingle;

            txtDataLanc.Visible = false;

            dtpData.Visible = true;

            txtSinopse.ReadOnly = false;
            txtSinopse.BackColor = Color.White;
            txtSinopse.ForeColor = Color.Black;
            txtSinopse.BorderStyle = BorderStyle.FixedSingle;

            ptbFoto.Enabled = true;
            ptbFoto.Cursor = Cursors.Hand;
            ptbFoto.BackColor = Color.FromArgb(190, 200, 222);

            txtImagem.Visible = true;

            btnEditar.Visible = false;
            btnCancelar.Visible = true;
            btnSalvar.Visible = true;
            btnExcluir.Visible = true;
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

            anime.setNomeAnime(txtCancelar.Text);
            anime = animeDao.selectId(anime);


            if (txtImagem.Text != "")
            {
                byte[] fotoAnime = null;
                FileStream file = new FileStream(this.txtImagem.Text, FileMode.Open, FileAccess.Read);
                BinaryReader reader = new BinaryReader(file);
                fotoAnime = reader.ReadBytes((int)file.Length);
                anime.setFotoAnime(fotoAnime);
            }
            else
            {
                anime = animeDao.selectFotoAnime(anime);
            }

            anime.setNomeAnime(txtNomeAnime.Text);
            anime.setEstudio(txtEstudio.Text);
            anime.setNumEps(int.Parse(txtNumEps.Text)); //Convertido para inteiro
            anime.setDataLanc(dtpData.Text);
            anime.setSinopse(txtSinopse.Text);

            animeDao.salvar(anime);

            txtCancelar.Text = anime.getNomeAnime();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Anime anime = new Anime();
            animeDao animeDao = new animeDao();

            anime.setNomeAnime(txtCancelar.Text);


            DialogResult dialogResult = MessageBox.Show("Tem certeza que deseja excluir o anime: " + anime.getNomeAnime(), "", MessageBoxButtons.YesNo); ;
            if (dialogResult == DialogResult.Yes)
            {
                anime = animeDao.selectId(anime);
                animeDao.excluir(anime);

                txtPesquisar.Visible = true;
                btnBuscar.Visible = true;
                btnShowAll.Visible = true;

                txtCancelar.Clear();

                txtNomeAnime.Visible = false;
                txtNomeAnime.ReadOnly = true;
                txtNomeAnime.BackColor = Color.FromArgb(62, 66, 73);
                txtNomeAnime.ForeColor = Color.WhiteSmoke;
                txtNomeAnime.BorderStyle = BorderStyle.None;

                lblEstudio.Visible = false;
                txtEstudio.Visible = false;
                txtEstudio.ReadOnly = true;
                txtEstudio.BackColor = Color.FromArgb(62, 66, 73);
                txtEstudio.ForeColor = Color.WhiteSmoke;
                txtEstudio.BorderStyle = BorderStyle.None;

                lblNumEps.Visible = false;
                txtNumEps.Visible = false;
                txtNumEps.ReadOnly = true;
                txtNumEps.BackColor = Color.FromArgb(62, 66, 73);
                txtNumEps.ForeColor = Color.WhiteSmoke;
                txtNumEps.BorderStyle = BorderStyle.None;

                dtpData.Visible = false;
                lblDataLanc.Visible = false;
                txtDataLanc.Visible = false;

                lblSinopse.Visible = false;
                txtSinopse.Visible = false;
                txtSinopse.ReadOnly = true;
                txtSinopse.BackColor = Color.FromArgb(62, 66, 73);
                txtSinopse.ForeColor = Color.WhiteSmoke;
                txtSinopse.BorderStyle = BorderStyle.None;

                ptbFoto.Visible = false;
                ptbFoto.Enabled = false;
                ptbFoto.Cursor = Cursors.Default;
                ptbFoto.BackColor = Color.FromArgb(62, 66, 73);

                txtImagem.Clear();
                txtImagem.Visible = false;

                btnEditar.Visible = false;
                btnCancelar.Visible = false;
                btnSalvar.Visible = false;
                btnExcluir.Visible = false;
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void FrmAnimeList_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FrmAnimeList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnBuscar.PerformClick();
            }

        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                FrmAnimeList.TabelaAdmin.Location = this.Location;
                FrmAnimeList.TabelaAdmin.Width = this.Width;
                FrmAnimeList.TabelaAdmin.Height = this.Height;
                FrmAnimeList.TabelaAdmin.StartPosition = FormStartPosition.Manual;
                FrmAnimeList.TabelaAdmin.FormClosing += delegate { this.Show(); };
                FrmAnimeList.TabelaAdmin.Show();
                FrmAnimeList.TabelaAdmin.AtualizaTabelaAdm();
                this.Hide();
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                FrmAnimeList.TabelaAdmin.Location = this.Location;
                FrmAnimeList.TabelaAdmin.StartPosition = FormStartPosition.Manual;
                FrmAnimeList.TabelaAdmin.WindowState = FormWindowState.Maximized;
                FrmAnimeList.TabelaAdmin.FormClosing += delegate { this.Show(); };
                FrmAnimeList.TabelaAdmin.Show();
                FrmAnimeList.TabelaAdmin.AtualizaTabelaAdm();
                this.Hide();
            }
        }

        public void AtualizaTabelaAnime()
        {
            string query;

            try
            {
                query = "SELECT nomeAnime FROM tblAnime";

                cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = query;
                da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);

                dtgAnimes.DataSource = dt;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.dtgAnimes.Sort(this.dtgAnimes.Columns[0], ListSortDirection.Ascending);
        }
    }
}
