namespace BTReceiver
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
            this.rtbOutData = new System.Windows.Forms.RichTextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.devicesList = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbInternalBT = new System.Windows.Forms.ListBox();
            this.btnUpdateInternalBtAdapters = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnReadFromBt = new System.Windows.Forms.Button();
            this.btnWriteToBt = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.gbUpdateDeviceListOperationType = new System.Windows.Forms.GroupBox();
            this.rbUpdateFromMemory = new System.Windows.Forms.RadioButton();
            this.rbUpdateDefault = new System.Windows.Forms.RadioButton();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblBtOperationStatus = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.gbUpdateDeviceListOperationType.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbOutData
            // 
            this.rtbOutData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbOutData.Location = new System.Drawing.Point(140, 189);
            this.rtbOutData.Name = "rtbOutData";
            this.rtbOutData.Size = new System.Drawing.Size(723, 108);
            this.rtbOutData.TabIndex = 0;
            this.rtbOutData.Text = "";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(3, 107);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(128, 24);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // devicesList
            // 
            this.devicesList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.devicesList.FormattingEnabled = true;
            this.devicesList.Location = new System.Drawing.Point(3, 189);
            this.devicesList.Name = "devicesList";
            this.devicesList.Size = new System.Drawing.Size(131, 108);
            this.devicesList.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.92593F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.07407F));
            this.tableLayoutPanel1.Controls.Add(this.rtbOutData, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.devicesList, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbInternalBT, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnUpdateInternalBtAdapters, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(866, 395);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // lbInternalBT
            // 
            this.lbInternalBT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbInternalBT.FormattingEnabled = true;
            this.lbInternalBT.Location = new System.Drawing.Point(3, 340);
            this.lbInternalBT.Name = "lbInternalBT";
            this.lbInternalBT.Size = new System.Drawing.Size(131, 52);
            this.lbInternalBT.TabIndex = 4;
            // 
            // btnUpdateInternalBtAdapters
            // 
            this.btnUpdateInternalBtAdapters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUpdateInternalBtAdapters.Location = new System.Drawing.Point(3, 303);
            this.btnUpdateInternalBtAdapters.Name = "btnUpdateInternalBtAdapters";
            this.btnUpdateInternalBtAdapters.Size = new System.Drawing.Size(131, 31);
            this.btnUpdateInternalBtAdapters.TabIndex = 5;
            this.btnUpdateInternalBtAdapters.Text = "Update radiomodules";
            this.btnUpdateInternalBtAdapters.UseVisualStyleBackColor = true;
            this.btnUpdateInternalBtAdapters.Click += new System.EventHandler(this.btnUpdateBtAdapters_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnReadFromBt);
            this.flowLayoutPanel1.Controls.Add(this.btnWriteToBt);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(140, 303);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(723, 31);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // btnReadFromBt
            // 
            this.btnReadFromBt.Location = new System.Drawing.Point(3, 3);
            this.btnReadFromBt.Name = "btnReadFromBt";
            this.btnReadFromBt.Size = new System.Drawing.Size(107, 23);
            this.btnReadFromBt.TabIndex = 0;
            this.btnReadFromBt.Text = "Read from BT";
            this.btnReadFromBt.UseVisualStyleBackColor = true;
            this.btnReadFromBt.Click += new System.EventHandler(this.btnAskDevice_Click);
            // 
            // btnWriteToBt
            // 
            this.btnWriteToBt.Location = new System.Drawing.Point(116, 3);
            this.btnWriteToBt.Name = "btnWriteToBt";
            this.btnWriteToBt.Size = new System.Drawing.Size(75, 23);
            this.btnWriteToBt.TabIndex = 1;
            this.btnWriteToBt.Text = "Write to BT";
            this.btnWriteToBt.UseVisualStyleBackColor = true;
            this.btnWriteToBt.Click += new System.EventHandler(this.btnWriteToBt_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.gbUpdateDeviceListOperationType);
            this.flowLayoutPanel2.Controls.Add(this.btnUpdate);
            this.flowLayoutPanel2.Controls.Add(this.btnConnect);
            this.flowLayoutPanel2.Controls.Add(this.lblBtOperationStatus);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(131, 180);
            this.flowLayoutPanel2.TabIndex = 7;
            // 
            // gbUpdateDeviceListOperationType
            // 
            this.gbUpdateDeviceListOperationType.Controls.Add(this.rbUpdateFromMemory);
            this.gbUpdateDeviceListOperationType.Controls.Add(this.rbUpdateDefault);
            this.gbUpdateDeviceListOperationType.Location = new System.Drawing.Point(3, 3);
            this.gbUpdateDeviceListOperationType.Name = "gbUpdateDeviceListOperationType";
            this.gbUpdateDeviceListOperationType.Size = new System.Drawing.Size(128, 70);
            this.gbUpdateDeviceListOperationType.TabIndex = 5;
            this.gbUpdateDeviceListOperationType.TabStop = false;
            this.gbUpdateDeviceListOperationType.Text = "Тип пошуку";
            // 
            // rbUpdateFromMemory
            // 
            this.rbUpdateFromMemory.AutoSize = true;
            this.rbUpdateFromMemory.Checked = true;
            this.rbUpdateFromMemory.Location = new System.Drawing.Point(7, 44);
            this.rbUpdateFromMemory.Name = "rbUpdateFromMemory";
            this.rbUpdateFromMemory.Size = new System.Drawing.Size(95, 17);
            this.rbUpdateFromMemory.TabIndex = 1;
            this.rbUpdateFromMemory.TabStop = true;
            this.rbUpdateFromMemory.Text = "Запамятовані";
            this.rbUpdateFromMemory.UseVisualStyleBackColor = true;
            // 
            // rbUpdateDefault
            // 
            this.rbUpdateDefault.AutoSize = true;
            this.rbUpdateDefault.Location = new System.Drawing.Point(7, 20);
            this.rbUpdateDefault.Name = "rbUpdateDefault";
            this.rbUpdateDefault.Size = new System.Drawing.Size(79, 17);
            this.rbUpdateDefault.TabIndex = 0;
            this.rbUpdateDefault.Text = "Звичайний";
            this.rbUpdateDefault.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(3, 79);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(128, 22);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblBtOperationStatus
            // 
            this.lblBtOperationStatus.AutoSize = true;
            this.lblBtOperationStatus.Location = new System.Drawing.Point(3, 134);
            this.lblBtOperationStatus.Name = "lblBtOperationStatus";
            this.lblBtOperationStatus.Size = new System.Drawing.Size(0, 13);
            this.lblBtOperationStatus.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 395);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.gbUpdateDeviceListOperationType.ResumeLayout(false);
            this.gbUpdateDeviceListOperationType.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbOutData;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.ListBox devicesList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListBox lbInternalBT;
        private System.Windows.Forms.Button btnUpdateInternalBtAdapters;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnReadFromBt;
        private System.Windows.Forms.Button btnWriteToBt;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.GroupBox gbUpdateDeviceListOperationType;
        private System.Windows.Forms.RadioButton rbUpdateFromMemory;
        private System.Windows.Forms.RadioButton rbUpdateDefault;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblBtOperationStatus;
    }
}

