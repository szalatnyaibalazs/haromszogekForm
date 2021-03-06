﻿using System;
using System.Collections.Generic;

namespace haromszogek
{
    internal class Haromszog
    {
        private double aOldal;
        private double bOldal;
        private double cOldal;


        public double Terulet {get; private set;}
        public double Kerulet {get; private set;}
        public bool Szerkeztheto { get; private set; }

        private void Szerk()
        {
            if (aOldal + bOldal > cOldal && cOldal + bOldal > aOldal && aOldal + cOldal > bOldal)
            {
                Szerkeztheto = true;
                Terulet = TeruletSzamitas();
                Kerulet = KeruletSzamitas();
            }
            else 
            {
                Szerkeztheto = false;
                Terulet = 0;
                Kerulet = 0;
            }
        }

        private double TeruletSzamitas()
        {
            double s = (aOldal + bOldal + cOldal) / 2;
            return Math.Sqrt(s*(s - aOldal) * (s - bOldal) * (s - cOldal));
        }
        private double KeruletSzamitas()
        { 
            return aOldal + bOldal + cOldal;
        }
        public Haromszog(string sor)
        {
            string[] adatok = sor.Split(';');
            aOldal = Convert.ToDouble(adatok[0]);
            bOldal = Convert.ToDouble(adatok[1]);
            cOldal = Convert.ToDouble(adatok[2]);
            Szerk();
        }
        public Haromszog(double aOldal, double bOldal, double cOldal)
        {
            this.aOldal = aOldal;
            this.bOldal = bOldal;
            this.cOldal = cOldal;
            Szerk();
        }

        public Haromszog()
        {
        }

        public List<string> AdatokSzoveg()
        {
            List<string> adatok = new List<string>();
            adatok.Add($"a: {aOldal} b: {bOldal} c: {cOldal}");
            if (Szerkeztheto)
            {
                adatok.Add($"Terület:{Terulet:N2} Kerület {Kerulet:N2}");
            }
            else
            {
                adatok.Add("Nem szerkeszthető!");
            }

                
            return adatok;
        }
    }
}