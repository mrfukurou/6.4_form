namespace WindowsFormsApp16
{
    partial class Form1
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
            this.Nn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Mass = new System.Windows.Forms.TextBox();
            this.Rez = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.newmas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Nn
            // 
            this.Nn.Location = new System.Drawing.Point(208, 10);
            this.Nn.Name = "Nn";
            this.Nn.Size = new System.Drawing.Size(156, 22);
            this.Nn.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите размер массива: ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(370, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 24);
            this.button1.TabIndex = 2;
            this.button1.Text = "Вычислить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Mass
            // 
            this.Mass.Location = new System.Drawing.Point(12, 42);
            this.Mass.Multiline = true;
            this.Mass.Name = "Mass";
            this.Mass.ReadOnly = true;
            this.Mass.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Mass.Size = new System.Drawing.Size(472, 193);
            this.Mass.TabIndex = 3;
            // 
            // Rez
            // 
            this.Rez.Location = new System.Drawing.Point(12, 304);
            this.Rez.Multiline = true;
            this.Rez.Name = "Rez";
            this.Rez.ReadOnly = true;
            this.Rez.Size = new System.Drawing.Size(352, 62);
            this.Rez.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(380, 304);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 62);
            this.button2.TabIndex = 5;
            this.button2.Text = "Очистить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // newmas
            // 
            this.newmas.Location = new System.Drawing.Point(12, 258);
            this.newmas.Multiline = true;
            this.newmas.Name = "newmas";
            this.newmas.ReadOnly = true;
            this.newmas.Size = new System.Drawing.Size(472, 40);
            this.newmas.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Новый массив:\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 378);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.newmas);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Rez);
            this.Controls.Add(this.Mass);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Nn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Nn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Mass;
        private System.Windows.Forms.TextBox Rez;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox newmas;
        private System.Windows.Forms.Label label2;
    }
}

