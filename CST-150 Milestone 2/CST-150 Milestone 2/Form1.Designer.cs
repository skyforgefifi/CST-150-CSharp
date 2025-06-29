namespace CST_150_Milestone_2
{
    partial class Milestone2
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
            btnShowInventory = new Button();
            lblInventoryOutput = new Label();
            SuspendLayout();
            // 
            // btnShowInventory
            // 
            btnShowInventory.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnShowInventory.Location = new Point(317, 52);
            btnShowInventory.Name = "btnShowInventory";
            btnShowInventory.Size = new Size(142, 70);
            btnShowInventory.TabIndex = 0;
            btnShowInventory.Text = "Show Inventory";
            btnShowInventory.UseVisualStyleBackColor = true;
            btnShowInventory.Click += btnShowInventoryClick;
            // 
            // lblInventoryOutput
            // 
            lblInventoryOutput.AutoSize = true;
            lblInventoryOutput.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInventoryOutput.Location = new Point(243, 209);
            lblInventoryOutput.Name = "lblInventoryOutput";
            lblInventoryOutput.Size = new Size(70, 25);
            lblInventoryOutput.TabIndex = 1;
            lblInventoryOutput.Text = "label1";
            lblInventoryOutput.Click += lblInventoryOutput_Click;
            // 
            // Milestone2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblInventoryOutput);
            Controls.Add(btnShowInventory);
            Name = "Milestone2";
            Text = "Milestone2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnShowInventory;
        private Label lblInventoryOutput;
    }
}
