using System;
using System.Collections.Generic;
using OfficeOpenXml;
using System.IO;
using System.Windows.Forms;


namespace Seminarska_Repse
{
    public partial class Form1 : Form
    {

        public List<Transport> razpoložljiviPrevozi;
        private string excelFilePath = "TransportData.xlsx";
        public Form1()
        {

            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;


            InitializeComponent();
            razpoložljiviPrevozi = new List<Transport>();
            NaložiPodatkePrevozaIzExcela();
            dodaj_prevoz_a.Click += new EventHandler(dodaj_prevoz_a_Click);
            nacin_prevoza_a.Items.AddRange(new string[] { "Bus", "Vlak", "Letalo", "Ladja" });
            vlak_bus_razred_a.Items.AddRange(new string[] { "Ekonomska", "Poslovna", "Prva" });
        }

        private void NaložiPodatkePrevozaIzExcela()
        {
            List<string> krajiOdhoda = new List<string>();
            List<string> krajiPrihoda = new List<string>();
            List<string> naciniPrevoza = new List<string>();
            List<string> razrediPrevoza = new List<string>();

            if (File.Exists(excelFilePath))
            {
                using (var paket = new ExcelPackage(new FileInfo(excelFilePath)))
                {
                    var delovniList = paket.Workbook.Worksheets[0];
                    int steviloVrstic = delovniList.Dimension.Rows;
                    for (int vrstica = 2; vrstica <= steviloVrstic; vrstica++) 
                    {
                        string krajOdhoda = delovniList.Cells[vrstica, 3].Value?.ToString();
                        string krajPrihoda = delovniList.Cells[vrstica, 5].Value?.ToString();
                        string nacinPrevoza = delovniList.Cells[vrstica, 1].Value?.ToString();
                        string razredPrevoza = delovniList.Cells[vrstica, 9].Value?.ToString();

                        if (!string.IsNullOrEmpty(krajOdhoda) && !krajiOdhoda.Contains(krajOdhoda))
                            krajiOdhoda.Add(krajOdhoda);

                        if (!string.IsNullOrEmpty(krajPrihoda) && !krajiPrihoda.Contains(krajPrihoda))
                            krajiPrihoda.Add(krajPrihoda);

                        if (!string.IsNullOrEmpty(nacinPrevoza) && !naciniPrevoza.Contains(nacinPrevoza))
                            naciniPrevoza.Add(nacinPrevoza);

                        if (!string.IsNullOrEmpty(razredPrevoza) && !razrediPrevoza.Contains(razredPrevoza))
                            razrediPrevoza.Add(razredPrevoza);

                      
                    }
                }
            }
            else
            {
                using (var paket = new ExcelPackage(new FileInfo(excelFilePath)))
                {
                    var delovniList = paket.Workbook.Worksheets.Add("Prevozi");

                    delovniList.Cells[1, 1].Value = "Tip";
                    delovniList.Cells[1, 2].Value = "ČasOdhoda";
                    delovniList.Cells[1, 3].Value = "KrajOdhoda";
                    delovniList.Cells[1, 4].Value = "DržavaOdhoda";
                    delovniList.Cells[1, 5].Value = "KrajPrihoda";
                    delovniList.Cells[1, 6].Value = "DržavaPrihoda";
                    delovniList.Cells[1, 7].Value = "Cena";
                    delovniList.Cells[1, 8].Value = "Sedeži";
                    delovniList.Cells[1, 9].Value = "Dodatno1"; // TipAvtobusa ali RazredPrevoza ali LinijaLeta
                    delovniList.Cells[1, 10].Value = "Dodatno2"; // Linija za Avtobus

                    paket.Save();
                }
            }
           
            NapolniComboBox(Kraj_odhoda_u, krajiOdhoda);
            NapolniComboBox(kraj_povratka_u, krajiPrihoda);
            NapolniComboBox(Do_u, krajiPrihoda);
            NapolniComboBox(Nacin_prevoza_u, naciniPrevoza);
            NapolniComboBox(vlak_bus_razred_u, razrediPrevoza);
        }

