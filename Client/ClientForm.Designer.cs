namespace Client
{
    partial class ClientForm
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
            this.RequestBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.AnswerBox = new System.Windows.Forms.TextBox();
            this.ClearBox = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RequestBox
            // 
            this.RequestBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RequestBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RequestBox.Location = new System.Drawing.Point(12, 12);
            this.RequestBox.Name = "RequestBox";
            this.RequestBox.Size = new System.Drawing.Size(645, 15);
            this.RequestBox.TabIndex = 0;
            this.RequestBox.Text = "Введите запрос";
            this.RequestBox.TextChanged += new System.EventHandler(this.RequestBox_TextChanged);
            this.RequestBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RequestBox_KeyDown);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(675, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 20);
            this.button1.TabIndex = 1;
            this.button1.Text = "Поиск";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AnswerBox
            // 
            this.AnswerBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AnswerBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AnswerBox.Location = new System.Drawing.Point(12, 54);
            this.AnswerBox.Name = "AnswerBox";
            this.AnswerBox.ReadOnly = true;
            this.AnswerBox.Size = new System.Drawing.Size(645, 15);
            this.AnswerBox.TabIndex = 2;
            this.AnswerBox.TextChanged += new System.EventHandler(this.AnswerBox_TextChanged);
            // 
            // ClearBox
            // 
            this.ClearBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClearBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ClearBox.Location = new System.Drawing.Point(675, 50);
            this.ClearBox.Name = "ClearBox";
            this.ClearBox.Size = new System.Drawing.Size(75, 20);
            this.ClearBox.TabIndex = 3;
            this.ClearBox.Text = "Очистить";
            this.ClearBox.UseVisualStyleBackColor = false;
            this.ClearBox.Click += new System.EventHandler(this.button2_Click);
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 106);
            this.Controls.Add(this.ClearBox);
            this.Controls.Add(this.AnswerBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RequestBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(778, 145);
            this.MinimumSize = new System.Drawing.Size(778, 145);
            this.Name = "ClientForm";
            this.Text = "Клиент";
            this.Load += new System.EventHandler(this.ClientForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox RequestBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox AnswerBox;
        private System.Windows.Forms.Button ClearBox;
    }
}

