using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CBriscola
{
    class Carta
    {
		private int seme, valore, punteggio;
		private String semeStr;
		private static CartaHelper helper;
		private static Carta[] carte;
		private static String path, nomeMazzo;
		private Carta(int n)
		{
			seme = helper.GetSeme(n);
			valore = helper.GetValore(n);
			punteggio = helper.GetPunteggio(n);
			semeStr = helper.GetSemeStr(n);
			//img=NULL;
		}

		public static void Inizializza(int n, CartaHelper h, String nomeMazzo)
		{
			carte = new Carta[n];
			if (carte==null)
				throw new NullReferenceException("Chiamato carta::inizializza con carte.size()==" + carte.Length);
			if (h == null)
				throw new NullReferenceException("Chiamato carta::inizializza con h==null");
			helper = h;
			int i;
			for (i = 0; i < n; i++)
			{
				carte[i]=new Carta(i);
			}
		}
		public static Carta GetCarta(Int64 quale)
		{
			return carte[quale];
		}
		/*public static void CaricaImmagini(String mazzo) throws FileNotFoundException
		{
			path=System.getProperty("user.dir")+File.pathSeparator+"Mazzi"+File.pathSeparator;
			nomeMazzo=mazzo;
			String pathCompleta = path + mazzo + File.pathSeparator;
			String s;
			File f;
			int i;
			for (i=0; i<carte.size(); i++) {
				s=pathCompleta+i+".jpg";
				f=new File(s);
				if (!f.exists()) {
					throw new FileNotFoundException("Il file " + s + "non esiste.");
				}
				try {
					carte.get(i).SetImmagine(s);
				} catch (IOException e) {
					// TODO Auto-generated catch block
					e.printStackTrace();
				}
			}
		}*/

		public int GetSeme() { return seme; }
		public int GetValore() { return valore; }
		public int GetPunteggio() { return punteggio; }
		public int GetNumero() {return helper.GetNumero(seme, valore);}
		public String GetValoreStr() { return "" + (valore + 1); }
		public String GetSemeStr() { return semeStr; }

//		public void SetImmagine(String path) throws IOException { img=ImageIO.read(new File(path));}
	//	public BufferedImage GetImmagine() { return img; }

		public bool StessoSeme(Carta c1) { return seme == c1.GetSeme(); }
		public static CartaHelper.RISULTATI_COMPARAZIONE Compara(Carta c, Carta c1)
		{
			return Carta.helper.Compara(Carta.helper.GetNumero(c.GetSeme(), c.GetValore()), Carta.helper.GetNumero(c1.GetSeme(), c1.GetValore()));
		}
//		static int GetAltezzaImmagine() { return carte.t(0).img.getHeight(); }
//		static int GetLarghezzaImmagine() { return carte.get(0).img.getWidth(); }

		public static String GetPathMazzi() { return path; }
		public static String GetPathCarte() { return path + nomeMazzo + Path.PathSeparator; }
		public static String GetNomeMazzo() { return nomeMazzo; }
//		public static BufferedImage GetImmagine(int quale) { return carte.get(quale).GetImmagine(); }
		static String GetSemeStr(int quale) {return carte[quale].GetSemeStr();}

		override public String ToString() {return GetValoreStr() + " " + GetSemeStr();}
		
	}
}
