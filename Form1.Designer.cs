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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 223);
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
    }
}

