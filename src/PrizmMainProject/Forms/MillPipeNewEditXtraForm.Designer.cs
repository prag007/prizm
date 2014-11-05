﻿namespace PrizmMain.Forms
{
    partial class MillPipeNewEditXtraForm
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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.weldersListGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.weldingHistory = new DevExpress.XtraGrid.GridControl();
            this.weldingHistoryGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.pipe = new DevExpress.XtraTab.XtraTabControl();
            this.generalParametersPage = new DevExpress.XtraTab.XtraTabPage();
            this.pipeGeneralParametersLayout = new DevExpress.XtraLayout.LayoutControl();
            this.shippedDate = new DevExpress.XtraEditors.TextEdit();
            this.certificateNumber = new DevExpress.XtraEditors.TextEdit();
            this.destanation = new DevExpress.XtraEditors.TextEdit();
            this.railcarNumber = new DevExpress.XtraEditors.TextEdit();
            this.chemicalComposition = new DevExpress.XtraGrid.GridControl();
            this.chemicalCompositionGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.pipeElementNameGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.quantityGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.addCoatingButton = new DevExpress.XtraEditors.SimpleButton();
            this.coatingType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.coatingDate = new DevExpress.XtraEditors.DateEdit();
            this.coatingHistory = new DevExpress.XtraGrid.GridControl();
            this.coatingHistoryGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.addWeldingButton = new DevExpress.XtraEditors.SimpleButton();
            this.welders = new DevExpress.XtraEditors.ComboBoxEdit();
            this.weldingDate = new DevExpress.XtraEditors.DateEdit();
            this.diameter = new DevExpress.XtraEditors.TextEdit();
            this.length = new DevExpress.XtraEditors.TextEdit();
            this.weight = new DevExpress.XtraEditors.TextEdit();
            this.thickness = new DevExpress.XtraEditors.TextEdit();
            this.generalParametersLayoutGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.chemicalCompositionLayoutGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.chemicalCompositionLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.geometricParametersLayoutGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lengthLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.thicknessLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.diameterLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.weightLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.shipmentParametersLayoutGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.railcarNumberLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.shiptedDateLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.certificateLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.destinationLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.coatingParametersLayoutGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.coatingHistoryLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.coatingDateLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.coatingTypeaLyout = new DevExpress.XtraLayout.LayoutControlItem();
            this.cpatingParametersEmptySpace = new DevExpress.XtraLayout.EmptySpaceItem();
            this.addCoatingButtonLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.coatingAddButtonEmptySpace = new DevExpress.XtraLayout.EmptySpaceItem();
            this.weldingParametersLayoutGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.weldingHistoryLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.weldingDateLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.addWeldingButtonLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.weldersLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.weldinAddButtonEmptySpace = new DevExpress.XtraLayout.EmptySpaceItem();
            this.weldingParametersEmpty = new DevExpress.XtraLayout.EmptySpaceItem();
            this.heatPlateParametersPage = new DevExpress.XtraTab.XtraTabPage();
            this.tabPagesLayout = new DevExpress.XtraLayout.LayoutControl();
            this.tensileTests = new DevExpress.XtraGrid.GridControl();
            this.tensileTestsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.plateThickness = new DevExpress.XtraEditors.TextEdit();
            this.steelGrade = new DevExpress.XtraEditors.TextEdit();
            this.editHeatButton = new DevExpress.XtraEditors.SimpleButton();
            this.plateChemicalComposition = new DevExpress.XtraGrid.GridControl();
            this.plateChemicalCompositionGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.plateElementNameGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.plateElementQuantityGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ladelMechanicalProperties = new DevExpress.XtraGrid.GridControl();
            this.ladelMechanicalPropertiesGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ladleChemicalComposition = new DevExpress.XtraGrid.GridControl();
            this.ladleChemicalCompositionView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.elementNameLadleCompositionGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.elementQuantityLadleGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.plateManufacturer = new DevExpress.XtraEditors.ComboBoxEdit();
            this.heatLayoutGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.heatParametersLayoutGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ladelChemicalCompositionLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.heatSplitter = new DevExpress.XtraLayout.SplitterItem();
            this.ladelMechanicalPropertiesLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.editHeatButtonEmptySpace = new DevExpress.XtraLayout.EmptySpaceItem();
            this.editHeatButtonLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.plateParametersLayoutGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.plateSplitter = new DevExpress.XtraLayout.SplitterItem();
            this.plateManufacturerLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.steelGradeLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.plateThicknessLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.steelGradeEmptySpace = new DevExpress.XtraLayout.EmptySpaceItem();
            this.plateChemicalCompositionLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.tensileTestsLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.inspectionPage = new DevExpress.XtraTab.XtraTabPage();
            this.inspectionOperation = new System.Windows.Forms.BindingSource(this.components);
            this.pipeSize = new DevExpress.XtraEditors.ComboBoxEdit();
            this.generalPipeLayout = new DevExpress.XtraLayout.LayoutControl();
            this.closeButton = new DevExpress.XtraEditors.SimpleButton();
            this.deactivate = new DevExpress.XtraEditors.CheckEdit();
            this.saveButton = new DevExpress.XtraEditors.SimpleButton();
            this.attachmentsButton = new DevExpress.XtraEditors.SimpleButton();
            this.purchaseOrderDate = new DevExpress.XtraEditors.DateEdit();
            this.purchaseOrder = new DevExpress.XtraEditors.ComboBoxEdit();
            this.heatNumber = new DevExpress.XtraEditors.ComboBoxEdit();
            this.pipeCreationDate = new DevExpress.XtraEditors.DateEdit();
            this.millStatus = new DevExpress.XtraEditors.ComboBoxEdit();
            this.pipeNumber = new DevExpress.XtraEditors.TextEdit();
            this.generalLayoutGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.pipeNumberLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.pipeSizeLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.pipeLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.heatNumberLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.statusLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.creationDateLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.purhaseOrderLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.generalPipeParametersEmpty = new DevExpress.XtraLayout.EmptySpaceItem();
            this.purhaseOrderDateLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.attachmentsButtonLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.deactivateLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.saveButtonLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.closeButtonLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.pipeParametersLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.certificateEmptySpace = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.inspectionsLayoutGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.inspections = new DevExpress.XtraGrid.GridControl();
            this.inspectionsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn15 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn16 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.inspectionsLayout = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.weldersListGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weldingHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weldingHistoryGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe)).BeginInit();
            this.pipe.SuspendLayout();
            this.generalParametersPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pipeGeneralParametersLayout)).BeginInit();
            this.pipeGeneralParametersLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shippedDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificateNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.destanation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.railcarNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chemicalComposition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chemicalCompositionGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coatingType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coatingDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coatingDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coatingHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coatingHistoryGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.welders.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weldingDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weldingDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diameter.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.length.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weight.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thickness.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalParametersLayoutGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chemicalCompositionLayoutGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chemicalCompositionLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.geometricParametersLayoutGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lengthLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thicknessLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diameterLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weightLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipmentParametersLayoutGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.railcarNumberLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shiptedDateLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificateLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.destinationLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coatingParametersLayoutGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coatingHistoryLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coatingDateLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coatingTypeaLyout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpatingParametersEmptySpace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addCoatingButtonLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coatingAddButtonEmptySpace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weldingParametersLayoutGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weldingHistoryLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weldingDateLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addWeldingButtonLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weldersLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weldinAddButtonEmptySpace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weldingParametersEmpty)).BeginInit();
            this.heatPlateParametersPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabPagesLayout)).BeginInit();
            this.tabPagesLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tensileTests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tensileTestsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plateThickness.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.steelGrade.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plateChemicalComposition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plateChemicalCompositionGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ladelMechanicalProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ladelMechanicalPropertiesGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ladleChemicalComposition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ladleChemicalCompositionView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plateManufacturer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heatLayoutGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heatParametersLayoutGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ladelChemicalCompositionLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heatSplitter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ladelMechanicalPropertiesLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editHeatButtonEmptySpace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editHeatButtonLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plateParametersLayoutGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plateSplitter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plateManufacturerLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.steelGradeLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plateThicknessLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.steelGradeEmptySpace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plateChemicalCompositionLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tensileTestsLayout)).BeginInit();
            this.inspectionPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionOperation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeSize.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalPipeLayout)).BeginInit();
            this.generalPipeLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deactivate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseOrderDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseOrderDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseOrder.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heatNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeCreationDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeCreationDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.millStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalLayoutGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeNumberLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeSizeLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heatNumberLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.creationDateLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purhaseOrderLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalPipeParametersEmpty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purhaseOrderDateLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attachmentsButtonLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deactivateLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveButtonLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButtonLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeParametersLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificateEmptySpace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionsLayoutGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspections)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionsLayout)).BeginInit();
            this.SuspendLayout();
            // 
            // weldersListGridView
            // 
            this.weldersListGridView.GridControl = this.weldingHistory;
            this.weldersListGridView.Name = "weldersListGridView";
            // 
            // weldingHistory
            // 
            this.weldingHistory.Cursor = System.Windows.Forms.Cursors.Default;
            gridLevelNode1.LevelTemplate = this.weldersListGridView;
            gridLevelNode1.RelationName = "welders";
            this.weldingHistory.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.weldingHistory.Location = new System.Drawing.Point(193, 95);
            this.weldingHistory.MainView = this.weldingHistoryGridView;
            this.weldingHistory.Name = "weldingHistory";
            this.weldingHistory.Size = new System.Drawing.Size(552, 129);
            this.weldingHistory.TabIndex = 40;
            this.weldingHistory.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.weldingHistoryGridView,
            this.weldersListGridView});
            // 
            // weldingHistoryGridView
            // 
            this.weldingHistoryGridView.GridControl = this.weldingHistory;
            this.weldingHistoryGridView.Name = "weldingHistoryGridView";
            this.weldingHistoryGridView.OptionsView.ShowGroupPanel = false;
            // 
            // pipe
            // 
            this.pipe.Location = new System.Drawing.Point(14, 65);
            this.pipe.Name = "pipe";
            this.pipe.SelectedTabPage = this.generalParametersPage;
            this.pipe.Size = new System.Drawing.Size(1242, 440);
            this.pipe.TabIndex = 0;
            this.pipe.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.generalParametersPage,
            this.heatPlateParametersPage,
            this.inspectionPage});
            // 
            // generalParametersPage
            // 
            this.generalParametersPage.Controls.Add(this.pipeGeneralParametersLayout);
            this.generalParametersPage.Name = "generalParametersPage";
            this.generalParametersPage.Size = new System.Drawing.Size(1236, 412);
            this.generalParametersPage.Text = "&Общие параметры трубы";
            // 
            // pipeGeneralParametersLayout
            // 
            this.pipeGeneralParametersLayout.Controls.Add(this.shippedDate);
            this.pipeGeneralParametersLayout.Controls.Add(this.certificateNumber);
            this.pipeGeneralParametersLayout.Controls.Add(this.destanation);
            this.pipeGeneralParametersLayout.Controls.Add(this.railcarNumber);
            this.pipeGeneralParametersLayout.Controls.Add(this.chemicalComposition);
            this.pipeGeneralParametersLayout.Controls.Add(this.addCoatingButton);
            this.pipeGeneralParametersLayout.Controls.Add(this.coatingType);
            this.pipeGeneralParametersLayout.Controls.Add(this.coatingDate);
            this.pipeGeneralParametersLayout.Controls.Add(this.coatingHistory);
            this.pipeGeneralParametersLayout.Controls.Add(this.addWeldingButton);
            this.pipeGeneralParametersLayout.Controls.Add(this.welders);
            this.pipeGeneralParametersLayout.Controls.Add(this.weldingHistory);
            this.pipeGeneralParametersLayout.Controls.Add(this.weldingDate);
            this.pipeGeneralParametersLayout.Controls.Add(this.diameter);
            this.pipeGeneralParametersLayout.Controls.Add(this.length);
            this.pipeGeneralParametersLayout.Controls.Add(this.weight);
            this.pipeGeneralParametersLayout.Controls.Add(this.thickness);
            this.pipeGeneralParametersLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pipeGeneralParametersLayout.Location = new System.Drawing.Point(0, 0);
            this.pipeGeneralParametersLayout.Name = "pipeGeneralParametersLayout";
            this.pipeGeneralParametersLayout.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(0, 167, 619, 715);
            this.pipeGeneralParametersLayout.Root = this.generalParametersLayoutGroup;
            this.pipeGeneralParametersLayout.Size = new System.Drawing.Size(1236, 412);
            this.pipeGeneralParametersLayout.TabIndex = 0;
            this.pipeGeneralParametersLayout.Text = "layoutControl2";
            // 
            // shippedDate
            // 
            this.shippedDate.Location = new System.Drawing.Point(29, 358);
            this.shippedDate.Name = "shippedDate";
            this.shippedDate.Properties.ReadOnly = true;
            this.shippedDate.Size = new System.Drawing.Size(132, 20);
            this.shippedDate.StyleController = this.pipeGeneralParametersLayout;
            this.shippedDate.TabIndex = 56;
            // 
            // certificateNumber
            // 
            this.certificateNumber.Location = new System.Drawing.Point(180, 309);
            this.certificateNumber.Name = "certificateNumber";
            this.certificateNumber.Properties.ReadOnly = true;
            this.certificateNumber.Size = new System.Drawing.Size(224, 20);
            this.certificateNumber.StyleController = this.pipeGeneralParametersLayout;
            this.certificateNumber.TabIndex = 55;
            // 
            // destanation
            // 
            this.destanation.Location = new System.Drawing.Point(180, 358);
            this.destanation.Name = "destanation";
            this.destanation.Properties.ReadOnly = true;
            this.destanation.Size = new System.Drawing.Size(224, 20);
            this.destanation.StyleController = this.pipeGeneralParametersLayout;
            this.destanation.TabIndex = 54;
            // 
            // railcarNumber
            // 
            this.railcarNumber.Location = new System.Drawing.Point(29, 309);
            this.railcarNumber.Name = "railcarNumber";
            this.railcarNumber.Properties.ReadOnly = true;
            this.railcarNumber.Size = new System.Drawing.Size(132, 20);
            this.railcarNumber.StyleController = this.pipeGeneralParametersLayout;
            this.railcarNumber.TabIndex = 53;
            // 
            // chemicalComposition
            // 
            this.chemicalComposition.Cursor = System.Windows.Forms.Cursors.Default;
            this.chemicalComposition.Location = new System.Drawing.Point(459, 299);
            this.chemicalComposition.MainView = this.chemicalCompositionGridView;
            this.chemicalComposition.Name = "chemicalComposition";
            this.chemicalComposition.Size = new System.Drawing.Size(748, 84);
            this.chemicalComposition.TabIndex = 52;
            this.chemicalComposition.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.chemicalCompositionGridView});
            // 
            // chemicalCompositionGridView
            // 
            this.chemicalCompositionGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.pipeElementNameGridColumn,
            this.quantityGridColumn});
            this.chemicalCompositionGridView.GridControl = this.chemicalComposition;
            this.chemicalCompositionGridView.Name = "chemicalCompositionGridView";
            this.chemicalCompositionGridView.OptionsView.ShowGroupPanel = false;
            // 
            // pipeElementNameGridColumn
            // 
            this.pipeElementNameGridColumn.Caption = "Название";
            this.pipeElementNameGridColumn.Name = "pipeElementNameGridColumn";
            this.pipeElementNameGridColumn.Visible = true;
            this.pipeElementNameGridColumn.VisibleIndex = 0;
            // 
            // quantityGridColumn
            // 
            this.quantityGridColumn.Caption = "Количество";
            this.quantityGridColumn.Name = "quantityGridColumn";
            this.quantityGridColumn.Visible = true;
            this.quantityGridColumn.VisibleIndex = 1;
            // 
            // addCoatingButton
            // 
            this.addCoatingButton.Location = new System.Drawing.Point(1095, 57);
            this.addCoatingButton.Name = "addCoatingButton";
            this.addCoatingButton.Size = new System.Drawing.Size(92, 22);
            this.addCoatingButton.StyleController = this.pipeGeneralParametersLayout;
            this.addCoatingButton.TabIndex = 51;
            this.addCoatingButton.Text = "Добавить";
            // 
            // coatingType
            // 
            this.coatingType.Location = new System.Drawing.Point(945, 59);
            this.coatingType.Name = "coatingType";
            this.coatingType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.coatingType.Size = new System.Drawing.Size(131, 20);
            this.coatingType.StyleController = this.pipeGeneralParametersLayout;
            this.coatingType.TabIndex = 50;
            // 
            // coatingDate
            // 
            this.coatingDate.EditValue = null;
            this.coatingDate.Location = new System.Drawing.Point(800, 59);
            this.coatingDate.Name = "coatingDate";
            this.coatingDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.coatingDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.coatingDate.Size = new System.Drawing.Size(126, 20);
            this.coatingDate.StyleController = this.pipeGeneralParametersLayout;
            this.coatingDate.TabIndex = 49;
            // 
            // coatingHistory
            // 
            this.coatingHistory.Cursor = System.Windows.Forms.Cursors.Default;
            this.coatingHistory.Location = new System.Drawing.Point(800, 95);
            this.coatingHistory.MainView = this.coatingHistoryGridView;
            this.coatingHistory.Name = "coatingHistory";
            this.coatingHistory.Size = new System.Drawing.Size(407, 132);
            this.coatingHistory.TabIndex = 45;
            this.coatingHistory.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.coatingHistoryGridView});
            // 
            // coatingHistoryGridView
            // 
            this.coatingHistoryGridView.GridControl = this.coatingHistory;
            this.coatingHistoryGridView.Name = "coatingHistoryGridView";
            this.coatingHistoryGridView.OptionsView.ShowGroupPanel = false;
            // 
            // addWeldingButton
            // 
            this.addWeldingButton.Location = new System.Drawing.Point(515, 57);
            this.addWeldingButton.Name = "addWeldingButton";
            this.addWeldingButton.Size = new System.Drawing.Size(92, 22);
            this.addWeldingButton.StyleController = this.pipeGeneralParametersLayout;
            this.addWeldingButton.TabIndex = 44;
            this.addWeldingButton.Text = "Добавить";
            // 
            // welders
            // 
            this.welders.Location = new System.Drawing.Point(315, 59);
            this.welders.Name = "welders";
            this.welders.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.welders.Size = new System.Drawing.Size(181, 20);
            this.welders.StyleController = this.pipeGeneralParametersLayout;
            this.welders.TabIndex = 43;
            // 
            // weldingDate
            // 
            this.weldingDate.EditValue = null;
            this.weldingDate.Location = new System.Drawing.Point(193, 59);
            this.weldingDate.Name = "weldingDate";
            this.weldingDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.weldingDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.weldingDate.Size = new System.Drawing.Size(103, 20);
            this.weldingDate.StyleController = this.pipeGeneralParametersLayout;
            this.weldingDate.TabIndex = 38;
            // 
            // diameter
            // 
            this.diameter.Location = new System.Drawing.Point(29, 109);
            this.diameter.Name = "diameter";
            this.diameter.Size = new System.Drawing.Size(109, 20);
            this.diameter.StyleController = this.pipeGeneralParametersLayout;
            this.diameter.TabIndex = 28;
            // 
            // length
            // 
            this.length.Location = new System.Drawing.Point(29, 60);
            this.length.Name = "length";
            this.length.Size = new System.Drawing.Size(109, 20);
            this.length.StyleController = this.pipeGeneralParametersLayout;
            this.length.TabIndex = 25;
            // 
            // weight
            // 
            this.weight.Location = new System.Drawing.Point(29, 204);
            this.weight.Name = "weight";
            this.weight.Size = new System.Drawing.Size(109, 20);
            this.weight.StyleController = this.pipeGeneralParametersLayout;
            this.weight.TabIndex = 27;
            // 
            // thickness
            // 
            this.thickness.Location = new System.Drawing.Point(29, 155);
            this.thickness.Name = "thickness";
            this.thickness.Size = new System.Drawing.Size(109, 20);
            this.thickness.StyleController = this.pipeGeneralParametersLayout;
            this.thickness.TabIndex = 26;
            // 
            // generalParametersLayoutGroup
            // 
            this.generalParametersLayoutGroup.CustomizationFormText = "generalParametersLayoutGroup";
            this.generalParametersLayoutGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.generalParametersLayoutGroup.GroupBordersVisible = false;
            this.generalParametersLayoutGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.chemicalCompositionLayoutGroup,
            this.geometricParametersLayoutGroup,
            this.shipmentParametersLayoutGroup,
            this.coatingParametersLayoutGroup,
            this.weldingParametersLayoutGroup});
            this.generalParametersLayoutGroup.Location = new System.Drawing.Point(0, 0);
            this.generalParametersLayoutGroup.Name = "generalParametersLayoutGroup";
            this.generalParametersLayoutGroup.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.generalParametersLayoutGroup.Size = new System.Drawing.Size(1236, 412);
            this.generalParametersLayoutGroup.Spacing = new DevExpress.XtraLayout.Utils.Padding(12, 12, 12, 12);
            this.generalParametersLayoutGroup.Text = "generalParametersLayoutGroup";
            this.generalParametersLayoutGroup.TextVisible = false;
            // 
            // chemicalCompositionLayoutGroup
            // 
            this.chemicalCompositionLayoutGroup.CustomizationFormText = "Химический состав";
            this.chemicalCompositionLayoutGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.chemicalCompositionLayout});
            this.chemicalCompositionLayoutGroup.Location = new System.Drawing.Point(420, 239);
            this.chemicalCompositionLayoutGroup.Name = "chemicalCompositionLayoutGroup";
            this.chemicalCompositionLayoutGroup.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.chemicalCompositionLayoutGroup.Size = new System.Drawing.Size(788, 145);
            this.chemicalCompositionLayoutGroup.Spacing = new DevExpress.XtraLayout.Utils.Padding(10, 0, 12, 0);
            this.chemicalCompositionLayoutGroup.Text = "Химический состав";
            // 
            // chemicalCompositionLayout
            // 
            this.chemicalCompositionLayout.Control = this.chemicalComposition;
            this.chemicalCompositionLayout.CustomizationFormText = "chemicalCompositionLayout";
            this.chemicalCompositionLayout.Location = new System.Drawing.Point(0, 0);
            this.chemicalCompositionLayout.Name = "chemicalCompositionLayout";
            this.chemicalCompositionLayout.Size = new System.Drawing.Size(772, 108);
            this.chemicalCompositionLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.chemicalCompositionLayout.Text = "chemicalCompositionLayout";
            this.chemicalCompositionLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.chemicalCompositionLayout.TextSize = new System.Drawing.Size(0, 0);
            this.chemicalCompositionLayout.TextToControlDistance = 0;
            this.chemicalCompositionLayout.TextVisible = false;
            // 
            // geometricParametersLayoutGroup
            // 
            this.geometricParametersLayoutGroup.CustomizationFormText = "Геометрические параметры";
            this.geometricParametersLayoutGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lengthLayout,
            this.thicknessLayout,
            this.diameterLayout,
            this.weightLayout});
            this.geometricParametersLayoutGroup.Location = new System.Drawing.Point(0, 0);
            this.geometricParametersLayoutGroup.Name = "geometricParametersLayoutGroup";
            this.geometricParametersLayoutGroup.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.geometricParametersLayoutGroup.Size = new System.Drawing.Size(154, 239);
            this.geometricParametersLayoutGroup.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 15, 0, 14);
            this.geometricParametersLayoutGroup.Text = "Размеры";
            // 
            // lengthLayout
            // 
            this.lengthLayout.Control = this.length;
            this.lengthLayout.CustomizationFormText = "Длина, мм";
            this.lengthLayout.Location = new System.Drawing.Point(0, 0);
            this.lengthLayout.Name = "lengthLayout";
            this.lengthLayout.Size = new System.Drawing.Size(133, 51);
            this.lengthLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(10, 10, 4, 5);
            this.lengthLayout.Text = "Длина, мм";
            this.lengthLayout.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.lengthLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.lengthLayout.TextSize = new System.Drawing.Size(70, 13);
            this.lengthLayout.TextToControlDistance = 5;
            // 
            // thicknessLayout
            // 
            this.thicknessLayout.Control = this.thickness;
            this.thicknessLayout.CustomizationFormText = "Толщина, мм";
            this.thicknessLayout.Location = new System.Drawing.Point(0, 97);
            this.thicknessLayout.Name = "thicknessLayout";
            this.thicknessLayout.Size = new System.Drawing.Size(133, 49);
            this.thicknessLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(10, 10, 2, 5);
            this.thicknessLayout.Text = "Толщина, мм";
            this.thicknessLayout.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.thicknessLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.thicknessLayout.TextSize = new System.Drawing.Size(70, 13);
            this.thicknessLayout.TextToControlDistance = 5;
            // 
            // diameterLayout
            // 
            this.diameterLayout.Control = this.diameter;
            this.diameterLayout.CustomizationFormText = "Диаметр, мм";
            this.diameterLayout.Location = new System.Drawing.Point(0, 51);
            this.diameterLayout.Name = "diameterLayout";
            this.diameterLayout.Size = new System.Drawing.Size(133, 46);
            this.diameterLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(10, 10, 2, 2);
            this.diameterLayout.Text = "Диаметр, мм";
            this.diameterLayout.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.diameterLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.diameterLayout.TextSize = new System.Drawing.Size(70, 13);
            this.diameterLayout.TextToControlDistance = 5;
            // 
            // weightLayout
            // 
            this.weightLayout.Control = this.weight;
            this.weightLayout.CustomizationFormText = "Вес, кг";
            this.weightLayout.Location = new System.Drawing.Point(0, 146);
            this.weightLayout.Name = "weightLayout";
            this.weightLayout.Size = new System.Drawing.Size(133, 54);
            this.weightLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(10, 10, 2, 10);
            this.weightLayout.Text = "Вес, кг";
            this.weightLayout.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.weightLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.weightLayout.TextSize = new System.Drawing.Size(70, 13);
            this.weightLayout.TextToControlDistance = 5;
            // 
            // shipmentParametersLayoutGroup
            // 
            this.shipmentParametersLayoutGroup.CustomizationFormText = "Параметры отгрузки";
            this.shipmentParametersLayoutGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.railcarNumberLayout,
            this.shiptedDateLayout,
            this.certificateLayout,
            this.destinationLayout});
            this.shipmentParametersLayoutGroup.Location = new System.Drawing.Point(0, 239);
            this.shipmentParametersLayoutGroup.Name = "shipmentParametersLayoutGroup";
            this.shipmentParametersLayoutGroup.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.shipmentParametersLayoutGroup.Size = new System.Drawing.Size(420, 145);
            this.shipmentParametersLayoutGroup.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 15, 12, 0);
            this.shipmentParametersLayoutGroup.Text = "Параметры отгрузки";
            // 
            // railcarNumberLayout
            // 
            this.railcarNumberLayout.Control = this.railcarNumber;
            this.railcarNumberLayout.CustomizationFormText = "layoutControlItem1";
            this.railcarNumberLayout.Location = new System.Drawing.Point(0, 0);
            this.railcarNumberLayout.Name = "railcarNumberLayout";
            this.railcarNumberLayout.Size = new System.Drawing.Size(156, 49);
            this.railcarNumberLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(10, 10, 4, 5);
            this.railcarNumberLayout.Text = "Номер вагона";
            this.railcarNumberLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.railcarNumberLayout.TextSize = new System.Drawing.Size(101, 13);
            // 
            // shiptedDateLayout
            // 
            this.shiptedDateLayout.Control = this.shippedDate;
            this.shiptedDateLayout.CustomizationFormText = "Дата отгрузки";
            this.shiptedDateLayout.Location = new System.Drawing.Point(0, 49);
            this.shiptedDateLayout.Name = "shiptedDateLayout";
            this.shiptedDateLayout.Size = new System.Drawing.Size(156, 59);
            this.shiptedDateLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(10, 10, 4, 5);
            this.shiptedDateLayout.Text = "Дата отгрузки";
            this.shiptedDateLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.shiptedDateLayout.TextSize = new System.Drawing.Size(101, 13);
            // 
            // certificateLayout
            // 
            this.certificateLayout.Control = this.certificateNumber;
            this.certificateLayout.CustomizationFormText = "Номер сертификата";
            this.certificateLayout.Location = new System.Drawing.Point(156, 0);
            this.certificateLayout.Name = "certificateLayout";
            this.certificateLayout.Size = new System.Drawing.Size(243, 49);
            this.certificateLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 10, 4, 5);
            this.certificateLayout.Text = "Номер сертификата";
            this.certificateLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.certificateLayout.TextSize = new System.Drawing.Size(101, 13);
            // 
            // destinationLayout
            // 
            this.destinationLayout.Control = this.destanation;
            this.destinationLayout.CustomizationFormText = "Получатель";
            this.destinationLayout.Location = new System.Drawing.Point(156, 49);
            this.destinationLayout.Name = "destinationLayout";
            this.destinationLayout.Size = new System.Drawing.Size(243, 59);
            this.destinationLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 10, 4, 5);
            this.destinationLayout.Text = "Получатель";
            this.destinationLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.destinationLayout.TextSize = new System.Drawing.Size(101, 13);
            // 
            // coatingParametersLayoutGroup
            // 
            this.coatingParametersLayoutGroup.CustomizationFormText = "Параметры покрытия";
            this.coatingParametersLayoutGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.coatingHistoryLayout,
            this.coatingDateLayout,
            this.coatingTypeaLyout,
            this.cpatingParametersEmptySpace,
            this.addCoatingButtonLayout,
            this.coatingAddButtonEmptySpace});
            this.coatingParametersLayoutGroup.Location = new System.Drawing.Point(761, 0);
            this.coatingParametersLayoutGroup.Name = "coatingParametersLayoutGroup";
            this.coatingParametersLayoutGroup.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.coatingParametersLayoutGroup.Size = new System.Drawing.Size(447, 239);
            this.coatingParametersLayoutGroup.Spacing = new DevExpress.XtraLayout.Utils.Padding(10, 0, 0, 14);
            this.coatingParametersLayoutGroup.Text = "Параметры покрытия";
            // 
            // coatingHistoryLayout
            // 
            this.coatingHistoryLayout.Control = this.coatingHistory;
            this.coatingHistoryLayout.CustomizationFormText = "coatingHistoryLayout";
            this.coatingHistoryLayout.Location = new System.Drawing.Point(0, 50);
            this.coatingHistoryLayout.Name = "coatingHistoryLayout";
            this.coatingHistoryLayout.Size = new System.Drawing.Size(431, 150);
            this.coatingHistoryLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(10, 10, 7, 7);
            this.coatingHistoryLayout.Text = "coatingHistoryLayout";
            this.coatingHistoryLayout.TextSize = new System.Drawing.Size(0, 0);
            this.coatingHistoryLayout.TextToControlDistance = 0;
            this.coatingHistoryLayout.TextVisible = false;
            // 
            // coatingDateLayout
            // 
            this.coatingDateLayout.Control = this.coatingDate;
            this.coatingDateLayout.CustomizationFormText = "Дата покрытия";
            this.coatingDateLayout.Location = new System.Drawing.Point(0, 0);
            this.coatingDateLayout.Name = "coatingDateLayout";
            this.coatingDateLayout.Size = new System.Drawing.Size(150, 50);
            this.coatingDateLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(10, 10, 5, 5);
            this.coatingDateLayout.Text = "Дата покрытия";
            this.coatingDateLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.coatingDateLayout.TextSize = new System.Drawing.Size(101, 13);
            // 
            // coatingTypeaLyout
            // 
            this.coatingTypeaLyout.Control = this.coatingType;
            this.coatingTypeaLyout.CustomizationFormText = "Тип покрытия";
            this.coatingTypeaLyout.Location = new System.Drawing.Point(150, 0);
            this.coatingTypeaLyout.Name = "coatingTypeaLyout";
            this.coatingTypeaLyout.Size = new System.Drawing.Size(150, 50);
            this.coatingTypeaLyout.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 10, 5, 5);
            this.coatingTypeaLyout.Text = "Тип покрытия";
            this.coatingTypeaLyout.TextLocation = DevExpress.Utils.Locations.Top;
            this.coatingTypeaLyout.TextSize = new System.Drawing.Size(101, 13);
            // 
            // cpatingParametersEmptySpace
            // 
            this.cpatingParametersEmptySpace.AllowHotTrack = false;
            this.cpatingParametersEmptySpace.CustomizationFormText = "cpatingParametersEmptySpace";
            this.cpatingParametersEmptySpace.Location = new System.Drawing.Point(411, 0);
            this.cpatingParametersEmptySpace.Name = "cpatingParametersEmptySpace";
            this.cpatingParametersEmptySpace.Size = new System.Drawing.Size(20, 50);
            this.cpatingParametersEmptySpace.Text = "cpatingParametersEmptySpace";
            this.cpatingParametersEmptySpace.TextSize = new System.Drawing.Size(0, 0);
            // 
            // addCoatingButtonLayout
            // 
            this.addCoatingButtonLayout.Control = this.addCoatingButton;
            this.addCoatingButtonLayout.CustomizationFormText = "addCoatingButtonLayout";
            this.addCoatingButtonLayout.Location = new System.Drawing.Point(300, 14);
            this.addCoatingButtonLayout.Name = "addCoatingButtonLayout";
            this.addCoatingButtonLayout.Size = new System.Drawing.Size(111, 36);
            this.addCoatingButtonLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 10, 5, 5);
            this.addCoatingButtonLayout.Text = "addCoatingButtonLayout";
            this.addCoatingButtonLayout.TextSize = new System.Drawing.Size(0, 0);
            this.addCoatingButtonLayout.TextToControlDistance = 0;
            this.addCoatingButtonLayout.TextVisible = false;
            // 
            // coatingAddButtonEmptySpace
            // 
            this.coatingAddButtonEmptySpace.AllowHotTrack = false;
            this.coatingAddButtonEmptySpace.CustomizationFormText = "coatingAddButtonEmptySpace";
            this.coatingAddButtonEmptySpace.Location = new System.Drawing.Point(300, 0);
            this.coatingAddButtonEmptySpace.Name = "coatingAddButtonEmptySpace";
            this.coatingAddButtonEmptySpace.Size = new System.Drawing.Size(111, 14);
            this.coatingAddButtonEmptySpace.Text = "coatingAddButtonEmptySpace";
            this.coatingAddButtonEmptySpace.TextSize = new System.Drawing.Size(0, 0);
            // 
            // weldingParametersLayoutGroup
            // 
            this.weldingParametersLayoutGroup.CustomizationFormText = "Параметры сварки";
            this.weldingParametersLayoutGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.weldingHistoryLayout,
            this.weldingDateLayout,
            this.addWeldingButtonLayout,
            this.weldersLayout,
            this.weldinAddButtonEmptySpace,
            this.weldingParametersEmpty});
            this.weldingParametersLayoutGroup.Location = new System.Drawing.Point(154, 0);
            this.weldingParametersLayoutGroup.Name = "weldingParametersLayoutGroup";
            this.weldingParametersLayoutGroup.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.weldingParametersLayoutGroup.Size = new System.Drawing.Size(607, 239);
            this.weldingParametersLayoutGroup.Spacing = new DevExpress.XtraLayout.Utils.Padding(10, 15, 0, 14);
            this.weldingParametersLayoutGroup.Text = "Параметры сварки";
            // 
            // weldingHistoryLayout
            // 
            this.weldingHistoryLayout.Control = this.weldingHistory;
            this.weldingHistoryLayout.CustomizationFormText = "Сварщики";
            this.weldingHistoryLayout.Location = new System.Drawing.Point(0, 50);
            this.weldingHistoryLayout.Name = "weldingHistoryLayout";
            this.weldingHistoryLayout.Size = new System.Drawing.Size(576, 150);
            this.weldingHistoryLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(10, 10, 7, 10);
            this.weldingHistoryLayout.Text = "Сварщики";
            this.weldingHistoryLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.weldingHistoryLayout.TextSize = new System.Drawing.Size(0, 0);
            this.weldingHistoryLayout.TextToControlDistance = 0;
            this.weldingHistoryLayout.TextVisible = false;
            // 
            // weldingDateLayout
            // 
            this.weldingDateLayout.Control = this.weldingDate;
            this.weldingDateLayout.CustomizationFormText = "Дата сварки";
            this.weldingDateLayout.Location = new System.Drawing.Point(0, 0);
            this.weldingDateLayout.Name = "weldingDateLayout";
            this.weldingDateLayout.Size = new System.Drawing.Size(127, 50);
            this.weldingDateLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(10, 10, 5, 5);
            this.weldingDateLayout.Text = "Дата сварки";
            this.weldingDateLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.weldingDateLayout.TextSize = new System.Drawing.Size(101, 13);
            // 
            // addWeldingButtonLayout
            // 
            this.addWeldingButtonLayout.Control = this.addWeldingButton;
            this.addWeldingButtonLayout.CustomizationFormText = "addWeldingButtonLayout";
            this.addWeldingButtonLayout.Location = new System.Drawing.Point(327, 14);
            this.addWeldingButtonLayout.Name = "addWeldingButtonLayout";
            this.addWeldingButtonLayout.Size = new System.Drawing.Size(111, 36);
            this.addWeldingButtonLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 10, 5, 5);
            this.addWeldingButtonLayout.Text = "addWeldingButtonLayout";
            this.addWeldingButtonLayout.TextSize = new System.Drawing.Size(0, 0);
            this.addWeldingButtonLayout.TextToControlDistance = 0;
            this.addWeldingButtonLayout.TextVisible = false;
            // 
            // weldersLayout
            // 
            this.weldersLayout.Control = this.welders;
            this.weldersLayout.CustomizationFormText = "Сварщики";
            this.weldersLayout.Location = new System.Drawing.Point(127, 0);
            this.weldersLayout.Name = "weldersLayout";
            this.weldersLayout.Size = new System.Drawing.Size(200, 50);
            this.weldersLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 10, 5, 5);
            this.weldersLayout.Text = "Сварщики";
            this.weldersLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.weldersLayout.TextSize = new System.Drawing.Size(101, 13);
            // 
            // weldinAddButtonEmptySpace
            // 
            this.weldinAddButtonEmptySpace.AllowHotTrack = false;
            this.weldinAddButtonEmptySpace.CustomizationFormText = "weldinAddButtonEmptySpace";
            this.weldinAddButtonEmptySpace.Location = new System.Drawing.Point(327, 0);
            this.weldinAddButtonEmptySpace.Name = "weldinAddButtonEmptySpace";
            this.weldinAddButtonEmptySpace.Size = new System.Drawing.Size(111, 14);
            this.weldinAddButtonEmptySpace.Text = "weldinAddButtonEmptySpace";
            this.weldinAddButtonEmptySpace.TextSize = new System.Drawing.Size(0, 0);
            // 
            // weldingParametersEmpty
            // 
            this.weldingParametersEmpty.AllowHotTrack = false;
            this.weldingParametersEmpty.CustomizationFormText = "weldingParametersEmpty";
            this.weldingParametersEmpty.Location = new System.Drawing.Point(438, 0);
            this.weldingParametersEmpty.Name = "weldingParametersEmpty";
            this.weldingParametersEmpty.Size = new System.Drawing.Size(138, 50);
            this.weldingParametersEmpty.Text = "weldingParametersEmpty";
            this.weldingParametersEmpty.TextSize = new System.Drawing.Size(0, 0);
            // 
            // heatPlateParametersPage
            // 
            this.heatPlateParametersPage.Controls.Add(this.tabPagesLayout);
            this.heatPlateParametersPage.Name = "heatPlateParametersPage";
            this.heatPlateParametersPage.Size = new System.Drawing.Size(1236, 412);
            this.heatPlateParametersPage.Text = "&Параметры плавки и листа";
            // 
            // tabPagesLayout
            // 
            this.tabPagesLayout.Controls.Add(this.tensileTests);
            this.tabPagesLayout.Controls.Add(this.plateThickness);
            this.tabPagesLayout.Controls.Add(this.steelGrade);
            this.tabPagesLayout.Controls.Add(this.editHeatButton);
            this.tabPagesLayout.Controls.Add(this.plateChemicalComposition);
            this.tabPagesLayout.Controls.Add(this.ladelMechanicalProperties);
            this.tabPagesLayout.Controls.Add(this.ladleChemicalComposition);
            this.tabPagesLayout.Controls.Add(this.plateManufacturer);
            this.tabPagesLayout.Location = new System.Drawing.Point(0, 0);
            this.tabPagesLayout.Name = "tabPagesLayout";
            this.tabPagesLayout.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(120, 637, 250, 350);
            this.tabPagesLayout.Root = this.heatLayoutGroup;
            this.tabPagesLayout.Size = new System.Drawing.Size(1236, 406);
            this.tabPagesLayout.TabIndex = 0;
            this.tabPagesLayout.Text = "layoutControl3";
            // 
            // tensileTests
            // 
            this.tensileTests.Cursor = System.Windows.Forms.Cursors.Default;
            this.tensileTests.Location = new System.Drawing.Point(920, 117);
            this.tensileTests.MainView = this.tensileTestsGridView;
            this.tensileTests.Name = "tensileTests";
            this.tensileTests.Size = new System.Drawing.Size(274, 250);
            this.tensileTests.TabIndex = 32;
            this.tensileTests.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.tensileTestsGridView});
            // 
            // tensileTestsGridView
            // 
            this.tensileTestsGridView.GridControl = this.tensileTests;
            this.tensileTestsGridView.Name = "tensileTestsGridView";
            this.tensileTestsGridView.OptionsView.ShowGroupPanel = false;
            // 
            // plateThickness
            // 
            this.plateThickness.Location = new System.Drawing.Point(789, 67);
            this.plateThickness.Name = "plateThickness";
            this.plateThickness.Size = new System.Drawing.Size(161, 20);
            this.plateThickness.StyleController = this.tabPagesLayout;
            this.plateThickness.TabIndex = 31;
            // 
            // steelGrade
            // 
            this.steelGrade.Location = new System.Drawing.Point(969, 67);
            this.steelGrade.Name = "steelGrade";
            this.steelGrade.Size = new System.Drawing.Size(161, 20);
            this.steelGrade.StyleController = this.tabPagesLayout;
            this.steelGrade.TabIndex = 30;
            // 
            // editHeatButton
            // 
            this.editHeatButton.Location = new System.Drawing.Point(34, 54);
            this.editHeatButton.Name = "editHeatButton";
            this.editHeatButton.Size = new System.Drawing.Size(108, 22);
            this.editHeatButton.StyleController = this.tabPagesLayout;
            this.editHeatButton.TabIndex = 29;
            this.editHeatButton.Text = "Редактировать";
            // 
            // plateChemicalComposition
            // 
            this.plateChemicalComposition.Cursor = System.Windows.Forms.Cursors.Default;
            this.plateChemicalComposition.Location = new System.Drawing.Point(601, 117);
            this.plateChemicalComposition.MainView = this.plateChemicalCompositionGridView;
            this.plateChemicalComposition.Name = "plateChemicalComposition";
            this.plateChemicalComposition.Size = new System.Drawing.Size(295, 250);
            this.plateChemicalComposition.TabIndex = 29;
            this.plateChemicalComposition.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.plateChemicalCompositionGridView});
            // 
            // plateChemicalCompositionGridView
            // 
            this.plateChemicalCompositionGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.plateElementNameGridColumn,
            this.plateElementQuantityGridColumn});
            this.plateChemicalCompositionGridView.GridControl = this.plateChemicalComposition;
            this.plateChemicalCompositionGridView.Name = "plateChemicalCompositionGridView";
            this.plateChemicalCompositionGridView.OptionsView.ShowGroupPanel = false;
            // 
            // plateElementNameGridColumn
            // 
            this.plateElementNameGridColumn.Caption = "Название";
            this.plateElementNameGridColumn.Name = "plateElementNameGridColumn";
            this.plateElementNameGridColumn.Visible = true;
            this.plateElementNameGridColumn.VisibleIndex = 0;
            // 
            // plateElementQuantityGridColumn
            // 
            this.plateElementQuantityGridColumn.Caption = "Количество";
            this.plateElementQuantityGridColumn.Name = "plateElementQuantityGridColumn";
            this.plateElementQuantityGridColumn.Visible = true;
            this.plateElementQuantityGridColumn.VisibleIndex = 1;
            // 
            // ladelMechanicalProperties
            // 
            this.ladelMechanicalProperties.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ladelMechanicalProperties.Cursor = System.Windows.Forms.Cursors.Default;
            this.ladelMechanicalProperties.Location = new System.Drawing.Point(296, 106);
            this.ladelMechanicalProperties.MainView = this.ladelMechanicalPropertiesGridView;
            this.ladelMechanicalProperties.Name = "ladelMechanicalProperties";
            this.ladelMechanicalProperties.Size = new System.Drawing.Size(244, 261);
            this.ladelMechanicalProperties.TabIndex = 28;
            this.ladelMechanicalProperties.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.ladelMechanicalPropertiesGridView});
            // 
            // ladelMechanicalPropertiesGridView
            // 
            this.ladelMechanicalPropertiesGridView.GridControl = this.ladelMechanicalProperties;
            this.ladelMechanicalPropertiesGridView.Name = "ladelMechanicalPropertiesGridView";
            this.ladelMechanicalPropertiesGridView.OptionsView.ShowGroupPanel = false;
            // 
            // ladleChemicalComposition
            // 
            this.ladleChemicalComposition.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ladleChemicalComposition.Cursor = System.Windows.Forms.Cursors.Default;
            this.ladleChemicalComposition.Location = new System.Drawing.Point(34, 106);
            this.ladleChemicalComposition.MainView = this.ladleChemicalCompositionView;
            this.ladleChemicalComposition.Name = "ladleChemicalComposition";
            this.ladleChemicalComposition.Size = new System.Drawing.Size(238, 261);
            this.ladleChemicalComposition.TabIndex = 28;
            this.ladleChemicalComposition.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.ladleChemicalCompositionView});
            // 
            // ladleChemicalCompositionView
            // 
            this.ladleChemicalCompositionView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.elementNameLadleCompositionGridColumn,
            this.elementQuantityLadleGridColumn});
            this.ladleChemicalCompositionView.GridControl = this.ladleChemicalComposition;
            this.ladleChemicalCompositionView.Name = "ladleChemicalCompositionView";
            this.ladleChemicalCompositionView.OptionsView.ShowGroupPanel = false;
            // 
            // elementNameLadleCompositionGridColumn
            // 
            this.elementNameLadleCompositionGridColumn.Caption = "Название";
            this.elementNameLadleCompositionGridColumn.Name = "elementNameLadleCompositionGridColumn";
            this.elementNameLadleCompositionGridColumn.Visible = true;
            this.elementNameLadleCompositionGridColumn.VisibleIndex = 0;
            // 
            // elementQuantityLadleGridColumn
            // 
            this.elementQuantityLadleGridColumn.Caption = "Количество";
            this.elementQuantityLadleGridColumn.Name = "elementQuantityLadleGridColumn";
            this.elementQuantityLadleGridColumn.Visible = true;
            this.elementQuantityLadleGridColumn.VisibleIndex = 1;
            // 
            // plateManufacturer
            // 
            this.plateManufacturer.Location = new System.Drawing.Point(601, 67);
            this.plateManufacturer.Name = "plateManufacturer";
            this.plateManufacturer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.plateManufacturer.Size = new System.Drawing.Size(169, 20);
            this.plateManufacturer.StyleController = this.tabPagesLayout;
            this.plateManufacturer.TabIndex = 28;
            // 
            // heatLayoutGroup
            // 
            this.heatLayoutGroup.CustomizationFormText = "Root";
            this.heatLayoutGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.heatLayoutGroup.GroupBordersVisible = false;
            this.heatLayoutGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.heatParametersLayoutGroup,
            this.plateParametersLayoutGroup});
            this.heatLayoutGroup.Location = new System.Drawing.Point(0, 0);
            this.heatLayoutGroup.Name = "Root";
            this.heatLayoutGroup.Size = new System.Drawing.Size(1236, 406);
            this.heatLayoutGroup.Text = "Root";
            this.heatLayoutGroup.TextVisible = false;
            // 
            // heatParametersLayoutGroup
            // 
            this.heatParametersLayoutGroup.CustomizationFormText = "Параметры плавки";
            this.heatParametersLayoutGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ladelChemicalCompositionLayout,
            this.heatSplitter,
            this.ladelMechanicalPropertiesLayout,
            this.editHeatButtonEmptySpace,
            this.editHeatButtonLayout});
            this.heatParametersLayoutGroup.Location = new System.Drawing.Point(0, 0);
            this.heatParametersLayoutGroup.Name = "heatParametersLayoutGroup";
            this.heatParametersLayoutGroup.Size = new System.Drawing.Size(562, 386);
            this.heatParametersLayoutGroup.Spacing = new DevExpress.XtraLayout.Utils.Padding(10, 15, 8, 15);
            this.heatParametersLayoutGroup.Text = "Параметры плавки";
            // 
            // ladelChemicalCompositionLayout
            // 
            this.ladelChemicalCompositionLayout.Control = this.ladleChemicalComposition;
            this.ladelChemicalCompositionLayout.CustomizationFormText = "Ковшовой химический состав";
            this.ladelChemicalCompositionLayout.Location = new System.Drawing.Point(0, 36);
            this.ladelChemicalCompositionLayout.Name = "ladelChemicalCompositionLayout";
            this.ladelChemicalCompositionLayout.Size = new System.Drawing.Size(254, 288);
            this.ladelChemicalCompositionLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 10, 5, 2);
            this.ladelChemicalCompositionLayout.Text = "Ковшовой химический состав";
            this.ladelChemicalCompositionLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.ladelChemicalCompositionLayout.TextSize = new System.Drawing.Size(161, 13);
            // 
            // heatSplitter
            // 
            this.heatSplitter.AllowHotTrack = true;
            this.heatSplitter.CustomizationFormText = "heatSplitter";
            this.heatSplitter.Location = new System.Drawing.Point(254, 36);
            this.heatSplitter.Name = "heatSplitter";
            this.heatSplitter.Size = new System.Drawing.Size(5, 288);
            // 
            // ladelMechanicalPropertiesLayout
            // 
            this.ladelMechanicalPropertiesLayout.Control = this.ladelMechanicalProperties;
            this.ladelMechanicalPropertiesLayout.CustomizationFormText = "Механические свойства плавки";
            this.ladelMechanicalPropertiesLayout.Location = new System.Drawing.Point(259, 36);
            this.ladelMechanicalPropertiesLayout.Name = "ladelMechanicalPropertiesLayout";
            this.ladelMechanicalPropertiesLayout.Size = new System.Drawing.Size(258, 288);
            this.ladelMechanicalPropertiesLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 2);
            this.ladelMechanicalPropertiesLayout.Text = "Механические свойства плавки";
            this.ladelMechanicalPropertiesLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.ladelMechanicalPropertiesLayout.TextSize = new System.Drawing.Size(161, 13);
            // 
            // editHeatButtonEmptySpace
            // 
            this.editHeatButtonEmptySpace.AllowHotTrack = false;
            this.editHeatButtonEmptySpace.CustomizationFormText = "editHeatButtonEmptySpace";
            this.editHeatButtonEmptySpace.Location = new System.Drawing.Point(124, 0);
            this.editHeatButtonEmptySpace.Name = "editHeatButtonEmptySpace";
            this.editHeatButtonEmptySpace.Size = new System.Drawing.Size(393, 36);
            this.editHeatButtonEmptySpace.Text = "editHeatButtonEmptySpace";
            this.editHeatButtonEmptySpace.TextSize = new System.Drawing.Size(0, 0);
            // 
            // editHeatButtonLayout
            // 
            this.editHeatButtonLayout.Control = this.editHeatButton;
            this.editHeatButtonLayout.CustomizationFormText = "editHeatButtonLayout";
            this.editHeatButtonLayout.Location = new System.Drawing.Point(0, 0);
            this.editHeatButtonLayout.Name = "editHeatButtonLayout";
            this.editHeatButtonLayout.Size = new System.Drawing.Size(124, 36);
            this.editHeatButtonLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 10, 5, 5);
            this.editHeatButtonLayout.Text = "editHeatButtonLayout";
            this.editHeatButtonLayout.TextSize = new System.Drawing.Size(0, 0);
            this.editHeatButtonLayout.TextToControlDistance = 0;
            this.editHeatButtonLayout.TextVisible = false;
            // 
            // plateParametersLayoutGroup
            // 
            this.plateParametersLayoutGroup.CustomizationFormText = "Параметры листа";
            this.plateParametersLayoutGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.plateSplitter,
            this.plateManufacturerLayout,
            this.steelGradeLayout,
            this.plateThicknessLayout,
            this.steelGradeEmptySpace,
            this.plateChemicalCompositionLayout,
            this.tensileTestsLayout});
            this.plateParametersLayoutGroup.Location = new System.Drawing.Point(562, 0);
            this.plateParametersLayoutGroup.Name = "plateParametersLayoutGroup";
            this.plateParametersLayoutGroup.Size = new System.Drawing.Size(654, 386);
            this.plateParametersLayoutGroup.Spacing = new DevExpress.XtraLayout.Utils.Padding(15, 15, 8, 15);
            this.plateParametersLayoutGroup.Text = "Параметры листа";
            // 
            // plateSplitter
            // 
            this.plateSplitter.AllowHotTrack = true;
            this.plateSplitter.CustomizationFormText = "plateSplitter";
            this.plateSplitter.Location = new System.Drawing.Point(311, 47);
            this.plateSplitter.Name = "plateSplitter";
            this.plateSplitter.Size = new System.Drawing.Size(5, 277);
            // 
            // plateManufacturerLayout
            // 
            this.plateManufacturerLayout.Control = this.plateManufacturer;
            this.plateManufacturerLayout.CustomizationFormText = "Производитель листа";
            this.plateManufacturerLayout.Location = new System.Drawing.Point(0, 0);
            this.plateManufacturerLayout.Name = "plateManufacturerLayout";
            this.plateManufacturerLayout.Size = new System.Drawing.Size(185, 47);
            this.plateManufacturerLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 10, 2, 5);
            this.plateManufacturerLayout.Text = "Производитель листа";
            this.plateManufacturerLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.plateManufacturerLayout.TextSize = new System.Drawing.Size(161, 13);
            // 
            // steelGradeLayout
            // 
            this.steelGradeLayout.Control = this.steelGrade;
            this.steelGradeLayout.CustomizationFormText = "Марка стали";
            this.steelGradeLayout.Location = new System.Drawing.Point(365, 0);
            this.steelGradeLayout.Name = "steelGradeLayout";
            this.steelGradeLayout.Size = new System.Drawing.Size(180, 47);
            this.steelGradeLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 10, 2, 5);
            this.steelGradeLayout.Text = "Марка стали";
            this.steelGradeLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.steelGradeLayout.TextSize = new System.Drawing.Size(161, 13);
            // 
            // plateThicknessLayout
            // 
            this.plateThicknessLayout.Control = this.plateThickness;
            this.plateThicknessLayout.CustomizationFormText = "Толщина листа";
            this.plateThicknessLayout.Location = new System.Drawing.Point(185, 0);
            this.plateThicknessLayout.Name = "plateThicknessLayout";
            this.plateThicknessLayout.Size = new System.Drawing.Size(180, 47);
            this.plateThicknessLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 10, 2, 5);
            this.plateThicknessLayout.Text = "Толщина листа";
            this.plateThicknessLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.plateThicknessLayout.TextSize = new System.Drawing.Size(161, 13);
            // 
            // steelGradeEmptySpace
            // 
            this.steelGradeEmptySpace.AllowHotTrack = false;
            this.steelGradeEmptySpace.CustomizationFormText = "steelGradeEmptySpace";
            this.steelGradeEmptySpace.Location = new System.Drawing.Point(545, 0);
            this.steelGradeEmptySpace.Name = "steelGradeEmptySpace";
            this.steelGradeEmptySpace.Size = new System.Drawing.Size(59, 47);
            this.steelGradeEmptySpace.Text = "steelGradeEmptySpace";
            this.steelGradeEmptySpace.TextSize = new System.Drawing.Size(0, 0);
            // 
            // plateChemicalCompositionLayout
            // 
            this.plateChemicalCompositionLayout.Control = this.plateChemicalComposition;
            this.plateChemicalCompositionLayout.CustomizationFormText = "Химический состав листа";
            this.plateChemicalCompositionLayout.Location = new System.Drawing.Point(0, 47);
            this.plateChemicalCompositionLayout.Name = "plateChemicalCompositionLayout";
            this.plateChemicalCompositionLayout.Size = new System.Drawing.Size(311, 277);
            this.plateChemicalCompositionLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 10, 5, 2);
            this.plateChemicalCompositionLayout.Text = "Химический состав листа";
            this.plateChemicalCompositionLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.plateChemicalCompositionLayout.TextSize = new System.Drawing.Size(161, 13);
            // 
            // tensileTestsLayout
            // 
            this.tensileTestsLayout.Control = this.tensileTests;
            this.tensileTestsLayout.CustomizationFormText = "Тесты растяжения";
            this.tensileTestsLayout.Location = new System.Drawing.Point(316, 47);
            this.tensileTestsLayout.Name = "tensileTestsLayout";
            this.tensileTestsLayout.Size = new System.Drawing.Size(288, 277);
            this.tensileTestsLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 2);
            this.tensileTestsLayout.Text = "Тесты растяжения";
            this.tensileTestsLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.tensileTestsLayout.TextSize = new System.Drawing.Size(161, 13);
            // 
            // inspectionPage
            // 
            this.inspectionPage.Controls.Add(this.layoutControl1);
            this.inspectionPage.Name = "inspectionPage";
            this.inspectionPage.Size = new System.Drawing.Size(1236, 412);
            this.inspectionPage.Text = "&Контрольные операции";
            // 
            // inspectionOperation
            // 
            this.inspectionOperation.DataSource = typeof(PrizmMain.DummyData.InspectionDummy);
            // 
            // pipeSize
            // 
            this.pipeSize.Location = new System.Drawing.Point(232, 27);
            this.pipeSize.Name = "pipeSize";
            this.pipeSize.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.pipeSize.Size = new System.Drawing.Size(167, 20);
            this.pipeSize.StyleController = this.generalPipeLayout;
            this.pipeSize.TabIndex = 1;
            // 
            // generalPipeLayout
            // 
            this.generalPipeLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.generalPipeLayout.Controls.Add(this.closeButton);
            this.generalPipeLayout.Controls.Add(this.deactivate);
            this.generalPipeLayout.Controls.Add(this.saveButton);
            this.generalPipeLayout.Controls.Add(this.attachmentsButton);
            this.generalPipeLayout.Controls.Add(this.purchaseOrderDate);
            this.generalPipeLayout.Controls.Add(this.purchaseOrder);
            this.generalPipeLayout.Controls.Add(this.pipe);
            this.generalPipeLayout.Controls.Add(this.heatNumber);
            this.generalPipeLayout.Controls.Add(this.pipeCreationDate);
            this.generalPipeLayout.Controls.Add(this.millStatus);
            this.generalPipeLayout.Controls.Add(this.pipeNumber);
            this.generalPipeLayout.Controls.Add(this.pipeSize);
            this.generalPipeLayout.Location = new System.Drawing.Point(0, 0);
            this.generalPipeLayout.Name = "generalPipeLayout";
            this.generalPipeLayout.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(39, 272, 250, 350);
            this.generalPipeLayout.Root = this.generalLayoutGroup;
            this.generalPipeLayout.Size = new System.Drawing.Size(1275, 545);
            this.generalPipeLayout.TabIndex = 24;
            this.generalPipeLayout.Text = "layoutControl1";
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(1160, 514);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(91, 22);
            this.closeButton.StyleController = this.generalPipeLayout;
            this.closeButton.TabIndex = 27;
            this.closeButton.Text = "Закрыть";
            // 
            // deactivate
            // 
            this.deactivate.Location = new System.Drawing.Point(142, 514);
            this.deactivate.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.deactivate.Name = "deactivate";
            this.deactivate.Properties.Caption = "Труба деактивирована";
            this.deactivate.Size = new System.Drawing.Size(881, 19);
            this.deactivate.StyleController = this.generalPipeLayout;
            this.deactivate.TabIndex = 28;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(1057, 514);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(89, 22);
            this.saveButton.StyleController = this.generalPipeLayout;
            this.saveButton.TabIndex = 26;
            this.saveButton.Text = "Сохранить";
            // 
            // attachmentsButton
            // 
            this.attachmentsButton.Location = new System.Drawing.Point(14, 514);
            this.attachmentsButton.Name = "attachmentsButton";
            this.attachmentsButton.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.attachmentsButton.Size = new System.Drawing.Size(99, 22);
            this.attachmentsButton.StyleController = this.generalPipeLayout;
            this.attachmentsButton.TabIndex = 25;
            this.attachmentsButton.Text = "Вложения";
            // 
            // purchaseOrderDate
            // 
            this.purchaseOrderDate.EditValue = null;
            this.purchaseOrderDate.Location = new System.Drawing.Point(835, 27);
            this.purchaseOrderDate.Name = "purchaseOrderDate";
            this.purchaseOrderDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.purchaseOrderDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.purchaseOrderDate.Size = new System.Drawing.Size(100, 20);
            this.purchaseOrderDate.StyleController = this.generalPipeLayout;
            this.purchaseOrderDate.TabIndex = 6;
            // 
            // purchaseOrder
            // 
            this.purchaseOrder.Location = new System.Drawing.Point(634, 27);
            this.purchaseOrder.Name = "purchaseOrder";
            this.purchaseOrder.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.purchaseOrder.Size = new System.Drawing.Size(167, 20);
            this.purchaseOrder.StyleController = this.generalPipeLayout;
            this.purchaseOrder.TabIndex = 5;
            // 
            // heatNumber
            // 
            this.heatNumber.Location = new System.Drawing.Point(433, 27);
            this.heatNumber.Name = "heatNumber";
            this.heatNumber.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.heatNumber.Size = new System.Drawing.Size(167, 20);
            this.heatNumber.StyleController = this.generalPipeLayout;
            this.heatNumber.TabIndex = 2;
            // 
            // pipeCreationDate
            // 
            this.pipeCreationDate.EditValue = null;
            this.pipeCreationDate.Location = new System.Drawing.Point(969, 27);
            this.pipeCreationDate.Name = "pipeCreationDate";
            this.pipeCreationDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.pipeCreationDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.pipeCreationDate.Size = new System.Drawing.Size(100, 20);
            this.pipeCreationDate.StyleController = this.generalPipeLayout;
            this.pipeCreationDate.TabIndex = 3;
            // 
            // millStatus
            // 
            this.millStatus.Location = new System.Drawing.Point(1103, 27);
            this.millStatus.Name = "millStatus";
            this.millStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.millStatus.Size = new System.Drawing.Size(148, 20);
            this.millStatus.StyleController = this.generalPipeLayout;
            this.millStatus.TabIndex = 4;
            // 
            // pipeNumber
            // 
            this.pipeNumber.Location = new System.Drawing.Point(14, 27);
            this.pipeNumber.Name = "pipeNumber";
            this.pipeNumber.Size = new System.Drawing.Size(184, 20);
            this.pipeNumber.StyleController = this.generalPipeLayout;
            this.pipeNumber.TabIndex = 0;
            // 
            // generalLayoutGroup
            // 
            this.generalLayoutGroup.CustomizationFormText = "pipeGeneralLayoutGroup";
            this.generalLayoutGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.generalLayoutGroup.GroupBordersVisible = false;
            this.generalLayoutGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.pipeNumberLayout,
            this.pipeSizeLayout,
            this.pipeLayout,
            this.heatNumberLayout,
            this.statusLayout,
            this.creationDateLayout,
            this.purhaseOrderLayout,
            this.generalPipeParametersEmpty,
            this.purhaseOrderDateLayout,
            this.attachmentsButtonLayout,
            this.deactivateLayout,
            this.saveButtonLayout,
            this.closeButtonLayout,
            this.emptySpaceItem2});
            this.generalLayoutGroup.Location = new System.Drawing.Point(0, 0);
            this.generalLayoutGroup.Name = "generalLayoutGroup";
            this.generalLayoutGroup.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.generalLayoutGroup.Size = new System.Drawing.Size(1275, 545);
            this.generalLayoutGroup.Spacing = new DevExpress.XtraLayout.Utils.Padding(10, 0, 0, 5);
            this.generalLayoutGroup.Text = "generalLayoutGroup";
            this.generalLayoutGroup.TextVisible = false;
            // 
            // pipeNumberLayout
            // 
            this.pipeNumberLayout.Control = this.pipeNumber;
            this.pipeNumberLayout.CustomizationFormText = "Pipe number";
            this.pipeNumberLayout.Location = new System.Drawing.Point(0, 0);
            this.pipeNumberLayout.Name = "pipeNumberLayout";
            this.pipeNumberLayout.Size = new System.Drawing.Size(203, 54);
            this.pipeNumberLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 15, 7, 7);
            this.pipeNumberLayout.Text = "Номер трубы";
            this.pipeNumberLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.pipeNumberLayout.TextSize = new System.Drawing.Size(99, 13);
            // 
            // pipeSizeLayout
            // 
            this.pipeSizeLayout.Control = this.pipeSize;
            this.pipeSizeLayout.CustomizationFormText = "Pipe size";
            this.pipeSizeLayout.Location = new System.Drawing.Point(203, 0);
            this.pipeSizeLayout.Name = "pipeSizeLayout";
            this.pipeSizeLayout.Size = new System.Drawing.Size(201, 54);
            this.pipeSizeLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(15, 15, 7, 7);
            this.pipeSizeLayout.Text = "Типоразмер трубы";
            this.pipeSizeLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.pipeSizeLayout.TextSize = new System.Drawing.Size(99, 13);
            // 
            // pipeLayout
            // 
            this.pipeLayout.Control = this.pipe;
            this.pipeLayout.CustomizationFormText = "pipeLayout";
            this.pipeLayout.Location = new System.Drawing.Point(0, 54);
            this.pipeLayout.Name = "pipeLayout";
            this.pipeLayout.Size = new System.Drawing.Size(1261, 456);
            this.pipeLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 15, 7, 5);
            this.pipeLayout.Text = "pipeLayout";
            this.pipeLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.pipeLayout.TextSize = new System.Drawing.Size(0, 0);
            this.pipeLayout.TextToControlDistance = 0;
            this.pipeLayout.TextVisible = false;
            // 
            // heatNumberLayout
            // 
            this.heatNumberLayout.Control = this.heatNumber;
            this.heatNumberLayout.CustomizationFormText = "Heat number";
            this.heatNumberLayout.Location = new System.Drawing.Point(404, 0);
            this.heatNumberLayout.Name = "heatNumberLayout";
            this.heatNumberLayout.Size = new System.Drawing.Size(201, 54);
            this.heatNumberLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(15, 15, 7, 7);
            this.heatNumberLayout.Text = "Номер плавки";
            this.heatNumberLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.heatNumberLayout.TextSize = new System.Drawing.Size(99, 13);
            // 
            // statusLayout
            // 
            this.statusLayout.Control = this.millStatus;
            this.statusLayout.CustomizationFormText = "Status";
            this.statusLayout.Location = new System.Drawing.Point(1074, 0);
            this.statusLayout.Name = "statusLayout";
            this.statusLayout.Size = new System.Drawing.Size(167, 54);
            this.statusLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(15, 0, 7, 7);
            this.statusLayout.Text = "Статус на заводе";
            this.statusLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.statusLayout.TextSize = new System.Drawing.Size(99, 13);
            // 
            // creationDateLayout
            // 
            this.creationDateLayout.Control = this.pipeCreationDate;
            this.creationDateLayout.CustomizationFormText = "Creation date";
            this.creationDateLayout.Location = new System.Drawing.Point(940, 0);
            this.creationDateLayout.Name = "creationDateLayout";
            this.creationDateLayout.Size = new System.Drawing.Size(134, 54);
            this.creationDateLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(15, 15, 7, 7);
            this.creationDateLayout.Text = "Дата изготовления";
            this.creationDateLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.creationDateLayout.TextSize = new System.Drawing.Size(99, 13);
            // 
            // purhaseOrderLayout
            // 
            this.purhaseOrderLayout.Control = this.purchaseOrder;
            this.purhaseOrderLayout.CustomizationFormText = "Наряд заказ";
            this.purhaseOrderLayout.Location = new System.Drawing.Point(605, 0);
            this.purhaseOrderLayout.Name = "purhaseOrderLayout";
            this.purhaseOrderLayout.Size = new System.Drawing.Size(201, 54);
            this.purhaseOrderLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(15, 15, 7, 7);
            this.purhaseOrderLayout.Text = "Наряд-заказ";
            this.purhaseOrderLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.purhaseOrderLayout.TextSize = new System.Drawing.Size(99, 13);
            // 
            // generalPipeParametersEmpty
            // 
            this.generalPipeParametersEmpty.AllowHotTrack = false;
            this.generalPipeParametersEmpty.CustomizationFormText = "generalPipeParametersEmpty";
            this.generalPipeParametersEmpty.Location = new System.Drawing.Point(1241, 0);
            this.generalPipeParametersEmpty.Name = "generalPipeParametersEmpty";
            this.generalPipeParametersEmpty.Size = new System.Drawing.Size(20, 54);
            this.generalPipeParametersEmpty.Text = "generalPipeParametersEmpty";
            this.generalPipeParametersEmpty.TextSize = new System.Drawing.Size(0, 0);
            // 
            // purhaseOrderDateLayout
            // 
            this.purhaseOrderDateLayout.Control = this.purchaseOrderDate;
            this.purhaseOrderDateLayout.CustomizationFormText = "Дата наряд-заказа";
            this.purhaseOrderDateLayout.Location = new System.Drawing.Point(806, 0);
            this.purhaseOrderDateLayout.Name = "purhaseOrderDateLayout";
            this.purhaseOrderDateLayout.Size = new System.Drawing.Size(134, 54);
            this.purhaseOrderDateLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(15, 15, 7, 7);
            this.purhaseOrderDateLayout.Text = "Дата наряд-заказа";
            this.purhaseOrderDateLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.purhaseOrderDateLayout.TextSize = new System.Drawing.Size(99, 13);
            // 
            // attachmentsButtonLayout
            // 
            this.attachmentsButtonLayout.Control = this.attachmentsButton;
            this.attachmentsButtonLayout.CustomizationFormText = "attachmentsButtonLayout";
            this.attachmentsButtonLayout.Location = new System.Drawing.Point(0, 510);
            this.attachmentsButtonLayout.Name = "attachmentsButtonLayout";
            this.attachmentsButtonLayout.Size = new System.Drawing.Size(103, 26);
            this.attachmentsButtonLayout.Text = "attachmentsButtonLayout";
            this.attachmentsButtonLayout.TextSize = new System.Drawing.Size(0, 0);
            this.attachmentsButtonLayout.TextToControlDistance = 0;
            this.attachmentsButtonLayout.TextVisible = false;
            // 
            // deactivateLayout
            // 
            this.deactivateLayout.Control = this.deactivate;
            this.deactivateLayout.CustomizationFormText = "deactivateLayout";
            this.deactivateLayout.Location = new System.Drawing.Point(103, 510);
            this.deactivateLayout.Name = "deactivateLayout";
            this.deactivateLayout.Size = new System.Drawing.Size(925, 26);
            this.deactivateLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(25, 15, 0, 0);
            this.deactivateLayout.Text = "deactivateLayout";
            this.deactivateLayout.TextSize = new System.Drawing.Size(0, 0);
            this.deactivateLayout.TextToControlDistance = 0;
            this.deactivateLayout.TextVisible = false;
            // 
            // saveButtonLayout
            // 
            this.saveButtonLayout.Control = this.saveButton;
            this.saveButtonLayout.CustomizationFormText = "saveButtonLayout";
            this.saveButtonLayout.Location = new System.Drawing.Point(1028, 510);
            this.saveButtonLayout.Name = "saveButtonLayout";
            this.saveButtonLayout.Size = new System.Drawing.Size(113, 26);
            this.saveButtonLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(15, 5, 0, 0);
            this.saveButtonLayout.Text = "saveButtonLayout";
            this.saveButtonLayout.TextSize = new System.Drawing.Size(0, 0);
            this.saveButtonLayout.TextToControlDistance = 0;
            this.saveButtonLayout.TextVisible = false;
            // 
            // closeButtonLayout
            // 
            this.closeButtonLayout.Control = this.closeButton;
            this.closeButtonLayout.CustomizationFormText = "closeButtonLayout";
            this.closeButtonLayout.Location = new System.Drawing.Point(1141, 510);
            this.closeButtonLayout.Name = "closeButtonLayout";
            this.closeButtonLayout.Size = new System.Drawing.Size(100, 26);
            this.closeButtonLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 0, 0, 0);
            this.closeButtonLayout.Text = "closeButtonLayout";
            this.closeButtonLayout.TextSize = new System.Drawing.Size(0, 0);
            this.closeButtonLayout.TextToControlDistance = 0;
            this.closeButtonLayout.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.CustomizationFormText = "emptySpaceItem2";
            this.emptySpaceItem2.Location = new System.Drawing.Point(1241, 510);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(20, 26);
            this.emptySpaceItem2.Text = "emptySpaceItem2";
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // pipeParametersLayout
            // 
            this.pipeParametersLayout.Control = this.pipe;
            this.pipeParametersLayout.CustomizationFormText = "layoutControlItem6";
            this.pipeParametersLayout.Location = new System.Drawing.Point(0, 40);
            this.pipeParametersLayout.Name = "layoutControlItem6";
            this.pipeParametersLayout.Size = new System.Drawing.Size(862, 480);
            this.pipeParametersLayout.Text = "layoutControlItem6";
            this.pipeParametersLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.pipeParametersLayout.TextSize = new System.Drawing.Size(99, 13);
            this.pipeParametersLayout.TextToControlDistance = 5;
            // 
            // certificateEmptySpace
            // 
            this.certificateEmptySpace.AllowHotTrack = false;
            this.certificateEmptySpace.CustomizationFormText = "certificateEmptySpace";
            this.certificateEmptySpace.Location = new System.Drawing.Point(351, 0);
            this.certificateEmptySpace.Name = "certificateEmptySpace";
            this.certificateEmptySpace.Size = new System.Drawing.Size(33, 50);
            this.certificateEmptySpace.Text = "certificateEmptySpace";
            this.certificateEmptySpace.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 92);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(1261, 414);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.inspections);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.inspectionsLayoutGroup;
            this.layoutControl1.Size = new System.Drawing.Size(1236, 412);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // inspectionsLayoutGroup
            // 
            this.inspectionsLayoutGroup.CustomizationFormText = "inspectionsLayoutGroup";
            this.inspectionsLayoutGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.inspectionsLayoutGroup.GroupBordersVisible = false;
            this.inspectionsLayoutGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.inspectionsLayout});
            this.inspectionsLayoutGroup.Location = new System.Drawing.Point(0, 0);
            this.inspectionsLayoutGroup.Name = "inspectionsLayoutGroup";
            this.inspectionsLayoutGroup.Size = new System.Drawing.Size(1236, 412);
            this.inspectionsLayoutGroup.Text = "inspectionsLayoutGroup";
            this.inspectionsLayoutGroup.TextVisible = false;
            // 
            // inspections
            // 
            this.inspections.AccessibleDescription = "l";
            this.inspections.Cursor = System.Windows.Forms.Cursors.Default;
            this.inspections.DataSource = this.inspectionOperation;
            this.inspections.Location = new System.Drawing.Point(14, 17);
            this.inspections.MainView = this.inspectionsGridView;
            this.inspections.Name = "inspections";
            this.inspections.Size = new System.Drawing.Size(1200, 381);
            this.inspections.TabIndex = 25;
            this.inspections.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.inspectionsGridView});
            // 
            // inspectionsGridView
            // 
            this.inspectionsGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn11,
            this.gridColumn12,
            this.gridColumn13,
            this.gridColumn14,
            this.gridColumn15,
            this.gridColumn16});
            this.inspectionsGridView.GridControl = this.inspections;
            this.inspectionsGridView.Name = "inspectionsGridView";
            this.inspectionsGridView.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Название операции";
            this.gridColumn9.FieldName = "Name";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 1;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Ожидаемый результат";
            this.gridColumn10.FieldName = "ExpectedResult";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 2;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "Результат измерения";
            this.gridColumn11.FieldName = "Measurements";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 3;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "Результат контроля";
            this.gridColumn12.FieldName = "InspectionResults";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 4;
            // 
            // gridColumn13
            // 
            this.gridColumn13.Caption = "Инспектора";
            this.gridColumn13.FieldName = "Inspectors";
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.Visible = true;
            this.gridColumn13.VisibleIndex = 5;
            // 
            // gridColumn14
            // 
            this.gridColumn14.Caption = "Дата контроля";
            this.gridColumn14.FieldName = "ControlDate";
            this.gridColumn14.Name = "gridColumn14";
            this.gridColumn14.Visible = true;
            this.gridColumn14.VisibleIndex = 6;
            // 
            // gridColumn15
            // 
            this.gridColumn15.Caption = "Комментарии ";
            this.gridColumn15.Name = "gridColumn15";
            this.gridColumn15.Visible = true;
            this.gridColumn15.VisibleIndex = 7;
            // 
            // gridColumn16
            // 
            this.gridColumn16.Caption = "Код операции";
            this.gridColumn16.FieldName = "Code";
            this.gridColumn16.Name = "gridColumn16";
            this.gridColumn16.Visible = true;
            this.gridColumn16.VisibleIndex = 0;
            // 
            // inspectionsLayout
            // 
            this.inspectionsLayout.Control = this.inspections;
            this.inspectionsLayout.CustomizationFormText = "inspectionsLayout";
            this.inspectionsLayout.Location = new System.Drawing.Point(0, 0);
            this.inspectionsLayout.Name = "inspectionsLayout";
            this.inspectionsLayout.Size = new System.Drawing.Size(1216, 392);
            this.inspectionsLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 10, 5, 2);
            this.inspectionsLayout.Text = "inspectionsLayout";
            this.inspectionsLayout.TextSize = new System.Drawing.Size(0, 0);
            this.inspectionsLayout.TextToControlDistance = 0;
            this.inspectionsLayout.TextVisible = false;
            // 
            // MillPipeNewEditXtraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1275, 550);
            this.Controls.Add(this.generalPipeLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MillPipeNewEditXtraForm";
            this.Text = "Mill - New or Edit pipe";
            ((System.ComponentModel.ISupportInitialize)(this.weldersListGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weldingHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weldingHistoryGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe)).EndInit();
            this.pipe.ResumeLayout(false);
            this.generalParametersPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pipeGeneralParametersLayout)).EndInit();
            this.pipeGeneralParametersLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.shippedDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificateNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.destanation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.railcarNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chemicalComposition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chemicalCompositionGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coatingType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coatingDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coatingDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coatingHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coatingHistoryGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.welders.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weldingDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weldingDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diameter.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.length.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weight.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thickness.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalParametersLayoutGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chemicalCompositionLayoutGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chemicalCompositionLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.geometricParametersLayoutGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lengthLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thicknessLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diameterLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weightLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipmentParametersLayoutGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.railcarNumberLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shiptedDateLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificateLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.destinationLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coatingParametersLayoutGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coatingHistoryLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coatingDateLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coatingTypeaLyout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpatingParametersEmptySpace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addCoatingButtonLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coatingAddButtonEmptySpace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weldingParametersLayoutGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weldingHistoryLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weldingDateLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addWeldingButtonLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weldersLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weldinAddButtonEmptySpace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weldingParametersEmpty)).EndInit();
            this.heatPlateParametersPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabPagesLayout)).EndInit();
            this.tabPagesLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tensileTests)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tensileTestsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plateThickness.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.steelGrade.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plateChemicalComposition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plateChemicalCompositionGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ladelMechanicalProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ladelMechanicalPropertiesGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ladleChemicalComposition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ladleChemicalCompositionView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plateManufacturer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heatLayoutGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heatParametersLayoutGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ladelChemicalCompositionLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heatSplitter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ladelMechanicalPropertiesLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editHeatButtonEmptySpace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editHeatButtonLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plateParametersLayoutGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plateSplitter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plateManufacturerLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.steelGradeLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plateThicknessLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.steelGradeEmptySpace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plateChemicalCompositionLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tensileTestsLayout)).EndInit();
            this.inspectionPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.inspectionOperation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeSize.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalPipeLayout)).EndInit();
            this.generalPipeLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.deactivate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseOrderDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseOrderDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseOrder.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heatNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeCreationDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeCreationDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.millStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalLayoutGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeNumberLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeSizeLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heatNumberLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.creationDateLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purhaseOrderLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalPipeParametersEmpty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purhaseOrderDateLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attachmentsButtonLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deactivateLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveButtonLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButtonLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeParametersLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificateEmptySpace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.inspectionsLayoutGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspections)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionsLayout)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl pipe;
        private DevExpress.XtraTab.XtraTabPage generalParametersPage;
        private DevExpress.XtraEditors.ComboBoxEdit pipeSize;
        private DevExpress.XtraEditors.ComboBoxEdit millStatus;
        private DevExpress.XtraEditors.TextEdit pipeNumber;
        private DevExpress.XtraEditors.DateEdit pipeCreationDate;
        private DevExpress.XtraLayout.LayoutControl generalPipeLayout;
        private DevExpress.XtraEditors.ComboBoxEdit heatNumber;
        private DevExpress.XtraLayout.LayoutControlGroup generalLayoutGroup;
        private DevExpress.XtraLayout.LayoutControlItem pipeNumberLayout;
        private DevExpress.XtraLayout.LayoutControlItem pipeSizeLayout;
        private DevExpress.XtraLayout.LayoutControlItem heatNumberLayout;
        private DevExpress.XtraLayout.LayoutControlItem statusLayout;
        private DevExpress.XtraLayout.LayoutControlItem creationDateLayout;
        private DevExpress.XtraLayout.LayoutControlItem pipeLayout;
        private DevExpress.XtraLayout.LayoutControlItem pipeParametersLayout;
        private DevExpress.XtraTab.XtraTabPage heatPlateParametersPage;
        private DevExpress.XtraEditors.ComboBoxEdit purchaseOrder;
        private DevExpress.XtraLayout.LayoutControlItem purhaseOrderLayout;
        private DevExpress.XtraLayout.LayoutControl pipeGeneralParametersLayout;
        private DevExpress.XtraEditors.TextEdit length;
        private DevExpress.XtraLayout.LayoutControlGroup generalParametersLayoutGroup;
        private DevExpress.XtraLayout.LayoutControlGroup geometricParametersLayoutGroup;
        private DevExpress.XtraLayout.LayoutControlItem lengthLayout;
        private DevExpress.XtraEditors.DateEdit weldingDate;
        private DevExpress.XtraLayout.LayoutControlGroup weldingParametersLayoutGroup;
        private DevExpress.XtraLayout.LayoutControlItem weldingDateLayout;
        private DevExpress.XtraGrid.GridControl weldingHistory;
        private DevExpress.XtraGrid.Views.Grid.GridView weldingHistoryGridView;
        private DevExpress.XtraLayout.LayoutControlItem weldingHistoryLayout;
        private DevExpress.XtraEditors.TextEdit diameter;
        private DevExpress.XtraEditors.TextEdit weight;
        private DevExpress.XtraEditors.TextEdit thickness;
        private DevExpress.XtraLayout.LayoutControlItem thicknessLayout;
        private DevExpress.XtraLayout.LayoutControlItem diameterLayout;
        private DevExpress.XtraLayout.LayoutControlItem weightLayout;
        private DevExpress.XtraEditors.SimpleButton addWeldingButton;
        private DevExpress.XtraEditors.ComboBoxEdit welders;
        private DevExpress.XtraLayout.LayoutControlItem addWeldingButtonLayout;
        private DevExpress.XtraLayout.LayoutControlItem weldersLayout;
        private DevExpress.XtraGrid.GridControl coatingHistory;
        private DevExpress.XtraGrid.Views.Grid.GridView coatingHistoryGridView;
        private DevExpress.XtraLayout.LayoutControlGroup coatingParametersLayoutGroup;
        private DevExpress.XtraLayout.LayoutControlItem coatingHistoryLayout;
        private DevExpress.XtraEditors.SimpleButton attachmentsButton;
        private DevExpress.XtraEditors.SimpleButton saveButton;
        private DevExpress.XtraEditors.SimpleButton closeButton;
        private DevExpress.XtraLayout.LayoutControl tabPagesLayout;
        private DevExpress.XtraGrid.GridControl ladelMechanicalProperties;
        private DevExpress.XtraGrid.Views.Grid.GridView ladelMechanicalPropertiesGridView;
        private DevExpress.XtraGrid.GridControl ladleChemicalComposition;
        private DevExpress.XtraGrid.Views.Grid.GridView ladleChemicalCompositionView;
        private DevExpress.XtraGrid.Columns.GridColumn elementNameLadleCompositionGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn elementQuantityLadleGridColumn;
        private DevExpress.XtraLayout.LayoutControlGroup heatLayoutGroup;
        private DevExpress.XtraLayout.LayoutControlGroup heatParametersLayoutGroup;
        private DevExpress.XtraLayout.LayoutControlItem ladelChemicalCompositionLayout;
        private DevExpress.XtraLayout.LayoutControlItem ladelMechanicalPropertiesLayout;
        private DevExpress.XtraLayout.SplitterItem heatSplitter;
        private DevExpress.XtraLayout.EmptySpaceItem weldinAddButtonEmptySpace;
        private DevExpress.XtraEditors.SimpleButton addCoatingButton;
        private DevExpress.XtraEditors.ComboBoxEdit coatingType;
        private DevExpress.XtraEditors.DateEdit coatingDate;
        private DevExpress.XtraLayout.LayoutControlItem coatingDateLayout;
        private DevExpress.XtraLayout.LayoutControlItem coatingTypeaLyout;
        private DevExpress.XtraLayout.EmptySpaceItem cpatingParametersEmptySpace;
        private DevExpress.XtraLayout.LayoutControlItem addCoatingButtonLayout;
        private DevExpress.XtraLayout.EmptySpaceItem coatingAddButtonEmptySpace;
        private DevExpress.XtraLayout.EmptySpaceItem weldingParametersEmpty;
        private DevExpress.XtraEditors.CheckEdit deactivate;
        private DevExpress.XtraLayout.EmptySpaceItem generalPipeParametersEmpty;
        private DevExpress.XtraTab.XtraTabPage inspectionPage;
        private DevExpress.XtraGrid.GridControl chemicalComposition;
        private DevExpress.XtraGrid.Views.Grid.GridView chemicalCompositionGridView;
        private DevExpress.XtraLayout.LayoutControlGroup chemicalCompositionLayoutGroup;
        private DevExpress.XtraLayout.LayoutControlItem chemicalCompositionLayout;
        private DevExpress.XtraEditors.TextEdit shippedDate;
        private DevExpress.XtraEditors.TextEdit certificateNumber;
        private DevExpress.XtraEditors.TextEdit destanation;
        private DevExpress.XtraEditors.TextEdit railcarNumber;
        private DevExpress.XtraLayout.LayoutControlGroup shipmentParametersLayoutGroup;
        private DevExpress.XtraLayout.LayoutControlItem railcarNumberLayout;
        private DevExpress.XtraLayout.LayoutControlItem destinationLayout;
        private DevExpress.XtraLayout.LayoutControlItem certificateLayout;
        private DevExpress.XtraLayout.LayoutControlItem shiptedDateLayout;
        private DevExpress.XtraGrid.Columns.GridColumn pipeElementNameGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn quantityGridColumn;
        private DevExpress.XtraGrid.GridControl plateChemicalComposition;
        private DevExpress.XtraGrid.Views.Grid.GridView plateChemicalCompositionGridView;
        private DevExpress.XtraGrid.Columns.GridColumn plateElementNameGridColumn;
        private DevExpress.XtraEditors.DateEdit purchaseOrderDate;
        private DevExpress.XtraLayout.LayoutControlItem purhaseOrderDateLayout;
        private DevExpress.XtraEditors.SimpleButton editHeatButton;
        private DevExpress.XtraLayout.LayoutControlItem editHeatButtonLayout;
        private DevExpress.XtraLayout.EmptySpaceItem editHeatButtonEmptySpace;
        private DevExpress.XtraLayout.EmptySpaceItem certificateEmptySpace;
        private DevExpress.XtraLayout.LayoutControlItem plateManufacturerLayout;
        private DevExpress.XtraLayout.LayoutControlItem plateChemicalCompositionLayout;
        private DevExpress.XtraGrid.GridControl tensileTests;
        private DevExpress.XtraGrid.Views.Grid.GridView tensileTestsGridView;
        private DevExpress.XtraEditors.TextEdit plateThickness;
        private DevExpress.XtraEditors.TextEdit steelGrade;
        private DevExpress.XtraEditors.ComboBoxEdit plateManufacturer;
        private DevExpress.XtraLayout.LayoutControlGroup plateParametersLayoutGroup;
        private DevExpress.XtraLayout.SplitterItem plateSplitter;
        private DevExpress.XtraLayout.LayoutControlItem steelGradeLayout;
        private DevExpress.XtraLayout.LayoutControlItem plateThicknessLayout;
        private DevExpress.XtraLayout.EmptySpaceItem steelGradeEmptySpace;
        private DevExpress.XtraLayout.LayoutControlItem tensileTestsLayout;
        private DevExpress.XtraGrid.Columns.GridColumn plateElementQuantityGridColumn;
        private DevExpress.XtraLayout.LayoutControlItem attachmentsButtonLayout;
        private DevExpress.XtraLayout.LayoutControlItem deactivateLayout;
        private DevExpress.XtraLayout.LayoutControlItem saveButtonLayout;
        private DevExpress.XtraLayout.LayoutControlItem closeButtonLayout;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraGrid.Views.Grid.GridView weldersListGridView;
        private System.Windows.Forms.BindingSource inspectionOperation;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl inspections;
        private DevExpress.XtraGrid.Views.Grid.GridView inspectionsGridView;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn15;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn16;
        private DevExpress.XtraLayout.LayoutControlGroup inspectionsLayoutGroup;
        private DevExpress.XtraLayout.LayoutControlItem inspectionsLayout;
    }
}