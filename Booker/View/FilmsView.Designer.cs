namespace Booker.View
{
    partial class FilmsView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilmsView));
            this.FilmsRibbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btSave = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup_Actions = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.filmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.FilmsRibbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // FilmsRibbonControl
            // 
            this.FilmsRibbonControl.ExpandCollapseItem.Id = 0;
            this.FilmsRibbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.FilmsRibbonControl.ExpandCollapseItem,
            this.btSave});
            this.FilmsRibbonControl.Location = new System.Drawing.Point(0, 0);
            this.FilmsRibbonControl.MaxItemId = 3;
            this.FilmsRibbonControl.MdiMergeStyle = DevExpress.XtraBars.Ribbon.RibbonMdiMergeStyle.Always;
            this.FilmsRibbonControl.Name = "FilmsRibbonControl";
            this.FilmsRibbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.FilmsRibbonControl.Size = new System.Drawing.Size(876, 143);
            // 
            // btSave
            // 
            this.btSave.Caption = "Save";
            this.btSave.Id = 2;
            this.btSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btSave.ImageOptions.Image")));
            this.btSave.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btSave.ImageOptions.LargeImage")));
            this.btSave.Name = "btSave";
            this.btSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btSave_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup_Actions});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "File";
            // 
            // ribbonPageGroup_Actions
            // 
            this.ribbonPageGroup_Actions.ItemLinks.Add(this.btSave);
            this.ribbonPageGroup_Actions.ItemsLayout = DevExpress.XtraBars.Ribbon.RibbonPageGroupItemsLayout.OneRow;
            this.ribbonPageGroup_Actions.Name = "ribbonPageGroup_Actions";
            this.ribbonPageGroup_Actions.Text = "Actions";
            // 
            // gridControl
            // 
            this.gridControl.DataSource = this.filmBindingSource;
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.Location = new System.Drawing.Point(0, 143);
            this.gridControl.MainView = this.gridView;
            this.gridControl.MenuManager = this.FilmsRibbonControl;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(876, 377);
            this.gridControl.TabIndex = 1;
            this.gridControl.UseEmbeddedNavigator = true;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // filmBindingSource
            // 
            this.filmBindingSource.DataSource = typeof(Booker.Model.Film);
            // 
            // gridView
            // 
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            this.gridView.OptionsView.ShowFooter = true;
            // 
            // FilmsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 520);
            this.Controls.Add(this.gridControl);
            this.Controls.Add(this.FilmsRibbonControl);
            this.Name = "FilmsView";
            this.Ribbon = this.FilmsRibbonControl;
            this.Text = "Films";
            ((System.ComponentModel.ISupportInitialize)(this.FilmsRibbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl FilmsRibbonControl;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup_Actions;
        private DevExpress.XtraBars.BarButtonItem btSave;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private System.Windows.Forms.BindingSource filmBindingSource;
    }
}