namespace Drawing2
{
    partial class FrmPaint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPaint));
            toolStrip1 = new ToolStrip();
            btnClearAll = new ToolStripButton();
            btnLine = new ToolStripButton();
            btnSquare = new ToolStripButton();
            btnEllipse = new ToolStripButton();
            btnTriangle = new ToolStripButton();
            btnSave = new ToolStripButton();
            label1 = new Label();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnClearAll, btnLine, btnSquare, btnEllipse, btnTriangle, btnSave });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 27);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnClearAll
            // 
            btnClearAll.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnClearAll.Image = (Image)resources.GetObject("btnClearAll.Image");
            btnClearAll.ImageTransparentColor = Color.Magenta;
            btnClearAll.Name = "btnClearAll";
            btnClearAll.Size = new Size(29, 24);
            btnClearAll.Text = "Очистить";
            btnClearAll.Click += btnClearAll_Click;
            // 
            // btnLine
            // 
            btnLine.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnLine.Image = (Image)resources.GetObject("btnLine.Image");
            btnLine.ImageTransparentColor = Color.Magenta;
            btnLine.Name = "btnLine";
            btnLine.Size = new Size(29, 24);
            btnLine.Text = "Линия";
            btnLine.Click += btnLine_Click;
            // 
            // btnSquare
            // 
            btnSquare.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnSquare.Image = (Image)resources.GetObject("btnSquare.Image");
            btnSquare.ImageTransparentColor = Color.Magenta;
            btnSquare.Name = "btnSquare";
            btnSquare.Size = new Size(29, 24);
            btnSquare.Text = "Прямоугольник";
            btnSquare.Click += btnSquare_Click;
            // 
            // btnEllipse
            // 
            btnEllipse.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnEllipse.Image = (Image)resources.GetObject("btnEllipse.Image");
            btnEllipse.ImageTransparentColor = Color.Magenta;
            btnEllipse.Name = "btnEllipse";
            btnEllipse.Size = new Size(29, 24);
            btnEllipse.Text = "Эллипс";
            btnEllipse.Click += btnEllipse_Click;
            // 
            // btnTriangle
            // 
            btnTriangle.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnTriangle.Image = (Image)resources.GetObject("btnTriangle.Image");
            btnTriangle.ImageTransparentColor = Color.Magenta;
            btnTriangle.Name = "btnTriangle";
            btnTriangle.Size = new Size(29, 24);
            btnTriangle.Text = "Треугольник";
            btnTriangle.Click += btnTriangle_Click;
            // 
            // btnSave
            // 
            btnSave.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnSave.Image = (Image)resources.GetObject("btnSave.Image");
            btnSave.ImageTransparentColor = Color.Magenta;
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(29, 24);
            btnSave.Text = "Сохранить";
            btnSave.Click += btnSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(572, 355);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // FrmPaint
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(toolStrip1);
            Name = "FrmPaint";
            Text = "FrmPaint";
            Load += FrmPaint_Load;
            Paint += FrmPaint_Paint;
            MouseDown += FrmPaint_MouseDown;
            MouseMove += FrmPaint_MouseMove;
            MouseUp += FrmPaint_MouseUp;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton btnClearAll;
        private ToolStripButton btnLine;
        private ToolStripButton btnSquare;
        private ToolStripButton btnEllipse;
        private ToolStripButton btnTriangle;
        private ToolStripButton btnSave;
        private Label label1;
    }
}