namespace Booker.View
{
    partial class PlanView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlanView));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btOpen = new DevExpress.XtraBars.BarButtonItem();
            this.btSave = new DevExpress.XtraBars.BarButtonItem();
            this.btAddFilm = new DevExpress.XtraBars.BarButtonItem();
            this.datePickerPeriod = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.comboBoxCinema = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.btSaveAs = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btRefresh = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btOpen,
            this.btSave,
            this.btAddFilm,
            this.datePickerPeriod,
            this.comboBoxCinema,
            this.btSaveAs,
            this.btRefresh});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 10;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage,
            this.ribbonPage1});
            this.ribbon.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit1,
            this.repositoryItemComboBox1});
            this.ribbon.Size = new System.Drawing.Size(797, 143);
            // 
            // btOpen
            // 
            this.btOpen.Caption = "Open";
            this.btOpen.Id = 1;
            this.btOpen.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btOpen.ImageOptions.Image")));
            this.btOpen.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btOpen.ImageOptions.LargeImage")));
            this.btOpen.Name = "btOpen";
            this.btOpen.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btOpen_ItemClick);
            // 
            // btSave
            // 
            this.btSave.Caption = "Save";
            this.btSave.Enabled = false;
            this.btSave.Id = 2;
            this.btSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btSave.ImageOptions.Image")));
            this.btSave.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btSave.ImageOptions.LargeImage")));
            this.btSave.Name = "btSave";
            this.btSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btSave_ItemClick);
            // 
            // btAddFilm
            // 
            this.btAddFilm.Caption = "Add Film";
            this.btAddFilm.Id = 4;
            this.btAddFilm.Name = "btAddFilm";
            // 
            // datePickerPeriod
            // 
            this.datePickerPeriod.AutoFillWidthInMenu = DevExpress.Utils.DefaultBoolean.False;
            this.datePickerPeriod.Caption = "Period";
            this.datePickerPeriod.Edit = this.repositoryItemDateEdit1;
            this.datePickerPeriod.EditWidth = 70;
            this.datePickerPeriod.Id = 6;
            this.datePickerPeriod.Name = "datePickerPeriod";
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.DisplayFormat.FormatString = "MMMM";
            this.repositoryItemDateEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEdit1.EditFormat.FormatString = "MMMM";
            this.repositoryItemDateEdit1.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEdit1.Mask.EditMask = "MMMM";
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            // 
            // comboBoxCinema
            // 
            this.comboBoxCinema.AutoFillWidthInMenu = DevExpress.Utils.DefaultBoolean.False;
            this.comboBoxCinema.Caption = "Cinema";
            this.comboBoxCinema.Edit = this.repositoryItemComboBox1;
            this.comboBoxCinema.EditWidth = 70;
            this.comboBoxCinema.Id = 7;
            this.comboBoxCinema.Name = "comboBoxCinema";
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            // 
            // btSaveAs
            // 
            this.btSaveAs.Caption = "Save As";
            this.btSaveAs.Id = 8;
            this.btSaveAs.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btSaveAs.ImageOptions.Image")));
            this.btSaveAs.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btSaveAs.ImageOptions.LargeImage")));
            this.btSaveAs.Name = "btSaveAs";
            this.btSaveAs.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btSaveAs_ItemClick);
            // 
            // ribbonPage
            // 
            this.ribbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage.Name = "ribbonPage";
            this.ribbonPage.Text = "File";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btOpen);
            this.ribbonPageGroup1.ItemLinks.Add(this.btSave);
            this.ribbonPageGroup1.ItemLinks.Add(this.btSaveAs);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Actions";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Plan";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btAddFilm);
            this.ribbonPageGroup2.ItemLinks.Add(this.datePickerPeriod);
            this.ribbonPageGroup2.ItemLinks.Add(this.comboBoxCinema);
            this.ribbonPageGroup2.ItemsLayout = DevExpress.XtraBars.Ribbon.RibbonPageGroupItemsLayout.OneRow;
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // gridControl
            // 
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.Location = new System.Drawing.Point(0, 143);
            this.gridControl.MainView = this.gridView;
            this.gridControl.MenuManager = this.ribbon;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(797, 436);
            this.gridControl.TabIndex = 2;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            this.gridView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btRefresh);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Data";
            // 
            // btRefresh
            // 
            this.btRefresh.Caption = "Refresh Data";
            this.btRefresh.Id = 9;
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btRefresh_ItemClick);
            // 
            // PlanView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 579);
            this.Controls.Add(this.gridControl);
            this.Controls.Add(this.ribbon);
            this.Name = "PlanView";
            this.Ribbon = this.ribbon;
            this.Text = "PlanView";
            this.Load += new System.EventHandler(this.PlanView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btOpen;
        private DevExpress.XtraBars.BarButtonItem btSave;
        private DevExpress.XtraBars.BarButtonItem btAddFilm;
        private DevExpress.XtraBars.BarEditItem datePickerPeriod;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraBars.BarEditItem comboBoxCinema;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraBars.BarButtonItem btSaveAs;
        private DevExpress.XtraBars.BarButtonItem btRefresh;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
    }
}