        private void NapolniComboBox(ComboBox comboBox, List<string> elementi)
        {
            foreach (var element in elementi)
            {
                comboBox.Items.Add(element);
            }

            if (comboBox.Items.Count > 0)
            {
                comboBox.SelectedIndex = 0;
            }
        }





        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Poti_u.Items.Clear();
            bool transportFound = false;

            string departureCity = Kraj_odhoda_u.SelectedItem.ToString();
            string destinationCity = Do_u.SelectedItem.ToString();
            razpoložljiviPrevozi.ForEach(Console.WriteLine);
            foreach (var transport in razpoložljiviPrevozi)
            {
                // Debugging output
                Console.WriteLine($"Checking transport: {transport.KrajOdhoda} -> {transport.KrajPrihoda}");

                if (string.Equals(transport.KrajOdhoda, departureCity, StringComparison.OrdinalIgnoreCase)) 
                    
                {
                    string transportInfo = $"Tip prevoza: {transport.TipPrevoza}, Odhod: {transport.UraOdhoda}, Prihod: {transport.UraPrihoda}, Cena: {transport.Cena} EUR";
                    Poti_u.Items.Add(transportInfo);
                    transportFound = true;
                }
            }

            if (!transportFound)
            {
                Poti_u.Items.Add("Žal nismo mogli najti prevoza za vas.");
            }
        }
    

    

        private void Kupiu_Click(object sender, EventArgs e)
        {
            if (Poti_u.SelectedItem != null)
            {
                string selectedTransportInfo = Poti_u.SelectedItem.ToString();
                if (!string.IsNullOrEmpty(selectedTransportInfo))
                {
                    MessageBox.Show("Uspešno ste kupili vozovnico!", "Nakup uspešen");
                }
                else
                {
                    MessageBox.Show("Prosimo izberite prevoz iz seznama.", "Napaka");
                }
            }
            else
            {
                MessageBox.Show("Prosimo izberite prevoz iz seznama.", "Napaka");
            }
        }

