using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace XmlYazma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        XmlDocument xml = new XmlDocument();
        XmlElement filmler;
        private void Form1_Load(object sender, EventArgs e)
        {
            xml.RemoveAll();
            if (!File.Exists("Filmler.xml"))
            {
                filmler = xml.CreateElement("filmler");
                xml.AppendChild(filmler);
            }
            else //Dosya varsa
            {
                xml.Load("Filmler.xml");
                filmler = (XmlElement)xml.SelectSingleNode("filmler");
                XmlNodeList film = filmler.SelectNodes("film");
                foreach (XmlNode item in film)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = item.Attributes["adi"].Value;
                    lvi.SubItems.Add(item.Attributes["turu"].Value);
                    lvi.SubItems.Add(item.Attributes["yili"].Value);
                    lvi.SubItems.Add(item.Attributes["yonetmen"].Value);
                    lvi.SubItems.Add(item.Attributes["imdb"].Value);

                    listView1.Items.Add(lvi);
                }
            }
        }

        private void btnFilmEkle_Click(object sender, EventArgs e)
        {

            XmlElement film = xml.CreateElement("film");

            XmlAttribute adi = xml.CreateAttribute("adi");
            adi.Value = txtFilmAdi.Text;
            film.Attributes.Append(adi);

            XmlAttribute filmTuru = xml.CreateAttribute("turu");
            filmTuru.Value = cmbFilmTuru.Text;
            film.Attributes.Append(filmTuru);

            XmlAttribute yili = xml.CreateAttribute("yili");
            yili.Value = dtpYapimYili.Value.Year.ToString();
            film.Attributes.Append(yili);

            XmlAttribute yonetmen = xml.CreateAttribute("yonetmen");
            yonetmen.Value = txtYonetmen.Text;
            film.Attributes.Append(yonetmen);

            XmlAttribute imdb = xml.CreateAttribute("imdb");
            imdb.Value = txtImdbPuani.Text;
            film.Attributes.Append(imdb);

            XmlElement oyuncular = xml.CreateElement("oyuncular");
            foreach (string item in listOyuncular.Items)
            {
                XmlElement oync = xml.CreateElement("oyuncu");
                oync.InnerText = item;
                oyuncular.AppendChild(oync);
            }
            film.AppendChild(oyuncular);
            filmler.AppendChild(film);
            xml.Save("Filmler.xml");
        }

        private void btnOyuncuEkle_Click(object sender, EventArgs e)
        {
            listOyuncular.Items.Add(txtOyuncuAdi.Text);
            txtOyuncuAdi.Clear();
        }

        private void btnDbToXml_Click(object sender, EventArgs e)
        {
            DbToXmlForm dbto = new DbToXmlForm();
            dbto.Show();
        }
    }
}
