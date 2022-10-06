
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
            this.lblAgent = new System.Windows.Forms.Label();
            this.cmbAgent = new System.Windows.Forms.ComboBox();
            this.lblClient = new System.Windows.Forms.Label();
            this.cmbClient = new System.Windows.Forms.ComboBox();
            this.chkProject = new System.Windows.Forms.CheckBox();
            this.gbxBilling = new System.Windows.Forms.GroupBox();
            this.txtBillingNotes = new System.Windows.Forms.TextBox();
            this.lblBillingNotes = new System.Windows.Forms.Label();
            this.cmbBillTo = new System.Windows.Forms.ComboBox();
            this.gbxProject = new System.Windows.Forms.GroupBox();
            this.lblTest = new System.Windows.Forms.Label();
            this.cmbTest = new System.Windows.Forms.ComboBox();
            this.lblProjectType = new System.Windows.Forms.Label();
            this.cmbPriorityRequested = new System.Windows.Forms.ComboBox();
            this.lblPriorityRequested = new System.Windows.Forms.Label();
            this.cmbProjectObjective = new System.Windows.Forms.ComboBox();
            this.lblObjective = new System.Windows.Forms.Label();
            this.cmbPrice = new System.Windows.Forms.ComboBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblDateInitiated = new System.Windows.Forms.Label();
            this.dtpDateInitiated = new System.Windows.Forms.DateTimePicker();
            this.lblProjectNotes = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cmbProjectType = new System.Windows.Forms.ComboBox();
            this.cmbSite = new System.Windows.Forms.ComboBox();
            this.gbxSample = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblDateSampleReceived = new System.Windows.Forms.Label();
            this.lblDateSampleColleted = new System.Windows.Forms.Label();
            this.dtpSampleReceived = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblField = new System.Windows.Forms.Label();
            this.cmbField = new System.Windows.Forms.ComboBox();
            this.lblDLS = new System.Windows.Forms.Label();
            this.cmbDLS = new System.Windows.Forms.ComboBox();
            this.lblZone = new System.Windows.Forms.Label();
            this.cmbZone = new System.Windows.Forms.ComboBox();
            this.lblSite = new System.Windows.Forms.Label();
            this.gbxTest = new System.Windows.Forms.GroupBox();
            this.btnRunBatch = new System.Windows.Forms.Button();
            this.dtpReportSent = new System.Windows.Forms.DateTimePicker();
            this.chkReported = new System.Windows.Forms.CheckBox();
            this.cmbPriorityAssigned = new System.Windows.Forms.ComboBox();
            this.lblPriorityAssigned = new System.Windows.Forms.Label();
            this.dgvDisplay = new System.Windows.Forms.DataGridView();
            this.gbxClient.SuspendLayout();
            this.gbxBilling.SuspendLayout();
            this.gbxProject.SuspendLayout();
            this.gbxSample.SuspendLayout();
            this.gbxTest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxClient
            // 
            this.gbxClient.Controls.Add(this.lblAgent);
            this.gbxClient.Controls.Add(this.cmbAgent);
            this.gbxClient.Controls.Add(this.lblClient);
            this.gbxClient.Controls.Add(this.cmbClient);
            this.gbxClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxClient.Location = new System.Drawing.Point(12, 13);
            this.gbxClient.Name = "gbxClient";
            this.gbxClient.Size = new System.Drawing.Size(611, 124);
            this.gbxClient.TabIndex = 0;
            this.gbxClient.TabStop = false;
            this.gbxClient.Text = "Personnel";
            // 
            // lblAgent
            // 
            this.lblAgent.AutoSize = true;
            this.lblAgent.Location = new System.Drawing.Point(51, 79);
            this.lblAgent.Name = "lblAgent";
            this.lblAgent.Size = new System.Drawing.Size(43, 16);
            this.lblAgent.TabIndex = 3;
            this.lblAgent.Text = "Agent";
            // 
            // cmbAgent
            // 
            this.cmbAgent.FormattingEnabled = true;
            this.cmbAgent.Location = new System.Drawing.Point(131, 71);
            this.cmbAgent.Name = "cmbAgent";
            this.cmbAgent.Size = new System.Drawing.Size(286, 24);
            this.cmbAgent.TabIndex = 2;
            this.cmbAgent.SelectedIndexChanged += new System.EventHandler(this.cmbAgent_SelectedIndexChanged);
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Location = new System.Drawing.Point(49, 38);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(44, 16);
            this.lblClient.TabIndex = 1;
            this.lblClient.Text = "Client:";
            // 
            // cmbClient
            // 
            this.cmbClient.FormattingEnabled = true;
            this.cmbClient.Location = new System.Drawing.Point(131, 37);
            this.cmbClient.Name = "cmbClient";
            this.cmbClient.Size = new System.Drawing.Size(286, 24);
            this.cmbClient.TabIndex = 0;
            this.cmbClient.SelectedIndexChanged += new System.EventHandler(this.cmbClient_SelectedIndexChanged);
            // 
            // chkProject
            // 
            this.chkProject.AutoSize = true;
            this.chkProject.Location = new System.Drawing.Point(21, 29);
            this.chkProject.Name = "chkProject";
            this.chkProject.Size = new System.Drawing.Size(91, 20);
            this.chkProject.TabIndex = 1;
            this.chkProject.Text = "Bill Client ?";
            this.chkProject.UseVisualStyleBackColor = true;
            // 
            // gbxBilling
            // 
            this.gbxBilling.Controls.Add(this.txtBillingNotes);
            this.gbxBilling.Controls.Add(this.lblBillingNotes);
            this.gbxBilling.Controls.Add(this.cmbBillTo);
            this.gbxBilling.Controls.Add(this.chkProject);
            this.gbxBilling.Location = new System.Drawing.Point(10, 219);
            this.gbxBilling.Name = "gbxBilling";
            this.gbxBilling.Size = new System.Drawing.Size(426, 95);
            this.gbxBilling.TabIndex = 2;
            this.gbxBilling.TabStop = false;
            this.gbxBilling.Text = "Billing";
            // 
            // txtBillingNotes
            // 
            this.txtBillingNotes.Location = new System.Drawing.Point(80, 70);
            this.txtBillingNotes.Name = "txtBillingNotes";
            this.txtBillingNotes.Size = new System.Drawing.Size(299, 22);
            this.txtBillingNotes.TabIndex = 8;
            // 
            // lblBillingNotes
            // 
            this.lblBillingNotes.AutoSize = true;
            this.lblBillingNotes.Location = new System.Drawing.Point(18, 72);
            this.lblBillingNotes.Name = "lblBillingNotes";
            this.lblBillingNotes.Size = new System.Drawing.Size(44, 16);
            this.lblBillingNotes.TabIndex = 7;
            this.lblBillingNotes.Text = "Notes";
            // 
            // cmbBillTo
            // 
            this.cmbBillTo.FormattingEnabled = true;
            this.cmbBillTo.Location = new System.Drawing.Point(154, 25);
            this.cmbBillTo.Name = "cmbBillTo";
            this.cmbBillTo.Size = new System.Drawing.Size(226, 24);
            this.cmbBillTo.TabIndex = 6;
            // 
            // gbxProject
            // 
            this.gbxProject.Controls.Add(this.lblTest);
            this.gbxProject.Controls.Add(this.cmbTest);
            this.gbxProject.Controls.Add(this.lblProjectType);
            this.gbxProject.Controls.Add(this.cmbPriorityRequested);
            this.gbxProject.Controls.Add(this.lblPriorityRequested);
            this.gbxProject.Controls.Add(this.cmbProjectObjective);
            this.gbxProject.Controls.Add(this.lblObjective);
            this.gbxProject.Controls.Add(this.cmbPrice);
            this.gbxProject.Controls.Add(this.lblPrice);
            this.gbxProject.Controls.Add(this.lblDateInitiated);
            this.gbxProject.Controls.Add(this.dtpDateInitiated);
            this.gbxProject.Controls.Add(this.lblProjectNotes);
            this.gbxProject.Controls.Add(this.textBox1);
            this.gbxProject.Controls.Add(this.cmbProjectType);
            this.gbxProject.Controls.Add(this.gbxBilling);
            this.gbxProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxProject.Location = new System.Drawing.Point(12, 154);
            this.gbxProject.Name = "gbxProject";
            this.gbxProject.Size = new System.Drawing.Size(611, 330);
            this.gbxProject.TabIndex = 3;
            this.gbxProject.TabStop = false;
            this.gbxProject.Text = "Project";
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.Location = new System.Drawing.Point(275, 43);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(105, 16);
            this.lblTest.TabIndex = 18;
            this.lblTest.Text = "Test Requested";
            // 
            // cmbTest
            // 
            this.cmbTest.FormattingEnabled = true;
            this.cmbTest.Location = new System.Drawing.Point(386, 35);
            this.cmbTest.Name = "cmbTest";
            this.cmbTest.Size = new System.Drawing.Size(210, 24);
            this.cmbTest.TabIndex = 17;
            this.cmbTest.Text = "Select Test";
            // 
            // lblProjectType
            // 
            this.lblProjectType.AutoSize = true;
            this.lblProjectType.Location = new System.Drawing.Point(20, 43);
            this.lblProjectType.Name = "lblProjectType";
            this.lblProjectType.Size = new System.Drawing.Size(85, 16);
            this.lblProjectType.TabIndex = 16;
            this.lblProjectType.Text = "Project Type";
            // 
            // cmbPriorityRequested
            // 
            this.cmbPriorityRequested.FormattingEnabled = true;
            this.cmbPriorityRequested.Location = new System.Drawing.Point(441, 130);
            this.cmbPriorityRequested.Name = "cmbPriorityRequested";
            this.cmbPriorityRequested.Size = new System.Drawing.Size(121, 24);
            this.cmbPriorityRequested.TabIndex = 15;
            // 
            // lblPriorityRequested
            // 
            this.lblPriorityRequested.AutoSize = true;
            this.lblPriorityRequested.Location = new System.Drawing.Point(316, 130);
            this.lblPriorityRequested.Name = "lblPriorityRequested";
            this.lblPriorityRequested.Size = new System.Drawing.Size(119, 16);
            this.lblPriorityRequested.TabIndex = 14;
            this.lblPriorityRequested.Text = "Priority Requested";
            // 
            // cmbProjectObjective
            // 
            this.cmbProjectObjective.FormattingEnabled = true;
            this.cmbProjectObjective.Location = new System.Drawing.Point(111, 130);
            this.cmbProjectObjective.Name = "cmbProjectObjective";
            this.cmbProjectObjective.Size = new System.Drawing.Size(198, 24);
            this.cmbProjectObjective.TabIndex = 13;
            // 
            // lblObjective
            // 
            this.lblObjective.AutoSize = true;
            this.lblObjective.Location = new System.Drawing.Point(24, 136);
            this.lblObjective.Name = "lblObjective";
            this.lblObjective.Size = new System.Drawing.Size(65, 16);
            this.lblObjective.TabIndex = 12;
            this.lblObjective.Text = "Objective";
            // 
            // cmbPrice
            // 
            this.cmbPrice.FormattingEnabled = true;
            this.cmbPrice.Location = new System.Drawing.Point(441, 83);
            this.cmbPrice.Name = "cmbPrice";
            this.cmbPrice.Size = new System.Drawing.Size(127, 24);
            this.cmbPrice.TabIndex = 11;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(386, 86);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(39, 16);
            this.lblPrice.TabIndex = 10;
            this.lblPrice.Text = "Price";
            // 
            // lblDateInitiated
            // 
            this.lblDateInitiated.AutoSize = true;
            this.lblDateInitiated.Location = new System.Drawing.Point(19, 83);
            this.lblDateInitiated.Name = "lblDateInitiated";
            this.lblDateInitiated.Size = new System.Drawing.Size(86, 16);
            this.lblDateInitiated.TabIndex = 9;
            this.lblDateInitiated.Text = "Date Initiated";
            // 
            // dtpDateInitiated
            // 
            this.dtpDateInitiated.CustomFormat = "yyyy-MMM-dd HH:mm";
            this.dtpDateInitiated.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateInitiated.Location = new System.Drawing.Point(111, 81);
            this.dtpDateInitiated.Name = "dtpDateInitiated";
            this.dtpDateInitiated.Size = new System.Drawing.Size(193, 22);
            this.dtpDateInitiated.TabIndex = 8;
            // 
            // lblProjectNotes
            // 
            this.lblProjectNotes.AutoSize = true;
            this.lblProjectNotes.Location = new System.Drawing.Point(61, 188);
            this.lblProjectNotes.Name = "lblProjectNotes";
            this.lblProjectNotes.Size = new System.Drawing.Size(44, 16);
            this.lblProjectNotes.TabIndex = 7;
            this.lblProjectNotes.Text = "Notes";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(111, 182);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(468, 22);
            this.textBox1.TabIndex = 6;
            // 
            // cmbProjectType
            // 
            this.cmbProjectType.FormattingEnabled = true;
            this.cmbProjectType.Location = new System.Drawing.Point(111, 35);
            this.cmbProjectType.Name = "cmbProjectType";
            this.cmbProjectType.Size = new System.Drawing.Size(138, 24);
            this.cmbProjectType.TabIndex = 3;
            // 
            // cmbSite
            // 
            this.cmbSite.FormattingEnabled = true;
            this.cmbSite.Location = new System.Drawing.Point(665, 24);
            this.cmbSite.Name = "cmbSite";
            this.cmbSite.Size = new System.Drawing.Size(121, 21);
            this.cmbSite.TabIndex = 4;
            // 
            // gbxSample
            // 
            this.gbxSample.Controls.Add(this.btnSave);
            this.gbxSample.Controls.Add(this.lblDateSampleReceived);
            this.gbxSample.Controls.Add(this.lblDateSampleColleted);
            this.gbxSample.Controls.Add(this.dtpSampleReceived);
            this.gbxSample.Controls.Add(this.dateTimePicker1);
            this.gbxSample.Controls.Add(this.lblField);
            this.gbxSample.Controls.Add(this.cmbField);
            this.gbxSample.Controls.Add(this.lblDLS);
            this.gbxSample.Controls.Add(this.cmbDLS);
            this.gbxSample.Controls.Add(this.lblZone);
            this.gbxSample.Controls.Add(this.cmbZone);
            this.gbxSample.Controls.Add(this.lblSite);
            this.gbxSample.Controls.Add(this.cmbSite);
            this.gbxSample.Location = new System.Drawing.Point(660, 16);
            this.gbxSample.Name = "gbxSample";
            this.gbxSample.Size = new System.Drawing.Size(807, 161);
            this.gbxSample.TabIndex = 5;
            this.gbxSample.TabStop = false;
            this.gbxSample.Text = "Sample";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(598, 126);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(188, 29);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Save Order";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // lblDateSampleReceived
            // 
            this.lblDateSampleReceived.AutoSize = true;
            this.lblDateSampleReceived.Location = new System.Drawing.Point(430, 82);
            this.lblDateSampleReceived.Name = "lblDateSampleReceived";
            this.lblDateSampleReceived.Size = new System.Drawing.Size(117, 13);
            this.lblDateSampleReceived.TabIndex = 20;
            this.lblDateSampleReceived.Text = "Date Sample Received";
            // 
            // lblDateSampleColleted
            // 
            this.lblDateSampleColleted.AutoSize = true;
            this.lblDateSampleColleted.Location = new System.Drawing.Point(17, 83);
            this.lblDateSampleColleted.Name = "lblDateSampleColleted";
            this.lblDateSampleColleted.Size = new System.Drawing.Size(115, 13);
            this.lblDateSampleColleted.TabIndex = 19;
            this.lblDateSampleColleted.Text = "Date Sample Collected";
            // 
            // dtpSampleReceived
            // 
            this.dtpSampleReceived.CustomFormat = "yyyy-MMM-dd HH-mm";
            this.dtpSampleReceived.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSampleReceived.Location = new System.Drawing.Point(553, 76);
            this.dtpSampleReceived.Name = "dtpSampleReceived";
            this.dtpSampleReceived.Size = new System.Drawing.Size(213, 20);
            this.dtpSampleReceived.TabIndex = 13;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MMM-dd HH:mm";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(152, 77);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(165, 20);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // lblField
            // 
            this.lblField.AutoSize = true;
            this.lblField.Location = new System.Drawing.Point(17, 32);
            this.lblField.Name = "lblField";
            this.lblField.Size = new System.Drawing.Size(29, 13);
            this.lblField.TabIndex = 11;
            this.lblField.Text = "Field";
            // 
            // cmbField
            // 
            this.cmbField.FormattingEnabled = true;
            this.cmbField.Location = new System.Drawing.Point(58, 24);
            this.cmbField.Name = "cmbField";
            this.cmbField.Size = new System.Drawing.Size(121, 21);
            this.cmbField.TabIndex = 10;
            // 
            // lblDLS
            // 
            this.lblDLS.AutoSize = true;
            this.lblDLS.Location = new System.Drawing.Point(416, 30);
            this.lblDLS.Name = "lblDLS";
            this.lblDLS.Size = new System.Drawing.Size(28, 13);
            this.lblDLS.TabIndex = 9;
            this.lblDLS.Text = "DLS";
            // 
            // cmbDLS
            // 
            this.cmbDLS.FormattingEnabled = true;
            this.cmbDLS.Location = new System.Drawing.Point(469, 24);
            this.cmbDLS.Name = "cmbDLS";
            this.cmbDLS.Size = new System.Drawing.Size(120, 21);
            this.cmbDLS.TabIndex = 8;
            // 
            // lblZone
            // 
            this.lblZone.AutoSize = true;
            this.lblZone.Location = new System.Drawing.Point(216, 30);
            this.lblZone.Name = "lblZone";
            this.lblZone.Size = new System.Drawing.Size(32, 13);
            this.lblZone.TabIndex = 7;
            this.lblZone.Text = "Zone";
            // 
            // cmbZone
            // 
            this.cmbZone.FormattingEnabled = true;
            this.cmbZone.Location = new System.Drawing.Point(254, 24);
            this.cmbZone.Name = "cmbZone";
            this.cmbZone.Size = new System.Drawing.Size(120, 21);
            this.cmbZone.TabIndex = 6;
            // 
            // lblSite
            // 
            this.lblSite.AutoSize = true;
            this.lblSite.Location = new System.Drawing.Point(624, 32);
            this.lblSite.Name = "lblSite";
            this.lblSite.Size = new System.Drawing.Size(25, 13);
            this.lblSite.TabIndex = 5;
            this.lblSite.Text = "Site";
            // 
            // gbxTest
            // 
            this.gbxTest.Controls.Add(this.btnRunBatch);
            this.gbxTest.Controls.Add(this.dtpReportSent);
            this.gbxTest.Controls.Add(this.chkReported);
            this.gbxTest.Controls.Add(this.cmbPriorityAssigned);
            this.gbxTest.Controls.Add(this.lblPriorityAssigned);
            this.gbxTest.Location = new System.Drawing.Point(660, 197);
            this.gbxTest.Name = "gbxTest";
            this.gbxTest.Size = new System.Drawing.Size(807, 111);
            this.gbxTest.TabIndex = 6;
            this.gbxTest.TabStop = false;
            this.gbxTest.Text = "Test";
            // 
            // btnRunBatch
            // 
            this.btnRunBatch.Location = new System.Drawing.Point(598, 61);
            this.btnRunBatch.Name = "btnRunBatch";
            this.btnRunBatch.Size = new System.Drawing.Size(187, 32);
            this.btnRunBatch.TabIndex = 20;
            this.btnRunBatch.Text = "RunBatch";
            this.btnRunBatch.UseVisualStyleBackColor = true;
            // 
            // dtpReportSent
            // 
            this.dtpReportSent.CustomFormat = "yyyy-MMM-dd HH:mm";
            this.dtpReportSent.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpReportSent.Location = new System.Drawing.Point(415, 25);
            this.dtpReportSent.Name = "dtpReportSent";
            this.dtpReportSent.Size = new System.Drawing.Size(193, 20);
            this.dtpReportSent.TabIndex = 19;
            // 
            // chkReported
            // 
            this.chkReported.AutoSize = true;
            this.chkReported.Location = new System.Drawing.Point(293, 30);
            this.chkReported.Name = "chkReported";
            this.chkReported.Size = new System.Drawing.Size(92, 17);
            this.chkReported.TabIndex = 18;
            this.chkReported.Text = "Report Sent ?";
            this.chkReported.UseVisualStyleBackColor = true;
            // 
            // cmbPriorityAssigned
            // 
            this.cmbPriorityAssigned.FormattingEnabled = true;
            this.cmbPriorityAssigned.Location = new System.Drawing.Point(135, 28);
            this.cmbPriorityAssigned.Name = "cmbPriorityAssigned";
            this.cmbPriorityAssigned.Size = new System.Drawing.Size(121, 21);
            this.cmbPriorityAssigned.TabIndex = 17;
            // 
            // lblPriorityAssigned
            // 
            this.lblPriorityAssigned.AutoSize = true;
            this.lblPriorityAssigned.Location = new System.Drawing.Point(10, 28);
            this.lblPriorityAssigned.Name = "lblPriorityAssigned";
            this.lblPriorityAssigned.Size = new System.Drawing.Size(84, 13);
            this.lblPriorityAssigned.TabIndex = 16;
            this.lblPriorityAssigned.Text = "Priority Assigned";
            // 
            // dgvDisplay
            // 
            this.dgvDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisplay.Location = new System.Drawing.Point(660, 325);
            this.dgvDisplay.Name = "dgvDisplay";
            this.dgvDisplay.Size = new System.Drawing.Size(807, 221);
            this.dgvDisplay.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1479, 558);
            this.Controls.Add(this.dgvDisplay);
            this.Controls.Add(this.gbxTest);
            this.Controls.Add(this.gbxSample);
            this.Controls.Add(this.gbxProject);
            this.Controls.Add(this.gbxClient);
            this.Name = "Form1";
            this.Text = "Lab Input";
            this.gbxClient.ResumeLayout(false);
            this.gbxClient.PerformLayout();
            this.gbxBilling.ResumeLayout(false);
            this.gbxBilling.PerformLayout();
            this.gbxProject.ResumeLayout(false);
            this.gbxProject.PerformLayout();
            this.gbxSample.ResumeLayout(false);
            this.gbxSample.PerformLayout();
            this.gbxTest.ResumeLayout(false);
            this.gbxTest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxClient;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.ComboBox cmbClient;
        private System.Windows.Forms.Label lblAgent;
        private System.Windows.Forms.ComboBox cmbAgent;
        private System.Windows.Forms.CheckBox chkProject;
        private System.Windows.Forms.GroupBox gbxBilling;
        private System.Windows.Forms.TextBox txtBillingNotes;
        private System.Windows.Forms.Label lblBillingNotes;
        private System.Windows.Forms.ComboBox cmbBillTo;
        private System.Windows.Forms.GroupBox gbxProject;
        private System.Windows.Forms.Label lblProjectNotes;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cmbProjectType;
        private System.Windows.Forms.ComboBox cmbSite;
        private System.Windows.Forms.Label lblDateInitiated;
        private System.Windows.Forms.DateTimePicker dtpDateInitiated;
        private System.Windows.Forms.GroupBox gbxSample;
        private System.Windows.Forms.ComboBox cmbPriorityRequested;
        private System.Windows.Forms.Label lblPriorityRequested;
        private System.Windows.Forms.ComboBox cmbProjectObjective;
        private System.Windows.Forms.Label lblObjective;
        private System.Windows.Forms.ComboBox cmbPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblTest;
        private System.Windows.Forms.ComboBox cmbTest;
        private System.Windows.Forms.Label lblProjectType;
        private System.Windows.Forms.Label lblSite;
        private System.Windows.Forms.Label lblField;
        private System.Windows.Forms.ComboBox cmbField;
        private System.Windows.Forms.Label lblDLS;
        private System.Windows.Forms.ComboBox cmbDLS;
        private System.Windows.Forms.Label lblZone;
        private System.Windows.Forms.ComboBox cmbZone;
        private System.Windows.Forms.DateTimePicker dtpSampleReceived;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox gbxTest;
        private System.Windows.Forms.DateTimePicker dtpReportSent;
        private System.Windows.Forms.CheckBox chkReported;
        private System.Windows.Forms.ComboBox cmbPriorityAssigned;
        private System.Windows.Forms.Label lblPriorityAssigned;
        private System.Windows.Forms.Label lblDateSampleReceived;
        private System.Windows.Forms.Label lblDateSampleColleted;
        private System.Windows.Forms.DataGridView dgvDisplay;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRunBatch;
    }
}

