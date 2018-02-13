namespace ExcelCSX
{
    partial class Ribbon : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public Ribbon()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary>
        /// デザイナーのサポートに必要なメソッドです。
        /// このメソッドの内容をコード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ribbon));
            this.tab1 = this.Factory.CreateRibbonTab();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.buttonOptions = this.Factory.CreateRibbonButton();
            this.buttonNewScript = this.Factory.CreateRibbonButton();
            this.dropDownScriptFile = this.Factory.CreateRibbonDropDown();
            this.buttonSelectFolder = this.Factory.CreateRibbonButton();
            this.buttonReload = this.Factory.CreateRibbonButton();
            this.buttonEdit = this.Factory.CreateRibbonButton();
            this.buttonRun = this.Factory.CreateRibbonButton();
            this.groupShortcut = this.Factory.CreateRibbonGroup();
            this.button1 = this.Factory.CreateRibbonButton();
            this.button2 = this.Factory.CreateRibbonButton();
            this.button3 = this.Factory.CreateRibbonButton();
            this.button4 = this.Factory.CreateRibbonButton();
            this.button5 = this.Factory.CreateRibbonButton();
            this.button6 = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.group1.SuspendLayout();
            this.groupShortcut.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.group1);
            this.tab1.Groups.Add(this.groupShortcut);
            this.tab1.Label = "TabAddIns";
            this.tab1.Name = "tab1";
            // 
            // group1
            // 
            this.group1.Items.Add(this.buttonOptions);
            this.group1.Items.Add(this.buttonNewScript);
            this.group1.Items.Add(this.dropDownScriptFile);
            this.group1.Items.Add(this.buttonSelectFolder);
            this.group1.Items.Add(this.buttonReload);
            this.group1.Items.Add(this.buttonEdit);
            this.group1.Items.Add(this.buttonRun);
            this.group1.Label = "ExcelCSX";
            this.group1.Name = "group1";
            // 
            // buttonOptions
            // 
            this.buttonOptions.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.buttonOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonOptions.Image")));
            this.buttonOptions.Label = "Options";
            this.buttonOptions.Name = "buttonOptions";
            this.buttonOptions.ShowImage = true;
            this.buttonOptions.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.buttonOptions_Click);
            // 
            // buttonNewScript
            // 
            this.buttonNewScript.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.buttonNewScript.Image = ((System.Drawing.Image)(resources.GetObject("buttonNewScript.Image")));
            this.buttonNewScript.Label = "NewScript";
            this.buttonNewScript.Name = "buttonNewScript";
            this.buttonNewScript.ShowImage = true;
            this.buttonNewScript.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.buttonNewScript_Click);
            // 
            // dropDownScriptFile
            // 
            this.dropDownScriptFile.Label = "ScriptFile:";
            this.dropDownScriptFile.Name = "dropDownScriptFile";
            this.dropDownScriptFile.SizeString = "******************";
            // 
            // buttonSelectFolder
            // 
            this.buttonSelectFolder.Image = ((System.Drawing.Image)(resources.GetObject("buttonSelectFolder.Image")));
            this.buttonSelectFolder.Label = "Select Folder...";
            this.buttonSelectFolder.Name = "buttonSelectFolder";
            this.buttonSelectFolder.ShowImage = true;
            this.buttonSelectFolder.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.buttonSelectFolder_Click);
            // 
            // buttonReload
            // 
            this.buttonReload.Image = ((System.Drawing.Image)(resources.GetObject("buttonReload.Image")));
            this.buttonReload.Label = "Reload";
            this.buttonReload.Name = "buttonReload";
            this.buttonReload.ShowImage = true;
            this.buttonReload.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.buttonReload_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.buttonEdit.Image = ((System.Drawing.Image)(resources.GetObject("buttonEdit.Image")));
            this.buttonEdit.Label = "Edit";
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.ShowImage = true;
            this.buttonEdit.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.buttonEdit_Click);
            // 
            // buttonRun
            // 
            this.buttonRun.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.buttonRun.Image = ((System.Drawing.Image)(resources.GetObject("buttonRun.Image")));
            this.buttonRun.Label = "Run";
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.ShowImage = true;
            this.buttonRun.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.buttonRun_Click);
            // 
            // groupShortcut
            // 
            this.groupShortcut.Items.Add(this.button1);
            this.groupShortcut.Items.Add(this.button2);
            this.groupShortcut.Items.Add(this.button3);
            this.groupShortcut.Items.Add(this.button4);
            this.groupShortcut.Items.Add(this.button5);
            this.groupShortcut.Items.Add(this.button6);
            this.groupShortcut.Label = "Shortcut";
            this.groupShortcut.Name = "groupShortcut";
            // 
            // button1
            // 
            this.button1.Label = "button1";
            this.button1.Name = "button1";
            // 
            // button2
            // 
            this.button2.Label = "button1";
            this.button2.Name = "button2";
            // 
            // button3
            // 
            this.button3.Label = "button1";
            this.button3.Name = "button3";
            // 
            // button4
            // 
            this.button4.Label = "button1";
            this.button4.Name = "button4";
            // 
            // button5
            // 
            this.button5.Label = "button1";
            this.button5.Name = "button5";
            // 
            // button6
            // 
            this.button6.Label = "button1";
            this.button6.Name = "button6";
            // 
            // Ribbon
            // 
            this.Name = "Ribbon";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.groupShortcut.ResumeLayout(false);
            this.groupShortcut.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonSelectFolder;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonRun;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonOptions;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonNewScript;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonReload;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonEdit;
        internal Microsoft.Office.Tools.Ribbon.RibbonDropDown dropDownScriptFile;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup groupShortcut;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button2;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button3;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button4;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button5;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button6;
    }

    partial class ThisRibbonCollection
    {
        internal Ribbon Ribbon
        {
            get { return this.GetRibbon<Ribbon>(); }
        }
    }
}
