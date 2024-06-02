namespace Seminarska_Repse
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
            this.Datum_cas_odhoda_u = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.datu_cas_povratka_u = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.Kraj_odhoda_u = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.mozni_sedezi_a = new System.Windows.Forms.TextBox();
            this.kraj_odhoda_a = new System.Windows.Forms.TextBox();
            this.Do_u = new System.Windows.Forms.ComboBox();
            this.kraj_povratka_u = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.vrnitev_u = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Kupiu = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.dodaj_prevoz_a = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.nacin_prevoza_a = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.datum_cas_odhoda_a = new System.Windows.Forms.DateTimePicker();
            this.liniski_prevoz_a = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.Nacin_prevoza_u = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.vlak_bus_razred_u = new System.Windows.Forms.ComboBox();
            this.izbrisi_a = new System.Windows.Forms.Button();
            this.st_oseb_u = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.vlak_bus_razred_a = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.Ime_priimek_u = new System.Windows.Forms.TextBox();
            this.Poti_u = new System.Windows.Forms.ListBox();
            this.label17 = new System.Windows.Forms.Label();
            this.gremo_a = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Datum_cas_odhoda_u
            // 
            this.Datum_cas_odhoda_u.Location = new System.Drawing.Point(0, 109);
            this.Datum_cas_odhoda_u.Name = "Datum_cas_odhoda_u";
            this.Datum_cas_odhoda_u.Size = new System.Drawing.Size(200, 20);
            this.Datum_cas_odhoda_u.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nakup kart";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // datu_cas_povratka_u
            // 
            this.datu_cas_povratka_u.Location = new System.Drawing.Point(2, 386);
            this.datu_cas_povratka_u.Name = "datu_cas_povratka_u";
            this.datu_cas_povratka_u.Size = new System.Drawing.Size(200, 20);
            this.datu_cas_povratka_u.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-1, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Datum in čas odhoda";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Kraj_odhoda_u
            // 
            this.Kraj_odhoda_u.FormattingEnabled = true;
            this.Kraj_odhoda_u.Location = new System.Drawing.Point(5, 161);
            this.Kraj_odhoda_u.Name = "Kraj_odhoda_u";
            this.Kraj_odhoda_u.Size = new System.Drawing.Size(121, 21);
            this.Kraj_odhoda_u.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kraj odhoda";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(2, 451);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Išči";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mozni_sedezi_a
            // 
            this.mozni_sedezi_a.Location = new System.Drawing.Point(830, 233);
            this.mozni_sedezi_a.Name = "mozni_sedezi_a";
            this.mozni_sedezi_a.Size = new System.Drawing.Size(164, 20);
            this.mozni_sedezi_a.TabIndex = 8;
            // 
            // kraj_odhoda_a
            // 
            this.kraj_odhoda_a.Location = new System.Drawing.Point(830, 185);
            this.kraj_odhoda_a.Name = "kraj_odhoda_a";
            this.kraj_odhoda_a.Size = new System.Drawing.Size(100, 20);
            this.kraj_odhoda_a.TabIndex = 9;
            // 
            // Do_u
            // 
            this.Do_u.FormattingEnabled = true;
            this.Do_u.Location = new System.Drawing.Point(5, 199);
            this.Do_u.Name = "Do_u";
            this.Do_u.Size = new System.Drawing.Size(121, 21);
            this.Do_u.TabIndex = 11;
            // 
            // kraj_povratka_u
            // 
            this.kraj_povratka_u.FormattingEnabled = true;
            this.kraj_povratka_u.Location = new System.Drawing.Point(2, 424);
            this.kraj_povratka_u.Name = "kraj_povratka_u";
            this.kraj_povratka_u.Size = new System.Drawing.Size(121, 21);
            this.kraj_povratka_u.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Kam bi dopotovali?";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // vrnitev_u
            // 
            this.vrnitev_u.AutoSize = true;
            this.vrnitev_u.Location = new System.Drawing.Point(4, 344);
            this.vrnitev_u.Name = "vrnitev_u";
            this.vrnitev_u.Size = new System.Drawing.Size(134, 17);
            this.vrnitev_u.TabIndex = 14;
            this.vrnitev_u.Text = "Si želite povratne karte";
            this.vrnitev_u.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1, 364);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Datum in čas povratka";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-1, 408);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Mesto povrratka";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(246, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Možne izbire";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // Kupiu
            // 
            this.Kupiu.Location = new System.Drawing.Point(446, 412);
            this.Kupiu.Name = "Kupiu";
            this.Kupiu.Size = new System.Drawing.Size(75, 23);
            this.Kupiu.TabIndex = 19;
            this.Kupiu.Text = "Kupi";
            this.Kupiu.UseVisualStyleBackColor = true;
            this.Kupiu.Click += new System.EventHandler(this.Kupiu_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(832, 217);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "število možnih sedežev";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // dodaj_prevoz_a
            // 
            this.dodaj_prevoz_a.Location = new System.Drawing.Point(827, 367);
            this.dodaj_prevoz_a.Name = "dodaj_prevoz_a";
            this.dodaj_prevoz_a.Size = new System.Drawing.Size(75, 23);
            this.dodaj_prevoz_a.TabIndex = 25;
            this.dodaj_prevoz_a.Text = "Dodaj prevoz";
            this.dodaj_prevoz_a.UseVisualStyleBackColor = true;
            this.dodaj_prevoz_a.Click += new System.EventHandler(this.dodaj_prevoz_a_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(827, 168);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Kraj odhoda";
            // 
            // nacin_prevoza_a
            // 
            this.nacin_prevoza_a.FormattingEnabled = true;
            this.nacin_prevoza_a.Location = new System.Drawing.Point(830, 275);
            this.nacin_prevoza_a.Name = "nacin_prevoza_a";
            this.nacin_prevoza_a.Size = new System.Drawing.Size(121, 21);
            this.nacin_prevoza_a.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(827, 129);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(108, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Datum in čas odhoda";
            // 
            // datum_cas_odhoda_a
            // 
            this.datum_cas_odhoda_a.Location = new System.Drawing.Point(830, 145);
            this.datum_cas_odhoda_a.Name = "datum_cas_odhoda_a";
            this.datum_cas_odhoda_a.Size = new System.Drawing.Size(200, 20);
            this.datum_cas_odhoda_a.TabIndex = 20;
            // 
            // liniski_prevoz_a
            // 
            this.liniski_prevoz_a.AutoSize = true;
            this.liniski_prevoz_a.Location = new System.Drawing.Point(832, 302);
            this.liniski_prevoz_a.Name = "liniski_prevoz_a";
            this.liniski_prevoz_a.Size = new System.Drawing.Size(50, 17);
            this.liniski_prevoz_a.TabIndex = 29;
            this.liniski_prevoz_a.Text = "Linija";
            this.liniski_prevoz_a.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(829, 256);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Način prevoza";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(835, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "Dodaj prevoz";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1, 256);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 13);
            this.label13.TabIndex = 33;
            this.label13.Text = "Način prevoza";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // Nacin_prevoza_u
            // 
            this.Nacin_prevoza_u.FormattingEnabled = true;
            this.Nacin_prevoza_u.Location = new System.Drawing.Point(4, 276);
            this.Nacin_prevoza_u.Name = "Nacin_prevoza_u";
            this.Nacin_prevoza_u.Size = new System.Drawing.Size(121, 21);
            this.Nacin_prevoza_u.TabIndex = 32;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(4, 306);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 13);
            this.label14.TabIndex = 35;
            this.label14.Text = "Razred ";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // vlak_bus_razred_u
            // 
            this.vlak_bus_razred_u.FormattingEnabled = true;
            this.vlak_bus_razred_u.Location = new System.Drawing.Point(2, 322);
            this.vlak_bus_razred_u.Name = "vlak_bus_razred_u";
            this.vlak_bus_razred_u.Size = new System.Drawing.Size(121, 21);
            this.vlak_bus_razred_u.TabIndex = 34;
            this.vlak_bus_razred_u.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
            // 
            // izbrisi_a
            // 
            this.izbrisi_a.Location = new System.Drawing.Point(908, 367);
            this.izbrisi_a.Name = "izbrisi_a";
            this.izbrisi_a.Size = new System.Drawing.Size(75, 23);
            this.izbrisi_a.TabIndex = 36;
            this.izbrisi_a.Text = "Izbriši";
            this.izbrisi_a.UseVisualStyleBackColor = true;
            this.izbrisi_a.Click += new System.EventHandler(this.izbrisi_a_Click);
            // 
            // st_oseb_u
            // 
            this.st_oseb_u.Location = new System.Drawing.Point(5, 239);
            this.st_oseb_u.Name = "st_oseb_u";
            this.st_oseb_u.Size = new System.Drawing.Size(100, 20);
            this.st_oseb_u.TabIndex = 37;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(2, 223);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 13);
            this.label15.TabIndex = 38;
            this.label15.Text = "Število oseb";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(829, 324);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(44, 13);
            this.label16.TabIndex = 40;
            this.label16.Text = "Razred ";
            // 
            // vlak_bus_razred_a
            // 
            this.vlak_bus_razred_a.FormattingEnabled = true;
            this.vlak_bus_razred_a.Location = new System.Drawing.Point(827, 340);
            this.vlak_bus_razred_a.Name = "vlak_bus_razred_a";
            this.vlak_bus_razred_a.Size = new System.Drawing.Size(121, 21);
            this.vlak_bus_razred_a.TabIndex = 39;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(2, 41);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(71, 13);
            this.label18.TabIndex = 42;
            this.label18.Text = "Ime in priimek";
            // 
            // Ime_priimek_u
            // 
            this.Ime_priimek_u.Location = new System.Drawing.Point(2, 57);
            this.Ime_priimek_u.Name = "Ime_priimek_u";
            this.Ime_priimek_u.Size = new System.Drawing.Size(136, 20);
            this.Ime_priimek_u.TabIndex = 41;
            // 
            // Poti_u
            // 
            this.Poti_u.FormattingEnabled = true;
            this.Poti_u.Location = new System.Drawing.Point(220, 90);
            this.Poti_u.Name = "Poti_u";
            this.Poti_u.Size = new System.Drawing.Size(588, 316);
            this.Poti_u.TabIndex = 43;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(818, 408);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(36, 13);
            this.label17.TabIndex = 45;
            this.label17.Text = "gremo";
            // 
            // gremo_a
            // 
            this.gremo_a.Location = new System.Drawing.Point(821, 425);
            this.gremo_a.Name = "gremo_a";
            this.gremo_a.Size = new System.Drawing.Size(100, 20);
            this.gremo_a.TabIndex = 44;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 511);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.gremo_a);
            this.Controls.Add(this.Poti_u);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.Ime_priimek_u);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.vlak_bus_razred_a);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.st_oseb_u);
            this.Controls.Add(this.izbrisi_a);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.vlak_bus_razred_u);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.Nacin_prevoza_u);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.liniski_prevoz_a);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dodaj_prevoz_a);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.nacin_prevoza_a);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.datum_cas_odhoda_a);
            this.Controls.Add(this.Kupiu);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.vrnitev_u);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.kraj_povratka_u);
            this.Controls.Add(this.Do_u);
            this.Controls.Add(this.kraj_odhoda_a);
            this.Controls.Add(this.mozni_sedezi_a);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Kraj_odhoda_u);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.datu_cas_povratka_u);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Datum_cas_odhoda_u);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker Datum_cas_odhoda_u;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker datu_cas_povratka_u;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Kraj_odhoda_u;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox mozni_sedezi_a;
        private System.Windows.Forms.TextBox kraj_odhoda_a;
        private System.Windows.Forms.ComboBox Do_u;
        private System.Windows.Forms.ComboBox kraj_povratka_u;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox vrnitev_u;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Kupiu;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button dodaj_prevoz_a;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox nacin_prevoza_a;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker datum_cas_odhoda_a;
        private System.Windows.Forms.CheckBox liniski_prevoz_a;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox Nacin_prevoza_u;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox vlak_bus_razred_u;
        private System.Windows.Forms.Button izbrisi_a;
        private System.Windows.Forms.TextBox st_oseb_u;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox vlak_bus_razred_a;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox Ime_priimek_u;
        private System.Windows.Forms.ListBox Poti_u;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox gremo_a;
    }
}

