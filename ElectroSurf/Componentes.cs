using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace ElectroSurf
{
    public class Resistencia
    {
        ColoresResistencia Colores = new ColoresResistencia();

        private double resist=0;
        private int banda1=0;
        private int banda2=0;
        private int multip=0;
        private int toler=0;
        private Color banda1Color = Color.FromRgb(0, 0, 0);
        private Color banda2Color = Color.FromRgb(0, 0, 0);
        private Color multipColor = Color.FromRgb(0, 0, 0);
        private Color tolerColor = Color.FromRgb(189, 172, 61);
        private double temperatura;
        private double watts;

        #region Propiedades
        public double Resist
        {
            get { return resist; }
            set
            {
                resist = value;
            }
        }
        public int Banda1
        {
            get { return banda1; }
            set
            {
                if (value >= 0 & value <= 9)
                    banda1 = value;
                banda1Color = BandaAcolor(banda1);
            }
        }
        public int Banda2
        {
            get { return banda2; }
            set
            {
                if (value >= 0 & value <= 9)
                    banda2 = value;
                banda2Color = BandaAcolor(banda2);

            }
        }
        public int Multip
        {
            get { return multip; }
            set
            {
                if (value >= 0 & value <= 11)
                    multip = value;
                multipColor = BandaAcolor(multip);

            }
        }
        public int Toler
        {
            get { return toler; }
            set
            {
                if (value >= 0 & value <= 12)
                    toler = value;
                tolerColor = BandaAcolor(toler);
            }
        }
        public double Temperatura
        {
            get { return temperatura; }
            set { temperatura = value; }
        }
        public double Watts
        {
            get { return watts; }
            set { watts = value; }
        }
        #region Banda colores
        public Color Banda1Color
        {
            get { return banda1Color; }
        }
        public Color Banda2Color
        {
            get { return banda2Color; }
        }
        public Color MultipColor
        {
            get { return multipColor; }
        }
        public Color TolerColor
        {
            get { return tolerColor; }
        }
        #endregion
        #endregion

        #region Métodos

        /// <summary>
        /// Convierte el código de colores por bandas al valor de las resistencias.
        /// </summary>
        /// <param name="resistencia">Resistencia con parámetros de bandas</param>
        /// <returns></returns>
        public double BandasARes()
        {
            int p;
            double m=1;
            double sumBandas = (Convert.ToDouble(this.Banda1) * 10) + Convert.ToDouble(this.Banda2);
            if (this.Multip != 0 & this.Multip<= 9)
            {
                for (p = 1; p <= this.Multip; p++)
                {
                    m = m * 10;
                }
            }
            else if (this.Multip== 10)
            {
                m = 0.1;
            }
            else if (this.Multip == 11)
            {
                m = m/100;
            }
            double total = sumBandas * m;
            return total;

        }

        /// <summary>
        /// Convierte el código de colores por bandas al valor de las resistencias sin el multiplicador.
        /// </summary>
        /// <returns></returns>
        public double BandasAResSNMulti()
        {
            double sumBandas = (Convert.ToDouble(this.Banda1) * 10) + Convert.ToDouble(this.Banda2);
            return sumBandas;
        }

        /// <summary>
        /// Regresa un valor en string con múltiplos de la resistencia (mΩ, Ω, kΩ, MΩ, GΩ, TΩ).
        /// </summary>
        /// <returns></returns>
        public string BandasAResInteliString()
        {
            double repo;
            string respuesta= "";
            if( this.BandasARes() == 0)
            {
                respuesta = "0 Ω";

            }
            else if (this.BandasARes() > 0 & this.BandasARes() < 1)
            {
                repo = this.BandasARes() / 0.001;
                respuesta = "" + repo + " mΩ";

            }
            else if (this.BandasARes() >= 1 & this.BandasARes() < 1000)
            {
                respuesta = Convert.ToString(this.BandasARes()) + " Ω";
            }
            else if (this.BandasARes() >= 1000 & this.BandasARes() < 1000000)
            {
                repo = this.BandasARes() / 1000;
                respuesta = "" + repo + " kΩ";

            }
            else if (this.BandasARes() >= 1000000 & this.BandasARes() < 1000000000)
            {
                repo = this.BandasARes() / 1000000;
                respuesta = "" + repo + " MΩ";

            }
            else if (this.BandasARes() >= 1000000000 & this.BandasARes() < 1000000000000)
            {
                repo = this.BandasARes() / 1000000000;
                respuesta = "" + repo + " GΩ";

            }
            else if (this.BandasARes() >= 1000000000000)
            {
                repo = this.BandasARes() / 1000000000000;
                respuesta = "" + repo + " TΩ";
            }
            else
            {
                respuesta = "Valor inválido";
            }
            return (respuesta);
        }
        public string BandasAResInteliString(double res)
        {
            double repo;
            string respuesta = "";
            if (res == 0)
            {
                respuesta = "0 Ω";

            }
            else if (res > 0 & res < 1)
            {
                repo = res / 0.001;
                respuesta = "" + repo + " mΩ";

            }
            else if (res >= 1 & res < 1000)
            {
                respuesta = Convert.ToString(res) + " Ω";
            }
            else if (res >= 1000 & res < 1000000)
            {
                repo = res / 1000;
                respuesta = "" + repo + " kΩ";

            }
            else if (res >= 1000000 & res < 1000000000)
            {
                repo = res / 1000000;
                respuesta = "" + repo + " MΩ";

            }
            else if (res >= 1000000000 & res < 1000000000000)
            {
                repo = res / 1000000000;
                respuesta = "" + repo + " GΩ";

            }
            else if (res >= 1000000000000)
            {
                repo = res / 1000000000000;
                respuesta = "" + repo + " TΩ";
            }
            else
            {
                respuesta = "Valor inválido";
            }
            return (respuesta);
        }


        public string BandaTolAString()
        {
            string respuesta = "";
            switch (this.Toler)
            {
                case 0://negro

                    break;
                case 1://Marrón
                    respuesta = "±1%";
                    break;
                case 2://Rojo
                    respuesta = "±2%";
                    break;
                case 3://Naranja
                    
                    break;
                case 4://Amarillo
                    respuesta = "±4%";

                    break;
                case 5://Verde
                    respuesta = "±0.5%";
                    break;
                case 6://Azul
                    respuesta = "±0.25%";
                    break;
                case 7://Morado
                    respuesta = "±0.1%";
                    break;
                case 8://Gris
                    respuesta = "±0.05%";
                    break;
                case 9://Blanco
                  
                    break;
                case 10://Dorado
                    respuesta = "±5%";
                    break;
                case 11://Plateado
                    respuesta = "±10%";
                    break;
                case 12:
                    respuesta = "±20%";
                    break;
                default:

                    break;
                    
            }
            return (respuesta);
        }

        public Color BandaAcolor(int banda)
        {
            Color palet = Color.FromRgb(0, 0, 0);
            switch (banda)
            {
                case 0://negro

                    palet = Colores.negro;
                    break;
                case 1://Marrón
                    palet = Colores.marron;
                    break;
                case 2://Rojo
                    palet = Colores.rojo;
                    break;
                case 3://Naranja
                    palet = Colores.naranja;
                    break;
                case 4://Amarillo
                    palet = Colores.amarillo;
                    break;
                case 5://Verde
                    palet = Colores.verde;
                    break;
                case 6://Azul
                    palet = Colores.azul;
                    break;
                case 7://Morado
                    palet = Colores.morado;
                    break;
                case 8://Gris
                    palet = Colores.gris;
                    break;
                case 9://Blanco
                    palet = Colores.blanco;
                    break;
                case 10://Dorado
                    palet = Colores.dorado;
                    break;
                case 11://Plateado
                    palet = Colores.plateado;
                    break;
                case 12:
                    palet = Colores.sincolor;
                    break;
                default:

                    break;

            }
            return (palet);
        }

        public static double ResistenciaParalelo(double[] resist)
        {
            double result=0;
            foreach (double elemento in resist)
            {
                if (elemento != 0)
                {
                    result+= (1 / elemento);
                }
            }
            if(result != 0)
            {
                result = 1 / result;
            }
            return result;

        }
        public static double ResistenciaSerie(double[] resist)
        {
            double result = 0;
            foreach (double elemento in resist)
            {
                if (elemento != 0)
                {
                    result = result + elemento;
                }
            }
            
            return result;

        }

        #endregion

    }
    public class Capacitor
    {
        private double capacitancia;
        private double carga;
        private double reactancia;

        public double Capacitancia
        {
            get { return capacitancia; }
            set
            {
                capacitancia = value;
            }
        }
        public static double CapacitanciaSerie (double[] cap)
        {
            double respuesta = 0;
            foreach (double capacit in cap)
            {
                if (capacit != 0)
                {
                    respuesta += (1/capacit);
                }

            }
            if (respuesta != 0)
            {
                respuesta = 1 / respuesta;

            }
            return respuesta;
        }
        public static double CapacitanciaParalelo(double[] cap)
        {
            double respuesta = 0;
            foreach (double capacit in cap)
            {
                if (capacit != 0)
                {
                    respuesta += capacit;
                }

            }
           
            return respuesta;
        }

    }
    public class Inductor
    {
        private double inductancia=0;
        private double diametro=0;
        private double longitud=0;
        private double vueltas=0;

        public double Inductancia
        {
            get { return inductancia; }
            set { inductancia = value; }
        }
        public double Diametro
        {
            get { return diametro; }
            set { diametro = value; }
        }
        public double Longitud
        {
            get { return longitud; }
            set { longitud = value; }
        }
        public double Vueltas
        {
            get { return vueltas; }
            set { vueltas = value; }
        }

        public double CalcInductancia()
        {
            double resultado;
            resultado = (this.diametro * this.diametro * this.vueltas * this.vueltas) / ((18 * this.diametro) + (40 * this.longitud));
            return resultado;
        }
    }

}
