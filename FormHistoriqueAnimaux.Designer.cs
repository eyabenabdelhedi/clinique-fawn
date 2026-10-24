namespace CliniqueVeterinaire
{
    partial class FormHistoriqueAnimaux
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHistoriqueAnimaux));
            this.lblRecherche = new System.Windows.Forms.Label();
            this.txtRecherche = new System.Windows.Forms.TextBox();
            this.panel = new System.Windows.Forms.Panel();
            this.lblTitre = new System.Windows.Forms.Label();
            this.cliniqueVetDBDataSet = new CliniqueVeterinaire.CliniqueVetDBDataSet();
            this.consultationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.consultationsTableAdapter = new CliniqueVeterinaire.CliniqueVetDBDataSetTableAdapters.ConsultationsTableAdapter();
            this.tableAdapterManager = new CliniqueVeterinaire.CliniqueVetDBDataSetTableAdapters.TableAdapterManager();
            this.consultationsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.consultationsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.consultationsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cliniqueVetDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultationsBindingNavigator)).BeginInit();
            this.consultationsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.consultationsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRecherche
            // 
            this.lblRecherche.AutoSize = true;
            this.lblRecherche.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecherche.Location = new System.Drawing.Point(284, 137);
            this.lblRecherche.Name = "lblRecherche";
            this.lblRecherche.Size = new System.Drawing.Size(137, 23);
            this.lblRecherche.TabIndex = 12;
            this.lblRecherche.Text = "🔍 Rechercher :";
            // 
            // txtRecherche
            // 
            this.txtRecherche.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRecherche.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtRecherche.Location = new System.Drawing.Point(443, 135);
            this.txtRecherche.Name = "txtRecherche";
            this.txtRecherche.Size = new System.Drawing.Size(400, 30);
            this.txtRecherche.TabIndex = 13;
            this.txtRecherche.TextChanged += new System.EventHandler(this.txtRecherche_TextChanged);
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(220)))));
            this.panel.Controls.Add(this.lblTitre);
            this.panel.Location = new System.Drawing.Point(-149, -2);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1347, 113);
            this.panel.TabIndex = 14;
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.BackColor = System.Drawing.Color.Transparent;
            this.lblTitre.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.ForeColor = System.Drawing.Color.Crimson;
            this.lblTitre.Location = new System.Drawing.Point(395, 40);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(633, 50);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "🐾 HISTORIQUE DES ANIMAUX 📋";
            // 
            // cliniqueVetDBDataSet
            // 
            this.cliniqueVetDBDataSet.DataSetName = "CliniqueVetDBDataSet";
            this.cliniqueVetDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // consultationsBindingSource
            // 
            this.consultationsBindingSource.DataMember = "Consultations";
            this.consultationsBindingSource.DataSource = this.cliniqueVetDBDataSet;
            // 
            // consultationsTableAdapter
            // 
            this.consultationsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AnimauxTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ConsultationsTableAdapter = this.consultationsTableAdapter;
            this.tableAdapterManager.FacturesTableAdapter = null;
            this.tableAdapterManager.MedicamentsTableAdapter = null;
            this.tableAdapterManager.ProprietairesTableAdapter = null;
            this.tableAdapterManager.RendezVousTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CliniqueVeterinaire.CliniqueVetDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UtilisateursTableAdapter = null;
            this.tableAdapterManager.VaccinationsTableAdapter = null;
            // 
            // consultationsBindingNavigator
            // 
            this.consultationsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.consultationsBindingNavigator.BindingSource = this.consultationsBindingSource;
            this.consultationsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.consultationsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.consultationsBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.consultationsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.consultationsBindingNavigatorSaveItem});
            this.consultationsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.consultationsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.consultationsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.consultationsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.consultationsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.consultationsBindingNavigator.Name = "consultationsBindingNavigator";
            this.consultationsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.consultationsBindingNavigator.Size = new System.Drawing.Size(1192, 27);
            this.consultationsBindingNavigator.TabIndex = 15;
            this.consultationsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Placer en premier";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Déplacer vers le haut";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Position actuelle";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 20);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Nombre total d\'éléments";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Déplacer vers le bas";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Placer en dernier";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Ajouter nouveau";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Supprimer";
            // 
            // consultationsBindingNavigatorSaveItem
            // 
            this.consultationsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.consultationsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("consultationsBindingNavigatorSaveItem.Image")));
            this.consultationsBindingNavigatorSaveItem.Name = "consultationsBindingNavigatorSaveItem";
            this.consultationsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.consultationsBindingNavigatorSaveItem.Text = "Enregistrer les données";
            this.consultationsBindingNavigatorSaveItem.Click += new System.EventHandler(this.consultationsBindingNavigatorSaveItem_Click);
            // 
            // consultationsDataGridView
            // 
            this.consultationsDataGridView.AutoGenerateColumns = false;
            this.consultationsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.consultationsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.consultationsDataGridView.DataSource = this.consultationsBindingSource;
            this.consultationsDataGridView.Location = new System.Drawing.Point(58, 203);
            this.consultationsDataGridView.Name = "consultationsDataGridView";
            this.consultationsDataGridView.RowHeadersWidth = 51;
            this.consultationsDataGridView.RowTemplate.Height = 24;
            this.consultationsDataGridView.Size = new System.Drawing.Size(1054, 220);
            this.consultationsDataGridView.TabIndex = 15;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdConsultation";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdConsultation";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DateConsultation";
            this.dataGridViewTextBoxColumn2.HeaderText = "DateConsultation";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Diagnostic";
            this.dataGridViewTextBoxColumn3.HeaderText = "Diagnostic";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Traitement";
            this.dataGridViewTextBoxColumn4.HeaderText = "Traitement";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Remarques";
            this.dataGridViewTextBoxColumn5.HeaderText = "Remarques";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "IdAnimal";
            this.dataGridViewTextBoxColumn6.HeaderText = "IdAnimal";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "IdVeterinaire";
            this.dataGridViewTextBoxColumn7.HeaderText = "IdVeterinaire";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "IdRendezVous";
            this.dataGridViewTextBoxColumn8.HeaderText = "IdRendezVous";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // FormHistoriqueAnimaux
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(250)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1192, 473);
            this.Controls.Add(this.consultationsDataGridView);
            this.Controls.Add(this.consultationsBindingNavigator);
            this.Controls.Add(this.lblRecherche);
            this.Controls.Add(this.txtRecherche);
            this.Controls.Add(this.panel);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FormHistoriqueAnimaux";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clinique Fawn - Historique des Animaux";
            this.Load += new System.EventHandler(this.FormHistoriqueAnimaux_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cliniqueVetDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultationsBindingNavigator)).EndInit();
            this.consultationsBindingNavigator.ResumeLayout(false);
            this.consultationsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.consultationsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRecherche;
        private System.Windows.Forms.TextBox txtRecherche;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label lblTitre;
        private CliniqueVetDBDataSet cliniqueVetDBDataSet;
        private System.Windows.Forms.BindingSource consultationsBindingSource;
        private CliniqueVetDBDataSetTableAdapters.ConsultationsTableAdapter consultationsTableAdapter;
        private CliniqueVetDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator consultationsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton consultationsBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView consultationsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}