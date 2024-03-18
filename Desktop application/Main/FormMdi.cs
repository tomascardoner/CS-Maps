﻿using CardonerSistemas.Framework.Base;

namespace CSMaps.Main
{
    public partial class FormMdi : Form
    {

        #region Declarations

        internal General.FormEntities formEntities;
        internal General.FormSettlements formSettlements;
        internal FormImport formImport;

        #endregion

        #region Form stuff

        public FormMdi()
        {
            InitializeComponent();
        }

        private void SetAppearance()
        {
            this.Cursor = Cursors.AppStarting;
            this.Icon = Properties.Resources.IconApplication;
            this.Text = Program.ApplicationTitle;
            ToolStripMenuItemHelpAbout.Text = "&Acerca de " + Program.ApplicationTitle + "...";
        }

        private void This_Load(object sender, EventArgs e)
        {
            SetAppearance();
        }

        private void This_Closing(object sender, FormClosingEventArgs e)
        {
            if (!(e.CloseReason == CloseReason.ApplicationExitCall || e.CloseReason == CloseReason.TaskManagerClosing || e.CloseReason == CloseReason.WindowsShutDown))
            {
                if (MessageBox.Show("¿Desea salir de la aplicación?", Program.ApplicationTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                {
                    e.Cancel = true;
                    return;
                }
            }
            Program.TerminateApplication();
        }

        #endregion

        #region Menu commands

        private void ToolStripMenuItemFileExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ToolStripMenuItemWindowCloseAll_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void ToolStripMenuItemHelpAbout_Click(object sender, EventArgs e)
        {
            //FormAboutBox formAboutBox = new();
            //formAboutBox.ShowDialog(this);
            //formAboutBox.Dispose();
        }

        #endregion

        #region Toolbar commands

        private void ToolStripButtonEntities_Click(object sender, EventArgs e)
        {
            formEntities ??= new();
            ShowMdiForm(formEntities);
        }

        private void ToolStripButtonSettlements_Click(object sender, EventArgs e)
        {
            formSettlements ??= new();
            ShowMdiForm(formSettlements);
        }

        private void ToolStripButtonImport_Click(object sender, EventArgs e)
        {
            formImport ??= new() { MdiParent = this };
            formImport.Show();
        }

        #endregion

        #region Extra stuff

        private void ShowMdiForm(Form form)
        {
            Application.UseWaitCursor = true;
            this.Cursor = Cursors.WaitCursor;
            Application.DoEvents();

            Forms.MdiChildPositionAndSizeToFit(this, form);
            form.Show();
            if (form.WindowState == FormWindowState.Minimized)
            {
                form.WindowState = FormWindowState.Normal;
            }
            form.Focus();

            this.Cursor = Cursors.Default;
            Application.UseWaitCursor = false;
            Application.DoEvents();
        }

        #endregion

    }
}
