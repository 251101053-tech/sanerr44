namespace sanerr44
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            listBox3.Items.Clear();

            // Hangi sýradaki elemanýn seçildiðine bakýyoruz (0: Adana, 1: Adýyaman, 2: Afyon vs.)
            int secilenSira = listBox1.SelectedIndex;

            switch (secilenSira)
            {
                case 0: // 01 - ADANA
                    listBox2.Items.Add("Taþ Köprü");
                    listBox2.Items.Add("Büyük Saat Kulesi");
                    listBox2.Items.Add("Sabancý Merkez Camii");

                    listBox3.Items.Add("Adana Kebabý");
                    listBox3.Items.Add("Þalgam Suyu");
                    listBox3.Items.Add("Bici Bici");
                    break;

                case 1: // 02 - ADIYAMAN
                    listBox2.Items.Add("Nemrut Daðý");
                    listBox2.Items.Add("Cendere Köprüsü");

                    listBox3.Items.Add("Çið Köfte");
                    listBox3.Items.Add("Adýyaman Hýtabý");
                    break;

                case 2: // 03 - AFYON
                    listBox2.Items.Add("Afyon Karahisar Kalesi");
                    listBox2.Items.Add("Gazlýgöl Kaplýcalarý");

                    listBox3.Items.Add("Afyon Sucuðu");
                    listBox3.Items.Add("Kaymak");
                    listBox3.Items.Add("Lokum");
                    break;

                case 3: // 04 - AÐRI
                    listBox2.Items.Add("Ýshak Paþa Sarayý");
                    listBox2.Items.Add("Aðrý Daðý");
                    listBox2.Items.Add("Meteor Çukuru");

                    listBox3.Items.Add("Abdigör Köftesi");
                    listBox3.Items.Add("Haþýl");
                    break;

                case 4: // 05 - AMASYA
                    listBox2.Items.Add("Kral Kaya Mezarlarý");
                    listBox2.Items.Add("Þehzadeler Gezi Yolu");
                    listBox2.Items.Add("Ferhat ile Þirin Aþýklar Müzesi");

                    listBox3.Items.Add("Amasya Elmasý");
                    listBox3.Items.Add("Amasya Çöreði");
                    listBox3.Items.Add("Baklalý Dolma");
                    break;

                case 5: // 06 - ANKARA
                    listBox2.Items.Add("Anýtkabir");
                    listBox2.Items.Add("Ankara Kalesi");
                    listBox2.Items.Add("Atakule");

                    listBox3.Items.Add("Ankara Tavasý");
                    listBox3.Items.Add("Ankara Simidi");
                    break;

                case 6: // 07 - ANTALYA
                    listBox2.Items.Add("Kaleiçi");
                    listBox2.Items.Add("Düden Þelalesi");
                    listBox2.Items.Add("Aspendos Antik Tiyatrosu");

                    listBox3.Items.Add("Piyaz (Tahinli)");
                    listBox3.Items.Add("Yanýksý Dondurma");
                    listBox3.Items.Add("Narenciye Reçelleri");
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //    listBox1.Items.Add("Cherry");

            //    listBox1.Items.Add("PORSCHE");

            //    listBox1.Items.Add("FORD");



            //    string[] arabalar = { "Fiat", "Renault", "LAMBORGHÝNÝ" };

            //    listBox1.Items.AddRange(arabalar);


            //   List<string> List =new List<string> { "FÝAT", "MERCEDES", "BMW" };
            //    listBox1.DataSource = List;

            Dictionary<int, string> iller = new Dictionary<int, string>();
            iller.Add(1, "ADANA");
            iller.Add(2, "ADIYAMAN");
            iller.Add(3, "AFYON");
            iller.Add(4, "AÐRI");
            iller.Add(5, "AMASYA");
            iller.Add(6, "ANKARA");
            iller.Add(7, "ANTALYA");

            foreach (KeyValuePair<int, string> il in iller)
            {
                // D2 formatý 1-9 arasýndaki sayýlarýn baþýna 0 ekler (01, 02...)
                listBox1.Items.Add($"{il.Key:D2} - {il.Value}");
            }



        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)

                listBox1.Items.Add(textBox1.Text);
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
        }
    }
}
