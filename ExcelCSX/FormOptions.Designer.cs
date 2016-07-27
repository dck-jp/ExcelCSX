namespace ExcelCSX
{
    partial class FormOptions
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOptions));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxEditorPath = new MetroFramework.Controls.MetroTextBox();
            this.metroTextButtonBroseEditor = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroTextButtonSave = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.metroTextButtonCancel = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxFolderPath = new MetroFramework.Controls.MetroTextBox();
            this.metroTextButtonBrowseFolder = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.metroRadioButtonUseLastFolder = new MetroFramework.Controls.MetroRadioButton();
            this.metroRadioButtonUseUserDefinedFolder = new MetroFramework.Controls.MetroRadioButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.metroLinkURL = new MetroFramework.Controls.MetroLink();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabelVer = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxArg = new MetroFramework.Controls.MetroTextBox();
            this.metroCheckBoxUseFolderPath = new MetroFramework.Controls.MetroCheckBox();
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(3, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(98, 25);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Editor Path";
            // 
            // metroTextBoxEditorPath
            // 
            // 
            // 
            // 
            this.metroTextBoxEditorPath.CustomButton.Image = null;
            this.metroTextBoxEditorPath.CustomButton.Location = new System.Drawing.Point(342, 1);
            this.metroTextBoxEditorPath.CustomButton.Name = "";
            this.metroTextBoxEditorPath.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxEditorPath.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxEditorPath.CustomButton.TabIndex = 1;
            this.metroTextBoxEditorPath.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxEditorPath.CustomButton.UseSelectable = true;
            this.metroTextBoxEditorPath.CustomButton.Visible = false;
            this.metroTextBoxEditorPath.Lines = new string[0];
            this.metroTextBoxEditorPath.Location = new System.Drawing.Point(7, 28);
            this.metroTextBoxEditorPath.MaxLength = 32767;
            this.metroTextBoxEditorPath.Name = "metroTextBoxEditorPath";
            this.metroTextBoxEditorPath.PasswordChar = '\0';
            this.metroTextBoxEditorPath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxEditorPath.SelectedText = "";
            this.metroTextBoxEditorPath.SelectionLength = 0;
            this.metroTextBoxEditorPath.SelectionStart = 0;
            this.metroTextBoxEditorPath.Size = new System.Drawing.Size(364, 23);
            this.metroTextBoxEditorPath.TabIndex = 1;
            this.metroTextBoxEditorPath.UseSelectable = true;
            this.metroTextBoxEditorPath.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxEditorPath.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextButtonBroseEditor
            // 
            this.metroTextButtonBroseEditor.Image = null;
            this.metroTextButtonBroseEditor.Location = new System.Drawing.Point(377, 28);
            this.metroTextButtonBroseEditor.Name = "metroTextButtonBroseEditor";
            this.metroTextButtonBroseEditor.Size = new System.Drawing.Size(109, 23);
            this.metroTextButtonBroseEditor.TabIndex = 2;
            this.metroTextButtonBroseEditor.Text = "Browse";
            this.metroTextButtonBroseEditor.UseSelectable = true;
            this.metroTextButtonBroseEditor.UseVisualStyleBackColor = true;
            this.metroTextButtonBroseEditor.Click += new System.EventHandler(this.metroTextButtonBroseEditor_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel2.ForeColor = System.Drawing.Color.DarkGray;
            this.metroLabel2.Location = new System.Drawing.Point(7, 54);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(449, 15);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "When you click the [Edit] button on Ribbon UI, you could edit a C# script file by" +
    " this editor.";
            // 
            // metroTextButtonSave
            // 
            this.metroTextButtonSave.BackColor = System.Drawing.Color.Transparent;
            this.metroTextButtonSave.FlatAppearance.BorderSize = 0;
            this.metroTextButtonSave.Image = ((System.Drawing.Image)(resources.GetObject("metroTextButtonSave.Image")));
            this.metroTextButtonSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroTextButtonSave.Location = new System.Drawing.Point(24, 465);
            this.metroTextButtonSave.Name = "metroTextButtonSave";
            this.metroTextButtonSave.Size = new System.Drawing.Size(99, 30);
            this.metroTextButtonSave.TabIndex = 4;
            this.metroTextButtonSave.Text = "Save";
            this.metroTextButtonSave.UseSelectable = true;
            this.metroTextButtonSave.UseVisualStyleBackColor = false;
            this.metroTextButtonSave.Click += new System.EventHandler(this.metroTextButtonSave_Click);
            // 
            // metroTextButtonCancel
            // 
            this.metroTextButtonCancel.BackColor = System.Drawing.Color.Transparent;
            this.metroTextButtonCancel.FlatAppearance.BorderSize = 0;
            this.metroTextButtonCancel.Image = ((System.Drawing.Image)(resources.GetObject("metroTextButtonCancel.Image")));
            this.metroTextButtonCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroTextButtonCancel.Location = new System.Drawing.Point(129, 465);
            this.metroTextButtonCancel.Name = "metroTextButtonCancel";
            this.metroTextButtonCancel.Size = new System.Drawing.Size(99, 30);
            this.metroTextButtonCancel.TabIndex = 4;
            this.metroTextButtonCancel.Text = "Cancel";
            this.metroTextButtonCancel.UseSelectable = true;
            this.metroTextButtonCancel.UseVisualStyleBackColor = false;
            this.metroTextButtonCancel.Click += new System.EventHandler(this.metroTextButtonCancel_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(3, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(163, 25);
            this.metroLabel3.TabIndex = 0;
            this.metroLabel3.Text = "Default Folder Path";
            // 
            // metroTextBoxFolderPath
            // 
            // 
            // 
            // 
            this.metroTextBoxFolderPath.CustomButton.Image = null;
            this.metroTextBoxFolderPath.CustomButton.Location = new System.Drawing.Point(342, 1);
            this.metroTextBoxFolderPath.CustomButton.Name = "";
            this.metroTextBoxFolderPath.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxFolderPath.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxFolderPath.CustomButton.TabIndex = 1;
            this.metroTextBoxFolderPath.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxFolderPath.CustomButton.UseSelectable = true;
            this.metroTextBoxFolderPath.CustomButton.Visible = false;
            this.metroTextBoxFolderPath.Lines = new string[0];
            this.metroTextBoxFolderPath.Location = new System.Drawing.Point(7, 70);
            this.metroTextBoxFolderPath.MaxLength = 32767;
            this.metroTextBoxFolderPath.Name = "metroTextBoxFolderPath";
            this.metroTextBoxFolderPath.PasswordChar = '\0';
            this.metroTextBoxFolderPath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxFolderPath.SelectedText = "";
            this.metroTextBoxFolderPath.SelectionLength = 0;
            this.metroTextBoxFolderPath.SelectionStart = 0;
            this.metroTextBoxFolderPath.Size = new System.Drawing.Size(364, 23);
            this.metroTextBoxFolderPath.TabIndex = 1;
            this.metroTextBoxFolderPath.UseSelectable = true;
            this.metroTextBoxFolderPath.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxFolderPath.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextButtonBrowseFolder
            // 
            this.metroTextButtonBrowseFolder.Image = null;
            this.metroTextButtonBrowseFolder.Location = new System.Drawing.Point(377, 70);
            this.metroTextButtonBrowseFolder.Name = "metroTextButtonBrowseFolder";
            this.metroTextButtonBrowseFolder.Size = new System.Drawing.Size(109, 23);
            this.metroTextButtonBrowseFolder.TabIndex = 2;
            this.metroTextButtonBrowseFolder.Text = "Browse";
            this.metroTextButtonBrowseFolder.UseSelectable = true;
            this.metroTextButtonBrowseFolder.UseVisualStyleBackColor = true;
            this.metroTextButtonBrowseFolder.Click += new System.EventHandler(this.metroTextButtonBroseFolder_Click);
            // 
            // metroRadioButtonUseLastFolder
            // 
            this.metroRadioButtonUseLastFolder.AutoSize = true;
            this.metroRadioButtonUseLastFolder.Checked = true;
            this.metroRadioButtonUseLastFolder.Location = new System.Drawing.Point(9, 28);
            this.metroRadioButtonUseLastFolder.Name = "metroRadioButtonUseLastFolder";
            this.metroRadioButtonUseLastFolder.Size = new System.Drawing.Size(106, 15);
            this.metroRadioButtonUseLastFolder.TabIndex = 5;
            this.metroRadioButtonUseLastFolder.TabStop = true;
            this.metroRadioButtonUseLastFolder.Text = "last used folder ";
            this.metroRadioButtonUseLastFolder.UseSelectable = true;
            // 
            // metroRadioButtonUseUserDefinedFolder
            // 
            this.metroRadioButtonUseUserDefinedFolder.AutoSize = true;
            this.metroRadioButtonUseUserDefinedFolder.Location = new System.Drawing.Point(9, 49);
            this.metroRadioButtonUseUserDefinedFolder.Name = "metroRadioButtonUseUserDefinedFolder";
            this.metroRadioButtonUseUserDefinedFolder.Size = new System.Drawing.Size(122, 15);
            this.metroRadioButtonUseUserDefinedFolder.TabIndex = 5;
            this.metroRadioButtonUseUserDefinedFolder.Text = "user defined folder";
            this.metroRadioButtonUseUserDefinedFolder.UseSelectable = true;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.metroRadioButtonUseUserDefinedFolder);
            this.metroPanel1.Controls.Add(this.metroLabel4);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.metroRadioButtonUseLastFolder);
            this.metroPanel1.Controls.Add(this.metroTextBoxFolderPath);
            this.metroPanel1.Controls.Add(this.metroTextButtonBrowseFolder);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(17, 219);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(501, 129);
            this.metroPanel1.TabIndex = 6;
            this.metroPanel1.UseStyleColors = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel4.ForeColor = System.Drawing.Color.DarkGray;
            this.metroLabel4.Location = new System.Drawing.Point(7, 96);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(216, 15);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "Choose the folder containig C# Script files.";
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.metroCheckBoxUseFolderPath);
            this.metroPanel2.Controls.Add(this.metroLabel6);
            this.metroPanel2.Controls.Add(this.metroLabel1);
            this.metroPanel2.Controls.Add(this.metroTextBoxArg);
            this.metroPanel2.Controls.Add(this.metroTextBoxEditorPath);
            this.metroPanel2.Controls.Add(this.metroLabel2);
            this.metroPanel2.Controls.Add(this.metroTextButtonBroseEditor);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(17, 63);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(501, 150);
            this.metroPanel2.TabIndex = 7;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // metroLinkURL
            // 
            this.metroLinkURL.Location = new System.Drawing.Point(342, 404);
            this.metroLinkURL.Name = "metroLinkURL";
            this.metroLinkURL.Size = new System.Drawing.Size(176, 23);
            this.metroLinkURL.TabIndex = 8;
            this.metroLinkURL.Text = "http://www.clockahead.com/";
            this.metroLinkURL.UseSelectable = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(326, 363);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(192, 19);
            this.metroLabel5.TabIndex = 9;
            this.metroLabel5.Text = "ExcelCSX (C Sharp Script)";
            // 
            // metroLabelVer
            // 
            this.metroLabelVer.AutoSize = true;
            this.metroLabelVer.Location = new System.Drawing.Point(326, 382);
            this.metroLabelVer.Name = "metroLabelVer";
            this.metroLabelVer.Size = new System.Drawing.Size(40, 19);
            this.metroLabelVer.TabIndex = 9;
            this.metroLabelVer.Text = "Ver. β";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(9, 83);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(71, 19);
            this.metroLabel6.TabIndex = 0;
            this.metroLabel6.Text = "Argument";
            // 
            // metroTextBoxArg
            // 
            // 
            // 
            // 
            this.metroTextBoxArg.CustomButton.Image = null;
            this.metroTextBoxArg.CustomButton.Location = new System.Drawing.Point(115, 1);
            this.metroTextBoxArg.CustomButton.Name = "";
            this.metroTextBoxArg.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxArg.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxArg.CustomButton.TabIndex = 1;
            this.metroTextBoxArg.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxArg.CustomButton.UseSelectable = true;
            this.metroTextBoxArg.CustomButton.Visible = false;
            this.metroTextBoxArg.Lines = new string[0];
            this.metroTextBoxArg.Location = new System.Drawing.Point(86, 83);
            this.metroTextBoxArg.MaxLength = 32767;
            this.metroTextBoxArg.Name = "metroTextBoxArg";
            this.metroTextBoxArg.PasswordChar = '\0';
            this.metroTextBoxArg.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxArg.SelectedText = "";
            this.metroTextBoxArg.SelectionLength = 0;
            this.metroTextBoxArg.SelectionStart = 0;
            this.metroTextBoxArg.Size = new System.Drawing.Size(137, 23);
            this.metroTextBoxArg.TabIndex = 1;
            this.metroTextBoxArg.UseSelectable = true;
            this.metroTextBoxArg.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxArg.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroCheckBoxUseFolderPath
            // 
            this.metroCheckBoxUseFolderPath.AutoSize = true;
            this.metroCheckBoxUseFolderPath.Location = new System.Drawing.Point(9, 121);
            this.metroCheckBoxUseFolderPath.Name = "metroCheckBoxUseFolderPath";
            this.metroCheckBoxUseFolderPath.Size = new System.Drawing.Size(360, 15);
            this.metroCheckBoxUseFolderPath.TabIndex = 4;
            this.metroCheckBoxUseFolderPath.Text = "Use a folder path instead of a C# Script file path passed to Editor";
            this.metroCheckBoxUseFolderPath.UseSelectable = true;
            this.metroCheckBoxUseFolderPath.Visible = false;
            // 
            // FormOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(541, 518);
            this.Controls.Add(this.metroLabelVer);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLinkURL);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.metroTextButtonCancel);
            this.Controls.Add(this.metroTextButtonSave);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormOptions";
            this.Resizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "Options";
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox metroTextBoxEditorPath;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton metroTextButtonBroseEditor;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton metroTextButtonSave;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton metroTextButtonCancel;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox metroTextBoxFolderPath;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton metroTextButtonBrowseFolder;
        private MetroFramework.Controls.MetroRadioButton metroRadioButtonUseLastFolder;
        private MetroFramework.Controls.MetroRadioButton metroRadioButtonUseUserDefinedFolder;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroLink metroLinkURL;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabelVer;
        private MetroFramework.Controls.MetroCheckBox metroCheckBoxUseFolderPath;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox metroTextBoxArg;
    }
}