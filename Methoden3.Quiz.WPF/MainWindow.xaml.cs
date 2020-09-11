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
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Methoden3.Quiz.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int score;
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            BeginSituatie();
        }

        private void BeginSituatie()
        {
            wrpVraag1.Visibility = Visibility.Visible;
            wrpVraag2.Visibility = Visibility.Collapsed;
            wrpVraag3.Visibility = Visibility.Collapsed;
            btnOpnieuw.Visibility = Visibility.Collapsed;
            wrpVraag1.IsEnabled = true;
            wrpVraag2.IsEnabled = true;
            wrpVraag3.IsEnabled = true;

            lblFeedBack1.Content = "Kies het juiste antwoord";
            lblFeedBack2.Content = "Kies het juiste antwoord";
            lblFeedBack3.Content = "Kies het juiste antwoord";
            score = 0;
            lblScore.Content = score.ToString();
        }
        private void BtnOpnieuw_Click(object sender, RoutedEventArgs e)
        {
            BeginSituatie();
        }


        private void BtnAntw1a_Click(object sender, RoutedEventArgs e)
        {
            VerwerkVraag1(false);
        }
        private void BtnAntw1b_Click(object sender, RoutedEventArgs e)
        {
            VerwerkVraag1(false);
        }
        private void BtnAntw1c_Click(object sender, RoutedEventArgs e)
        {
            VerwerkVraag1(true);
        }
        private void VerwerkVraag1(bool correct)
        {
            wrpVraag1.IsEnabled = false;
            wrpVraag2.Visibility = Visibility.
                Visible;
            if (correct)
            {
                lblFeedBack1.Content = "Correct";
                score++;
                lblScore.Content = score.ToString();
            }
            else
            {
                lblFeedBack1.Content = "Fout";
            }
        }

        private void BtnAntw2a_Click(object sender, RoutedEventArgs e)
        {
            VerwerkVraag2(false);
        }

        private void BtnAntw2b_Click(object sender, RoutedEventArgs e)
        {
            VerwerkVraag2(true);
        }

        private void BtnAntw2c_Click(object sender, RoutedEventArgs e)
        {
            VerwerkVraag2(false);
        }
        private void VerwerkVraag2(bool correct)
        {
            wrpVraag2.IsEnabled = false;
            wrpVraag3.Visibility = Visibility.Visible;
            if (correct)
            {
                lblFeedBack2.Content = "Correct";
                score++;
                lblScore.Content = score.ToString();
            }
            else
            {
                lblFeedBack2.Content = "Fout";
            }
        }

        private void BtnAntw3a_Click(object sender, RoutedEventArgs e)
        {
            VerwerkVraag3(false);
        }

        private void BtnAntw3b_Click(object sender, RoutedEventArgs e)
        {
            VerwerkVraag3(false);
        }

        private void BtnAntw3c_Click(object sender, RoutedEventArgs e)
        {
            VerwerkVraag3(true);
        }
        private void VerwerkVraag3(bool correct)
        {
            wrpVraag3.IsEnabled = false;
            btnOpnieuw.Visibility = Visibility.Visible;
            if (correct)
            {
                lblFeedBack3.Content = "Correct";
                score++;
                lblScore.Content = score.ToString();
            }
            else
            {
                lblFeedBack3.Content = "Fout";
            }
        }

    }
}
