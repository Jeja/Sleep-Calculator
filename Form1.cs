using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SleepCalculator
{
    public partial class Form1 : Form
    {
        string timeFormat = "HH:mm";
        public Form1()
        {
            InitializeComponent();

            /**
             * Converts time for when to wake up part of the program
             * Converts it from 12h version to 24h one
            */
            dateTimePickerSleep.Format = DateTimePickerFormat.Custom;
            dateTimePickerSleep.CustomFormat = timeFormat;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            LabelsVisible();

            DateTime wakeUpTime = dateTimePickerSleep.Value;

            time1.Text = wakeUpTime.AddHours(-9f).ToString(timeFormat);
            time2.Text = wakeUpTime.AddHours(-7.5f).ToString(timeFormat);
            time3.Text = wakeUpTime.AddHours(-6f).ToString(timeFormat);
            time4.Text = wakeUpTime.AddHours(-4.5f).ToString(timeFormat);

            void LabelsVisible()
            {
                label2.Visible = true;

                time1.Visible = true;
                time2.Visible = true;
                time3.Visible = true;
                time4.Visible = true;

                label7.Visible = true;
                label8.Visible = true;
            }
        }
    }
}
