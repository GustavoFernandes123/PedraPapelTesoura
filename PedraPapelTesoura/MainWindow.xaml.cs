using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
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

namespace PedraPapelTesoura
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        float GanhadosVC = 0;
        float GanhadosPC = 0;

        public MainWindow()
        {
            InitializeComponent();
            OcultarImagens();
            txtVencedor.Visibility = Visibility.Hidden;
        }

        private void ClickPedra(object sender, RoutedEventArgs e)
        {
            imgPato.Visibility = Visibility.Hidden;
            imgPapel.Visibility = Visibility.Hidden;
            imgPedra.Visibility = Visibility.Visible;
            imgTesoura.Visibility = Visibility.Hidden;

            Random random = new Random();
            int NumeroSorteado = random.Next(0, 3);
            if (NumeroSorteado == 0)
            {
                imgPapel2.Visibility = Visibility.Visible;
                imgPato2.Visibility = Visibility.Hidden;
                imgPedra2.Visibility = Visibility.Hidden;
                imgTesoura2.Visibility = Visibility.Hidden;
            }
            else if (NumeroSorteado == 1)
            {
                imgPedra2.Visibility = Visibility.Visible;
                imgPato2.Visibility = Visibility.Hidden;
                imgPapel2.Visibility = Visibility.Hidden;
                imgTesoura2.Visibility = Visibility.Hidden;
            }
            else
            {
                imgTesoura2.Visibility = Visibility.Visible;
                imgPato2.Visibility = Visibility.Hidden;
                imgPedra2.Visibility = Visibility.Hidden;
                imgPapel2.Visibility = Visibility.Hidden;
            }

            if(imgPedra.Visibility == Visibility.Visible && imgTesoura2.Visibility == Visibility.Visible)
            {
                txtVencedor.Text = "Jogador Vencedor";
                txtVencedor.Visibility = Visibility.Visible;
                GanhadosVC++;
                txtGanhouVC.Text = $"{GanhadosVC}";
                txtGanhouPC.Text = $"{GanhadosPC}";

                Stream audio = Properties.Resources.SomPato;
                SoundPlayer player = new SoundPlayer(audio);
                player.Play();

            }
            else if (imgPedra.Visibility == Visibility.Visible && imgPapel2.Visibility == Visibility.Visible)
            {
                txtVencedor.Text = "Computador Vencedor";
                txtVencedor.Visibility = Visibility.Visible;
                GanhadosPC++;
                txtGanhouVC.Text = $"{GanhadosVC}";
                txtGanhouPC.Text = $"{GanhadosPC}";

                Stream audio2 = Properties.Resources.SomRodolfo;
                SoundPlayer player2 = new SoundPlayer(audio2);
                player2.Play();

            }
            else if(imgPedra.Visibility == Visibility.Visible && imgPedra2.Visibility == Visibility.Visible)
            {
                txtVencedor.Text = "Empatou";
                txtVencedor.Visibility = Visibility.Visible;
                txtGanhouVC.Text = $"{GanhadosVC}";
                txtGanhouPC.Text = $"{GanhadosPC}";
            }
        }

        private void ClickPapel(object sender, RoutedEventArgs e)
        {
            imgPato.Visibility = Visibility.Hidden;
            imgPapel.Visibility = Visibility.Visible;
            imgPedra.Visibility = Visibility.Hidden;
            imgTesoura.Visibility = Visibility.Hidden;

            Random random = new Random();
            int NumeroSorteado = random.Next(0, 3);
            if (NumeroSorteado == 0)
            {
                imgPapel2.Visibility = Visibility.Visible;
                imgPato2.Visibility = Visibility.Hidden;
                imgPedra2.Visibility = Visibility.Hidden;
                imgTesoura2.Visibility = Visibility.Hidden;
            }
            else if (NumeroSorteado == 1)
            {
                imgPedra2.Visibility = Visibility.Visible;
                imgPato2.Visibility = Visibility.Hidden;
                imgPapel2.Visibility = Visibility.Hidden;
                imgTesoura2.Visibility = Visibility.Hidden;
            }
            else
            {
                imgTesoura2.Visibility = Visibility.Visible;
                imgPato2.Visibility = Visibility.Hidden;
                imgPedra2.Visibility = Visibility.Hidden;
                imgPapel2.Visibility = Visibility.Hidden;
            }

            if (imgPapel.Visibility == Visibility.Visible && imgPedra2.Visibility == Visibility.Visible)
            {
                txtVencedor.Text = "Jogador Vencedor";
                txtVencedor.Visibility = Visibility.Visible;
                GanhadosVC++;
                txtGanhouVC.Text = $"{GanhadosVC}";
                txtGanhouPC.Text = $"{GanhadosPC}";

                Stream audio = Properties.Resources.SomPato;
                SoundPlayer player = new SoundPlayer(audio);
                player.Play();

            }
            else if (imgPapel.Visibility == Visibility.Visible && imgTesoura2.Visibility == Visibility.Visible)
            {
                txtVencedor.Text = "Computador Vencedor";
                txtVencedor.Visibility = Visibility.Visible;
                GanhadosPC++;
                txtGanhouVC.Text = $"{GanhadosVC}";
                txtGanhouPC.Text = $"{GanhadosPC}";

                Stream audio2 = Properties.Resources.SomRodolfo;
                SoundPlayer player2 = new SoundPlayer(audio2);
                player2.Play();

            }
            else if (imgPapel.Visibility == Visibility.Visible && imgPapel2.Visibility == Visibility.Visible)
            {
                txtVencedor.Text = "Empatou";
                txtVencedor.Visibility = Visibility.Visible;
                txtGanhouVC.Text = $"{GanhadosVC}";
                txtGanhouPC.Text = $"{GanhadosPC}";
            }
        }

        private void ClickTesoura(object sender, RoutedEventArgs e)
        {
            imgPato.Visibility = Visibility.Hidden;
            imgPapel.Visibility = Visibility.Hidden;
            imgPedra.Visibility = Visibility.Hidden;
            imgTesoura.Visibility = Visibility.Visible;

            Random random = new Random();
            int NumeroSorteado = random.Next(0, 3);
            if (NumeroSorteado == 0)
            {
                imgPapel2.Visibility = Visibility.Visible;
                imgPato2.Visibility = Visibility.Hidden;
                imgPedra2.Visibility = Visibility.Hidden;
                imgTesoura2.Visibility = Visibility.Hidden;
            }
            else if (NumeroSorteado == 1)
            {
                imgPedra2.Visibility = Visibility.Visible;
                imgPato2.Visibility = Visibility.Hidden;
                imgPapel2.Visibility = Visibility.Hidden;
                imgTesoura2.Visibility = Visibility.Hidden;
            }
            else
            {
                imgTesoura2.Visibility = Visibility.Visible;
                imgPato2.Visibility = Visibility.Hidden;
                imgPedra2.Visibility = Visibility.Hidden;
                imgPapel2.Visibility = Visibility.Hidden;
            }

            if (imgTesoura.Visibility == Visibility.Visible && imgPapel2.Visibility == Visibility.Visible)
            {
                txtVencedor.Text = "Jogador Vencedor";
                txtVencedor.Visibility = Visibility.Visible;
                GanhadosVC++;
                txtGanhouVC.Text = $"{GanhadosVC}";
                txtGanhouPC.Text = $"{GanhadosPC}";

                Stream audio = Properties.Resources.SomPato;
                SoundPlayer player = new SoundPlayer(audio);
                player.Play();

            }
            else if (imgTesoura.Visibility == Visibility.Visible && imgPedra2.Visibility == Visibility.Visible)
            {
                txtVencedor.Text = "Computador Vencedor";
                txtVencedor.Visibility = Visibility.Visible;
                GanhadosPC++;
                txtGanhouVC.Text = $"{GanhadosVC}";
                txtGanhouPC.Text = $"{GanhadosPC}";

                Stream audio2 = Properties.Resources.SomRodolfo;
                SoundPlayer player2 = new SoundPlayer(audio2);
                player2.Play();

            }
            else if (imgTesoura.Visibility == Visibility.Visible && imgTesoura2.Visibility == Visibility.Visible)
            {
                txtVencedor.Text = "Empatou";
                txtVencedor.Visibility = Visibility.Visible;
                txtGanhouVC.Text = $"{GanhadosVC}";
                txtGanhouPC.Text = $"{GanhadosPC}";
            }

        }

        private void OcultarImagens()
        {
            imgPapel.Visibility = Visibility.Hidden;
            imgPedra.Visibility = Visibility.Hidden;
            imgTesoura.Visibility = Visibility.Hidden;

            imgPapel2.Visibility = Visibility.Hidden;
            imgPedra2.Visibility = Visibility.Hidden;
            imgTesoura2.Visibility = Visibility.Hidden;

        }

        private void ClickFechar(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void ClickReset(object sender, RoutedEventArgs e)
        {
            GanhadosVC = 0;
            GanhadosPC = 0;
            OcultarImagens();
            txtVencedor.Visibility = Visibility.Hidden;
            imgPato.Visibility = Visibility.Visible;
            imgPato2.Visibility = Visibility.Visible;
            txtGanhouVC.Text = $"{GanhadosVC}";
            txtGanhouPC.Text = $"{GanhadosPC}";
        }
    }
}
