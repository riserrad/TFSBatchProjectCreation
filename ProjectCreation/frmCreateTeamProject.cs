using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Resources;
using System.Threading;
using System.Windows.Forms;
<<<<<<< HEAD
<<<<<<< HEAD
=======
using ProjectCreation.Properties;
>>>>>>> 6cf346c... Localization completed
=======
>>>>>>> 2e16eb6... version 1.0.0.0

namespace ProjectCreation
{
    public partial class FrmCreateTeamProject : Form
    {
        private static ResourceManager _resourceManager;

        public FrmCreateTeamProject()
        {
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> 6bde0f1... adjusting process template label
#if DEBUG
            Thread.CurrentThread.CurrentUICulture = MessageBox.Show("Choose Yes for pt-BR or No for en-US", "Choose Language", MessageBoxButtons.YesNo) ==
                                                    DialogResult.Yes ? new CultureInfo("pt-BR") : new CultureInfo("en-US");
#endif
<<<<<<< HEAD
=======
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("pt-BR");
>>>>>>> 6cf346c... Localization completed
=======
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
>>>>>>> a13d8b9... continuing combo to select process template

=======
>>>>>>> f9ae1e8... localization adjustments before first publish\
=======

>>>>>>> 6bde0f1... adjusting process template label
            InitializeComponent();

            txtCaminho.Text = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "teamprojects.txt");
            txtLogPath.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
#if DEBUG
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
            txtCollectionUrl.Text = "http://vsalm:8080/tfs/FabrikamFiberCollection";
#endif

            _resourceManager = new ResourceManager("ProjectCreation.Resource", this.GetType().Assembly);
=======
            txtCollectionUrl.Text = "http://tfs-aasp:8080/tfs/FabrikamFiberCollection";
=======
            txtCollectionUrl.Text = "http://tfs-server:8080/tfs/FabrikamFiberCollection";
>>>>>>> 5b435bc... adjusting some parameters
=======
            txtCollectionUrl.Text = "http://vsalm:8080/tfs/FabrikamFiberCollection";
>>>>>>> 22661f7... adjusting some parameters
#endif

<<<<<<< HEAD
            _resourceManager = new ResourceManager(this.GetType());
>>>>>>> 6cf346c... Localization completed
=======
            _resourceManager = new ResourceManager("ProjectCreation.Resource", this.GetType().Assembly);
>>>>>>> c389bb2... stable resource files
        }

