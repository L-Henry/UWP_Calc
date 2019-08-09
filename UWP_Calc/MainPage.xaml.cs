using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UWP_Calc
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>

    public sealed partial class MainPage : Page
    {
        public CalculatorViewModel Calc;



        public MainPage()
        {
            this.InitializeComponent();

            Calc = new CalculatorViewModel(new Calculator());


            //Load();

        }

        //private async void Load()
        //{
        //    List<string> list = await Persistentie.Load();
        //    foreach (var item in list)
        //    {
        //        listView.Items.Add(item);
        //    }

        //    //string t = await Windows.Storage.FileIO.ReadTextAsync(textFile);
        //    //string[] tt = t.Split(";;");
        //    //for (int i = 1; i < tt.Length; i++)
        //    //{
        //    //    listView.Items.Add(tt[i]);
        //    //}
        //}

        //private async void Save()
        //{
        //    List<string> list = new List<string>();
        //    foreach (var item in listView.Items)
        //    {
        //        list.Add(item.ToString());
        //    }
        //    await Persistentie.Save(list);

        //await Windows.Storage.FileIO.AppendTextAsync(textFile, ";;" + textBox2.Text);
        //}

        //private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (comboBox.SelectedIndex == 0)
        //    {
        //        panelParser.Visible = false;
        //        panelKlassiek.Visible = true;
        //        textBox1.Text = "0";
        //        GetalIngevuld = false;
        //    }
        //    else if (comboBox.SelectedIndex == 1)
        //    {
        //        panelKlassiek.Visible = false;
        //        panelParser.Location = new Point(12, 60);
        //        panelParser.Visible = true;
        //        textBoxP1.Text = "0";
        //        GetalIngevuldParserPanel = false;
        //    }
        //}


        //    private void Button_Click(object sender, RoutedEventArgs e)
        //    {
        //        Button button = sender as Button;

        //        if (GetalIngevuld && !InvertAfgehandeld)
        //        {
        //            textBox1.Text = "";
        //            textBox2.Text = "";
        //        }
        //        else if (!GetalIngevuld)
        //        {
        //            textBox1.Text = "";
        //        }
        //        GetalIngevuld = true;
        //        textBox1.Text += button.Content;
        //        InvertAfgehandeld = true;
        //    }

        //    private void IsButton_Click(object sender, RoutedEventArgs e)
        //    {
        //        if (Bewerking == null)
        //        {
        //            Getal1 = textBox1.Text;
        //            listView.Items.Add(Getal1 + " = " + Getal1);
        //        }
        //        else if (GetalIngevuld && textBox1.Text != "-")
        //        {
        //            Getal2 = textBox1.Text;
        //            GetalIngevuld = false;
        //            textBox1.Text = BerekenClass.Bereken(double.Parse(Getal1), double.Parse(Getal2), Bewerking).ToString();
        //            textBox2.Text += " " + Getal2 + " = " + textBox1.Text;
        //            listView.Items.Add(textBox2.Text);
        //        }
        //        else if (textBox1.Text.Any(c => char.IsDigit(c)) && textBox1.Text != "-")
        //        {
        //            Getal1 = textBox1.Text;
        //            textBox1.Text = BerekenClass.Bereken(double.Parse(Getal1), double.Parse(Getal2), Bewerking).ToString();
        //            textBox2.Text += Getal1 + " " + Bewerking + " " + Getal2 + " = " + textBox1.Text;
        //            listView.Items.Add(textBox2.Text);
        //        }
        //        Save();
        //        textBox2.Text = "";
        //    }

        //    private void CommaButton_Click(object sender, RoutedEventArgs e)
        //    {
        //        if (!textBox1.Text.Contains(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator))
        //        {
        //            GetalIngevuld = true;
        //            textBox1.Text += System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
        //        }
        //    }

        //    private void PlusButton_Click(object sender, RoutedEventArgs e)
        //    {
        //        if (GetalIngevuld && textBox1.Text != "-" && (textBox2.Text.Contains("+") || textBox2.Text.Contains("-") || textBox2.Text.Contains("*") || textBox2.Text.Contains("/")))
        //        {
        //            Getal2 = textBox1.Text;
        //            textBox1.Text = BerekenClass.Bereken(double.Parse(Getal1), double.Parse(Getal2), Bewerking).ToString();
        //            Getal1 = textBox1.Text;
        //            GetalIngevuld = false;
        //            Bewerking = "+";
        //            textBox2.Text += Getal2 + " " + Bewerking + " ";
        //        }

        //        else if (textBox2.Text.Length < 1)
        //        {
        //            Getal1 = textBox1.Text;
        //            GetalIngevuld = false;
        //            Bewerking = "+";
        //            textBox2.Text += Getal1 + " " + Bewerking + " ";
        //        }
        //    }

        //    private void MinButton_Click(object sender, RoutedEventArgs e)
        //    {
        //        if (GetalIngevuld && textBox1.Text != "-" && (textBox2.Text.Contains("+") || textBox2.Text.Contains("-") || textBox2.Text.Contains("*") || textBox2.Text.Contains("/")))
        //        {
        //            Getal2 = textBox1.Text;
        //            textBox1.Text = BerekenClass.Bereken(double.Parse(Getal1), double.Parse(Getal2), Bewerking).ToString();
        //            Getal1 = textBox1.Text;
        //            GetalIngevuld = false;
        //            Bewerking = "-";
        //            textBox2.Text += Getal2 + " " + Bewerking + " ";
        //        }

        //        else if (textBox2.Text.Length < 1)
        //        {
        //            Getal1 = textBox1.Text;
        //            GetalIngevuld = false;
        //            Bewerking = "-";
        //            textBox2.Text += Getal1 + " " + Bewerking + " ";
        //        }
        //    }

        //    private void MaalButton_Click(object sender, RoutedEventArgs e)
        //    {
        //        if (GetalIngevuld && textBox1.Text != "-" && (textBox2.Text.Contains("+") || textBox2.Text.Contains("-") || textBox2.Text.Contains("*") || textBox2.Text.Contains("/")))
        //        {
        //            Getal2 = textBox1.Text;
        //            textBox1.Text = BerekenClass.Bereken(double.Parse(Getal1), double.Parse(Getal2), Bewerking).ToString();
        //            Getal1 = textBox1.Text;
        //            GetalIngevuld = false;
        //            Bewerking = "*";
        //            textBox2.Text += Getal2 + " " + Bewerking + " ";
        //        }

        //        else if (textBox2.Text.Length < 1)
        //        {
        //            Getal1 = textBox1.Text;
        //            GetalIngevuld = false;
        //            Bewerking = "*";
        //            textBox2.Text += Getal1 + " " + Bewerking + " ";
        //        }
        //    }

        //    private void DeelButton_Click(object sender, RoutedEventArgs e)
        //    {
        //        if (GetalIngevuld && textBox1.Text != "-" && (textBox2.Text.Contains("+") || textBox2.Text.Contains("-") || textBox2.Text.Contains("*") || textBox2.Text.Contains("/")))
        //        {
        //            Getal2 = textBox1.Text;
        //            textBox1.Text = BerekenClass.Bereken(double.Parse(Getal1), double.Parse(Getal2), Bewerking).ToString();
        //            Getal1 = textBox1.Text;
        //            GetalIngevuld = false;
        //            Bewerking = "/";
        //            textBox2.Text += Getal2 + " " + Bewerking + " ";
        //        }

        //        else if (textBox2.Text.Length < 1)
        //        {
        //            Getal1 = textBox1.Text;
        //            GetalIngevuld = false;
        //            Bewerking = "/";
        //            textBox2.Text += Getal1 + " " + Bewerking + " ";
        //        }
        //    }

        //    private void NegateButton_Click(object sender, RoutedEventArgs e)
        //    {
        //        textBox1.Text = (double.Parse(textBox1.Text) * -1).ToString();
        //    }

        //    private void CeButton_Click(object sender, RoutedEventArgs e)
        //    {
        //        textBox1.Text = "0";
        //        GetalIngevuld = false;
        //    }

        //    private void CButton_Click(object sender, RoutedEventArgs e)
        //    {
        //        Getal1 = null;
        //        Getal2 = null;
        //        GetalIngevuld = false;
        //        Bewerking = null;
        //        textBox1.Text = "0";
        //        textBox2.Text = "";
        //    }

        //    private void KwadraatButton_Click(object sender, RoutedEventArgs e)
        //    {
        //        Getal1 = textBox1.Text;
        //        textBox1.Text = Math.Pow(double.Parse(textBox1.Text), 2).ToString();
        //        listView.Items.Add(Getal1 + "^2 = " + textBox1.Text);
        //        Bewerking = null;
        //    }

        //    private void SqrtButton_Click(object sender, RoutedEventArgs e)
        //    {
        //        if (double.Parse(textBox1.Text) >= 0)
        //        {
        //            Getal1 = textBox1.Text;
        //            textBox1.Text = Math.Pow(double.Parse(textBox1.Text), 0.5).ToString();
        //            listView.Items.Add($"sqrt({Getal1}) = {textBox1.Text}");
        //            Bewerking = null;
        //        }
        //    }

        //    private void DelButton_Click(object sender, RoutedEventArgs e)
        //    {
        //        textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
        //        if (textBox1.Text == "" || textBox1.Text == "-")
        //        {
        //            GetalIngevuld = false;
        //        }
        //    }

        //    private void ModuleButton_Click(object sender, RoutedEventArgs e)
        //    {
        //        textBox1.Text = (double.Parse(textBox1.Text) / 100).ToString();
        //    }

        //    private void ClearHistoryButton_Click(object sender, RoutedEventArgs e)
        //    {
        //        listView.Items.Clear();
        //    }
        //}

    }
}

