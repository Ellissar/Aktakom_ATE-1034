using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using System.Text.RegularExpressions;

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
            string[] ports = SerialPort.GetPortNames();
            comboBoxCOMPort.Items.AddRange(ports);
            if (ports.Length > 0)
            {
                comboBoxCOMPort.SelectedIndex = 0;
            }
        }

        private void comboBoxCOMPort_DropDown(object sender, EventArgs e)
        {
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
            SerialPort sp = (SerialPort)sender;
            string value1, units1, raw1, screenNumber1;
            string value2, units2, raw2, screenNumber2;
            raw1 = sp.ReadLine();
            StringParse (raw1, out value1, out units1, out screenNumber1);
            raw2 = sp.ReadLine();
            StringParse (raw2, out value2, out units2, out screenNumber2);



            textBox.Invoke(new Action<string>((s) => textBox.Text += s + Environment.NewLine), raw1 + "  |  " + value1 + " " + units1);
            textBox.Invoke(new Action<string>((s) => textBox.Text += s + Environment.NewLine), raw2 + "  |  " + value2 + " " + units2);

            sp.DiscardInBuffer();
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
        private void StringParse (string str, out string value, out string units, out string screenNumber)
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

            //получено значение верхнего(1) или нижнего(2) числа на дисплее
            switch (str[2])
            {
                case '1'://скорость воздуха
                    screenNumber = "1";
                    break;

                case '2'://температура воздуха
                    screenNumber = "2";
                    break;

                default:
                    screenNumber = "Ошибка в полученных данных";
                    break;
            }

            //единицы измерения
            switch (str.Substring(3,2))
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
        private string DelZero (string str)
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
        private void writeResult()
        {

        }
    }
}
