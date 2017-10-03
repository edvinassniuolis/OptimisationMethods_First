namespace OptimisationMethods_First
{
    partial class mainForm
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
            this.intervalDivButton = new System.Windows.Forms.Button();
            this.goldenDivButton = new System.Windows.Forms.Button();
            this.newtonButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // intervalDivButton
            // 
            this.intervalDivButton.Location = new System.Drawing.Point(65, 44);
            this.intervalDivButton.Name = "intervalDivButton";
            this.intervalDivButton.Size = new System.Drawing.Size(148, 23);
            this.intervalDivButton.TabIndex = 0;
            this.intervalDivButton.Text = "Intervalo dalijimo pusiau f(x)";
            this.intervalDivButton.UseVisualStyleBackColor = true;
            this.intervalDivButton.Click += new System.EventHandler(this.intervalDivButton_Click);
            // 
            // goldenDivButton
            // 
            this.goldenDivButton.Location = new System.Drawing.Point(65, 91);
            this.goldenDivButton.Name = "goldenDivButton";
            this.goldenDivButton.Size = new System.Drawing.Size(148, 23);
            this.goldenDivButton.TabIndex = 1;
            this.goldenDivButton.Text = "Auksinio pjuvio f(x)";
            this.goldenDivButton.UseVisualStyleBackColor = true;
            this.goldenDivButton.Click += new System.EventHandler(this.goldenDivButton_Click);
            // 
            // newtonButton
            // 
            this.newtonButton.Location = new System.Drawing.Point(65, 140);
            this.newtonButton.Name = "newtonButton";
            this.newtonButton.Size = new System.Drawing.Size(148, 23);
            this.newtonButton.TabIndex = 2;
            this.newtonButton.Text = "Niutono f(x)";
            this.newtonButton.UseVisualStyleBackColor = true;
            this.newtonButton.Click += new System.EventHandler(this.newtonButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.Location = new System.Drawing.Point(6, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tikslo f(x): (x^2)/8";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newtonButton);
            this.Controls.Add(this.goldenDivButton);
            this.Controls.Add(this.intervalDivButton);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button intervalDivButton;
        private System.Windows.Forms.Button goldenDivButton;
        private System.Windows.Forms.Button newtonButton;
        private System.Windows.Forms.Label label1;
    }
}

