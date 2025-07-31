namespace chestionar_auto
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
            components = new System.ComponentModel.Container();
            lblIntrebare = new Label();
            btnInapoi = new Button();
            rbtVarianta1 = new RadioButton();
            rbtVarianta2 = new RadioButton();
            rbtVarianta3 = new RadioButton();
            btnInainte = new Button();
            lblTimer = new Label();
            tmrCountdown = new System.Windows.Forms.Timer(components);
            lblIntrebariRamase = new Label();
            SuspendLayout();
            // 
            // lblIntrebare
            // 
            lblIntrebare.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblIntrebare.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIntrebare.Location = new Point(292, 115);
            lblIntrebare.Name = "lblIntrebare";
            lblIntrebare.Size = new Size(403, 66);
            lblIntrebare.TabIndex = 0;
            lblIntrebare.Text = "Intrebare";
            lblIntrebare.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnInapoi
            // 
            btnInapoi.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInapoi.Location = new Point(12, 545);
            btnInapoi.Name = "btnInapoi";
            btnInapoi.Size = new Size(120, 43);
            btnInapoi.TabIndex = 4;
            btnInapoi.Text = "inapoi";
            btnInapoi.UseVisualStyleBackColor = true;
            btnInapoi.Click += btnInapoi_Click;
            // 
            // rbtVarianta1
            // 
            rbtVarianta1.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            rbtVarianta1.Location = new Point(292, 247);
            rbtVarianta1.Name = "rbtVarianta1";
            rbtVarianta1.Size = new Size(403, 52);
            rbtVarianta1.TabIndex = 6;
            rbtVarianta1.Text = "Varianta1";
            rbtVarianta1.UseVisualStyleBackColor = true;
            // 
            // rbtVarianta2
            // 
            rbtVarianta2.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            rbtVarianta2.Location = new Point(292, 305);
            rbtVarianta2.Name = "rbtVarianta2";
            rbtVarianta2.Size = new Size(403, 52);
            rbtVarianta2.TabIndex = 7;
            rbtVarianta2.Text = "Varianta 2";
            rbtVarianta2.UseVisualStyleBackColor = true;
            // 
            // rbtVarianta3
            // 
            rbtVarianta3.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            rbtVarianta3.Location = new Point(292, 363);
            rbtVarianta3.Name = "rbtVarianta3";
            rbtVarianta3.Size = new Size(403, 52);
            rbtVarianta3.TabIndex = 8;
            rbtVarianta3.Text = "Varianta 3";
            rbtVarianta3.UseVisualStyleBackColor = true;
            // 
            // btnInainte
            // 
            btnInainte.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInainte.Location = new Point(896, 545);
            btnInainte.Name = "btnInainte";
            btnInainte.Size = new Size(120, 43);
            btnInainte.TabIndex = 9;
            btnInainte.Text = "inainte";
            btnInainte.UseVisualStyleBackColor = true;
            btnInainte.Click += btnInainte_Click;
            // 
            // lblTimer
            // 
            lblTimer.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTimer.Location = new Point(411, 18);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new Size(175, 69);
            lblTimer.TabIndex = 10;
            lblTimer.Text = "00:00:00";
            lblTimer.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tmrCountdown
            // 
            tmrCountdown.Interval = 1000;
            tmrCountdown.Tick += tmrCountdown_Tick;
            // 
            // lblIntrebariRamase
            // 
            lblIntrebariRamase.AutoSize = true;
            lblIntrebariRamase.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIntrebariRamase.Location = new Point(248, 37);
            lblIntrebariRamase.Name = "lblIntrebariRamase";
            lblIntrebariRamase.Size = new Size(172, 30);
            lblIntrebariRamase.TabIndex = 11;
            lblIntrebariRamase.Text = "intrebari ramase";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1028, 620);
            Controls.Add(lblIntrebariRamase);
            Controls.Add(lblTimer);
            Controls.Add(btnInainte);
            Controls.Add(rbtVarianta3);
            Controls.Add(rbtVarianta2);
            Controls.Add(rbtVarianta1);
            Controls.Add(btnInapoi);
            Controls.Add(lblIntrebare);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblIntrebare;
        private Button btnInapoi;
        private RadioButton rbtVarianta1;
        private RadioButton rbtVarianta2;
        private RadioButton rbtVarianta3;
        private Button btnInainte;
        private Label lblTimer;
        public System.Windows.Forms.Timer tmrCountdown;
        private Label lblIntrebariRamase;
    }
}
