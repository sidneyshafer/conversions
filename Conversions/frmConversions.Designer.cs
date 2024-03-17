namespace Conversions
{
    partial class frmConversions
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
            this.lblValue = new System.Windows.Forms.Label();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.lblConversions = new System.Windows.Forms.Label();
            this.lstConversions = new System.Windows.Forms.ListBox();
            this.lstCalculations = new System.Windows.Forms.ListBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnManageConversions = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValue.Location = new System.Drawing.Point(27, 35);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(106, 16);
            this.lblValue.TabIndex = 0;
            this.lblValue.Text = "Value to convert:";
            // 
            // txtValue
            // 
            this.txtValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValue.Location = new System.Drawing.Point(30, 56);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(115, 24);
            this.txtValue.TabIndex = 1;
            // 
            // lblConversions
            // 
            this.lblConversions.AutoSize = true;
            this.lblConversions.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConversions.Location = new System.Drawing.Point(27, 109);
            this.lblConversions.Name = "lblConversions";
            this.lblConversions.Size = new System.Drawing.Size(85, 16);
            this.lblConversions.TabIndex = 2;
            this.lblConversions.Text = "Conversions:";
            // 
            // lstConversions
            // 
            this.lstConversions.FormattingEnabled = true;
            this.lstConversions.ItemHeight = 16;
            this.lstConversions.Location = new System.Drawing.Point(30, 130);
            this.lstConversions.Name = "lstConversions";
            this.lstConversions.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstConversions.Size = new System.Drawing.Size(198, 196);
            this.lstConversions.TabIndex = 1;
            // 
            // lstCalculations
            // 
            this.lstCalculations.FormattingEnabled = true;
            this.lstCalculations.ItemHeight = 16;
            this.lstCalculations.Location = new System.Drawing.Point(276, 33);
            this.lstCalculations.Name = "lstCalculations";
            this.lstCalculations.Size = new System.Drawing.Size(338, 292);
            this.lstCalculations.TabIndex = 2;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(30, 350);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(82, 34);
            this.btnConvert.TabIndex = 3;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(144, 350);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(84, 34);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnManageConversions
            // 
            this.btnManageConversions.Location = new System.Drawing.Point(276, 350);
            this.btnManageConversions.Name = "btnManageConversions";
            this.btnManageConversions.Size = new System.Drawing.Size(210, 34);
            this.btnManageConversions.TabIndex = 5;
            this.btnManageConversions.Text = "Manage Conversions";
            this.btnManageConversions.UseVisualStyleBackColor = true;
            this.btnManageConversions.Click += new System.EventHandler(this.btnManageConversions_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(530, 350);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(84, 34);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmConversions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(653, 422);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnManageConversions);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.lstCalculations);
            this.Controls.Add(this.lstConversions);
            this.Controls.Add(this.lblConversions);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.lblValue);
            this.Name = "frmConversions";
            this.Text = "Conversions";
            this.Load += new System.EventHandler(this.frmConversions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Label lblConversions;
        private System.Windows.Forms.ListBox lstConversions;
        private System.Windows.Forms.ListBox lstCalculations;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnManageConversions;
        private System.Windows.Forms.Button btnExit;
    }
}

