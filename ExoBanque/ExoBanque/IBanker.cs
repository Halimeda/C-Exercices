using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoBanque
{ /* Pas de champs ni de code logique
    C'est un contrat qui stipule les clauses à respecter*/

    public interface IBanker:ICustomer
    {

        string Numero { get; }
        Personne Titulaire { get;}
        void AppliquerInteret();

        //Correction exercice bonus sur les interfaces
        //double LigneCredit { get; set; }

    }
}
