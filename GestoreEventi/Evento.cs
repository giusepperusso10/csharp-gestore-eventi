using System;
namespace GestoreEventi
{
	public class Evento
	{
		public string titolo { get; set; }
		public DateTime data { get; set; }
		private int capienzaMassima;
		private int postiDisponibili;
		private int numeroPostiPrenotati;
		private int postiRimanenti;

		public Evento(string titolo, DateTime data, int capienzaMassima)
		{
			this.titolo = titolo;
			this.data = data;
			this.capienzaMassima = capienzaMassima;
			this.postiDisponibili = capienzaMassima;
			numeroPostiPrenotati = 0;
		}

		public string GetTitolo()
        {
			return titolo;
        }

		public string SetTitolo(string titolo)
		{
			return titolo;
		}

		public DateTime GetDateTime()
        {
			return data;
        }

		public DateTime SetDateTime(DateTime data)
		{
			ControlloDataEsatta();
			return data;
		}

		public int GetCapienzaMassima()
        {
			return capienzaMassima;
        }

		public int GetNumeroPostiPrenotati()
		{
			return numeroPostiPrenotati;
		}

		public int GetNumeroPostiRimasti()
		{
			return postiRimanenti;
		}

		public int GetPostiDisponibili()
		{
			return postiDisponibili;
		}

		public void ControlloDataEsatta()
		{

			DateTime dataOraAttuale = DateTime.Now;

			if (data <= dataOraAttuale)
			{
				throw new ArgumentOutOfRangeException("Non puoi inserire data nel passato");
			}
		}

		public void PrenotaPosti(int postiDaPrenotare)
        {
			numeroPostiPrenotati = numeroPostiPrenotati + postiDaPrenotare;
			postiDisponibili = postiDisponibili - postiDaPrenotare; 
        }

		public void DisdiciPosti(int postiDaDisdire)
		{
			numeroPostiPrenotati = numeroPostiPrenotati - postiDaDisdire;
			postiDisponibili = postiDisponibili + postiDaDisdire;
		}

		public override string ToString()
		{
			Console.WriteLine(data + " - " + titolo);
			return base.ToString();
		}
	}
}

