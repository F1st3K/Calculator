namespace View
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this._inputExpression = new System.Windows.Forms.TextBox();
            this._convertedExpression = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this._resultExpression = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this._calculateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(33, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(609, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Математическое выражение:";
            // 
            // _inputExpression
            // 
            this._inputExpression.Location = new System.Drawing.Point(33, 48);
            this._inputExpression.Name = "_inputExpression";
            this._inputExpression.Size = new System.Drawing.Size(609, 33);
            this._inputExpression.TabIndex = 1;
            // 
            // _convertedExpression
            // 
            this._convertedExpression.Location = new System.Drawing.Point(33, 199);
            this._convertedExpression.Name = "_convertedExpression";
            this._convertedExpression.Size = new System.Drawing.Size(609, 33);
            this._convertedExpression.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(33, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(609, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "Обратная польская нотация:";
            // 
            // _resultExpression
            // 
            this._resultExpression.Location = new System.Drawing.Point(33, 298);
            this._resultExpression.Name = "_resultExpression";
            this._resultExpression.Size = new System.Drawing.Size(609, 33);
            this._resultExpression.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(33, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(609, 36);
            this.label3.TabIndex = 4;
            this.label3.Text = "Результат:";
            // 
            // _calculateButton
            // 
            this._calculateButton.Location = new System.Drawing.Point(312, 87);
            this._calculateButton.Name = "_calculateButton";
            this._calculateButton.Size = new System.Drawing.Size(330, 44);
            this._calculateButton.TabIndex = 2;
            this._calculateButton.Text = "Вычеслить";
            this._calculateButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 345);
            this.Controls.Add(this._calculateButton);
            this.Controls.Add(this._resultExpression);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._convertedExpression);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._inputExpression);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Калькулятор";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox _resultExpression;
        private System.Windows.Forms.TextBox _inputExpression;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _convertedExpression;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button _calculateButton;
        private System.Windows.Forms.Label label1;

        #endregion
    }
}