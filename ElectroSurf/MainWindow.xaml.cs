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

namespace ElectroSurf
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Resistencia
        ColoresResistencia colores = new ColoresResistencia();
        Resistencia resiRef = new Resistencia();
        double[] resistencia = new double[50];
        int numRes = 0;
        int contRes = 1;
        int subfijRes = 2;
        #endregion
        #region Capacitor
        double[] capacitores = new double[50];
        int numCap = 1;
        int subfijCap = 2;

        #endregion
        #region Inductor
        Inductor InductorRef = new Inductor();
        #endregion
        public MainWindow()
        {
            InitializeComponent();

        }




        #region Pruebas y basura

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Resistencia resi = new Resistencia();
            resi.Banda1 = 2;
            resi.Banda2 = 2;
            resi.Multip = 1;
            double tot = resi.BandasARes();
            MessageBox.Show(Convert.ToString(tot)+" Ohms");
            

        }
        private void button_Click_1(object sender, RoutedEventArgs e)
        {
            // recBanda1.Fill = new SolidColorBrush(Colors.Aqua);
            recBanda1.Fill = new SolidColorBrush(colores.negro);
        }
        private void Rectangle_DragLeave(object sender, DragEventArgs e)
        {

        }
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            //recBanda1.Fill = new SolidColorBrush(Colors.Blue);
        }
        private void button_Click_2(object sender, RoutedEventArgs e)
        {

        }
        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void cbSerPar_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        #endregion
        #region Combobox Codigo de resistencias
        private void comboBox_DropDownClosed(object sender, EventArgs e)
        {
            switch (comboBox.SelectionBoxItem.ToString())
            {
                case  "0":
                    resiRef.Banda1 = 0;
                    break;
                case "1":
                    resiRef.Banda1 = 1;
                    break;
                case "2":
                    resiRef.Banda1 = 2;
                    break;
                case "3":
                    resiRef.Banda1 = 3;
                    break;
                case "4":
                    resiRef.Banda1 = 4;
                    break;
                case "5":
                    resiRef.Banda1 = 5;
                    break;
                case "6":
                    resiRef.Banda1 = 6;
                    break;
                case "7":
                    resiRef.Banda1 = 7;
                    break;
                case "8":
                    resiRef.Banda1 = 8;
                    break;
                case "9":
                    resiRef.Banda1 = 9;
                    break;
                default:
                    break;

            }
            gradiente1.Color = resiRef.Banda1Color;
            recBanda1.Fill = new SolidColorBrush(resiRef.Banda1Color);
            tbResistOmga.Text = resiRef.BandasAResInteliString();
            tbResistNum.Text = Convert.ToString( resiRef.BandasARes());
            resiRef.Resist = resiRef.BandasARes();
        }

        private void comboBox2_DropDownClosed(object sender, EventArgs e)
        {
            switch (comboBox2.SelectionBoxItem.ToString())
            {
                case "0":
                    resiRef.Banda2 = 0;
                    break;
                case "1":
                    resiRef.Banda2 = 1;
                    break;
                case "2":
                    resiRef.Banda2 = 2;
                    break;
                case "3":
                    resiRef.Banda2 = 3;
                    break;
                case "4":
                    resiRef.Banda2 = 4;
                    break;
                case "5":
                    resiRef.Banda2 = 5;
                    break;
                case "6":
                    resiRef.Banda2 = 6;
                    break;
                case "7":
                    resiRef.Banda2 = 7;
                    break;
                case "8":
                    resiRef.Banda2 = 8;
                    break;
                case "9":
                    resiRef.Banda2 = 9;
                    break;
                default:
                    break;

            }
            gradiente2.Color = resiRef.Banda2Color;
            recBanda2.Fill = new SolidColorBrush(resiRef.Banda2Color);
            tbResistOmga.Text = resiRef.BandasAResInteliString();
            tbResistNum.Text = Convert.ToString(resiRef.BandasARes());
            resiRef.Resist = resiRef.BandasARes();

        }

        private void comboBox3_DropDownClosed(object sender, EventArgs e)
        {
            switch (comboBox3.SelectionBoxItem.ToString())
            {
                case "0":
                    resiRef.Multip = 0;
                    break;
                case "1":
                    resiRef.Multip = 1;
                    break;
                case "2":
                    resiRef.Multip = 2;
                    break;
                case "3":
                    resiRef.Multip = 3;
                    break;
                case "4":
                    resiRef.Multip = 4;
                    break;
                case "5":
                    resiRef.Multip = 5;
                    break;
                case "6":
                    resiRef.Multip = 6;
                    break;
                case "7":
                    resiRef.Multip = 7;
                    break;
                case "8":
                    resiRef.Multip = 8;
                    break;
                case "9":
                    resiRef.Multip = 9;
                    break;
                case "Dorado":
                    resiRef.Multip = 10;
                    break;
                case "Plateado":
                    resiRef.Multip = 11;
                    break;

                default:
                    break;

            }
            gradiente3.Color = resiRef.MultipColor;
            recBandaMul.Fill = new SolidColorBrush(resiRef.MultipColor);
            tbResistOmga.Text = resiRef.BandasAResInteliString();
            tbResistNum.Text = Convert.ToString(resiRef.BandasARes());
            resiRef.Resist = resiRef.BandasARes();

        }

        private void comboBox4_DropDownClosed(object sender, EventArgs e)
        {
            switch (comboBox4.SelectionBoxItem.ToString())
            {
                case "0":
                    resiRef.Toler = 0;
                    break;
                case "1":
                    resiRef.Toler = 1;
                    break;
                case "2":
                    resiRef.Toler = 2;
                    break;
                case "3":
                    resiRef.Toler = 3;
                    break;
                case "4":
                    resiRef.Toler = 4;
                    break;
                case "5":
                    resiRef.Toler = 5;
                    break;
                case "6":
                    resiRef.Toler = 6;
                    break;
                case "7":
                    resiRef.Toler = 7;
                    break;
                case "8":
                    resiRef.Toler = 8;
                    break;
                case "9":
                    resiRef.Toler = 9;
                    break;
                case "Dorado":
                    resiRef.Toler = 10;
                    break;
                case "Plateado":
                    resiRef.Toler = 11;
                    break;
                case "Ninguno":
                    resiRef.Toler = 12;
                    break;
                default:
                    break;

            }
            gradiente4.Color = resiRef.TolerColor;
            recBandaTol.Fill = new SolidColorBrush(resiRef.TolerColor);
            tbTolerancia.Text = resiRef.BandaTolAString();
            resiRef.Resist = resiRef.BandasARes();

        }
        #endregion
        #region Guardado y operación con resistencias
        private void Nuevo_Click(object sender, RoutedEventArgs e)
        {
            if (subfijRes <= 49)
            {
                contRes++;
                subfijRes++;
                cbGuardar.Items.Add("Resistencia " + subfijRes);
                cbSerPar.Items.Add("Resistencia " + subfijRes);
                cbSerPar.SelectedIndex = contRes;
                cbGuardar.SelectedIndex = contRes;
                tbValorSP.Text = "0";
                lValorSP.Content = "0 Ω";
            }
            else
            {
                MessageBox.Show("Ha excedido el límite de resistencias (50)");
            }
            
        }

        private void Guardar_Click(object sender, RoutedEventArgs e)
        {
            resistencia[cbGuardar.SelectedIndex] = resiRef.Resist;
            numRes = cbGuardar.SelectedIndex + 1;
            string menResGuard = "Valor guardado en Resistencia " + numRes +"\n"+ resistencia[cbGuardar.SelectedIndex]+ " Ω";
            MessageBox.Show(menResGuard);
            if(cbGuardar.SelectedIndex == cbSerPar.SelectedIndex)
            {
                lValorSP.Content = resiRef.BandasAResInteliString();
                tbValorSP.Text = ""+resiRef.Resist;
            }

        }



        private void tbValorSP_TextChanged(object sender, TextChangedEventArgs e)
        {
            double ValorDeConver;
            if(double.TryParse(tbValorSP.Text, out ValorDeConver))//comprobar que lo introducido sea un valor double
            {
                try
                {
                    resistencia[cbSerPar.SelectedIndex] = ValorDeConver;
                    lValorSP.Content = resiRef.BandasAResInteliString(ValorDeConver);
                }
                catch (NullReferenceException)
                {

                }
            }
            else if (tbValorSP.Text == "")
            {
                resistencia[cbSerPar.SelectedIndex] = 0;
                lValorSP.Content = "0 Ω";
            }
            else
            {
                MessageBox.Show("El valor ingresado no es aceptado! \n Ingrese sólo números");
                tbValorSP.Text = "" + resistencia[cbSerPar.SelectedIndex];
                lValorSP.Content = "" + resiRef.BandasAResInteliString(resistencia[cbSerPar.SelectedIndex]);
            }
        }

        private void cbSerPar_DropDownClosed(object sender, EventArgs e)
        {
            tbValorSP.Text = Convert.ToString(resistencia[cbSerPar.SelectedIndex]);
            lValorSP.Content = resiRef.BandasAResInteliString(resistencia[cbSerPar.SelectedIndex]);
        }

        private void button_Click_3(object sender, RoutedEventArgs e)
        {
            if (rbSerie.IsChecked==true)//calcular serie
            {
                tbResultadoResistencias.Text = "" + Resistencia.ResistenciaSerie(resistencia);
            }
            else if (rbParalelo.IsChecked == true)//Calcular paralelo
            {
                
                tbResultadoResistencias.Text = "" + Resistencia.ResistenciaParalelo(resistencia);
            }
            else
            {
                MessageBox.Show("Seleccione serie o paralelo");
            }
        }

        private void rbSerie_Checked(object sender, RoutedEventArgs e)
        {
            imageSerie.Visibility = Visibility.Visible;
            imageParalelo.Visibility = Visibility.Hidden;
        }

        private void rbParalelo_Checked(object sender, RoutedEventArgs e)
        {
            imageSerie.Visibility = Visibility.Hidden;
            imageParalelo.Visibility = Visibility.Visible;
        }

        #endregion

        #region Capacitor
        private void btNuevoCap_Click(object sender, RoutedEventArgs e)
        {
            if (subfijCap <= 49)
            {
                numCap++;
                subfijCap++;
                cbCapacitores.Items.Add("Capacitor "+subfijCap);
                cbCapacitores.SelectedIndex = numCap;
                
                tbValCap.Text = "0";
                capacitores[cbCapacitores.SelectedIndex] = 0;

            }
            else
            {
                MessageBox.Show("Ha excedido el número de capacitores (50)");
            }
        }

        private void tbValCap_TextChanged(object sender, TextChangedEventArgs e)
        {
            double valor;
            if(double.TryParse(tbValCap.Text, out valor))
            {
                try
                {
                    capacitores[cbCapacitores.SelectedIndex] = valor;
                }
                catch (NullReferenceException)
                {

                }
            }
            else if (tbValCap.Text == "")
            {
                capacitores[cbCapacitores.SelectedIndex] = 0;
            }
            else
            {
                MessageBox.Show("El valor ingresado no es aceptado! \n Ingrese sólo números");
                tbValCap.Text = "" + capacitores[cbCapacitores.SelectedIndex];
            }
        }

        private void cbCapacitores_DropDownClosed(object sender, EventArgs e)
        {
            try
            {
                tbValCap.Text = "" + capacitores[cbCapacitores.SelectedIndex];

            }
            catch (NullReferenceException)
            {
                tbValCap.Text = "0";
            }
        }

        private void btCalcCap_Click(object sender, RoutedEventArgs e)
        {
            string resultado = "";
            if (rbCapSerie.IsChecked == true)
            {
                resultado = ""+ Capacitor.CapacitanciaSerie(capacitores);
                tbResultCap.Text = resultado;
            }
            else if (rbCapParalelo.IsChecked == true)
            {
                resultado = "" + Capacitor.CapacitanciaParalelo(capacitores);
                tbResultCap.Text = resultado;
            }
            else
            {
                MessageBox.Show("Seleccione serie o paralelo");
            }
            
        }
        #endregion

        #region Inductor
        private void tbDiametroBobina_TextChanged(object sender, TextChangedEventArgs e)
        {
            double valor;
            if(double.TryParse(tbDiametroBobina.Text, out valor))
            {
                InductorRef.Diametro = valor;
            }
            else if (tbDiametroBobina.Text == "")
            {

            }
            else
            {
                MessageBox.Show("Inserte sólo números");
            }
        }

        private void tbLongitudBobina_TextChanged(object sender, TextChangedEventArgs e)
        {
            double valor;
            if (double.TryParse(tbLongitudBobina.Text, out valor))
            {
                InductorRef.Longitud = valor;
            }
            else if (tbLongitudBobina.Text == "")
            {

            }
            else
            {
                MessageBox.Show("Inserte sólo números");
            }
        }

        private void tbNumeroVueltas_TextChanged(object sender, TextChangedEventArgs e)
        {
            double valor;
            if (double.TryParse(tbNumeroVueltas.Text, out valor))
            {
                InductorRef.Vueltas = valor;
            }
            else if (tbNumeroVueltas.Text == "")
            {

            }
            else
            {
                MessageBox.Show("Inserte sólo números");
            }
        }
        #endregion

        private void btInduct_Click(object sender, RoutedEventArgs e)
        {
            double basura;
            if (
                tbLongitudBobina.Text != "" &
                tbNumeroVueltas.Text != "" &
                tbDiametroBobina.Text != "" &
                double.TryParse(tbLongitudBobina.Text, out basura)&
                double.TryParse(tbNumeroVueltas.Text, out basura)&
                double.TryParse(tbDiametroBobina.Text, out basura))
            {
                tbInductancia.Text = "" + InductorRef.CalcInductancia();
            }
            else
            {
                MessageBox.Show("Llene los valores de manera adecuada!");
            }

        }
    }
}
