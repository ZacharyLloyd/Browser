namespace Star_Wars_Browser
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.Browser = new System.Windows.Forms.WebBrowser();
            this.LoadWebsite = new System.Windows.Forms.Button();
            this.URL = new System.Windows.Forms.TextBox();
            this.URL_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Browser
            // 
            this.Browser.Location = new System.Drawing.Point(0, 80);
            this.Browser.MinimumSize = new System.Drawing.Size(20, 20);
            this.Browser.Name = "Browser";
            this.Browser.Size = new System.Drawing.Size(799, 371);
            this.Browser.TabIndex = 0;
            // 
            // LoadWebsite
            // 
            this.LoadWebsite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadWebsite.Location = new System.Drawing.Point(12, 24);
            this.LoadWebsite.Name = "LoadWebsite";
            this.LoadWebsite.Size = new System.Drawing.Size(88, 41);
            this.LoadWebsite.TabIndex = 1;
            this.LoadWebsite.Text = "Go";
            this.LoadWebsite.UseVisualStyleBackColor = true;
            this.LoadWebsite.Click += new System.EventHandler(this.LoadWebsite_Click);
            // 
            // URL
            // 
            this.URL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.URL.Location = new System.Drawing.Point(152, 36);
            this.URL.Name = "URL";
            this.URL.Size = new System.Drawing.Size(375, 22);
            this.URL.TabIndex = 2;
            // 
            // URL_Label
            // 
            this.URL_Label.AutoSize = true;
            this.URL_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.URL_Label.Location = new System.Drawing.Point(152, 13);
            this.URL_Label.Name = "URL_Label";
            this.URL_Label.Size = new System.Drawing.Size(145, 16);
            this.URL_Label.TabIndex = 3;
            this.URL_Label.Text = "Search the Jedi Library";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.URL_Label);
            this.Controls.Add(this.URL);
            this.Controls.Add(this.LoadWebsite);
            this.Controls.Add(this.Browser);
            this.Name = "FormMain";
            this.Text = "Star Wars Browser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser Browser;
        private System.Windows.Forms.Button LoadWebsite;
        private System.Windows.Forms.TextBox URL;
        private System.Windows.Forms.Label URL_Label;
    }
}

