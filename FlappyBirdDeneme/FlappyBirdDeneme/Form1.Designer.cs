namespace FlappyBirdDeneme
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pcboxKuş = new System.Windows.Forms.PictureBox();
            this.pcboxÜstBoru = new System.Windows.Forms.PictureBox();
            this.pcboxZemin = new System.Windows.Forms.PictureBox();
            this.lblSkor = new System.Windows.Forms.Label();
            this.pcboxAltBoru = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.startTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pcboxKuş)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcboxÜstBoru)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcboxZemin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcboxAltBoru)).BeginInit();
            this.SuspendLayout();
            // 
            // pcboxKuş
            // 
            this.pcboxKuş.Image = ((System.Drawing.Image)(resources.GetObject("pcboxKuş.Image")));
            this.pcboxKuş.Location = new System.Drawing.Point(12, 92);
            this.pcboxKuş.Name = "pcboxKuş";
            this.pcboxKuş.Size = new System.Drawing.Size(116, 127);
            this.pcboxKuş.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcboxKuş.TabIndex = 0;
            this.pcboxKuş.TabStop = false;
            this.pcboxKuş.Click += new System.EventHandler(this.pcboxKuş_Click);
            // 
            // pcboxÜstBoru
            // 
            this.pcboxÜstBoru.Image = ((System.Drawing.Image)(resources.GetObject("pcboxÜstBoru.Image")));
            this.pcboxÜstBoru.Location = new System.Drawing.Point(743, 0);
            this.pcboxÜstBoru.Name = "pcboxÜstBoru";
            this.pcboxÜstBoru.Size = new System.Drawing.Size(100, 202);
            this.pcboxÜstBoru.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcboxÜstBoru.TabIndex = 1;
            this.pcboxÜstBoru.TabStop = false;
            // 
            // pcboxZemin
            // 
            this.pcboxZemin.Image = ((System.Drawing.Image)(resources.GetObject("pcboxZemin.Image")));
            this.pcboxZemin.Location = new System.Drawing.Point(-11, 496);
            this.pcboxZemin.Name = "pcboxZemin";
            this.pcboxZemin.Size = new System.Drawing.Size(1050, 90);
            this.pcboxZemin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcboxZemin.TabIndex = 4;
            this.pcboxZemin.TabStop = false;
            // 
            // lblSkor
            // 
            this.lblSkor.AutoSize = true;
            this.lblSkor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSkor.Location = new System.Drawing.Point(859, 445);
            this.lblSkor.Name = "lblSkor";
            this.lblSkor.Size = new System.Drawing.Size(0, 29);
            this.lblSkor.TabIndex = 8;
            // 
            // pcboxAltBoru
            // 
            this.pcboxAltBoru.Image = ((System.Drawing.Image)(resources.GetObject("pcboxAltBoru.Image")));
            this.pcboxAltBoru.Location = new System.Drawing.Point(334, 254);
            this.pcboxAltBoru.Name = "pcboxAltBoru";
            this.pcboxAltBoru.Size = new System.Drawing.Size(100, 245);
            this.pcboxAltBoru.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcboxAltBoru.TabIndex = 9;
            this.pcboxAltBoru.TabStop = false;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvents);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1036, 587);
            this.Controls.Add(this.lblSkor);
            this.Controls.Add(this.pcboxAltBoru);
            this.Controls.Add(this.pcboxZemin);
            this.Controls.Add(this.pcboxÜstBoru);
            this.Controls.Add(this.pcboxKuş);
            this.Name = "Form1";
            this.Text = "Uçan Kaçan Sevilay Oyunu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamekeyisup);
            ((System.ComponentModel.ISupportInitialize)(this.pcboxKuş)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcboxÜstBoru)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcboxZemin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcboxAltBoru)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcboxKuş;
        private System.Windows.Forms.PictureBox pcboxÜstBoru;
        private System.Windows.Forms.PictureBox pcboxZemin;
        private System.Windows.Forms.Label lblSkor;
        private System.Windows.Forms.PictureBox pcboxAltBoru;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Timer startTimer;
    }
}

