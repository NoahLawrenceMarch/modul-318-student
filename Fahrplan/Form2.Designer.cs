namespace Fahrplan
{
    partial class Form2
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
            this.btn_cancel_exit = new System.Windows.Forms.Button();
            this.btn_confitm_exit = new System.Windows.Forms.Button();
            this.lbl_confirm_exit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_cancel_exit
            // 
            this.btn_cancel_exit.Location = new System.Drawing.Point(203, 81);
            this.btn_cancel_exit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cancel_exit.Name = "btn_cancel_exit";
            this.btn_cancel_exit.Size = new System.Drawing.Size(100, 28);
            this.btn_cancel_exit.TabIndex = 5;
            this.btn_cancel_exit.Text = "Nein";
            this.btn_cancel_exit.UseVisualStyleBackColor = true;
            this.btn_cancel_exit.Click += new System.EventHandler(this.btn_cancel_exit_Click);
            // 
            // btn_confitm_exit
            // 
            this.btn_confitm_exit.Location = new System.Drawing.Point(95, 81);
            this.btn_confitm_exit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_confitm_exit.Name = "btn_confitm_exit";
            this.btn_confitm_exit.Size = new System.Drawing.Size(100, 28);
            this.btn_confitm_exit.TabIndex = 4;
            this.btn_confitm_exit.Text = "Ja";
            this.btn_confitm_exit.UseVisualStyleBackColor = true;
            this.btn_confitm_exit.Click += new System.EventHandler(this.btn_confitm_exit_Click);
            // 
            // lbl_confirm_exit
            // 
            this.lbl_confirm_exit.AutoSize = true;
            this.lbl_confirm_exit.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_confirm_exit.Location = new System.Drawing.Point(90, 18);
            this.lbl_confirm_exit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_confirm_exit.Name = "lbl_confirm_exit";
            this.lbl_confirm_exit.Size = new System.Drawing.Size(226, 29);
            this.lbl_confirm_exit.TabIndex = 3;
            this.lbl_confirm_exit.Text = "Anwendung schliessen?";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 172);
            this.Controls.Add(this.btn_cancel_exit);
            this.Controls.Add(this.btn_confitm_exit);
            this.Controls.Add(this.lbl_confirm_exit);
            this.Name = "Form2";
            this.Text = "Anwendung schliessen";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cancel_exit;
        private System.Windows.Forms.Button btn_confitm_exit;
        private System.Windows.Forms.Label lbl_confirm_exit;
    }
}