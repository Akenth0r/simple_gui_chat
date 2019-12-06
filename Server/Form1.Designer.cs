namespace Server
{
    partial class fServer
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
            this.tbConsole = new System.Windows.Forms.TextBox();
            this.tbIP = new System.Windows.Forms.TextBox();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.lServerIP = new System.Windows.Forms.Label();
            this.lServerPort = new System.Windows.Forms.Label();
            this.bStartServer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbConsole
            // 
            this.tbConsole.Location = new System.Drawing.Point(39, 90);
            this.tbConsole.Multiline = true;
            this.tbConsole.Name = "tbConsole";
            this.tbConsole.ReadOnly = true;
            this.tbConsole.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbConsole.Size = new System.Drawing.Size(444, 200);
            this.tbConsole.TabIndex = 0;
            // 
            // tbIP
            // 
            this.tbIP.Location = new System.Drawing.Point(91, 23);
            this.tbIP.Name = "tbIP";
            this.tbIP.Size = new System.Drawing.Size(100, 20);
            this.tbIP.TabIndex = 1;
            this.tbIP.Text = "127.0.0.1";
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(231, 23);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(49, 20);
            this.tbPort.TabIndex = 2;
            this.tbPort.Text = "1488";
            // 
            // lServerIP
            // 
            this.lServerIP.AutoSize = true;
            this.lServerIP.Location = new System.Drawing.Point(68, 23);
            this.lServerIP.Name = "lServerIP";
            this.lServerIP.Size = new System.Drawing.Size(17, 13);
            this.lServerIP.TabIndex = 3;
            this.lServerIP.Text = "IP";
            // 
            // lServerPort
            // 
            this.lServerPort.AutoSize = true;
            this.lServerPort.Location = new System.Drawing.Point(199, 26);
            this.lServerPort.Name = "lServerPort";
            this.lServerPort.Size = new System.Drawing.Size(26, 13);
            this.lServerPort.TabIndex = 4;
            this.lServerPort.Text = "Port";
            // 
            // bStartServer
            // 
            this.bStartServer.Location = new System.Drawing.Point(309, 21);
            this.bStartServer.Name = "bStartServer";
            this.bStartServer.Size = new System.Drawing.Size(75, 23);
            this.bStartServer.TabIndex = 5;
            this.bStartServer.Text = "Start server";
            this.bStartServer.UseVisualStyleBackColor = true;
            this.bStartServer.Click += new System.EventHandler(this.bStartServer_Click);
            // 
            // fServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 330);
            this.Controls.Add(this.bStartServer);
            this.Controls.Add(this.lServerPort);
            this.Controls.Add(this.lServerIP);
            this.Controls.Add(this.tbPort);
            this.Controls.Add(this.tbIP);
            this.Controls.Add(this.tbConsole);
            this.Name = "fServer";
            this.Text = "Server";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fServer_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbConsole;
        private System.Windows.Forms.TextBox tbIP;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.Label lServerIP;
        private System.Windows.Forms.Label lServerPort;
        private System.Windows.Forms.Button bStartServer;
    }
}

