
namespace HostelManagement
{
    partial class frmMain
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
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Utilities.BunifuPages.BunifuAnimatorNS.Animation animation1 = new Utilities.BunifuPages.BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDashboard = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnHostel = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.header = new System.Windows.Forms.Panel();
            this.bunifuImageButton2 = new Bunifu.UI.WinForms.BunifuImageButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pages = new Bunifu.UI.WinForms.BunifuPages();
            this.tbHostel = new System.Windows.Forms.TabPage();
            this.tbInfo = new System.Windows.Forms.TabPage();
            this.tbRoom = new System.Windows.Forms.TabPage();
            this.tbCustomer = new System.Windows.Forms.TabPage();
            this.tbDashboard = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.bunifuButton1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuDatavizBasic1 = new Bunifu.Dataviz.WinForms.BunifuDatavizBasic();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pages.SuspendLayout();
            this.tbDashboard.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.btnHostel);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 505);
            this.panel1.TabIndex = 0;
            // 
            // btnDashboard
            // 
            this.btnDashboard.AllowAnimations = true;
            this.btnDashboard.AllowMouseEffects = true;
            this.btnDashboard.AllowToggling = false;
            this.btnDashboard.AnimationSpeed = 200;
            this.btnDashboard.AutoGenerateColors = false;
            this.btnDashboard.AutoRoundBorders = false;
            this.btnDashboard.AutoSizeLeftIcon = true;
            this.btnDashboard.AutoSizeRightIcon = true;
            this.btnDashboard.BackColor = System.Drawing.Color.Transparent;
            this.btnDashboard.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnDashboard.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDashboard.BackgroundImage")));
            this.btnDashboard.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDashboard.ButtonText = "Báo cáo";
            this.btnDashboard.ButtonTextMarginLeft = 0;
            this.btnDashboard.ColorContrastOnClick = 45;
            this.btnDashboard.ColorContrastOnHover = 45;
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnDashboard.CustomizableEdges = borderEdges2;
            this.btnDashboard.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDashboard.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnDashboard.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnDashboard.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnDashboard.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnDashboard.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnDashboard.IconMarginLeft = 11;
            this.btnDashboard.IconPadding = 10;
            this.btnDashboard.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDashboard.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnDashboard.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnDashboard.IconSize = 25;
            this.btnDashboard.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnDashboard.IdleBorderRadius = 1;
            this.btnDashboard.IdleBorderThickness = 1;
            this.btnDashboard.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnDashboard.IdleIconLeftImage = null;
            this.btnDashboard.IdleIconRightImage = null;
            this.btnDashboard.IndicateFocus = false;
            this.btnDashboard.Location = new System.Drawing.Point(3, 195);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnDashboard.OnDisabledState.BorderRadius = 1;
            this.btnDashboard.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDashboard.OnDisabledState.BorderThickness = 1;
            this.btnDashboard.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnDashboard.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnDashboard.OnDisabledState.IconLeftImage = null;
            this.btnDashboard.OnDisabledState.IconRightImage = null;
            this.btnDashboard.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnDashboard.onHoverState.BorderRadius = 1;
            this.btnDashboard.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDashboard.onHoverState.BorderThickness = 1;
            this.btnDashboard.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnDashboard.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.onHoverState.IconLeftImage = null;
            this.btnDashboard.onHoverState.IconRightImage = null;
            this.btnDashboard.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnDashboard.OnIdleState.BorderRadius = 1;
            this.btnDashboard.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDashboard.OnIdleState.BorderThickness = 1;
            this.btnDashboard.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnDashboard.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.OnIdleState.IconLeftImage = null;
            this.btnDashboard.OnIdleState.IconRightImage = null;
            this.btnDashboard.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnDashboard.OnPressedState.BorderRadius = 1;
            this.btnDashboard.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDashboard.OnPressedState.BorderThickness = 1;
            this.btnDashboard.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnDashboard.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.OnPressedState.IconLeftImage = null;
            this.btnDashboard.OnPressedState.IconRightImage = null;
            this.btnDashboard.Size = new System.Drawing.Size(227, 39);
            this.btnDashboard.TabIndex = 3;
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDashboard.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDashboard.TextMarginLeft = 0;
            this.btnDashboard.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnDashboard.UseDefaultRadiusAndThickness = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnHostel
            // 
            this.btnHostel.AllowAnimations = true;
            this.btnHostel.AllowMouseEffects = true;
            this.btnHostel.AllowToggling = false;
            this.btnHostel.AnimationSpeed = 200;
            this.btnHostel.AutoGenerateColors = false;
            this.btnHostel.AutoRoundBorders = false;
            this.btnHostel.AutoSizeLeftIcon = true;
            this.btnHostel.AutoSizeRightIcon = true;
            this.btnHostel.BackColor = System.Drawing.Color.Transparent;
            this.btnHostel.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnHostel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHostel.BackgroundImage")));
            this.btnHostel.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnHostel.ButtonText = "Quản lý nhà trọ";
            this.btnHostel.ButtonTextMarginLeft = 0;
            this.btnHostel.ColorContrastOnClick = 45;
            this.btnHostel.ColorContrastOnHover = 45;
            this.btnHostel.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btnHostel.CustomizableEdges = borderEdges3;
            this.btnHostel.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnHostel.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnHostel.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnHostel.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnHostel.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnHostel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHostel.ForeColor = System.Drawing.Color.White;
            this.btnHostel.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHostel.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnHostel.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnHostel.IconMarginLeft = 11;
            this.btnHostel.IconPadding = 10;
            this.btnHostel.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHostel.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnHostel.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnHostel.IconSize = 25;
            this.btnHostel.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnHostel.IdleBorderRadius = 1;
            this.btnHostel.IdleBorderThickness = 1;
            this.btnHostel.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnHostel.IdleIconLeftImage = null;
            this.btnHostel.IdleIconRightImage = null;
            this.btnHostel.IndicateFocus = false;
            this.btnHostel.Location = new System.Drawing.Point(3, 150);
            this.btnHostel.Name = "btnHostel";
            this.btnHostel.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnHostel.OnDisabledState.BorderRadius = 1;
            this.btnHostel.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnHostel.OnDisabledState.BorderThickness = 1;
            this.btnHostel.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnHostel.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnHostel.OnDisabledState.IconLeftImage = null;
            this.btnHostel.OnDisabledState.IconRightImage = null;
            this.btnHostel.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnHostel.onHoverState.BorderRadius = 1;
            this.btnHostel.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnHostel.onHoverState.BorderThickness = 1;
            this.btnHostel.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnHostel.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnHostel.onHoverState.IconLeftImage = null;
            this.btnHostel.onHoverState.IconRightImage = null;
            this.btnHostel.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnHostel.OnIdleState.BorderRadius = 1;
            this.btnHostel.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnHostel.OnIdleState.BorderThickness = 1;
            this.btnHostel.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnHostel.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnHostel.OnIdleState.IconLeftImage = null;
            this.btnHostel.OnIdleState.IconRightImage = null;
            this.btnHostel.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnHostel.OnPressedState.BorderRadius = 1;
            this.btnHostel.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnHostel.OnPressedState.BorderThickness = 1;
            this.btnHostel.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnHostel.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnHostel.OnPressedState.IconLeftImage = null;
            this.btnHostel.OnPressedState.IconRightImage = null;
            this.btnHostel.Size = new System.Drawing.Size(227, 39);
            this.btnHostel.TabIndex = 2;
            this.btnHostel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnHostel.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnHostel.TextMarginLeft = 0;
            this.btnHostel.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnHostel.UseDefaultRadiusAndThickness = true;
            this.btnHostel.Click += new System.EventHandler(this.btnHostel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(41, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(187)))), ((int)(((byte)(146)))));
            this.header.Controls.Add(this.bunifuImageButton2);
            this.header.Controls.Add(this.pictureBox2);
            this.header.Controls.Add(this.bunifuLabel1);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1070, 41);
            this.header.TabIndex = 1;
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.ActiveImage = null;
            this.bunifuImageButton2.AllowAnimations = true;
            this.bunifuImageButton2.AllowBuffering = false;
            this.bunifuImageButton2.AllowToggling = false;
            this.bunifuImageButton2.AllowZooming = true;
            this.bunifuImageButton2.AllowZoomingOnFocus = false;
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuImageButton2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.ErrorImage")));
            this.bunifuImageButton2.FadeWhenInactive = false;
            this.bunifuImageButton2.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.ImageLocation = null;
            this.bunifuImageButton2.ImageMargin = 40;
            this.bunifuImageButton2.ImageSize = new System.Drawing.Size(-20, -20);
            this.bunifuImageButton2.ImageZoomSize = new System.Drawing.Size(20, 20);
            this.bunifuImageButton2.InitialImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.InitialImage")));
            this.bunifuImageButton2.Location = new System.Drawing.Point(1038, 10);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Rotation = 0;
            this.bunifuImageButton2.ShowActiveImage = true;
            this.bunifuImageButton2.ShowCursorChanges = true;
            this.bunifuImageButton2.ShowImageBorders = true;
            this.bunifuImageButton2.ShowSizeMarkers = false;
            this.bunifuImageButton2.Size = new System.Drawing.Size(20, 20);
            this.bunifuImageButton2.TabIndex = 3;
            this.bunifuImageButton2.ToolTipText = "";
            this.bunifuImageButton2.WaitOnLoad = false;
            this.bunifuImageButton2.Zoom = 40;
            this.bunifuImageButton2.ZoomSpeed = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(13, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(22, 23);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bunifuLabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bunifuLabel1.Location = new System.Drawing.Point(49, 10);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(139, 21);
            this.bunifuLabel1.TabIndex = 2;
            this.bunifuLabel1.Text = "Quản lý phòng trọ";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.header;
            this.bunifuDragControl1.Vertical = true;
            // 
            // pages
            // 
            this.pages.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.pages.AllowTransitions = true;
            this.pages.Controls.Add(this.tbHostel);
            this.pages.Controls.Add(this.tbInfo);
            this.pages.Controls.Add(this.tbRoom);
            this.pages.Controls.Add(this.tbCustomer);
            this.pages.Controls.Add(this.tbDashboard);
            this.pages.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pages.Location = new System.Drawing.Point(233, 90);
            this.pages.Multiline = true;
            this.pages.Name = "pages";
            this.pages.Page = this.tbDashboard;
            this.pages.PageIndex = 4;
            this.pages.PageName = "tbDashboard";
            this.pages.PageTitle = "dashboard";
            this.pages.SelectedIndex = 0;
            this.pages.Size = new System.Drawing.Size(837, 456);
            this.pages.TabIndex = 2;
            animation1.AnimateOnlyDifferences = false;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.pages.Transition = animation1;
            this.pages.TransitionType = Utilities.BunifuPages.BunifuAnimatorNS.AnimationType.Custom;
            // 
            // tbHostel
            // 
            this.tbHostel.AllowDrop = true;
            this.tbHostel.AutoScroll = true;
            this.tbHostel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.tbHostel.Location = new System.Drawing.Point(4, 4);
            this.tbHostel.Name = "tbHostel";
            this.tbHostel.Padding = new System.Windows.Forms.Padding(3);
            this.tbHostel.Size = new System.Drawing.Size(829, 430);
            this.tbHostel.TabIndex = 0;
            this.tbHostel.Text = "hostel";
            // 
            // tbInfo
            // 
            this.tbInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.tbInfo.Location = new System.Drawing.Point(4, 4);
            this.tbInfo.Name = "tbInfo";
            this.tbInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tbInfo.Size = new System.Drawing.Size(829, 430);
            this.tbInfo.TabIndex = 1;
            this.tbInfo.Text = "info";
            // 
            // tbRoom
            // 
            this.tbRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.tbRoom.Location = new System.Drawing.Point(4, 4);
            this.tbRoom.Name = "tbRoom";
            this.tbRoom.Padding = new System.Windows.Forms.Padding(3);
            this.tbRoom.Size = new System.Drawing.Size(829, 430);
            this.tbRoom.TabIndex = 2;
            this.tbRoom.Text = "room";
            // 
            // tbCustomer
            // 
            this.tbCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.tbCustomer.Location = new System.Drawing.Point(4, 4);
            this.tbCustomer.Name = "tbCustomer";
            this.tbCustomer.Padding = new System.Windows.Forms.Padding(3);
            this.tbCustomer.Size = new System.Drawing.Size(829, 430);
            this.tbCustomer.TabIndex = 3;
            this.tbCustomer.Text = "customer";
            // 
            // tbDashboard
            // 
            this.tbDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.tbDashboard.Controls.Add(this.bunifuLabel2);
            this.tbDashboard.Controls.Add(this.bunifuDatavizBasic1);
            this.tbDashboard.Location = new System.Drawing.Point(4, 4);
            this.tbDashboard.Name = "tbDashboard";
            this.tbDashboard.Padding = new System.Windows.Forms.Padding(3);
            this.tbDashboard.Size = new System.Drawing.Size(829, 430);
            this.tbDashboard.TabIndex = 4;
            this.tbDashboard.Text = "dashboard";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.bunifuButton1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(233, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(837, 43);
            this.panel2.TabIndex = 3;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(3, 13);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(28, 20);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // bunifuButton1
            // 
            this.bunifuButton1.AllowAnimations = true;
            this.bunifuButton1.AllowMouseEffects = true;
            this.bunifuButton1.AllowToggling = false;
            this.bunifuButton1.AnimationSpeed = 200;
            this.bunifuButton1.AutoGenerateColors = false;
            this.bunifuButton1.AutoRoundBorders = false;
            this.bunifuButton1.AutoSizeLeftIcon = true;
            this.bunifuButton1.AutoSizeRightIcon = true;
            this.bunifuButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton1.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.bunifuButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton1.BackgroundImage")));
            this.bunifuButton1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.ButtonText = "     Thêm mới";
            this.bunifuButton1.ButtonTextMarginLeft = 0;
            this.bunifuButton1.ColorContrastOnClick = 45;
            this.bunifuButton1.ColorContrastOnHover = 45;
            this.bunifuButton1.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.bunifuButton1.CustomizableEdges = borderEdges1;
            this.bunifuButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuButton1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton1.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton1.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton1.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.bunifuButton1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuButton1.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuButton1.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton1.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.bunifuButton1.IconMarginLeft = 11;
            this.bunifuButton1.IconPadding = 10;
            this.bunifuButton1.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuButton1.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton1.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.bunifuButton1.IconSize = 25;
            this.bunifuButton1.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.bunifuButton1.IdleBorderRadius = 1;
            this.bunifuButton1.IdleBorderThickness = 1;
            this.bunifuButton1.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.bunifuButton1.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton1.IdleIconLeftImage")));
            this.bunifuButton1.IdleIconRightImage = null;
            this.bunifuButton1.IndicateFocus = false;
            this.bunifuButton1.Location = new System.Drawing.Point(683, 3);
            this.bunifuButton1.Name = "bunifuButton1";
            this.bunifuButton1.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton1.OnDisabledState.BorderRadius = 1;
            this.bunifuButton1.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.OnDisabledState.BorderThickness = 1;
            this.bunifuButton1.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton1.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton1.OnDisabledState.IconLeftImage = null;
            this.bunifuButton1.OnDisabledState.IconRightImage = null;
            this.bunifuButton1.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuButton1.onHoverState.BorderRadius = 1;
            this.bunifuButton1.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.onHoverState.BorderThickness = 1;
            this.bunifuButton1.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuButton1.onHoverState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.onHoverState.IconLeftImage = null;
            this.bunifuButton1.onHoverState.IconRightImage = null;
            this.bunifuButton1.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.bunifuButton1.OnIdleState.BorderRadius = 1;
            this.bunifuButton1.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.OnIdleState.BorderThickness = 1;
            this.bunifuButton1.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.bunifuButton1.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton1.OnIdleState.IconLeftImage")));
            this.bunifuButton1.OnIdleState.IconRightImage = null;
            this.bunifuButton1.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButton1.OnPressedState.BorderRadius = 1;
            this.bunifuButton1.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.OnPressedState.BorderThickness = 1;
            this.bunifuButton1.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButton1.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.OnPressedState.IconLeftImage = null;
            this.bunifuButton1.OnPressedState.IconRightImage = null;
            this.bunifuButton1.Size = new System.Drawing.Size(150, 39);
            this.bunifuButton1.TabIndex = 2;
            this.bunifuButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bunifuButton1.TextMarginLeft = 0;
            this.bunifuButton1.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuButton1.UseDefaultRadiusAndThickness = true;
            this.bunifuButton1.Click += new System.EventHandler(this.bunifuButton1_Click);
            // 
            // bunifuDatavizBasic1
            // 
            this.bunifuDatavizBasic1.animationEnabled = false;
            this.bunifuDatavizBasic1.AxisLineColor = System.Drawing.Color.LightGray;
            this.bunifuDatavizBasic1.AxisXFontColor = System.Drawing.Color.Gray;
            this.bunifuDatavizBasic1.AxisXGridColor = System.Drawing.Color.Gray;
            this.bunifuDatavizBasic1.AxisXGridThickness = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.bunifuDatavizBasic1.AxisYFontColor = System.Drawing.Color.Gray;
            this.bunifuDatavizBasic1.AxisYGridColor = System.Drawing.Color.Gray;
            this.bunifuDatavizBasic1.AxisYGridThickness = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.bunifuDatavizBasic1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuDatavizBasic1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bunifuDatavizBasic1.Location = new System.Drawing.Point(3, 37);
            this.bunifuDatavizBasic1.Name = "bunifuDatavizBasic1";
            this.bunifuDatavizBasic1.Size = new System.Drawing.Size(823, 390);
            this.bunifuDatavizBasic1.TabIndex = 0;
            this.bunifuDatavizBasic1.Theme = Bunifu.Dataviz.WinForms.BunifuDatavizBasic._theme.theme1;
            this.bunifuDatavizBasic1.Title = "";
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuLabel2.Location = new System.Drawing.Point(260, 6);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(327, 25);
            this.bunifuLabel2.TabIndex = 2;
            this.bunifuLabel2.Text = "Thống kê số lượng khách theo tháng";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1070, 546);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pages);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pages.ResumeLayout(false);
            this.tbDashboard.ResumeLayout(false);
            this.tbDashboard.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnHostel;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButton2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnDashboard;
        private Bunifu.UI.WinForms.BunifuPages pages;
        private System.Windows.Forms.TabPage tbHostel;
        private System.Windows.Forms.TabPage tbInfo;
        private System.Windows.Forms.TabPage tbRoom;
        private System.Windows.Forms.TabPage tbCustomer;
        private System.Windows.Forms.TabPage tbDashboard;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.Dataviz.WinForms.BunifuDatavizBasic bunifuDatavizBasic1;
    }
}

