using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoBanque
{
    public interface ICustomer
    {
        double Solde { get; }
        void Retrait(double somme);
        void Depot(double somme);

    }
}
