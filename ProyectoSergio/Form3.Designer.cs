namespace ProyectoSergio
{
    partial class frmLlamada
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
            this.btnLlamada = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLlamada
            // 
            this.btnLlamada.BackColor = System.Drawing.SystemColors.Control;
            this.btnLlamada.BackgroundImage = global::ProyectoSergio.Properties.Resources.png_clipart_end_call_button_telephone_call_button_computer_icons_button_text_trademark;
            this.btnLlamada.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLlamada.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLlamada.FlatAppearance.BorderSize = 0;
            this.btnLlamada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLlamada.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLlamada.Location = new System.Drawing.Point(356, 179);
            this.btnLlamada.Margin = new System.Windows.Forms.Padding(0);
            this.btnLlamada.Name = "btnLlamada";
            this.btnLlamada.Size = new System.Drawing.Size(75, 80);
            this.btnLlamada.TabIndex = 0;
            this.btnLlamada.UseVisualStyleBackColor = false;
            this.btnLlamada.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmLlamada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLlamada);
            this.Name = "frmLlamada";
            this.Text = "Llamando...";
            this.Load += new System.EventHandler(this.frmLlamada_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLlamada;
    }
}