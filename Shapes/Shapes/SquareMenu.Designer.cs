namespace Shapes
{
    partial class SquareMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtsides = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtsqArea = new System.Windows.Forms.TextBox();
            this.txtsqPeri = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCompute = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(260, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input Sides:";
            // 
            // txtsides
            // 
            this.txtsides.Location = new System.Drawing.Point(236, 28);
            this.txtsides.Name = "txtsides";
            this.txtsides.Size = new System.Drawing.Size(100, 22);
            this.txtsides.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Area:";
            // 
            // txtsqArea
            // 
            this.txtsqArea.Location = new System.Drawing.Point(12, 47);
            this.txtsqArea.Name = "txtsqArea";
            this.txtsqArea.Size = new System.Drawing.Size(100, 22);
            this.txtsqArea.TabIndex = 3;
            // 
            // txtsqPeri
            // 
            this.txtsqPeri.Location = new System.Drawing.Point(15, 106);
            this.txtsqPeri.Name = "txtsqPeri";
            this.txtsqPeri.Size = new System.Drawing.Size(100, 22);
            this.txtsqPeri.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Perimeter:";
            // 
            // btnCompute
            // 
            this.btnCompute.Location = new System.Drawing.Point(236, 175);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(75, 32);
            this.btnCompute.TabIndex = 6;
            this.btnCompute.Text = "Compute";
            this.btnCompute.UseVisualStyleBackColor = true;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // SquareMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 233);
            this.Controls.Add(this.btnCompute);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtsqPeri);
            this.Controls.Add(this.txtsqArea);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtsides);
            this.Controls.Add(this.label1);
            this.Name = "SquareMenu";
            this.Text = "SquareMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsides;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtsqArea;
        private System.Windows.Forms.TextBox txtsqPeri;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCompute;
    }
}