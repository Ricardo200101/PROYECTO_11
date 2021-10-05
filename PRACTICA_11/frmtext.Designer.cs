
namespace PRACTICA_11
{
    partial class frmtext
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
            this.btntes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btntes
            // 
            this.btntes.Location = new System.Drawing.Point(306, 208);
            this.btntes.Name = "btntes";
            this.btntes.Size = new System.Drawing.Size(134, 31);
            this.btntes.TabIndex = 1;
            this.btntes.Text = "text ";
            this.btntes.UseVisualStyleBackColor = true;
            this.btntes.Click += new System.EventHandler(this.btntes_Click);
            // 
            // frmtext
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btntes);
            this.Name = "frmtext";
            this.Text = "frmtext";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btntes;
    }
}