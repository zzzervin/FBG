namespace FBG
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.flappybird = new System.Windows.Forms.PictureBox();
            this.pipedown = new System.Windows.Forms.PictureBox();
            this.pipe = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gT = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.flappybird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipedown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            this.SuspendLayout();
            // 
            // flappybird
            // 
            this.flappybird.Image = ((System.Drawing.Image)(resources.GetObject("flappybird.Image")));
            this.flappybird.Location = new System.Drawing.Point(97, 284);
            this.flappybird.Name = "flappybird";
            this.flappybird.Size = new System.Drawing.Size(82, 59);
            this.flappybird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flappybird.TabIndex = 0;
            this.flappybird.TabStop = false;
            // 
            // pipedown
            // 
            this.pipedown.Image = ((System.Drawing.Image)(resources.GetObject("pipedown.Image")));
            this.pipedown.Location = new System.Drawing.Point(467, -6);
            this.pipedown.Name = "pipedown";
            this.pipedown.Size = new System.Drawing.Size(100, 267);
            this.pipedown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipedown.TabIndex = 1;
            this.pipedown.TabStop = false;
            this.pipedown.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pipe
            // 
            this.pipe.Image = ((System.Drawing.Image)(resources.GetObject("pipe.Image")));
            this.pipe.Location = new System.Drawing.Point(434, 412);
            this.pipe.Name = "pipe";
            this.pipe.Size = new System.Drawing.Size(100, 246);
            this.pipe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipe.TabIndex = 2;
            this.pipe.TabStop = false;
            this.pipe.Click += new System.EventHandler(this.pipe_Click);
            // 
            // ground
            // 
            this.ground.Image = ((System.Drawing.Image)(resources.GetObject("ground.Image")));
            this.ground.Location = new System.Drawing.Point(-4, 654);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(802, 87);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 3;
            this.ground.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 45);
            this.label2.TabIndex = 5;
            this.label2.Text = "Score:0";
            // 
            // gT
            // 
            this.gT.Enabled = true;
            this.gT.Interval = 20;
            this.gT.Tick += new System.EventHandler(this.gTEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(793, 738);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.pipe);
            this.Controls.Add(this.pipedown);
            this.Controls.Add(this.flappybird);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gkisd);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gkisu);
            ((System.ComponentModel.ISupportInitialize)(this.flappybird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipedown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox flappybird;
        private System.Windows.Forms.PictureBox pipedown;
        private System.Windows.Forms.PictureBox pipe;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer gT;
    }
}

