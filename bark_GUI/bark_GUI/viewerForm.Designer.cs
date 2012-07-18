namespace bark_GUI
{
    partial class viewerForm
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
            this.viewer = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.viewer)).BeginInit();
            this.viewer.SuspendLayout();
            this.SuspendLayout();
            // 
            // viewer
            // 
            this.viewer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.viewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewer.Location = new System.Drawing.Point(0, 0);
            this.viewer.Name = "viewer";
            // 
            // viewer.Panel1
            // 
            this.viewer.Panel1.AutoScroll = true;
            // 
            // viewer.Panel2
            // 
            this.viewer.Panel2.AutoScroll = true;
            this.viewer.Size = new System.Drawing.Size(884, 684);
            this.viewer.SplitterDistance = 193;
            this.viewer.TabIndex = 0;
            // 
            // viewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 684);
            this.Controls.Add(this.viewer);
            this.HelpButton = true;
            this.Name = "viewerForm";
            this.Opacity = 0.9D;
            this.Text = "Viewer";
            ((System.ComponentModel.ISupportInitialize)(this.viewer)).EndInit();
            this.viewer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer viewer;
    }
}