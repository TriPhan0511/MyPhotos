﻿
namespace MyPhotos
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pbxPhoto = new System.Windows.Forms.PictureBox();
            this.ctxMenuPhoto = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuImage = new System.Windows.Forms.ToolStripMenuItem();
            this.menuImageScale = new System.Windows.Forms.ToolStripMenuItem();
            this.menuImageStretch = new System.Windows.Forms.ToolStripMenuItem();
            this.menuImageActual = new System.Windows.Forms.ToolStripMenuItem();
            this.menuImageCenter = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuView = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusImageSize = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusAlbumPos = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.menuFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuFilePrint = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFilePrintPreview = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.menuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.menuEditCut = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.menuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuEditAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.menuNext = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrevious = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPhoto)).BeginInit();
            this.ctxMenuPhoto.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbxPhoto
            // 
            this.pbxPhoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxPhoto.ContextMenuStrip = this.ctxMenuPhoto;
            this.pbxPhoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbxPhoto.Location = new System.Drawing.Point(0, 24);
            this.pbxPhoto.Name = "pbxPhoto";
            this.pbxPhoto.Size = new System.Drawing.Size(292, 242);
            this.pbxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxPhoto.TabIndex = 1;
            this.pbxPhoto.TabStop = false;
            // 
            // ctxMenuPhoto
            // 
            this.ctxMenuPhoto.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuImage,
            this.toolStripSeparator7,
            this.menuNext,
            this.menuPrevious});
            this.ctxMenuPhoto.Name = "ctxMenuPhoto";
            this.ctxMenuPhoto.Size = new System.Drawing.Size(193, 98);
            // 
            // menuImage
            // 
            this.menuImage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuImageScale,
            this.menuImageStretch,
            this.menuImageActual,
            this.menuImageCenter});
            this.menuImage.Name = "menuImage";
            this.menuImage.Size = new System.Drawing.Size(192, 22);
            this.menuImage.Text = "Image";
            this.menuImage.DropDownOpening += new System.EventHandler(this.menuImage_DropDownOpening);
            this.menuImage.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuImage_DropDownItemClicked);
            // 
            // menuImageScale
            // 
            this.menuImageScale.Checked = true;
            this.menuImageScale.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menuImageScale.Name = "menuImageScale";
            this.menuImageScale.Size = new System.Drawing.Size(180, 22);
            this.menuImageScale.Tag = "Zoom";
            this.menuImageScale.Text = "&Scale to Fit";
            // 
            // menuImageStretch
            // 
            this.menuImageStretch.Name = "menuImageStretch";
            this.menuImageStretch.Size = new System.Drawing.Size(180, 22);
            this.menuImageStretch.Tag = "StretchImage";
            this.menuImageStretch.Text = "S&tretch to Fit";
            // 
            // menuImageActual
            // 
            this.menuImageActual.Name = "menuImageActual";
            this.menuImageActual.Size = new System.Drawing.Size(180, 22);
            this.menuImageActual.Tag = "Normal";
            this.menuImageActual.Text = "&Actual Size";
            // 
            // menuImageCenter
            // 
            this.menuImageCenter.Name = "menuImageCenter";
            this.menuImageCenter.Size = new System.Drawing.Size(180, 22);
            this.menuImageCenter.Tag = "CenterImage";
            this.menuImageCenter.Text = "&Center Image";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuEdit,
            this.menuView,
            this.menuHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(292, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuView
            // 
            this.menuView.Name = "menuView";
            this.menuView.Size = new System.Drawing.Size(44, 20);
            this.menuView.Text = "&View";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusInfo,
            this.statusImageSize,
            this.statusAlbumPos});
            this.statusStrip1.Location = new System.Drawing.Point(0, 242);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.ShowItemToolTips = true;
            this.statusStrip1.Size = new System.Drawing.Size(292, 24);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusInfo
            // 
            this.statusInfo.AutoSize = false;
            this.statusInfo.Name = "statusInfo";
            this.statusInfo.Size = new System.Drawing.Size(206, 19);
            this.statusInfo.Spring = true;
            this.statusInfo.Text = "Desc";
            this.statusInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statusImageSize
            // 
            this.statusImageSize.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.statusImageSize.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.statusImageSize.Name = "statusImageSize";
            this.statusImageSize.Size = new System.Drawing.Size(43, 19);
            this.statusImageSize.Text = "W x H";
            // 
            // statusAlbumPos
            // 
            this.statusAlbumPos.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.statusAlbumPos.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.statusAlbumPos.Name = "statusAlbumPos";
            this.statusAlbumPos.Size = new System.Drawing.Size(28, 19);
            this.statusAlbumPos.Text = "1/1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFileNew,
            this.menuFileOpen,
            this.toolStripSeparator,
            this.menuFileSave,
            this.menuFileSaveAs,
            this.toolStripSeparator2,
            this.menuFilePrint,
            this.menuFilePrintPreview,
            this.toolStripSeparator3,
            this.menuFileExit});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(37, 20);
            this.menuFile.Text = "&File";
            // 
            // menuFileNew
            // 
            this.menuFileNew.Image = ((System.Drawing.Image)(resources.GetObject("menuFileNew.Image")));
            this.menuFileNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuFileNew.Name = "menuFileNew";
            this.menuFileNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.menuFileNew.Size = new System.Drawing.Size(180, 22);
            this.menuFileNew.Text = "&New";
            // 
            // menuFileOpen
            // 
            this.menuFileOpen.Image = ((System.Drawing.Image)(resources.GetObject("menuFileOpen.Image")));
            this.menuFileOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuFileOpen.Name = "menuFileOpen";
            this.menuFileOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.menuFileOpen.Size = new System.Drawing.Size(180, 22);
            this.menuFileOpen.Text = "&Open";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(177, 6);
            // 
            // menuFileSave
            // 
            this.menuFileSave.Image = ((System.Drawing.Image)(resources.GetObject("menuFileSave.Image")));
            this.menuFileSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuFileSave.Name = "menuFileSave";
            this.menuFileSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.menuFileSave.Size = new System.Drawing.Size(180, 22);
            this.menuFileSave.Text = "&Save";
            // 
            // menuFileSaveAs
            // 
            this.menuFileSaveAs.Name = "menuFileSaveAs";
            this.menuFileSaveAs.Size = new System.Drawing.Size(180, 22);
            this.menuFileSaveAs.Text = "Save &As";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // menuFilePrint
            // 
            this.menuFilePrint.Image = ((System.Drawing.Image)(resources.GetObject("menuFilePrint.Image")));
            this.menuFilePrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuFilePrint.Name = "menuFilePrint";
            this.menuFilePrint.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.menuFilePrint.Size = new System.Drawing.Size(180, 22);
            this.menuFilePrint.Text = "&Print";
            // 
            // menuFilePrintPreview
            // 
            this.menuFilePrintPreview.Image = ((System.Drawing.Image)(resources.GetObject("menuFilePrintPreview.Image")));
            this.menuFilePrintPreview.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuFilePrintPreview.Name = "menuFilePrintPreview";
            this.menuFilePrintPreview.Size = new System.Drawing.Size(180, 22);
            this.menuFilePrintPreview.Text = "Print Pre&view";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
            // 
            // menuFileExit
            // 
            this.menuFileExit.Name = "menuFileExit";
            this.menuFileExit.Size = new System.Drawing.Size(180, 22);
            this.menuFileExit.Text = "E&xit";
            // 
            // menuEdit
            // 
            this.menuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator4,
            this.menuEditCut,
            this.menuEditCopy,
            this.menuEditPaste,
            this.toolStripSeparator5,
            this.toolStripSeparator1,
            this.menuEditAdd,
            this.menuEditRemove});
            this.menuEdit.Name = "menuEdit";
            this.menuEdit.Size = new System.Drawing.Size(39, 20);
            this.menuEdit.Text = "&Edit";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(187, 6);
            // 
            // menuEditCut
            // 
            this.menuEditCut.Image = ((System.Drawing.Image)(resources.GetObject("menuEditCut.Image")));
            this.menuEditCut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuEditCut.Name = "menuEditCut";
            this.menuEditCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.menuEditCut.Size = new System.Drawing.Size(190, 22);
            this.menuEditCut.Text = "Cu&t";
            // 
            // menuEditCopy
            // 
            this.menuEditCopy.Image = ((System.Drawing.Image)(resources.GetObject("menuEditCopy.Image")));
            this.menuEditCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuEditCopy.Name = "menuEditCopy";
            this.menuEditCopy.Size = new System.Drawing.Size(190, 22);
            this.menuEditCopy.Text = "&Copy";
            // 
            // menuEditPaste
            // 
            this.menuEditPaste.Image = ((System.Drawing.Image)(resources.GetObject("menuEditPaste.Image")));
            this.menuEditPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuEditPaste.Name = "menuEditPaste";
            this.menuEditPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.menuEditPaste.Size = new System.Drawing.Size(190, 22);
            this.menuEditPaste.Text = "&Paste";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(187, 6);
            // 
            // menuHelp
            // 
            this.menuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator6,
            this.menuHelpAbout});
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Size = new System.Drawing.Size(44, 20);
            this.menuHelp.Text = "&Help";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(177, 6);
            // 
            // menuHelpAbout
            // 
            this.menuHelpAbout.Name = "menuHelpAbout";
            this.menuHelpAbout.Size = new System.Drawing.Size(180, 22);
            this.menuHelpAbout.Text = "&About...";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(187, 6);
            // 
            // menuEditAdd
            // 
            this.menuEditAdd.Name = "menuEditAdd";
            this.menuEditAdd.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.A)));
            this.menuEditAdd.Size = new System.Drawing.Size(190, 22);
            this.menuEditAdd.Text = "Ad&d";
            // 
            // menuEditRemove
            // 
            this.menuEditRemove.Name = "menuEditRemove";
            this.menuEditRemove.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.R)));
            this.menuEditRemove.Size = new System.Drawing.Size(190, 22);
            this.menuEditRemove.Text = "Remo&ve";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(189, 6);
            // 
            // menuNext
            // 
            this.menuNext.Name = "menuNext";
            this.menuNext.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.menuNext.Size = new System.Drawing.Size(192, 22);
            this.menuNext.Text = "&Next";
            // 
            // menuPrevious
            // 
            this.menuPrevious.Name = "menuPrevious";
            this.menuPrevious.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.P)));
            this.menuPrevious.Size = new System.Drawing.Size(192, 22);
            this.menuPrevious.Text = "&Previous";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pbxPhoto);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MyPhotos";
            ((System.ComponentModel.ISupportInitialize)(this.pbxPhoto)).EndInit();
            this.ctxMenuPhoto.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbxPhoto;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ContextMenuStrip ctxMenuPhoto;
        private System.Windows.Forms.ToolStripMenuItem menuImage;
        private System.Windows.Forms.ToolStripMenuItem menuImageScale;
        private System.Windows.Forms.ToolStripMenuItem menuImageStretch;
        private System.Windows.Forms.ToolStripMenuItem menuImageActual;
        private System.Windows.Forms.ToolStripMenuItem menuView;
        private System.Windows.Forms.ToolStripMenuItem menuImageCenter;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusInfo;
        private System.Windows.Forms.ToolStripStatusLabel statusImageSize;
        private System.Windows.Forms.ToolStripStatusLabel statusAlbumPos;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuFileNew;
        private System.Windows.Forms.ToolStripMenuItem menuFileOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem menuFileSave;
        private System.Windows.Forms.ToolStripMenuItem menuFileSaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem menuFilePrint;
        private System.Windows.Forms.ToolStripMenuItem menuFilePrintPreview;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem menuFileExit;
        private System.Windows.Forms.ToolStripMenuItem menuEdit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem menuEditCut;
        private System.Windows.Forms.ToolStripMenuItem menuEditCopy;
        private System.Windows.Forms.ToolStripMenuItem menuEditPaste;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem menuHelp;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem menuHelpAbout;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuEditAdd;
        private System.Windows.Forms.ToolStripMenuItem menuEditRemove;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem menuNext;
        private System.Windows.Forms.ToolStripMenuItem menuPrevious;
    }
}

