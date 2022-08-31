namespace payrollGUI01
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtHours = new System.Windows.Forms.TextBox();
            this.lblHours = new System.Windows.Forms.Label();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.lblRate = new System.Windows.Forms.Label();
            this.txtGross = new System.Windows.Forms.TextBox();
            this.lblGross = new System.Windows.Forms.Label();
            this.txtTotalNumberGrossPays = new System.Windows.Forms.TextBox();
            this.lblTotalNumberGrossPays = new System.Windows.Forms.Label();
            this.txtTotalGrossPay = new System.Windows.Forms.TextBox();
            this.lblTotalGrossPay = new System.Windows.Forms.Label();
            this.txtAverageGrossPay = new System.Windows.Forms.TextBox();
            this.lblAverageGrossPay = new System.Windows.Forms.Label();
            this.txtHighestGrossPay = new System.Windows.Forms.TextBox();
            this.lblHighestGrossPay = new System.Windows.Forms.Label();
            this.txtLowestGrossPay = new System.Windows.Forms.TextBox();
            this.lblLowestGrossPay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(247, 378);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(160, 54);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(441, 378);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(160, 54);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(637, 378);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(160, 54);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblFirstName
            // 
            this.lblFirstName.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(50, 35);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(163, 36);
            this.lblFirstName.TabIndex = 13;
            this.lblFirstName.Text = "First Name:";
            this.lblFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(247, 38);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(160, 38);
            this.txtFirstName.TabIndex = 0;
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(247, 101);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(160, 38);
            this.txtLastName.TabIndex = 1;
            // 
            // lblLastName
            // 
            this.lblLastName.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(50, 98);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(163, 36);
            this.lblLastName.TabIndex = 14;
            this.lblLastName.Text = "Last Name:";
            this.lblLastName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtHours
            // 
            this.txtHours.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHours.Location = new System.Drawing.Point(247, 170);
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(160, 38);
            this.txtHours.TabIndex = 2;
            // 
            // lblHours
            // 
            this.lblHours.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHours.Location = new System.Drawing.Point(50, 167);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(163, 36);
            this.lblHours.TabIndex = 15;
            this.lblHours.Text = "Hours:";
            this.lblHours.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtRate
            // 
            this.txtRate.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRate.Location = new System.Drawing.Point(247, 233);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(160, 38);
            this.txtRate.TabIndex = 3;
            // 
            // lblRate
            // 
            this.lblRate.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRate.Location = new System.Drawing.Point(50, 230);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(163, 36);
            this.lblRate.TabIndex = 16;
            this.lblRate.Text = "Rate:";
            this.lblRate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtGross
            // 
            this.txtGross.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGross.Location = new System.Drawing.Point(247, 293);
            this.txtGross.Name = "txtGross";
            this.txtGross.ReadOnly = true;
            this.txtGross.Size = new System.Drawing.Size(160, 38);
            this.txtGross.TabIndex = 7;
            // 
            // lblGross
            // 
            this.lblGross.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGross.Location = new System.Drawing.Point(50, 290);
            this.lblGross.Name = "lblGross";
            this.lblGross.Size = new System.Drawing.Size(163, 36);
            this.lblGross.TabIndex = 17;
            this.lblGross.Text = "Gross:";
            this.lblGross.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTotalNumberGrossPays
            // 
            this.txtTotalNumberGrossPays.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalNumberGrossPays.Location = new System.Drawing.Point(725, 35);
            this.txtTotalNumberGrossPays.Name = "txtTotalNumberGrossPays";
            this.txtTotalNumberGrossPays.ReadOnly = true;
            this.txtTotalNumberGrossPays.Size = new System.Drawing.Size(160, 38);
            this.txtTotalNumberGrossPays.TabIndex = 8;
            // 
            // lblTotalNumberGrossPays
            // 
            this.lblTotalNumberGrossPays.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalNumberGrossPays.Location = new System.Drawing.Point(454, 35);
            this.lblTotalNumberGrossPays.Name = "lblTotalNumberGrossPays";
            this.lblTotalNumberGrossPays.Size = new System.Drawing.Size(253, 36);
            this.lblTotalNumberGrossPays.TabIndex = 18;
            this.lblTotalNumberGrossPays.Text = "Total # Gross Pays:";
            this.lblTotalNumberGrossPays.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTotalGrossPay
            // 
            this.txtTotalGrossPay.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalGrossPay.Location = new System.Drawing.Point(725, 98);
            this.txtTotalGrossPay.Name = "txtTotalGrossPay";
            this.txtTotalGrossPay.ReadOnly = true;
            this.txtTotalGrossPay.Size = new System.Drawing.Size(160, 38);
            this.txtTotalGrossPay.TabIndex = 9;
            // 
            // lblTotalGrossPay
            // 
            this.lblTotalGrossPay.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalGrossPay.Location = new System.Drawing.Point(454, 98);
            this.lblTotalGrossPay.Name = "lblTotalGrossPay";
            this.lblTotalGrossPay.Size = new System.Drawing.Size(253, 36);
            this.lblTotalGrossPay.TabIndex = 19;
            this.lblTotalGrossPay.Text = "Total Gross Pay:";
            this.lblTotalGrossPay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAverageGrossPay
            // 
            this.txtAverageGrossPay.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAverageGrossPay.Location = new System.Drawing.Point(725, 167);
            this.txtAverageGrossPay.Name = "txtAverageGrossPay";
            this.txtAverageGrossPay.ReadOnly = true;
            this.txtAverageGrossPay.Size = new System.Drawing.Size(160, 38);
            this.txtAverageGrossPay.TabIndex = 10;
            // 
            // lblAverageGrossPay
            // 
            this.lblAverageGrossPay.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAverageGrossPay.Location = new System.Drawing.Point(454, 167);
            this.lblAverageGrossPay.Name = "lblAverageGrossPay";
            this.lblAverageGrossPay.Size = new System.Drawing.Size(253, 36);
            this.lblAverageGrossPay.TabIndex = 20;
            this.lblAverageGrossPay.Text = "Average Gross Pay:";
            this.lblAverageGrossPay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtHighestGrossPay
            // 
            this.txtHighestGrossPay.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHighestGrossPay.Location = new System.Drawing.Point(725, 239);
            this.txtHighestGrossPay.Name = "txtHighestGrossPay";
            this.txtHighestGrossPay.ReadOnly = true;
            this.txtHighestGrossPay.Size = new System.Drawing.Size(160, 38);
            this.txtHighestGrossPay.TabIndex = 11;
            // 
            // lblHighestGrossPay
            // 
            this.lblHighestGrossPay.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighestGrossPay.Location = new System.Drawing.Point(454, 239);
            this.lblHighestGrossPay.Name = "lblHighestGrossPay";
            this.lblHighestGrossPay.Size = new System.Drawing.Size(253, 36);
            this.lblHighestGrossPay.TabIndex = 21;
            this.lblHighestGrossPay.Text = "Highest Gross Pay:";
            this.lblHighestGrossPay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtLowestGrossPay
            // 
            this.txtLowestGrossPay.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLowestGrossPay.Location = new System.Drawing.Point(725, 300);
            this.txtLowestGrossPay.Name = "txtLowestGrossPay";
            this.txtLowestGrossPay.ReadOnly = true;
            this.txtLowestGrossPay.Size = new System.Drawing.Size(160, 38);
            this.txtLowestGrossPay.TabIndex = 12;
            // 
            // lblLowestGrossPay
            // 
            this.lblLowestGrossPay.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLowestGrossPay.Location = new System.Drawing.Point(454, 300);
            this.lblLowestGrossPay.Name = "lblLowestGrossPay";
            this.lblLowestGrossPay.Size = new System.Drawing.Size(253, 36);
            this.lblLowestGrossPay.TabIndex = 22;
            this.lblLowestGrossPay.Text = "Lowest Gross Pay:";
            this.lblLowestGrossPay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(1019, 481);
            this.Controls.Add(this.txtLowestGrossPay);
            this.Controls.Add(this.lblLowestGrossPay);
            this.Controls.Add(this.txtHighestGrossPay);
            this.Controls.Add(this.lblHighestGrossPay);
            this.Controls.Add(this.txtAverageGrossPay);
            this.Controls.Add(this.lblAverageGrossPay);
            this.Controls.Add(this.txtTotalGrossPay);
            this.Controls.Add(this.lblTotalGrossPay);
            this.Controls.Add(this.txtTotalNumberGrossPays);
            this.Controls.Add(this.lblTotalNumberGrossPays);
            this.Controls.Add(this.txtGross);
            this.Controls.Add(this.lblGross);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.lblRate);
            this.Controls.Add(this.txtHours);
            this.Controls.Add(this.lblHours);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.TextBox txtGross;
        private System.Windows.Forms.Label lblGross;
        private System.Windows.Forms.TextBox txtTotalNumberGrossPays;
        private System.Windows.Forms.Label lblTotalNumberGrossPays;
        private System.Windows.Forms.TextBox txtTotalGrossPay;
        private System.Windows.Forms.Label lblTotalGrossPay;
        private System.Windows.Forms.TextBox txtAverageGrossPay;
        private System.Windows.Forms.Label lblAverageGrossPay;
        private System.Windows.Forms.TextBox txtHighestGrossPay;
        private System.Windows.Forms.Label lblHighestGrossPay;
        private System.Windows.Forms.TextBox txtLowestGrossPay;
        private System.Windows.Forms.Label lblLowestGrossPay;
    }
}

