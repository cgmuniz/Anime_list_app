
namespace HamimiProofei
{
    partial class TblAdmin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TblAdmin));
            this.btnApagar = new System.Windows.Forms.Button();
            this.dtgAdmin = new System.Windows.Forms.DataGridView();
            this.nomeAdminDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailAdminDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbladminBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bancoanimesDataSet1 = new HamimiProofei.bancoanimesDataSet1();
            this.tblanimeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bancoanimesDataSet = new HamimiProofei.bancoanimesDataSet();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.BtnCadastro = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
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
            this.btnAtualizaTabela = new System.Windows.Forms.Button();
            this.tblanimeTableAdapter = new HamimiProofei.bancoanimesDataSetTableAdapters.tblanimeTableAdapter();
            this.tbladminTableAdapter = new HamimiProofei.bancoanimesDataSet1TableAdapters.tbladminTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbladminBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoanimesDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblanimeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoanimesDataSet)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.iframeFake.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnApagar
            // 
            this.btnApagar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApagar.BackColor = System.Drawing.SystemColors.Control;
            this.btnApagar.FlatAppearance.BorderSize = 0;
            this.btnApagar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(200)))), ((int)(((byte)(222)))));
            this.btnApagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApagar.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.btnApagar.ForeColor = System.Drawing.Color.Black;
            this.btnApagar.Location = new System.Drawing.Point(108, 584);
            this.btnApagar.MaximumSize = new System.Drawing.Size(102, 31);
            this.btnApagar.MinimumSize = new System.Drawing.Size(102, 31);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(102, 31);
            this.btnApagar.TabIndex = 19;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = false;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // dtgAdmin
            // 
            this.dtgAdmin.AllowUserToAddRows = false;
            this.dtgAdmin.AllowUserToDeleteRows = false;
            this.dtgAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgAdmin.AutoGenerateColumns = false;
            this.dtgAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAdmin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeAdminDataGridViewTextBoxColumn,
            this.emailAdminDataGridViewTextBoxColumn});
            this.dtgAdmin.DataSource = this.tbladminBindingSource;
            this.dtgAdmin.Location = new System.Drawing.Point(108, 124);
            this.dtgAdmin.MaximumSize = new System.Drawing.Size(1100, 500);
            this.dtgAdmin.MinimumSize = new System.Drawing.Size(620, 437);
            this.dtgAdmin.Name = "dtgAdmin";
            this.dtgAdmin.ReadOnly = true;
            this.dtgAdmin.RowHeadersVisible = false;
            this.dtgAdmin.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgAdmin.Size = new System.Drawing.Size(853, 437);
            this.dtgAdmin.TabIndex = 20;
            this.dtgAdmin.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgAdmin_CellClick);
            // 
            // nomeAdminDataGridViewTextBoxColumn
            // 
            this.nomeAdminDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomeAdminDataGridViewTextBoxColumn.DataPropertyName = "nomeAdmin";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.nomeAdminDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.nomeAdminDataGridViewTextBoxColumn.HeaderText = "Nome Admin";
            this.nomeAdminDataGridViewTextBoxColumn.Name = "nomeAdminDataGridViewTextBoxColumn";
            this.nomeAdminDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailAdminDataGridViewTextBoxColumn
            // 
            this.emailAdminDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.emailAdminDataGridViewTextBoxColumn.DataPropertyName = "emailAdmin";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.emailAdminDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.emailAdminDataGridViewTextBoxColumn.HeaderText = "Email Admin";
            this.emailAdminDataGridViewTextBoxColumn.Name = "emailAdminDataGridViewTextBoxColumn";
            this.emailAdminDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tbladminBindingSource
            // 
            this.tbladminBindingSource.DataMember = "tbladmin";
            this.tbladminBindingSource.DataSource = this.bancoanimesDataSet1;
            // 
            // bancoanimesDataSet1
            // 
            this.bancoanimesDataSet1.DataSetName = "bancoanimesDataSet1";
            this.bancoanimesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.panel2.TabIndex = 23;
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
            this.btnAdmin.TabIndex = 9;
            this.btnAdmin.Text = "Tabela Admin";
            this.btnAdmin.UseVisualStyleBackColor = false;
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
            this.BtnAnimeList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(27)))));
            this.BtnAnimeList.FlatAppearance.BorderSize = 0;
            this.BtnAnimeList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(200)))), ((int)(((byte)(222)))));
            this.BtnAnimeList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAnimeList.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.BtnAnimeList.ForeColor = System.Drawing.Color.White;
            this.BtnAnimeList.Location = new System.Drawing.Point(3, 250);
            this.BtnAnimeList.Name = "BtnAnimeList";
            this.BtnAnimeList.Size = new System.Drawing.Size(209, 81);
            this.BtnAnimeList.TabIndex = 3;
            this.BtnAnimeList.Text = "Anime List";
            this.BtnAnimeList.UseVisualStyleBackColor = false;
            this.BtnAnimeList.Click += new System.EventHandler(this.BtnAnimeList_Click);
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
            this.iframeFake.Controls.Add(this.btnAtualizaTabela);
            this.iframeFake.Controls.Add(this.btnApagar);
            this.iframeFake.Controls.Add(this.dtgAdmin);
            this.iframeFake.Location = new System.Drawing.Point(215, 28);
            this.iframeFake.Name = "iframeFake";
            this.iframeFake.Size = new System.Drawing.Size(1065, 670);
            this.iframeFake.TabIndex = 28;
            // 
            // btnAtualizaTabela
            // 
            this.btnAtualizaTabela.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAtualizaTabela.BackgroundImage")));
            this.btnAtualizaTabela.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAtualizaTabela.FlatAppearance.BorderSize = 0;
            this.btnAtualizaTabela.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAtualizaTabela.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizaTabela.Location = new System.Drawing.Point(228, 577);
            this.btnAtualizaTabela.Name = "btnAtualizaTabela";
            this.btnAtualizaTabela.Size = new System.Drawing.Size(39, 42);
            this.btnAtualizaTabela.TabIndex = 21;
            this.btnAtualizaTabela.UseVisualStyleBackColor = true;
            this.btnAtualizaTabela.Click += new System.EventHandler(this.btnAtualizaTabela_Click);
            // 
            // tblanimeTableAdapter
            // 
            this.tblanimeTableAdapter.ClearBeforeFill = true;
            // 
            // tbladminTableAdapter
            // 
            this.tbladminTableAdapter.ClearBeforeFill = true;
            // 
            // TblAdmin
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
            this.Name = "TblAdmin";
            this.Text = "AnimeList";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TblAdmin_FormClosed);
            this.Load += new System.EventHandler(this.TblAdmin_Load);
            this.Resize += new System.EventHandler(this.TblAdmin_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dtgAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbladminBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoanimesDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblanimeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoanimesDataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.iframeFake.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.DataGridView dtgAdmin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnCadastro;
        private System.Windows.Forms.Button btnSair;
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
        private bancoanimesDataSet bancoanimesDataSet;
        private System.Windows.Forms.BindingSource tblanimeBindingSource;
        private bancoanimesDataSetTableAdapters.tblanimeTableAdapter tblanimeTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private bancoanimesDataSet1 bancoanimesDataSet1;
        private System.Windows.Forms.BindingSource tbladminBindingSource;
        private bancoanimesDataSet1TableAdapters.tbladminTableAdapter tbladminTableAdapter;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeAdminDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailAdminDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnAtualizaTabela;
    }
}