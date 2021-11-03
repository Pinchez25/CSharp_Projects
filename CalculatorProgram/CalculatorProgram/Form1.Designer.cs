namespace WindowsFormsApplication1
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
            this.lblNum = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.lblNum2 = new System.Windows.Forms.Label();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblFirst = new System.Windows.Forms.Label();
            this.lblOp = new System.Windows.Forms.Label();
            this.lblSec = new System.Windows.Forms.Label();
            this.lblEq = new System.Windows.Forms.Label();
            this.lblAns = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum.Location = new System.Drawing.Point(81, 68);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(154, 25);
            this.lblNum.TabIndex = 0;
            this.lblNum.Text = "First Number:";
            this.lblNum.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Maroon;
            this.btnAdd.Location = new System.Drawing.Point(54, 251);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(119, 42);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(245, 69);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(188, 20);
            this.txtNum1.TabIndex = 2;
            this.txtNum1.TextChanged += new System.EventHandler(this.txtNum1_TextChanged);
            // 
            // lblNum2
            // 
            this.lblNum2.AutoSize = true;
            this.lblNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum2.Location = new System.Drawing.Point(49, 141);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(186, 25);
            this.lblNum2.TabIndex = 3;
            this.lblNum2.Text = "Second Number:";
            // 
            // btnDiv
            // 
            this.btnDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiv.ForeColor = System.Drawing.Color.Maroon;
            this.btnDiv.Location = new System.Drawing.Point(471, 251);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(119, 42);
            this.btnDiv.TabIndex = 4;
            this.btnDiv.Text = "Divide";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // btnSub
            // 
            this.btnSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSub.ForeColor = System.Drawing.Color.Maroon;
            this.btnSub.Location = new System.Drawing.Point(337, 251);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(119, 42);
            this.btnSub.TabIndex = 5;
            this.btnSub.Text = "Subtract";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiply.ForeColor = System.Drawing.Color.Maroon;
            this.btnMultiply.Location = new System.Drawing.Point(212, 251);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(119, 42);
            this.btnMultiply.TabIndex = 6;
            this.btnMultiply.Text = "Multiply";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(245, 146);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(188, 20);
            this.txtNum2.TabIndex = 7;
            this.txtNum2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.White;
            this.lblResult.Location = new System.Drawing.Point(528, 69);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 37);
            this.lblResult.TabIndex = 8;
            this.lblResult.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblFirst
            // 
            this.lblFirst.AutoSize = true;
            this.lblFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirst.Location = new System.Drawing.Point(49, 207);
            this.lblFirst.Name = "lblFirst";
            this.lblFirst.Size = new System.Drawing.Size(0, 25);
            this.lblFirst.TabIndex = 9;
            // 
            // lblOp
            // 
            this.lblOp.AutoSize = true;
            this.lblOp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOp.Location = new System.Drawing.Point(134, 207);
            this.lblOp.Name = "lblOp";
            this.lblOp.Size = new System.Drawing.Size(0, 25);
            this.lblOp.TabIndex = 10;
            // 
            // lblSec
            // 
            this.lblSec.AutoSize = true;
            this.lblSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSec.Location = new System.Drawing.Point(213, 207);
            this.lblSec.Name = "lblSec";
            this.lblSec.Size = new System.Drawing.Size(0, 25);
            this.lblSec.TabIndex = 11;
            // 
            // lblEq
            // 
            this.lblEq.AutoSize = true;
            this.lblEq.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEq.Location = new System.Drawing.Point(299, 207);
            this.lblEq.Name = "lblEq";
            this.lblEq.Size = new System.Drawing.Size(0, 25);
            this.lblEq.TabIndex = 12;
            // 
            // lblAns
            // 
            this.lblAns.AutoSize = true;
            this.lblAns.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAns.Location = new System.Drawing.Point(390, 207);
            this.lblAns.Name = "lblAns";
            this.lblAns.Size = new System.Drawing.Size(0, 25);
            this.lblAns.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 321);
            this.Controls.Add(this.lblAns);
            this.Controls.Add(this.lblEq);
            this.Controls.Add(this.lblSec);
            this.Controls.Add(this.lblOp);
            this.Controls.Add(this.lblFirst);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.lblNum2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblNum);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.Label lblNum2;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblFirst;
        private System.Windows.Forms.Label lblOp;
        private System.Windows.Forms.Label lblSec;
        private System.Windows.Forms.Label lblEq;
        private System.Windows.Forms.Label lblAns;
    }
}

