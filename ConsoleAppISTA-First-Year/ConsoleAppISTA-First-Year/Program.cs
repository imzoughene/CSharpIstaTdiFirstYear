using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppISTA_First_Year
{
    interface TestInterface
    {
        double Propriete1 { get; }
        double Methode1(int X);
    }

    class implementation : TestInterface
    {

        private double attribut1;
        public double Propriete1 {

            get { return attribut1; }
            set { attribut1 = value; }
        }



        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public double Methode1(int X)
        {
            // throw new NotImplementedException();
            attribut1 = Math.Sqrt(X);
            return attribut1;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }



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
        //Destructeur
        //Garbage Collector
        //ramasse miettes
        ~vehicule()
        {
            //Destructeur GC.collect()
            //libération des ressources
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
        //Polymorphisme
        public virtual int getNumber()
        {
            return 6;
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


    class voiture : vehicule
    {
        private string attributA;
        public voiture():base()
        {

        }
        public voiture(string new_marque, int new_puissance, int new_vitesse_courante, int new_vitesse_maximale,string a) : base(new_marque,new_puissance,new_vitesse_courante,new_vitesse_maximale)
        {
            this.AttributA = a;
        }

        public string AttributA { get => attributA; set => attributA = value; }

        public void demarrer(string v)
        {
            AttributA += " bingo "+v;
        }


        //Polymorphisme
        public override int getNumber()
        {
            return 11;
        }


        public void demarrer(int x)
        {
            AttributA += x.ToString();
        }

        public override bool Equals(object obj)
        {
            //return base.Equals(obj);
            if (this.AttributA.Equals(((voiture)obj).AttributA))
            {
                return true;
            }
            else
            {
                return false;
            }
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


            //Polymorphisme
            vehicule[] my_vehicules= new vehicule[2];
            my_vehicules[0] = new vehicule();
            my_vehicules[1] = new voiture();
            for(int i = 0; i < my_vehicules.Length; i++)
            {
                Console.WriteLine(my_vehicules[i].getNumber());
            }
            Console.ReadLine();
        }
    }
}
