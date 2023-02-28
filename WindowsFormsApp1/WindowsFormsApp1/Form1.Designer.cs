namespace WindowsFormsApp1
{
    partial class poZalogowaniuUczen
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Biologia");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Chemia");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Fizyka");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("Geografia");
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("Historia");
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("Informatyka");
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem("Język Polski");
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem("Matematyka");
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem(new string[] {
            "Zachowanie"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))));
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(poZalogowaniuUczen));
            this.tabelaOceny = new System.Windows.Forms.Button();
            this.tabelaFrekwencja = new System.Windows.Forms.Button();
            this.tabelaWiadomosci = new System.Windows.Forms.Button();
            this.tabelaOgloszenia = new System.Windows.Forms.Button();
            this.tabelaTerminarz = new System.Windows.Forms.Button();
            this.tabelaUwagi = new System.Windows.Forms.Button();
            this.wyloguj = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.przedmiot = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.oceny1sem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imieNazwiskoUcznia = new System.Windows.Forms.Label();
            this.klasaUcznia = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ocenaProponowana1sem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ocenaKoncowa1sem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.oceny2sem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ocenaProponowana2sem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ocenaKoncowa2sem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // tabelaOceny
            // 
            this.tabelaOceny.Location = new System.Drawing.Point(514, 25);
            this.tabelaOceny.Name = "tabelaOceny";
            this.tabelaOceny.Size = new System.Drawing.Size(75, 75);
            this.tabelaOceny.TabIndex = 0;
            this.tabelaOceny.Text = "Oceny";
            this.tabelaOceny.UseVisualStyleBackColor = true;
            // 
            // tabelaFrekwencja
            // 
            this.tabelaFrekwencja.Location = new System.Drawing.Point(595, 25);
            this.tabelaFrekwencja.Name = "tabelaFrekwencja";
            this.tabelaFrekwencja.Size = new System.Drawing.Size(75, 75);
            this.tabelaFrekwencja.TabIndex = 1;
            this.tabelaFrekwencja.Text = "Frekwencja";
            this.tabelaFrekwencja.UseVisualStyleBackColor = true;
            // 
            // tabelaWiadomosci
            // 
            this.tabelaWiadomosci.Location = new System.Drawing.Point(676, 25);
            this.tabelaWiadomosci.Name = "tabelaWiadomosci";
            this.tabelaWiadomosci.Size = new System.Drawing.Size(75, 75);
            this.tabelaWiadomosci.TabIndex = 2;
            this.tabelaWiadomosci.Text = "Wiadomosci";
            this.tabelaWiadomosci.UseVisualStyleBackColor = true;
            // 
            // tabelaOgloszenia
            // 
            this.tabelaOgloszenia.Location = new System.Drawing.Point(757, 25);
            this.tabelaOgloszenia.Name = "tabelaOgloszenia";
            this.tabelaOgloszenia.Size = new System.Drawing.Size(75, 75);
            this.tabelaOgloszenia.TabIndex = 3;
            this.tabelaOgloszenia.Text = "Ogloszenia";
            this.tabelaOgloszenia.UseVisualStyleBackColor = true;
            // 
            // tabelaTerminarz
            // 
            this.tabelaTerminarz.Location = new System.Drawing.Point(838, 25);
            this.tabelaTerminarz.Name = "tabelaTerminarz";
            this.tabelaTerminarz.Size = new System.Drawing.Size(75, 75);
            this.tabelaTerminarz.TabIndex = 4;
            this.tabelaTerminarz.Text = "Terminarz";
            this.tabelaTerminarz.UseVisualStyleBackColor = true;
            // 
            // tabelaUwagi
            // 
            this.tabelaUwagi.Location = new System.Drawing.Point(919, 25);
            this.tabelaUwagi.Name = "tabelaUwagi";
            this.tabelaUwagi.Size = new System.Drawing.Size(75, 75);
            this.tabelaUwagi.TabIndex = 5;
            this.tabelaUwagi.Text = "Uwagi";
            this.tabelaUwagi.UseVisualStyleBackColor = true;
            // 
            // wyloguj
            // 
            this.wyloguj.Location = new System.Drawing.Point(1000, 25);
            this.wyloguj.Name = "wyloguj";
            this.wyloguj.Size = new System.Drawing.Size(75, 75);
            this.wyloguj.TabIndex = 6;
            this.wyloguj.Text = "Wyloguj";
            this.wyloguj.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.przedmiot,
            this.oceny1sem,
            this.ocenaProponowana1sem,
            this.ocenaKoncowa1sem,
            this.oceny2sem,
            this.ocenaProponowana2sem,
            this.ocenaKoncowa2sem});
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7,
            listViewItem8,
            listViewItem9});
            this.listView1.Location = new System.Drawing.Point(12, 106);
            this.listView1.Name = "listView1";
            this.listView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listView1.Size = new System.Drawing.Size(1063, 500);
            this.listView1.TabIndex = 7;
            this.listView1.TileSize = new System.Drawing.Size(50, 50);
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // przedmiot
            // 
            this.przedmiot.Text = "Przedmiot";
            this.przedmiot.Width = 151;
            // 
            // oceny1sem
            // 
            this.oceny1sem.Text = "Oceny";
            this.oceny1sem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.oceny1sem.Width = 380;
            // 
            // imieNazwiskoUcznia
            // 
            this.imieNazwiskoUcznia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.imieNazwiskoUcznia.Location = new System.Drawing.Point(100, 40);
            this.imieNazwiskoUcznia.Name = "imieNazwiskoUcznia";
            this.imieNazwiskoUcznia.Size = new System.Drawing.Size(100, 15);
            this.imieNazwiskoUcznia.TabIndex = 8;
            this.imieNazwiskoUcznia.Text = "Imie i Nazwisko";
            // 
            // klasaUcznia
            // 
            this.klasaUcznia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.klasaUcznia.Location = new System.Drawing.Point(100, 70);
            this.klasaUcznia.Name = "klasaUcznia";
            this.klasaUcznia.Size = new System.Drawing.Size(50, 15);
            this.klasaUcznia.TabIndex = 9;
            this.klasaUcznia.Text = "Klasa";
            // 
            // label1
            // 
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 75);
            this.label1.TabIndex = 10;
            // 
            // ocenaProponowana1sem
            // 
            this.ocenaProponowana1sem.Text = "(|)";
            this.ocenaProponowana1sem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ocenaProponowana1sem.Width = 38;
            // 
            // ocenaKoncowa1sem
            // 
            this.ocenaKoncowa1sem.Text = "|";
            this.ocenaKoncowa1sem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ocenaKoncowa1sem.Width = 38;
            // 
            // oceny2sem
            // 
            this.oceny2sem.Text = "Oceny";
            this.oceny2sem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.oceny2sem.Width = 380;
            // 
            // ocenaProponowana2sem
            // 
            this.ocenaProponowana2sem.Text = "(|)";
            this.ocenaProponowana2sem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ocenaProponowana2sem.Width = 38;
            // 
            // ocenaKoncowa2sem
            // 
            this.ocenaKoncowa2sem.Text = "|";
            this.ocenaKoncowa2sem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ocenaKoncowa2sem.Width = 38;
            // 
            // poZalogowaniuUczen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.klasaUcznia);
            this.Controls.Add(this.imieNazwiskoUcznia);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.wyloguj);
            this.Controls.Add(this.tabelaUwagi);
            this.Controls.Add(this.tabelaTerminarz);
            this.Controls.Add(this.tabelaOgloszenia);
            this.Controls.Add(this.tabelaWiadomosci);
            this.Controls.Add(this.tabelaFrekwencja);
            this.Controls.Add(this.tabelaOceny);
            this.Name = "poZalogowaniuUczen";
            this.Text = "Dziennik Elektroniczny";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button tabelaOceny;
        private System.Windows.Forms.Button tabelaFrekwencja;
        private System.Windows.Forms.Button tabelaWiadomosci;
        private System.Windows.Forms.Button tabelaOgloszenia;
        private System.Windows.Forms.Button tabelaTerminarz;
        private System.Windows.Forms.Button tabelaUwagi;
        private System.Windows.Forms.Button wyloguj;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label imieNazwiskoUcznia;
        private System.Windows.Forms.Label klasaUcznia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader przedmiot;
        private System.Windows.Forms.ColumnHeader oceny1sem;
        private System.Windows.Forms.ColumnHeader ocenaProponowana1sem;
        private System.Windows.Forms.ColumnHeader ocenaKoncowa1sem;
        private System.Windows.Forms.ColumnHeader oceny2sem;
        private System.Windows.Forms.ColumnHeader ocenaProponowana2sem;
        private System.Windows.Forms.ColumnHeader ocenaKoncowa2sem;
    }
}

