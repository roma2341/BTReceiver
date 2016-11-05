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
            this.btnConnect = new System.Windows.Forms.Button();
            this.devicesList = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbInternalBT = new System.Windows.Forms.ListBox();
            this.btnUpdateInternalBtAdapters = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.gbUpdateDeviceListOperationType = new System.Windows.Forms.GroupBox();
            this.rbUpdateFromMemory = new System.Windows.Forms.RadioButton();
            this.rbUpdateDefault = new System.Windows.Forms.RadioButton();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblBtOperationStatus = new System.Windows.Forms.Label();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnWriteToBt = new System.Windows.Forms.Button();
            this.btnReadFromBt = new System.Windows.Forms.Button();
            this.btnReadRawBytes = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbChannelsCount = new System.Windows.Forms.TextBox();
            this.tbByteDepth = new System.Windows.Forms.TextBox();
            this.tbSampleRate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbFileName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbRawBytesToReadCount = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.chRepresendDataAsString = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.rtbDataToSend = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.rtbReceivedData = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.gbUpdateDeviceListOperationType.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(3, 107);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(128, 24);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Підєднатись";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // devicesList
            // 
            this.devicesList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.devicesList.FormattingEnabled = true;
            this.devicesList.Location = new System.Drawing.Point(3, 299);
            this.devicesList.Name = "devicesList";
            this.devicesList.Size = new System.Drawing.Size(131, 84);
            this.devicesList.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.92593F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.07407F));
            this.tableLayoutPanel1.Controls.Add(this.devicesList, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbInternalBT, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnUpdateInternalBtAdapters, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.68394F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.31606F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(866, 482);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // lbInternalBT
            // 
            this.lbInternalBT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbInternalBT.FormattingEnabled = true;
            this.lbInternalBT.Location = new System.Drawing.Point(3, 426);
            this.lbInternalBT.Name = "lbInternalBT";
            this.lbInternalBT.Size = new System.Drawing.Size(131, 53);
            this.lbInternalBT.TabIndex = 4;
            // 
            // btnUpdateInternalBtAdapters
            // 
            this.btnUpdateInternalBtAdapters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUpdateInternalBtAdapters.Location = new System.Drawing.Point(3, 389);
            this.btnUpdateInternalBtAdapters.Name = "btnUpdateInternalBtAdapters";
            this.btnUpdateInternalBtAdapters.Size = new System.Drawing.Size(131, 31);
            this.btnUpdateInternalBtAdapters.TabIndex = 5;
            this.btnUpdateInternalBtAdapters.Text = "Оновити радіомодулі";
            this.btnUpdateInternalBtAdapters.UseVisualStyleBackColor = true;
            this.btnUpdateInternalBtAdapters.Click += new System.EventHandler(this.btnUpdateBtAdapters_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(140, 389);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(723, 31);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.gbUpdateDeviceListOperationType);
            this.flowLayoutPanel2.Controls.Add(this.btnUpdate);
            this.flowLayoutPanel2.Controls.Add(this.btnConnect);
            this.flowLayoutPanel2.Controls.Add(this.lblBtOperationStatus);
            this.flowLayoutPanel2.Controls.Add(this.btnDisconnect);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(131, 290);
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
            this.btnUpdate.Text = "Оновити";
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
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(3, 150);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(128, 23);
            this.btnDisconnect.TabIndex = 7;
            this.btnDisconnect.Text = "Відєднатись";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.btnWriteToBt);
            this.flowLayoutPanel3.Controls.Add(this.btnReadFromBt);
            this.flowLayoutPanel3.Controls.Add(this.btnReadRawBytes);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(140, 299);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(723, 84);
            this.flowLayoutPanel3.TabIndex = 8;
            // 
            // btnWriteToBt
            // 
            this.btnWriteToBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnWriteToBt.Location = new System.Drawing.Point(3, 3);
            this.btnWriteToBt.Name = "btnWriteToBt";
            this.btnWriteToBt.Size = new System.Drawing.Size(126, 35);
            this.btnWriteToBt.TabIndex = 1;
            this.btnWriteToBt.Text = "Відправити";
            this.btnWriteToBt.UseVisualStyleBackColor = true;
            this.btnWriteToBt.Click += new System.EventHandler(this.btnWriteToBt_Click);
            // 
            // btnReadFromBt
            // 
            this.btnReadFromBt.Location = new System.Drawing.Point(135, 3);
            this.btnReadFromBt.Name = "btnReadFromBt";
            this.btnReadFromBt.Size = new System.Drawing.Size(151, 23);
            this.btnReadFromBt.TabIndex = 0;
            this.btnReadFromBt.Text = "Зчитати звук";
            this.btnReadFromBt.UseVisualStyleBackColor = true;
            this.btnReadFromBt.Click += new System.EventHandler(this.btnAskDevice_Click);
            // 
            // btnReadRawBytes
            // 
            this.btnReadRawBytes.Location = new System.Drawing.Point(292, 3);
            this.btnReadRawBytes.Name = "btnReadRawBytes";
            this.btnReadRawBytes.Size = new System.Drawing.Size(134, 35);
            this.btnReadRawBytes.TabIndex = 2;
            this.btnReadRawBytes.Text = "Зчитати n байт у текстове поле";
            this.btnReadRawBytes.UseVisualStyleBackColor = true;
            this.btnReadRawBytes.Click += new System.EventHandler(this.btnReadRawBytes_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.17629F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.82371F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label6, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(140, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.206897F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.79311F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(723, 290);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Дані для відправки";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.tbChannelsCount, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.tbByteDepth, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.tbSampleRate, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.tbFileName, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.label7, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.tbRawBytesToReadCount, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.label9, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 1, 5);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(319, 20);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 7;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(334, 267);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Кількість каналів";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 13);
            this.label3.TabIndex = 1;
            this.label3.Tag = "";
            this.label3.Text = "Розрядність семпла(байт)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Частота дескритизації";
            // 
            // tbChannelsCount
            // 
            this.tbChannelsCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbChannelsCount.Location = new System.Drawing.Point(170, 3);
            this.tbChannelsCount.Name = "tbChannelsCount";
            this.tbChannelsCount.Size = new System.Drawing.Size(161, 20);
            this.tbChannelsCount.TabIndex = 3;
            this.tbChannelsCount.Text = "3";
            // 
            // tbByteDepth
            // 
            this.tbByteDepth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbByteDepth.Location = new System.Drawing.Point(170, 29);
            this.tbByteDepth.Name = "tbByteDepth";
            this.tbByteDepth.Size = new System.Drawing.Size(161, 20);
            this.tbByteDepth.TabIndex = 4;
            this.tbByteDepth.Text = "2";
            // 
            // tbSampleRate
            // 
            this.tbSampleRate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSampleRate.Location = new System.Drawing.Point(170, 55);
            this.tbSampleRate.Name = "tbSampleRate";
            this.tbSampleRate.Size = new System.Drawing.Size(161, 20);
            this.tbSampleRate.TabIndex = 5;
            this.tbSampleRate.Text = "8000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Імя файлу";
            // 
            // tbFileName
            // 
            this.tbFileName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbFileName.Location = new System.Drawing.Point(170, 81);
            this.tbFileName.Name = "tbFileName";
            this.tbFileName.Size = new System.Drawing.Size(161, 20);
            this.tbFileName.TabIndex = 7;
            this.tbFileName.Text = "test.wav";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 26);
            this.label7.TabIndex = 8;
            this.label7.Text = "Сирих байт для одного читання";
            // 
            // tbRawBytesToReadCount
            // 
            this.tbRawBytesToReadCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbRawBytesToReadCount.Location = new System.Drawing.Point(170, 107);
            this.tbRawBytesToReadCount.Name = "tbRawBytesToReadCount";
            this.tbRawBytesToReadCount.Size = new System.Drawing.Size(161, 20);
            this.tbRawBytesToReadCount.TabIndex = 9;
            this.tbRawBytesToReadCount.Text = "1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(159, 26);
            this.label9.TabIndex = 10;
            this.label9.Text = "Представляти отриманні дані у вигляді стрічки";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.20988F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.34568F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.44444F));
            this.tableLayoutPanel5.Controls.Add(this.chRepresendDataAsString, 1, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(170, 133);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(161, 22);
            this.tableLayoutPanel5.TabIndex = 11;
            // 
            // chRepresendDataAsString
            // 
            this.chRepresendDataAsString.AutoSize = true;
            this.chRepresendDataAsString.Location = new System.Drawing.Point(72, 3);
            this.chRepresendDataAsString.Name = "chRepresendDataAsString";
            this.chRepresendDataAsString.Size = new System.Drawing.Size(13, 14);
            this.chRepresendDataAsString.TabIndex = 12;
            this.chRepresendDataAsString.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chRepresendDataAsString.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(319, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(334, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Налаштування";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.rtbDataToSend, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label8, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.rtbReceivedData, 0, 2);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 20);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 199F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(310, 267);
            this.tableLayoutPanel4.TabIndex = 4;
            // 
            // rtbDataToSend
            // 
            this.rtbDataToSend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbDataToSend.Location = new System.Drawing.Point(3, 3);
            this.rtbDataToSend.Name = "rtbDataToSend";
            this.rtbDataToSend.Size = new System.Drawing.Size(304, 28);
            this.rtbDataToSend.TabIndex = 1;
            this.rtbDataToSend.Text = "53";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(3, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(304, 34);
            this.label8.TabIndex = 2;
            this.label8.Text = "Отримані дані";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rtbReceivedData
            // 
            this.rtbReceivedData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbReceivedData.Location = new System.Drawing.Point(3, 71);
            this.rtbReceivedData.Name = "rtbReceivedData";
            this.rtbReceivedData.Size = new System.Drawing.Size(304, 193);
            this.rtbReceivedData.TabIndex = 3;
            this.rtbReceivedData.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 482);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.gbUpdateDeviceListOperationType.ResumeLayout(false);
            this.gbUpdateDeviceListOperationType.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
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
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbChannelsCount;
        private System.Windows.Forms.TextBox tbByteDepth;
        private System.Windows.Forms.TextBox tbSampleRate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbFileName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnReadRawBytes;
        private System.Windows.Forms.TextBox tbRawBytesToReadCount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.CheckBox chRepresendDataAsString;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.RichTextBox rtbDataToSend;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox rtbReceivedData;
    }
}

