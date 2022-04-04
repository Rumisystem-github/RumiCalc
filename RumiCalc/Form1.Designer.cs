namespace RumiCalc
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Calc_Output_label = new System.Windows.Forms.Label();
            this.Nomal_Calc_in1_textBox = new System.Windows.Forms.TextBox();
            this.Nomal_Calc_Ap_button = new System.Windows.Forms.Button();
            this.Nomal_Calc_in2_textBox = new System.Windows.Forms.TextBox();
            this.base_conv_input_textBox = new System.Windows.Forms.TextBox();
            this.B_Conv_button = new System.Windows.Forms.Button();
            this.Base_conv_HEX_radioButton = new System.Windows.Forms.RadioButton();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabControl1.Location = new System.Drawing.Point(12, 157);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(785, 281);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Nomal_Calc_in2_textBox);
            this.tabPage1.Controls.Add(this.Nomal_Calc_Ap_button);
            this.tabPage1.Controls.Add(this.Nomal_Calc_in1_textBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(777, 255);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "一般";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Base_conv_HEX_radioButton);
            this.tabPage2.Controls.Add(this.B_Conv_button);
            this.tabPage2.Controls.Add(this.base_conv_input_textBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(777, 255);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "進数変換";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Calc_Output_label
            // 
            this.Calc_Output_label.BackColor = System.Drawing.Color.Black;
            this.Calc_Output_label.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Calc_Output_label.ForeColor = System.Drawing.Color.Lime;
            this.Calc_Output_label.Location = new System.Drawing.Point(12, 9);
            this.Calc_Output_label.Name = "Calc_Output_label";
            this.Calc_Output_label.Size = new System.Drawing.Size(776, 145);
            this.Calc_Output_label.TabIndex = 1;
            this.Calc_Output_label.Text = "label1\r\nlabel1\r\nlabel1\r\nlabel1\r\n";
            // 
            // Nomal_Calc_in1_textBox
            // 
            this.Nomal_Calc_in1_textBox.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Nomal_Calc_in1_textBox.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.Nomal_Calc_in1_textBox.Location = new System.Drawing.Point(6, 6);
            this.Nomal_Calc_in1_textBox.Name = "Nomal_Calc_in1_textBox";
            this.Nomal_Calc_in1_textBox.Size = new System.Drawing.Size(765, 44);
            this.Nomal_Calc_in1_textBox.TabIndex = 0;
            // 
            // Nomal_Calc_Ap_button
            // 
            this.Nomal_Calc_Ap_button.Location = new System.Drawing.Point(6, 107);
            this.Nomal_Calc_Ap_button.Name = "Nomal_Calc_Ap_button";
            this.Nomal_Calc_Ap_button.Size = new System.Drawing.Size(764, 23);
            this.Nomal_Calc_Ap_button.TabIndex = 1;
            this.Nomal_Calc_Ap_button.Text = "計算";
            this.Nomal_Calc_Ap_button.UseVisualStyleBackColor = true;
            this.Nomal_Calc_Ap_button.Click += new System.EventHandler(this.Nomal_Calc);
            // 
            // Nomal_Calc_in2_textBox
            // 
            this.Nomal_Calc_in2_textBox.Font = new System.Drawing.Font("MS UI Gothic", 27.75F);
            this.Nomal_Calc_in2_textBox.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.Nomal_Calc_in2_textBox.Location = new System.Drawing.Point(7, 57);
            this.Nomal_Calc_in2_textBox.Name = "Nomal_Calc_in2_textBox";
            this.Nomal_Calc_in2_textBox.Size = new System.Drawing.Size(764, 44);
            this.Nomal_Calc_in2_textBox.TabIndex = 2;
            // 
            // base_conv_input_textBox
            // 
            this.base_conv_input_textBox.Font = new System.Drawing.Font("MS UI Gothic", 27.75F);
            this.base_conv_input_textBox.Location = new System.Drawing.Point(6, 6);
            this.base_conv_input_textBox.Name = "base_conv_input_textBox";
            this.base_conv_input_textBox.Size = new System.Drawing.Size(765, 44);
            this.base_conv_input_textBox.TabIndex = 0;
            // 
            // B_Conv_button
            // 
            this.B_Conv_button.Location = new System.Drawing.Point(6, 156);
            this.B_Conv_button.Name = "B_Conv_button";
            this.B_Conv_button.Size = new System.Drawing.Size(765, 23);
            this.B_Conv_button.TabIndex = 6;
            this.B_Conv_button.Text = "変換";
            this.B_Conv_button.UseVisualStyleBackColor = true;
            this.B_Conv_button.Click += new System.EventHandler(this.base_Conversion);
            // 
            // Base_conv_HEX_radioButton
            // 
            this.Base_conv_HEX_radioButton.AutoSize = true;
            this.Base_conv_HEX_radioButton.Location = new System.Drawing.Point(6, 56);
            this.Base_conv_HEX_radioButton.Name = "Base_conv_HEX_radioButton";
            this.Base_conv_HEX_radioButton.Size = new System.Drawing.Size(45, 16);
            this.Base_conv_HEX_radioButton.TabIndex = 7;
            this.Base_conv_HEX_radioButton.TabStop = true;
            this.Base_conv_HEX_radioButton.Text = "HEX";
            this.Base_conv_HEX_radioButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Calc_Output_label);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox Nomal_Calc_in1_textBox;
        private System.Windows.Forms.Label Calc_Output_label;
        private System.Windows.Forms.Button Nomal_Calc_Ap_button;
        private System.Windows.Forms.TextBox Nomal_Calc_in2_textBox;
        private System.Windows.Forms.Button B_Conv_button;
        private System.Windows.Forms.TextBox base_conv_input_textBox;
        private System.Windows.Forms.RadioButton Base_conv_HEX_radioButton;
    }
}

