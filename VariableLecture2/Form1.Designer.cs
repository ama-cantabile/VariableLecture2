
namespace VariableLecture2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.firstNameInput = new System.Windows.Forms.TextBox();
            this.outputText = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.Label();
            this.lastNameInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(405, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(271, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "&First Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "당신이 입력한 이름은";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(317, 230);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Read Input";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // firstNameInput
            // 
            this.firstNameInput.Location = new System.Drawing.Point(405, 69);
            this.firstNameInput.Name = "firstNameInput";
            this.firstNameInput.Size = new System.Drawing.Size(100, 23);
            this.firstNameInput.TabIndex = 1;
            // 
            // outputText
            // 
            this.outputText.Location = new System.Drawing.Point(405, 137);
            this.outputText.Name = "outputText";
            this.outputText.ReadOnly = true;
            this.outputText.Size = new System.Drawing.Size(100, 23);
            this.outputText.TabIndex = 5;
            this.outputText.TabStop = false;
            // 
            // lastName
            // 
            this.lastName.AutoSize = true;
            this.lastName.Location = new System.Drawing.Point(271, 109);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(66, 15);
            this.lastName.TabIndex = 2;
            this.lastName.Text = "L&ast Name:";
            // 
            // lastNameInput
            // 
            this.lastNameInput.Location = new System.Drawing.Point(405, 101);
            this.lastNameInput.Name = "lastNameInput";
            this.lastNameInput.Size = new System.Drawing.Size(100, 23);
            this.lastNameInput.TabIndex = 3;
            // 
            // Form1
            // 
            this.AcceptButton = this.button2;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lastNameInput);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.outputText);
            this.Controls.Add(this.firstNameInput);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox firstNameInput;
        private System.Windows.Forms.TextBox outputText;
        private System.Windows.Forms.Label lastName;
        private System.Windows.Forms.TextBox lastNameInput;
    }
}

