﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppISTA_First_Year
{


    class vehicule
    {
        private string marque;
        private int puissance_fiscale;
        private int vitesse_courante;
        private int vitesse_maximale;

        public string Marque { get => marque; set => marque = value; }
        public int Puissance_fiscale { get => puissance_fiscale; set => puissance_fiscale = value; }
        public int Vitesse_courante { get => vitesse_courante; set => vitesse_courante = value; }
        public int Vitesse_maximale { get => vitesse_maximale; set => vitesse_maximale = value; }
        //constructeur d'initialisation
        public vehicule(string new_marque,int new_puissance,int new_vitesse_courante,int new_vitesse_maximale)
        {
            this.marque = new_marque;
            this.puissance_fiscale = new_puissance;
            this.vitesse_courante = new_vitesse_courante;
            this.vitesse_maximale = new_vitesse_maximale;
        }

        public vehicule(vehicule recopie)
        {
            this.marque = recopie.Marque;
            this.puissance_fiscale = recopie.Puissance_fiscale;
            this.vitesse_courante = recopie.Vitesse_courante;
            this.vitesse_maximale = recopie.Vitesse_maximale;
        }
        //constructeur par défaut
        public vehicule()
        {
            this.marque = "Marque inconu";
            this.puissance_fiscale = 0;
            this.vitesse_courante = 0;
            this.vitesse_maximale = 0;
        }

        public void creer_un_vehicule()
        {

        }
        public void detruire_un_vehicule()
        {

        }
        public void demarrer()
        {

        }
        public void accelerer(int taux)
        {
            this.vitesse_courante += taux;
            if (this.vitesse_courante > this.vitesse_maximale)
                this.vitesse_courante = this.vitesse_maximale;
        }
        public override string ToString()
        {
            //return base.ToString();
            return "Vehicule : " + this.marque.ToString() + " Vitesse : " + this.vitesse_courante + " / " + this.vitesse_maximale;
          
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            vehicule p = new vehicule();
            p.Marque = "Peugeot";
            p.Puissance_fiscale = 7;
            p.Vitesse_maximale = 197;
            p.Vitesse_courante = 432;
            vehicule q = new vehicule();
            q.Marque = "Renault";
            q.Puissance_fiscale = 13;
            q.Vitesse_maximale = 543;
            q.Vitesse_courante = 321;
            vehicule s = new vehicule("sovidias", 87, 987, 654);
            //constructeur de recopie
            vehicule recopie_s = new vehicule(s);


            Console.WriteLine(p.ToString());
            Console.WriteLine(q.ToString());
            recopie_s.accelerer(45);
            Console.WriteLine(recopie_s.ToString());
            Console.ReadLine();
        }
    }
}
