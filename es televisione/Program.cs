using System;

namespace ProgettoTelevisore
{
    public class Schermo
    {
        public string Marca;
        public string Modello;
        public int Risoluzione;
        public int Dimensione;
        public int Prezzo;
        public bool Stato;
        public int CanaleAttuale;
        public int VolumeAttuale;

        public Schermo(string marca, string modello, int risoluzione, int dimensione, int prezzo)
        {
            Marca = marca;
            Modello = modello;
            Risoluzione = risoluzione;
            Dimensione = dimensione;
            Prezzo = prezzo;
            Stato = false; 
            CanaleAttuale = 1; 
            VolumeAttuale = 0; 
        }

        public void Accendi()
        {
            Stato = true;
            Console.WriteLine($"{Marca} {Modello}: Schermo acceso.");
        }

        public void Spegni()
        {
            Stato = false;
            Console.WriteLine($"{Marca} {Modello}: Schermo spento.");
        }

        public void CambiaCanale(int nuovoCanale)
        {
            if (Stato)
            {
                CanaleAttuale = nuovoCanale;
                Console.WriteLine($"{Marca} {Modello}: Canale cambiato a {CanaleAttuale}.");
            }
            else
            {
                Console.WriteLine($"{Marca} {Modello}: Lo schermo è spento. Accendilo prima di cambiare canale.");
            }
        }

        public void CambiaVolume(int nuovoVolume)
        {
            if (Stato)
            {
                VolumeAttuale = nuovoVolume;
                Console.WriteLine($"{Marca} {Modello}: Volume impostato a {VolumeAttuale}.");
            }
            else
            {
                Console.WriteLine($"{Marca} {Modello}: Lo schermo è spento. Accendilo prima di regolare il volume.");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Schermo s1 = new Schermo("Marca A", "Modello A", 1080, 42, 400);
            Schermo s2 = new Schermo("Marca A", "Modello B", 2160, 55, 700);

            s1.Accendi();
            s1.CambiaCanale(5);
            s1.CambiaVolume(3);

            s2.Accendi();
            s2.CambiaCanale(10);
            s2.CambiaVolume(10);

            Console.WriteLine($"\nTelevisore s1: Canale {s1.CanaleAttuale}, Volume {s1.VolumeAttuale}");
            Console.WriteLine($"Televisore s2: Canale {s2.CanaleAttuale}, Volume {s2.VolumeAttuale}");

            Console.ReadLine();
        }
    }
}
