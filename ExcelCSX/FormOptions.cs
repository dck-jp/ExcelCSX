using MetroFramework.Forms;
using System;
using System.IO;
using System.Windows.Forms;
using System.Deployment;

namespace ExcelCSX
{
    public partial class FormOptions : MetroForm
    {
        public FormOptions()
        {
            InitializeComponent();
            metroTextBoxEditorPath.Text = Core.Config.EditorPath;
            metroTextBoxArg.Text = Core.Config.EditorArgument;
            metroRadioButtonUseLastFolder.Checked = Core.Config.UseLastFolder;
            metroTextBoxFolderPath.Text = Core.Config.UserDefinedFolderPath;
        }

        private void metroTextButtonBroseEditor_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Title = "Choose the editor";
            dialog.Filter = "execution file(*.exe)|*.exe";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                metroTextBoxEditorPath.Text = dialog.FileName;
            }
        }

        private void metroTextButtonBroseFolder_Click(object sender, EventArgs e)
        {
            var dialog = new FolderSelect.FolderSelectDialog();
            dialog.InitialDirectory = Core.Config.UserDefinedFolderPath;
            if (dialog.ShowDialog(IntPtr.Zero))
            {
                metroTextBoxFolderPath.Text = dialog.FileName; //FileNameという名称だが、実体はフォルダPath
            }
        }

        private void metroTextButtonSave_Click(object sender, EventArgs e)
        {
            if (!File.Exists(metroTextBoxEditorPath.Text))
            {
                MessageBox.Show("Editor is not exists!");
                return;
            }

            if (!Directory.Exists(metroTextBoxFolderPath.Text))
            {
                MessageBox.Show("User Defined Folder is not exists!");
                return;
            }

            Core.Config.EditorPath = metroTextBoxEditorPath.Text;
            Core.Config.EditorArgument = metroTextBoxArg.Text;
            Core.Config.UserDefinedFolderPath = metroTextBoxFolderPath.Text;
            Core.Config.UseLastFolder = metroRadioButtonUseLastFolder.Checked;
            Close();
        }

        private void metroTextButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}