        private void dodaj_prevoz_a_Click(object sender, EventArgs e)
        {
            // Uporabnik vpiše geslo v MessageBoxu
            using (var passwordForm = new Form())
            {
                var passwordLabel = new Label();
                passwordLabel.Text = "Vnesite geslo:";
                passwordLabel.Dock = DockStyle.Top;

                var passwordTextBox = new TextBox();
                passwordTextBox.PasswordChar = '*'; // Skrije vnesene znake
                passwordTextBox.Dock = DockStyle.Top;

                var submitButton = new Button();
                submitButton.Text = "Potrdi";
                submitButton.Dock = DockStyle.Top;
                submitButton.Click += (s, args) =>
                {
                    string password = passwordTextBox.Text;
                    if (password == "123456")
                    {
                        // Geslo je pravilno, nadaljujemo z dodajanjem podatkov
                        DateTime dateTime = datum_cas_odhoda_a.Value;
                        string departureCity = kraj_odhoda_a.Text;
                        string destinationCity = gremo_a.Text;
                        string transportMode = nacin_prevoza_a.SelectedItem.ToString();
                        bool isLinear = liniski_prevoz_a.Checked;
                        string transportClass = vlak_bus_razred_a.SelectedItem.ToString();

                        // Dodamo podatke v Excel tabelo
                        AddTransportToExcel(dateTime, departureCity, destinationCity, transportMode, isLinear, transportClass);

                        passwordForm.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Napačno geslo!", "Napaka pri preverjanju gesla", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                };

                passwordForm.Controls.Add(submitButton);
                passwordForm.Controls.Add(passwordTextBox);
                passwordForm.Controls.Add(passwordLabel);

                if (passwordForm.ShowDialog() == DialogResult.OK)
                {
                    // Nadaljujete z delovanjem, saj je geslo pravilno
                }
                else
                {
                    MessageBox.Show("Prekinili ste preverjanje gesla.", "Prekinjeno", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void AddTransportToExcel(DateTime dateTime, string departureCity, string destinationCity, string transportMode, bool isLinear, string transportClass)
        {
            using (var package = new ExcelPackage(new FileInfo(excelFilePath)))
            {
                var worksheet = package.Workbook.Worksheets[0];
                int rowCount = worksheet.Dimension.Rows;
                worksheet.Cells[rowCount + 1, 1].Value = transportMode;
                worksheet.Cells[rowCount + 1, 2].Value = dateTime.ToString("g");
                worksheet.Cells[rowCount + 1, 3].Value = departureCity;
                worksheet.Cells[rowCount + 1, 4].Value = ""; // Država odhoda, ni na voljo
                worksheet.Cells[rowCount + 1, 5].Value = destinationCity;
                worksheet.Cells[rowCount + 1, 6].Value = ""; // Država prihoda, ni na voljo
                worksheet.Cells[rowCount + 1, 7].Value = ""; // Cena, ni na voljo
                worksheet.Cells[rowCount + 1, 8].Value = ""; // Število sedežev, ni na voljo
                worksheet.Cells[rowCount + 1, 9].Value = isLinear ? "Linearni" : ""; // Extra1 (tip prevoza)
                worksheet.Cells[rowCount + 1, 10].Value = transportClass; // Extra2 (razred prevoza)

                package.Save();
            }
        }

        private void izbrisi_a_Click(object sender, EventArgs e)
        {
            using (var passwordForm = new Form())
            {
                var passwordLabel = new Label();
                passwordLabel.Text = "Vnesite geslo:";
                passwordLabel.Dock = DockStyle.Top;

                var passwordTextBox = new TextBox();
                passwordTextBox.PasswordChar = '*'; // Skrije vnesene znake
                passwordTextBox.Dock = DockStyle.Top;

                var submitButton = new Button();
                submitButton.Text = "Potrdi";
                submitButton.Dock = DockStyle.Top;
                submitButton.Click += (s, args) =>
                {
                    string password = passwordTextBox.Text;
                    if (password == "123456")
                    {
                        // Geslo je pravilno, nadaljujemo z brisanjem podatkov
                        DeleteSelectedTransport();

                        passwordForm.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Napačno geslo!", "Napaka pri preverjanju gesla", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                };

                passwordForm.Controls.Add(submitButton);
                passwordForm.Controls.Add(passwordTextBox);
                passwordForm.Controls.Add(passwordLabel);

                if (passwordForm.ShowDialog() == DialogResult.OK)
                {
                    // Nadaljujete z delovanjem, saj je geslo pravilno
                }
                else
                {
                    MessageBox.Show("Prekinili ste preverjanje gesla.", "Prekinjeno", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void DeleteSelectedTransport()
        {
            if (Poti_u.SelectedItem != null)
            {
                string selectedTransportInfo = Poti_u.SelectedItem.ToString();

                // Poiščite prevoz v seznamu availableTransports
                Transport transportToRemove = null;
                foreach (var transport in razpoložljiviPrevozi)
                {
                    string transportInfo = $"Tip prevoza: {transport.TipPrevoza}, Odhod: {transport.UraOdhoda}, Prihod: {transport.UraPrihoda}, Cena: {transport.Cena} EUR";
                    if (transportInfo == selectedTransportInfo)
                    {
                        transportToRemove = transport;
                        break;
                    }
                }

                if (transportToRemove != null)
                {
                    // Odstranite prevoz iz seznama availableTransports
                    razpoložljiviPrevozi.Remove(transportToRemove);

                    // Osvežite ListBox
                    Poti_u.Items.Remove(selectedTransportInfo);

                    // Odstranite prevoz iz Excel datoteke
                    RemoveTransportFromExcel(transportToRemove);
                }
            }
            else
            {
                MessageBox.Show("Prosimo izberite prevoz iz seznama.", "Napaka");
            }
        }

        private void RemoveTransportFromExcel(Transport transport)
        {
            using (var package = new ExcelPackage(new FileInfo(excelFilePath)))
            {
                var worksheet = package.Workbook.Worksheets[0];
                int rowCount = worksheet.Dimension.Rows;

                for (int row = 2; row <= rowCount; row++)
                {
                    string transportMode = worksheet.Cells[row, 1].Value?.ToString();
                    string departureTime = worksheet.Cells[row, 2].Value?.ToString();
                    string departureCity = worksheet.Cells[row, 3].Value?.ToString();
                    string destinationCity = worksheet.Cells[row, 5].Value?.ToString();

                    if (transportMode == transport.TipPrevoza &&
                        departureTime == transport.UraOdhoda.ToString("g") &&
                        departureCity == transport.KrajOdhoda &&
                        destinationCity == transport.KrajPrihoda)
                    {
                        // Odstranite vrstico z ustreznimi podatki
                        worksheet.DeleteRow(row);
                        break;
                    }
                }

                package.Save();
            }
        }
    }

public class Transport
{
    public string TipPrevoza;
    public DateTime UraOdhoda;
    public DateTime UraPrihoda;
    public string KrajOdhoda;
    public string DrzavaOdhoda;
    public string KrajPrihoda;
    public string DrzavaPrihoda;
    public decimal Cena;
    public int SteviloSedezev;
    public int SteviloProdanihSedezev = 0;
    public List<string> DodatneLastnosti;

    protected Transport(string tipPrevoza, DateTime uraOdhoda, string krajOdhoda, string drzavaOdhoda,
                     string krajPrihoda, string drzavaPrihoda, decimal cena, int steviloSedezev)
    {
        TipPrevoza = tipPrevoza;
        UraOdhoda = uraOdhoda;
        KrajOdhoda = krajOdhoda;
        DrzavaOdhoda = drzavaOdhoda;
        KrajPrihoda = krajPrihoda;
        DrzavaPrihoda = drzavaPrihoda;
        Cena = cena;
        SteviloSedezev = steviloSedezev;

    }
}

public class Bus : Transport
{
    public string TipAvtobusa;
    public string Linija;
    public Bus(DateTime uraOdhoda, string krajOdhoda, string drzavaOdhoda, string krajPrihoda,
                       string drzavaPrihoda, decimal cena, int steviloSedezev, string tipAvtobusa, string linija)
    : base("avtobus", uraOdhoda, krajOdhoda, drzavaOdhoda, krajPrihoda, drzavaPrihoda, cena, steviloSedezev)
    {
        TipAvtobusa = tipAvtobusa;
        Linija = linija;
    }
}

public class Vlak : Transport
{
    public string RazredVagona;

    public Vlak(DateTime uraOdhoda, string krajOdhoda, string drzavaOdhoda, string krajPrihoda,
                            string drzavaPrihoda, decimal cena, int steviloSedezev, string razredVagona)
        : base("vlak", uraOdhoda, krajOdhoda, drzavaOdhoda, krajPrihoda, drzavaPrihoda, cena, steviloSedezev)
    {
        RazredVagona = razredVagona;
    }
}



public class Letalo : Transport
{
    public string Linija;
    public Letalo(DateTime uraOdhoda, string krajOdhoda, string drzavaOdhoda, string krajPrihoda,
                           string drzavaPrihoda, decimal cena, int steviloSedezev, string Linija)
       : base("Letalo", uraOdhoda, krajOdhoda, drzavaOdhoda, krajPrihoda, drzavaPrihoda, cena, steviloSedezev)
    {
        this.Linija = Linija;
    }


}
public class Vozovnica
{
    public Transport Prevoz;
    public DateTime DatumPotovanja;
    public int NumberOfPeople;
    public bool IsReturnTicket;
}

    public class Potnik
    {
        public string Name;
        public int NumberOfPassengers;
        public Transport PreferredTransport;
        public DateTime DepartureTime;
        public string StartLocation;
        public string EndLocation;

        public Potnik(string name, int numberOfPassengers, Transport preferredTransport, DateTime departureTime, string startLocation, string endLocation)
        {
            Name = name;
            NumberOfPassengers = numberOfPassengers;
            PreferredTransport = preferredTransport;
            DepartureTime = departureTime;
            StartLocation = startLocation;
            EndLocation = endLocation;
        }

    }

}