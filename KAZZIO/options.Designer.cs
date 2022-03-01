namespace KAZZIO
{
    partial class options
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
            this.label1 = new System.Windows.Forms.Label();
            this.gunaButton17 = new Guna.UI.WinForms.GunaButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(78, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Options";
            // 
            // gunaButton17
            // 
            this.gunaButton17.Animated = true;
            this.gunaButton17.AnimationHoverSpeed = 0.05F;
            this.gunaButton17.AnimationSpeed = 0.01F;
            this.gunaButton17.BaseColor = System.Drawing.Color.Transparent;
            this.gunaButton17.BorderColor = System.Drawing.Color.Black;
            this.gunaButton17.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton17.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton17.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton17.ForeColor = System.Drawing.Color.White;
            this.gunaButton17.Image = null;
            this.gunaButton17.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton17.Location = new System.Drawing.Point(232, 6);
            this.gunaButton17.Margin = new System.Windows.Forms.Padding(4);
            this.gunaButton17.Name = "gunaButton17";
            this.gunaButton17.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.gunaButton17.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton17.OnHoverForeColor = System.Drawing.Color.Wheat;
            this.gunaButton17.OnHoverImage = null;
            this.gunaButton17.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton17.Size = new System.Drawing.Size(32, 31);
            this.gunaButton17.TabIndex = 26;
            this.gunaButton17.Text = "X";
            // 
            // options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(269, 327);
            this.Controls.Add(this.gunaButton17);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "options";
            this.Text = "options";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaButton gunaButton17;
    }
}