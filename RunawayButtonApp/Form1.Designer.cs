namespace RunawayButtonApp
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
            RunawayButton = new Button();
            YesButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(100, 28);
            label1.Name = "label1";
            label1.Size = new Size(607, 57);
            label1.TabIndex = 0;
            label1.Text = "Чи подобається вам ДТЕУ?";
            // 
            // RunawayButton
            // 
            RunawayButton.BackColor = Color.Red;
            RunawayButton.FlatAppearance.BorderColor = Color.Black;
            RunawayButton.FlatStyle = FlatStyle.Flat;
            RunawayButton.Font = new Font("Microsoft Sans Serif", 8.25F);
            RunawayButton.Location = new Point(151, 215);
            RunawayButton.Name = "RunawayButton";
            RunawayButton.Size = new Size(175, 66);
            RunawayButton.TabIndex = 1;
            RunawayButton.Text = "Ні 👎";
            RunawayButton.UseVisualStyleBackColor = false;
            RunawayButton.Click += RunawayButton_Click;
            RunawayButton.MouseMove += RunawayButton_MouseMove;
            // 
            // YesButton
            // 
            YesButton.BackColor = Color.PaleGreen;
            YesButton.FlatAppearance.BorderColor = Color.Black;
            YesButton.FlatStyle = FlatStyle.Flat;
            YesButton.Location = new Point(470, 215);
            YesButton.Name = "YesButton";
            YesButton.Size = new Size(175, 66);
            YesButton.TabIndex = 2;
            YesButton.Text = "Так 👍";
            YesButton.UseVisualStyleBackColor = true;
            YesButton.Click += YesButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(YesButton);
            Controls.Add(RunawayButton);
            Controls.Add(label1);
            Name = "Form1";
            Text = "NotManipulation";
            ResumeLayout(false);
            PerformLayout();
        }

        private void Run(object sender, MouseEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label label1;
        private Button RunawayButton;
        private Button YesButton;
    }
}
