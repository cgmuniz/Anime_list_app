
namespace HamimiProofei
{
    partial class FrmAnimeList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnimeList));
            this.btnShowAll = new System.Windows.Forms.Button();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.dtgAnimes = new System.Windows.Forms.DataGridView();
            this.nomeAnimeDesign = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblanimeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bancoanimesDataSet = new HamimiProofei.bancoanimesDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.BtnAnimeGer = new System.Windows.Forms.Button();
            this.BtnAnimeList = new System.Windows.Forms.Button();
            this.btnMini = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.iframeFake = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtCancelar = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.ptbFoto = new System.Windows.Forms.PictureBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtNomeAnime = new System.Windows.Forms.TextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.lblSinopse = new System.Windows.Forms.Label();
            this.txtImagem = new System.Windows.Forms.TextBox();
            this.txtSinopse = new System.Windows.Forms.TextBox();
            this.txtDataLanc = new System.Windows.Forms.TextBox();
            this.lblNumEps = new System.Windows.Forms.Label();
            this.lblEstudio = new System.Windows.Forms.Label();
            this.lblDataLanc = new System.Windows.Forms.Label();
            this.txtEstudio = new System.Windows.Forms.TextBox();
            this.txtNumEps = new System.Windows.Forms.TextBox();
            this.tblanimeTableAdapter = new HamimiProofei.bancoanimesDataSetTableAdapters.tblanimeTableAdapter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.BtnCadastro = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAnimes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblanimeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoanimesDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.iframeFake.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFoto)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnShowAll
            // 
            this.btnShowAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowAll.BackColor = System.Drawing.SystemColors.Control;
            this.btnShowAll.FlatAppearance.BorderSize = 0;
            this.btnShowAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(200)))), ((int)(((byte)(222)))));
            this.btnShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAll.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.btnShowAll.ForeColor = System.Drawing.Color.Black;
            this.btnShowAll.Location = new System.Drawing.Point(120, 100);
            this.btnShowAll.MaximumSize = new System.Drawing.Size(102, 31);
            this.btnShowAll.MinimumSize = new System.Drawing.Size(102, 31);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(102, 31);
            this.btnShowAll.TabIndex = 19;
            this.btnShowAll.Text = "Exibir Todos";
            this.btnShowAll.UseVisualStyleBackColor = false;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPesquisar.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.txtPesquisar.Location = new System.Drawing.Point(109, 58);
            this.txtPesquisar.MaximumSize = new System.Drawing.Size(1100, 25);
            this.txtPesquisar.MinimumSize = new System.Drawing.Size(500, 25);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(853, 25);
            this.txtPesquisar.TabIndex = 18;
            this.txtPesquisar.TextChanged += new System.EventHandler(this.txtPesquisar_TextChanged);
            // 
            // dtgAnimes
            // 
            this.dtgAnimes.AllowUserToAddRows = false;
            this.dtgAnimes.AllowUserToDeleteRows = false;
            this.dtgAnimes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgAnimes.AutoGenerateColumns = false;
            this.dtgAnimes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAnimes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeAnimeDesign});
            this.dtgAnimes.DataSource = this.tblanimeBindingSource;
            this.dtgAnimes.Location = new System.Drawing.Point(109, 155);
            this.dtgAnimes.MaximumSize = new System.Drawing.Size(1100, 500);
            this.dtgAnimes.MinimumSize = new System.Drawing.Size(620, 437);
            this.dtgAnimes.Name = "dtgAnimes";
            this.dtgAnimes.ReadOnly = true;
            this.dtgAnimes.RowHeadersVisible = false;
            this.dtgAnimes.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgAnimes.Size = new System.Drawing.Size(853, 437);
            this.dtgAnimes.TabIndex = 20;
            this.dtgAnimes.Visible = false;
            this.dtgAnimes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgAnimes_CellClick);
            // 
            // nomeAnimeDesign
            // 
            this.nomeAnimeDesign.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomeAnimeDesign.DataPropertyName = "nomeAnime";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.nomeAnimeDesign.DefaultCellStyle = dataGridViewCellStyle3;
            this.nomeAnimeDesign.HeaderText = "Nome Anime";
            this.nomeAnimeDesign.MinimumWidth = 500;
            this.nomeAnimeDesign.Name = "nomeAnimeDesign";
            this.nomeAnimeDesign.ReadOnly = true;
            this.nomeAnimeDesign.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.nomeAnimeDesign.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // tblanimeBindingSource
            // 
            this.tblanimeBindingSource.DataMember = "tblanime";
            this.tblanimeBindingSource.DataSource = this.bancoanimesDataSet;
            // 
            // bancoanimesDataSet
            // 
            this.bancoanimesDataSet.DataSetName = "bancoanimesDataSet";
            this.bancoanimesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(27)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.BtnAnimeGer);
            this.panel1.Controls.Add(this.BtnAnimeList);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 718);
            this.panel1.TabIndex = 21;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(215, 154);
            this.panel3.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(206, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(215, 29);
            this.panel7.TabIndex = 1;
            this.panel7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel7_MouseDown);
            this.panel7.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel7_MouseMove);
            this.panel7.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel7_MouseUp);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(200)))), ((int)(((byte)(222)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 152);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(215, 2);
            this.panel4.TabIndex = 0;
            // 
            // BtnAnimeGer
            // 
            this.BtnAnimeGer.FlatAppearance.BorderSize = 0;
            this.BtnAnimeGer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(27)))));
            this.BtnAnimeGer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(200)))), ((int)(((byte)(222)))));
            this.BtnAnimeGer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAnimeGer.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.BtnAnimeGer.Location = new System.Drawing.Point(3, 362);
            this.BtnAnimeGer.Name = "BtnAnimeGer";
            this.BtnAnimeGer.Size = new System.Drawing.Size(209, 81);
            this.BtnAnimeGer.TabIndex = 4;
            this.BtnAnimeGer.Text = "Cadastro Anime";
            this.BtnAnimeGer.UseVisualStyleBackColor = true;
            this.BtnAnimeGer.Click += new System.EventHandler(this.BtnAnimeGer_Click);
            this.BtnAnimeGer.MouseEnter += new System.EventHandler(this.BtnAnimeGer_MouseEnter);
            this.BtnAnimeGer.MouseLeave += new System.EventHandler(this.BtnAnimeGer_MouseLeave);
            // 
            // BtnAnimeList
            // 
            this.BtnAnimeList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.BtnAnimeList.FlatAppearance.BorderSize = 0;
            this.BtnAnimeList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(200)))), ((int)(((byte)(222)))));
            this.BtnAnimeList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAnimeList.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.BtnAnimeList.ForeColor = System.Drawing.Color.Black;
            this.BtnAnimeList.Location = new System.Drawing.Point(3, 250);
            this.BtnAnimeList.Name = "BtnAnimeList";
            this.BtnAnimeList.Size = new System.Drawing.Size(209, 81);
            this.BtnAnimeList.TabIndex = 3;
            this.BtnAnimeList.Text = "Anime List";
            this.BtnAnimeList.UseVisualStyleBackColor = false;
            this.BtnAnimeList.MouseEnter += new System.EventHandler(this.BtnAnimeList_MouseEnter);
            this.BtnAnimeList.MouseLeave += new System.EventHandler(this.BtnAnimeList_MouseLeave);
            // 
            // btnMini
            // 
            this.btnMini.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMini.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMini.FlatAppearance.BorderSize = 0;
            this.btnMini.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(112)))), ((int)(((byte)(122)))));
            this.btnMini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMini.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMini.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(200)))), ((int)(((byte)(222)))));
            this.btnMini.Location = new System.Drawing.Point(1160, 0);
            this.btnMini.Name = "btnMini";
            this.btnMini.Size = new System.Drawing.Size(40, 30);
            this.btnMini.TabIndex = 26;
            this.btnMini.Text = "—";
            this.btnMini.UseVisualStyleBackColor = true;
            this.btnMini.Click += new System.EventHandler(this.btnMini_Click);
            // 
            // btnMax
            // 
            this.btnMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(112)))), ((int)(((byte)(122)))));
            this.btnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(200)))), ((int)(((byte)(222)))));
            this.btnMax.Image = ((System.Drawing.Image)(resources.GetObject("btnMax.Image")));
            this.btnMax.Location = new System.Drawing.Point(1200, 0);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(40, 30);
            this.btnMax.TabIndex = 27;
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(200)))), ((int)(((byte)(222)))));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1240, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 30);
            this.btnClose.TabIndex = 25;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(66)))), ((int)(((byte)(73)))));
            this.panel6.ForeColor = System.Drawing.Color.Black;
            this.panel6.Location = new System.Drawing.Point(215, 1);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1065, 29);
            this.panel6.TabIndex = 24;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            this.panel6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel6_MouseDown);
            this.panel6.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel6_MouseMove);
            this.panel6.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel6_MouseUp);
            // 
            // iframeFake
            // 
            this.iframeFake.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iframeFake.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(66)))), ((int)(((byte)(73)))));
            this.iframeFake.Controls.Add(this.btnBuscar);
            this.iframeFake.Controls.Add(this.txtCancelar);
            this.iframeFake.Controls.Add(this.btnCancelar);
            this.iframeFake.Controls.Add(this.dtpData);
            this.iframeFake.Controls.Add(this.btnExcluir);
            this.iframeFake.Controls.Add(this.ptbFoto);
            this.iframeFake.Controls.Add(this.btnSalvar);
            this.iframeFake.Controls.Add(this.txtNomeAnime);
            this.iframeFake.Controls.Add(this.btnEditar);
            this.iframeFake.Controls.Add(this.lblSinopse);
            this.iframeFake.Controls.Add(this.txtImagem);
            this.iframeFake.Controls.Add(this.txtSinopse);
            this.iframeFake.Controls.Add(this.txtDataLanc);
            this.iframeFake.Controls.Add(this.lblNumEps);
            this.iframeFake.Controls.Add(this.lblEstudio);
            this.iframeFake.Controls.Add(this.lblDataLanc);
            this.iframeFake.Controls.Add(this.txtEstudio);
            this.iframeFake.Controls.Add(this.txtNumEps);
            this.iframeFake.Controls.Add(this.txtPesquisar);
            this.iframeFake.Controls.Add(this.btnShowAll);
            this.iframeFake.Controls.Add(this.dtgAnimes);
            this.iframeFake.Location = new System.Drawing.Point(215, 28);
            this.iframeFake.Name = "iframeFake";
            this.iframeFake.Size = new System.Drawing.Size(1065, 670);
            this.iframeFake.TabIndex = 28;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscar.BackColor = System.Drawing.SystemColors.Control;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(15)))), ((int)(((byte)(17)))));
            this.btnBuscar.Location = new System.Drawing.Point(240, 102);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(15, 3, 30, 20);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(102, 31);
            this.btnBuscar.TabIndex = 67;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtCancelar
            // 
            this.txtCancelar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(66)))), ((int)(((byte)(73)))));
            this.txtCancelar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCancelar.Enabled = false;
            this.txtCancelar.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtCancelar.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtCancelar.Location = new System.Drawing.Point(402, 561);
            this.txtCancelar.Margin = new System.Windows.Forms.Padding(10, 20, 40, 0);
            this.txtCancelar.MaxLength = 70;
            this.txtCancelar.Name = "txtCancelar";
            this.txtCancelar.ReadOnly = true;
            this.txtCancelar.Size = new System.Drawing.Size(160, 24);
            this.txtCancelar.TabIndex = 66;
            this.txtCancelar.Visible = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancelar.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(15)))), ((int)(((byte)(17)))));
            this.btnCancelar.Location = new System.Drawing.Point(916, 555);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(16, 3, 30, 20);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 30);
            this.btnCancelar.TabIndex = 65;
            this.btnCancelar.Text = "Cancel";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dtpData
            // 
            this.dtpData.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpData.CustomFormat = " yyyy-MM-dd";
            this.dtpData.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpData.Location = new System.Drawing.Point(572, 325);
            this.dtpData.Margin = new System.Windows.Forms.Padding(3, 28, 3, 0);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(434, 24);
            this.dtpData.TabIndex = 64;
            this.dtpData.Value = new System.DateTime(2021, 10, 29, 16, 50, 32, 0);
            this.dtpData.Visible = false;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnExcluir.BackColor = System.Drawing.SystemColors.Control;
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(15)))), ((int)(((byte)(17)))));
            this.btnExcluir.Location = new System.Drawing.Point(704, 555);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(15, 3, 0, 20);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(90, 30);
            this.btnExcluir.TabIndex = 63;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Visible = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // ptbFoto
            // 
            this.ptbFoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(66)))), ((int)(((byte)(73)))));
            this.ptbFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptbFoto.Cursor = System.Windows.Forms.Cursors.Default;
            this.ptbFoto.Enabled = false;
            this.ptbFoto.Location = new System.Drawing.Point(64, 165);
            this.ptbFoto.Margin = new System.Windows.Forms.Padding(40, 40, 0, 0);
            this.ptbFoto.Name = "ptbFoto";
            this.ptbFoto.Size = new System.Drawing.Size(285, 380);
            this.ptbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbFoto.TabIndex = 58;
            this.ptbFoto.TabStop = false;
            this.ptbFoto.Visible = false;
            this.ptbFoto.Click += new System.EventHandler(this.ptbFoto_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSalvar.BackColor = System.Drawing.SystemColors.Control;
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(15)))), ((int)(((byte)(17)))));
            this.btnSalvar.Location = new System.Drawing.Point(810, 555);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(16, 3, 0, 20);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(90, 30);
            this.btnSalvar.TabIndex = 62;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Visible = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtNomeAnime
            // 
            this.txtNomeAnime.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNomeAnime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(66)))), ((int)(((byte)(73)))));
            this.txtNomeAnime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomeAnime.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeAnime.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtNomeAnime.Location = new System.Drawing.Point(404, 165);
            this.txtNomeAnime.Margin = new System.Windows.Forms.Padding(20, 0, 40, 0);
            this.txtNomeAnime.MaxLength = 70;
            this.txtNomeAnime.Name = "txtNomeAnime";
            this.txtNomeAnime.ReadOnly = true;
            this.txtNomeAnime.Size = new System.Drawing.Size(602, 27);
            this.txtNomeAnime.TabIndex = 50;
            this.txtNomeAnime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNomeAnime.Visible = false;
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEditar.BackColor = System.Drawing.SystemColors.Control;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(15)))), ((int)(((byte)(17)))));
            this.btnEditar.Location = new System.Drawing.Point(916, 555);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(16, 3, 30, 20);
            this.btnEditar.MaximumSize = new System.Drawing.Size(90, 30);
            this.btnEditar.MinimumSize = new System.Drawing.Size(90, 30);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(90, 30);
            this.btnEditar.TabIndex = 61;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Visible = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // lblSinopse
            // 
            this.lblSinopse.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSinopse.AutoSize = true;
            this.lblSinopse.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSinopse.ForeColor = System.Drawing.Color.White;
            this.lblSinopse.Location = new System.Drawing.Point(401, 367);
            this.lblSinopse.Margin = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.lblSinopse.Name = "lblSinopse";
            this.lblSinopse.Size = new System.Drawing.Size(65, 18);
            this.lblSinopse.TabIndex = 51;
            this.lblSinopse.Text = "Sinopse";
            this.lblSinopse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSinopse.Visible = false;
            // 
            // txtImagem
            // 
            this.txtImagem.BackColor = System.Drawing.SystemColors.Window;
            this.txtImagem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtImagem.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.txtImagem.Location = new System.Drawing.Point(64, 555);
            this.txtImagem.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.txtImagem.Name = "txtImagem";
            this.txtImagem.ReadOnly = true;
            this.txtImagem.Size = new System.Drawing.Size(285, 21);
            this.txtImagem.TabIndex = 60;
            this.txtImagem.Visible = false;
            // 
            // txtSinopse
            // 
            this.txtSinopse.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSinopse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(66)))), ((int)(((byte)(73)))));
            this.txtSinopse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSinopse.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtSinopse.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtSinopse.Location = new System.Drawing.Point(404, 395);
            this.txtSinopse.Margin = new System.Windows.Forms.Padding(20, 10, 40, 30);
            this.txtSinopse.MaxLength = 1400;
            this.txtSinopse.Multiline = true;
            this.txtSinopse.Name = "txtSinopse";
            this.txtSinopse.ReadOnly = true;
            this.txtSinopse.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSinopse.Size = new System.Drawing.Size(602, 150);
            this.txtSinopse.TabIndex = 52;
            this.txtSinopse.Visible = false;
            // 
            // txtDataLanc
            // 
            this.txtDataLanc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDataLanc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(66)))), ((int)(((byte)(73)))));
            this.txtDataLanc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDataLanc.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtDataLanc.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtDataLanc.Location = new System.Drawing.Point(572, 325);
            this.txtDataLanc.Margin = new System.Windows.Forms.Padding(10, 20, 40, 0);
            this.txtDataLanc.MaxLength = 10;
            this.txtDataLanc.Name = "txtDataLanc";
            this.txtDataLanc.ReadOnly = true;
            this.txtDataLanc.Size = new System.Drawing.Size(434, 24);
            this.txtDataLanc.TabIndex = 59;
            this.txtDataLanc.Visible = false;
            // 
            // lblNumEps
            // 
            this.lblNumEps.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNumEps.AutoSize = true;
            this.lblNumEps.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumEps.ForeColor = System.Drawing.Color.White;
            this.lblNumEps.Location = new System.Drawing.Point(401, 279);
            this.lblNumEps.Margin = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.lblNumEps.Name = "lblNumEps";
            this.lblNumEps.Size = new System.Drawing.Size(163, 18);
            this.lblNumEps.TabIndex = 53;
            this.lblNumEps.Text = "Número de Episódios";
            this.lblNumEps.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNumEps.Visible = false;
            // 
            // lblEstudio
            // 
            this.lblEstudio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEstudio.AutoSize = true;
            this.lblEstudio.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstudio.ForeColor = System.Drawing.Color.White;
            this.lblEstudio.Location = new System.Drawing.Point(401, 235);
            this.lblEstudio.Margin = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.lblEstudio.Name = "lblEstudio";
            this.lblEstudio.Size = new System.Drawing.Size(59, 18);
            this.lblEstudio.TabIndex = 54;
            this.lblEstudio.Text = "Estúdio";
            this.lblEstudio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEstudio.Visible = false;
            // 
            // lblDataLanc
            // 
            this.lblDataLanc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDataLanc.AutoSize = true;
            this.lblDataLanc.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.lblDataLanc.ForeColor = System.Drawing.Color.White;
            this.lblDataLanc.Location = new System.Drawing.Point(401, 323);
            this.lblDataLanc.Margin = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.lblDataLanc.Name = "lblDataLanc";
            this.lblDataLanc.Size = new System.Drawing.Size(161, 18);
            this.lblDataLanc.TabIndex = 57;
            this.lblDataLanc.Text = "Data de lançamento";
            this.lblDataLanc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDataLanc.Visible = false;
            // 
            // txtEstudio
            // 
            this.txtEstudio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtEstudio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(66)))), ((int)(((byte)(73)))));
            this.txtEstudio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEstudio.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtEstudio.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtEstudio.Location = new System.Drawing.Point(470, 237);
            this.txtEstudio.Margin = new System.Windows.Forms.Padding(10, 28, 40, 0);
            this.txtEstudio.MaxLength = 70;
            this.txtEstudio.Name = "txtEstudio";
            this.txtEstudio.ReadOnly = true;
            this.txtEstudio.Size = new System.Drawing.Size(536, 24);
            this.txtEstudio.TabIndex = 55;
            this.txtEstudio.Visible = false;
            // 
            // txtNumEps
            // 
            this.txtNumEps.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNumEps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(66)))), ((int)(((byte)(73)))));
            this.txtNumEps.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumEps.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtNumEps.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtNumEps.Location = new System.Drawing.Point(574, 281);
            this.txtNumEps.Margin = new System.Windows.Forms.Padding(10, 20, 40, 0);
            this.txtNumEps.MaxLength = 70;
            this.txtNumEps.Name = "txtNumEps";
            this.txtNumEps.ReadOnly = true;
            this.txtNumEps.Size = new System.Drawing.Size(428, 24);
            this.txtNumEps.TabIndex = 56;
            this.txtNumEps.Visible = false;
            // 
            // tblanimeTableAdapter
            // 
            this.tblanimeTableAdapter.ClearBeforeFill = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(27)))));
            this.panel2.Controls.Add(this.btnAdmin);
            this.panel2.Controls.Add(this.BtnCadastro);
            this.panel2.Controls.Add(this.btnSair);
            this.panel2.Location = new System.Drawing.Point(0, 513);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(215, 208);
            this.panel2.TabIndex = 29;
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.SystemColors.Control;
            this.btnAdmin.FlatAppearance.BorderSize = 0;
            this.btnAdmin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(200)))), ((int)(((byte)(222)))));
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.ForeColor = System.Drawing.Color.Black;
            this.btnAdmin.Location = new System.Drawing.Point(19, 13);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(177, 46);
            this.btnAdmin.TabIndex = 10;
            this.btnAdmin.Text = "Tabela Admin";
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // BtnCadastro
            // 
            this.BtnCadastro.BackColor = System.Drawing.SystemColors.Control;
            this.BtnCadastro.FlatAppearance.BorderSize = 0;
            this.BtnCadastro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(200)))), ((int)(((byte)(222)))));
            this.BtnCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCadastro.ForeColor = System.Drawing.Color.Black;
            this.BtnCadastro.Location = new System.Drawing.Point(19, 78);
            this.BtnCadastro.Name = "BtnCadastro";
            this.BtnCadastro.Size = new System.Drawing.Size(177, 46);
            this.BtnCadastro.TabIndex = 8;
            this.BtnCadastro.Text = "Cadastro";
            this.BtnCadastro.UseVisualStyleBackColor = false;
            this.BtnCadastro.Click += new System.EventHandler(this.BtnCadastro_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.Control;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(200)))), ((int)(((byte)(222)))));
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.ForeColor = System.Drawing.Color.Black;
            this.btnSair.Location = new System.Drawing.Point(19, 143);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(177, 46);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // FrmAnimeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(66)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnMini);
            this.Controls.Add(this.btnMax);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.iframeFake);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(880, 589);
            this.Name = "FrmAnimeList";
            this.Text = "AnimeList";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmAnimeList_FormClosed);
            this.Load += new System.EventHandler(this.FrmAnimeList_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmAnimeList_KeyDown);
            this.Resize += new System.EventHandler(this.FrmAnimeList_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dtgAnimes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblanimeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoanimesDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.iframeFake.ResumeLayout(false);
            this.iframeFake.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFoto)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.DataGridView dtgAnimes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnAnimeGer;
        private System.Windows.Forms.Button BtnAnimeList;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnMini;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel iframeFake;
        private System.Windows.Forms.TextBox txtCancelar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.PictureBox ptbFoto;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtNomeAnime;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label lblSinopse;
        private System.Windows.Forms.TextBox txtImagem;
        private System.Windows.Forms.TextBox txtSinopse;
        private System.Windows.Forms.TextBox txtDataLanc;
        private System.Windows.Forms.Label lblNumEps;
        private System.Windows.Forms.Label lblEstudio;
        private System.Windows.Forms.Label lblDataLanc;
        private System.Windows.Forms.TextBox txtEstudio;
        private System.Windows.Forms.TextBox txtNumEps;
        private System.Windows.Forms.Button btnBuscar;
        private bancoanimesDataSet bancoanimesDataSet;
        private System.Windows.Forms.BindingSource tblanimeBindingSource;
        private bancoanimesDataSetTableAdapters.tblanimeTableAdapter tblanimeTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeAnimeDesign;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button BtnCadastro;
        private System.Windows.Forms.Button btnSair;
    }
}