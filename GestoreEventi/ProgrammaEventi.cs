using System;
namespace GestoreEventi
{
	public class ProgrammaEventi
	{
		public string titolo;
		public List<Evento> eventi;

		public ProgrammaEventi(string titolo, List<Evento> eventi)
		{
			this.eventi = eventi;
			this.titolo = titolo;
		}

		//GET
		public string GetTitolo()
		{
			return titolo;
		}

		//AGGIUNGI EVENTI ALLA LISTA

		public List<Evento> AggiungiEventi()
		{
			foreach (Evento events in eventi)
			{
				this.eventi.Add(events);
			}

			return this.eventi;
		}

		//STAMPA EVENTO DA DATA

		public void StampaEvento(DateTime dataScelta)
        {
			foreach (Evento evento in eventi)
			{
				if (evento.GetDateTime() == dataScelta)
				{
					Console.WriteLine(evento.ToString());
				}
			}
		}

		public void Stampa()
		{
			int lunghezzaList = LunghezzaLista();
			Console.WriteLine("Il numero di eventi e': " + lunghezzaList);
			Console.WriteLine("Ecco il tuo programma eventi: ");
			Console.WriteLine(this.titolo);
			foreach (Evento evento in this.eventi)
			{
				Console.Write("\t" + evento.GetDateTime().ToString("MM/dd/yyyy"));
				Console.Write(" - ");
				Console.WriteLine(evento.GetTitolo());
			}
		}

		public int LunghezzaLista()
        {
			int lunghezzaDellaLista = this.eventi.Count;
			return lunghezzaDellaLista;
        }

		//SVUOTA LA LISTA
		public void ListaVuota()
		{
			this.titolo = "";
			this.eventi.Clear();
		}

	}
}

