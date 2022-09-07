namespace Shapes
{
    partial class CircleMenu
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
            this.lblRadius = new System.Windows.Forms.Label();
            this.txtRadius = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCompute = new System.Windows.Forms.Button();
            this.lblcircumference = new System.Windows.Forms.Label();
            this.lblarea = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblRadius
            // 
            this.lblRadius.AutoSize = true;
            this.lblRadius.Location = new System.Drawing.Point(26, 25);
            this.lblRadius.Name = "lblRadius";
            this.lblRadius.Size = new System.Drawing.Size(53, 16);
            this.lblRadius.TabIndex = 0;
            this.lblRadius.Text = "Radius:";
            // 
            // txtRadius
            // 
            this.txtRadius.Location = new System.Drawing.Point(29, 44);
            this.txtRadius.Name = "txtRadius";
            this.txtRadius.Size = new System.Drawing.Size(100, 22);
            this.txtRadius.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(231, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Circumference:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(288, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Area:";
            // 
            // btnCompute
            // 
            this.btnCompute.Location = new System.Drawing.Point(29, 98);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(171, 44);
            this.btnCompute.TabIndex = 4;
            this.btnCompute.Text = "Compute";
            this.btnCompute.UseVisualStyleBackColor = true;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // lblcircumference
            // 
            this.lblcircumference.AutoSize = true;
            this.lblcircumference.Location = new System.Drawing.Point(333, 44);
            this.lblcircumference.Name = "lblcircumference";
            this.lblcircumference.Size = new System.Drawing.Size(14, 16);
            this.lblcircumference.TabIndex = 5;
            this.lblcircumference.Text = "0";
            this.lblcircumference.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblarea
            // 
            this.lblarea.AutoSize = true;
            this.lblarea.Location = new System.Drawing.Point(333, 89);
            this.lblarea.Name = "lblarea";
            this.lblarea.Size = new System.Drawing.Size(14, 16);
            this.lblarea.TabIndex = 6;
            this.lblarea.Text = "0";
            // 
            // CircleMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 163);
            this.Controls.Add(this.lblarea);
            this.Controls.Add(this.lblcircumference);
            this.Controls.Add(this.btnCompute);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRadius);
            this.Controls.Add(this.lblRadius);
            this.Name = "CircleMenu";
            this.Text = "CircleMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRadius;
        private System.Windows.Forms.TextBox txtRadius;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.Label lblcircumference;
        private System.Windows.Forms.Label lblarea;
    }
}