
namespace _01._04._22
{
    partial class Regist
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.name = new System.Windows.Forms.Label();
            this.namebox = new System.Windows.Forms.RichTextBox();
            this.startbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("SimSun-ExtB", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(90, 74);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(87, 33);
            this.name.TabIndex = 0;
            this.name.Text = "Имя:";
            // 
            // namebox
            // 
            this.namebox.Location = new System.Drawing.Point(197, 74);
            this.namebox.Name = "namebox";
            this.namebox.Size = new System.Drawing.Size(152, 33);
            this.namebox.TabIndex = 1;
            this.namebox.Text = "";
            // 
            // startbutton
            // 
            this.startbutton.Location = new System.Drawing.Point(223, 154);
            this.startbutton.Name = "startbutton";
            this.startbutton.Size = new System.Drawing.Size(108, 39);
            this.startbutton.TabIndex = 2;
            this.startbutton.Text = "Старт";
            this.startbutton.UseVisualStyleBackColor = true;
            this.startbutton.Click += new System.EventHandler(this.startbutton_Click);
            // 
            // Regist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(553, 285);
            this.Controls.Add(this.startbutton);
            this.Controls.Add(this.namebox);
            this.Controls.Add(this.name);
            this.MaximizeBox = false;
            this.Name = "Regist";
            this.Text = "Регистрация ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name;
        private System.Windows.Forms.RichTextBox namebox;
        private System.Windows.Forms.Button startbutton;
    }
}

