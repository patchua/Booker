namespace Booker.View
{
    partial class MainWindowView
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
            this.ParentRibbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btFilms = new DevExpress.XtraBars.BarButtonItem();
            this.btCinemas = new DevExpress.XtraBars.BarButtonItem();
            this.btPlan = new DevExpress.XtraBars.BarButtonItem();
            this.btSchedule = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.documentManager = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            this.dockManager = new DevExpress.XtraBars.Docking.DockManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ParentRibbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager)).BeginInit();
            this.SuspendLayout();
            // 
            // ParentRibbonControl
            // 
            this.ParentRibbonControl.ExpandCollapseItem.Id = 0;
            this.ParentRibbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ParentRibbonControl.ExpandCollapseItem,
            this.btFilms,
            this.btCinemas,
            this.btPlan,
            this.btSchedule});
            this.ParentRibbonControl.Location = new System.Drawing.Point(0, 0);
            this.ParentRibbonControl.MaxItemId = 5;
            this.ParentRibbonControl.MdiMergeStyle = DevExpress.XtraBars.Ribbon.RibbonMdiMergeStyle.Always;
            this.ParentRibbonControl.Name = "ParentRibbonControl";
            this.ParentRibbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ParentRibbonControl.Size = new System.Drawing.Size(940, 143);
            // 
            // btFilms
            // 
            this.btFilms.Caption = "Films";
            this.btFilms.Id = 1;
            this.btFilms.Name = "btFilms";
            this.btFilms.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btFilms_ItemClick);
            // 
            // btCinemas
            // 
            this.btCinemas.Caption = "Cinemas";
            this.btCinemas.Id = 2;
            this.btCinemas.Name = "btCinemas";
            this.btCinemas.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btCinemas_ItemClick);
            // 
            // btPlan
            // 
            this.btPlan.Caption = "Plan";
            this.btPlan.Id = 3;
            this.btPlan.Name = "btPlan";
            this.btPlan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btPlan_ItemClick);
            // 
            // btSchedule
            // 
            this.btSchedule.Caption = "Schedule";
            this.btSchedule.Id = 4;
            this.btSchedule.Name = "btSchedule";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Home";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btFilms);
            this.ribbonPageGroup1.ItemLinks.Add(this.btCinemas);
            this.ribbonPageGroup1.ItemLinks.Add(this.btPlan);
            this.ribbonPageGroup1.ItemLinks.Add(this.btSchedule);
            this.ribbonPageGroup1.ItemsLayout = DevExpress.XtraBars.Ribbon.RibbonPageGroupItemsLayout.OneRow;
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Application";
            // 
            // documentManager
            // 
            this.documentManager.MdiParent = this;
            this.documentManager.MenuManager = this.ParentRibbonControl;
            this.documentManager.View = this.tabbedView1;
            this.documentManager.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView1});
            // 
            // tabbedView1
            // 
            this.tabbedView1.RootContainer.Element = null;
            // 
            // dockManager
            // 
            this.dockManager.Form = this;
            this.dockManager.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane",
            "DevExpress.XtraBars.TabFormControl"});
            // 
            // MainWindowView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 514);
            this.Controls.Add(this.ParentRibbonControl);
            this.IsMdiContainer = true;
            this.Name = "MainWindowView";
            this.Ribbon = this.ParentRibbonControl;
            this.Text = "Booker";
            ((System.ComponentModel.ISupportInitialize)(this.ParentRibbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ParentRibbonControl;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.BarButtonItem btFilms;
        private DevExpress.XtraBars.BarButtonItem btCinemas;
        private DevExpress.XtraBars.BarButtonItem btPlan;
        private DevExpress.XtraBars.BarButtonItem btSchedule;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView1;
        private DevExpress.XtraBars.Docking.DockManager dockManager;
    }
}

