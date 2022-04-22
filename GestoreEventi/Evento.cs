using System;
namespace GestoreEventi
{
	public class Evento
	{
		public string titolo { get; set; }
		public DateTime data { get; set; }
		private int capienzaMassima;
		private int numeroPostiPrenotati;

		public Evento(string titolo, DateTime data, int capienzaMassima, int numeroPostiPrenotati)
		{
			this.titolo = titolo;
			this.data = data;
			this.capienzaMassima = capienzaMassima;
			this.numeroPostiPrenotati = numeroPostiPrenotati;
		}
	}
}

