using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.IO;


namespace XML_Devam
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        XmlDocument xDoc;

        Doviz selectedDoviz;

        SaveFileDialog saveFileDialog;

        XmlNode rootNode;

        private void Form3_Load(object sender, EventArgs e)
        {
            xDoc = new XmlDocument();
            xDoc.Load("http://www.tcmb.gov.tr/kurlar/today.xml");

            rootNode = xDoc.FirstChild;

            while (rootNode.SelectNodes("Currency") == null || rootNode.SelectNodes("Currency").Count == 0)
            {
                rootNode = rootNode.NextSibling;
            }
            xDoc.RemoveChild(rootNode.PreviousSibling);

            this.Text = rootNode.Attributes["Tarih"].Value;

            XmlNodeList currencyNodes = rootNode.SelectNodes("Currency");

            foreach (XmlNode item in currencyNodes)
            {
                if (item.SelectSingleNode("ForexBuying") == null)
                {
                    item.ParentNode.RemoveChild(item);
                    continue;
                }

                Doviz doviz = new Doviz()
                {
                    Kod = item.Attributes["Kod"].Value,
                    CurrencyName = item.SelectSingleNode("CurrencyName").InnerText,
                    ForexBuying = Donustur(item.SelectSingleNode("ForexBuying")),
                    ForexSelling = Donustur(item.SelectSingleNode("ForexSelling")),
                    BanknoteSelling = Donustur(item.SelectSingleNode("BanknoteSelling")),
                    BanknoteBuying = Donustur(item.SelectSingleNode("BanknoteBuying")),
                    CrossRateUSD = Donustur(item.SelectSingleNode("CrossRateUSD")),
                    CrossRateOther = Donustur(item.SelectSingleNode("CrossRateOther"))
                };

                lstboxCurrencies.Items.Add(doviz);
            }


            saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Save XML File";
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            saveFileDialog.Filter = "XML Files|*.xml";
            saveFileDialog.FileName = "currency.xml";

        }
        private decimal Donustur(XmlNode node)
        {
            return (String.IsNullOrEmpty(node.InnerText)) ? 0 : decimal.Parse(node.InnerText.Replace('.', ','));
        }

        private void lstboxCurrencies_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstboxCurrencies.SelectedItem == null)
                return;

            selectedDoviz = lstboxCurrencies.SelectedItem as Doviz;

            txtKod.Text = selectedDoviz.Kod;
            txtCurrencyName.Text = selectedDoviz.CurrencyName;
            txtForexBuying.Text = selectedDoviz.ForexBuying.ToString();
            txtForexSelling.Text = selectedDoviz.ForexSelling.ToString();
            txtBanknoteBuying.Text = selectedDoviz.BanknoteBuying.ToString();
            txtBanknoteSelling.Text = selectedDoviz.BanknoteSelling.ToString();
            txtCrossRateUSD.Text = selectedDoviz.CrossRateUSD.ToString();
            txtCrossRateOthers.Text = selectedDoviz.CrossRateOther.ToString();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            XmlNode newNode = xDoc.CreateNode(XmlNodeType.Element, "Currency", String.Empty);

            XmlAttribute att = xDoc.CreateAttribute("Kod");
            att.Value = txtKod.Text;

            XmlNode currencyName = xDoc.CreateNode(XmlNodeType.Element, "CurrencyName", String.Empty);
            currencyName.InnerText = txtCurrencyName.Text;

            XmlNode forexBuying = xDoc.CreateNode(XmlNodeType.Element, "ForexBuying", String.Empty);
            forexBuying.InnerText = txtForexBuying.Text;

            XmlNode forexSelling = xDoc.CreateNode(XmlNodeType.Element, "ForexSelling", String.Empty);
            forexSelling.InnerText = txtForexSelling.Text;

            XmlNode banknoteBuying = xDoc.CreateNode(XmlNodeType.Element, "BanknoteBuying", String.Empty);
            banknoteBuying.InnerText = txtBanknoteBuying.Text;

            XmlNode banknoteSelling = xDoc.CreateNode(XmlNodeType.Element, "BanknoteSelling", String.Empty);
            banknoteSelling.InnerText = txtBanknoteSelling.Text;

            XmlNode crossRateUSD = xDoc.CreateNode(XmlNodeType.Element, "CrossRateUSD", String.Empty);
            crossRateUSD.InnerText = txtCrossRateUSD.Text;

            XmlNode crossRateOther = xDoc.CreateNode(XmlNodeType.Element, "CrossRateOther", String.Empty);
            crossRateOther.InnerText = txtCrossRateOthers.Text;

            newNode.Attributes.Append(att);
            newNode.AppendChild(currencyName);
            newNode.AppendChild(forexBuying);
            newNode.AppendChild(forexSelling);
            newNode.AppendChild(banknoteBuying);
            newNode.AppendChild(banknoteSelling);
            newNode.AppendChild(crossRateUSD);
            newNode.AppendChild(crossRateOther);

            rootNode.AppendChild(newNode);
            Doviz doviz = new Doviz()
            {
                Kod = txtKod.Text,
                CurrencyName = txtCurrencyName.Text,
                ForexBuying = String.IsNullOrEmpty(txtForexBuying.Text) ? 0.0m : decimal.Parse(txtForexBuying.Text),
                ForexSelling = String.IsNullOrEmpty(txtForexSelling.Text) ? 0.0m : decimal.Parse(txtForexSelling.Text),
                BanknoteBuying = String.IsNullOrEmpty(txtBanknoteBuying.Text) ? 0.0m : decimal.Parse(txtBanknoteBuying.Text),
                BanknoteSelling = String.IsNullOrEmpty(txtBanknoteSelling.Text) ? 0.0m : decimal.Parse(txtBanknoteSelling.Text),
                CrossRateUSD = String.IsNullOrEmpty(txtCrossRateUSD.Text) ? 0.0m : decimal.Parse(txtCrossRateUSD.Text),
                CrossRateOther = String.IsNullOrEmpty(txtCrossRateOthers.Text) ? 0.0m : decimal.Parse(txtCrossRateOthers.Text)
            };

            lstboxCurrencies.Items.Add(doviz);

            ClearTextboxes();

            MessageBox.Show("Yeni doviz kuru başarıyla eklendi");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                return;

            xDoc.Save(saveFileDialog.FileName);

            MessageBox.Show("XML başarıyla kaydedildi");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstboxCurrencies.SelectedItem == null)
                return;

            XmlNode node = rootNode.SelectSingleNode(String.Format("Currency[@Kod='{0}']", selectedDoviz.Kod));

            node.ParentNode.RemoveChild(node);

            lstboxCurrencies.Items.Remove(lstboxCurrencies.SelectedItem);

            ClearTextboxes();

            MessageBox.Show("Seçili döviz başarıyla silindi");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lstboxCurrencies.SelectedItem == null)
                return;

            XmlNode node = rootNode.SelectSingleNode(String.Format("Currency[@Kod = '{0}']", selectedDoviz.Kod));

            node.Attributes["Kod"].Value = txtKod.Text;
            node.SelectSingleNode("CurrencyName").InnerText = txtCurrencyName.Text;
            node.SelectSingleNode("ForexBuying").InnerText = txtForexBuying.Text;
            node.SelectSingleNode("ForexSelling").InnerText = txtForexSelling.Text;
            node.SelectSingleNode("BanknoteBuying").InnerText = txtBanknoteBuying.Text;
            node.SelectSingleNode("BanknoteSelling").InnerText = txtBanknoteSelling.Text;
            node.SelectSingleNode("CrossRateUSD").InnerText = txtCrossRateUSD.Text;
            node.SelectSingleNode("CrossRateOther").InnerText = txtCrossRateOthers.Text;

            selectedDoviz.Kod = txtKod.Text;
            selectedDoviz.CurrencyName = txtCurrencyName.Text;
            selectedDoviz.ForexBuying = String.IsNullOrEmpty(txtForexBuying.Text) ? 0.0m : decimal.Parse(txtForexBuying.Text);
            selectedDoviz.ForexSelling = String.IsNullOrEmpty(txtForexSelling.Text) ? 0.0m : decimal.Parse(txtForexSelling.Text);
            selectedDoviz.BanknoteBuying = String.IsNullOrEmpty(txtBanknoteBuying.Text) ? 0.0m : decimal.Parse(txtBanknoteBuying.Text);
            selectedDoviz.BanknoteSelling = String.IsNullOrEmpty(txtBanknoteSelling.Text) ? 0.0m : decimal.Parse(txtBanknoteSelling.Text);
            selectedDoviz.CrossRateUSD = String.IsNullOrEmpty(txtCrossRateUSD.Text) ? 0.0m : decimal.Parse(txtCrossRateUSD.Text);
            selectedDoviz.CrossRateOther = String.IsNullOrEmpty(txtCrossRateOthers.Text) ? 0.0m : decimal.Parse(txtCrossRateOthers.Text);

            MessageBox.Show("Seçili döviz başarıyla güncellendi");
        }
        private void ClearTextboxes()
        {
            foreach (Control item in groupBox2.Controls)
            {
                if (item is TextBox)
                    item.ResetText();
            }
        }
    }
}
