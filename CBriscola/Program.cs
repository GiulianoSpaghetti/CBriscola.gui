/*
 *  This code is distribuited under GPL 3.0 or, at your opinion, any later version
 *  CBriscola 0.1
 *
 *  Created by numerunix on 22/05/22.
 *  Copyright 2022 Some rights reserved.
 *
 */

//using System.Resources;

//namespace CBriscola
//{
//	class Program
//	{
/*		private static Giocatore g;
		private static Giocatore cpu;
		private static Giocatore primo;
		private static Giocatore secondo;
		private static Mazzo m;
		public static System.Resources.ResourceManager mgr;
		public static void Main(String[] args)
		{
			CreaResourceManager(args.Length > 0 ? args[0] : "it");
			ElaboratoreCarteBriscola e = new ElaboratoreCarteBriscola(true);
			m = new Mazzo(e);
			Carta.Inizializza(40, new CartaHelperBriscola(e), "Napoletano");
			g = new Giocatore(new GiocatoreHelperUtente(), "Giulio", true, 3);
			cpu = new Giocatore(new GiocatoreHelperCpu(e.getCartaBriscola()), "Cpu", true, 3);
			primo = g;
			secondo = cpu;
			giocatore temp = g;
			carta c;
			carta c1;
			carta briscola = carta.getCarta(elaboratoreCarteBriscola.getCartaBriscola());
			string vers = "0.2.5";
			Console.WriteLine($"CBriscola {vers} {mgr.GetString("AdOperaDi")} Giulio Sorrentino. {mgr.GetString("Traduzione")} {mgr.GetString("AdOperaDi")} {mgr.GetString("Autore")}.");
			for (UInt16 i = 0; i < 3; i++)
			{
				g.addCarta(m);
				cpu.addCarta(m);
			}
			while (true)
			{
				if (m.getNumeroCarte() < UInt16.MaxValue)
				{
					System.Console.WriteLine($"{mgr.GetString("CartaBriscola")}: {briscola}");
					System.Console.WriteLine($"{mgr.GetString("CarteMazzo")}: {m.getNumeroCarte()} {mgr.GetString("carte")}.");
				}
				System.Console.WriteLine($"{mgr.GetString("PuntiCpu")}: {cpu.getPunteggio()}"); ;
				System.Console.WriteLine($"{mgr.GetString("PuntiUtente")}: {g.getPunteggio()}");
				gioca();
				c = primo.getCartaGiocata();
				c1 = secondo.getCartaGiocata();
				System.Console.WriteLine($" {c} {c1}");

				if ((c.CompareTo(c1) > 0 && c.stessoSeme(c1)) || (c1.stessoSeme(briscola) && !c.stessoSeme(briscola)))
				{
					temp = secondo;
					secondo = primo;
					primo = temp;
				}
				primo.aggiornaPunteggio(secondo);
				if (!aggiungiCarte())
					break;
			}
			Console.Write($"{mgr.GetString("PremereInvio")}");
			Console.ReadLine();
		}

		private static void gioca()
		{
			try
			{
				primo.gioca();
				if (primo == cpu)
					System.Console.WriteLine($"{mgr.GetString("Giocata")} {primo.getCartaGiocata()}");
				secondo.gioca(primo);
			}
			catch (System.ArgumentNullException e)
			{
			}

		}

		private static bool aggiungiCarte()
		{
			try
			{
				primo.addCarta(m);
				secondo.addCarta(m);
			}
			catch (IndexOutOfRangeException e)
			{
				System.Console.WriteLine($"{mgr.GetString("PartitaFinita")}.");
				System.Console.WriteLine($"{mgr.GetString("PuntiUtente")}: {g.getPunteggio()}");
				System.Console.WriteLine($"{mgr.GetString("PuntiCpu")}: {cpu.getPunteggio()}");
				if (g.getPunteggio() == cpu.getPunteggio())
					Console.WriteLine($"{mgr.GetString("PartitaPatta")}.");
				else
					if (g.getPunteggio() > cpu.getPunteggio())
					Console.WriteLine($"{mgr.GetString("HaiVintoPer")} {g.getPunteggio() - cpu.getPunteggio()} {mgr.GetString("punti")}.");
				else
					Console.WriteLine($"{mgr.GetString("HaiPersoPer")} {cpu.getPunteggio() - g.getPunteggio()} {mgr.GetString("punti")}.");

				return false;
			}
			return true;
		}
		private static void CreaResourceManager(string arg)
		{
			System.Resources.ResourceManager m;
			m = new System.Resources.ResourceManager($"CBriscola.Strings.{arg}.Resources", System.Reflection.Assembly.GetExecutingAssembly()); try
			{
				m.GetString("di");
			}
			catch (System.Resources.MissingManifestResourceException e)
			{
				m = new System.Resources.ResourceManager($"CBriscola.Strings.it.Resources", System.Reflection.Assembly.GetExecutingAssembly());
			}
			mgr = m;
		}*/
namespace WinFormsApp1
	{
		internal static class Program
		{
			/// <summary>
			///  The main entry point for the application.
			/// </summary>
			[STAThread]
			static void Main()
			{
				// To customize application configuration such as set high DPI settings or default font,
				// see https://aka.ms/applicationconfiguration.
				ApplicationConfiguration.Initialize();
				Application.Run(new CBriscola.CartaAlta());
			}
		}
	}