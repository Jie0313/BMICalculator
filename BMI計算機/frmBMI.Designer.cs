namespace BMI計算機
{
    partial class frmBMI
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grpInput = new System.Windows.Forms.GroupBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.grpOutput = new System.Windows.Forms.GroupBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblBMI = new System.Windows.Forms.Label();
            this.lblAdvice = new System.Windows.Forms.Label();
            this.lblIdealWeight = new System.Windows.Forms.Label();
            this.grpInput.SuspendLayout();
            this.grpOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpInput
            // 
            this.grpInput.Controls.Add(this.btnRun);
            this.grpInput.Controls.Add(this.txtWeight);
            this.grpInput.Controls.Add(this.txtHeight);
            this.grpInput.Controls.Add(this.lblWeight);
            this.grpInput.Controls.Add(this.lblHeight);
            this.grpInput.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grpInput.Location = new System.Drawing.Point(12, 12);
            this.grpInput.Name = "grpInput";
            this.grpInput.Size = new System.Drawing.Size(395, 131);
            this.grpInput.TabIndex = 0;
            this.grpInput.TabStop = false;
            this.grpInput.Text = "輸入";
            // 
            // btnRun
            // 
            this.btnRun.BackColor = System.Drawing.SystemColors.Control;
            this.btnRun.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRun.Location = new System.Drawing.Point(265, 45);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(76, 61);
            this.btnRun.TabIndex = 4;
            this.btnRun.Text = "計算";
            this.btnRun.UseVisualStyleBackColor = false;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(118, 85);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(100, 26);
            this.txtWeight.TabIndex = 3;
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(118, 30);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(100, 26);
            this.txtHeight.TabIndex = 2;
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(10, 88);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(60, 18);
            this.lblWeight.TabIndex = 1;
            this.lblWeight.Text = "體重(kg)";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(10, 33);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(64, 18);
            this.lblHeight.TabIndex = 0;
            this.lblHeight.Text = "身高(cm)";
            // 
            // grpOutput
            // 
            this.grpOutput.Controls.Add(this.lblIdealWeight);
            this.grpOutput.Controls.Add(this.lblAdvice);
            this.grpOutput.Controls.Add(this.lblResult);
            this.grpOutput.Controls.Add(this.lblBMI);
            this.grpOutput.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grpOutput.Location = new System.Drawing.Point(12, 159);
            this.grpOutput.Name = "grpOutput";
            this.grpOutput.Size = new System.Drawing.Size(395, 142);
            this.grpOutput.TabIndex = 1;
            this.grpOutput.TabStop = false;
            this.grpOutput.Text = "計算結果";
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult.Location = new System.Drawing.Point(184, 34);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(157, 26);
            this.lblResult.TabIndex = 1;
            this.lblResult.Text = "                             ";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBMI
            // 
            this.lblBMI.AutoSize = true;
            this.lblBMI.Location = new System.Drawing.Point(6, 34);
            this.lblBMI.Name = "lblBMI";
            this.lblBMI.Size = new System.Drawing.Size(127, 18);
            this.lblBMI.TabIndex = 0;
            this.lblBMI.Text = "身體質量指數(BMI)";
            // 
            // lblAdvice
            // 
            this.lblAdvice.AutoSize = true;
            this.lblAdvice.Location = new System.Drawing.Point(10, 105);
            this.lblAdvice.Name = "lblAdvice";
            this.lblAdvice.Size = new System.Drawing.Size(0, 18);
            this.lblAdvice.TabIndex = 2;
            // 
            // lblIdealWeight
            // 
            this.lblIdealWeight.AutoSize = true;
            this.lblIdealWeight.Location = new System.Drawing.Point(6, 74);
            this.lblIdealWeight.Name = "lblIdealWeight";
            this.lblIdealWeight.Size = new System.Drawing.Size(0, 18);
            this.lblIdealWeight.TabIndex = 3;
            // 
            // frmBMI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 328);
            this.Controls.Add(this.grpOutput);
            this.Controls.Add(this.grpInput);
            this.Name = "frmBMI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BMI計算機";
            this.grpInput.ResumeLayout(false);
            this.grpInput.PerformLayout();
            this.grpOutput.ResumeLayout(false);
            this.grpOutput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox grpInput;
        private System.Windows.Forms.GroupBox grpOutput;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblBMI;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblAdvice;
        private System.Windows.Forms.Label lblIdealWeight;
    }
}

