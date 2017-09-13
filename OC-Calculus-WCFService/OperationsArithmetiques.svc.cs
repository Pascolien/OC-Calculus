using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Text.RegularExpressions;

namespace OC_Calculus_WCFService
{
    public class OperationsArithmetiques : IOperationsArithmetiques
    {
        public double Plus(double nb1, double nb2)
        {
            return nb1 + nb2;
        }

        public double Moins(double nb1, double nb2)
        {
            return nb1 - nb2;
        }

        public double Diviser(double nb1, double nb2)
        {
            return nb1 / nb2;
        }

        public double Multiplier(double nb1, double nb2)
        {
            return nb1 * nb2;
        }

        public bool EstMultipleDe(int nb1, int nb2)
        {
            return (nb1 % nb2) == 0; 
        }

        public int ChaineDAdditionsEntieres(string chaine)
        {

            int resultat = 0;
            string[] nombres = chaine.Split('+');

            if (nombres.Length > 0) // Traite le cas d'une chaîne avec des +
            {
                foreach (string nombre in nombres)
                {
                    resultat += Convert.ToInt32(nombre);
                }
            } else
            {
                if (chaine != "") // Traite le cas d'un seul nombre
                {
                    resultat = Convert.ToInt32(chaine);
                }
            }
            
            return resultat;
        }

        public double ChaineDAdditionsReelles(string chaine)
        {
            double resultat = 0;
            //With Regex pattern = new Regex("[,]|[.]");

            chaine = chaine.Replace(",", "."); 
            string[] nombres = chaine.Split('+');
            
            if(nombres.Length > 0)
            {
                foreach (string nombre in nombres)
                {
                    resultat += Convert.ToDouble(nombre);
                }
            } else
            {
                if(chaine != "")
                {
                    resultat = Convert.ToDouble(chaine);
                }
            }

            return resultat;
        }
        public int ChaineDAdditionsEtDeSoustractionsEntieres(string chaine)
        {
            chaine = chaine.Replace("-", "+-");
            return ChaineDAdditionsEntieres(chaine); 
        }
        public double ChaineDAdditionsEtDeSoustractionsReelles(string chaine)
        {
            chaine = chaine.Replace("-", "+-");
            return ChaineDAdditionsReelles(chaine);
        }
        public int ChaineDAdditionsEtSoustractionsEtMultiplicationsEntieres(string chaine)
        {
            int resultat = 0;
            chaine = chaine.Replace("-", "+-");
            chaine = chaine.Replace("*+", "*");

            string[] nombresAdditionner = chaine.Split('+');
            string[] nombresMultiplier;

            if (nombresAdditionner.Length > 0)
            {
                foreach (string strNombres in nombresAdditionner)
                {
                    if (strNombres != "")
                    {
                        int resultatMultiplication = 1;
                        nombresMultiplier = strNombres.Split('*');

                        foreach (string nombres in nombresMultiplier)
                        {
                            resultatMultiplication *= Convert.ToInt32(nombres);
                        }

                        resultat += resultatMultiplication;
                    }
                }
            }
            return resultat;
        }
    }
}
