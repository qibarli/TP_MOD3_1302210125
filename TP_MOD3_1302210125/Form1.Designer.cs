namespace TP_MOD3_1302210125
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
            this.buttoncek = new System.Windows.Forms.Button();
            this.labelcek1 = new System.Windows.Forms.Label();
            this.textcek1 = new System.Windows.Forms.TextBox();
            this.labelcek2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttoncek
            // 
            this.buttoncek.Location = new System.Drawing.Point(511, 209);
            this.buttoncek.Name = "buttoncek";
            this.buttoncek.Size = new System.Drawing.Size(75, 23);
            this.buttoncek.TabIndex = 0;
            this.buttoncek.Text = "CEK";
            this.buttoncek.UseVisualStyleBackColor = true;
            this.buttoncek.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelcek1
            // 
            this.labelcek1.AutoSize = true;
            this.labelcek1.BackColor = System.Drawing.SystemColors.InfoText;
            this.labelcek1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcek1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelcek1.Location = new System.Drawing.Point(219, 204);
            this.labelcek1.Name = "labelcek1";
            this.labelcek1.Size = new System.Drawing.Size(80, 25);
            this.labelcek1.TabIndex = 1;
            this.labelcek1.Text = "Cobain";
            this.labelcek1.Click += new System.EventHandler(this.labelcek1_Click);
            // 
            // textcek1
            // 
            this.textcek1.Location = new System.Drawing.Point(305, 210);
            this.textcek1.Name = "textcek1";
            this.textcek1.Size = new System.Drawing.Size(190, 20);
            this.textcek1.TabIndex = 2;
            this.textcek1.Text = "Masukin Dongs...";
            // 
            // labelcek2
            // 
            this.labelcek2.AutoSize = true;
            this.labelcek2.BackColor = System.Drawing.SystemColors.InfoText;
            this.labelcek2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcek2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelcek2.Location = new System.Drawing.Point(12, 144);
            this.labelcek2.Name = "labelcek2";
            this.labelcek2.Size = new System.Drawing.Size(0, 31);
            this.labelcek2.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelcek2);
            this.Controls.Add(this.textcek1);
            this.Controls.Add(this.labelcek1);
            this.Controls.Add(this.buttoncek);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttoncek;
        private System.Windows.Forms.Label labelcek1;
        private System.Windows.Forms.TextBox textcek1;
        private System.Windows.Forms.Label labelcek2;
    }
}

