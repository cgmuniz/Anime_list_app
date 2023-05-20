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
    public partial class TblAdmin : Form
    {

        private bool dragging = false;
        private Point startPoint = new Point(0, 0);

        private OpenFileDialog abrir = new OpenFileDialog();

        MySqlConnection conn = ConexaoBD.obterConexao();
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataAdapter da = new MySqlDataAdapter();
        DataTable dt = new DataTable();


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


        public TblAdmin()
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

        private void TblAdmin_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bancoanimesDataSet1.tbladmin'. Você pode movê-la ou removê-la conforme necessário.
            this.tbladminTableAdapter.Fill(this.bancoanimesDataSet1.tbladmin);
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

        private void dtgAdmin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            int Linha = dtgAdmin.CurrentRow.Index;

            String Nome = dtgAdmin.Rows[Linha].Cells[0].Value.ToString();

            FormVerificaSenha formSenha = new FormVerificaSenha();

            formSenha.puxaNome = Nome;

            formSenha.Show();
        }


        private void TblAdmin_Resize(object sender, EventArgs e)
        {
            ResizeConfig();
            ResizeConfig();
        }

        private void BtnAnimeList_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                TblAdmin.FormAnimeList.Location = this.Location;
                TblAdmin.FormAnimeList.Width = this.Width;
                TblAdmin.FormAnimeList.Height = this.Height;
                TblAdmin.FormAnimeList.StartPosition = FormStartPosition.Manual;
                TblAdmin.FormAnimeList.FormClosing += delegate { this.Show(); };
                TblAdmin.FormAnimeList.Show();
                this.Hide();
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                TblAdmin.FormAnimeList.Location = this.Location;
                TblAdmin.FormAnimeList.StartPosition = FormStartPosition.Manual;
                TblAdmin.FormAnimeList.WindowState = FormWindowState.Maximized;
                TblAdmin.FormAnimeList.FormClosing += delegate { this.Show(); };
                TblAdmin.FormAnimeList.Show();
                this.Hide();
            }
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
                TblAdmin.FormCadastroLogado.Location = this.Location;
                TblAdmin.FormCadastroLogado.Width = this.Width;
                TblAdmin.FormCadastroLogado.Height = this.Height;
                TblAdmin.FormCadastroLogado.StartPosition = FormStartPosition.Manual;
                TblAdmin.FormCadastroLogado.FormClosing += delegate { this.Show(); };
                TblAdmin.FormCadastroLogado.Show();
                this.Hide();
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                TblAdmin.FormCadastroLogado.Location = this.Location;
                TblAdmin.FormCadastroLogado.StartPosition = FormStartPosition.Manual;
                TblAdmin.FormCadastroLogado.WindowState = FormWindowState.Maximized;
                TblAdmin.FormCadastroLogado.FormClosing += delegate { this.Show(); };
                TblAdmin.FormCadastroLogado.Show();
                this.Hide();
            }
        }

        private void BtnAnimeGer_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                TblAdmin.FormGerenciador.Location = this.Location;
                TblAdmin.FormGerenciador.Width = this.Width;
                TblAdmin.FormGerenciador.Height = this.Height;
                TblAdmin.FormGerenciador.StartPosition = FormStartPosition.Manual;
                TblAdmin.FormGerenciador.FormClosing += delegate { this.Show(); };
                TblAdmin.FormGerenciador.Show();
                this.Hide();
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                TblAdmin.FormGerenciador.Location = this.Location;
                TblAdmin.FormGerenciador.StartPosition = FormStartPosition.Manual;
                TblAdmin.FormGerenciador.WindowState = FormWindowState.Maximized;
                TblAdmin.FormGerenciador.FormClosing += delegate { this.Show(); };
                TblAdmin.FormGerenciador.Show();
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

        public void ResizeConfig()
        {
            int formAltura = this.Height;
            int formLargura = this.Width;
            int formAlturaA = iframeFake.Height;
            int formLarguraA = iframeFake.Width;

            iframeFake.Size = new Size(formLarguraA, formAlturaA);

            int formCentroA = (formAltura - panel6.Height) / 2;
            int formCentroL = (formLargura - panel1.Width) / 2;

            panel1.Size = new Size(215, formAltura);
            BtnAnimeList.Location = new Point(BtnAnimeList.Location.X, 154 + 10);
            BtnAnimeGer.Location = new Point(BtnAnimeGer.Location.X, 154 + 20 + BtnAnimeList.Height);
            iframeFake.Size = new Size(formLargura - 215, formAltura - 29);

            dtgAdmin.Size = new Size(dtgAdmin.Width, dtgAdmin.Height);


            dtgAdmin.Location = new Point(((formLargura - panel1.Width - 20 - dtgAdmin.Width) / 2), (formCentroA - (dtgAdmin.Height/2))/2);
            btnApagar.Location = new Point(((formLargura - panel1.Width - 20 - dtgAdmin.Width) / 2), ((formCentroA - (dtgAdmin.Height / 2)) / 2) + 30 + dtgAdmin.Height);
            btnAtualizaTabela.Location = new Point((((formLargura - panel1.Width - 20 - dtgAdmin.Width) / 2) + btnApagar.Width + 50), ((formCentroA - (dtgAdmin.Height / 2)) / 2) + 30 + dtgAdmin.Height);

            //Largura: 1180 Altura: 666

        }

        private void TblAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        public void AtualizaTabelaAdm()
        {
            string query;

            try
            {
                query = "SELECT nomeAdmin, emailAdmin FROM tblAdmin";

                cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = query;
                da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);

                dtgAdmin.DataSource = dt;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            this.dtgAdmin.Sort(this.dtgAdmin.Columns[0], ListSortDirection.Ascending);
        }

        private void btnAtualizaTabela_Click(object sender, EventArgs e)
        {
            AtualizaTabelaAdm();
        }
    }
}
