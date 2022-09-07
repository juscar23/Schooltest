namespace Shapes
{
    partial class RectangleMenu
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
            this.txtlength = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtwidth = new System.Windows.Forms.TextBox();
            this.txtPerimeter = new System.Windows.Forms.TextBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.btnCompute = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(284, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Length:";
            // 
            // txtlength
            // 
            this.txtlength.Location = new System.Drawing.Point(261, 44);
            this.txtlength.Name = "txtlength";
            this.txtlength.Size = new System.Drawing.Size(100, 22);
            this.txtlength.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(284, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Width:";
            // 
            // txtwidth
            // 
            this.txtwidth.Location = new System.Drawing.Point(261, 105);
            this.txtwidth.Name = "txtwidth";
            this.txtwidth.Size = new System.Drawing.Size(100, 22);
            this.txtwidth.TabIndex = 3;
            // 
            // txtPerimeter
            // 
            this.txtPerimeter.Location = new System.Drawing.Point(53, 150);
            this.txtPerimeter.Name = "txtPerimeter";
            this.txtPerimeter.Size = new System.Drawing.Size(175, 22);
            this.txtPerimeter.TabIndex = 4;
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(53, 192);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(175, 22);
            this.txtArea.TabIndex = 5;
            // 
            // btnCompute
            // 
            this.btnCompute.Location = new System.Drawing.Point(104, 238);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(75, 23);
            this.btnCompute.TabIndex = 6;
            this.btnCompute.Text = "Compute";
            this.btnCompute.UseVisualStyleBackColor = true;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Perimeter:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Area:";
            // 
            // RectangleMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 273);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCompute);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.txtPerimeter);
            this.Controls.Add(this.txtwidth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtlength);
            this.Controls.Add(this.label1);
            this.Name = "RectangleMenu";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtlength;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtwidth;
        private System.Windows.Forms.TextBox txtPerimeter;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}