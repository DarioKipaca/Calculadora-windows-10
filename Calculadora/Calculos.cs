using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public static class Calculos
    {

        #region calculos da cientifica


        public static string Soma(string Parcela1, string Parcela2)
        {

            if(Parcela1.Contains(",")|| Parcela2.Contains(","))
            {
                double parce1 = double.Parse(Parcela1.Replace("+", ""));
                double parce2 = double.Parse(Parcela2);
                return formatando((parce1 + parce2).ToString());
            }
            else
            {
                int parce1 = int.Parse(Parcela1.Replace("+", ""));
                int parce2 = int.Parse(Parcela2);
                return formatando((parce1 + parce2).ToString());
             
            }
        
        }
        public static string subtracao(string Parcela1, string Parcela2)
        {

            if (Parcela1.Contains(",") || Parcela2.Contains(","))
            {
                double parce1 = double.Parse(Parcela1.Replace("-", ""));
                double parce2 = double.Parse(Parcela2);
                return formatando((parce1 - parce2).ToString());
            }
            else
            {
                int parce1 = int.Parse(Parcela1.Replace("-", ""));
                int parce2 = int.Parse(Parcela2);
                return  formatando((parce1 - parce2).ToString());
            }

        }
        public static string multiplicacao(string Parcela1, string Parcela2)
        {

            if(Parcela1.Contains("×")&& Parcela1.Contains("="))
            {
                string n = Parcela1.Substring(0, Parcela1.IndexOf("×")).Replace("=", "");
                double parce1 = double.Parse(n);
                double parce2 = double.Parse(Parcela2);
                return formatando((parce1 * parce2).ToString());

            }

            if (Parcela1.Contains(",") || Parcela2.Contains(","))
            {
                double parce1 = double.Parse(Parcela1.Replace("×", ""));
                double parce2 = double.Parse(Parcela2);
                return formatando((parce1 * parce2).ToString());
            }
            else
            {
                int parce1 = int.Parse(Parcela1.Replace("×", ""));
                int parce2 = int.Parse(Parcela2);
                return formatando((parce1 * parce2).ToString());
            }

        }
        public static string divisao(string Parcela1, string Parcela2)
        {

      
                string resolta = null;
                double parce1 = double.Parse(Parcela1.Replace("÷", ""));
                double parce2 = double.Parse(Parcela2);
                resolta=(parce1 / parce2).ToString();
                if (resolta.Contains(","))
                {
                    return resolta;
                }
                if (!resolta.Contains(",") && resolta.Length >= 4)
                {
                    return formatando(resolta);
                }
                else
                {
                    return resolta;
                }


                
            
          

        }
        public static string Pontencia(string Parcela1, string Parcela2)
        {


            double mult=0;
                double parce1 = double.Parse(Parcela1.Replace("^", ""));
                double parce2 = double.Parse(Parcela2);
            mult = parce1;
            if (parce2 == 0)
            {
                return "0";
            }
            if (parce2 == 1)
            {
                return parce1.ToString();
            }
            for (double i = 2; i <= parce2; i++)
            {
                mult *= parce1;
            }
                return formatando(mult.ToString());
          

        }
        public static string Raiz(string valor)
        {

            double v = double.Parse(valor);
            string resoltado = Math.Sqrt(v).ToString();
            if (resoltado.Contains(","))
            {
                return resoltado;
            }
            if (!resoltado.Contains(",") && resoltado.Length >= 4)
            {
                return formatando(resoltado);
            }
            else
            {
                return resoltado;
            }
            
         
          
        }
      
        private static string formatando (string valor)
        {

            try
            {
                if (valor.Length <= 3)
                {
                    return valor;
                }



                string saida = string.Empty;
                string achado = string.Empty;
                string n = string.Empty;
                double v = 0;
                n = valor.Replace(",", "").Replace(".", "");
               
                v = Convert.ToDouble(n) ;
                saida = string.Format("{0:N0}", v);
                return saida;


            }
            catch
            {


                return "0";

            }
            

        }
        public static string multiOperacao(string valores)
        {
            string mult;
            string[] multiplicao;
            string[] divisao;
            string[] adicao;
            string[] subtracao;
            int cont = 0;
            if (valores.Contains("×"))
            {
              multiplicao = valores.Split('×');
            }


            return null;

        }
        #endregion

        #region calculos comprimento
        public static string Comprimento(string combo1, string combo2, string valor)
        {
            double v = double.Parse(valor);
            #region conversão Quilómetros

            if (combo1 == "Quilómetros" && combo2 == "Metros")
            {

                return (v * 1000).ToString("N");
            }
            if (combo1 == "Quilómetros" && combo2 == "Centímetros")
            {

                return (v * 100000).ToString("N"); 
            }
            if (combo1 == "Quilómetros" && combo2 == "Milímetros")
            {

                return (v * 1000000).ToString("N"); 
            }
            if (combo1 == "Quilómetros" && combo2 == "Polegadas")
            {

                return (v * 39370.08).ToString("N"); 
            }

            if (combo1 == "Quilómetros" && combo2 == "Milhas")
            {

                return (v * 0.621371).ToString("N");
            }
            #endregion
            return null;
        }
        #endregion

        #region Calculos tempo



        public static string Tempo(string combo1, string combo2, string valor)
        {
            double v = double.Parse(valor);
            #region conversão minutos

      
            if (combo1 == "Minutos" && combo2 == "Horas")
            {

                return (v * 60000).ToString();
            }
            if (combo1 == "Minutos" && combo2 == "Milissegundos")
            {

                return (v * 0.0166667).ToString();
            }
            if (combo1 == "Minutos" && combo2 == "Segundos")
            {

                return (v * 60).ToString();
            }
            if (combo1 == "Minutos" && combo2 == "Dias")
            {

                return (v * 0.000694444).ToString();
            }
            if (combo1 == "Minutos" && combo2 == "Semanas")
            {

                return (v * 0.0000992063).ToString();
            }
            if (combo1 == "Minutos" && combo2 == "anos")
            {

                return (v * 0.00000190129).ToString();
            }
            if (combo1 == "Minutos" && combo2 == "Minutos")
            {

                return (v * 1).ToString();
            }
            #endregion
            return null;


        }


        #endregion


    }
}
