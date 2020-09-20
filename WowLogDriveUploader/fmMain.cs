using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System.Threading;
using System.Configuration;
using System.Net.Http;


namespace WowLogDriveUploader
{
    public partial class WowLogDriveUploader : Form
    {
        fmConfig ventanaConfig;

        string ruta_log;
        string id_carpeta_drive;
        string tiempo;
        string client_id;
        string client_secret;

        private static readonly HttpClient client = new HttpClient();

        public WowLogDriveUploader()
        {
            InitializeComponent();
            
            tiempo = DateTime.Now.ToString();
            CheckForIllegalCrossThreadCalls = false; // Nos saltamos un error para modificar tbEstado desde subprocesos

        }

        private void WowLogDriveUploader_Load(object sender, EventArgs e)
        {
            recogerValoresConfig();

            if (ruta_log == "" || id_carpeta_drive == "" || client_id == "" || client_secret == "")
                tbEstado.Text = "Configure los parámetros.";
            else
                tbEstado.Text = "Listo para empezar la subida.";
        }

        private void tsbConfigurar_Click(object sender, EventArgs e)
        {
            ventanaConfig = new fmConfig();
            ventanaConfig.ShowDialog();
            ventanaConfig.Dispose();
        }

        private void btSubirADrive_Click(object sender, EventArgs e)
        {
            recogerValoresConfig();

            if (ruta_log == "" || id_carpeta_drive == "" || client_id == "" || client_secret == "")
            {
                MessageBox.Show("Configure los parámetros.");
                tsbConfigurar.PerformClick();
            } else
            {
                tbEstado.Text = "Subiendo..";
                Authorize();
            }
        }

        private void recogerValoresConfig()
        {
            // Recogemos los valores del archivo de configuración
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            ruta_log = config.AppSettings.Settings["ruta_log"].Value;
            id_carpeta_drive = config.AppSettings.Settings["id_carpeta_drive"].Value;
            client_id = config.AppSettings.Settings["client_id"].Value;
            client_secret = config.AppSettings.Settings["client_secret"].Value;
        }

        private void tsbAyuda_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://developers.google.com/drive/api/v3/quickstart/dotnet");
        }

        private void Authorize()
        {
            string[] scopes = new string[] { DriveService.Scope.Drive, DriveService.Scope.DriveFile, };
            var clientId = client_id;      // From https://console.developers.google.com  
            var clientSecret = client_secret;          // From https://console.developers.google.com  
            // here is where we Request the user to give us access, or use the Refresh Token that was previously stored in %AppData%  
            var credential = GoogleWebAuthorizationBroker.AuthorizeAsync
            (
                new ClientSecrets
                {
                    ClientId = clientId,
                    ClientSecret = clientSecret
                },
                scopes,
                Environment.UserName,
                CancellationToken.None,
                new FileDataStore("MyAppsToken")
            ).Result;
            //Once consent is recieved, your token will be stored locally on the AppData directory, so that next time you wont be prompted for consent.   

            DriveService service = new DriveService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = "AppName",

            });
            service.HttpClient.Timeout = TimeSpan.FromMinutes(100);
            //Long Operations like file uploads might timeout. 100 is just precautionary value, can be set to any reasonable value depending on what you use your service for  

            // team drive root https://drive.google.com/drive/folders/0AAE83zjNwK-GUk9PVA   

            var response = uploadFile(service);
            // Third parameter is empty it means it would upload to root directory, if you want to upload under a folder, pass folder's id here.
        }

        public Google.Apis.Drive.v3.Data.File uploadFile(DriveService _service)
        {
            string _uploadFile = ruta_log;
            string _parent = id_carpeta_drive;
            string _descrp = "Combatlog subido con WowLogDriveUploader";
            if (System.IO.File.Exists(_uploadFile))
            {
                Google.Apis.Drive.v3.Data.File body = new Google.Apis.Drive.v3.Data.File();
                body.Name = tbNombreArchivo.Text != "" ? tbNombreArchivo.Text + ".txt" : tiempo + ".txt";
                body.Description = _descrp;
                body.MimeType = GetMimeType(_uploadFile);
                body.Parents = new List<string> { _parent };// UN comment if you want to upload to a folder(ID of parent folder need to be send as paramter in above method)
                byte[] byteArray = System.IO.File.ReadAllBytes(_uploadFile);
                System.IO.MemoryStream stream = new System.IO.MemoryStream(byteArray);
                try
                {
                    FilesResource.CreateMediaUpload request = _service.Files.Create(body, stream, GetMimeType(_uploadFile));
                    request.SupportsTeamDrives = true;
                    // You can bind event handler with progress changed event and response recieved(completed event)
                    //request.ProgressChanged += Request_ProgressChanged;
                    request.ResponseReceived += Request_ResponseReceived;
                    request.Upload();
                    return request.ResponseBody;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "Error Occured");
                    return null;
                }
            }
            else
            {
                tbEstado.Text = "No existe el archivo.";
                MessageBox.Show("El archivo " + ruta_log + " no existe.", "404");
                return null;
            }
        }
        /*
        private void Request_ProgressChanged(Google.Apis.Upload.IUploadProgress obj)
        {
            //tbEstado.Text = obj.Status.ToString();
        }*/

        private void Request_ResponseReceived(Google.Apis.Drive.v3.Data.File obj)
        {
            if (obj != null)
                tbEstado.Text = "Log subido correctamente.";
            else
                tbEstado.Text = "Error.";
        }

        private static string GetMimeType(string fileName)
        {
            string mimeType = "application/unknown";
            string ext = System.IO.Path.GetExtension(fileName).ToLower();
            Microsoft.Win32.RegistryKey regKey = Microsoft.Win32.Registry.ClassesRoot.OpenSubKey(ext); 
            if (regKey != null && regKey.GetValue("Content Type") != null) 
                mimeType = regKey.GetValue("Content Type").ToString();
            System.Diagnostics.Debug.WriteLine(mimeType);
            return mimeType;
        }
    }
}