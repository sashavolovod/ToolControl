namespace ToolControl
{
    partial class ToolView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbToolTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbOrderNumber = new System.Windows.Forms.Label();
            this.lbEmploeeName = new System.Windows.Forms.Label();
            this.lbWorkerName = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.lbWeight = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbDetailNumber = new System.Windows.Forms.Label();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lbToolTitle
            // 
            this.lbToolTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbToolTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbToolTitle.Location = new System.Drawing.Point(-5, 0);
            this.lbToolTitle.Name = "lbToolTitle";
            this.lbToolTitle.Size = new System.Drawing.Size(221, 26);
            this.lbToolTitle.TabIndex = 0;
            this.lbToolTitle.Text = "0543-4124";
            this.lbToolTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Технолог:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Слесарь:";
            // 
            // lbOrderNumber
            // 
            this.lbOrderNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbOrderNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbOrderNumber.ForeColor = System.Drawing.Color.Maroon;
            this.lbOrderNumber.Location = new System.Drawing.Point(134, 21);
            this.lbOrderNumber.Name = "lbOrderNumber";
            this.lbOrderNumber.Size = new System.Drawing.Size(82, 26);
            this.lbOrderNumber.TabIndex = 0;
            this.lbOrderNumber.Text = "988190";
            this.lbOrderNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbEmploeeName
            // 
            this.lbEmploeeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbEmploeeName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbEmploeeName.Location = new System.Drawing.Point(94, 46);
            this.lbEmploeeName.Name = "lbEmploeeName";
            this.lbEmploeeName.Size = new System.Drawing.Size(113, 17);
            this.lbEmploeeName.TabIndex = 1;
            this.lbEmploeeName.Text = "Шашин А.С.";
            // 
            // lbWorkerName
            // 
            this.lbWorkerName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbWorkerName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbWorkerName.Location = new System.Drawing.Point(94, 64);
            this.lbWorkerName.Name = "lbWorkerName";
            this.lbWorkerName.Size = new System.Drawing.Size(113, 17);
            this.lbWorkerName.TabIndex = 1;
            this.lbWorkerName.Text = "Муравский Р.П.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Находится в:";
            // 
            // cbStatus
            // 
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "ИнЦ",
            "ЛМЦ"});
            this.cbStatus.Location = new System.Drawing.Point(96, 84);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(111, 25);
            this.cbStatus.TabIndex = 2;
            // 
            // lbWeight
            // 
            this.lbWeight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbWeight.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbWeight.Location = new System.Drawing.Point(49, 115);
            this.lbWeight.Name = "lbWeight";
            this.lbWeight.Size = new System.Drawing.Size(41, 17);
            this.lbWeight.TabIndex = 3;
            this.lbWeight.Text = "1024";
            this.lbWeight.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Масса:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "кг.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbDetailNumber
            // 
            this.lbDetailNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDetailNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbDetailNumber.Location = new System.Drawing.Point(5, 24);
            this.lbDetailNumber.Name = "lbDetailNumber";
            this.lbDetailNumber.Size = new System.Drawing.Size(149, 20);
            this.lbDetailNumber.TabIndex = 6;
            this.lbDetailNumber.Text = "0543-4124";
            this.lbDetailNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtp
            // 
            this.dtp.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp.Location = new System.Drawing.Point(107, 111);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(99, 22);
            this.dtp.TabIndex = 7;
            // 
            // ToolView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.dtp);
            this.Controls.Add(this.lbToolTitle);
            this.Controls.Add(this.lbDetailNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbWeight);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbWorkerName);
            this.Controls.Add(this.lbEmploeeName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbOrderNumber);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ToolView";
            this.Size = new System.Drawing.Size(215, 135);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbToolTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbOrderNumber;
        private System.Windows.Forms.Label lbEmploeeName;
        private System.Windows.Forms.Label lbWorkerName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label lbWeight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbDetailNumber;
        private System.Windows.Forms.DateTimePicker dtp;
    }
}
