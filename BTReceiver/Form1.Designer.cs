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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.rtbOutData = new System.Windows.Forms.RichTextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.devicesList = new System.Windows.Forms.ListBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbInternalBT = new System.Windows.Forms.ListBox();
            this.btnUpdateInternalBtAdapters = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnReadFromBt = new System.Windows.Forms.Button();
            this.btnWriteToBt = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // rtbOutData
            // 
            this.rtbOutData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbOutData.Location = new System.Drawing.Point(140, 33);
            this.rtbOutData.Name = "rtbOutData";
            this.rtbOutData.Size = new System.Drawing.Size(723, 164);
            this.rtbOutData.TabIndex = 0;
            this.rtbOutData.Text = "";
            // 
            // btnConnect
            // 
            this.btnConnect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnConnect.Location = new System.Drawing.Point(140, 3);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(723, 24);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // devicesList
            // 
            this.devicesList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.devicesList.FormattingEnabled = true;
            this.devicesList.Location = new System.Drawing.Point(3, 33);
            this.devicesList.Name = "devicesList";
            this.devicesList.Size = new System.Drawing.Size(131, 164);
            this.devicesList.TabIndex = 2;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUpdate.Location = new System.Drawing.Point(3, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(131, 24);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.92593F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.07407F));
            this.tableLayoutPanel1.Controls.Add(this.btnUpdate, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.rtbOutData, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnConnect, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.devicesList, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbInternalBT, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnUpdateInternalBtAdapters, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.chart1, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.12605F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.87395F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 126F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(866, 395);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // lbInternalBT
            // 
            this.lbInternalBT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbInternalBT.FormattingEnabled = true;
            this.lbInternalBT.Location = new System.Drawing.Point(3, 271);
            this.lbInternalBT.Name = "lbInternalBT";
            this.lbInternalBT.Size = new System.Drawing.Size(131, 121);
            this.lbInternalBT.TabIndex = 4;
            // 
            // btnUpdateInternalBtAdapters
            // 
            this.btnUpdateInternalBtAdapters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUpdateInternalBtAdapters.Location = new System.Drawing.Point(3, 203);
            this.btnUpdateInternalBtAdapters.Name = "btnUpdateInternalBtAdapters";
            this.btnUpdateInternalBtAdapters.Size = new System.Drawing.Size(131, 62);
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
            this.flowLayoutPanel1.Location = new System.Drawing.Point(140, 203);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(723, 62);
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
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(140, 271);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(723, 121);
            this.chart1.TabIndex = 7;
            this.chart1.Text = "chart1";
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
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbOutData;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.ListBox devicesList;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListBox lbInternalBT;
        private System.Windows.Forms.Button btnUpdateInternalBtAdapters;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnReadFromBt;
        private System.Windows.Forms.Button btnWriteToBt;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

