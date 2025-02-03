namespace Kaksi_lomaketta_harjoitus
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
            btnVarmista = new Button();
            textKäyttäjätunnus = new TextBox();
            textSalasana = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnVarmista
            // 
            btnVarmista.Location = new Point(330, 370);
            btnVarmista.Name = "btnVarmista";
            btnVarmista.Size = new Size(112, 34);
            btnVarmista.TabIndex = 0;
            btnVarmista.Text = "Varmista";
            btnVarmista.UseVisualStyleBackColor = true;
            btnVarmista.Click += button1_Click;
            // 
            // textKäyttäjätunnus
            // 
            textKäyttäjätunnus.Location = new Point(315, 198);
            textKäyttäjätunnus.Name = "textKäyttäjätunnus";
            textKäyttäjätunnus.Size = new Size(221, 31);
            textKäyttäjätunnus.TabIndex = 1;
            // 
            // textSalasana
            // 
            textSalasana.Location = new Point(315, 268);
            textSalasana.Name = "textSalasana";
            textSalasana.Size = new Size(221, 31);
            textSalasana.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(171, 204);
            label1.Name = "label1";
            label1.Size = new Size(131, 25);
            label1.TabIndex = 3;
            label1.Text = "KäyttäjäTunnus";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(171, 274);
            label2.Name = "label2";
            label2.Size = new Size(80, 25);
            label2.TabIndex = 4;
            label2.Text = "Salasana";
            label2.Click += label2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(688, 524);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textSalasana);
            Controls.Add(textKäyttäjätunnus);
            Controls.Add(btnVarmista);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVarmista;
        private TextBox textKäyttäjätunnus;
        private TextBox textSalasana;
        private Label label1;
        private Label label2;
    }
}