
namespace tcc
{
    partial class frmLampada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLampada));
            this.btnImagem = new System.Windows.Forms.Button();
            this.imageList = new System.Windows.Forms.ListView();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.cbCamera = new System.Windows.Forms.ComboBox();
            this.picVideo = new System.Windows.Forms.PictureBox();
            this.picFotos = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picVideo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFotos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnImagem
            // 
            this.btnImagem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnImagem.Location = new System.Drawing.Point(705, 10);
            this.btnImagem.Name = "btnImagem";
            this.btnImagem.Size = new System.Drawing.Size(75, 23);
            this.btnImagem.TabIndex = 15;
            this.btnImagem.Text = "imagens";
            this.btnImagem.UseVisualStyleBackColor = false;
            this.btnImagem.Click += new System.EventHandler(this.btnImagem_Click_1);
            // 
            // imageList
            // 
            this.imageList.HideSelection = false;
            this.imageList.Location = new System.Drawing.Point(633, 46);
            this.imageList.Name = "imageList";
            this.imageList.Size = new System.Drawing.Size(211, 330);
            this.imageList.TabIndex = 14;
            this.imageList.UseCompatibleStateImageBehavior = false;
            this.imageList.SelectedIndexChanged += new System.EventHandler(this.imageList_SelectedIndexChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(414, 10);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "salvar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(322, 10);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 9;
            this.btnStart.Text = "iniciar";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click_1);
            // 
            // cbCamera
            // 
            this.cbCamera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCamera.FormattingEnabled = true;
            this.cbCamera.Location = new System.Drawing.Point(12, 12);
            this.cbCamera.Name = "cbCamera";
            this.cbCamera.Size = new System.Drawing.Size(295, 21);
            this.cbCamera.TabIndex = 8;
            this.cbCamera.SelectedIndexChanged += new System.EventHandler(this.cbCamera_SelectedIndexChanged);
            // 
            // picVideo
            // 
            this.picVideo.Location = new System.Drawing.Point(12, 46);
            this.picVideo.Name = "picVideo";
            this.picVideo.Size = new System.Drawing.Size(295, 330);
            this.picVideo.TabIndex = 16;
            this.picVideo.TabStop = false;
            // 
            // picFotos
            // 
            this.picFotos.Location = new System.Drawing.Point(322, 46);
            this.picFotos.Name = "picFotos";
            this.picFotos.Size = new System.Drawing.Size(295, 330);
            this.picFotos.TabIndex = 17;
            this.picFotos.TabStop = false;
            // 
            // frmLampada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 401);
            this.Controls.Add(this.picFotos);
            this.Controls.Add(this.picVideo);
            this.Controls.Add(this.btnImagem);
            this.Controls.Add(this.imageList);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.cbCamera);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLampada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "lampada de fenda";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmLampada_FormClosed);
            this.Load += new System.EventHandler(this.frmVideo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picVideo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFotos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnImagem;
        private System.Windows.Forms.ListView imageList;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ComboBox cbCamera;
        private System.Windows.Forms.PictureBox picVideo;
        private System.Windows.Forms.PictureBox picFotos;
    }
}