
namespace PointOfSale
{
    partial class Form1
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
            this.gbxClient = new System.Windows.Forms.GroupBox();
            this.lblClient = new System.Windows.Forms.Label();
            this.cmbClient = new System.Windows.Forms.ComboBox();
            this.cmbAgent = new System.Windows.Forms.ComboBox();
            this.lblAgent = new System.Windows.Forms.Label();
            this.gbxClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxClient
            // 
            this.gbxClient.Controls.Add(this.lblAgent);
            this.gbxClient.Controls.Add(this.cmbAgent);
            this.gbxClient.Controls.Add(this.lblClient);
            this.gbxClient.Controls.Add(this.cmbClient);
            this.gbxClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxClient.Location = new System.Drawing.Point(12, 13);
            this.gbxClient.Name = "gbxClient";
            this.gbxClient.Size = new System.Drawing.Size(442, 124);
            this.gbxClient.TabIndex = 0;
            this.gbxClient.TabStop = false;
            this.gbxClient.Text = "Personnel";
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Location = new System.Drawing.Point(4, 30);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(53, 20);
            this.lblClient.TabIndex = 1;
            this.lblClient.Text = "Client:";
            // 
            // cmbClient
            // 
            this.cmbClient.FormattingEnabled = true;
            this.cmbClient.Location = new System.Drawing.Point(86, 29);
            this.cmbClient.Name = "cmbClient";
            this.cmbClient.Size = new System.Drawing.Size(286, 28);
            this.cmbClient.TabIndex = 0;
            this.cmbClient.SelectedIndexChanged += new System.EventHandler(this.cmbClient_SelectedIndexChanged);
            // 
            // cmbAgent
            // 
            this.cmbAgent.FormattingEnabled = true;
            this.cmbAgent.Location = new System.Drawing.Point(86, 63);
            this.cmbAgent.Name = "cmbAgent";
            this.cmbAgent.Size = new System.Drawing.Size(286, 28);
            this.cmbAgent.TabIndex = 2;
            // 
            // lblAgent
            // 
            this.lblAgent.AutoSize = true;
            this.lblAgent.Location = new System.Drawing.Point(6, 71);
            this.lblAgent.Name = "lblAgent";
            this.lblAgent.Size = new System.Drawing.Size(52, 20);
            this.lblAgent.TabIndex = 3;
            this.lblAgent.Text = "Agent";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1479, 558);
            this.Controls.Add(this.gbxClient);
            this.Name = "Form1";
            this.Text = "Lab Input";
            this.gbxClient.ResumeLayout(false);
            this.gbxClient.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxClient;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.ComboBox cmbClient;
        private System.Windows.Forms.Label lblAgent;
        private System.Windows.Forms.ComboBox cmbAgent;
    }
}

