using System;
using System.Collections.Generic;
using System.Text;

namespace CBriscola
{
    class Giocatore
	{
		private String nome;
		private Carta[] mano;
		private bool ordinaMano;
		private int numeroCarte;
		private int iCartaGiocata;
		private int punteggio;
		private int nessunaCartaGiocata;
		private GiocatoreHelper helper;
		public Giocatore(GiocatoreHelper h, String n, bool ordina, int carte)
		{
			mano = new Carta[carte];
			ordinaMano = ordina;
			numeroCarte = carte;
			nessunaCartaGiocata = numeroCarte + 1;
			iCartaGiocata = nessunaCartaGiocata;
			helper = h;
			nome = n;
		}
		public String GetNome() { return nome; }
		public bool GetFlagOrdina() { return ordinaMano; }
		public void SetFlagOrdina(bool ordina) { ordinaMano = ordina; }
		public void AddCarta(Mazzo m)
		{
			Carta c = null;
			bool continua = true;
			/*if (mano.Length == numeroCarte && !HasCartaGiocata())
				throw new NullReferenceException("Chiamato giocatore::addCarta con mano.size==numeroCarte e iCartaGiocata==-1");*/

			if (HasCartaGiocata())
			{
				int i, j, k;
				for (i = 0, j = 0; i < iCartaGiocata; i++, j++) ;
					for (k = j; k <mano.Length-1; k++)
						mano[k] = mano[k+1];

				mano[numeroCarte-1] = null;
				iCartaGiocata = nessunaCartaGiocata;

			}
			try
			{
				c = Carta.GetCarta(m.GetCarta());
			}
			catch (NullReferenceException e)
			{
				numeroCarte--;
				Array.Resize(ref mano, mano.Length - 1);
				continua = false;
				if (numeroCarte == 0)
					throw e;
			}
			if (continua)
			{
				if (!ordinaMano)
					mano[mano.Length-1]=c;
				else
				{
					int i, j;
					for (i = 0; i < mano.Length && mano[i]!=null && Carta.Compara(mano[i], c) == CartaHelper.RISULTATI_COMPARAZIONE.MAGGIORE_LA_SECONDA; i++);
					for (j =mano.Length-1; j > i; j--)
						mano[j] = mano[j-1];
					mano[i]=c;
				}
			}

		}
		public Carta GetCartaGiocata()
		{
			if (iCartaGiocata == nessunaCartaGiocata)
				throw new IndexOutOfRangeException("Chiamata a giocatore::getCartaGiocata con iCartaGiocata==nessunaCartaGiocata");
			return mano[iCartaGiocata];
		}
		public int GetPunteggio() { return punteggio; }
		String GetPunteggioStr() { return "" + punteggio; }
		public void Gioca(int i)
		{
			iCartaGiocata = helper.Gioca(mano, i);
		}
		public void Gioca(Giocatore g1, int i)
		{
			iCartaGiocata = helper.Gioca(mano, g1.GetCartaGiocata(), i);
		}
		public bool HasCartaGiocata() { return iCartaGiocata != nessunaCartaGiocata; }
		public void AggiornaPunteggio(Giocatore g)
		{
			if (g == null)
				throw new NullReferenceException("Chiamata a giocatoe.AggiornaPunteggio con g==NULL");
			if (!HasCartaGiocata())
				throw new IndexOutOfRangeException("Chiamata a giocatore::AggiornaPunteggio con iCartaGiocata==nessunaCartaGiocata");
			punteggio = punteggio + helper.GetPunteggio(GetCartaGiocata(), g.GetCartaGiocata());
		}
		public bool StessoSemeCartaGiocata(Giocatore g)
		{
			if (!HasCartaGiocata())
				throw new IndexOutOfRangeException("Chiamata a giocatore::AggiornaPunteggio con iCartaGiocata==nessunaCartaGiocata");
			return StessoSeme(g.GetCartaGiocata());
		}
		public bool StessoSeme(Carta c)
		{
			if (!HasCartaGiocata())
				throw new IndexOutOfRangeException("Chiamata a giocatore::AggiornaPunteggio con iCartaGiocata==nessunaCartaGiocata");
			return mano[iCartaGiocata].GetSeme() == c.GetSeme();
		}

		public void Paint()
		{
			Console.WriteLine("Punti di " + nome + ": " + punteggio);
			helper.Paint(nome, mano, iCartaGiocata);
		}
	}
}
