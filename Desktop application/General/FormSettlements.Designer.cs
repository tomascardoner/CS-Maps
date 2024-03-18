﻿namespace CSMaps.General
{
    partial class FormSettlements
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
            DataGridViewMain = new DataGridView();
            DataGridViewColumnNombre = new DataGridViewTextBoxColumn();
            DataGridViewColumnEntidad = new DataGridViewTextBoxColumn();
            DataGridViewColumnTelefonoMovil = new DataGridViewTextBoxColumn();
            FlowLayoutPanelToolbars = new FlowLayoutPanel();
            ToolStripMain = new ToolStrip();
            ToolStripButtonAdd = new ToolStripButton();
            ToolStripButtonView = new ToolStripButton();
            ToolStripButtonEdit = new ToolStripButton();
            ToolStripButtonDelete = new ToolStripButton();
            ToolStripNamesFilter = new ToolStrip();
            ToolStripLabelFilter = new ToolStripLabel();
            ToolStripComboBoxFilterType = new ToolStripComboBox();
            ToolStripTextBoxFilter = new ToolStripTextBox();
            ToolStripButtonFilterClear = new ToolStripButton();
            ToolStripItemsCounter = new ToolStrip();
            ToolStripLabelItemsCounter = new ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)DataGridViewMain).BeginInit();
            FlowLayoutPanelToolbars.SuspendLayout();
            ToolStripMain.SuspendLayout();
            ToolStripNamesFilter.SuspendLayout();
            ToolStripItemsCounter.SuspendLayout();
            SuspendLayout();
            // 
            // DataGridViewMain
            // 
            DataGridViewMain.AllowUserToAddRows = false;
            DataGridViewMain.AllowUserToDeleteRows = false;
            DataGridViewMain.AllowUserToResizeColumns = false;
            DataGridViewMain.AllowUserToResizeRows = false;
            DataGridViewMain.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DataGridViewMain.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            DataGridViewMain.Columns.AddRange(new DataGridViewColumn[] { DataGridViewColumnNombre, DataGridViewColumnEntidad, DataGridViewColumnTelefonoMovil });
            DataGridViewMain.Dock = DockStyle.Fill;
            DataGridViewMain.EditMode = DataGridViewEditMode.EditProgrammatically;
            DataGridViewMain.Location = new Point(0, 64);
            DataGridViewMain.MultiSelect = false;
            DataGridViewMain.Name = "DataGridViewMain";
            DataGridViewMain.ReadOnly = true;
            DataGridViewMain.RowHeadersVisible = false;
            DataGridViewMain.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            DataGridViewMain.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridViewMain.Size = new Size(730, 269);
            DataGridViewMain.TabIndex = 1;
            DataGridViewMain.ColumnHeaderMouseClick += DataGridViewMain_ColumnHeaderMouseClick;
            DataGridViewMain.DoubleClick += ToolStripButtonView_Click;
            DataGridViewMain.KeyPress += DataGridViewMain_KeyPress;
            // 
            // DataGridViewColumnNombre
            // 
            DataGridViewColumnNombre.DataPropertyName = "Nombre";
            DataGridViewColumnNombre.HeaderText = "Nombre";
            DataGridViewColumnNombre.Name = "DataGridViewColumnNombre";
            DataGridViewColumnNombre.ReadOnly = true;
            DataGridViewColumnNombre.Width = 76;
            // 
            // DataGridViewColumnEntidad
            // 
            DataGridViewColumnEntidad.DataPropertyName = "EntidadNombre";
            DataGridViewColumnEntidad.HeaderText = "Entidad";
            DataGridViewColumnEntidad.Name = "DataGridViewColumnEntidad";
            DataGridViewColumnEntidad.ReadOnly = true;
            DataGridViewColumnEntidad.Width = 72;
            // 
            // DataGridViewColumnTelefonoMovil
            // 
            DataGridViewColumnTelefonoMovil.DataPropertyName = "TelefonoMovil";
            DataGridViewColumnTelefonoMovil.HeaderText = "Teléfono móvil";
            DataGridViewColumnTelefonoMovil.Name = "DataGridViewColumnTelefonoMovil";
            DataGridViewColumnTelefonoMovil.ReadOnly = true;
            DataGridViewColumnTelefonoMovil.Width = 110;
            // 
            // FlowLayoutPanelToolbars
            // 
            FlowLayoutPanelToolbars.AutoSize = true;
            FlowLayoutPanelToolbars.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            FlowLayoutPanelToolbars.Controls.Add(ToolStripMain);
            FlowLayoutPanelToolbars.Controls.Add(ToolStripNamesFilter);
            FlowLayoutPanelToolbars.Controls.Add(ToolStripItemsCounter);
            FlowLayoutPanelToolbars.Dock = DockStyle.Top;
            FlowLayoutPanelToolbars.Location = new Point(0, 0);
            FlowLayoutPanelToolbars.Margin = new Padding(4, 3, 4, 3);
            FlowLayoutPanelToolbars.Name = "FlowLayoutPanelToolbars";
            FlowLayoutPanelToolbars.Size = new Size(730, 64);
            FlowLayoutPanelToolbars.TabIndex = 3;
            // 
            // ToolStripMain
            // 
            ToolStripMain.Dock = DockStyle.Fill;
            ToolStripMain.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripMain.Items.AddRange(new ToolStripItem[] { ToolStripButtonAdd, ToolStripButtonView, ToolStripButtonEdit, ToolStripButtonDelete });
            ToolStripMain.Location = new Point(0, 0);
            ToolStripMain.Name = "ToolStripMain";
            ToolStripMain.Size = new Size(295, 39);
            ToolStripMain.TabIndex = 0;
            // 
            // ToolStripButtonAdd
            // 
            ToolStripButtonAdd.Image = Properties.Resources.ImageItemAdd32;
            ToolStripButtonAdd.ImageScaling = ToolStripItemImageScaling.None;
            ToolStripButtonAdd.ImageTransparentColor = Color.Magenta;
            ToolStripButtonAdd.Name = "ToolStripButtonAdd";
            ToolStripButtonAdd.Size = new Size(85, 36);
            ToolStripButtonAdd.Text = "Agregar";
            ToolStripButtonAdd.Click += ToolStripButtonAdd_Click;
            // 
            // ToolStripButtonView
            // 
            ToolStripButtonView.Image = Properties.Resources.ImageItemView32;
            ToolStripButtonView.ImageScaling = ToolStripItemImageScaling.None;
            ToolStripButtonView.ImageTransparentColor = Color.Magenta;
            ToolStripButtonView.Name = "ToolStripButtonView";
            ToolStripButtonView.Size = new Size(59, 36);
            ToolStripButtonView.Text = "Ver";
            ToolStripButtonView.Click += ToolStripButtonView_Click;
            // 
            // ToolStripButtonEdit
            // 
            ToolStripButtonEdit.Image = Properties.Resources.ImageItemEdit32;
            ToolStripButtonEdit.ImageScaling = ToolStripItemImageScaling.None;
            ToolStripButtonEdit.ImageTransparentColor = Color.Magenta;
            ToolStripButtonEdit.Name = "ToolStripButtonEdit";
            ToolStripButtonEdit.Size = new Size(73, 36);
            ToolStripButtonEdit.Text = "Editar";
            ToolStripButtonEdit.Click += ToolStripButtonEdit_Click;
            // 
            // ToolStripButtonDelete
            // 
            ToolStripButtonDelete.Image = Properties.Resources.ImageItemDelete32;
            ToolStripButtonDelete.ImageScaling = ToolStripItemImageScaling.None;
            ToolStripButtonDelete.ImageTransparentColor = Color.Magenta;
            ToolStripButtonDelete.Name = "ToolStripButtonDelete";
            ToolStripButtonDelete.Size = new Size(75, 36);
            ToolStripButtonDelete.Text = "Borrar";
            ToolStripButtonDelete.Click += ToolStripButtonDelete_Click;
            // 
            // ToolStripNamesFilter
            // 
            ToolStripNamesFilter.Dock = DockStyle.Fill;
            ToolStripNamesFilter.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripNamesFilter.Items.AddRange(new ToolStripItem[] { ToolStripLabelFilter, ToolStripComboBoxFilterType, ToolStripTextBoxFilter, ToolStripButtonFilterClear });
            ToolStripNamesFilter.Location = new Point(295, 0);
            ToolStripNamesFilter.Name = "ToolStripNamesFilter";
            ToolStripNamesFilter.Size = new Size(412, 39);
            ToolStripNamesFilter.TabIndex = 1;
            // 
            // ToolStripLabelFilter
            // 
            ToolStripLabelFilter.Name = "ToolStripLabelFilter";
            ToolStripLabelFilter.Size = new Size(111, 36);
            ToolStripLabelFilter.Text = "Filtrar por nombres:";
            // 
            // ToolStripComboBoxFilterType
            // 
            ToolStripComboBoxFilterType.DropDownStyle = ComboBoxStyle.DropDownList;
            ToolStripComboBoxFilterType.Name = "ToolStripComboBoxFilterType";
            ToolStripComboBoxFilterType.Size = new Size(121, 39);
            ToolStripComboBoxFilterType.SelectedIndexChanged += ToolStripComboBoxFilterType_SelectedIndexChanged;
            // 
            // ToolStripTextBoxFilter
            // 
            ToolStripTextBoxFilter.MaxLength = 100;
            ToolStripTextBoxFilter.Name = "ToolStripTextBoxFilter";
            ToolStripTextBoxFilter.Size = new Size(150, 39);
            ToolStripTextBoxFilter.Enter += ToolStripTextBoxSearch_Enter;
            ToolStripTextBoxFilter.KeyPress += ToolStripTextBoxSearch_KeyPress;
            // 
            // ToolStripButtonFilterClear
            // 
            ToolStripButtonFilterClear.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ToolStripButtonFilterClear.Image = Properties.Resources.ImageClose16;
            ToolStripButtonFilterClear.ImageScaling = ToolStripItemImageScaling.None;
            ToolStripButtonFilterClear.ImageTransparentColor = Color.Magenta;
            ToolStripButtonFilterClear.Name = "ToolStripButtonFilterClear";
            ToolStripButtonFilterClear.Size = new Size(23, 36);
            ToolStripButtonFilterClear.ToolTipText = "Limpiar búsqueda";
            ToolStripButtonFilterClear.Click += ToolStripButtonSearchClear_Click;
            // 
            // ToolStripItemsCounter
            // 
            ToolStripItemsCounter.BackColor = Color.FromArgb(255, 224, 192);
            ToolStripItemsCounter.Dock = DockStyle.Fill;
            ToolStripItemsCounter.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripItemsCounter.Items.AddRange(new ToolStripItem[] { ToolStripLabelItemsCounter });
            ToolStripItemsCounter.Location = new Point(0, 39);
            ToolStripItemsCounter.Name = "ToolStripItemsCounter";
            ToolStripItemsCounter.Size = new Size(34, 25);
            ToolStripItemsCounter.TabIndex = 3;
            // 
            // ToolStripLabelItemsCounter
            // 
            ToolStripLabelItemsCounter.Alignment = ToolStripItemAlignment.Right;
            ToolStripLabelItemsCounter.Name = "ToolStripLabelItemsCounter";
            ToolStripLabelItemsCounter.Size = new Size(0, 22);
            // 
            // FormSettlements
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(730, 333);
            Controls.Add(DataGridViewMain);
            Controls.Add(FlowLayoutPanelToolbars);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormSettlements";
            Text = "Establecimientos";
            FormClosed += This_FormClosed;
            Load += This_Load;
            ((System.ComponentModel.ISupportInitialize)DataGridViewMain).EndInit();
            FlowLayoutPanelToolbars.ResumeLayout(false);
            FlowLayoutPanelToolbars.PerformLayout();
            ToolStripMain.ResumeLayout(false);
            ToolStripMain.PerformLayout();
            ToolStripNamesFilter.ResumeLayout(false);
            ToolStripNamesFilter.PerformLayout();
            ToolStripItemsCounter.ResumeLayout(false);
            ToolStripItemsCounter.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView DataGridViewMain;
        private DataGridViewTextBoxColumn DataGridViewColumnNombre;
        private DataGridViewTextBoxColumn DataGridViewColumnEntidad;
        private DataGridViewTextBoxColumn DataGridViewColumnTelefonoMovil;
        private FlowLayoutPanel FlowLayoutPanelToolbars;
        private ToolStrip ToolStripMain;
        private ToolStripButton ToolStripButtonAdd;
        private ToolStripButton ToolStripButtonView;
        private ToolStripButton ToolStripButtonEdit;
        private ToolStripButton ToolStripButtonDelete;
        private ToolStrip ToolStripNamesFilter;
        private ToolStripLabel ToolStripLabelFilter;
        private ToolStripComboBox ToolStripComboBoxFilterType;
        private ToolStripTextBox ToolStripTextBoxFilter;
        internal ToolStripButton ToolStripButtonFilterClear;
        private ToolStrip ToolStripItemsCounter;
        private ToolStripLabel ToolStripLabelItemsCounter;
    }
}