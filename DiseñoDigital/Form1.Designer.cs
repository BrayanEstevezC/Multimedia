namespace DiseñoDigital
{
    partial class View
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View));
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.lblTitle = new System.Windows.Forms.Label();
            this.YT = new System.Windows.Forms.PictureBox();
            this.SP = new System.Windows.Forms.PictureBox();
            this.FIGURE = new System.Windows.Forms.PictureBox();
            this.Home = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pReproductor2 = new System.Windows.Forms.Panel();
            this.Files = new System.Windows.Forms.PictureBox();
            this.lblRut = new System.Windows.Forms.Label();
            this.Pause = new System.Windows.Forms.PictureBox();
            this.Stop = new System.Windows.Forms.PictureBox();
            this.Play = new System.Windows.Forms.PictureBox();
            this.Reproductor = new AxWMPLib.AxWindowsMediaPlayer();
            this.panelDibujo = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FIGURE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Home)).BeginInit();
            this.pReproductor2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Files)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Play)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reproductor)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Consolas", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitle.Location = new System.Drawing.Point(88, 26);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(726, 56);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Multimedia y diseño digital";
            // 
            // YT
            // 
            this.YT.BackColor = System.Drawing.Color.Transparent;
            this.YT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.YT.Image = global::DiseñoDigital.Properties.Resources.youtube;
            this.YT.Location = new System.Drawing.Point(146, 384);
            this.YT.Name = "YT";
            this.YT.Size = new System.Drawing.Size(113, 99);
            this.YT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.YT.TabIndex = 1;
            this.YT.TabStop = false;
            this.YT.Click += new System.EventHandler(this.YT_Click);
            this.YT.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.YT.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // SP
            // 
            this.SP.BackColor = System.Drawing.Color.Transparent;
            this.SP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SP.Image = global::DiseñoDigital.Properties.Resources.Spotify_icon;
            this.SP.Location = new System.Drawing.Point(331, 389);
            this.SP.Name = "SP";
            this.SP.Size = new System.Drawing.Size(99, 94);
            this.SP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SP.TabIndex = 2;
            this.SP.TabStop = false;
            this.SP.Click += new System.EventHandler(this.SP_Click);
            this.SP.MouseEnter += new System.EventHandler(this.SP_MouseEnter);
            this.SP.MouseHover += new System.EventHandler(this.SP_MouseLeave);
            // 
            // FIGURE
            // 
            this.FIGURE.BackColor = System.Drawing.Color.Transparent;
            this.FIGURE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FIGURE.Image = global::DiseñoDigital.Properties.Resources.figuras1;
            this.FIGURE.Location = new System.Drawing.Point(508, 389);
            this.FIGURE.Name = "FIGURE";
            this.FIGURE.Size = new System.Drawing.Size(122, 94);
            this.FIGURE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FIGURE.TabIndex = 3;
            this.FIGURE.TabStop = false;
            this.FIGURE.Click += new System.EventHandler(this.FIGURE_Click);
            this.FIGURE.MouseEnter += new System.EventHandler(this.FG_MouseEnter);
            this.FIGURE.MouseLeave += new System.EventHandler(this.FG_MouseLeave);
            // 
            // Home
            // 
            this.Home.BackColor = System.Drawing.Color.Transparent;
            this.Home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Home.Image = global::DiseñoDigital.Properties.Resources.home;
            this.Home.Location = new System.Drawing.Point(8, 16);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(74, 66);
            this.Home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Home.TabIndex = 4;
            this.Home.TabStop = false;
            this.Home.Visible = false;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pReproductor2
            // 
            this.pReproductor2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pReproductor2.Controls.Add(this.Files);
            this.pReproductor2.Controls.Add(this.lblRut);
            this.pReproductor2.Controls.Add(this.Pause);
            this.pReproductor2.Controls.Add(this.Stop);
            this.pReproductor2.Controls.Add(this.Play);
            this.pReproductor2.Controls.Add(this.Reproductor);
            this.pReproductor2.Location = new System.Drawing.Point(8, 88);
            this.pReproductor2.Name = "pReproductor2";
            this.pReproductor2.Size = new System.Drawing.Size(856, 428);
            this.pReproductor2.TabIndex = 7;
            this.pReproductor2.Visible = false;
            // 
            // Files
            // 
            this.Files.BackColor = System.Drawing.Color.Transparent;
            this.Files.Image = global::DiseñoDigital.Properties.Resources.File;
            this.Files.Location = new System.Drawing.Point(523, 365);
            this.Files.Name = "Files";
            this.Files.Size = new System.Drawing.Size(61, 50);
            this.Files.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Files.TabIndex = 7;
            this.Files.TabStop = false;
            this.Files.Click += new System.EventHandler(this.Files_Click_1);
            // 
            // lblRut
            // 
            this.lblRut.AutoSize = true;
            this.lblRut.Font = new System.Drawing.Font("Consolas", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRut.Location = new System.Drawing.Point(0, 333);
            this.lblRut.Name = "lblRut";
            this.lblRut.Size = new System.Drawing.Size(58, 24);
            this.lblRut.TabIndex = 6;
            this.lblRut.Text = "Ruta";
            this.lblRut.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Pause
            // 
            this.Pause.BackColor = System.Drawing.Color.Transparent;
            this.Pause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pause.Image = global::DiseñoDigital.Properties.Resources.pause;
            this.Pause.Location = new System.Drawing.Point(449, 365);
            this.Pause.Name = "Pause";
            this.Pause.Size = new System.Drawing.Size(54, 50);
            this.Pause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pause.TabIndex = 3;
            this.Pause.TabStop = false;
            this.Pause.Click += new System.EventHandler(this.Pause_Click);
            // 
            // Stop
            // 
            this.Stop.BackColor = System.Drawing.Color.Transparent;
            this.Stop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Stop.Image = global::DiseñoDigital.Properties.Resources.stop;
            this.Stop.Location = new System.Drawing.Point(309, 365);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(51, 50);
            this.Stop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Stop.TabIndex = 2;
            this.Stop.TabStop = false;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // Play
            // 
            this.Play.BackColor = System.Drawing.Color.Transparent;
            this.Play.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Play.Image = global::DiseñoDigital.Properties.Resources.play;
            this.Play.Location = new System.Drawing.Point(378, 365);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(54, 50);
            this.Play.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Play.TabIndex = 1;
            this.Play.TabStop = false;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // Reproductor
            // 
            this.Reproductor.Enabled = true;
            this.Reproductor.Location = new System.Drawing.Point(0, 0);
            this.Reproductor.Name = "Reproductor";
            this.Reproductor.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Reproductor.OcxState")));
            this.Reproductor.Size = new System.Drawing.Size(856, 333);
            this.Reproductor.TabIndex = 0;
            // 
            // panelDibujo
            // 
            this.panelDibujo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelDibujo.Location = new System.Drawing.Point(8, 91);
            this.panelDibujo.Name = "panelDibujo";
            this.panelDibujo.Size = new System.Drawing.Size(856, 431);
            this.panelDibujo.TabIndex = 8;
            this.panelDibujo.Visible = false;
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(876, 525);
            this.Controls.Add(this.panelDibujo);
            this.Controls.Add(this.pReproductor2);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.FIGURE);
            this.Controls.Add(this.SP);
            this.Controls.Add(this.YT);
            this.Controls.Add(this.lblTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "View";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FIGURE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Home)).EndInit();
            this.pReproductor2.ResumeLayout(false);
            this.pReproductor2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Files)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Play)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reproductor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox YT;
        private System.Windows.Forms.PictureBox SP;
        private System.Windows.Forms.PictureBox FIGURE;
        private System.Windows.Forms.PictureBox Home;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel pReproductor2;
        private System.Windows.Forms.PictureBox Files;
        private System.Windows.Forms.Label lblRut;
        private System.Windows.Forms.PictureBox Pause;
        private System.Windows.Forms.PictureBox Stop;
        private System.Windows.Forms.PictureBox Play;
        private AxWMPLib.AxWindowsMediaPlayer Reproductor;
        private System.Windows.Forms.Panel panelDibujo;
    }
}

