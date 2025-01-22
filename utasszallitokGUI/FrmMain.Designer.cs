namespace utasszallitokGUI
{
    partial class FrmMain
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
            lblRam = new Label();
            lblStatic = new Label();
            tbxRamPressure = new TextBox();
            tbxStaticPressure = new TextBox();
            btnCalculate = new Button();
            lblResult = new Label();
            lbxResult = new ListBox();
            SuspendLayout();
            // 
            // lblRam
            // 
            lblRam.AutoSize = true;
            lblRam.Font = new Font("Segoe UI", 9.75F);
            lblRam.Location = new Point(12, 16);
            lblRam.Name = "lblRam";
            lblRam.Size = new Size(86, 17);
            lblRam.TabIndex = 0;
            lblRam.Text = "Torlónyomás:";
            // 
            // lblStatic
            // 
            lblStatic.AutoSize = true;
            lblStatic.Font = new Font("Segoe UI", 9.75F);
            lblStatic.Location = new Point(12, 63);
            lblStatic.Name = "lblStatic";
            lblStatic.Size = new Size(104, 17);
            lblStatic.TabIndex = 1;
            lblStatic.Text = "Statikus nyomás:";
            // 
            // tbxRamPressure
            // 
            tbxRamPressure.Location = new Point(122, 16);
            tbxRamPressure.Name = "tbxRamPressure";
            tbxRamPressure.Size = new Size(100, 23);
            tbxRamPressure.TabIndex = 2;
            // 
            // tbxStaticPressure
            // 
            tbxStaticPressure.Location = new Point(122, 63);
            tbxStaticPressure.Name = "tbxStaticPressure";
            tbxStaticPressure.Size = new Size(100, 23);
            tbxStaticPressure.TabIndex = 3;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(243, 16);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(108, 72);
            btnCalculate.TabIndex = 4;
            btnCalculate.Text = "Számol";
            btnCalculate.UseVisualStyleBackColor = true;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lblResult.Location = new Point(12, 116);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(82, 17);
            lblResult.TabIndex = 5;
            lblResult.Text = "Eredmények:";
            // 
            // lbxResult
            // 
            lbxResult.FormattingEnabled = true;
            lbxResult.ItemHeight = 15;
            lbxResult.Location = new Point(12, 136);
            lbxResult.Name = "lbxResult";
            lbxResult.Size = new Size(348, 244);
            lbxResult.TabIndex = 6;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(372, 396);
            Controls.Add(lbxResult);
            Controls.Add(lblResult);
            Controls.Add(btnCalculate);
            Controls.Add(tbxStaticPressure);
            Controls.Add(tbxRamPressure);
            Controls.Add(lblStatic);
            Controls.Add(lblRam);
            Name = "FrmMain";
            Text = "Mach-szám kalkulátor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRam;
        private Label lblStatic;
        private TextBox tbxRamPressure;
        private TextBox tbxStaticPressure;
        private Button btnCalculate;
        private Label lblResult;
        private ListBox lbxResult;
    }
}
