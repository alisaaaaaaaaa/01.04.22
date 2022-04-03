
namespace _01._04._22
{
    partial class Rules
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rules));
            this.rulalebel = new System.Windows.Forms.Label();
            this.rlabele = new System.Windows.Forms.Label();
            this.okbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rulalebel
            // 
            this.rulalebel.AutoSize = true;
            this.rulalebel.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rulalebel.Location = new System.Drawing.Point(42, 96);
            this.rulalebel.Name = "rulalebel";
            this.rulalebel.Size = new System.Drawing.Size(536, 190);
            this.rulalebel.TabIndex = 0;
            this.rulalebel.Text = resources.GetString("rulalebel.Text");
            // 
            // rlabele
            // 
            this.rlabele.AutoSize = true;
            this.rlabele.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rlabele.Location = new System.Drawing.Point(225, 36);
            this.rlabele.Name = "rlabele";
            this.rlabele.Size = new System.Drawing.Size(96, 22);
            this.rlabele.TabIndex = 1;
            this.rlabele.Text = "ПРАВИЛА";
            // 
            // okbutton
            // 
            this.okbutton.Location = new System.Drawing.Point(197, 242);
            this.okbutton.Name = "okbutton";
            this.okbutton.Size = new System.Drawing.Size(173, 44);
            this.okbutton.TabIndex = 2;
            this.okbutton.Text = "OK";
            this.okbutton.UseVisualStyleBackColor = true;
            this.okbutton.Click += new System.EventHandler(this.okbutton_Click);
            // 
            // Rules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(590, 315);
            this.Controls.Add(this.okbutton);
            this.Controls.Add(this.rlabele);
            this.Controls.Add(this.rulalebel);
            this.MaximizeBox = false;
            this.Name = "Rules";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label rulalebel;
        private System.Windows.Forms.Label rlabele;
        private System.Windows.Forms.Button okbutton;
    }
}