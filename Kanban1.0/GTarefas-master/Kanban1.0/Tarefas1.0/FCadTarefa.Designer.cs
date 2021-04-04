
namespace GTarefas
{
    partial class FCadTarefa
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
            System.Windows.Forms.Label idTarefaLabel;
            System.Windows.Forms.Label descricaoLabel;
            System.Windows.Forms.Label fKStatusLabel;
            System.Windows.Forms.Label fKResponsavelLabel;
            System.Windows.Forms.Label obsLabel;
            this.gtarefasDataSet = new GTarefas.GtarefasDataSet();
            this.tarefaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tarefaTableAdapter = new GTarefas.GtarefasDataSetTableAdapters.TarefaTableAdapter();
            this.tableAdapterManager = new GTarefas.GtarefasDataSetTableAdapters.TableAdapterManager();
            this.idTarefaLabel1 = new System.Windows.Forms.Label();
            this.descricaoTextBox = new System.Windows.Forms.TextBox();
            this.obsTextBox = new System.Windows.Forms.TextBox();
            this.statusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statusTableAdapter = new GTarefas.GtarefasDataSetTableAdapters.StatusTableAdapter();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.responsavelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.responsavelTableAdapter = new GTarefas.GtarefasDataSetTableAdapters.responsavelTableAdapter();
            this.BTSalvar = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            idTarefaLabel = new System.Windows.Forms.Label();
            descricaoLabel = new System.Windows.Forms.Label();
            fKStatusLabel = new System.Windows.Forms.Label();
            fKResponsavelLabel = new System.Windows.Forms.Label();
            obsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gtarefasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarefaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.responsavelBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // idTarefaLabel
            // 
            idTarefaLabel.AutoSize = true;
            idTarefaLabel.Location = new System.Drawing.Point(13, 64);
            idTarefaLabel.Name = "idTarefaLabel";
            idTarefaLabel.Size = new System.Drawing.Size(53, 13);
            idTarefaLabel.TabIndex = 1;
            idTarefaLabel.Text = "Id Tarefa:";
            // 
            // descricaoLabel
            // 
            descricaoLabel.AutoSize = true;
            descricaoLabel.Location = new System.Drawing.Point(10, 93);
            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new System.Drawing.Size(41, 13);
            descricaoLabel.TabIndex = 3;
            descricaoLabel.Text = "Tarefa:";
            descricaoLabel.Click += new System.EventHandler(this.descricaoLabel_Click);
            // 
            // fKStatusLabel
            // 
            fKStatusLabel.AutoSize = true;
            fKStatusLabel.Location = new System.Drawing.Point(218, 64);
            fKStatusLabel.Name = "fKStatusLabel";
            fKStatusLabel.Size = new System.Drawing.Size(86, 13);
            fKStatusLabel.TabIndex = 5;
            fKStatusLabel.Text = "Status da Tarefa";
            // 
            // fKResponsavelLabel
            // 
            fKResponsavelLabel.AutoSize = true;
            fKResponsavelLabel.Location = new System.Drawing.Point(341, 64);
            fKResponsavelLabel.Name = "fKResponsavelLabel";
            fKResponsavelLabel.Size = new System.Drawing.Size(72, 13);
            fKResponsavelLabel.TabIndex = 7;
            fKResponsavelLabel.Text = "Responsavel:";
            // 
            // obsLabel
            // 
            obsLabel.AutoSize = true;
            obsLabel.Location = new System.Drawing.Point(37, 119);
            obsLabel.Name = "obsLabel";
            obsLabel.Size = new System.Drawing.Size(29, 13);
            obsLabel.TabIndex = 9;
            obsLabel.Text = "Obs:";
            // 
            // gtarefasDataSet
            // 
            this.gtarefasDataSet.DataSetName = "GtarefasDataSet";
            this.gtarefasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tarefaBindingSource
            // 
            this.tarefaBindingSource.DataMember = "Tarefa";
            this.tarefaBindingSource.DataSource = this.gtarefasDataSet;
            // 
            // tarefaTableAdapter
            // 
            this.tarefaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.responsavelTableAdapter = null;
            this.tableAdapterManager.StatusTableAdapter = null;
            this.tableAdapterManager.TarefaTableAdapter = this.tarefaTableAdapter;
            this.tableAdapterManager.UpdateOrder = GTarefas.GtarefasDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // idTarefaLabel1
            // 
            this.idTarefaLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tarefaBindingSource, "IdTarefa", true));
            this.idTarefaLabel1.Location = new System.Drawing.Point(72, 64);
            this.idTarefaLabel1.Name = "idTarefaLabel1";
            this.idTarefaLabel1.Size = new System.Drawing.Size(121, 23);
            this.idTarefaLabel1.TabIndex = 2;
            this.idTarefaLabel1.Text = "label1";
            // 
            // descricaoTextBox
            // 
            this.descricaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tarefaBindingSource, "descricao", true));
            this.descricaoTextBox.Location = new System.Drawing.Point(72, 90);
            this.descricaoTextBox.Name = "descricaoTextBox";
            this.descricaoTextBox.Size = new System.Drawing.Size(121, 20);
            this.descricaoTextBox.TabIndex = 4;
            // 
            // obsTextBox
            // 
            this.obsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tarefaBindingSource, "Obs", true));
            this.obsTextBox.Location = new System.Drawing.Point(72, 116);
            this.obsTextBox.Multiline = true;
            this.obsTextBox.Name = "obsTextBox";
            this.obsTextBox.Size = new System.Drawing.Size(121, 59);
            this.obsTextBox.TabIndex = 10;
            // 
            // statusBindingSource
            // 
            this.statusBindingSource.DataMember = "Status";
            this.statusBindingSource.DataSource = this.gtarefasDataSet;
            // 
            // statusTableAdapter
            // 
            this.statusTableAdapter.ClearBeforeFill = true;
            // 
            // listBox1
            // 
            this.listBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tarefaBindingSource, "FKStatus", true));
            this.listBox1.DataSource = this.statusBindingSource;
            this.listBox1.DisplayMember = "Descricao";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(208, 80);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 11;
            this.listBox1.ValueMember = "IdStatus";
            // 
            // listBox2
            // 
            this.listBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tarefaBindingSource, "FKResponsavel", true));
            this.listBox2.DataSource = this.responsavelBindingSource;
            this.listBox2.DisplayMember = "Nome";
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(344, 80);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 95);
            this.listBox2.TabIndex = 12;
            this.listBox2.ValueMember = "IdResponsavel";
            // 
            // responsavelBindingSource
            // 
            this.responsavelBindingSource.DataMember = "responsavel";
            this.responsavelBindingSource.DataSource = this.gtarefasDataSet;
            // 
            // responsavelTableAdapter
            // 
            this.responsavelTableAdapter.ClearBeforeFill = true;
            // 
            // BTSalvar
            // 
            this.BTSalvar.Location = new System.Drawing.Point(208, 190);
            this.BTSalvar.Name = "BTSalvar";
            this.BTSalvar.Size = new System.Drawing.Size(75, 23);
            this.BTSalvar.TabIndex = 13;
            this.BTSalvar.Text = "Salvar";
            this.BTSalvar.UseVisualStyleBackColor = true;
            this.BTSalvar.Click += new System.EventHandler(this.BTSalvar_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(139, 215);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(216, 20);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(125, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Cadastrar novas Tarefas";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.cadastrarStatusToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(525, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // cadastrarStatusToolStripMenuItem
            // 
            this.cadastrarStatusToolStripMenuItem.Name = "cadastrarStatusToolStripMenuItem";
            this.cadastrarStatusToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.cadastrarStatusToolStripMenuItem.Text = "Sobre";
            this.cadastrarStatusToolStripMenuItem.Click += new System.EventHandler(this.cadastrarStatusToolStripMenuItem_Click);
            // 
            // FCadTarefa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(525, 239);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.BTSalvar);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(idTarefaLabel);
            this.Controls.Add(this.idTarefaLabel1);
            this.Controls.Add(descricaoLabel);
            this.Controls.Add(this.descricaoTextBox);
            this.Controls.Add(fKStatusLabel);
            this.Controls.Add(fKResponsavelLabel);
            this.Controls.Add(obsLabel);
            this.Controls.Add(this.obsTextBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FCadTarefa";
            this.Text = "FCadTarefa";
            this.Load += new System.EventHandler(this.FCadTarefa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gtarefasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarefaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.responsavelBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GtarefasDataSet gtarefasDataSet;
        private System.Windows.Forms.BindingSource tarefaBindingSource;
        private GtarefasDataSetTableAdapters.TarefaTableAdapter tarefaTableAdapter;
        private GtarefasDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label idTarefaLabel1;
        private System.Windows.Forms.TextBox descricaoTextBox;
        private System.Windows.Forms.TextBox obsTextBox;
        private System.Windows.Forms.BindingSource statusBindingSource;
        private GtarefasDataSetTableAdapters.StatusTableAdapter statusTableAdapter;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.BindingSource responsavelBindingSource;
        private GtarefasDataSetTableAdapters.responsavelTableAdapter responsavelTableAdapter;
        private System.Windows.Forms.Button BTSalvar;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarStatusToolStripMenuItem;
    }
}