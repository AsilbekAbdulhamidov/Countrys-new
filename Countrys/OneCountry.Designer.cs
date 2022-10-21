namespace Countrys
{
    partial class OneCountry
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
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblSHort = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnl1 = new System.Windows.Forms.Panel();
            this.btnAddRegion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCountry.Location = new System.Drawing.Point(34, 32);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(84, 27);
            this.lblCountry.TabIndex = 0;
            this.lblCountry.Text = "label1";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCode.Location = new System.Drawing.Point(34, 120);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(84, 27);
            this.lblCode.TabIndex = 1;
            this.lblCode.Text = "label1";
            // 
            // lblSHort
            // 
            this.lblSHort.AutoSize = true;
            this.lblSHort.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSHort.Location = new System.Drawing.Point(34, 74);
            this.lblSHort.Name = "lblSHort";
            this.lblSHort.Size = new System.Drawing.Size(84, 27);
            this.lblSHort.TabIndex = 2;
            this.lblSHort.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(572, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(302, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pnl1
            // 
            this.pnl1.Location = new System.Drawing.Point(34, 166);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(478, 618);
            this.pnl1.TabIndex = 5;
            // 
            // btnAddRegion
            // 
            this.btnAddRegion.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnAddRegion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddRegion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAddRegion.Location = new System.Drawing.Point(0, 790);
            this.btnAddRegion.Name = "btnAddRegion";
            this.btnAddRegion.Size = new System.Drawing.Size(902, 29);
            this.btnAddRegion.TabIndex = 6;
            this.btnAddRegion.Text = "Add region";
            this.btnAddRegion.UseVisualStyleBackColor = false;
            this.btnAddRegion.Click += new System.EventHandler(this.btnAddRegion_Click);
            // 
            // OneCountry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 819);
            this.Controls.Add(this.btnAddRegion);
            this.Controls.Add(this.pnl1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblSHort);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.lblCountry);
            this.Name = "OneCountry";
            this.Text = "OneCountry";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblCountry;
        private Label lblCode;
        private Label lblSHort;
        private PictureBox pictureBox1;
        private Panel pnl1;
        private Button btnAddRegion;
    }
}