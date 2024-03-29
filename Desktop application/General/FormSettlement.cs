﻿using CardonerSistemas.Framework.Base;
using CardonerSistemas.Framework.Controls;

namespace CSMaps.General
{
    public partial class FormSettlement : Form
    {

        #region Declarations

        private const string entityNameSingular = "establecimiento";
        private const bool entityIsFemale = false;

        private readonly bool isLoading;
        private readonly bool isNew;
        private bool isEditMode;

        private Models.CSMapsContext context = new();
        private Models.Establecimiento establecimiento;

        #endregion

        #region Form stuff

        public FormSettlement(bool editMode, short idEstablecimiento)
        {
            InitializeComponent();

            isLoading = true;
            isNew = (idEstablecimiento == 0);
            isEditMode = editMode;

            if (isNew)
            {
                establecimiento = new();
                InitializeNewObjectData();
                context.Establecimientos.Add(establecimiento);
            }
            else
            {
                establecimiento = context.Establecimientos.Find(idEstablecimiento);
            }

            InitializeFormAndControls();
            SetDataToUserInterface();
            isLoading = false;

            ChangeEditMode();
        }

        private void InitializeFormAndControls()
        {
            SetAppearance();
            Common.Lists.GetEntidades(ComboBoxEntidad, context, true);
        }

        private void SetAppearance()
        {
            this.Text = entityNameSingular.FirstCharToUpperCase();
            Forms.SetFont(this, Program.AppearanceConfig.Font);
        }

        private void ChangeEditMode()
        {
            if (isLoading)
            {
                return;
            }

            ToolStripButtonSave.Visible = isEditMode;
            ToolStripButtonCancel.Visible = isEditMode;
            ToolStripButtonEdit.Visible = !isEditMode;
            ToolStripButtonClose.Visible = !isEditMode;

            TextBoxNombre.ReadOnly = !isEditMode;
            ComboBoxEntidad.Enabled = isEditMode;
            TextBoxTelefonoMovil.ReadOnly = !isEditMode;
        }

        private void This_FormClosed(object sender, FormClosedEventArgs e)
        {
            context.Dispose();
            context = null;
            establecimiento = null;
            this.Dispose();
        }

        #endregion

        #region User interface data

        private void SetDataToUserInterface()
        {
            Values.ToTextBox(TextBoxIdEstablecimiento, establecimiento.IdEstablecimiento);
            Values.ToTextBox(TextBoxNombre, establecimiento.Nombre);
            Values.ToComboBox(ComboBoxEntidad, establecimiento.IdEntidad);
            Values.ToTextBox(TextBoxTelefonoMovil, establecimiento.TelefonoMovil);
            Values.ToTextBoxAsShortDateTime(TextBoxUltimaActualizacion, establecimiento.UltimaActualizacion);
        }

        private void SetDataToEntityObject()
        {
            establecimiento.Nombre = Values.TextBoxToString(TextBoxNombre);
            establecimiento.IdEntidad = Values.ComboBoxToShort(ComboBoxEntidad);
            establecimiento.TelefonoMovil = Values.TextBoxToString(TextBoxTelefonoMovil);
        }

        #endregion

        #region Controls events

        private void FormEntity_KeyPress(object sender, KeyPressEventArgs e)
        {
            Common.Forms.This_KeyPress(e, isEditMode, ActiveControl, ToolStripButtonClose, ToolStripButtonSave, ToolStripButtonCancel, null);
        }

        private void TextBoxs_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).SelectAll();
        }

        #endregion

        #region Main toolbar

        private void ToolStripButtonSave_Click(object sender, EventArgs e)
        {
            if (!VerifyData())
            {
                return;
            }

            if (!CompleteNewObjectData())
            {
                return;
            }

            SetDataToEntityObject();

            if (context.ChangeTracker.HasChanges())
            {
                this.Cursor = Cursors.WaitCursor;
                establecimiento.UltimaActualizacion = System.DateTime.Now;
                try
                {
                    context.SaveChanges();
                    Program.formMdi.formSettlements?.ReadData(establecimiento.IdEstablecimiento);
                }
                catch (System.Data.Entity.Infrastructure.DbUpdateException dbUEx)
                {
                    this.Cursor = Cursors.Default;
                    Common.DBErrors.DbUpdateException(dbUEx, entityNameSingular, entityIsFemale, isNew ? Properties.Resources.StringActionAdd : Properties.Resources.StringActionEdit);
                    return;
                }
                catch (Exception ex)
                {
                    this.Cursor = Cursors.Default;
                    Common.DBErrors.OtherUpdateException(ex, entityNameSingular, entityIsFemale, isNew ? Properties.Resources.StringActionAdd : Properties.Resources.StringActionEdit);
                    return;
                }
            }

            this.Close();
        }

        private void ToolStripButtonCancel_Click(object sender, EventArgs e)
        {
            if (Common.Forms.ButtonCancel_Click(context))
            {
                this.Close();
            }
        }

        private void ToolStripButtonEdit_Click(object sender, EventArgs e)
        {
            isEditMode = true;
            ChangeEditMode();
        }

        private void ToolStripButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region New object initialization

        private void InitializeNewObjectData()
        {
            establecimiento.UltimaActualizacion = System.DateTime.Now;
        }

        private bool CompleteNewObjectData()
        {
            if (!isNew)
            {
                return true;
            }

            try
            {
                using Models.CSMapsContext newIdContext = new();
                if (context.Establecimientos.Any())
                {
                    establecimiento.IdEstablecimiento = (short)(newIdContext.Establecimientos.Max(e => e.IdEstablecimiento) + 1);
                }
                else
                {
                    establecimiento.IdEstablecimiento = 1;
                }
                return true;
            }
            catch (Exception ex)
            {
                Error.ProcessException(ex, string.Format(Properties.Resources.StringEntityNewValuesErrorFemale, entityNameSingular));
                return false;
            }
        }

        #endregion

        #region Extra stuff

        private bool VerifyData()
        {
            if (string.IsNullOrWhiteSpace(TextBoxNombre.Text))
            {
                MessageBox.Show(string.Format(entityIsFemale ? Properties.Resources.StringEntityDataVerificationMaleFieldRequiredFemale : Properties.Resources.StringEntityDataVerificationMaleFieldRequiredMale, entityNameSingular, "nombre"), Program.ApplicationTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (ComboBoxEntidad.SelectedIndex == -1)
            {
                MessageBox.Show(string.Format(entityIsFemale ? Properties.Resources.StringEntityDataVerificationFemaleFieldRequiredFemale : Properties.Resources.StringEntityDataVerificationFemaleFieldRequiredMale, entityNameSingular, "entidad"), Program.ApplicationTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        #endregion

    }
}
