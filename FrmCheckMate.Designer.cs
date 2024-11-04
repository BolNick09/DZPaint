namespace Drawing2
{
    partial class FrmCheckMate
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCheckMate = new Button();
            SuspendLayout();
            // 
            // btnCheckMate
            // 
            btnCheckMate.Location = new Point(12, 139);
            btnCheckMate.Name = "btnCheckMate";
            btnCheckMate.Size = new Size(143, 29);
            btnCheckMate.TabIndex = 0;
            btnCheckMate.Text = "Отрисовать доску";
            btnCheckMate.UseVisualStyleBackColor = true;
            btnCheckMate.Click += btnCheckMate_Click_1;
            // 
            // FrmCheckMate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(165, 175);
            Controls.Add(btnCheckMate);
            Name = "FrmCheckMate";
            Text = "Холст";
            ResumeLayout(false);
        }

        #endregion

        private Button btnCheckMate;
    }
}
