namespace ReferenceNumberCalculator
{
    partial class frmRefNumCalc
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
            this.txtInputNumber = new System.Windows.Forms.TextBox();
            this.btnCalcRefNum = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtInputNumber
            // 
            this.txtInputNumber.Location = new System.Drawing.Point(12, 12);
            this.txtInputNumber.MaxLength = 18;
            this.txtInputNumber.Name = "txtInputNumber";
            this.txtInputNumber.Size = new System.Drawing.Size(263, 20);
            this.txtInputNumber.TabIndex = 0;
            // 
            // btnCalcRefNum
            // 
            this.btnCalcRefNum.Location = new System.Drawing.Point(12, 39);
            this.btnCalcRefNum.Name = "btnCalcRefNum";
            this.btnCalcRefNum.Size = new System.Drawing.Size(263, 23);
            this.btnCalcRefNum.TabIndex = 1;
            this.btnCalcRefNum.Text = "Reference number =";
            this.btnCalcRefNum.UseVisualStyleBackColor = true;
            this.btnCalcRefNum.Click += new System.EventHandler(this.btnCalcRefNum_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(13, 69);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(262, 20);
            this.txtResult.TabIndex = 2;
            // 
            // frmRefNumCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 125);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnCalcRefNum);
            this.Controls.Add(this.txtInputNumber);
            this.Name = "frmRefNumCalc";
            this.Text = "Reference Number Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInputNumber;
        private System.Windows.Forms.Button btnCalcRefNum;
        private System.Windows.Forms.TextBox txtResult;
    }
}

