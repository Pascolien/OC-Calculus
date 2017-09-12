using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace OC_Calculus_WCFService
{
    public class OperationsArithmetiques : IOperationsArithmetiques
    {
        public double Plus(double nb1, double nb2)
        {
            //TODO
        }

        public double Moins(double nb1, double nb2)
        {
            //TODO
        }

        public double Diviser(double nb1, double nb2)
        {
            //TODO
        }

        public double Multiplier(double nb1, double nb2)
        {
            //TODO
        }

        public bool EstMultipleDe(int nb1, int nb2)
        {
            //TODO
        }

        public int ChaineDAdditionsEntieres(string chaine)
        {
            //TODO
        }

        public double ChaineDAdditionsReelles(string chaine)
        {
            //TODO
        }
        public int ChaineDAdditionsEtDeSoustractionsEntieres(string chaine)
        {
            //TODO
        }
        public double ChaineDAdditionsEtDeSoustractionsReelles(string chaine)
        {
            //TODO
        }
        public int ChaineDAdditionsEtSoustractionsEtMultiplicationsEntieres(string chaine)
        {
            //TODO
        }
    }
}
