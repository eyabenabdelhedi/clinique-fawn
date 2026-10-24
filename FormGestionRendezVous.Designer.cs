namespace CliniqueVeterinaire
{
    partial class FormGestionRendezVous
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGestionRendezVous));
            this.lblRecherche = new System.Windows.Forms.Label();
            this.txtRecherche = new System.Windows.Forms.TextBox();
            this.panel = new System.Windows.Forms.Panel();
            this.lblTitre = new System.Windows.Forms.Label();
            this.cliniqueVetDBDataSet = new CliniqueVeterinaire.CliniqueVetDBDataSet();
            this.rendezVousBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rendezVousTableAdapter = new CliniqueVeterinaire.CliniqueVetDBDataSetTableAdapters.RendezVousTableAdapter();
            this.tableAdapterManager = new CliniqueVeterinaire.CliniqueVetDBDataSetTableAdapters.TableAdapterManager();
            this.rendezVousBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.rendezVousBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.rendezVousDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cliniqueVetDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rendezVousBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rendezVousBindingNavigator)).BeginInit();
            this.rendezVousBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rendezVousDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRecherche
            // 
            this.lblRecherche.AutoSize = true;
            this.lblRecherche.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecherche.Location = new System.Drawing.Point(29, 121);
            this.lblRecherche.Name = "lblRecherche";
            this.lblRecherche.Size = new System.Drawing.Size(137, 23);
            this.lblRecherche.TabIndex = 3;
            this.lblRecherche.Text = "🔍 Rechercher :";
            // 
            // txtRecherche
            // 
            this.txtRecherche.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRecherche.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtRecherche.Location = new System.Drawing.Point(185, 117);
            this.txtRecherche.Name = "txtRecherche";
            this.txtRecherche.Size = new System.Drawing.Size(400, 30);
            this.txtRecherche.TabIndex = 4;
            this.txtRecherche.TextChanged += new System.EventHandler(this.txtRecherche_TextChanged);
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(220)))));
            this.panel.Controls.Add(this.lblTitre);
            this.panel.Location = new System.Drawing.Point(1, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1020, 90);
            this.panel.TabIndex = 5;
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.BackColor = System.Drawing.Color.Transparent;
            this.lblTitre.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.ForeColor = System.Drawing.Color.Crimson;
            this.lblTitre.Location = new System.Drawing.Point(135, 27);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(650, 50);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "🐾 GESTION DES RENDEZ-VOUS 📅";
            this.lblTitre.Click += new System.EventHandler(this.Titre_Click);
            // 
            // cliniqueVetDBDataSet
            // 
            this.cliniqueVetDBDataSet.DataSetName = "CliniqueVetDBDataSet";
            this.cliniqueVetDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rendezVousBindingSource
            // 
            this.rendezVousBindingSource.DataMember = "RendezVous";
            this.rendezVousBindingSource.DataSource = this.cliniqueVetDBDataSet;
            // 
            // rendezVousTableAdapter
            // 
            this.rendezVousTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AnimauxTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ConsultationsTableAdapter = null;
            this.tableAdapterManager.FacturesTableAdapter = null;
            this.tableAdapterManager.MedicamentsTableAdapter = null;
            this.tableAdapterManager.ProprietairesTableAdapter = null;
            this.tableAdapterManager.RendezVousTableAdapter = this.rendezVousTableAdapter;
            this.tableAdapterManager.UpdateOrder = CliniqueVeterinaire.CliniqueVetDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UtilisateursTableAdapter = null;
            this.tableAdapterManager.VaccinationsTableAdapter = null;
            // 
            // rendezVousBindingNavigator
            // 
            this.rendezVousBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.rendezVousBindingNavigator.BindingSource = this.rendezVousBindingSource;
            this.rendezVousBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.rendezVousBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.rendezVousBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.rendezVousBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.rendezVousBindingNavigatorSaveItem});
            this.rendezVousBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.rendezVousBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.rendezVousBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.rendezVousBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.rendezVousBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.rendezVousBindingNavigator.Name = "rendezVousBindingNavigator";
            this.rendezVousBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.rendezVousBindingNavigator.Size = new System.Drawing.Size(1022, 31);
            this.rendezVousBindingNavigator.TabIndex = 6;
            this.rendezVousBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem.Text = "Ajouter nouveau";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 24);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Nombre total d\'éléments";
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
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Placer en premier";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Déplacer vers le haut";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Position actuelle";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // rendezVousBindingNavigatorSaveItem
            // 
            this.rendezVousBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.rendezVousBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("rendezVousBindingNavigatorSaveItem.Image")));
            this.rendezVousBindingNavigatorSaveItem.Name = "rendezVousBindingNavigatorSaveItem";
            this.rendezVousBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.rendezVousBindingNavigatorSaveItem.Text = "Enregistrer les données";
            this.rendezVousBindingNavigatorSaveItem.Click += new System.EventHandler(this.rendezVousBindingNavigatorSaveItem_Click);
            // 
            // rendezVousDataGridView
            // 
            this.rendezVousDataGridView.AutoGenerateColumns = false;
            this.rendezVousDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rendezVousDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.rendezVousDataGridView.DataSource = this.rendezVousBindingSource;
            this.rendezVousDataGridView.Location = new System.Drawing.Point(47, 172);
            this.rendezVousDataGridView.Name = "rendezVousDataGridView";
            this.rendezVousDataGridView.RowHeadersWidth = 51;
            this.rendezVousDataGridView.RowTemplate.Height = 24;
            this.rendezVousDataGridView.Size = new System.Drawing.Size(804, 220);
            this.rendezVousDataGridView.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdRendezVous";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdRendezVous";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DateRDV";
            this.dataGridViewTextBoxColumn2.HeaderText = "DateRDV";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Motif";
            this.dataGridViewTextBoxColumn3.HeaderText = "Motif";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Statut";
            this.dataGridViewTextBoxColumn4.HeaderText = "Statut";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "IdAnimal";
            this.dataGridViewTextBoxColumn5.HeaderText = "IdAnimal";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "IdVeterinaire";
            this.dataGridViewTextBoxColumn6.HeaderText = "IdVeterinaire";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // FormGestionRendezVous
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 453);
            this.Controls.Add(this.rendezVousDataGridView);
            this.Controls.Add(this.rendezVousBindingNavigator);
            this.Controls.Add(this.lblRecherche);
            this.Controls.Add(this.txtRecherche);
            this.Controls.Add(this.panel);
            this.Name = "FormGestionRendezVous";
            this.Text = "Clinique Fawn - Gestion des Rendez-Vous";
            this.Load += new System.EventHandler(this.FormGestionRendezVous_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cliniqueVetDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rendezVousBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rendezVousBindingNavigator)).EndInit();
            this.rendezVousBindingNavigator.ResumeLayout(false);
            this.rendezVousBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rendezVousDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRecherche;
        private System.Windows.Forms.TextBox txtRecherche;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label lblTitre;
        private CliniqueVetDBDataSet cliniqueVetDBDataSet;
        private System.Windows.Forms.BindingSource rendezVousBindingSource;
        private CliniqueVetDBDataSetTableAdapters.RendezVousTableAdapter rendezVousTableAdapter;
        private CliniqueVetDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator rendezVousBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton rendezVousBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView rendezVousDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}