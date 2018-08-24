using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace ExcelCSX
{
    public class Config
    {
        /// <summary>
        /// 編集に使うエディタ
        /// </summary>
        public string EditorPath = @"C:\Program Files (x86)\Microsoft VS Code\code.exe";
        /// <summary>
        /// エディタ起動時に与えるパラメータ
        /// </summary>
        public string EditorArgument = @"";
        /// <summary>
        /// 起動時に、前回終了時のフォルダを読み込むか
        /// （falseの場合、ユーザーが指定したフォルダ）
        /// </summary>
        public bool UseLastFolder = true;
        /// <summary>
        /// 現在選択されているフォルダ
        /// </summary>
        public string CurrentFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
        /// <summary>
        /// ユーザが指定したデフォルトフォルダ
        /// </summary>
        public string UserDefinedFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
        /// <summary>
        /// ショートカットボタンの設定
        /// </summary>
        public List<ButtonConfig> ShortcutButtons = new List<ButtonConfig>();

        #region for developer
        /// <summary>
        /// Configファイルのパス
        /// ユーザAppDataフォルダ内
        /// ("C:\\Users\\{ユーザ名}\\AppData\\Roaming\\Microsoft Corporation\\Microsoft Office {Ver.}\\{Ver番号}")
        /// </summary>
        private static string ConfigFilePath
        {
            get { return Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\ExcelCSX\ExcelCSX.xml"; }
        }
        /// <summary>
        /// Config.xmlファイルの保存
        /// </summary>
        public void Save()
        {
            Files.SaveXML<Config>(ConfigFilePath, this);
        }
        /// <summary>
        /// Config.xmlファイルの読み込み
        /// 読み込み失敗時はConfigクラスを初期化
        /// </summary>
        /// <returns></returns>
        public static Config Load()
        {
            try
            {
                var existsFile = File.Exists(ConfigFilePath);
                return existsFile ? Files.LoadXML<Config>(ConfigFilePath, true) : new Config();
            }
            catch (Exception)
            {
                MessageBox.Show(
                    @"
                    設定ファイル(config.xml)の読み込みに失敗しました。
                    設定を初期化した状態で起動します。"
                    , "読み込みエラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return new Config();
            }
        }
        #endregion
    }

    [Serializable]
    public class ButtonConfig
    {
        public string DisplayName { get; set; }
        public string ScriptPath { get; set; }
    }

    static class Files
    {
        /// <summary>
        /// XMLファイルへオブジェクトをシリアライズします。
        /// </summary>
        /// <typeparam name="Type">シリアライズする型</typeparam>
        /// <param name="fpath">保存先のファイルパス</param>
        /// <param name="cfgclass">シリアライズするオブジェクト</param>
        public static void SaveXML<Type>(string fpath, Type cfgclass)
        {
            var xsz = new XmlSerializer(typeof(Type));
            using (var fs = new FileStream(fpath, FileMode.Create, FileAccess.Write))
            {
                xsz.Serialize(fs, cfgclass);
            }
        }

        /// <summary>
        /// XMLファイルからオブジェクトをデシリアライズします。
        /// </summary>
        /// <typeparam name="Type">デシリアライズする型</typeparam>
        /// <param name="fpath">読込先のファイルパス</param>
        /// <param name="raiseFileNotFoundException">ファイルが存在しないときにFileNotFoundExceptionを発生させるか</param>
        /// <returns>デシリアライズしたオブジェクト</returns>
        public static Type LoadXML<Type>(string fpath, bool raiseFileNotFoundException)
        {
            if (!File.Exists(fpath))
            {
                if (raiseFileNotFoundException)
                    throw new FileNotFoundException("ファイル " + fpath + "が見つかりません。");
                return default(Type);
            }

            var xsz = new XmlSerializer(typeof(Type));
            using (var fs = new FileStream(fpath, FileMode.Open, FileAccess.Read))
            {
                return (Type)xsz.Deserialize(fs);
            }
        }
    }
}