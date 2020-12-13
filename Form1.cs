using System;
using System.Drawing;
using System.IO.Ports;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Aktakom_ATE_1034
{
    public partial class FormMain : Form
    {
        SerialPort serialPort = new SerialPort();

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Shown(object sender, EventArgs e)
        {
            //заполнение списка существующих компортов
            string[] ports = SerialPort.GetPortNames();
            comboBoxCOMPort.Items.AddRange(ports);
            if (ports.Length > 0)
            {
                comboBoxCOMPort.SelectedIndex = 0;
            }

            //скрыть терминал
            Size size = new Size(420, 354);
            this.MinimumSize = size;
            this.MaximumSize = size;
            this.Size = size;
            buttonShowTerminal.Text = ">>>";
        }

        private void comboBoxCOMPort_DropDown(object sender, EventArgs e)
        {
            //обновление списка существующих компортов
            string[] ports = SerialPort.GetPortNames();
            comboBoxCOMPort.Items.Clear();
            comboBoxCOMPort.Items.AddRange(ports);
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            Button buttonText = (Button)sender;
            if (buttonText.Text == "Подключить")
            {
                try
                {
                    serialPort.PortName = comboBoxCOMPort.SelectedItem.ToString();
                    serialPort.BaudRate = 9600;
                    serialPort.Parity = Parity.None;
                    serialPort.DataBits = 8;
                    serialPort.StopBits = StopBits.One;
                    serialPort.Handshake = Handshake.None;

                    serialPort.ReadTimeout = 1000;
                    serialPort.WriteTimeout = 1000;
                    serialPort.NewLine = "\r";

                    serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);

                    serialPort.Open();

                    toolStripStatusLabelStatus.ForeColor = SystemColors.ControlText;
                    toolStripStatusLabelStatus.Text = comboBoxCOMPort.SelectedItem.ToString() + " открыт";
                }
                catch (Exception)
                {
                    toolStripStatusLabelStatus.ForeColor = Color.Red;
                    toolStripStatusLabelStatus.Text = "Ошибка подключения к COM порту";
                    return;
                }

                buttonText.Text = "Отключить";
            }
            else
            {
                serialPort.Close();
                buttonText.Text = "Подключить";
            }
        }

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                SerialPort sp = (SerialPort)sender;
                string value, units, raw;

                raw = sp.ReadLine();
                StringParse(raw, out value, out units);
                SendToForm(raw, value, units);

                raw = sp.ReadLine();
                StringParse(raw, out value, out units);
                SendToForm(raw, value, units);

                FlowCalc();

                sp.DiscardInBuffer();
            }
            catch (Exception)
            {
                return;
            }
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            serialPort.Close();
        }

        private void radioButtonCirc_CheckedChanged(object sender, EventArgs e)
        {
            labelCircRect.Text = "Диаметр:";
            labelRect.Visible = false;
            textBoxRectmm.Visible = false;
            labelRectmm.Visible = false;
        }

        private void radioButtonRect_CheckedChanged(object sender, EventArgs e)
        {
            labelCircRect.Text = "Сторона a:";
            labelRect.Visible = true;
            textBoxRectmm.Visible = true;
            labelRectmm.Visible = true;
        }

        //разбор полученной строки
        private void StringParse(string str, out string value, out string units)
        {
            value = str.Substring(7, 8);

            //расположение десятичной точки (справа на лево)
            switch (str[6])
            {
                case '0': //точка не ставится
                    break;

                case '1':
                    value = value.Insert(7, ",");
                    break;

                case '2':
                    value = value.Insert(6, ",");
                    break;

                case '3':
                    value = value.Insert(5, ",");
                    break;

                default:
                    value = "Ошибка в полученных данных";
                    break;
            }

            //удалить лишние нули слева
            value = DelZero(value);

            //если отрицательное число
            if (str[5] == '1')
            {
                value = "-" + value;
            }

            //единицы измерения
            switch (str.Substring(3, 2))
            {
                case "01":
                    units = "°C";
                    break;

                case "02":
                    units = "°F";
                    break;

                case "08":
                    units = "m/s";
                    break;

                case "09":
                    units = "Knot";
                    break;

                case "10":
                    units = "Km/h";
                    break;

                case "11":
                    units = "ft/min";
                    break;

                case "12":
                    units = "mile/h";
                    break;

                default:
                    units = "Ошибка в полученных данных";
                    break;
            }
        }

        //удалить лишние нули слева
        private string DelZero(string str)
        {
            //удаляет лишние нули слева от числа
            //если слева от точки стоит ноль (например 0.ххх) то получится строка .ххх
            MatchCollection matches = Regex.Matches(str, @"([1-9]*\,\d*)");
            foreach (Match match in matches)
                str = match.Value;

            //если слева от десятичной точки не хватает нуля (т.е. что-то типа .хх) то добавляем его
            if (str[0] == ',')
                str = "0" + str;

            return str;
        }

        //отображение параметра в элементы формы
        private void SendToForm(string raw, string val, string units)
        {
            textBox.Invoke(new Action<string>((s) => textBox.Text += s + Environment.NewLine), raw + "  |  " + val + " " + units);
            //получено значение верхнего(1) или нижнего(2) числа на дисплее
            switch (raw[2])
            {
                case '1'://скорость воздуха
                    textBoxSpeed.Invoke(new Action<string>((s) => textBoxSpeed.Text = s), val);
                    labelSpeedUnit.Invoke(new Action<string>((s) => labelSpeedUnit.Text = s), units);
                    break;

                case '2'://температура воздуха
                    textBoxTemp.Invoke(new Action<string>((s) => textBoxTemp.Text = s), val);
                    labelTempUnit.Invoke(new Action<string>((s) => labelTempUnit.Text = s), units);
                    break;

                default:
                    toolStripStatusLabelStatus.ForeColor = Color.Red;
                    toolStripStatusLabelStatus.Text = "Ошибка в полученных данных";
                    break;
            }
        }

        //вычисление объёмного расхода
        private void FlowCalc()
        {
            //L = 3600 * F * V, где F - площадь сечения воздуховода в м^2, V - скорость воздуха в воздуховоде м/с
            double L = 3600 * SCalc() * Convert.ToDouble(textBoxSpeed.Text);
            textBoxFlow.Invoke(new Action<string>((s) => textBoxFlow.Text = s), L.ToString("N2"));
        }

        //расчёт площади сечения воздуховода
        private double SCalc()
        {
            double result = 0;
            try
            {
                if (radioButtonCirc.Checked)
                {
                    //S = 1/4*Pi*d^2
                    result = Math.PI * (Math.Pow((Convert.ToDouble(textBoxCircRectmm.Text) / 1000), 2) / 4);
                }
                else
                {
                    //S = (a/1000) * (b/1000)
                    result = (Convert.ToDouble(textBoxCircRectmm.Text) / 1000) * (Convert.ToDouble(textBoxRectmm.Text) / 1000);
                }

            }
            catch (Exception)
            {
                labelFlowError.Invoke(new Action<string>((s) => labelFlowError.Text = s), "Введите размеры круглого или квадратного воздуховода");
                return result = 0;
            }

            labelFlowError.Invoke(new Action<string>((s) => labelFlowError.Text = s), "");
            return result;
        }

        //скрыть\показать терминал
        private void buttonShowTerminal_Click(object sender, EventArgs e)
        {
            if (buttonShowTerminal.Text == ">>>")
            {
                Size size = new Size(650, 354);
                this.MinimumSize = size;
                this.MaximumSize = size;
                this.Size = size;
                buttonShowTerminal.Text = "<<<";
            }
            else
            if (buttonShowTerminal.Text == "<<<")
            {
                Size size = new Size(420, 354);
                this.MinimumSize = size;
                this.MaximumSize = size;
                this.Size = size;
                buttonShowTerminal.Text = ">>>";
            }
        }
    }
}
