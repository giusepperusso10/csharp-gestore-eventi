using System;
namespace GestoreEventi
{
	public class Evento
	{
		public string titolo { get; set; }
		public DateTime data;
		private int capienzaMassima;
		private int postiDisponibili;
		private int numeroPostiPrenotati;

		public Evento(string titolo, DateTime data, int capienzaMassima)
		{
			this.titolo = titolo;
			this.data = data;
			this.capienzaMassima = capienzaMassima;
			this.postiDisponibili = capienzaMassima;
			numeroPostiPrenotati = 0;
		}

		//GET E SET
		public string GetTitolo()
        {
			return titolo;
        }

		public void SetTitolo(string titolo)
		{
			this.titolo = titolo;
		}

		public DateTime GetDateTime()
        {
			return data;
        }

		public void SetDateTime(DateTime data)
		{
			ControlloDataEsatta();
			this.data = data;
		}

		public int GetCapienzaMassima()
        {
			return capienzaMassima;
        }

		public int GetNumeroPostiPrenotati()
		{
			return numeroPostiPrenotati;
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

		//METODI PRENOTA E DISDICI
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
			string stringa = "";
			stringa += data.ToString("MM/dd/yyyy") + " - " + titolo;
			
			return stringa;
		}
	}
}

