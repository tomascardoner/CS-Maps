using static CardonerSistemas.Framework.Database.Ado.SqlServer;

namespace CSMaps
{
    internal static class Program
    {
        internal const string ApplicationTitle = "CS-Maps";

#pragma warning disable S2223 // Non-constant static fields should not be visible
        internal static AppearanceConfig AppearanceConfig;
        internal static GeneralConfig GeneralConfig;
        internal static CardonerSistemas.Framework.Database.Ado.SqlServer.DatabaseConfig DatabaseConfig;

        internal static Main.FormMdi formMdi;
#pragma warning restore S2223 // Non-constant static fields should not be visible

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(Constants.SyncfusionLicenseKey);

            // Cargo los archivos de configuración de la aplicación
            if (!Configuration.LoadFiles())
            {
                return;
            }

            // Obtengo el connection string para las conexiones de ADO .NET
            CardonerSistemas.Framework.Database.Ado.SqlServer database = new();
            if (!database.SetProperties(DatabaseConfig.Datasource, DatabaseConfig.Database, DatabaseConfig.UserId, DatabaseConfig.Password, DatabaseConfig.ConnectTimeout, DatabaseConfig.ConnectRetryCount, DatabaseConfig.ConnectRetryInterval))
            {
                return;
            }
            if (!database.PasswordUnencrypt(Constants.PublicEncryptionPassword, out string resultMessage))
            {
                MessageBox.Show(string.Format(Properties.Resources.StringDatabasePasswordUnencryptionError, resultMessage), Program.ApplicationTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            database.CreateConnectionString();
            Models.CSMapsContext.ConnectionString = database.ConnectionString;

            formMdi = new();
            Application.Run(formMdi);
        }

        static public void TerminateApplication()
        {
            if (formMdi != null)
            {
                CardonerSistemas.Framework.Base.Forms.MdiChildCloseAll(formMdi);
                CardonerSistemas.Framework.Base.Forms.CloseAll("FormMdi");
            }

            // Config
            AppearanceConfig = null;
            DatabaseConfig = null;
            GeneralConfig = null;
        }
    }
}