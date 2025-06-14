namespace CST_150_Activity_1
{
    partial class Form1
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
            lblEarth = new Label();
            txtEarthWeight = new TextBox();
            lblMars = new Label();
            lblMarsWeight = new Label();
            btnConvert = new Button();
            lblLbs = new Label();
            SuspendLayout();
            // 
            // lblEarth
            // 
            lblEarth.AutoSize = true;
            lblEarth.BackColor = SystemColors.ActiveCaption;
            lblEarth.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEarth.Location = new Point(66, 117);
            lblEarth.Name = "lblEarth";
            lblEarth.Size = new Size(189, 18);
            lblEarth.TabIndex = 0;
            lblEarth.Text = "Enter your weight on Earth";
            lblEarth.Click += lblEarth_Click;
            // 
            // txtEarthWeight
            // 
            txtEarthWeight.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEarthWeight.Location = new Point(261, 112);
            txtEarthWeight.Name = "txtEarthWeight";
            txtEarthWeight.Size = new Size(100, 26);
            txtEarthWeight.TabIndex = 1;
            txtEarthWeight.TextChanged += textBox1_TextChanged;
            // 
            // lblMars
            // 
            lblMars.AutoSize = true;
            lblMars.BackColor = SystemColors.ActiveCaption;
            lblMars.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMars.Location = new Point(93, 183);
            lblMars.Name = "lblMars";
            lblMars.Size = new Size(147, 18);
            lblMars.TabIndex = 2;
            lblMars.Text = "Your weight on Mars";
            lblMars.Click += label1_Click;
            // 
            // lblMarsWeight
            // 
            lblMarsWeight.AutoSize = true;
            lblMarsWeight.Location = new Point(257, 183);
            lblMarsWeight.Name = "lblMarsWeight";
            lblMarsWeight.Size = new Size(38, 15);
            lblMarsWeight.TabIndex = 3;
            lblMarsWeight.Text = "label2";
            // 
            // btnConvert
            // 
            btnConvert.BackColor = SystemColors.ActiveCaption;
            btnConvert.Location = new Point(322, 272);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(75, 23);
            btnConvert.TabIndex = 4;
            btnConvert.Text = "Convert";
            btnConvert.UseVisualStyleBackColor = false;
            btnConvert.Click += ConvertButtonClickEvent;
            // 
            // lblLbs
            // 
            lblLbs.AutoSize = true;
            lblLbs.Location = new Point(367, 123);
            lblLbs.Name = "lblLbs";
            lblLbs.Size = new Size(22, 15);
            lblLbs.TabIndex = 5;
            lblLbs.Text = "lbs";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblLbs);
            Controls.Add(btnConvert);
            Controls.Add(lblMarsWeight);
            Controls.Add(lblMars);
            Controls.Add(txtEarthWeight);
            Controls.Add(lblEarth);
            Name = "Form1";
            Text = "Your Weight On Mars";
            Load += lblMars_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEarth;
        private TextBox txtEarthWeight;
        private Label lblMars;
        private Label lblMarsWeight;
        private Button btnConvert;
        private Label lblLbs;
    }
}
