using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Wiederstands_Rechner
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            FillCbbx(true);
        }



        #region GUI_Events

        private void rbtn_kohle_Checked(object sender, RoutedEventArgs e)
        {
            lbl_box3.Content = "Multiplier";
            lbl_box4.Content = "Toleranz";
            lbl_box5.Content = "-";
            cbbx_box5.IsEnabled = false;
            FillCbbx(true);
        }

        private void rbtn_metall_Checked(object sender, RoutedEventArgs e)
        {
            lbl_box3.Content = "Ring 3";
            lbl_box4.Content = "Multiplier";
            lbl_box5.Content = "Toleranz";
            cbbx_box5.IsEnabled = true;
            FillCbbx(false);
        }

        private void cbbx_box1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                rec_ring1.Fill = getBrush(cbbx_box1.SelectedIndex + 1);

            }
            catch { }
        }

        private void cbbx_box2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                
                rec_ring2.Fill = getBrush(cbbx_box2.SelectedIndex);

            }
            catch { }
        }

        private void cbbx_box3_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                rec_ring3.Fill = getBrush(cbbx_box3.SelectedIndex);

            }
            catch { }
        }

        private void cbbx_box4_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                rec_ring4.Fill = getBrush(cbbx_box4.SelectedIndex);

            }
            catch { }
        }

        private void cbbx_box5_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                rec_ring5.Fill = getBrush(cbbx_box5.SelectedIndex);

            }
            catch { }
        }

        #endregion



        #region Helper


        private void FillCbbx(bool b_fourCodes)
        {
            cbbx_box1.Items.Clear();
            cbbx_box2.Items.Clear();
            cbbx_box3.Items.Clear();
            cbbx_box4.Items.Clear();
            cbbx_box5.Items.Clear();

            int c = 4;

            if (!b_fourCodes)
                c = 5;

            for (int i = 0; i < c; i++)
            {
                for (int a = 0; a < 12; a++)
                {
                    var cb
                        bxi = new ComboBoxItem();
                    cbbxi.Background = getBrush(a);
                    cbbxi.Foreground = getForegr(a);
                    cbbxi.Content = getContent(a);

                    if (i == 0 && a != 0)
                        if (i == 0 && a <= 9)
                            cbbx_box1.Items.Add(cbbxi);

                    if (i == 1 && a <= 9)
                        cbbx_box2.Items.Add(cbbxi);

                    if (b_fourCodes)
                    {
                        if (i == 2 && a != 9 && a != 8)
                            cbbx_box3.Items.Add(cbbxi);
                    }
                    else
                    {
                        if (i == 2 && a <= 9)
                            cbbx_box3.Items.Add(cbbxi);
                    }

                    if (b_fourCodes)
                    {
                        if (i == 3 && a != 0 && a != 3 && a != 4 && a != 9)
                            cbbx_box4.Items.Add(cbbxi);
                    }
                    else
                    {
                        if (i == 3 && a != 9 && a != 8)
                            cbbx_box4.Items.Add(cbbxi);
                    }

                    if (i == 4 && a != 0 && a != 3 && a != 4 && a != 9)
                        cbbx_box5.Items.Add(cbbxi);
                }

            }

            cbbx_box1.SelectedIndex = 0;
            cbbx_box2.SelectedIndex = 0;
            cbbx_box3.SelectedIndex = 0;
            cbbx_box4.SelectedIndex = 0;
            cbbx_box5.SelectedIndex = 0;
        }



        #endregion

        private Brush getBrush(int itemNr)
        {
            switch (itemNr)
            {
                case 0:
                    return Brushes.Black;
                case 1:
                    return Brushes.Brown;
                case 2:
                    return Brushes.Red;
                case 3:
                    return Brushes.Orange;
                case 4:
                    return Brushes.Yellow;
                case 5:
                    return Brushes.Green;
                case 6:
                    return Brushes.Blue;
                case 7:
                    return Brushes.Violet;
                case 8:
                    return Brushes.DarkGray;
                case 9:
                    return Brushes.White;
                case 10:
                    return Brushes.Silver;
                default:
                    return Brushes.Gold;
            }
        }

        private Brush getForegr(int itemNr)
        {
            switch (itemNr)
            {

                case 8:
                    return Brushes.Black;
                case 9:
                    return Brushes.Black;
                case 10:
                    return Brushes.Black;
                case 11:
                    return Brushes.Black;
                default:
                    return Brushes.White;
            }
        }

        private string getContent(int itemNr)
        {
            switch (itemNr)
            {
                case 0:
                    return "Black";
                case 1:
                    return "Brown";
                case 2:
                    return "Red";
                case 3:
                    return "Orange";
                case 4:
                    return "Yellow";
                case 5:
                    return "Green";
                case 6:
                    return "Blue";
                case 7:
                    return "Violet";
                case 8:
                    return "Gray";
                case 9:
                    return "White";
                case 10:
                    return "Silver";
                default:
                    return "Gold";
            }
        }
    }
}