        private void btnCriar_click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCollectionUrl.Text))
            {
                MessageBox.Show(_resourceManager.GetString("FrmCriarTeamProject_txtCollectionUrl_Precisa_Ser_Informada"), _resourceManager.GetString("MessageBox_TituloGenericoErro"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCollectionUrl.Focus();
                return;
            }
<<<<<<< HEAD
<<<<<<< HEAD

=======
            
>>>>>>> 6cf346c... Localization completed
=======

>>>>>>> 0bdf4ed... icons and texts
            if (!File.Exists(txtCaminho.Text))
            {
                MessageBox.Show(string.Format(_resourceManager.GetString("FrmCriarTeamProject_InvalidListPath"), txtCaminho.Text), _resourceManager.GetString("MessageBox_TituloGenericoErro"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtLogPath.Text))
            {
                MessageBox.Show(_resourceManager.GetString("FrmCriarTeamProject_txtLogPath_Required"), _resourceManager.GetString("MessageBox_TituloGenericoErro"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Directory.Exists(txtLogPath.Text))
            {
                var result = MessageBox.Show(_resourceManager.GetString("FrmCriarTeamProject_btnCriar_txtLogPath_DirectoryNotFoud_Create"), _resourceManager.GetString("MessageBox_TituloGenericoErro"), MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    Directory.CreateDirectory(txtLogPath.Text);
                }
                else
                {
                    return;
                }
            }
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> a13d8b9... continuing combo to select process template

            if (string.IsNullOrWhiteSpace(cmbProcessTemplates.Text))
            {
                MessageBox.Show(_resourceManager.GetString("FrmCriarTeamProject_ProcessTemplateNotSelected"),
                    _resourceManager.GetString("MessageBox_TituloGenericoErro"), MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }
<<<<<<< HEAD
<<<<<<< HEAD

=======
=======
>>>>>>> a13d8b9... continuing combo to select process template
            
>>>>>>> 6cf346c... Localization completed
=======

>>>>>>> 0bdf4ed... icons and texts
            string validacao;

            var lines = ReadFile(txtCaminho.Text, out validacao);

            if (!string.IsNullOrWhiteSpace(validacao))
            {
                MessageBox.Show(string.Format(_resourceManager.GetString("FrmCriarTeamProject_InvalidListFile"), "\r\n", validacao),
                    _resourceManager.GetString("MessageBox_TituloGenericoErro"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            const string executavel = "tfpt.exe";

<<<<<<< HEAD
<<<<<<< HEAD
            var comando = string.Format(@"createteamproject /collection:{0} /teamproject:""[teamproject]"" /processtemplate:""{2}"" /sourcecontrol:New /log:""{1}"" /noportal", txtCollectionUrl.Text, txtLogPath.Text, cmbProcessTemplates.Text);
=======
            var comando = string.Format(@"createteamproject /collection:{0} /teamproject:""[teamproject]"" /processtemplate:""MSF for Agile Software Development 2013.3"" /sourcecontrol:New /log:""{1}"" /noportal", txtCollectionUrl.Text, txtLogPath.Text);
>>>>>>> 6cf346c... Localization completed
=======
            var comando = string.Format(@"createteamproject /collection:{0} /teamproject:""[teamproject]"" /processtemplate:""{2}"" /sourcecontrol:New /log:""{1}"" /noportal", txtCollectionUrl.Text, txtLogPath.Text, cmbProcessTemplates.Text);
>>>>>>> d546353... parametrizing process template

            foreach (var line in lines)
            {
                var teamProject = line.Split('|')[0];
                var portal = line.Split('|')[1];

                var comandoFinal = comando.Replace("[teamproject]", teamProject);

                if (portal.Equals(_resourceManager.GetString("FrmCriarTeamProject_TextFile_Yes")))
                {
                    comandoFinal = comandoFinal.Replace("/noportal", string.Empty);
                }

                try
                {
                    ExecutarFerramenta(executavel, comandoFinal);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(string.Format(_resourceManager.GetString("FrmCriarTeamProject_CouldNotCreateTeamProject"), teamProject));
                }
            }
        }

        private static IEnumerable<string> ReadFile(string filePath, out string message)
        {
            var lines = File.ReadAllLines(filePath);
            message = string.Empty;
            var messages = new List<string>();
            var columns = false;
            var yesNo = false;
<<<<<<< HEAD
<<<<<<< HEAD
            var emptyLines = false;
=======
>>>>>>> 6cf346c... Localization completed
=======
            var emptyLines = false;
>>>>>>> 0bdf4ed... icons and texts

            if (lines.Length == 0)
            {
                messages.Add(_resourceManager.GetString("FrmCriarTeamProject_txtCaminho_Arquivo_Vazio"));
            }

            foreach (var line in lines)
            {
                var split = line.Split('|');

<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> 0bdf4ed... icons and texts
                if (string.IsNullOrWhiteSpace(line) && !emptyLines)
                {
                    messages.Add(_resourceManager.GetString("FrmCriarTeamProject_EmptyLines"));
                    emptyLines = true;
                    continue;
                }
                
<<<<<<< HEAD
=======
>>>>>>> 6cf346c... Localization completed
=======
>>>>>>> 0bdf4ed... icons and texts
                if (split.Length < 2 && !columns)
                {
                    messages.Add(_resourceManager.GetString("FrmCriarTeamProject_YourFileContainsLessThan2Lines"));
                    columns = true;
<<<<<<< HEAD
<<<<<<< HEAD

                    continue;
                }

                if (split.Length == 2)
                {
                    if (split[1].ToLower().Equals(_resourceManager.GetString("FrmCriarTeamProject_TextFile_Yes").ToLower())
                        || split[1].ToLower().Equals(_resourceManager.GetString("FrmCriarTeamProject_TextFile_No").ToLower())
                        || yesNo)
                    {
                        continue;
                    }

                    messages.Add(_resourceManager.GetString("FrmCriarTeamProject_InvalidSharepointSiteFlag"));
                    yesNo = true;
                }
=======
=======

                    continue;
>>>>>>> 0bdf4ed... icons and texts
                }

                if (split.Length == 2)
                {
                    if (split[1].ToLower().Equals(_resourceManager.GetString("FrmCriarTeamProject_TextFile_Yes").ToLower())
                        || split[1].ToLower().Equals(_resourceManager.GetString("FrmCriarTeamProject_TextFile_No").ToLower())
                        || yesNo)
                    {
                        continue;
                    }

                    messages.Add(_resourceManager.GetString("FrmCriarTeamProject_InvalidSharepointSiteFlag"));
                    yesNo = true;
                }
<<<<<<< HEAD

                messages.Add(_resourceManager.GetString("FrmCriarTeamProject_YourFileContainsInvalidLines"));
                yesNo = true;
>>>>>>> 6cf346c... Localization completed
=======
>>>>>>> 0bdf4ed... icons and texts
            }

            if (messages.Count > 0)
            {
                message = messages.Aggregate(message, (current, individualMessage) => current + string.Format("\r\n{0}", individualMessage));
            }

            return lines;
        }

<<<<<<< HEAD
<<<<<<< HEAD
        private static void ExecutarFerramenta(string fileName, string arguments)
        {
=======
        private static void ExecutarFerramenta(string fileName, string arguments){
>>>>>>> 6cf346c... Localization completed
=======
        private static void ExecutarFerramenta(string fileName, string arguments)
        {
>>>>>>> 0bdf4ed... icons and texts
            var info = new ProcessStartInfo
            {
                FileName = fileName,
                Arguments = arguments,
                WorkingDirectory = @"%programfiles(x86)%\Microsoft Team Foundation Server 2013 Power Tools"
            };
<<<<<<< HEAD
<<<<<<< HEAD

=======
            
>>>>>>> 6cf346c... Localization completed
=======

>>>>>>> 0bdf4ed... icons and texts
            var process = Process.Start(info);

            var result = string.Empty;

            if (process != null)
            {
                process.BeginOutputReadLine();
                result = process.StandardOutput.ReadToEnd();
                process.WaitForExit();
            }

            MessageBox.Show(result);
        }

        private void txtCaminho_Click(object sender, EventArgs e)
        {
            var openFile = new OpenFileDialog
            {
                InitialDirectory = Path.GetDirectoryName(txtCaminho.Text),
                Filter = _resourceManager.GetString("FrmCriarTeamProject_txtCaminho_FilterFiles")
            };

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                txtCaminho.Text = openFile.FileName;
            }
        }

        private void txtCaminho_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLogPath_Click(object sender, EventArgs e)
        {
            folderBrowsing.RootFolder = Environment.SpecialFolder.Desktop;

            if (folderBrowsing.ShowDialog() == DialogResult.OK)
            {
                txtLogPath.Text = folderBrowsing.SelectedPath;
            }
        }
    }
}
