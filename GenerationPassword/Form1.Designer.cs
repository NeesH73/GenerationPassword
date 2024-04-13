namespace GenerationPassword
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
        public void InitializeComponent()
        {
            this.vklpoxojix = new System.Windows.Forms.CheckBox();
            this.vklnebykv = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.length = new System.Windows.Forms.NumericUpDown();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btngeneration = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnsaved = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.length)).BeginInit();
            this.SuspendLayout();
            // 
            // vklpoxojix
            // 
            this.vklpoxojix.AutoSize = true;
            this.vklpoxojix.Location = new System.Drawing.Point(44, 95);
            this.vklpoxojix.Name = "vklpoxojix";
            this.vklpoxojix.Size = new System.Drawing.Size(194, 17);
            this.vklpoxojix.TabIndex = 0;
            this.vklpoxojix.Text = "Использовать похожие символы";
            this.vklpoxojix.UseVisualStyleBackColor = true;
            // 
            // vklnebykv
            // 
            this.vklnebykv.AutoSize = true;
            this.vklnebykv.Location = new System.Drawing.Point(44, 118);
            this.vklnebykv.Name = "vklnebykv";
            this.vklnebykv.Size = new System.Drawing.Size(218, 17);
            this.vklnebykv.TabIndex = 1;
            this.vklnebykv.Text = "Использовать небуквенные символы";
            this.vklnebykv.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Количество символов:";
            // 
            // length
            // 
            this.length.Location = new System.Drawing.Point(159, 69);
            this.length.Name = "length";
            this.length.Size = new System.Drawing.Size(120, 20);
            this.length.TabIndex = 3;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(487, 69);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(150, 20);
            this.textBoxLogin.TabIndex = 4;
            // 
            // textBoxPass
            // 
            this.textBoxPass.Location = new System.Drawing.Point(487, 115);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.Size = new System.Drawing.Size(150, 20);
            this.textBoxPass.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(397, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Введите логин:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(343, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Сгенерированный пароль:";
            // 
            // btngeneration
            // 
            this.btngeneration.Location = new System.Drawing.Point(44, 159);
            this.btngeneration.Name = "btngeneration";
            this.btngeneration.Size = new System.Drawing.Size(134, 23);
            this.btngeneration.TabIndex = 8;
            this.btngeneration.Text = "Сгенерировать пароль";
            this.btngeneration.UseVisualStyleBackColor = true;
            this.btngeneration.Click += new System.EventHandler(this.btngeneration_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(590, 12);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(75, 23);
            this.btnexit.TabIndex = 9;
            this.btnexit.Text = "Закрыть";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnsaved
            // 
            this.btnsaved.Location = new System.Drawing.Point(422, 159);
            this.btnsaved.Name = "btnsaved";
            this.btnsaved.Size = new System.Drawing.Size(155, 23);
            this.btnsaved.TabIndex = 10;
            this.btnsaved.Text = "Сохранить данные в файл";
            this.btnsaved.UseVisualStyleBackColor = true;
            this.btnsaved.Click += new System.EventHandler(this.btnsaved_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 227);
            this.Controls.Add(this.btnsaved);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btngeneration);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPass);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.length);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vklnebykv);
            this.Controls.Add(this.vklpoxojix);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.length)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.CheckBox vklpoxojix;
        public System.Windows.Forms.CheckBox vklnebykv;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.NumericUpDown length;
        public System.Windows.Forms.TextBox textBoxLogin;
        public System.Windows.Forms.TextBox textBoxPass;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button btngeneration;
        public System.Windows.Forms.Button btnexit;
        public System.Windows.Forms.Button btnsaved;
    }
}

