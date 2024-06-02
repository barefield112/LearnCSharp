namespace LearnCSharp
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
            this.btn_increase = new System.Windows.Forms.Button();
            this.lbl_count = new System.Windows.Forms.Label();
            this.btn_decrease = new System.Windows.Forms.Button();
            this.btn_zero = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_increase
            // 
            this.btn_increase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_increase.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_increase.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_increase.Location = new System.Drawing.Point(93, 297);
            this.btn_increase.Name = "btn_increase";
            this.btn_increase.Size = new System.Drawing.Size(205, 45);
            this.btn_increase.TabIndex = 0;
            this.btn_increase.Text = "Increase";
            this.btn_increase.UseVisualStyleBackColor = false;
            this.btn_increase.Click += new System.EventHandler(this.btn_increase_Click);
            // 
            // lbl_count
            // 
            this.lbl_count.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_count.Font = new System.Drawing.Font("Arial Rounded MT Bold", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_count.Location = new System.Drawing.Point(214, 71);
            this.lbl_count.Name = "lbl_count";
            this.lbl_count.Size = new System.Drawing.Size(400, 139);
            this.lbl_count.TabIndex = 1;
            this.lbl_count.Text = "0";
            this.lbl_count.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_decrease
            // 
            this.btn_decrease.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_decrease.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_decrease.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_decrease.Location = new System.Drawing.Point(313, 297);
            this.btn_decrease.Name = "btn_decrease";
            this.btn_decrease.Size = new System.Drawing.Size(205, 45);
            this.btn_decrease.TabIndex = 2;
            this.btn_decrease.Text = "Decrease";
            this.btn_decrease.UseVisualStyleBackColor = false;
            this.btn_decrease.Click += new System.EventHandler(this.btn_decrease_Click);
            // 
            // btn_zero
            // 
            this.btn_zero.BackColor = System.Drawing.Color.Gray;
            this.btn_zero.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_zero.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_zero.Location = new System.Drawing.Point(533, 297);
            this.btn_zero.Name = "btn_zero";
            this.btn_zero.Size = new System.Drawing.Size(205, 45);
            this.btn_zero.TabIndex = 3;
            this.btn_zero.Text = "Zero Out";
            this.btn_zero.UseVisualStyleBackColor = false;
            this.btn_zero.Click += new System.EventHandler(this.btn_zero_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_zero);
            this.Controls.Add(this.btn_decrease);
            this.Controls.Add(this.lbl_count);
            this.Controls.Add(this.btn_increase);
            this.Name = "Form1";
            this.Text = "Counter App";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_increase;
        private System.Windows.Forms.Label lbl_count;
        private System.Windows.Forms.Button btn_decrease;
        private System.Windows.Forms.Button btn_zero;
    }
}

