namespace Lampadina
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
            ACCENDI = new Button();
            SPEGNI = new Button();
            accesa = new PictureBox();
            spenta = new PictureBox();
            toolTip1 = new ToolTip(components);
            toolTip2 = new ToolTip(components);
            label1 = new Label();
            su = new Button();
            giu = new Button();
            contapixel = new TextBox();
            toolTip3 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)accesa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)spenta).BeginInit();
            SuspendLayout();
            // 
            // ACCENDI
            // 
            ACCENDI.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ACCENDI.Cursor = Cursors.Hand;
            ACCENDI.Location = new Point(158, 12);
            ACCENDI.Name = "ACCENDI";
            ACCENDI.Size = new Size(169, 97);
            ACCENDI.TabIndex = 0;
            ACCENDI.Text = "ACCENDI";
            ACCENDI.UseVisualStyleBackColor = true;
            ACCENDI.Click += button1_Click;
            // 
            // SPEGNI
            // 
            SPEGNI.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            SPEGNI.Cursor = Cursors.Hand;
            SPEGNI.Location = new Point(158, 115);
            SPEGNI.Name = "SPEGNI";
            SPEGNI.Size = new Size(169, 101);
            SPEGNI.TabIndex = 1;
            SPEGNI.Text = "SPEGNI";
            SPEGNI.UseVisualStyleBackColor = true;
            SPEGNI.Click += button2_Click;
            // 
            // accesa
            // 
            accesa.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            accesa.Cursor = Cursors.No;
            accesa.Image = Properties.Resources.lampadina_accesa;
            accesa.Location = new Point(416, 96);
            accesa.Name = "accesa";
            accesa.Size = new Size(170, 200);
            accesa.TabIndex = 2;
            accesa.TabStop = false;
            toolTip1.SetToolTip(accesa, "accesa");
            // 
            // spenta
            // 
            spenta.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            spenta.Cursor = Cursors.No;
            spenta.Image = Properties.Resources.lampadina_spenta;
            spenta.Location = new Point(416, 96);
            spenta.Name = "spenta";
            spenta.Size = new Size(171, 200);
            spenta.TabIndex = 3;
            spenta.TabStop = false;
            toolTip2.SetToolTip(spenta, "spenta");
            spenta.Click += spenta_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Cursor = Cursors.No;
            label1.Location = new Point(416, 63);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 4;
            label1.Text = "Lampada:";
            label1.Click += label1_Click;
            // 
            // su
            // 
            su.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            su.Cursor = Cursors.Hand;
            su.Location = new Point(158, 222);
            su.Name = "su";
            su.Size = new Size(169, 106);
            su.TabIndex = 5;
            su.Text = "ALZA";
            su.UseVisualStyleBackColor = true;
            su.Click += su_Click;
            // 
            // giu
            // 
            giu.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            giu.Cursor = Cursors.Hand;
            giu.Location = new Point(158, 334);
            giu.Name = "giu";
            giu.Size = new Size(169, 104);
            giu.TabIndex = 6;
            giu.Text = "ABBASSA";
            giu.UseVisualStyleBackColor = true;
            giu.Click += giu_Click;
            // 
            // contapixel
            // 
            contapixel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            contapixel.Cursor = Cursors.No;
            contapixel.Location = new Point(416, 302);
            contapixel.Name = "contapixel";
            contapixel.Size = new Size(241, 27);
            contapixel.TabIndex = 7;
            toolTip3.SetToolTip(contapixel, "tengo conto degli spostamenti");
            contapixel.TextChanged += contapixel_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(contapixel);
            Controls.Add(giu);
            Controls.Add(su);
            Controls.Add(label1);
            Controls.Add(spenta);
            Controls.Add(accesa);
            Controls.Add(SPEGNI);
            Controls.Add(ACCENDI);
            Name = "Form1";
            Text = "Lampadina";
            ((System.ComponentModel.ISupportInitialize)accesa).EndInit();
            ((System.ComponentModel.ISupportInitialize)spenta).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ACCENDI;
        private Button SPEGNI;
        private PictureBox accesa;
        private PictureBox spenta;
        private ToolTip toolTip1;
        private ToolTip toolTip2;
        private Label label1;
        private Button su;
        private Button giu;
        private TextBox contapixel;
        private ToolTip toolTip3;
    }
}
