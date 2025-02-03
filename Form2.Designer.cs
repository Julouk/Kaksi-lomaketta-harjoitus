namespace Kaksi_lomaketta_harjoitus
{
    partial class Form2
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
            btnKirjauduulos = new Button();
            dataGridView1 = new DataGridView();
            Ruoka = new DataGridViewTextBoxColumn();
            Määrä = new DataGridViewTextBoxColumn();
            Kalorit = new DataGridViewTextBoxColumn();
            Joulet = new DataGridViewTextBoxColumn();
            Yhteensä = new DataGridViewTextBoxColumn();
            labelKT = new Label();
            btnLaske = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnKirjauduulos
            // 
            btnKirjauduulos.Location = new Point(991, 593);
            btnKirjauduulos.Name = "btnKirjauduulos";
            btnKirjauduulos.Size = new Size(158, 34);
            btnKirjauduulos.TabIndex = 0;
            btnKirjauduulos.Text = "Kirjaudu ulos";
            btnKirjauduulos.UseVisualStyleBackColor = true;
            btnKirjauduulos.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Ruoka, Määrä, Kalorit, Joulet, Yhteensä });
            dataGridView1.Location = new Point(300, 183);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(814, 225);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Ruoka
            // 
            Ruoka.HeaderText = "Ruoka-Aineita";
            Ruoka.MinimumWidth = 8;
            Ruoka.Name = "Ruoka";
            Ruoka.Width = 150;
            // 
            // Määrä
            // 
            Määrä.HeaderText = "Määrä";
            Määrä.MinimumWidth = 8;
            Määrä.Name = "Määrä";
            Määrä.Width = 150;
            // 
            // Kalorit
            // 
            Kalorit.HeaderText = "Kalorit";
            Kalorit.MinimumWidth = 8;
            Kalorit.Name = "Kalorit";
            Kalorit.Width = 150;
            // 
            // Joulet
            // 
            Joulet.HeaderText = "Joulet";
            Joulet.MinimumWidth = 8;
            Joulet.Name = "Joulet";
            Joulet.Width = 150;
            // 
            // Yhteensä
            // 
            Yhteensä.HeaderText = "Koko määrä";
            Yhteensä.MinimumWidth = 8;
            Yhteensä.Name = "Yhteensä";
            Yhteensä.Width = 150;
            // 
            // labelKT
            // 
            labelKT.AutoSize = true;
            labelKT.Location = new Point(42, 28);
            labelKT.Name = "labelKT";
            labelKT.Size = new Size(0, 25);
            labelKT.TabIndex = 2;
            // 
            // btnLaske
            // 
            btnLaske.Location = new Point(779, 593);
            btnLaske.Name = "btnLaske";
            btnLaske.Size = new Size(112, 34);
            btnLaske.TabIndex = 3;
            btnLaske.Text = "Laske";
            btnLaske.UseVisualStyleBackColor = true;
            btnLaske.Click += btnLaske_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1292, 693);
            Controls.Add(btnLaske);
            Controls.Add(labelKT);
            Controls.Add(dataGridView1);
            Controls.Add(btnKirjauduulos);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnKirjauduulos;
        private DataGridView dataGridView1;
        private Label labelKT;
        private Button btnLaske;
        private DataGridViewTextBoxColumn Ruoka;
        private DataGridViewTextBoxColumn Määrä;
        private DataGridViewTextBoxColumn Kalorit;
        private DataGridViewTextBoxColumn Joulet;
        private DataGridViewTextBoxColumn Yhteensä;
    }
}