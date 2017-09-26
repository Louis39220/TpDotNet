using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WSConvertisseur.Models
{
    public class Devise
    {
        public int id { get; set; }
        public string nom { get; set; }
        public double taux { get; set; }

        public Devise()
        {

        }

        public Devise(int id, string nom, double taux)
        {
            this.id = id;
            this.nom = nom;
            this.taux = taux;
        }

        

    }
}