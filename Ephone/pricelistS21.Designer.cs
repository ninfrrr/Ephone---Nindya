
namespace Ephone
{
    partial class pricelistS21
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
            this.bt21 = new System.Windows.Forms.Button();
            this.bt21p = new System.Windows.Forms.Button();
            this.bt21u = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bt21
            // 
            this.bt21.Location = new System.Drawing.Point(68, 324);
            this.bt21.Name = "bt21";
            this.bt21.Size = new System.Drawing.Size(130, 91);
            this.bt21.TabIndex = 3;
            this.bt21.Text = "S21";
            this.bt21.UseVisualStyleBackColor = true;
            this.bt21.Click += new System.EventHandler(this.bt21_Click);
            // 
            // bt21p
            // 
            this.bt21p.Location = new System.Drawing.Point(460, 324);
            this.bt21p.Name = "bt21p";
            this.bt21p.Size = new System.Drawing.Size(130, 91);
            this.bt21p.TabIndex = 4;
            this.bt21p.Text = "S21+";
            this.bt21p.UseVisualStyleBackColor = true;
            this.bt21p.Click += new System.EventHandler(this.bt21p_Click);
            // 
            // bt21u
            // 
            this.bt21u.Location = new System.Drawing.Point(819, 324);
            this.bt21u.Name = "bt21u";
            this.bt21u.Size = new System.Drawing.Size(130, 91);
            this.bt21u.TabIndex = 5;
            this.bt21u.Text = "S21 Ultra";
            this.bt21u.UseVisualStyleBackColor = true;
            this.bt21u.Click += new System.EventHandler(this.bt21u_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Ephone.Properties.Resources.s21u;
            this.pictureBox3.Location = new System.Drawing.Point(746, 94);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(255, 203);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Ephone.Properties.Resources.s21p;
            this.pictureBox2.Location = new System.Drawing.Point(378, 90);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(268, 207);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Ephone.Properties.Resources.s21;
            this.pictureBox1.Location = new System.Drawing.Point(12, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(229, 207);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pricelistS21
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 450);
            this.Controls.Add(this.bt21u);
            this.Controls.Add(this.bt21p);
            this.Controls.Add(this.bt21);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "pricelistS21";
            this.Text = "pricelistS21";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button bt21;
        private System.Windows.Forms.Button bt21p;
        private System.Windows.Forms.Button bt21u;
    }
}