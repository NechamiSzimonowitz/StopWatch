namespace Stopwatch {
    partial class Form1 {
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
            this.start = new System.Windows.Forms.Label();
            this.stop = new System.Windows.Forms.Label();
            this.restart = new System.Windows.Forms.Label();
            this.counter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.AutoSize = true;
            this.start.Location = new System.Drawing.Point(164, 300);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(40, 20);
            this.start.TabIndex = 0;
            this.start.Text = "Start";
            this.start.Click += new System.EventHandler(this.StartClick);
            // 
            // stop
            // 
            this.stop.AutoSize = true;
            this.stop.Location = new System.Drawing.Point(358, 300);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(40, 20);
            this.stop.TabIndex = 1;
            this.stop.Text = "Stop";
            this.stop.Click += new System.EventHandler(this.Stopclick);
            // 
            // restart
            // 
            this.restart.AutoSize = true;
            this.restart.Location = new System.Drawing.Point(534, 300);
            this.restart.Name = "restart";
            this.restart.Size = new System.Drawing.Size(55, 20);
            this.restart.TabIndex = 2;
            this.restart.Text = "Restart";
            this.restart.Click += new System.EventHandler(this.Restartclick);
            // 
            // counter
            // 
            this.counter.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.counter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.counter.Location = new System.Drawing.Point(190, 43);
            this.counter.Name = "counter";
            this.counter.Size = new System.Drawing.Size(380, 200);
            this.counter.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.counter);
            this.Controls.Add(this.restart);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.start);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label start;
        private Label stop;
        private Label restart;
        private Label counter;
    }
}