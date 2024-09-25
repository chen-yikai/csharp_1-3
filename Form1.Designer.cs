namespace _1_3
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.calc = new System.Windows.Forms.Button();
            this.input = new System.Windows.Forms.TextBox();
            this.text1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.diameter = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.area = new System.Windows.Forms.Label();
            this.perimeter = new System.Windows.Forms.Label();
            this.plusA = new System.Windows.Forms.TextBox();
            this.plusB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.plusResult = new System.Windows.Forms.Label();
            this.plusCalc = new System.Windows.Forms.Button();
            this.minusCalc = new System.Windows.Forms.Button();
            this.minusResult = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.minusB = new System.Windows.Forms.TextBox();
            this.minusA = new System.Windows.Forms.TextBox();
            this.multiplyCalc = new System.Windows.Forms.Button();
            this.multiplyResult = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.multiplyB = new System.Windows.Forms.TextBox();
            this.multiplyA = new System.Windows.Forms.TextBox();
            this.divisionCalc = new System.Windows.Forms.Button();
            this.divisionResult = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dividedB = new System.Windows.Forms.TextBox();
            this.dividedA = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // calc
            // 
            this.calc.Font = new System.Drawing.Font("新細明體", 15F);
            this.calc.Location = new System.Drawing.Point(291, 30);
            this.calc.Name = "calc";
            this.calc.Size = new System.Drawing.Size(104, 50);
            this.calc.TabIndex = 0;
            this.calc.Text = "計算";
            this.calc.UseVisualStyleBackColor = true;
            this.calc.Click += new System.EventHandler(this.calc_click);
            // 
            // input
            // 
            this.input.Font = new System.Drawing.Font("新細明體", 15F);
            this.input.Location = new System.Drawing.Point(107, 30);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(127, 31);
            this.input.TabIndex = 1;
            // 
            // text1
            // 
            this.text1.AutoSize = true;
            this.text1.Font = new System.Drawing.Font("新細明體", 15F);
            this.text1.Location = new System.Drawing.Point(32, 33);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(69, 20);
            this.text1.TabIndex = 2;
            this.text1.Text = "圓半徑";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 15F);
            this.label2.Location = new System.Drawing.Point(32, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "圓周長";
            // 
            // diameter
            // 
            this.diameter.AutoSize = true;
            this.diameter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.diameter.Font = new System.Drawing.Font("新細明體", 15F);
            this.diameter.Location = new System.Drawing.Point(107, 85);
            this.diameter.Name = "diameter";
            this.diameter.Size = new System.Drawing.Size(2, 22);
            this.diameter.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 15F);
            this.label4.Location = new System.Drawing.Point(32, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "圓直徑";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新細明體", 15F);
            this.label6.Location = new System.Drawing.Point(32, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "圓面積";
            // 
            // area
            // 
            this.area.AutoSize = true;
            this.area.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.area.Font = new System.Drawing.Font("新細明體", 15F);
            this.area.Location = new System.Drawing.Point(107, 168);
            this.area.Name = "area";
            this.area.Size = new System.Drawing.Size(2, 22);
            this.area.TabIndex = 8;
            // 
            // perimeter
            // 
            this.perimeter.AutoSize = true;
            this.perimeter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.perimeter.Font = new System.Drawing.Font("新細明體", 15F);
            this.perimeter.Location = new System.Drawing.Point(107, 127);
            this.perimeter.Name = "perimeter";
            this.perimeter.Size = new System.Drawing.Size(2, 22);
            this.perimeter.TabIndex = 9;
            // 
            // plusA
            // 
            this.plusA.Font = new System.Drawing.Font("新細明體", 15F);
            this.plusA.Location = new System.Drawing.Point(36, 243);
            this.plusA.Name = "plusA";
            this.plusA.Size = new System.Drawing.Size(73, 31);
            this.plusA.TabIndex = 10;
            // 
            // plusB
            // 
            this.plusB.Font = new System.Drawing.Font("新細明體", 15F);
            this.plusB.Location = new System.Drawing.Point(143, 243);
            this.plusB.Name = "plusB";
            this.plusB.Size = new System.Drawing.Size(73, 31);
            this.plusB.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 15F);
            this.label1.Location = new System.Drawing.Point(117, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "+";
            // 
            // plusResult
            // 
            this.plusResult.AutoSize = true;
            this.plusResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plusResult.Font = new System.Drawing.Font("新細明體", 15F);
            this.plusResult.Location = new System.Drawing.Point(307, 246);
            this.plusResult.Name = "plusResult";
            this.plusResult.Size = new System.Drawing.Size(2, 22);
            this.plusResult.TabIndex = 13;
            // 
            // plusCalc
            // 
            this.plusCalc.Font = new System.Drawing.Font("新細明體", 15F);
            this.plusCalc.Location = new System.Drawing.Point(242, 243);
            this.plusCalc.Name = "plusCalc";
            this.plusCalc.Size = new System.Drawing.Size(44, 27);
            this.plusCalc.TabIndex = 14;
            this.plusCalc.Text = "=";
            this.plusCalc.UseVisualStyleBackColor = true;
            this.plusCalc.Click += new System.EventHandler(this.plusCalc_Click);
            // 
            // minusCalc
            // 
            this.minusCalc.Font = new System.Drawing.Font("新細明體", 15F);
            this.minusCalc.Location = new System.Drawing.Point(242, 292);
            this.minusCalc.Name = "minusCalc";
            this.minusCalc.Size = new System.Drawing.Size(44, 27);
            this.minusCalc.TabIndex = 19;
            this.minusCalc.Text = "=";
            this.minusCalc.UseVisualStyleBackColor = true;
            this.minusCalc.Click += new System.EventHandler(this.minusCalc_Click);
            // 
            // minusResult
            // 
            this.minusResult.AutoSize = true;
            this.minusResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.minusResult.Font = new System.Drawing.Font("新細明體", 15F);
            this.minusResult.Location = new System.Drawing.Point(307, 295);
            this.minusResult.Name = "minusResult";
            this.minusResult.Size = new System.Drawing.Size(2, 22);
            this.minusResult.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("新細明體", 15F);
            this.label7.Location = new System.Drawing.Point(117, 295);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "-";
            // 
            // minusB
            // 
            this.minusB.Font = new System.Drawing.Font("新細明體", 15F);
            this.minusB.Location = new System.Drawing.Point(143, 292);
            this.minusB.Name = "minusB";
            this.minusB.Size = new System.Drawing.Size(73, 31);
            this.minusB.TabIndex = 16;
            // 
            // minusA
            // 
            this.minusA.Font = new System.Drawing.Font("新細明體", 15F);
            this.minusA.Location = new System.Drawing.Point(36, 292);
            this.minusA.Name = "minusA";
            this.minusA.Size = new System.Drawing.Size(73, 31);
            this.minusA.TabIndex = 15;
            // 
            // multiplyCalc
            // 
            this.multiplyCalc.Font = new System.Drawing.Font("新細明體", 15F);
            this.multiplyCalc.Location = new System.Drawing.Point(242, 341);
            this.multiplyCalc.Name = "multiplyCalc";
            this.multiplyCalc.Size = new System.Drawing.Size(44, 27);
            this.multiplyCalc.TabIndex = 24;
            this.multiplyCalc.Text = "=";
            this.multiplyCalc.UseVisualStyleBackColor = true;
            this.multiplyCalc.Click += new System.EventHandler(this.multiplyCalc_Click);
            // 
            // multiplyResult
            // 
            this.multiplyResult.AutoSize = true;
            this.multiplyResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.multiplyResult.Font = new System.Drawing.Font("新細明體", 15F);
            this.multiplyResult.Location = new System.Drawing.Point(307, 344);
            this.multiplyResult.Name = "multiplyResult";
            this.multiplyResult.Size = new System.Drawing.Size(2, 22);
            this.multiplyResult.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("新細明體", 15F);
            this.label9.Location = new System.Drawing.Point(117, 344);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 20);
            this.label9.TabIndex = 22;
            this.label9.Text = "*";
            // 
            // multiplyB
            // 
            this.multiplyB.Font = new System.Drawing.Font("新細明體", 15F);
            this.multiplyB.Location = new System.Drawing.Point(143, 341);
            this.multiplyB.Name = "multiplyB";
            this.multiplyB.Size = new System.Drawing.Size(73, 31);
            this.multiplyB.TabIndex = 21;
            // 
            // multiplyA
            // 
            this.multiplyA.Font = new System.Drawing.Font("新細明體", 15F);
            this.multiplyA.Location = new System.Drawing.Point(36, 341);
            this.multiplyA.Name = "multiplyA";
            this.multiplyA.Size = new System.Drawing.Size(73, 31);
            this.multiplyA.TabIndex = 20;
            // 
            // divisionCalc
            // 
            this.divisionCalc.Font = new System.Drawing.Font("新細明體", 15F);
            this.divisionCalc.Location = new System.Drawing.Point(242, 392);
            this.divisionCalc.Name = "divisionCalc";
            this.divisionCalc.Size = new System.Drawing.Size(44, 27);
            this.divisionCalc.TabIndex = 29;
            this.divisionCalc.Text = "=";
            this.divisionCalc.UseVisualStyleBackColor = true;
            this.divisionCalc.Click += new System.EventHandler(this.divisionCalc_Click);
            // 
            // divisionResult
            // 
            this.divisionResult.AutoSize = true;
            this.divisionResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.divisionResult.Font = new System.Drawing.Font("新細明體", 15F);
            this.divisionResult.Location = new System.Drawing.Point(307, 395);
            this.divisionResult.Name = "divisionResult";
            this.divisionResult.Size = new System.Drawing.Size(2, 22);
            this.divisionResult.TabIndex = 28;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("新細明體", 15F);
            this.label11.Location = new System.Drawing.Point(117, 395);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(14, 20);
            this.label11.TabIndex = 27;
            this.label11.Text = "/";
            // 
            // dividedB
            // 
            this.dividedB.Font = new System.Drawing.Font("新細明體", 15F);
            this.dividedB.Location = new System.Drawing.Point(143, 392);
            this.dividedB.Name = "dividedB";
            this.dividedB.Size = new System.Drawing.Size(73, 31);
            this.dividedB.TabIndex = 26;
            // 
            // dividedA
            // 
            this.dividedA.Font = new System.Drawing.Font("新細明體", 15F);
            this.dividedA.Location = new System.Drawing.Point(36, 392);
            this.dividedA.Name = "dividedA";
            this.dividedA.Size = new System.Drawing.Size(73, 31);
            this.dividedA.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 450);
            this.Controls.Add(this.divisionCalc);
            this.Controls.Add(this.divisionResult);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dividedB);
            this.Controls.Add(this.dividedA);
            this.Controls.Add(this.multiplyCalc);
            this.Controls.Add(this.multiplyResult);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.multiplyB);
            this.Controls.Add(this.multiplyA);
            this.Controls.Add(this.minusCalc);
            this.Controls.Add(this.minusResult);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.minusB);
            this.Controls.Add(this.minusA);
            this.Controls.Add(this.plusCalc);
            this.Controls.Add(this.plusResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.plusB);
            this.Controls.Add(this.plusA);
            this.Controls.Add(this.perimeter);
            this.Controls.Add(this.area);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.diameter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.text1);
            this.Controls.Add(this.input);
            this.Controls.Add(this.calc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calc;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Label text1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label diameter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label area;
        private System.Windows.Forms.Label perimeter;
        private System.Windows.Forms.TextBox plusA;
        private System.Windows.Forms.TextBox plusB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label plusResult;
        private System.Windows.Forms.Button plusCalc;
        private System.Windows.Forms.Button minusCalc;
        private System.Windows.Forms.Label minusResult;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox minusB;
        private System.Windows.Forms.TextBox minusA;
        private System.Windows.Forms.Button multiplyCalc;
        private System.Windows.Forms.Label multiplyResult;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox multiplyB;
        private System.Windows.Forms.TextBox multiplyA;
        private System.Windows.Forms.Button divisionCalc;
        private System.Windows.Forms.Label divisionResult;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox dividedB;
        private System.Windows.Forms.TextBox dividedA;
    }
}

