
namespace Aktakom_ATE_1034
{
    partial class FormMain
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
            System.Windows.Forms.Button buttonConnect;
            this.comboBoxCOMPort = new System.Windows.Forms.ComboBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelTemp = new System.Windows.Forms.Label();
            this.textBoxTemp = new System.Windows.Forms.TextBox();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.textBoxSpeed = new System.Windows.Forms.TextBox();
            this.groupBoxConnect = new System.Windows.Forms.GroupBox();
            this.groupBoxValue = new System.Windows.Forms.GroupBox();
            this.labelFreq = new System.Windows.Forms.Label();
            this.textBoxFreq = new System.Windows.Forms.TextBox();
            this.groupBoxAirFlow = new System.Windows.Forms.GroupBox();
            this.labelm3h = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelFlow = new System.Windows.Forms.Label();
            this.groupBoxForm = new System.Windows.Forms.GroupBox();
            this.labelRectmm = new System.Windows.Forms.Label();
            this.labelCircRectmm = new System.Windows.Forms.Label();
            this.labelRect = new System.Windows.Forms.Label();
            this.labelCircRect = new System.Windows.Forms.Label();
            this.textBoxRectmm = new System.Windows.Forms.TextBox();
            this.textBoxCircRectmm = new System.Windows.Forms.TextBox();
            this.radioButtonCirc = new System.Windows.Forms.RadioButton();
            this.radioButtonRect = new System.Windows.Forms.RadioButton();
            this.textBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            buttonConnect = new System.Windows.Forms.Button();
            this.statusStrip.SuspendLayout();
            this.groupBoxConnect.SuspendLayout();
            this.groupBoxValue.SuspendLayout();
            this.groupBoxAirFlow.SuspendLayout();
            this.groupBoxForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonConnect
            // 
            buttonConnect.AllowDrop = true;
            buttonConnect.Location = new System.Drawing.Point(7, 22);
            buttonConnect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            buttonConnect.Name = "buttonConnect";
            buttonConnect.Size = new System.Drawing.Size(120, 26);
            buttonConnect.TabIndex = 1;
            buttonConnect.TabStop = false;
            buttonConnect.Text = "Подключить";
            buttonConnect.UseVisualStyleBackColor = true;
            buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // comboBoxCOMPort
            // 
            this.comboBoxCOMPort.FormattingEnabled = true;
            this.comboBoxCOMPort.Location = new System.Drawing.Point(133, 22);
            this.comboBoxCOMPort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxCOMPort.Name = "comboBoxCOMPort";
            this.comboBoxCOMPort.Size = new System.Drawing.Size(119, 24);
            this.comboBoxCOMPort.TabIndex = 0;
            this.comboBoxCOMPort.DropDown += new System.EventHandler(this.comboBoxCOMPort_DropDown);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel,
            this.toolStripStatusLabelStatus});
            this.statusStrip.Location = new System.Drawing.Point(0, 347);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip.Size = new System.Drawing.Size(897, 26);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(185, 20);
            this.toolStripStatusLabel.Text = "Состояние подключения:";
            // 
            // toolStripStatusLabelStatus
            // 
            this.toolStripStatusLabelStatus.AutoSize = false;
            this.toolStripStatusLabelStatus.Name = "toolStripStatusLabelStatus";
            this.toolStripStatusLabelStatus.Size = new System.Drawing.Size(230, 20);
            this.toolStripStatusLabelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTemp
            // 
            this.labelTemp.Location = new System.Drawing.Point(7, 22);
            this.labelTemp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTemp.Name = "labelTemp";
            this.labelTemp.Size = new System.Drawing.Size(103, 25);
            this.labelTemp.TabIndex = 3;
            this.labelTemp.Text = "Температура:";
            // 
            // textBoxTemp
            // 
            this.textBoxTemp.Location = new System.Drawing.Point(115, 19);
            this.textBoxTemp.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTemp.Name = "textBoxTemp";
            this.textBoxTemp.ReadOnly = true;
            this.textBoxTemp.Size = new System.Drawing.Size(80, 22);
            this.textBoxTemp.TabIndex = 4;
            // 
            // labelSpeed
            // 
            this.labelSpeed.Location = new System.Drawing.Point(250, 22);
            this.labelSpeed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(129, 25);
            this.labelSpeed.TabIndex = 5;
            this.labelSpeed.Text = "Скорость потока:";
            // 
            // textBoxSpeed
            // 
            this.textBoxSpeed.Location = new System.Drawing.Point(382, 19);
            this.textBoxSpeed.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSpeed.Name = "textBoxSpeed";
            this.textBoxSpeed.ReadOnly = true;
            this.textBoxSpeed.Size = new System.Drawing.Size(80, 22);
            this.textBoxSpeed.TabIndex = 6;
            // 
            // groupBoxConnect
            // 
            this.groupBoxConnect.Controls.Add(this.textBoxFreq);
            this.groupBoxConnect.Controls.Add(buttonConnect);
            this.groupBoxConnect.Controls.Add(this.comboBoxCOMPort);
            this.groupBoxConnect.Controls.Add(this.labelFreq);
            this.groupBoxConnect.Location = new System.Drawing.Point(16, 15);
            this.groupBoxConnect.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxConnect.Name = "groupBoxConnect";
            this.groupBoxConnect.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxConnect.Size = new System.Drawing.Size(507, 64);
            this.groupBoxConnect.TabIndex = 7;
            this.groupBoxConnect.TabStop = false;
            this.groupBoxConnect.Text = "Подключение к COM порту";
            // 
            // groupBoxValue
            // 
            this.groupBoxValue.Controls.Add(this.textBoxTemp);
            this.groupBoxValue.Controls.Add(this.labelTemp);
            this.groupBoxValue.Controls.Add(this.textBoxSpeed);
            this.groupBoxValue.Controls.Add(this.labelSpeed);
            this.groupBoxValue.Location = new System.Drawing.Point(16, 94);
            this.groupBoxValue.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxValue.Name = "groupBoxValue";
            this.groupBoxValue.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxValue.Size = new System.Drawing.Size(507, 57);
            this.groupBoxValue.TabIndex = 8;
            this.groupBoxValue.TabStop = false;
            this.groupBoxValue.Text = "Значения";
            // 
            // labelFreq
            // 
            this.labelFreq.Location = new System.Drawing.Point(285, 15);
            this.labelFreq.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFreq.Name = "labelFreq";
            this.labelFreq.Size = new System.Drawing.Size(120, 40);
            this.labelFreq.TabIndex = 9;
            this.labelFreq.Text = "Частота опроса прибора сек.:";
            // 
            // textBoxFreq
            // 
            this.textBoxFreq.Location = new System.Drawing.Point(410, 22);
            this.textBoxFreq.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFreq.Name = "textBoxFreq";
            this.textBoxFreq.Size = new System.Drawing.Size(55, 22);
            this.textBoxFreq.TabIndex = 10;
            // 
            // groupBoxAirFlow
            // 
            this.groupBoxAirFlow.Controls.Add(this.labelm3h);
            this.groupBoxAirFlow.Controls.Add(this.textBox1);
            this.groupBoxAirFlow.Controls.Add(this.labelFlow);
            this.groupBoxAirFlow.Controls.Add(this.groupBoxForm);
            this.groupBoxAirFlow.Location = new System.Drawing.Point(16, 166);
            this.groupBoxAirFlow.Name = "groupBoxAirFlow";
            this.groupBoxAirFlow.Size = new System.Drawing.Size(412, 168);
            this.groupBoxAirFlow.TabIndex = 11;
            this.groupBoxAirFlow.TabStop = false;
            this.groupBoxAirFlow.Text = "Объёмный расход воздуха";
            // 
            // labelm3h
            // 
            this.labelm3h.AutoSize = true;
            this.labelm3h.Location = new System.Drawing.Point(285, 132);
            this.labelm3h.Name = "labelm3h";
            this.labelm3h.Size = new System.Drawing.Size(37, 17);
            this.labelm3h.TabIndex = 5;
            this.labelm3h.Text = "м3/ч";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(150, 129);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(128, 22);
            this.textBox1.TabIndex = 4;
            // 
            // labelFlow
            // 
            this.labelFlow.AutoSize = true;
            this.labelFlow.Location = new System.Drawing.Point(13, 132);
            this.labelFlow.Name = "labelFlow";
            this.labelFlow.Size = new System.Drawing.Size(132, 17);
            this.labelFlow.TabIndex = 3;
            this.labelFlow.Text = "Объёмный расход:";
            // 
            // groupBoxForm
            // 
            this.groupBoxForm.Controls.Add(this.labelRectmm);
            this.groupBoxForm.Controls.Add(this.labelCircRectmm);
            this.groupBoxForm.Controls.Add(this.labelRect);
            this.groupBoxForm.Controls.Add(this.labelCircRect);
            this.groupBoxForm.Controls.Add(this.textBoxRectmm);
            this.groupBoxForm.Controls.Add(this.textBoxCircRectmm);
            this.groupBoxForm.Controls.Add(this.radioButtonCirc);
            this.groupBoxForm.Controls.Add(this.radioButtonRect);
            this.groupBoxForm.Location = new System.Drawing.Point(10, 21);
            this.groupBoxForm.Name = "groupBoxForm";
            this.groupBoxForm.Size = new System.Drawing.Size(390, 95);
            this.groupBoxForm.TabIndex = 2;
            this.groupBoxForm.TabStop = false;
            this.groupBoxForm.Text = "Форма воздуховода";
            // 
            // labelRectmm
            // 
            this.labelRectmm.AutoSize = true;
            this.labelRectmm.Location = new System.Drawing.Point(345, 60);
            this.labelRectmm.Name = "labelRectmm";
            this.labelRectmm.Size = new System.Drawing.Size(26, 17);
            this.labelRectmm.TabIndex = 7;
            this.labelRectmm.Text = "мм";
            this.labelRectmm.Visible = false;
            // 
            // labelCircRectmm
            // 
            this.labelCircRectmm.AutoSize = true;
            this.labelCircRectmm.Location = new System.Drawing.Point(345, 25);
            this.labelCircRectmm.Name = "labelCircRectmm";
            this.labelCircRectmm.Size = new System.Drawing.Size(26, 17);
            this.labelCircRectmm.TabIndex = 6;
            this.labelCircRectmm.Text = "мм";
            // 
            // labelRect
            // 
            this.labelRect.AutoSize = true;
            this.labelRect.Location = new System.Drawing.Point(153, 60);
            this.labelRect.Name = "labelRect";
            this.labelRect.Size = new System.Drawing.Size(80, 17);
            this.labelRect.TabIndex = 5;
            this.labelRect.Text = "Сторона b:";
            this.labelRect.Visible = false;
            // 
            // labelCircRect
            // 
            this.labelCircRect.AutoSize = true;
            this.labelCircRect.Location = new System.Drawing.Point(153, 25);
            this.labelCircRect.Name = "labelCircRect";
            this.labelCircRect.Size = new System.Drawing.Size(71, 17);
            this.labelCircRect.TabIndex = 4;
            this.labelCircRect.Text = "Диаметр:";
            // 
            // textBoxRectmm
            // 
            this.textBoxRectmm.Location = new System.Drawing.Point(239, 55);
            this.textBoxRectmm.Name = "textBoxRectmm";
            this.textBoxRectmm.Size = new System.Drawing.Size(100, 22);
            this.textBoxRectmm.TabIndex = 3;
            this.textBoxRectmm.Visible = false;
            // 
            // textBoxCircRectmm
            // 
            this.textBoxCircRectmm.Location = new System.Drawing.Point(239, 20);
            this.textBoxCircRectmm.Name = "textBoxCircRectmm";
            this.textBoxCircRectmm.Size = new System.Drawing.Size(100, 22);
            this.textBoxCircRectmm.TabIndex = 2;
            // 
            // radioButtonCirc
            // 
            this.radioButtonCirc.AutoSize = true;
            this.radioButtonCirc.Checked = true;
            this.radioButtonCirc.Location = new System.Drawing.Point(6, 21);
            this.radioButtonCirc.Name = "radioButtonCirc";
            this.radioButtonCirc.Size = new System.Drawing.Size(58, 21);
            this.radioButtonCirc.TabIndex = 0;
            this.radioButtonCirc.TabStop = true;
            this.radioButtonCirc.Text = "Круг";
            this.radioButtonCirc.UseVisualStyleBackColor = true;
            this.radioButtonCirc.CheckedChanged += new System.EventHandler(this.radioButtonCirc_CheckedChanged);
            // 
            // radioButtonRect
            // 
            this.radioButtonRect.AutoSize = true;
            this.radioButtonRect.Location = new System.Drawing.Point(6, 48);
            this.radioButtonRect.Name = "radioButtonRect";
            this.radioButtonRect.Size = new System.Drawing.Size(84, 21);
            this.radioButtonRect.TabIndex = 1;
            this.radioButtonRect.Text = "Квадрат";
            this.radioButtonRect.UseVisualStyleBackColor = true;
            this.radioButtonRect.CheckedChanged += new System.EventHandler(this.radioButtonRect_CheckedChanged);
            // 
            // textBox
            // 
            this.textBox.AcceptsReturn = true;
            this.textBox.Location = new System.Drawing.Point(545, 10);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox.Size = new System.Drawing.Size(334, 324);
            this.textBox.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(443, 172);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = ">>>";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 373);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.groupBoxAirFlow);
            this.Controls.Add(this.groupBoxValue);
            this.Controls.Add(this.groupBoxConnect);
            this.Controls.Add(this.statusStrip);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(915, 420);
            this.MinimumSize = new System.Drawing.Size(915, 420);
            this.Name = "FormMain";
            this.Text = "Термоанемометр Актаком ATE-1034";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Shown += new System.EventHandler(this.FormMain_Shown);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.groupBoxConnect.ResumeLayout(false);
            this.groupBoxConnect.PerformLayout();
            this.groupBoxValue.ResumeLayout(false);
            this.groupBoxValue.PerformLayout();
            this.groupBoxAirFlow.ResumeLayout(false);
            this.groupBoxAirFlow.PerformLayout();
            this.groupBoxForm.ResumeLayout(false);
            this.groupBoxForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCOMPort;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.Label labelTemp;
        private System.Windows.Forms.TextBox textBoxTemp;
        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.TextBox textBoxSpeed;
        private System.Windows.Forms.GroupBox groupBoxConnect;
        private System.Windows.Forms.GroupBox groupBoxValue;
        private System.Windows.Forms.Label labelFreq;
        private System.Windows.Forms.TextBox textBoxFreq;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelStatus;
        private System.Windows.Forms.GroupBox groupBoxAirFlow;
        private System.Windows.Forms.RadioButton radioButtonRect;
        private System.Windows.Forms.RadioButton radioButtonCirc;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelFlow;
        private System.Windows.Forms.GroupBox groupBoxForm;
        private System.Windows.Forms.Label labelRectmm;
        private System.Windows.Forms.Label labelCircRectmm;
        private System.Windows.Forms.Label labelRect;
        private System.Windows.Forms.Label labelCircRect;
        private System.Windows.Forms.TextBox textBoxRectmm;
        private System.Windows.Forms.TextBox textBoxCircRectmm;
        private System.Windows.Forms.Label labelm3h;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button button1;
    }
}

