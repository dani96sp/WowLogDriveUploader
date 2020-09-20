using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Drive.v3.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System.IO;
using System.Threading;
using System.Configuration;
using System.Collections.Specialized;

namespace WowLogDriveUploader
{
    public partial class fmConfig : Form
    {
        string ruta_log;
        string id_carpeta_drive;
        string client_id;
        string client_secret;

        public fmConfig()
        {
            InitializeComponent();

            recogerValoresConfig();
        }

        private void recogerValoresConfig()
        {
            // Recogemos los valores del archivo de configuración
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            ruta_log = config.AppSettings.Settings["ruta_log"].Value;
            id_carpeta_drive = config.AppSettings.Settings["id_carpeta_drive"].Value;
            client_id = config.AppSettings.Settings["client_id"].Value;
            client_secret = config.AppSettings.Settings["client_secret"].Value;

            tbRutaLog.Text = ruta_log;
            tbIdCarpetaDrive.Text = id_carpeta_drive;
            tbClientId.Text = client_id;
            tbClientSecret.Text = client_secret;
        }


        private void btGuardarConfig_Click(object sender, EventArgs e)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings.Remove("ruta_log");
            config.AppSettings.Settings.Add("ruta_log", tbRutaLog.Text);
            config.AppSettings.Settings.Remove("id_carpeta_drive");
            config.AppSettings.Settings.Add("id_carpeta_drive", tbIdCarpetaDrive.Text);
            config.AppSettings.Settings.Remove("client_id");
            config.AppSettings.Settings.Add("client_id", tbClientId.Text);
            config.AppSettings.Settings.Remove("client_secret");
            config.AppSettings.Settings.Add("client_secret", tbClientSecret.Text);
            config.Save();

            Close();
        }
    }
}
