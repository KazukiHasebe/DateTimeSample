using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateTimeSample
{
    public partial class Form1 : Form
    {
        //現在時刻取得
        private DateTime _now;

        public Form1()
        {
            InitializeComponent();
        }

        private void btNow_Click(object sender, EventArgs e)
        {
            _now = DateTime.Now; //現在時刻取得
            tbNowDisp.Text = _now.ToString();

            if (DateTime.IsLeapYear(_now.Year))
            {
                tbLeapYearCheck.Text = "今年は閏年です。";
            }
            else
            {
                tbLeapYearCheck.Text = "今年は閏年ではありません。";
            }
        }

        private void btBefore_Click(object sender, EventArgs e)
        {
            //メソッドチェーンの例
            var outputDate = (_now.AddMonths(-(int)nudMonthBeforeAfter.Value)).AddDays(-(double)nudDayBeforeAfter.Value);
            
            //月日を戻して表示
            tbBeforeAfterDisp.Text = outputDate.ToString();

            //閏年の判定(三項演算子)
            tbLeapYearCheck.Text = nudMonthBeforeAfter.Value.ToString() + "ヶ月" +
                                       nudDayBeforeAfter.Value.ToString() + "日前は";
            tbLeapYearCheck.Text = DateTime.IsLeapYear(outputDate.Year) ? "閏年です。" : "平年です。";
            
        }

        private void btAfter_Click(object sender, EventArgs e)
        {
            //メソッドチェーンの例
            var outputDate = (_now.AddMonths((int)nudMonthBeforeAfter.Value)).AddDays((double)nudDayBeforeAfter.Value);

            //月日を進めて表示
            tbBeforeAfterDisp.Text = outputDate.ToString();

            //閏年の判定(三項演算子)
            tbLeapYearCheck.Text = nudMonthBeforeAfter.Value.ToString() + "ヶ月" +
                                       nudDayBeforeAfter.Value.ToString() + "日後は";
            tbLeapYearCheck.Text = DateTime.IsLeapYear(outputDate.Year) ? "閏年です。" : "平年です。";

        }

        private void btBirthdayCalc_Click(object sender, EventArgs e)
        {
            //現在時刻を格納
            DateTime now = new DateTime((int)DateTime.Now.Year, (int)DateTime.Now.Month, (int)DateTime.Now.Day);
            //誕生日を格納
            DateTime birth = new DateTime((int)nudYear.Value, (int)nudMonth.Value, (int)nudDay.Value);

            //日数計算
            tbDayCountDisp.Text = (now - birth).TotalDays.ToString();
        }
    }
}
