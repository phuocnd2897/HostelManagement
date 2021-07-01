
namespace HostelManagement.US
{
    partial class RoomControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomControl));
            this.pbAvatar = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.lbNumberOfCustomer = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel5 = new Bunifu.UI.WinForms.BunifuLabel();
            this.lbCapacity = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.lbPrice = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.lbName = new Bunifu.UI.WinForms.BunifuLabel();
            this.lbDescription = new Bunifu.UI.WinForms.BunifuLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuSeparator1 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.btnDelete = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnUpdate = new Bunifu.UI.WinForms.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbAvatar
            // 
            this.pbAvatar.AllowFocused = false;
            this.pbAvatar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbAvatar.AutoSizeHeight = true;
            this.pbAvatar.BorderRadius = 0;
            this.pbAvatar.Image = ((System.Drawing.Image)(resources.GetObject("pbAvatar.Image")));
            this.pbAvatar.IsCircle = true;
            this.pbAvatar.Location = new System.Drawing.Point(0, 0);
            this.pbAvatar.Name = "pbAvatar";
            this.pbAvatar.Size = new System.Drawing.Size(100, 100);
            this.pbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAvatar.TabIndex = 18;
            this.pbAvatar.TabStop = false;
            this.pbAvatar.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            // 
            // lbNumberOfCustomer
            // 
            this.lbNumberOfCustomer.AllowParentOverrides = false;
            this.lbNumberOfCustomer.AutoEllipsis = false;
            this.lbNumberOfCustomer.CursorType = null;
            this.lbNumberOfCustomer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbNumberOfCustomer.Location = new System.Drawing.Point(461, 75);
            this.lbNumberOfCustomer.Name = "lbNumberOfCustomer";
            this.lbNumberOfCustomer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbNumberOfCustomer.Size = new System.Drawing.Size(12, 15);
            this.lbNumberOfCustomer.TabIndex = 17;
            this.lbNumberOfCustomer.Text = "14";
            this.lbNumberOfCustomer.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lbNumberOfCustomer.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel5
            // 
            this.bunifuLabel5.AllowParentOverrides = false;
            this.bunifuLabel5.AutoEllipsis = false;
            this.bunifuLabel5.CursorType = null;
            this.bunifuLabel5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuLabel5.Location = new System.Drawing.Point(364, 75);
            this.bunifuLabel5.Name = "bunifuLabel5";
            this.bunifuLabel5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel5.Size = new System.Drawing.Size(91, 15);
            this.bunifuLabel5.TabIndex = 16;
            this.bunifuLabel5.Text = "Số khách đang ở:";
            this.bunifuLabel5.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel5.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lbCapacity
            // 
            this.lbCapacity.AllowParentOverrides = false;
            this.lbCapacity.AutoEllipsis = false;
            this.lbCapacity.CursorType = null;
            this.lbCapacity.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbCapacity.Location = new System.Drawing.Point(329, 75);
            this.lbCapacity.Name = "lbCapacity";
            this.lbCapacity.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbCapacity.Size = new System.Drawing.Size(12, 15);
            this.lbCapacity.TabIndex = 15;
            this.lbCapacity.Text = "14";
            this.lbCapacity.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lbCapacity.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AllowParentOverrides = false;
            this.bunifuLabel3.AutoEllipsis = false;
            this.bunifuLabel3.CursorType = null;
            this.bunifuLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuLabel3.Location = new System.Drawing.Point(233, 75);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(94, 15);
            this.bunifuLabel3.TabIndex = 14;
            this.bunifuLabel3.Text = "Số khách ở tối đa:";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lbPrice
            // 
            this.lbPrice.AllowParentOverrides = false;
            this.lbPrice.AutoEllipsis = false;
            this.lbPrice.CursorType = null;
            this.lbPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbPrice.Location = new System.Drawing.Point(170, 75);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbPrice.Size = new System.Drawing.Size(48, 15);
            this.lbPrice.TabIndex = 13;
            this.lbPrice.Text = "3,500,000";
            this.lbPrice.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lbPrice.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.CursorType = null;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuLabel1.Location = new System.Drawing.Point(106, 75);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(58, 15);
            this.bunifuLabel1.TabIndex = 12;
            this.bunifuLabel1.Text = "Giá phòng:";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lbName
            // 
            this.lbName.AllowParentOverrides = false;
            this.lbName.AutoEllipsis = false;
            this.lbName.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbName.CursorType = System.Windows.Forms.Cursors.Default;
            this.lbName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbName.Location = new System.Drawing.Point(106, 12);
            this.lbName.Name = "lbName";
            this.lbName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbName.Size = new System.Drawing.Size(56, 15);
            this.lbName.TabIndex = 10;
            this.lbName.Text = "Phòng 401";
            this.lbName.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lbName.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lbDescription
            // 
            this.lbDescription.AllowParentOverrides = false;
            this.lbDescription.AutoEllipsis = false;
            this.lbDescription.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbDescription.CursorType = System.Windows.Forms.Cursors.Default;
            this.lbDescription.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbDescription.Location = new System.Drawing.Point(106, 45);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbDescription.Size = new System.Drawing.Size(156, 15);
            this.lbDescription.TabIndex = 19;
            this.lbDescription.Text = "Phòng có cửa sổ và ban công";
            this.lbDescription.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lbDescription.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bunifuSeparator1);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(678, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(38, 105);
            this.panel1.TabIndex = 20;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator1.BackgroundImage")));
            this.bunifuSeparator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator1.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.Black;
            this.bunifuSeparator1.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(3, 45);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator1.Size = new System.Drawing.Size(30, 15);
            this.bunifuSeparator1.TabIndex = 25;
            // 
            // btnDelete
            // 
            this.btnDelete.ActiveImage = null;
            this.btnDelete.AllowAnimations = true;
            this.btnDelete.AllowBuffering = false;
            this.btnDelete.AllowToggling = false;
            this.btnDelete.AllowZooming = true;
            this.btnDelete.AllowZoomingOnFocus = false;
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDelete.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.ErrorImage")));
            this.btnDelete.FadeWhenInactive = false;
            this.btnDelete.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageActive = null;
            this.btnDelete.ImageLocation = null;
            this.btnDelete.ImageMargin = 5;
            this.btnDelete.ImageSize = new System.Drawing.Size(26, 29);
            this.btnDelete.ImageZoomSize = new System.Drawing.Size(31, 34);
            this.btnDelete.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.InitialImage")));
            this.btnDelete.Location = new System.Drawing.Point(3, 64);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Rotation = 0;
            this.btnDelete.ShowActiveImage = true;
            this.btnDelete.ShowCursorChanges = true;
            this.btnDelete.ShowImageBorders = true;
            this.btnDelete.ShowSizeMarkers = false;
            this.btnDelete.Size = new System.Drawing.Size(31, 34);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.ToolTipText = "";
            this.btnDelete.WaitOnLoad = false;
            this.btnDelete.Zoom = 5;
            this.btnDelete.ZoomSpeed = 10;
            // 
            // btnUpdate
            // 
            this.btnUpdate.ActiveImage = null;
            this.btnUpdate.AllowAnimations = true;
            this.btnUpdate.AllowBuffering = false;
            this.btnUpdate.AllowToggling = false;
            this.btnUpdate.AllowZooming = true;
            this.btnUpdate.AllowZoomingOnFocus = false;
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnUpdate.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.ErrorImage")));
            this.btnUpdate.FadeWhenInactive = false;
            this.btnUpdate.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageActive = null;
            this.btnUpdate.ImageLocation = null;
            this.btnUpdate.ImageMargin = 5;
            this.btnUpdate.ImageSize = new System.Drawing.Size(26, 29);
            this.btnUpdate.ImageZoomSize = new System.Drawing.Size(31, 34);
            this.btnUpdate.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.InitialImage")));
            this.btnUpdate.Location = new System.Drawing.Point(3, 12);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Rotation = 0;
            this.btnUpdate.ShowActiveImage = true;
            this.btnUpdate.ShowCursorChanges = true;
            this.btnUpdate.ShowImageBorders = true;
            this.btnUpdate.ShowSizeMarkers = false;
            this.btnUpdate.Size = new System.Drawing.Size(31, 34);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.ToolTipText = "";
            this.btnUpdate.WaitOnLoad = false;
            this.btnUpdate.Zoom = 5;
            this.btnUpdate.ZoomSpeed = 10;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // RoomControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbDescription);
            this.Controls.Add(this.pbAvatar);
            this.Controls.Add(this.lbNumberOfCustomer);
            this.Controls.Add(this.bunifuLabel5);
            this.Controls.Add(this.lbCapacity);
            this.Controls.Add(this.bunifuLabel3);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.bunifuLabel1);
            this.Controls.Add(this.lbName);
            this.Name = "RoomControl";
            this.Size = new System.Drawing.Size(716, 105);
            this.Load += new System.EventHandler(this.RoomControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPictureBox pbAvatar;
        private Bunifu.UI.WinForms.BunifuLabel lbNumberOfCustomer;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel5;
        private Bunifu.UI.WinForms.BunifuLabel lbCapacity;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
        private Bunifu.UI.WinForms.BunifuLabel lbPrice;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuLabel lbName;
        private Bunifu.UI.WinForms.BunifuLabel lbDescription;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator1;
        private Bunifu.UI.WinForms.BunifuImageButton btnDelete;
        private Bunifu.UI.WinForms.BunifuImageButton btnUpdate;
    }
}
