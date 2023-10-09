using ClassLibrary1;

namespace WinFormsApp1
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
            label1 = new Label();
            FirstName = new TextBox();
            LastName = new TextBox();
            label2 = new Label();
            Phone = new TextBox();
            label3 = new Label();
            Email = new TextBox();
            label4 = new Label();
            Save = new Button();
            ErrorMessage = new Label();
            PlaceOfResidenceTextBox = new TextBox();
            label5 = new Label();
            label6 = new Label();
            GenderComboBox = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 29);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 0;
            label1.Text = "First Name";
            // 
            // FirstName
            // 
            FirstName.Location = new Point(30, 50);
            FirstName.Margin = new Padding(1);
            FirstName.Name = "FirstName";
            FirstName.Size = new Size(228, 23);
            FirstName.TabIndex = 1;
            // 
            // LastName
            // 
            LastName.Location = new Point(30, 108);
            LastName.Margin = new Padding(1);
            LastName.Name = "LastName";
            LastName.Size = new Size(228, 23);
            LastName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 86);
            label2.Margin = new Padding(1, 0, 1, 0);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 2;
            label2.Text = "Last Name";
            // 
            // Phone
            // 
            Phone.Location = new Point(30, 224);
            Phone.Margin = new Padding(1);
            Phone.Name = "Phone";
            Phone.Size = new Size(228, 23);
            Phone.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 202);
            label3.Margin = new Padding(1, 0, 1, 0);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 6;
            label3.Text = "Phone";
            // 
            // Email
            // 
            Email.Location = new Point(30, 167);
            Email.Margin = new Padding(1);
            Email.Name = "Email";
            Email.Size = new Size(228, 23);
            Email.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 145);
            label4.Margin = new Padding(1, 0, 1, 0);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 4;
            label4.Text = "Email";
            // 
            // Save
            // 
            Save.Location = new Point(181, 396);
            Save.Margin = new Padding(1);
            Save.Name = "Save";
            Save.Size = new Size(77, 21);
            Save.TabIndex = 8;
            Save.Text = "Save";
            Save.UseVisualStyleBackColor = true;
            Save.Click += Save_Click;
            // 
            // ErrorMessage
            // 
            ErrorMessage.AutoSize = true;
            ErrorMessage.ForeColor = Color.Red;
            ErrorMessage.Location = new Point(30, 426);
            ErrorMessage.Margin = new Padding(1, 0, 1, 0);
            ErrorMessage.Name = "ErrorMessage";
            ErrorMessage.Size = new Size(0, 15);
            ErrorMessage.TabIndex = 9;
            // 
            // PlaceOfResidenceTextBox
            // 
            PlaceOfResidenceTextBox.Location = new Point(30, 282);
            PlaceOfResidenceTextBox.Margin = new Padding(1);
            PlaceOfResidenceTextBox.Name = "PlaceOfResidenceTextBox";
            PlaceOfResidenceTextBox.Size = new Size(228, 23);
            PlaceOfResidenceTextBox.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 260);
            label5.Margin = new Padding(1, 0, 1, 0);
            label5.Name = "label5";
            label5.Size = new Size(102, 15);
            label5.TabIndex = 10;
            label5.Text = "Place of residence";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(30, 319);
            label6.Margin = new Padding(1, 0, 1, 0);
            label6.Name = "label6";
            label6.Size = new Size(48, 15);
            label6.TabIndex = 12;
            label6.Text = "Gender";
            // 
            // GenderComboBox
            // 
            GenderComboBox.FormattingEnabled = true;
            GenderComboBox.Location = new Point(30, 337);
            GenderComboBox.Name = "GenderComboBox";
            GenderComboBox.Size = new Size(228, 23);
            GenderComboBox.TabIndex = 13;
            GenderComboBox.DataSource = Enum.GetValues(typeof(Gender));
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(329, 565);
            Controls.Add(GenderComboBox);
            Controls.Add(label6);
            Controls.Add(PlaceOfResidenceTextBox);
            Controls.Add(label5);
            Controls.Add(ErrorMessage);
            Controls.Add(Save);
            Controls.Add(Phone);
            Controls.Add(label3);
            Controls.Add(Email);
            Controls.Add(label4);
            Controls.Add(LastName);
            Controls.Add(label2);
            Controls.Add(FirstName);
            Controls.Add(label1);
            Margin = new Padding(1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox FirstName;
        private TextBox LastName;
        private Label label2;
        private TextBox Phone;
        private Label label3;
        private TextBox Email;
        private Label label4;
        private Button Save;
        private Label ErrorMessage;
        private TextBox PlaceOfResidenceTextBox;
        private Label label5;
        private Label label6;
        private ComboBox GenderComboBox;
    }
}