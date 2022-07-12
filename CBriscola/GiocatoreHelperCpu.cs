using System;
using System.Collections.Generic;
using System.Text;

namespace CBriscola
{
    class GiocatoreHelperCpu : GiocatoreHelper
	{
		private Carta briscola;
	//	private Image img;
		private Random rand;
		private int getBriscola(Carta[] mano)
		{
			int i;
			for (i = 0; i < mano.Length && !briscola.StessoSeme(mano[i]); i++) ;
			return i;
		}
		private int GetSoprataglio(Carta[] mano, Carta c, bool maggiore)
		{
			bool trovata = false;
			int i;
			if (maggiore)
			{
				for (i = mano.Length - 1; i > -1; i--)
					if (c.StessoSeme(mano[i]) && Carta.Compara(c, mano[i]) == CartaHelper.RISULTATI_COMPARAZIONE.MAGGIORE_LA_SECONDA)
					{
						trovata = true;
						break;
					}
					else if (c.StessoSeme(mano[i]) && Carta.Compara(c, mano[i]) == CartaHelper.RISULTATI_COMPARAZIONE.MAGGIORE_LA_PRIMA)
					{
						break;
					}
			}
			else
			{
				for (i = 0; i < mano.Length; i++)
					if (c.StessoSeme(mano[i]) && Carta.Compara(c, mano[i]) == CartaHelper.RISULTATI_COMPARAZIONE.MAGGIORE_LA_SECONDA)
					{
						trovata = true;
						break;
					}
			}
			if (trovata)
				return i;
			else
				return mano.Length;

		}

		public GiocatoreHelperCpu(int b)
		{
			briscola = Carta.GetCarta(b);
			//img = null;
			rand = new Random();
			//CaricaImmagine();
		}

/*		void CaricaImmagine() throws FileNotFoundException, IOException  {
		String s = Carta.GetPathCarte() + "retro carte pc.jpg";
		File f = new File(s);
		if (!f.exists())
			throw new FileNotFoundException("Il file "+s+" non esiste.");
		else
			img=ImageIO.read(f);
	}*/

	public int Gioca(Carta[] mano, int iCarta)
	{
		// TODO Auto-generated method stub
		int i;
		if (mano.Length == 0)
			throw new IndexOutOfRangeException("Chiamata a giocatoreHelperCpu::Gioca con mano.size()==0");
		for (i = mano.Length - 1; i > -1 && (mano[i].GetPunteggio() > 5 || briscola.StessoSeme(mano[i])); i--) ;
		if (i < 0 || i > mano.Length)
			i = 0;
		return i;

	}

	public int Gioca(Carta[] mano, Carta c, int i)
	{
		// TODO Auto-generated method stub
		if (mano.Length == 0)
			throw new IndexOutOfRangeException("Chiamata a GiocatoreHelperCpu::gioca(mano, c, i) con mano.size==0");
		if (c == null)
			throw new NullReferenceException("Chiamata a GiocatoreHelperCpu::gioca(mano, c, i) con c==NULL");
		i = rand.Next();
		if (!briscola.StessoSeme(c))
		{
			if ((i = GetSoprataglio(mano, c, true)) < mano.Length)
				return i;
			if (c.GetPunteggio() > 0 && (i = getBriscola(mano)) < mano.Length)
			{
				if (c.GetPunteggio() > 4)
					return i;
				if (mano[i].GetPunteggio() > 0)
					if (i % 10 < 5)
						return i;
			}
		}
		else
		{
			if (i % 10 < 5 && (i = GetSoprataglio(mano, c, false)) < mano.Length)
				return i;
		}
		i = 0;
		return 0;
	}

	public int GetPunteggio(Carta c, Carta c1)
	{
		// TODO Auto-generated method stub
		if (c == null)
			throw new NullReferenceException("Chiamata a giocatoreHelperUtente::getPunteggio con c==NULL");
		if (c1 == null)
			throw new NullReferenceException("Chiamata a giocatoreHelperUtente::getPunteggio con c1==NULL");
		return c.GetPunteggio() + c1.GetPunteggio();
	}

	public void Paint(String nome, Carta[] mano, int iCartaGiocata)
	{
		// TODO Auto-generated method stub
		/*		System.out.println("Carte di "+ nome);
				int i;
				for (i=0; i<mano.size(); i++)
					if (i!=iCartaGiocata)
					System.out.print(mano.get(i));
				if (mano.size()>iCartaGiocata)
					System.out.println("Carta giocata: "+mano.get(iCartaGiocata));
				System.out.println();
				System.out.println();*/


	}
}
}
