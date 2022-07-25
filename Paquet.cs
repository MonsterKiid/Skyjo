using System;
using System.Collections.Generic;
using System.Linq;

namespace Skyjo
{
    internal class Paquet : List<Carte>
    {

        private List<Carte> cartes;
        public Paquet()
        {
            this.cartes = new List<Carte>();
        }

        public void Remplir()
        {
            for (int i = 0; i < 5; i++)
            {
                this.cartes.Add(new Carte(-2,true));
            }
            for (int i = 0; i < 15; i++)
            {
                this.cartes.Add(new Carte(0,true));
            }
            for (int i = 1; i <= 12; i++)
            {
                if (i == 0) i = -1;
                for (int j = 0; j < 10; j++)
                {
                    this.cartes.Add(new Carte(i,true));
                }
            }
        }

        public void Melanger()
        {
            var rdm = new Random();
            var cartes = this.cartes.OrderBy(item => rdm.Next()).ToList<Carte>();
            this.cartes.Clear();
            this.cartes.AddRange(cartes);
        }

        public List<Carte> getCartes()
        {
            return this.cartes;
        }

        public List<Carte> getCartesVisibles()
        {
            List<Carte> res = new List<Carte>();
            foreach(Carte carte in this.cartes)
            {
                if(carte.estVisible())
                {
                    res.Add(carte);
                }
            }
            return res;
        }

        public List<Carte> getCartesCachees()
        {
            List<Carte> res = new List<Carte>();
            foreach (Carte carte in this.cartes)
            {
                if (!carte.estVisible())
                {
                    res.Add(carte);
                }
            }
            return res;
        }

        public int getPoints()
        {
            int points = 0;
            for (int i = 0; i < this.cartes.Count; i++)
            {
                if(this.cartes[i].estVisible()) points += this.cartes[i].getValeur();
            }
            return points;
        }

        public int getTotalPoints()
        {
            int points = 0;
            for (int i = 0; i < this.cartes.Count; i++)
            {
                points += this.cartes[i].getValeur();
            }
            return points;
        }
    }
}