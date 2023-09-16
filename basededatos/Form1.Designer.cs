namespace basededatos
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
            listView1 = new ListView();
            label1 = new Label();
            label2 = new Label();
            txtId = new TextBox();
            txtNombre = new TextBox();
            btninsertar = new Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Location = new Point(780, 0);
            listView1.Name = "listView1";
            listView1.Size = new Size(151, 121);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(158, 66);
            label1.Name = "label1";
            label1.Size = new Size(94, 20);
            label1.TabIndex = 1;
            label1.Text = "Identificador";
           // label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(410, 66);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 2;
            label2.Text = "Nombre";
            // 
            // txtId
            // 
            txtId.Location = new Point(158, 94);
            txtId.Name = "txtId";
            txtId.Size = new Size(125, 27);
            txtId.TabIndex = 3;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(374, 94);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(228, 27);
            txtNombre.TabIndex = 4;
            // 
            // btninsertar
            // 
            btninsertar.Location = new Point(660, 92);
            btninsertar.Name = "btninsertar";
            btninsertar.Size = new Size(94, 29);
            btninsertar.TabIndex = 5;
            btninsertar.Text = "Insertar";
            btninsertar.UseVisualStyleBackColor = true;
            btninsertar.Click += btnInsertar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btninsertar);
            Controls.Add(txtNombre);
            Controls.Add(txtId);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private Label label1;
        private Label label2;
        private TextBox txtId;
        private TextBox txtNombre;
        private Button btninsertar;
    }
}