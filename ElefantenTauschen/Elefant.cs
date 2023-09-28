using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ElefantenTauschen
{
    class Elefant
    {
        string name;
        public string Name
        {
            get { return name; }
            set
            {
                MessageBox.Show("meinen Namen kannst du nicht ändern.");

            }
        }
        int ohrengroesse;
        public int Ohrengröße
        {
            get { return ohrengroesse; }
            set { }
        }
        int elefantenGröße;
        public int ElefantenGröße
        {
            get { return elefantenGröße; }
            set
            {
                elefantenGröße = value;
                ohrengroesse = elefantenGröße / 5;
            }
        }

        public Elefant(string Elefantenname, int Größe)
        {
            name = Elefantenname;
            ElefantenGröße = Größe;
            MessageBox.Show("Hier bin ich: " + name + ". Ich bin " + elefantenGröße + "cm groß und meine Ohren sind " + ohrengroesse + "cm lang.");
        }

        public string WerBinIch()
        {
            return "Hallo! Ich bin " + name + ". Meine Ohren sind " + ohrengroesse + "cm lang.";
        }

        public string WieGroßBinIch()
        {
            return "Hallo! Ich bin " + name + ". Ich bin " + elefantenGröße + " groß.";
        }
    }
}
