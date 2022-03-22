namespace Monon
{
    partial class FormMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

      
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.keepOnSw = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // keepOnSw
            // 
            this.keepOnSw.AutoSize = true;
            this.keepOnSw.Location = new System.Drawing.Point(10, 11);
            this.keepOnSw.Margin = new System.Windows.Forms.Padding(2);
            this.keepOnSw.Name = "keepOnSw";
            this.keepOnSw.Size = new System.Drawing.Size(103, 17);
            this.keepOnSw.TabIndex = 0;
            this.keepOnSw.Text = "Enable No Lock";
            this.keepOnSw.UseVisualStyleBackColor = true;
            this.keepOnSw.CheckedChanged += new System.EventHandler(this.keepOnSw_CheckedChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(224, 39);
            this.Controls.Add(this.keepOnSw);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "No Lock v2";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        private System.Windows.Forms.CheckBox keepOnSw;
    }
}

