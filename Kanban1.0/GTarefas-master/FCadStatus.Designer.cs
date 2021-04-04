
namespace GTarefas
{
    partial class FCadStatus
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
            System.Windows.Forms.Label idStatusLabel;
            System.Windows.Forms.Label descricaoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FCadStatus));
            this.gtarefasDataSet = new GTarefas.GtarefasDataSet();
            this.statusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statusTableAdapter = new GTarefas.GtarefasDataSetTableAdapters.StatusTableAdapter();
            this.tableAdapterManager = new GTarefas.GtarefasDataSetTableAdapters.TableAdapterManager();
            this.statusBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.statusBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idStatusLabel1 = new System.Windows.Forms.Label();
            this.descricaoTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.voltarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairDoSitemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            idStatusLabel = new System.Windows.Forms.Label();
            descricaoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gtarefasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingNavigator)).BeginInit();
            this.statusBindingNavigator.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // idStatusLabel
            // 
            idStatusLabel.AutoSize = true;
            idStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idStatusLabel.Location = new System.Drawing.Point(114, 120);
            idStatusLabel.Name = "idStatusLabel";
            idStatusLabel.Size = new System.Drawing.Size(72, 16);
            idStatusLabel.TabIndex = 1;
            idStatusLabel.Text = "Id Status:";
            // 
            // descricaoLabel
            // 
            descricaoLabel.AutoSize = true;
            descricaoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descricaoLabel.Location = new System.Drawing.Point(114, 149);
            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new System.Drawing.Size(83, 16);
            descricaoLabel.TabIndex = 3;
            descricaoLabel.Text = "Descricao:";
            // 
            // gtarefasDataSet
            // 
            this.gtarefasDataSet.DataSetName = "GtarefasDataSet";
            this.gtarefasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.responsavelTableAdapter = null;
            this.tableAdapterManager.StatusTableAdapter = this.statusTableAdapter;
            this.tableAdapterManager.TarefaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GTarefas.GtarefasDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // statusBindingNavigator
            // 
            this.statusBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.statusBindingNavigator.BindingSource = this.statusBindingSource;
            this.statusBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.statusBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.statusBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.statusBindingNavigatorSaveItem});
            this.statusBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.statusBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.statusBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.statusBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.statusBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.statusBindingNavigator.Name = "statusBindingNavigator";
            this.statusBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.statusBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.statusBindingNavigator.TabIndex = 0;
            this.statusBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // statusBindingNavigatorSaveItem
            // 
            this.statusBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.statusBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("statusBindingNavigatorSaveItem.Image")));
            this.statusBindingNavigatorSaveItem.Name = "statusBindingNavigatorSaveItem";
            this.statusBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.statusBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.statusBindingNavigatorSaveItem.Click += new System.EventHandler(this.statusBindingNavigatorSaveItem_Click);
            // 
            // idStatusLabel1
            // 
            this.idStatusLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statusBindingSource, "IdStatus", true));
            this.idStatusLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idStatusLabel1.Location = new System.Drawing.Point(203, 120);
            this.idStatusLabel1.Name = "idStatusLabel1";
            this.idStatusLabel1.Size = new System.Drawing.Size(100, 23);
            this.idStatusLabel1.TabIndex = 2;
            this.idStatusLabel1.Text = "label1";
            // 
            // descricaoTextBox
            // 
            this.descricaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statusBindingSource, "Descricao", true));
            this.descricaoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descricaoTextBox.Location = new System.Drawing.Point(203, 143);
            this.descricaoTextBox.Multiline = true;
            this.descricaoTextBox.Name = "descricaoTextBox";
            this.descricaoTextBox.Size = new System.Drawing.Size(164, 38);
            this.descricaoTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(117, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cadastrar novo Status de Tarefa";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.voltarToolStripMenuItem,
            this.sairDoSitemaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 25);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 25);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // voltarToolStripMenuItem
            // 
            this.voltarToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voltarToolStripMenuItem.Name = "voltarToolStripMenuItem";
            this.voltarToolStripMenuItem.Size = new System.Drawing.Size(61, 21);
            this.voltarToolStripMenuItem.Text = "Voltar ";
            this.voltarToolStripMenuItem.Click += new System.EventHandler(this.voltarToolStripMenuItem_Click);
            // 
            // sairDoSitemaToolStripMenuItem
            // 
            this.sairDoSitemaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sairDoSitemaToolStripMenuItem.Name = "sairDoSitemaToolStripMenuItem";
            this.sairDoSitemaToolStripMenuItem.Size = new System.Drawing.Size(115, 21);
            this.sairDoSitemaToolStripMenuItem.Text = "Sair do Sistema";
            this.sairDoSitemaToolStripMenuItem.Click += new System.EventHandler(this.sairDoSitemaToolStripMenuItem_Click);
            // 
            // FCadStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(idStatusLabel);
            this.Controls.Add(this.idStatusLabel1);
            this.Controls.Add(descricaoLabel);
            this.Controls.Add(this.descricaoTextBox);
            this.Controls.Add(this.statusBindingNavigator);
            this.MinimizeBox = false;
            this.Name = "FCadStatus";
            this.Text = "Cadastro de Status ";
            this.Load += new System.EventHandler(this.Fkstatus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gtarefasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingNavigator)).EndInit();
            this.statusBindingNavigator.ResumeLayout(false);
            this.statusBindingNavigator.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GtarefasDataSet gtarefasDataSet;
        private System.Windows.Forms.BindingSource statusBindingSource;
        private GtarefasDataSetTableAdapters.StatusTableAdapter statusTableAdapter;
        private GtarefasDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator statusBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton statusBindingNavigatorSaveItem;
        private System.Windows.Forms.Label idStatusLabel1;
        private System.Windows.Forms.TextBox descricaoTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem voltarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairDoSitemaToolStripMenuItem;
    }
}