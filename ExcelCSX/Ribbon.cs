using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;

namespace ExcelCSX
{
    public partial class Ribbon
    {
        private void Ribbon_Load(object sender, RibbonUIEventArgs e)
        {
            try
            {
                if (Core.Config.UseLastFolder)
                {
                    SetDropDownList(Core.Config.CurrentFolderPath);
                }
                else
                {
                    SetDropDownList(Core.Config.UserDefinedFolderPath);
                }

                AddShortcutButtons(Core.Config.ShortcutButtons);
            }
            catch (Exception ex)
            {
                //想定外のエラー
            }
        }

        /// <summary>
        /// フォルダ選択ボタン
        /// ※フォルダ選択時、Core.Config.CurrentFolderも書き換える
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSelectFolder_Click(object sender, RibbonControlEventArgs e)
        {
            var dialog = new FolderSelect.FolderSelectDialog();
            dialog.InitialDirectory = Core.Config.CurrentFolderPath;
            if (dialog.ShowDialog(IntPtr.Zero))
            {
                SetDropDownList(dialog.FileName); //FileNameという名称だが、実体はフォルダPath
                Core.Config.CurrentFolderPath = dialog.FileName;
            }
        }

        /// <summary>
        /// 指定したフォルダパス下のcsxファイルをdropdownlistのItemに設定する。
        /// Item
        ///  .label はファイル名
        ///  .screentip にフルパス
        /// </summary>
        /// <param name="folderPath"></param>
        private void SetDropDownList(string folderPath)
        {
            var files = Directory.GetFiles(folderPath, "*.csx").ToList();
            dropDownScriptFile.Items.Clear(); //一旦初期化
            files.ForEach(file => {
                var item = Factory.CreateRibbonDropDownItem();
                item.Label = Path.GetFileName(file); //ファイル名をLabelに
                item.ScreenTip = file; //フルパスをScreentipに
                dropDownScriptFile.Items.Add(item);
            });

            SetCurrentDirectry();
        }

        private void SetCurrentDirectry()
        {
            Environment.CurrentDirectory = Core.Config.CurrentFolderPath;
        }

        /// <summary>
        /// 実行ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void buttonRun_Click(object sender, RibbonControlEventArgs e)
        {
            buttonRun.Enabled = false;

            var path = GetSelectedItemPath();
            if (!File.Exists(path))
            {
                MessageBox.Show($"{path} is not exists!");
                return; //フォルダ選択→実行までの間に削除された場合
            }

            var code = File.ReadAllText(path);
            var cs = new CsScript(code);
            var excel = Globals.ThisAddIn.Application;
            var errorMessage = await cs.Execute(excel);
            if (errorMessage != "") MessageBox.Show(errorMessage);

            buttonRun.Enabled = true;
        }

        /// <summary>
        /// Comboboxで選択されているItemのPathを取得する
        /// </summary>
        /// <returns></returns>
        private string GetSelectedItemPath()
        {
            return dropDownScriptFile.SelectedItem.ScreenTip;
        }

        /// <summary>
        /// エディタで編集
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEdit_Click(object sender, RibbonControlEventArgs e)
        {
            if (!File.Exists(Core.Config.EditorPath))
            {
                MessageBox.Show($"{Core.Config.EditorPath} is not exists!");
                return;
            }

            var arg = Core.Config.EditorArgument != "" ? $" {Core.Config.EditorArgument} " : "";
            var p = Process.Start(Core.Config.EditorPath, arg + @"""" + dropDownScriptFile.SelectedItem.ScreenTip + @"""");
        }

        /// <summary>
        /// スクリプトを新規作成
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonNewScript_Click(object sender, RibbonControlEventArgs e)
        {
            if (!File.Exists(Core.Config.EditorPath))
            {
                MessageBox.Show($"{Core.Config.EditorPath} is not exists!");
                return;
            }

            var p = Process.Start(Core.Config.EditorPath);
        }

        /// <summary>
        /// 選択されたフォルダのcsxファイルをリロード
        /// TODO: 将来的には、フォルダの変更を監視して自動リロードにする
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonReload_Click(object sender, RibbonControlEventArgs e)
        {
            if (!Directory.Exists(Core.Config.CurrentFolderPath))
            {
                MessageBox.Show($"{Core.Config.CurrentFolderPath} is not exists!");
                return;
            }

            SetDropDownList(Core.Config.CurrentFolderPath);
        }

        private void buttonOptions_Click(object sender, RibbonControlEventArgs e)
        {
            var form = new FormOptions();
            form.ShowDialog();

            AddShortcutButtons(Core.Config.ShortcutButtons);
        }

        public void AddShortcutButtons(List<ButtonConfig> buttonConfigs)
        {
            var ribbonButtons = new[] { button1, button2, button3, button4, button5, button6 };
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(Ribbon));

            for(var i = 0; i<6;i++)
            {
                var buttonRun = ribbonButtons[i];
                if (buttonConfigs.Count > i)
                {
                    var button = buttonConfigs[i];
                    buttonRun.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeRegular;
                    buttonRun.Image = ((System.Drawing.Image)(resources.GetObject("buttonRun.Image")));
                    buttonRun.Label = button.DisplayName;
                    buttonRun.ShowImage = true;
                    buttonRun.Click += new RibbonControlEventHandler(async (_, __) => {
                        buttonRun.Enabled = false;
                        groupShortcut.Items.ToList().ForEach(item => item.Enabled = false);

                        var path = button.ScriptPath;
                        if (!File.Exists(path))
                        {
                            MessageBox.Show($"{path} is not exists!");
                            return; //フォルダ選択→実行までの間に削除された場合
                        }

                        var code = File.ReadAllText(path);
                        var cs = new CsScript(code);
                        var excel = Globals.ThisAddIn.Application;
                        var errorMessage = await cs.Execute(excel);
                        if (errorMessage != "") MessageBox.Show(errorMessage);

                        groupShortcut.Items.ToList().ForEach(item => item.Enabled = true);
                        buttonRun.Enabled = true;
                    });
                }
                else
                {
                    buttonRun.Visible = false;
                }

            }
        }

    }
}
