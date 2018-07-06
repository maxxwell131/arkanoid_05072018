namespace arkanoid_05072018
{
    partial class FormGame
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
            this.labelTop = new System.Windows.Forms.Label();
            this.labelLeft = new System.Windows.Forms.Label();
            this.labelRight = new System.Windows.Forms.Label();
            this.buttonRacket = new System.Windows.Forms.Button();
            this.ball = new System.Windows.Forms.RadioButton();
            this.brick1 = new System.Windows.Forms.Label();
            this.brick3 = new System.Windows.Forms.Label();
            this.brick5 = new System.Windows.Forms.Label();
            this.brick4 = new System.Windows.Forms.Label();
            this.brick2 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labelTop
            // 
            this.labelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.labelTop.Location = new System.Drawing.Point(0, 0);
            this.labelTop.Name = "labelTop";
            this.labelTop.Size = new System.Drawing.Size(800, 20);
            this.labelTop.TabIndex = 0;
            // 
            // labelLeft
            // 
            this.labelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.labelLeft.Location = new System.Drawing.Point(0, 20);
            this.labelLeft.Name = "labelLeft";
            this.labelLeft.Size = new System.Drawing.Size(20, 410);
            this.labelLeft.TabIndex = 2;
            // 
            // labelRight
            // 
            this.labelRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.labelRight.Location = new System.Drawing.Point(780, 20);
            this.labelRight.Name = "labelRight";
            this.labelRight.Size = new System.Drawing.Size(20, 410);
            this.labelRight.TabIndex = 3;
            // 
            // buttonRacket
            // 
            this.buttonRacket.Enabled = false;
            this.buttonRacket.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRacket.Location = new System.Drawing.Point(375, 430);
            this.buttonRacket.Name = "buttonRacket";
            this.buttonRacket.Size = new System.Drawing.Size(57, 20);
            this.buttonRacket.TabIndex = 4;
            this.buttonRacket.Text = "-------";
            this.buttonRacket.UseVisualStyleBackColor = true;
            // 
            // ball
            // 
            this.ball.AutoSize = true;
            this.ball.Checked = true;
            this.ball.Enabled = false;
            this.ball.Location = new System.Drawing.Point(397, 411);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(14, 13);
            this.ball.TabIndex = 5;
            this.ball.TabStop = true;
            this.ball.UseVisualStyleBackColor = true;
            // 
            // brick1
            // 
            this.brick1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.brick1.Location = new System.Drawing.Point(124, 79);
            this.brick1.Name = "brick1";
            this.brick1.Size = new System.Drawing.Size(90, 20);
            this.brick1.TabIndex = 6;
            // 
            // brick3
            // 
            this.brick3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.brick3.Location = new System.Drawing.Point(342, 162);
            this.brick3.Name = "brick3";
            this.brick3.Size = new System.Drawing.Size(90, 20);
            this.brick3.TabIndex = 7;
            // 
            // brick5
            // 
            this.brick5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.brick5.Location = new System.Drawing.Point(583, 231);
            this.brick5.Name = "brick5";
            this.brick5.Size = new System.Drawing.Size(90, 20);
            this.brick5.TabIndex = 8;
            // 
            // brick4
            // 
            this.brick4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.brick4.Location = new System.Drawing.Point(124, 231);
            this.brick4.Name = "brick4";
            this.brick4.Size = new System.Drawing.Size(90, 20);
            this.brick4.TabIndex = 9;
            // 
            // brick2
            // 
            this.brick2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.brick2.Location = new System.Drawing.Point(583, 79);
            this.brick2.Name = "brick2";
            this.brick2.Size = new System.Drawing.Size(90, 20);
            this.brick2.TabIndex = 10;
            // 
            // timer
            // 
            this.timer.Interval = 25;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.brick2);
            this.Controls.Add(this.brick4);
            this.Controls.Add(this.brick5);
            this.Controls.Add(this.brick3);
            this.Controls.Add(this.brick1);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.buttonRacket);
            this.Controls.Add(this.labelRight);
            this.Controls.Add(this.labelLeft);
            this.Controls.Add(this.labelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGame";
            this.Text = "FormGame";
            this.Shown += new System.EventHandler(this.FormGame_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormGame_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTop;
        private System.Windows.Forms.Label labelLeft;
        private System.Windows.Forms.Label labelRight;
        private System.Windows.Forms.Button buttonRacket;
        private System.Windows.Forms.RadioButton ball;
        private System.Windows.Forms.Label brick1;
        private System.Windows.Forms.Label brick3;
        private System.Windows.Forms.Label brick5;
        private System.Windows.Forms.Label brick4;
        private System.Windows.Forms.Label brick2;
        private System.Windows.Forms.Timer timer;
    }
}