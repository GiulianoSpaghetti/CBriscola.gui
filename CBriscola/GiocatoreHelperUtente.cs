using System;
using System.Collections.Generic;
using System.Text;

namespace CBriscola
{
    class GiocatoreHelperUtente : GiocatoreHelper
    {
		public int Gioca(Carta[] v, int i)
		{
			String s;
			// TODO Auto-generated method stub
			if (v.Length == 0)
				throw new IndexOutOfRangeException("Chiamata a GiocatoreHelperUtente.gioca(Vector<Carta>, int) con v.size==0");
			if (i > v.Length || i < 0)
				throw new IndexOutOfRangeException("Chiamata a GiocatoreHelperUtente.gioca(Vector<Carta>, int) con i=" + i);
			do
			{
				Console.Write("Inserire l'indice della carta giocata: ");
				s = Console.ReadLine();
				i = Int16.Parse(s);
				i--;
				if (i < 0 || i >= v.Length)
					Console.WriteLine("Numero non corretto.");
			} while (i < 0 || i >= v.Length);
			return i;
		}

		public int Gioca(Carta[] v, Carta c, int i)
		{
			// TODO Auto-generated method stub
			String s;
			if (v.Length == 0)
				throw new IndexOutOfRangeException("Chiamata a GiocatoreHelperUtente.gioca(Vector<Carta>, Carta, int) con v.size==0");
			if (i > v.Length || i < 0)
				throw new IndexOutOfRangeException("Chiamata a GiocatoreHelperUtente.gioca(Vector<Carta>, Carta, int) con i=" + i);
			do
			{
				Console.WriteLine("Inserire l'indice della carta giocata: ");
				s = Console.ReadLine();
				i = Int16.Parse(s);
				i--;
				if (i < 0 || i >= v.Length)
					Console.WriteLine("Numero non corretto.");
			} while (i < 0 || i >= v.Length);
			return i;
		}

		public int GetPunteggio(Carta c, Carta c1)
		{
			// TODO Auto-generated method stub
			if (c == null)
				throw new NullReferenceException("Chiamata a giocatoreHelperUtente.GetPunteggio con c==NULL");
			if (c1 == null)
				throw new NullReferenceException("Chiamata a giocatoreHelperUtente.GetPunteggio con c1==NULL");
			return c.GetPunteggio() + c1.GetPunteggio();
		}

		public void Paint(String nome, Carta[] mano, int iCartaGiocata)
		{
			// TODO Auto-generated method stub
			Console.WriteLine("Carte di " + nome);
			int i;
			for (i = 0; i < mano.Length; i++)
				if (i != iCartaGiocata)
					Console.WriteLine(mano[i]);
			Console.WriteLine();
			Console.WriteLine();
		}
	}
}
