namespace LearnCSharp
{
    partial class calc_app
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
            this.lbl_output = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_minus = new System.Windows.Forms.Button();
            this.btn_multiply = new System.Windows.Forms.Button();
            this.btn_divide = new System.Windows.Forms.Button();
            this.txtBox_input1 = new System.Windows.Forms.TextBox();
            this.txtBox_input2 = new System.Windows.Forms.TextBox();
            this.btn_equals = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_output
            // 
            this.lbl_output.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_output.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_output.Location = new System.Drawing.Point(20, 23);
            this.lbl_output.Name = "lbl_output";
            this.lbl_output.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.lbl_output.Size = new System.Drawing.Size(350, 50);
            this.lbl_output.TabIndex = 0;
            this.lbl_output.Text = "0";
            this.lbl_output.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.GhostWhite;
            this.btn_add.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(27, 172);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(74, 60);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "+";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_minus
            // 
            this.btn_minus.BackColor = System.Drawing.Color.GhostWhite;
            this.btn_minus.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_minus.Location = new System.Drawing.Point(116, 172);
            this.btn_minus.Name = "btn_minus";
            this.btn_minus.Size = new System.Drawing.Size(74, 60);
            this.btn_minus.TabIndex = 2;
            this.btn_minus.Text = "-";
            this.btn_minus.UseVisualStyleBackColor = false;
            this.btn_minus.Click += new System.EventHandler(this.btn_minus_Click);
            // 
            // btn_multiply
            // 
            this.btn_multiply.BackColor = System.Drawing.Color.GhostWhite;
            this.btn_multiply.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_multiply.Location = new System.Drawing.Point(205, 172);
            this.btn_multiply.Name = "btn_multiply";
            this.btn_multiply.Size = new System.Drawing.Size(74, 60);
            this.btn_multiply.TabIndex = 3;
            this.btn_multiply.Text = "*";
            this.btn_multiply.UseVisualStyleBackColor = false;
            this.btn_multiply.Click += new System.EventHandler(this.btn_multiply_Click);
            // 
            // btn_divide
            // 
            this.btn_divide.BackColor = System.Drawing.Color.GhostWhite;
            this.btn_divide.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_divide.Location = new System.Drawing.Point(296, 172);
            this.btn_divide.Name = "btn_divide";
            this.btn_divide.Size = new System.Drawing.Size(74, 60);
            this.btn_divide.TabIndex = 4;
            this.btn_divide.Text = "/";
            this.btn_divide.UseVisualStyleBackColor = false;
            this.btn_divide.Click += new System.EventHandler(this.btn_divide_Click);
            // 
            // txtBox_input1
            // 
            this.txtBox_input1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_input1.Location = new System.Drawing.Point(61, 104);
            this.txtBox_input1.Name = "txtBox_input1";
            this.txtBox_input1.Size = new System.Drawing.Size(262, 39);
            this.txtBox_input1.TabIndex = 5;
            this.txtBox_input1.Text = "0";
            this.txtBox_input1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtBox_input2
            // 
            this.txtBox_input2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_input2.Location = new System.Drawing.Point(61, 260);
            this.txtBox_input2.Name = "txtBox_input2";
            this.txtBox_input2.Size = new System.Drawing.Size(262, 39);
            this.txtBox_input2.TabIndex = 6;
            this.txtBox_input2.Text = "0";
            this.txtBox_input2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_equals
            // 
            this.btn_equals.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_equals.Location = new System.Drawing.Point(100, 336);
            this.btn_equals.Name = "btn_equals";
            this.btn_equals.Size = new System.Drawing.Size(179, 51);
            this.btn_equals.TabIndex = 7;
            this.btn_equals.Text = "=";
            this.btn_equals.UseVisualStyleBackColor = true;
            this.btn_equals.Click += new System.EventHandler(this.btn_equals_Click);
            // 
            // calc_app
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 453);
            this.Controls.Add(this.btn_equals);
            this.Controls.Add(this.txtBox_input2);
            this.Controls.Add(this.txtBox_input1);
            this.Controls.Add(this.btn_divide);
            this.Controls.Add(this.btn_multiply);
            this.Controls.Add(this.btn_minus);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.lbl_output);
            this.Name = "calc_app";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_output;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_minus;
        private System.Windows.Forms.Button btn_multiply;
        private System.Windows.Forms.Button btn_divide;
        private System.Windows.Forms.TextBox txtBox_input1;
        private System.Windows.Forms.TextBox txtBox_input2;
        private System.Windows.Forms.Button btn_equals;
    }
}