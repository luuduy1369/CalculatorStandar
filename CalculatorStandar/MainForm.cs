using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorStandar
{
    public partial class MainForm : Form
    {
        delegate double Calculation(double a, double b);
        private List<Calculation> _listCal = new List<Calculation>();

        private string _temp = "0";
        private bool _backSpace = false;
        private bool _put0 = false;
        private double _value = 0;
        private double _inputA = 0;
        private double _inputB = 0;
        private string _str = "";
        private bool _cal = false;
        private int _preMath = -1;
        private bool _putDot = false;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _listCal.Add(MathOperation.Cong);
            _listCal.Add(MathOperation.Tru);
            _listCal.Add(MathOperation.Nhan);
            _listCal.Add(MathOperation.Chia);
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (_cal)
            {
                _temp = "0";
                _cal = false;
                _put0 = false;
            }

            if (_put0)
            {
                _temp += "0";
                _backSpace = true;
            }

            lblResult.Text = _temp;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (_cal)
            {
                _temp = "0";
                _cal = false;
            }

            if (_temp == "0")
            {
                _temp = "1";
            }
            else
            {
                _temp += "1";
            }

            _put0 = true;
            _backSpace = true;

            lblResult.Text = _temp;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (_cal)
            {
                _temp = "0";
                _cal = false;
            }
            if (_temp == "0")
            {
                _temp = "2";
            }
            else
            {
                _temp += "2";
            }

            _put0 = true;
            _backSpace = true;

            lblResult.Text = _temp;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (_cal)
            {
                _temp = "0";
                _cal = false;
            }
            if (_temp == "0")
            {
                _temp = "3";
            }
            else
            {
                _temp += "3";
            }

            _put0 = true;
            _backSpace = true;

            lblResult.Text = _temp;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (_cal)
            {
                _temp = "0";
                _cal = false;
            }
            if (_temp == "0")
            {
                _temp = "4";
            }
            else
            {
                _temp += "4";
            }

            _put0 = true;
            _backSpace = true;

            lblResult.Text = _temp;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (_cal)
            {
                _temp = "0";
                _cal = false;
            }
            if (_temp == "0")
            {
                _temp = "5";
            }
            else
            {
                _temp += "5";
            }

            _put0 = true;
            _backSpace = true;

            lblResult.Text = _temp;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (_cal)
            {
                _temp = "0";
                _cal = false;
            }
            if (_temp == "0")
            {
                _temp = "6";
            }
            else
            {
                _temp += "6";
            }

            _put0 = true;
            _backSpace = true;

            lblResult.Text = _temp;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (_cal)
            {
                _temp = "0";
                _cal = false;
            }
            if (_temp == "0")
            {
                _temp = "7";
            }
            else
            {
                _temp += "7";
            }

            _put0 = true;
            _backSpace = true;

            lblResult.Text = _temp;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (_cal)
            {
                _temp = "0";
                _cal = false;
            }
            if (_temp == "0")
            {
                _temp = "8";
            }
            else
            {
                _temp += "8";
            }

            _put0 = true;
            _backSpace = true;

            lblResult.Text = _temp;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (_cal)
            {
                _temp = "0";
                _cal = false;
            }
            if (_temp == "0")
            {
                _temp = "9";
            }
            else
            {
                _temp += "9";
            }

            _put0 = true;
            _backSpace = true;

            lblResult.Text = _temp;
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            if (_cal)
            {
                _temp = "0";
                _cal = false;
            }

            if (!_temp.Contains('.'))
            {
                _temp += ".";
            }

            _put0 = true;
            _backSpace = true;

            lblResult.Text = _temp;
        }

        private void btnBS_Click(object sender, EventArgs e)
        {
            if (_backSpace)
            {
                if (_temp.Length > 1)
                {
                    _temp = _temp.Remove(_temp.Length - 1);
                    _cal = true;
                }
                else
                {
                    _temp = "0";
                    _put0 = false;
                    _backSpace = false;
                }
            }

            lblResult.Text = _temp;
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            if (_preMath != 0)
            {
                if (_str == "")
                {
                    _inputA = double.Parse(_temp);
                    _str = _str + _temp + " + ";
                }
                else
                {
                    if (_cal)
                    {
                        _str = _str.Remove(_str.Length - 2) + "+ ";
                    }
                    else
                    {
                        _inputB = double.Parse(_temp);
                        _value = _listCal[_preMath](_inputA, _inputB);
                        _inputA = _value;

                        lblResult.Text = _value.ToString();
                        _str = _str + _temp + " + ";
                        _temp = _value.ToString();
                    }
                }

                label1.Text = _str;
                _preMath = 0;
                _backSpace = false;
                _cal = true;
            }
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            if (_preMath != 1)
            {
                if (_str == "")
                {
                    _inputA = double.Parse(_temp);
                    _str = _str + _temp + " - ";
                }
                else
                {
                    if (_cal)
                    {
                        _str = _str.Remove(_str.Length - 2) + "- ";
                    }
                    else
                    {
                        _inputB = double.Parse(_temp);
                        _value = _listCal[_preMath](_inputA, _inputB);
                        _inputA = _value;

                        lblResult.Text = _value.ToString();
                        _str = _str + _temp + " - ";
                        _temp = _value.ToString();
                    }
                }

                label1.Text = _str;
                _preMath = 1;
                _backSpace = false;
                _cal = true;
            }
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            if (_preMath != 2)
            {
                if (_str == "")
                {
                    _inputA = double.Parse(_temp);
                    _str = _str + _temp + " x ";
                }
                else
                {
                    if (_cal)
                    {
                        _str = _str.Remove(_str.Length - 2) + "x ";
                    }
                    else
                    {
                        _inputB = double.Parse(_temp);
                        _value = _listCal[_preMath](_inputA, _inputB);
                        _inputA = _value;

                        lblResult.Text = _value.ToString();
                        _str = _str + _temp + " x ";
                        _temp = _value.ToString();
                    }
                }

                label1.Text = _str;
                _preMath = 2;
                _backSpace = false;
                _cal = true;
            }
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            if (_preMath != 3)
            {
                if (_str == "")
                {
                    _inputA = double.Parse(_temp);
                    _str = _str + _temp + " / ";
                }
                else
                {
                    if (_cal)
                    {
                        _str = _str.Remove(_str.Length - 2) + "/ ";
                    }

                    else
                    {
                        _inputB = double.Parse(_temp);
                        _value = _listCal[_preMath](_inputA, _inputB);
                        _inputA = _value;

                        lblResult.Text = _value.ToString();
                        _str = _str + _temp + " / ";
                        _temp = _value.ToString();
                    }
                }

                label1.Text = _str;
                _preMath = 3;
                _backSpace = false;
                _cal = true;
            }
        }

        private void btnBang_Click(object sender, EventArgs e)
        {
            if (_preMath != -1)
            {
                _inputB = double.Parse(_temp);
                _value = _listCal[_preMath](_inputA, _inputB);
                _temp = _value.ToString();
                _str = "";
                label1.Text = _str;
                lblResult.Text = _value.ToString();
                _backSpace = false;
                _cal = true;
                _preMath = -1;
            }
        }

        private void btnBP_Click(object sender, EventArgs e)
        {
            double a = double.Parse(_temp);
            _value = a * a;
            _temp = _value.ToString();
            lblResult.Text = _temp;
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            _temp = "0";
            _backSpace = false;
            _put0 = false;
            _putDot = false;
            _value = 0;
            _inputA = 0;
            _inputB = 0;
            _str = "";
            _cal = false;
            _preMath = -1;

            lblResult.Text = _temp;
            label1.Text = "";
        }

        private void btnZ_Click(object sender, EventArgs e)
        {
            if (_temp[0] == '-')
                _temp = _temp.Remove(0, 1);
            else
                _temp = _temp.Insert(0, "-");

            lblResult.Text = _temp;
        }
    }
}
