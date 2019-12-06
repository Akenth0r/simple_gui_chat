namespace Client
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
            this.bSend = new System.Windows.Forms.Button();
            this.lIP = new System.Windows.Forms.Label();
            this.tBoxOut = new System.Windows.Forms.TextBox();
            this.tBoxIn = new System.Windows.Forms.TextBox();
            this.bConnect = new System.Windows.Forms.Button();
            this.tbIP = new System.Windows.Forms.TextBox();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.lPort = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.lUsername = new System.Windows.Forms.Label();
            this.bDisconnect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bSend
            // 
            this.bSend.Location = new System.Drawing.Point(462, 325);
            this.bSend.Name = "bSend";
            this.bSend.Size = new System.Drawing.Size(75, 55);
            this.bSend.TabIndex = 0;
            this.bSend.Text = "Send";
            this.bSend.UseVisualStyleBackColor = true;
            this.bSend.Click += new System.EventHandler(this.bSend_Click);
            // 
            // lIP
            // 
            this.lIP.AutoSize = true;
            this.lIP.Location = new System.Drawing.Point(49, 39);
            this.lIP.Name = "lIP";
            this.lIP.Size = new System.Drawing.Size(17, 13);
            this.lIP.TabIndex = 1;
            this.lIP.Text = "IP";
            // 
            // tBoxOut
            // 
            this.tBoxOut.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tBoxOut.Location = new System.Drawing.Point(34, 119);
            this.tBoxOut.Multiline = true;
            this.tBoxOut.Name = "tBoxOut";
            this.tBoxOut.ReadOnly = true;
            this.tBoxOut.Size = new System.Drawing.Size(414, 202);
            this.tBoxOut.TabIndex = 2;
            // 
            // tBoxIn
            // 
            this.tBoxIn.Location = new System.Drawing.Point(34, 327);
            this.tBoxIn.Multiline = true;
            this.tBoxIn.Name = "tBoxIn";
            this.tBoxIn.Size = new System.Drawing.Size(414, 53);
            this.tBoxIn.TabIndex = 3;
            // 
            // bConnect
            // 
            this.bConnect.Location = new System.Drawing.Point(399, 28);
            this.bConnect.Name = "bConnect";
            this.bConnect.Size = new System.Drawing.Size(75, 34);
            this.bConnect.TabIndex = 4;
            this.bConnect.Text = "Connect";
            this.bConnect.UseVisualStyleBackColor = true;
            this.bConnect.Click += new System.EventHandler(this.bConnect_Click);
            // 
            // tbIP
            // 
            this.tbIP.Location = new System.Drawing.Point(72, 36);
            this.tbIP.Name = "tbIP";
            this.tbIP.Size = new System.Drawing.Size(65, 20);
            this.tbIP.TabIndex = 5;
            this.tbIP.Text = "127.0.0.1";
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(185, 36);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(34, 20);
            this.tbPort.TabIndex = 6;
            this.tbPort.Text = "1488";
            // 
            // lPort
            // 
            this.lPort.AutoSize = true;
            this.lPort.Location = new System.Drawing.Point(159, 39);
            this.lPort.Name = "lPort";
            this.lPort.Size = new System.Drawing.Size(26, 13);
            this.lPort.TabIndex = 7;
            this.lPort.Text = "Port";
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(291, 36);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(100, 20);
            this.tbUsername.TabIndex = 8;
            this.tbUsername.Text = "Anonymous";
            // 
            // lUsername
            // 
            this.lUsername.AutoSize = true;
            this.lUsername.Location = new System.Drawing.Point(228, 39);
            this.lUsername.Name = "lUsername";
            this.lUsername.Size = new System.Drawing.Size(55, 13);
            this.lUsername.TabIndex = 9;
            this.lUsername.Text = "Username";
            // 
            // bDisconnect
            // 
            this.bDisconnect.Location = new System.Drawing.Point(399, 68);
            this.bDisconnect.Name = "bDisconnect";
            this.bDisconnect.Size = new System.Drawing.Size(75, 32);
            this.bDisconnect.TabIndex = 10;
            this.bDisconnect.Text = "Disconnect";
            this.bDisconnect.UseVisualStyleBackColor = true;
            this.bDisconnect.Click += new System.EventHandler(this.bDisconnect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 450);
            this.Controls.Add(this.bDisconnect);
            this.Controls.Add(this.lUsername);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.lPort);
            this.Controls.Add(this.tbPort);
            this.Controls.Add(this.tbIP);
            this.Controls.Add(this.bConnect);
            this.Controls.Add(this.tBoxIn);
            this.Controls.Add(this.tBoxOut);
            this.Controls.Add(this.lIP);
            this.Controls.Add(this.bSend);
            this.Name = "Form1";
            this.Text = "Chat client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bSend;
        private System.Windows.Forms.Label lIP;
        private System.Windows.Forms.TextBox tBoxOut;
        private System.Windows.Forms.TextBox tBoxIn;
        private System.Windows.Forms.Button bConnect;
        private System.Windows.Forms.TextBox tbIP;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.Label lPort;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label lUsername;
        private System.Windows.Forms.Button bDisconnect;
    }
}

