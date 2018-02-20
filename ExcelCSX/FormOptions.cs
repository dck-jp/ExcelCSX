using MetroFramework.Forms;
using System;
using System.IO;
using System.Windows.Forms;
using System.Deployment;
using System.Linq;

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
            metroRadioButtonUseUserDefinedFolder.Checked = !Core.Config.UseLastFolder;
            metroTextBoxFolderPath.Text = Core.Config.UserDefinedFolderPath;

            Core.Config.ShortcutButtons.ForEach(x =>
            {
                metroListViewShortcutButtons.Items.Add(new ListViewItem(new[] { x.DisplayName, x.ScriptPath }));
            });
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

            Core.Config.ShortcutButtons = metroListViewShortcutButtons.Items
                                                .Cast<ListViewItem>().Select(x =>
                                                {
                                                    var b = new ButtonConfig();
                                                    b.DisplayName = x.SubItems[0].Text;
                                                    b.ScriptPath = x.SubItems[1].Text;
                                                    return b;
                                                }).ToList();

            Close();
        }

        private void metroTextButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void metroTextButtonAddButton_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Title = "Choose the csx script file";
            dialog.Filter = "C# Script File (*.csx)|*.csx";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                metroListViewShortcutButtons.Items.Add(new ListViewItem(new[] { "", dialog.FileName }));
            }
        }

        private void metroTextButtonDeleteButton_Click(object sender, EventArgs e)
        {
            if (metroListViewShortcutButtons.SelectedIndices.Count == 0)
            {
                MessageBox.Show("No item selected");
                return;
            }
            foreach (ListViewItem item in metroListViewShortcutButtons.SelectedItems)
            {
                metroListViewShortcutButtons.Items.Remove(item);
            }
        }
    }
}