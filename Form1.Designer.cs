
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
            this.textBoxFreq = new System.Windows.Forms.TextBox();
            this.labelFreq = new System.Windows.Forms.Label();
            this.groupBoxValue = new System.Windows.Forms.GroupBox();
            this.labelSpeedUnit = new System.Windows.Forms.Label();
            this.labelTempUnit = new System.Windows.Forms.Label();
            this.groupBoxAirFlow = new System.Windows.Forms.GroupBox();
            this.labelFlowError = new System.Windows.Forms.Label();
            this.labelm3h = new System.Windows.Forms.Label();
            this.textBoxFlow = new System.Windows.Forms.TextBox();
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
            this.buttonShowTerminal = new System.Windows.Forms.Button();
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
            buttonConnect.Location = new System.Drawing.Point(5, 18);
            buttonConnect.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            buttonConnect.Name = "buttonConnect";
            buttonConnect.Size = new System.Drawing.Size(90, 21);
            buttonConnect.TabIndex = 1;
            buttonConnect.TabStop = false;
            buttonConnect.Text = "Подключить";
            buttonConnect.UseVisualStyleBackColor = true;
            buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // comboBoxCOMPort
            // 
            this.comboBoxCOMPort.FormattingEnabled = true;
            this.comboBoxCOMPort.Location = new System.Drawing.Point(100, 18);
            this.comboBoxCOMPort.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxCOMPort.Name = "comboBoxCOMPort";
            this.comboBoxCOMPort.Size = new System.Drawing.Size(90, 21);
            this.comboBoxCOMPort.TabIndex = 0;
            this.comboBoxCOMPort.DropDown += new System.EventHandler(this.comboBoxCOMPort_DropDown);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel,
            this.toolStripStatusLabelStatus});
            this.statusStrip.Location = new System.Drawing.Point(0, 289);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(634, 26);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(148, 21);
            this.toolStripStatusLabel.Text = "Состояние подключения:";
            // 
            // toolStripStatusLabelStatus
            // 
            this.toolStripStatusLabelStatus.AutoSize = false;
            this.toolStripStatusLabelStatus.Name = "toolStripStatusLabelStatus";
            this.toolStripStatusLabelStatus.Size = new System.Drawing.Size(230, 21);
            this.toolStripStatusLabelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTemp
            // 
            this.labelTemp.AutoSize = true;
            this.labelTemp.Location = new System.Drawing.Point(6, 18);
            this.labelTemp.Name = "labelTemp";
            this.labelTemp.Size = new System.Drawing.Size(77, 13);
            this.labelTemp.TabIndex = 3;
            this.labelTemp.Text = "Температура:";
            // 
            // textBoxTemp
            // 
            this.textBoxTemp.Location = new System.Drawing.Point(86, 15);
            this.textBoxTemp.Name = "textBoxTemp";
            this.textBoxTemp.ReadOnly = true;
            this.textBoxTemp.Size = new System.Drawing.Size(54, 20);
            this.textBoxTemp.TabIndex = 4;
            this.textBoxTemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Location = new System.Drawing.Point(180, 18);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(96, 13);
            this.labelSpeed.TabIndex = 5;
            this.labelSpeed.Text = "Скорость потока:";
            // 
            // textBoxSpeed
            // 
            this.textBoxSpeed.Location = new System.Drawing.Point(278, 15);
            this.textBoxSpeed.Name = "textBoxSpeed";
            this.textBoxSpeed.ReadOnly = true;
            this.textBoxSpeed.Size = new System.Drawing.Size(54, 20);
            this.textBoxSpeed.TabIndex = 6;
            this.textBoxSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBoxConnect
            // 
            this.groupBoxConnect.Controls.Add(this.textBoxFreq);
            this.groupBoxConnect.Controls.Add(buttonConnect);
            this.groupBoxConnect.Controls.Add(this.comboBoxCOMPort);
            this.groupBoxConnect.Controls.Add(this.labelFreq);
            this.groupBoxConnect.Location = new System.Drawing.Point(12, 12);
            this.groupBoxConnect.Name = "groupBoxConnect";
            this.groupBoxConnect.Size = new System.Drawing.Size(380, 52);
            this.groupBoxConnect.TabIndex = 7;
            this.groupBoxConnect.TabStop = false;
            this.groupBoxConnect.Text = "Подключение к COM порту";
            // 
            // textBoxFreq
            // 
            this.textBoxFreq.Location = new System.Drawing.Point(308, 18);
            this.textBoxFreq.Name = "textBoxFreq";
            this.textBoxFreq.Size = new System.Drawing.Size(42, 20);
            this.textBoxFreq.TabIndex = 10;
            // 
            // labelFreq
            // 
            this.labelFreq.Location = new System.Drawing.Point(214, 12);
            this.labelFreq.Name = "labelFreq";
            this.labelFreq.Size = new System.Drawing.Size(90, 32);
            this.labelFreq.TabIndex = 9;
            this.labelFreq.Text = "Частота опроса прибора сек.:";
            // 
            // groupBoxValue
            // 
            this.groupBoxValue.Controls.Add(this.labelSpeedUnit);
            this.groupBoxValue.Controls.Add(this.labelTempUnit);
            this.groupBoxValue.Controls.Add(this.textBoxTemp);
            this.groupBoxValue.Controls.Add(this.labelTemp);
            this.groupBoxValue.Controls.Add(this.textBoxSpeed);
            this.groupBoxValue.Controls.Add(this.labelSpeed);
            this.groupBoxValue.Location = new System.Drawing.Point(12, 76);
            this.groupBoxValue.Name = "groupBoxValue";
            this.groupBoxValue.Size = new System.Drawing.Size(380, 46);
            this.groupBoxValue.TabIndex = 8;
            this.groupBoxValue.TabStop = false;
            this.groupBoxValue.Text = "Значения";
            // 
            // labelSpeedUnit
            // 
            this.labelSpeedUnit.AutoSize = true;
            this.labelSpeedUnit.Location = new System.Drawing.Point(334, 18);
            this.labelSpeedUnit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSpeedUnit.Name = "labelSpeedUnit";
            this.labelSpeedUnit.Size = new System.Drawing.Size(16, 13);
            this.labelSpeedUnit.TabIndex = 8;
            this.labelSpeedUnit.Text = "   ";
            // 
            // labelTempUnit
            // 
            this.labelTempUnit.AutoSize = true;
            this.labelTempUnit.Location = new System.Drawing.Point(142, 18);
            this.labelTempUnit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTempUnit.Name = "labelTempUnit";
            this.labelTempUnit.Size = new System.Drawing.Size(16, 13);
            this.labelTempUnit.TabIndex = 7;
            this.labelTempUnit.Text = "   ";
            // 
            // groupBoxAirFlow
            // 
            this.groupBoxAirFlow.Controls.Add(this.labelFlowError);
            this.groupBoxAirFlow.Controls.Add(this.labelm3h);
            this.groupBoxAirFlow.Controls.Add(this.textBoxFlow);
            this.groupBoxAirFlow.Controls.Add(this.labelFlow);
            this.groupBoxAirFlow.Controls.Add(this.groupBoxForm);
            this.groupBoxAirFlow.Location = new System.Drawing.Point(12, 135);
            this.groupBoxAirFlow.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxAirFlow.Name = "groupBoxAirFlow";
            this.groupBoxAirFlow.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxAirFlow.Size = new System.Drawing.Size(324, 146);
            this.groupBoxAirFlow.TabIndex = 11;
            this.groupBoxAirFlow.TabStop = false;
            this.groupBoxAirFlow.Text = "Объёмный расход воздуха";
            // 
            // labelFlowError
            // 
            this.labelFlowError.ForeColor = System.Drawing.Color.Red;
            this.labelFlowError.Location = new System.Drawing.Point(10, 93);
            this.labelFlowError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFlowError.Name = "labelFlowError";
            this.labelFlowError.Size = new System.Drawing.Size(304, 16);
            this.labelFlowError.TabIndex = 6;
            this.labelFlowError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelm3h
            // 
            this.labelm3h.AutoSize = true;
            this.labelm3h.Location = new System.Drawing.Point(214, 118);
            this.labelm3h.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelm3h.Name = "labelm3h";
            this.labelm3h.Size = new System.Drawing.Size(31, 13);
            this.labelm3h.TabIndex = 5;
            this.labelm3h.Text = "м3/ч";
            // 
            // textBoxFlow
            // 
            this.textBoxFlow.Location = new System.Drawing.Point(112, 115);
            this.textBoxFlow.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxFlow.Name = "textBoxFlow";
            this.textBoxFlow.ReadOnly = true;
            this.textBoxFlow.Size = new System.Drawing.Size(97, 20);
            this.textBoxFlow.TabIndex = 4;
            this.textBoxFlow.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelFlow
            // 
            this.labelFlow.AutoSize = true;
            this.labelFlow.Location = new System.Drawing.Point(10, 118);
            this.labelFlow.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFlow.Name = "labelFlow";
            this.labelFlow.Size = new System.Drawing.Size(103, 13);
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
            this.groupBoxForm.Location = new System.Drawing.Point(8, 17);
            this.groupBoxForm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxForm.Name = "groupBoxForm";
            this.groupBoxForm.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxForm.Size = new System.Drawing.Size(292, 73);
            this.groupBoxForm.TabIndex = 2;
            this.groupBoxForm.TabStop = false;
            this.groupBoxForm.Text = "Форма воздуховода";
            // 
            // labelRectmm
            // 
            this.labelRectmm.AutoSize = true;
            this.labelRectmm.Location = new System.Drawing.Point(259, 49);
            this.labelRectmm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRectmm.Name = "labelRectmm";
            this.labelRectmm.Size = new System.Drawing.Size(23, 13);
            this.labelRectmm.TabIndex = 7;
            this.labelRectmm.Text = "мм";
            this.labelRectmm.Visible = false;
            // 
            // labelCircRectmm
            // 
            this.labelCircRectmm.AutoSize = true;
            this.labelCircRectmm.Location = new System.Drawing.Point(259, 20);
            this.labelCircRectmm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCircRectmm.Name = "labelCircRectmm";
            this.labelCircRectmm.Size = new System.Drawing.Size(23, 13);
            this.labelCircRectmm.TabIndex = 6;
            this.labelCircRectmm.Text = "мм";
            // 
            // labelRect
            // 
            this.labelRect.AutoSize = true;
            this.labelRect.Location = new System.Drawing.Point(115, 49);
            this.labelRect.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRect.Name = "labelRect";
            this.labelRect.Size = new System.Drawing.Size(61, 13);
            this.labelRect.TabIndex = 5;
            this.labelRect.Text = "Сторона b:";
            this.labelRect.Visible = false;
            // 
            // labelCircRect
            // 
            this.labelCircRect.AutoSize = true;
            this.labelCircRect.Location = new System.Drawing.Point(115, 20);
            this.labelCircRect.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCircRect.Name = "labelCircRect";
            this.labelCircRect.Size = new System.Drawing.Size(56, 13);
            this.labelCircRect.TabIndex = 4;
            this.labelCircRect.Text = "Диаметр:";
            // 
            // textBoxRectmm
            // 
            this.textBoxRectmm.Location = new System.Drawing.Point(179, 45);
            this.textBoxRectmm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxRectmm.Name = "textBoxRectmm";
            this.textBoxRectmm.Size = new System.Drawing.Size(76, 20);
            this.textBoxRectmm.TabIndex = 3;
            this.textBoxRectmm.Visible = false;
            // 
            // textBoxCircRectmm
            // 
            this.textBoxCircRectmm.Location = new System.Drawing.Point(179, 16);
            this.textBoxCircRectmm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxCircRectmm.Name = "textBoxCircRectmm";
            this.textBoxCircRectmm.Size = new System.Drawing.Size(76, 20);
            this.textBoxCircRectmm.TabIndex = 2;
            // 
            // radioButtonCirc
            // 
            this.radioButtonCirc.AutoSize = true;
            this.radioButtonCirc.Checked = true;
            this.radioButtonCirc.Location = new System.Drawing.Point(4, 17);
            this.radioButtonCirc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButtonCirc.Name = "radioButtonCirc";
            this.radioButtonCirc.Size = new System.Drawing.Size(48, 17);
            this.radioButtonCirc.TabIndex = 0;
            this.radioButtonCirc.TabStop = true;
            this.radioButtonCirc.Text = "Круг";
            this.radioButtonCirc.UseVisualStyleBackColor = true;
            this.radioButtonCirc.CheckedChanged += new System.EventHandler(this.radioButtonCirc_CheckedChanged);
            // 
            // radioButtonRect
            // 
            this.radioButtonRect.AutoSize = true;
            this.radioButtonRect.Location = new System.Drawing.Point(4, 39);
            this.radioButtonRect.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButtonRect.Name = "radioButtonRect";
            this.radioButtonRect.Size = new System.Drawing.Size(67, 17);
            this.radioButtonRect.TabIndex = 1;
            this.radioButtonRect.Text = "Квадрат";
            this.radioButtonRect.UseVisualStyleBackColor = true;
            this.radioButtonRect.CheckedChanged += new System.EventHandler(this.radioButtonRect_CheckedChanged);
            // 
            // textBox
            // 
            this.textBox.AcceptsReturn = true;
            this.textBox.Location = new System.Drawing.Point(409, 8);
            this.textBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox.MaxLength = 0;
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ReadOnly = true;
            this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox.Size = new System.Drawing.Size(210, 274);
            this.textBox.TabIndex = 12;
            // 
            // buttonShowTerminal
            // 
            this.buttonShowTerminal.Location = new System.Drawing.Point(347, 140);
            this.buttonShowTerminal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonShowTerminal.Name = "buttonShowTerminal";
            this.buttonShowTerminal.Size = new System.Drawing.Size(45, 19);
            this.buttonShowTerminal.TabIndex = 13;
            this.buttonShowTerminal.Text = ">>>";
            this.buttonShowTerminal.UseVisualStyleBackColor = true;
            this.buttonShowTerminal.Click += new System.EventHandler(this.buttonShowTerminal_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 315);
            this.Controls.Add(this.buttonShowTerminal);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.groupBoxAirFlow);
            this.Controls.Add(this.groupBoxValue);
            this.Controls.Add(this.groupBoxConnect);
            this.Controls.Add(this.statusStrip);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
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
        private System.Windows.Forms.TextBox textBoxFlow;
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
        private System.Windows.Forms.Button buttonShowTerminal;
        private System.Windows.Forms.Label labelSpeedUnit;
        private System.Windows.Forms.Label labelTempUnit;
        private System.Windows.Forms.Label labelFlowError;
    }
}

