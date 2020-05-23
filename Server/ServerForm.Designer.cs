namespace Server
{
    partial class ServerForm
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
            this.LogBox = new System.Windows.Forms.TextBox();
            this.bStartClient = new System.Windows.Forms.Button();
            this.ClientsBar = new System.Windows.Forms.TrackBar();
            this.bDeleteClients = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьЛогToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьЛогToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveFileTxt = new System.Windows.Forms.SaveFileDialog();
            this.OpenFileTxt = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.ClientsBar)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LogBox
            // 
            this.LogBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.LogBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LogBox.Location = new System.Drawing.Point(12, 30);
            this.LogBox.Multiline = true;
            this.LogBox.Name = "LogBox";
            this.LogBox.ReadOnly = true;
            this.LogBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.LogBox.Size = new System.Drawing.Size(650, 156);
            this.LogBox.TabIndex = 0;
            this.LogBox.TextChanged += new System.EventHandler(this.LogBox_TextChanged);
            // 
            // bStartClient
            // 
            this.bStartClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bStartClient.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bStartClient.Location = new System.Drawing.Point(479, 192);
            this.bStartClient.Name = "bStartClient";
            this.bStartClient.Size = new System.Drawing.Size(82, 45);
            this.bStartClient.TabIndex = 1;
            this.bStartClient.Text = "Подключить 1 клиента";
            this.bStartClient.UseVisualStyleBackColor = true;
            this.bStartClient.Click += new System.EventHandler(this.bStartClient_Click);
            // 
            // ClientsBar
            // 
            this.ClientsBar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ClientsBar.LargeChange = 1;
            this.ClientsBar.Location = new System.Drawing.Point(12, 193);
            this.ClientsBar.Minimum = 1;
            this.ClientsBar.Name = "ClientsBar";
            this.ClientsBar.Size = new System.Drawing.Size(439, 45);
            this.ClientsBar.TabIndex = 10;
            this.ClientsBar.Value = 1;
            this.ClientsBar.Scroll += new System.EventHandler(this.ClientsBar_Scroll);
            // 
            // bDeleteClients
            // 
            this.bDeleteClients.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bDeleteClients.Enabled = false;
            this.bDeleteClients.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bDeleteClients.Location = new System.Drawing.Point(580, 193);
            this.bDeleteClients.Name = "bDeleteClients";
            this.bDeleteClients.Size = new System.Drawing.Size(82, 45);
            this.bDeleteClients.TabIndex = 11;
            this.bDeleteClients.Text = "Сброс";
            this.bDeleteClients.UseVisualStyleBackColor = true;
            this.bDeleteClients.Click += new System.EventHandler(this.bDeleteClients_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(674, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "MenuStrip";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьЛогToolStripMenuItem,
            this.открытьЛогToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(39, 20);
            this.toolStripMenuItem1.Text = "Лог";
            // 
            // сохранитьЛогToolStripMenuItem
            // 
            this.сохранитьЛогToolStripMenuItem.Name = "сохранитьЛогToolStripMenuItem";
            this.сохранитьЛогToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.сохранитьЛогToolStripMenuItem.Text = "Сохранить лог";
            this.сохранитьЛогToolStripMenuItem.Click += new System.EventHandler(this.сохранитьЛогToolStripMenuItem_Click);
            // 
            // открытьЛогToolStripMenuItem
            // 
            this.открытьЛогToolStripMenuItem.Name = "открытьЛогToolStripMenuItem";
            this.открытьЛогToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.открытьЛогToolStripMenuItem.Text = "Открыть лог";
            this.открытьЛогToolStripMenuItem.Click += new System.EventHandler(this.открытьЛогToolStripMenuItem_Click);
            // 
            // SaveFileTxt
            // 
            this.SaveFileTxt.FileName = "log.txt";
            this.SaveFileTxt.Filter = "Текстовые файлы(*.txt)|*.txt";
            // 
            // OpenFileTxt
            // 
            this.OpenFileTxt.FileName = "OpenFileTxt";
            this.OpenFileTxt.Filter = "Текстовые файлы(*.txt)|*.txt";
            // 
            // ServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 246);
            this.Controls.Add(this.bDeleteClients);
            this.Controls.Add(this.ClientsBar);
            this.Controls.Add(this.bStartClient);
            this.Controls.Add(this.LogBox);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(690, 285);
            this.MinimumSize = new System.Drawing.Size(690, 285);
            this.Name = "ServerForm";
            this.Text = "База данных";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ServerForm_FormClosing);
            this.Load += new System.EventHandler(this.ServerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClientsBar)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LogBox;
        private System.Windows.Forms.Button bStartClient;
        private System.Windows.Forms.TrackBar ClientsBar;
        private System.Windows.Forms.Button bDeleteClients;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem сохранитьЛогToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьЛогToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog SaveFileTxt;
        private System.Windows.Forms.OpenFileDialog OpenFileTxt;
    }
}

