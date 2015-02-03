﻿namespace Prizm.Main.Forms.ExternalFile
{
    partial class ExternalFilesXtraForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExternalFilesXtraForm));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            this.files = new DevExpress.XtraGrid.GridControl();
            this.filesView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFileName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUploadDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colView = new DevExpress.XtraGrid.Columns.GridColumn();
            this.viewButton = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colDownload = new DevExpress.XtraGrid.Columns.GridColumn();
            this.downloadButton = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.addFile = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControl = new DevExpress.XtraLayout.LayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.tableLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.buttonLayoutControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.addButtonLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.filesBindingSource = new System.Windows.Forms.BindingSource();
            this.colEdit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.editButton = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.files)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filesView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.downloadButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
            this.layoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonLayoutControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addButtonLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editButton)).BeginInit();
            this.SuspendLayout();
            // 
            // files
            // 
            this.files.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.files.Cursor = System.Windows.Forms.Cursors.Default;
            this.files.Location = new System.Drawing.Point(15, 15);
            this.files.MainView = this.filesView;
            this.files.Margin = new System.Windows.Forms.Padding(11);
            this.files.Name = "files";
            this.files.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.viewButton,
            this.downloadButton,
            this.repositoryItemButtonEdit1,
            this.editButton});
            this.files.Size = new System.Drawing.Size(465, 235);
            this.files.TabIndex = 0;
            this.files.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.filesView});
            // 
            // filesView
            // 
            this.filesView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFileName,
            this.colUploadDate,
            this.colView,
            this.colDownload,
            this.colEdit});
            this.filesView.GridControl = this.files;
            this.filesView.Name = "filesView";
            this.filesView.OptionsView.ShowGroupPanel = false;
            this.filesView.OptionsView.ShowIndicator = false;
            // 
            // colFileName
            // 
            this.colFileName.Caption = "Имя файла";
            this.colFileName.FieldName = "FileName";
            this.colFileName.Name = "colFileName";
            this.colFileName.OptionsColumn.AllowEdit = false;
            this.colFileName.Visible = true;
            this.colFileName.VisibleIndex = 0;
            this.colFileName.Width = 251;
            // 
            // colUploadDate
            // 
            this.colUploadDate.Caption = "Дата добавления";
            this.colUploadDate.FieldName = "UploadDate";
            this.colUploadDate.Name = "colUploadDate";
            this.colUploadDate.OptionsColumn.AllowEdit = false;
            this.colUploadDate.Visible = true;
            this.colUploadDate.VisibleIndex = 1;
            this.colUploadDate.Width = 140;
            // 
            // colView
            // 
            this.colView.ColumnEdit = this.viewButton;
            this.colView.Name = "colView";
            this.colView.ToolTip = "Просмотреть файл";
            this.colView.Visible = true;
            this.colView.VisibleIndex = 2;
            this.colView.Width = 42;
            // 
            // viewButton
            // 
            this.viewButton.AutoHeight = false;
            this.viewButton.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("viewButton.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject4, "", null, null, true)});
            this.viewButton.Name = "viewButton";
            this.viewButton.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.viewButton.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.viewButton_ButtonClick);
            // 
            // colDownload
            // 
            this.colDownload.ColumnEdit = this.downloadButton;
            this.colDownload.Name = "colDownload";
            this.colDownload.ToolTip = "Извлечь файл";
            this.colDownload.Visible = true;
            this.colDownload.VisibleIndex = 3;
            this.colDownload.Width = 43;
            // 
            // downloadButton
            // 
            this.downloadButton.AutoHeight = false;
            this.downloadButton.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("downloadButton.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, "", null, null, true)});
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.downloadButton.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.downloadButton_ButtonClick);
            // 
            // colEdit
            // 
            this.colEdit.ColumnEdit = this.editButton;
            this.colEdit.Name = "colEdit";
            this.colEdit.ToolTip = "Заменить файл";
            this.colEdit.Visible = true;
            this.colEdit.VisibleIndex = 4;
            this.colEdit.Width = 48;
            // 
            // editButton
            // 
            this.editButton.AutoHeight = false;
            this.editButton.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("editButton.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject6, "", null, null, true)});
            this.editButton.Name = "editButton";
            this.editButton.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.editButton.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.editButton_ButtonClick);
            // 
            // addFile
            // 
            this.addFile.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.addFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addFile.Image = ((System.Drawing.Image)(resources.GetObject("addFile.Image")));
            this.addFile.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.addFile.Location = new System.Drawing.Point(20, 265);
            this.addFile.Margin = new System.Windows.Forms.Padding(11);
            this.addFile.Name = "addFile";
            this.addFile.Size = new System.Drawing.Size(135, 22);
            this.addFile.StyleController = this.layoutControl;
            this.addFile.TabIndex = 1;
            this.addFile.Text = "Добавить файл";
            this.addFile.Click += new System.EventHandler(this.addFile_Click);
            // 
            // layoutControl
            // 
            this.layoutControl.Controls.Add(this.files);
            this.layoutControl.Controls.Add(this.addFile);
            this.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl.Location = new System.Drawing.Point(0, 0);
            this.layoutControl.Name = "layoutControl";
            this.layoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(785, 166, 396, 463);
            this.layoutControl.OptionsPrint.AppearanceGroupCaption.BackColor = System.Drawing.Color.LightGray;
            this.layoutControl.OptionsPrint.AppearanceGroupCaption.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.layoutControl.OptionsPrint.AppearanceGroupCaption.Options.UseBackColor = true;
            this.layoutControl.OptionsPrint.AppearanceGroupCaption.Options.UseFont = true;
            this.layoutControl.OptionsPrint.AppearanceGroupCaption.Options.UseTextOptions = true;
            this.layoutControl.OptionsPrint.AppearanceGroupCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.layoutControl.OptionsPrint.AppearanceGroupCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.layoutControl.OptionsPrint.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControl.OptionsPrint.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.layoutControl.OptionsPrint.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.layoutControl.Root = this.Root;
            this.layoutControl.Size = new System.Drawing.Size(495, 307);
            this.layoutControl.TabIndex = 2;
            this.layoutControl.Text = "layoutControl1";
            // 
            // Root
            // 
            this.Root.CustomizationFormText = "Root";
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.tableLayoutControlItem,
            this.buttonLayoutControlGroup});
            this.Root.Location = new System.Drawing.Point(0, 0);
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(495, 307);
            this.Root.Text = "Root";
            this.Root.TextVisible = false;
            // 
            // tableLayoutControlItem
            // 
            this.tableLayoutControlItem.Control = this.files;
            this.tableLayoutControlItem.CustomizationFormText = "Файлы";
            this.tableLayoutControlItem.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutControlItem.Name = "tableLayoutControlItem";
            this.tableLayoutControlItem.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.tableLayoutControlItem.Size = new System.Drawing.Size(475, 245);
            this.tableLayoutControlItem.Text = "Файлы";
            this.tableLayoutControlItem.TextLocation = DevExpress.Utils.Locations.Top;
            this.tableLayoutControlItem.TextSize = new System.Drawing.Size(0, 0);
            this.tableLayoutControlItem.TextVisible = false;
            // 
            // buttonLayoutControlGroup
            // 
            this.buttonLayoutControlGroup.CustomizationFormText = "Добавить";
            this.buttonLayoutControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.addButtonLayoutControlItem,
            this.emptySpaceItem1});
            this.buttonLayoutControlGroup.Location = new System.Drawing.Point(0, 245);
            this.buttonLayoutControlGroup.Name = "buttonLayoutControlGroup";
            this.buttonLayoutControlGroup.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.buttonLayoutControlGroup.Size = new System.Drawing.Size(475, 42);
            this.buttonLayoutControlGroup.Text = "Добавить";
            this.buttonLayoutControlGroup.TextVisible = false;
            // 
            // addButtonLayoutControlItem
            // 
            this.addButtonLayoutControlItem.Control = this.addFile;
            this.addButtonLayoutControlItem.CustomizationFormText = "Кнопка добавить";
            this.addButtonLayoutControlItem.Location = new System.Drawing.Point(0, 0);
            this.addButtonLayoutControlItem.Name = "addButtonLayoutControlItem";
            this.addButtonLayoutControlItem.Size = new System.Drawing.Size(139, 26);
            this.addButtonLayoutControlItem.Text = "addButtonLayoutControlItem";
            this.addButtonLayoutControlItem.TextSize = new System.Drawing.Size(0, 0);
            this.addButtonLayoutControlItem.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(139, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(320, 26);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";

            // 
            // ExternalFilesXtraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 307);
            this.Controls.Add(this.layoutControl);
            this.Name = "ExternalFilesXtraForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Внешние файлы";
            this.Load += new System.EventHandler(this.ExternalFilesXtraForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.files)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filesView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.downloadButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
            this.layoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonLayoutControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addButtonLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl files;
        private DevExpress.XtraGrid.Views.Grid.GridView filesView;
        private DevExpress.XtraGrid.Columns.GridColumn colFileName;
        private DevExpress.XtraGrid.Columns.GridColumn colUploadDate;
        private DevExpress.XtraEditors.SimpleButton addFile;
        private DevExpress.XtraGrid.Columns.GridColumn colView;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit viewButton;
        private DevExpress.XtraGrid.Columns.GridColumn colDownload;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit downloadButton;
        private System.Windows.Forms.BindingSource filesBindingSource;
        private DevExpress.XtraLayout.LayoutControl layoutControl;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem tableLayoutControlItem;
        private DevExpress.XtraLayout.LayoutControlGroup buttonLayoutControlGroup;
        private DevExpress.XtraLayout.LayoutControlItem addButtonLayoutControlItem;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraGrid.Columns.GridColumn colEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit editButton;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
    }
}