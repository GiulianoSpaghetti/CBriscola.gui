using System;
using System.Collections.Generic;
using System.Text;

namespace CBriscola
{
    class Mazzo
    {
		private ElaboratoreCarte elaboratore;
		private Int64[] carte;
		public Mazzo(ElaboratoreCarte e)
		{
			if (e == null)
				throw new NullReferenceException("Chiamata a mazzo::mazzo con e==null");
			elaboratore = e;
			carte = new Int64[e.GetNumeroCarte()];
			Mischia();
		}
		private void Mischia()
		{
			bool continua = true;
			int i = 0;
			if (carte == null)
				throw new NullReferenceException("Chiamato mazzo::mischia con carte.size!=0");
			else
				while (continua)
					try
					{
						carte[i++]=elaboratore.GetCarta();
					}
					catch (IndexOutOfRangeException e)
					{
						// TODO Auto-generated catch block
						continua = false;
					}
		}
		public int GetNumeroCarte() { return carte.Length; }
		public String GetNumeroCarteStr() { return "" + carte.Length; }
		public Int64 GetCarta()
		{
			if (carte.Length == 0)
				throw new NullReferenceException("Chiamata a mazzo::getCarta con carte.size==0");
			Int64 c = carte[carte.Length - 1];
			Array.Resize(ref carte, carte.Length - 1);
			return c;
		}
		public Int64 GetCarta(int quale)
		{
			if (quale >= carte.Length || carte.Length == 0)
				throw new IndexOutOfRangeException("Chiamato a mazzo::getCarta con quale=" + quale + " e carte.size=" + carte.Length);
			Int64 c = carte[quale];
			int i;
			for (i = quale; i < carte.Length-1; i++)
				carte[i] = carte[i + 1];
			Array.Resize(ref carte, carte.Length - 1);
			return c;
		}
	}
}
