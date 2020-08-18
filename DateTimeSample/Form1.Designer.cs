namespace DateTimeSample
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.btNow = new System.Windows.Forms.Button();
            this.tbNowDisp = new System.Windows.Forms.TextBox();
            this.nudMonthBeforeAfter = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btBefore = new System.Windows.Forms.Button();
            this.btAfter = new System.Windows.Forms.Button();
            this.tbBeforeAfterDisp = new System.Windows.Forms.TextBox();
            this.nudDayBeforeAfter = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.tbLeapYearCheck = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btBirthdayCalc = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.tbDayCountDisp = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.mcBirth = new System.Windows.Forms.MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)(this.nudMonthBeforeAfter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDayBeforeAfter)).BeginInit();
            this.SuspendLayout();
            // 
            // btNow
            // 
            this.btNow.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btNow.Location = new System.Drawing.Point(43, 40);
            this.btNow.Name = "btNow";
            this.btNow.Size = new System.Drawing.Size(126, 54);
            this.btNow.TabIndex = 0;
            this.btNow.Text = "現在日時";
            this.btNow.UseVisualStyleBackColor = true;
            this.btNow.Click += new System.EventHandler(this.btNow_Click);
            // 
            // tbNowDisp
            // 
            this.tbNowDisp.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbNowDisp.Location = new System.Drawing.Point(198, 52);
            this.tbNowDisp.Name = "tbNowDisp";
            this.tbNowDisp.Size = new System.Drawing.Size(343, 31);
            this.tbNowDisp.TabIndex = 1;
            // 
            // nudMonthBeforeAfter
            // 
            this.nudMonthBeforeAfter.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nudMonthBeforeAfter.Location = new System.Drawing.Point(198, 113);
            this.nudMonthBeforeAfter.Name = "nudMonthBeforeAfter";
            this.nudMonthBeforeAfter.Size = new System.Drawing.Size(120, 31);
            this.nudMonthBeforeAfter.TabIndex = 2;
            this.nudMonthBeforeAfter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(324, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "ヶ月";
            // 
            // btBefore
            // 
            this.btBefore.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btBefore.Location = new System.Drawing.Point(198, 163);
            this.btBefore.Name = "btBefore";
            this.btBefore.Size = new System.Drawing.Size(59, 39);
            this.btBefore.TabIndex = 4;
            this.btBefore.Text = "前";
            this.btBefore.UseVisualStyleBackColor = true;
            this.btBefore.Click += new System.EventHandler(this.btBefore_Click);
            // 
            // btAfter
            // 
            this.btAfter.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btAfter.Location = new System.Drawing.Point(283, 163);
            this.btAfter.Name = "btAfter";
            this.btAfter.Size = new System.Drawing.Size(59, 39);
            this.btAfter.TabIndex = 4;
            this.btAfter.Text = "後";
            this.btAfter.UseVisualStyleBackColor = true;
            this.btAfter.Click += new System.EventHandler(this.btAfter_Click);
            // 
            // tbBeforeAfterDisp
            // 
            this.tbBeforeAfterDisp.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbBeforeAfterDisp.Location = new System.Drawing.Point(198, 224);
            this.tbBeforeAfterDisp.Name = "tbBeforeAfterDisp";
            this.tbBeforeAfterDisp.Size = new System.Drawing.Size(343, 31);
            this.tbBeforeAfterDisp.TabIndex = 1;
            // 
            // nudDayBeforeAfter
            // 
            this.nudDayBeforeAfter.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nudDayBeforeAfter.Location = new System.Drawing.Point(381, 114);
            this.nudDayBeforeAfter.Name = "nudDayBeforeAfter";
            this.nudDayBeforeAfter.Size = new System.Drawing.Size(120, 31);
            this.nudDayBeforeAfter.TabIndex = 2;
            this.nudDayBeforeAfter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(507, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "日";
            // 
            // tbLeapYearCheck
            // 
            this.tbLeapYearCheck.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbLeapYearCheck.Location = new System.Drawing.Point(198, 275);
            this.tbLeapYearCheck.Name = "tbLeapYearCheck";
            this.tbLeapYearCheck.Size = new System.Drawing.Size(343, 31);
            this.tbLeapYearCheck.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(87, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "誕生日";
            // 
            // btBirthdayCalc
            // 
            this.btBirthdayCalc.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btBirthdayCalc.Location = new System.Drawing.Point(415, 443);
            this.btBirthdayCalc.Name = "btBirthdayCalc";
            this.btBirthdayCalc.Size = new System.Drawing.Size(126, 54);
            this.btBirthdayCalc.TabIndex = 0;
            this.btBirthdayCalc.Text = "日数計算";
            this.btBirthdayCalc.UseVisualStyleBackColor = true;
            this.btBirthdayCalc.Click += new System.EventHandler(this.btBirthdayCalc_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label8.Location = new System.Drawing.Point(194, 522);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 24);
            this.label8.TabIndex = 5;
            this.label8.Text = "生まれてから";
            // 
            // tbDayCountDisp
            // 
            this.tbDayCountDisp.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbDayCountDisp.Location = new System.Drawing.Point(329, 519);
            this.tbDayCountDisp.Name = "tbDayCountDisp";
            this.tbDayCountDisp.Size = new System.Drawing.Size(129, 31);
            this.tbDayCountDisp.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label9.Location = new System.Drawing.Point(464, 519);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 24);
            this.label9.TabIndex = 5;
            this.label9.Text = "日目です。";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label10.Location = new System.Drawing.Point(63, 278);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 24);
            this.label10.TabIndex = 5;
            this.label10.Text = "閏年判定";
            // 
            // mcBirth
            // 
            this.mcBirth.Location = new System.Drawing.Point(198, 336);
            this.mcBirth.MaxSelectionCount = 1;
            this.mcBirth.Name = "mcBirth";
            this.mcBirth.ShowToday = false;
            this.mcBirth.TabIndex = 6;
            this.mcBirth.TodayDate = new System.DateTime(2020, 8, 18, 0, 0, 0, 0);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 592);
            this.Controls.Add(this.mcBirth);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btAfter);
            this.Controls.Add(this.btBefore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudDayBeforeAfter);
            this.Controls.Add(this.nudMonthBeforeAfter);
            this.Controls.Add(this.tbDayCountDisp);
            this.Controls.Add(this.tbLeapYearCheck);
            this.Controls.Add(this.tbBeforeAfterDisp);
            this.Controls.Add(this.tbNowDisp);
            this.Controls.Add(this.btBirthdayCalc);
            this.Controls.Add(this.btNow);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudMonthBeforeAfter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDayBeforeAfter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btNow;
        private System.Windows.Forms.TextBox tbNowDisp;
        private System.Windows.Forms.NumericUpDown nudMonthBeforeAfter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btBefore;
        private System.Windows.Forms.Button btAfter;
        private System.Windows.Forms.TextBox tbBeforeAfterDisp;
        private System.Windows.Forms.NumericUpDown nudDayBeforeAfter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbLeapYearCheck;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btBirthdayCalc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbDayCountDisp;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MonthCalendar mcBirth;
    }
}

