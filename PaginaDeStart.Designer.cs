namespace chestionar_auto
{
    partial class PaginaDeStart
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
            lblPaginaStart = new Label();
            lblProbaTeoretica = new Label();
            btnStartExamen = new Button();
            SuspendLayout();
            // 
            // lblPaginaStart
            // 
            lblPaginaStart.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblPaginaStart.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblPaginaStart.Location = new Point(177, 36);
            lblPaginaStart.Name = "lblPaginaStart";
            lblPaginaStart.Size = new Size(408, 87);
            lblPaginaStart.TabIndex = 0;
            lblPaginaStart.Text = "Examen Auto";
            lblPaginaStart.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblProbaTeoretica
            // 
            lblProbaTeoretica.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblProbaTeoretica.Location = new Point(364, 97);
            lblProbaTeoretica.Name = "lblProbaTeoretica";
            lblProbaTeoretica.Size = new Size(178, 50);
            lblProbaTeoretica.TabIndex = 1;
            lblProbaTeoretica.Text = "Proba Teoretica";
            // 
            // btnStartExamen
            // 
            btnStartExamen.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStartExamen.Location = new Point(319, 224);
            btnStartExamen.Name = "btnStartExamen";
            btnStartExamen.Size = new Size(167, 90);
            btnStartExamen.TabIndex = 2;
            btnStartExamen.Text = "Star Examen";
            btnStartExamen.UseVisualStyleBackColor = true;
            btnStartExamen.Click += btnStartExamen_Click;
            // 
            // PaginaDeStart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnStartExamen);
            Controls.Add(lblProbaTeoretica);
            Controls.Add(lblPaginaStart);
            Name = "PaginaDeStart";
            Text = "PaginaDeStart";
            ResumeLayout(false);
        }

        #endregion

        private Label lblPaginaStart;
        private Label lblProbaTeoretica;
        private Button btnStartExamen;
    }
}