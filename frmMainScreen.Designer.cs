namespace BradescoTest
{
    partial class frmMainScreen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlTitle = new Panel();
            btnDate = new Button();
            btnConvert = new Button();
            btnList = new Button();
            btnEvenOrOdd = new Button();
            pnlEvenOrOdd = new Panel();
            btnToCheckEvenOrOdd = new Button();
            txtNumber = new TextBox();
            lblNumber = new Label();
            pnlDate = new Panel();
            btnToCheckDate = new Button();
            mskDate = new MaskedTextBox();
            lblData = new Label();
            pnlConvert = new Panel();
            cmbTemp = new ComboBox();
            txtConvertFor = new Label();
            btnToCheckConvert = new Button();
            txtCelsius = new TextBox();
            lblCelsius = new Label();
            pnlList = new Panel();
            lblListReturn = new Label();
            btnToCheckList = new Button();
            lblList = new Label();
            pnlTitle.SuspendLayout();
            pnlEvenOrOdd.SuspendLayout();
            pnlDate.SuspendLayout();
            pnlConvert.SuspendLayout();
            pnlList.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTitle
            // 
            pnlTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlTitle.BorderStyle = BorderStyle.FixedSingle;
            pnlTitle.Controls.Add(btnDate);
            pnlTitle.Controls.Add(btnConvert);
            pnlTitle.Controls.Add(btnList);
            pnlTitle.Controls.Add(btnEvenOrOdd);
            pnlTitle.Location = new Point(12, 12);
            pnlTitle.Name = "pnlTitle";
            pnlTitle.Size = new Size(776, 85);
            pnlTitle.TabIndex = 0;
            // 
            // btnDate
            // 
            btnDate.Location = new Point(232, 3);
            btnDate.Name = "btnDate";
            btnDate.Size = new Size(109, 77);
            btnDate.TabIndex = 3;
            btnDate.Text = "Data";
            btnDate.UseVisualStyleBackColor = true;
            btnDate.Click += btnDate_Click;
            // 
            // btnConvert
            // 
            btnConvert.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnConvert.Location = new Point(443, 3);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(109, 77);
            btnConvert.TabIndex = 2;
            btnConvert.Text = "Converter temperaturas";
            btnConvert.UseVisualStyleBackColor = true;
            btnConvert.Click += btnConvert_Click;
            // 
            // btnList
            // 
            btnList.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnList.Location = new Point(664, 3);
            btnList.Name = "btnList";
            btnList.Size = new Size(109, 77);
            btnList.TabIndex = 1;
            btnList.Text = "Lista";
            btnList.UseVisualStyleBackColor = true;
            btnList.Click += btnList_Click;
            // 
            // btnEvenOrOdd
            // 
            btnEvenOrOdd.Location = new Point(3, 3);
            btnEvenOrOdd.Name = "btnEvenOrOdd";
            btnEvenOrOdd.Size = new Size(109, 77);
            btnEvenOrOdd.TabIndex = 0;
            btnEvenOrOdd.Text = "Par ou ímpar";
            btnEvenOrOdd.UseVisualStyleBackColor = true;
            btnEvenOrOdd.Click += btnEvenOrOdd_Click;
            // 
            // pnlEvenOrOdd
            // 
            pnlEvenOrOdd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlEvenOrOdd.Controls.Add(btnToCheckEvenOrOdd);
            pnlEvenOrOdd.Controls.Add(txtNumber);
            pnlEvenOrOdd.Controls.Add(lblNumber);
            pnlEvenOrOdd.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            pnlEvenOrOdd.Location = new Point(12, 114);
            pnlEvenOrOdd.Name = "pnlEvenOrOdd";
            pnlEvenOrOdd.Size = new Size(417, 100);
            pnlEvenOrOdd.TabIndex = 1;
            pnlEvenOrOdd.Visible = false;
            // 
            // btnToCheckEvenOrOdd
            // 
            btnToCheckEvenOrOdd.Location = new Point(288, 38);
            btnToCheckEvenOrOdd.Name = "btnToCheckEvenOrOdd";
            btnToCheckEvenOrOdd.Size = new Size(102, 27);
            btnToCheckEvenOrOdd.TabIndex = 2;
            btnToCheckEvenOrOdd.Text = "Verificar";
            btnToCheckEvenOrOdd.UseVisualStyleBackColor = true;
            btnToCheckEvenOrOdd.Click += btnToCheckEvenOrOdd_Click;
            // 
            // txtNumber
            // 
            txtNumber.Location = new Point(173, 38);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(100, 26);
            txtNumber.TabIndex = 1;
            // 
            // lblNumber
            // 
            lblNumber.AutoSize = true;
            lblNumber.Location = new Point(22, 41);
            lblNumber.Name = "lblNumber";
            lblNumber.Size = new Size(145, 20);
            lblNumber.TabIndex = 0;
            lblNumber.Text = "Entre com um número:";
            // 
            // pnlDate
            // 
            pnlDate.Controls.Add(btnToCheckDate);
            pnlDate.Controls.Add(mskDate);
            pnlDate.Controls.Add(lblData);
            pnlDate.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            pnlDate.Location = new Point(12, 220);
            pnlDate.Name = "pnlDate";
            pnlDate.Size = new Size(417, 100);
            pnlDate.TabIndex = 2;
            pnlDate.Visible = false;
            // 
            // btnToCheckDate
            // 
            btnToCheckDate.Location = new Point(288, 37);
            btnToCheckDate.Name = "btnToCheckDate";
            btnToCheckDate.Size = new Size(102, 27);
            btnToCheckDate.TabIndex = 3;
            btnToCheckDate.Text = "Verificar";
            btnToCheckDate.UseVisualStyleBackColor = true;
            btnToCheckDate.Click += btnToCheckDate_Click;
            // 
            // mskDate
            // 
            mskDate.Location = new Point(173, 38);
            mskDate.Mask = "00/00/0000";
            mskDate.Name = "mskDate";
            mskDate.Size = new Size(100, 26);
            mskDate.TabIndex = 1;
            mskDate.ValidatingType = typeof(DateTime);
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Location = new Point(22, 41);
            lblData.Name = "lblData";
            lblData.Size = new Size(133, 20);
            lblData.TabIndex = 0;
            lblData.Text = "Entre com uma Data:";
            // 
            // pnlConvert
            // 
            pnlConvert.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlConvert.Controls.Add(cmbTemp);
            pnlConvert.Controls.Add(txtConvertFor);
            pnlConvert.Controls.Add(btnToCheckConvert);
            pnlConvert.Controls.Add(txtCelsius);
            pnlConvert.Controls.Add(lblCelsius);
            pnlConvert.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            pnlConvert.Location = new Point(12, 326);
            pnlConvert.Name = "pnlConvert";
            pnlConvert.Size = new Size(664, 100);
            pnlConvert.TabIndex = 3;
            pnlConvert.Visible = false;
            // 
            // cmbTemp
            // 
            cmbTemp.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTemp.FormattingEnabled = true;
            cmbTemp.Items.AddRange(new object[] { "Kelvin", "Fahrenheit" });
            cmbTemp.Location = new Point(413, 38);
            cmbTemp.Name = "cmbTemp";
            cmbTemp.Size = new Size(121, 28);
            cmbTemp.TabIndex = 4;
            // 
            // txtConvertFor
            // 
            txtConvertFor.AutoSize = true;
            txtConvertFor.Location = new Point(312, 41);
            txtConvertFor.Name = "txtConvertFor";
            txtConvertFor.Size = new Size(95, 20);
            txtConvertFor.TabIndex = 3;
            txtConvertFor.Text = "converter para";
            // 
            // btnToCheckConvert
            // 
            btnToCheckConvert.Location = new Point(550, 39);
            btnToCheckConvert.Name = "btnToCheckConvert";
            btnToCheckConvert.Size = new Size(102, 27);
            btnToCheckConvert.TabIndex = 2;
            btnToCheckConvert.Text = "Converter";
            btnToCheckConvert.UseVisualStyleBackColor = true;
            btnToCheckConvert.Click += btnToCheckConvert_Click;
            // 
            // txtCelsius
            // 
            txtCelsius.Location = new Point(186, 41);
            txtCelsius.Name = "txtCelsius";
            txtCelsius.Size = new Size(100, 26);
            txtCelsius.TabIndex = 1;
            // 
            // lblCelsius
            // 
            lblCelsius.AutoSize = true;
            lblCelsius.Location = new Point(22, 41);
            lblCelsius.Name = "lblCelsius";
            lblCelsius.Size = new Size(158, 20);
            lblCelsius.TabIndex = 0;
            lblCelsius.Text = "Temperatura Celsius (°C)";
            // 
            // pnlList
            // 
            pnlList.Controls.Add(lblListReturn);
            pnlList.Controls.Add(btnToCheckList);
            pnlList.Controls.Add(lblList);
            pnlList.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            pnlList.Location = new Point(435, 114);
            pnlList.Name = "pnlList";
            pnlList.Size = new Size(353, 206);
            pnlList.TabIndex = 4;
            pnlList.Visible = false;
            // 
            // lblListReturn
            // 
            lblListReturn.AutoSize = true;
            lblListReturn.Location = new Point(21, 131);
            lblListReturn.Name = "lblListReturn";
            lblListReturn.Size = new Size(0, 20);
            lblListReturn.TabIndex = 4;
            // 
            // btnToCheckList
            // 
            btnToCheckList.Location = new Point(125, 90);
            btnToCheckList.Name = "btnToCheckList";
            btnToCheckList.Size = new Size(102, 27);
            btnToCheckList.TabIndex = 3;
            btnToCheckList.Text = "Converter";
            btnToCheckList.UseVisualStyleBackColor = true;
            btnToCheckList.Click += btnToCheckList_Click;
            // 
            // lblList
            // 
            lblList.AutoSize = true;
            lblList.Location = new Point(21, 41);
            lblList.Name = "lblList";
            lblList.Size = new Size(296, 20);
            lblList.TabIndex = 0;
            lblList.Text = "Lista: [ -34, 77, -89, -25, -19, 14, -20, 46, -32, 91 ]";
            // 
            // frmMainScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlList);
            Controls.Add(pnlConvert);
            Controls.Add(pnlDate);
            Controls.Add(pnlEvenOrOdd);
            Controls.Add(pnlTitle);
            MinimumSize = new Size(816, 489);
            Name = "frmMainScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bradesco - Test";
            pnlTitle.ResumeLayout(false);
            pnlEvenOrOdd.ResumeLayout(false);
            pnlEvenOrOdd.PerformLayout();
            pnlDate.ResumeLayout(false);
            pnlDate.PerformLayout();
            pnlConvert.ResumeLayout(false);
            pnlConvert.PerformLayout();
            pnlList.ResumeLayout(false);
            pnlList.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTitle;
        private Button btnDate;
        private Button btnConvert;
        private Button btnList;
        private Button btnEvenOrOdd;
        private TextBox txtNumber;
        private Label lblNumber;
        private Button btnToCheckEvenOrOdd;
        public Panel pnlEvenOrOdd;
        public Panel pnlDate;
        private Label lblData;
        private Button btnToCheckDate;
        public Panel pnlConvert;
        private Label txtConvertFor;
        private Button btnToCheckConvert;
        private Label lblCelsius;
        private Label lblList;
        private Button btnToCheckList;
        public Panel pnlList;
        public ComboBox cmbTemp;
        public TextBox txtCelsius;
        public MaskedTextBox mskDate;
        public Label lblListReturn;
    }
}
