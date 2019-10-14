namespace SleepCalculator
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.time4 = new System.Windows.Forms.Label();
            this.time3 = new System.Windows.Forms.Label();
            this.time2 = new System.Windows.Forms.Label();
            this.time1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePickerSleep = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.time8 = new System.Windows.Forms.Label();
            this.time7 = new System.Windows.Forms.Label();
            this.time6 = new System.Windows.Forms.Label();
            this.time5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(608, 297);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.dateTimePickerSleep);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(600, 266);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Wake Up";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.time4);
            this.groupBox1.Controls.Add(this.time3);
            this.groupBox1.Controls.Add(this.time2);
            this.groupBox1.Controls.Add(this.time1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(6, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(586, 159);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Go to sleep";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(516, 18);
            this.label8.TabIndex = 6;
            this.label8.Text = "The average human takes fourteen minutes to fall asleep, so plan accordingly!";
            this.label8.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(452, 18);
            this.label7.TabIndex = 5;
            this.label7.Text = "Please keep in mind that you should be falling asleep at these times.";
            this.label7.Visible = false;
            // 
            // time4
            // 
            this.time4.AutoSize = true;
            this.time4.Location = new System.Drawing.Point(328, 62);
            this.time4.Name = "time4";
            this.time4.Size = new System.Drawing.Size(44, 18);
            this.time4.TabIndex = 4;
            this.time4.Text = "01:30";
            this.time4.Visible = false;
            // 
            // time3
            // 
            this.time3.AutoSize = true;
            this.time3.Location = new System.Drawing.Point(229, 62);
            this.time3.Name = "time3";
            this.time3.Size = new System.Drawing.Size(44, 18);
            this.time3.TabIndex = 3;
            this.time3.Text = "00:00";
            this.time3.Visible = false;
            // 
            // time2
            // 
            this.time2.AutoSize = true;
            this.time2.Location = new System.Drawing.Point(136, 62);
            this.time2.Name = "time2";
            this.time2.Size = new System.Drawing.Size(44, 18);
            this.time2.TabIndex = 2;
            this.time2.Text = "22:30";
            this.time2.Visible = false;
            // 
            // time1
            // 
            this.time1.AutoSize = true;
            this.time1.Location = new System.Drawing.Point(50, 62);
            this.time1.Name = "time1";
            this.time1.Size = new System.Drawing.Size(44, 18);
            this.time1.TabIndex = 1;
            this.time1.Text = "21:00";
            this.time1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "You should fall asleep at these times:";
            this.label2.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(362, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // dateTimePickerSleep
            // 
            this.dateTimePickerSleep.CustomFormat = "HH:mm";
            this.dateTimePickerSleep.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerSleep.Location = new System.Drawing.Point(81, 62);
            this.dateTimePickerSleep.Name = "dateTimePickerSleep";
            this.dateTimePickerSleep.ShowUpDown = true;
            this.dateTimePickerSleep.Size = new System.Drawing.Size(200, 24);
            this.dateTimePickerSleep.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "I have to wake up at...";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(600, 266);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Go To Sleep";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.time8);
            this.groupBox2.Controls.Add(this.time7);
            this.groupBox2.Controls.Add(this.time6);
            this.groupBox2.Controls.Add(this.time5);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(8, 105);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(586, 161);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Wake up";
            // 
            // time8
            // 
            this.time8.AutoSize = true;
            this.time8.Location = new System.Drawing.Point(326, 95);
            this.time8.Name = "time8";
            this.time8.Size = new System.Drawing.Size(44, 18);
            this.time8.TabIndex = 5;
            this.time8.Text = "10:30";
            this.time8.Visible = false;
            // 
            // time7
            // 
            this.time7.AutoSize = true;
            this.time7.Location = new System.Drawing.Point(229, 95);
            this.time7.Name = "time7";
            this.time7.Size = new System.Drawing.Size(44, 18);
            this.time7.TabIndex = 4;
            this.time7.Text = "09:00";
            this.time7.Visible = false;
            // 
            // time6
            // 
            this.time6.AutoSize = true;
            this.time6.Location = new System.Drawing.Point(128, 95);
            this.time6.Name = "time6";
            this.time6.Size = new System.Drawing.Size(44, 18);
            this.time6.TabIndex = 3;
            this.time6.Text = "07:30";
            this.time6.Visible = false;
            // 
            // time5
            // 
            this.time5.AutoSize = true;
            this.time5.Location = new System.Drawing.Point(36, 95);
            this.time5.Name = "time5";
            this.time5.Size = new System.Drawing.Size(44, 18);
            this.time5.TabIndex = 2;
            this.time5.Text = "06:00";
            this.time5.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 56);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(556, 18);
            this.label11.TabIndex = 1;
            this.label11.Text = "If you head to bed right now, you should try to wake up at one of the following t" +
    "imes:";
            this.label11.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(388, 18);
            this.label10.TabIndex = 0;
            this.label10.Text = "It takes the average human fourteen minutes to fall asleep.";
            this.label10.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(102, 56);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "ZZZz";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(298, 18);
            this.label9.TabIndex = 0;
            this.label9.Text = "Find out when to get up if you go to bed now";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(611, 300);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Name = "Form1";
            this.Text = "Sleep calculator";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DateTimePicker dateTimePickerSleep;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label time4;
        private System.Windows.Forms.Label time3;
        private System.Windows.Forms.Label time2;
        private System.Windows.Forms.Label time1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label time8;
        private System.Windows.Forms.Label time7;
        private System.Windows.Forms.Label time6;
        private System.Windows.Forms.Label time5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label9;
    }
}

