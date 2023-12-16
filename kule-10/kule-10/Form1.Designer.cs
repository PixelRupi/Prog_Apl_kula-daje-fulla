namespace kule_10
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel_scena = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button_start = new System.Windows.Forms.Button();
            this.button_add_kula = new System.Windows.Forms.Button();
            this.button_sub_kula = new System.Windows.Forms.Button();
            this.button_CHINA = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel_scena
            // 
            this.panel_scena.Location = new System.Drawing.Point(12, 12);
            this.panel_scena.Name = "panel_scena";
            this.panel_scena.Size = new System.Drawing.Size(776, 426);
            this.panel_scena.TabIndex = 0;
            // 
            // button_start
            // 
            this.button_start.BackColor = System.Drawing.Color.Lime;
            this.button_start.Location = new System.Drawing.Point(794, 12);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(102, 57);
            this.button_start.TabIndex = 1;
            this.button_start.Text = "START";
            this.button_start.UseVisualStyleBackColor = false;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // button_add_kula
            // 
            this.button_add_kula.Location = new System.Drawing.Point(794, 191);
            this.button_add_kula.Name = "button_add_kula";
            this.button_add_kula.Size = new System.Drawing.Size(102, 41);
            this.button_add_kula.TabIndex = 0;
            this.button_add_kula.Text = "Kula++";
            this.button_add_kula.UseVisualStyleBackColor = true;
            this.button_add_kula.Click += new System.EventHandler(this.button_add_kula_Click);
            // 
            // button_sub_kula
            // 
            this.button_sub_kula.Location = new System.Drawing.Point(794, 238);
            this.button_sub_kula.Name = "button_sub_kula";
            this.button_sub_kula.Size = new System.Drawing.Size(102, 41);
            this.button_sub_kula.TabIndex = 4;
            this.button_sub_kula.Text = "Kula--";
            this.button_sub_kula.UseVisualStyleBackColor = true;
            this.button_sub_kula.Click += new System.EventHandler(this.button_sub_kula_Click);
            // 
            // button_CHINA
            // 
            this.button_CHINA.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_CHINA.BackgroundImage")));
            this.button_CHINA.Location = new System.Drawing.Point(796, 338);
            this.button_CHINA.Name = "button_CHINA";
            this.button_CHINA.Size = new System.Drawing.Size(100, 100);
            this.button_CHINA.TabIndex = 5;
            this.button_CHINA.UseVisualStyleBackColor = true;
            this.button_CHINA.Click += new System.EventHandler(this.button_CHINA_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 450);
            this.Controls.Add(this.button_CHINA);
            this.Controls.Add(this.button_sub_kula);
            this.Controls.Add(this.button_add_kula);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.panel_scena);
            this.Name = "Form1";
            this.Text = "Ballin\'";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_scena;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Button button_add_kula;
        private System.Windows.Forms.Button button_sub_kula;
        private System.Windows.Forms.Button button_CHINA;
    }
}

