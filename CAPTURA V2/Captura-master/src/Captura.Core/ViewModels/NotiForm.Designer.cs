
namespace lecturadeveu
{
    partial class NotiForm
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
            this.notificacio = new System.Windows.Forms.Label();
            this.timerTancarNoti = new System.Windows.Forms.Timer(this.components);
            this.FadeIn = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // notificacio
            // 
            this.notificacio.AutoSize = true;
            this.notificacio.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notificacio.ForeColor = System.Drawing.Color.White;
            this.notificacio.Location = new System.Drawing.Point(32, 77);
            this.notificacio.Name = "notificacio";
            this.notificacio.Size = new System.Drawing.Size(46, 17);
            this.notificacio.TabIndex = 0;
            this.notificacio.Text = "label1";
            this.notificacio.Click += new System.EventHandler(this.notificacio_Click);
            // 
            // timerTancarNoti
            // 
            this.timerTancarNoti.Interval = 4000;
            this.timerTancarNoti.Tick += new System.EventHandler(this.timerTancarNoti_Tick);
            // 
            // FadeIn
            // 
            this.FadeIn.Interval = 30;
            this.FadeIn.Tick += new System.EventHandler(this.FadeIn_Tick);
            // 
            // NotiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkViolet;
            this.ClientSize = new System.Drawing.Size(310, 113);
            this.Controls.Add(this.notificacio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NotiForm";
            this.Opacity = 0D;
            this.Text = "NotiForm";
            this.Load += new System.EventHandler(this.NotiForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label notificacio;
        private System.Windows.Forms.Timer timerTancarNoti;
        private System.Windows.Forms.Timer FadeIn;
    }
}