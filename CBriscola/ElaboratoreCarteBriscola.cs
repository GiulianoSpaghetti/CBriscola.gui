using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace CBriscola
{
    class ElaboratoreCarteBriscola : ElaboratoreCarte  
    {
		private int numeroCarte = 40;
		private bool[] doppione;
		int cartaBriscola;
		bool inizio, briscolaDaPunti;
		Random rand;

		public ElaboratoreCarteBriscola(bool punti)
		{
			int i;
			doppione = new bool[numeroCarte];
			for (i = 0; i < numeroCarte; i++)
				doppione[i]=false;
			rand = new Random();
			cartaBriscola = 0;
			inizio = true;
			briscolaDaPunti = punti;
		}

		public int GetCarta()
		{
			// TODO Auto-generated method stub
			int fine = rand.Next(numeroCarte);
			int carta = (fine + 1) % numeroCarte;
			int valore;
			while (doppione[carta] && carta != fine)
				carta = (carta + 1) % numeroCarte;
			if (doppione[carta])
				throw new IndexOutOfRangeException("Chiamato elaboratoreCarteBriscola::getCarta quando non ci sono più carte da elaborare");
			else
			{
				if (inizio)
				{
					valore = carta % 10;
					if (!briscolaDaPunti && (valore == 0 || valore == 2 || valore > 6))
						carta = carta - valore + 1;
					cartaBriscola = carta;
					inizio = false;
				}
				doppione[carta]=true;
			}
			return carta;
		}

		public int GetCartaBriscola() { return cartaBriscola; }
		public int GetNumeroCarte() { return numeroCarte; }

	}
}
