namespace Shapes
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnsquare = new System.Windows.Forms.Button();
            this.btnCircle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(172, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "Rectangle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnsquare
            // 
            this.btnsquare.Location = new System.Drawing.Point(326, 83);
            this.btnsquare.Name = "btnsquare";
            this.btnsquare.Size = new System.Drawing.Size(101, 36);
            this.btnsquare.TabIndex = 1;
            this.btnsquare.Text = "Square";
            this.btnsquare.UseVisualStyleBackColor = true;
            this.btnsquare.Click += new System.EventHandler(this.btnsquare_Click);
            // 
            // btnCircle
            // 
            this.btnCircle.Location = new System.Drawing.Point(13, 83);
            this.btnCircle.Name = "btnCircle";
            this.btnCircle.Size = new System.Drawing.Size(106, 36);
            this.btnCircle.TabIndex = 2;
            this.btnCircle.Text = "Circle";
            this.btnCircle.UseVisualStyleBackColor = true;
            this.btnCircle.Click += new System.EventHandler(this.btnCircle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 232);
            this.Controls.Add(this.btnCircle);
            this.Controls.Add(this.btnsquare);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnsquare;
        private System.Windows.Forms.Button btnCircle;
    }
}

