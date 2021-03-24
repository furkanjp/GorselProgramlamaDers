
namespace Ders3_ListeKutusu
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
            this.tbMetin = new System.Windows.Forms.TextBox();
            this.lbListe = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // tbMetin
            // 
            this.tbMetin.BackColor = System.Drawing.Color.MistyRose;
            this.tbMetin.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbMetin.Location = new System.Drawing.Point(0, 0);
            this.tbMetin.Name = "tbMetin";
            this.tbMetin.ReadOnly = true;
            this.tbMetin.Size = new System.Drawing.Size(360, 34);
            this.tbMetin.TabIndex = 0;
            this.tbMetin.TextChanged += new System.EventHandler(this.lbListe_SelectedIndexChanged);
            // 
            // lbListe
            // 
            this.lbListe.BackColor = System.Drawing.Color.Coral;
            this.lbListe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbListe.ForeColor = System.Drawing.Color.Black;
            this.lbListe.FormattingEnabled = true;
            this.lbListe.ItemHeight = 29;
            this.lbListe.Items.AddRange(new object[] {
            "Ben sizi sevdim: belki bu sevda",
            "Kalbimde sönmedi, kaldı izi;",
            "Bu bir hüzne yol açmasın asla,",
            "Hiçbir şeyle üzmek istemem sizi.",
            "Sessizce, ümitsizce sevdim sizi,",
            "Çile çekerek, kıskanç ve çekingen,",
            "Öyle candan, öyle içtenlikli, ki",
            "Başkası da öyle sevsin yürekten."});
            this.lbListe.Location = new System.Drawing.Point(0, 34);
            this.lbListe.Name = "lbListe";
            this.lbListe.Size = new System.Drawing.Size(360, 457);
            this.lbListe.TabIndex = 1;
            this.lbListe.SelectedIndexChanged += new System.EventHandler(this.lbListe_SelectedIndexChanged);
            this.lbListe.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Liste);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 491);
            this.Controls.Add(this.lbListe);
            this.Controls.Add(this.tbMetin);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbMetin;
        private System.Windows.Forms.ListBox lbListe;
    }
}

