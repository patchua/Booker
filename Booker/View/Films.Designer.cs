namespace Booker.View
{
    partial class Films
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
            this.FilmsRibbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup_Actions = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btOpen = new DevExpress.XtraBars.BarButtonItem();
            this.btSave = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.FilmsRibbonControl)).BeginInit();
            this.SuspendLayout();
            // 
            // FilmsRibbonControl
            // 
            this.FilmsRibbonControl.ExpandCollapseItem.Id = 0;
            this.FilmsRibbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.FilmsRibbonControl.ExpandCollapseItem,
            this.btOpen,
            this.btSave});
            this.FilmsRibbonControl.Location = new System.Drawing.Point(0, 0);
            this.FilmsRibbonControl.MaxItemId = 3;
            this.FilmsRibbonControl.MdiMergeStyle = DevExpress.XtraBars.Ribbon.RibbonMdiMergeStyle.Always;
            this.FilmsRibbonControl.Name = "FilmsRibbonControl";
            this.FilmsRibbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.FilmsRibbonControl.Size = new System.Drawing.Size(726, 143);
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
            this.ribbonPageGroup_Actions.ItemLinks.Add(this.btOpen);
            this.ribbonPageGroup_Actions.ItemLinks.Add(this.btSave);
            this.ribbonPageGroup_Actions.ItemsLayout = DevExpress.XtraBars.Ribbon.RibbonPageGroupItemsLayout.OneRow;
            this.ribbonPageGroup_Actions.Name = "ribbonPageGroup_Actions";
            this.ribbonPageGroup_Actions.Text = "Actions";
            // 
            // btOpen
            // 
            this.btOpen.Caption = "Open";
            this.btOpen.Id = 1;
            this.btOpen.Name = "btOpen";
            // 
            // btSave
            // 
            this.btSave.Caption = "Save";
            this.btSave.Id = 2;
            this.btSave.Name = "btSave";
            // 
            // Films
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 449);
            this.Controls.Add(this.FilmsRibbonControl);
            this.Name = "Films";
            this.Ribbon = this.FilmsRibbonControl;
            this.Text = "Films";
            ((System.ComponentModel.ISupportInitialize)(this.FilmsRibbonControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl FilmsRibbonControl;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup_Actions;
        private DevExpress.XtraBars.BarButtonItem btOpen;
        private DevExpress.XtraBars.BarButtonItem btSave;
    }
}