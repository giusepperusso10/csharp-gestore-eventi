
using GestoreEventi;

Console.Write("Inserisci il nome dell'evento: ");
string? titolo = Console.ReadLine().ToLower();
while (titolo == null)
{
    titolo = Console.ReadLine().ToLower();
}

DateTime data = DateTime.Now;
bool dataCorretta = false;
while (!dataCorretta)
{
        Console.Write("Aggiungi data [gg/mm/aaaa] e ora [00:00] : ");
        try
        {
            data = DateTime.Parse(Console.ReadLine());
            dataCorretta = true;
        }
        catch (Exception)
        {
            Console.WriteLine("Il formato non è corretto");
        }
    

}

Console.Write("Inserisci il numero di posti totali: ");
int capienzaMassima = int.Parse(Console.ReadLine().ToLower());
while (capienzaMassima == null)
{
    capienzaMassima = int.Parse(Console.ReadLine().ToLower());
}

Console.Write("Quanti posti desideri prenotare?: ");
int postiDaPrenotare = int.Parse(Console.ReadLine().ToLower());
while (postiDaPrenotare == null)
{
    postiDaPrenotare = int.Parse(Console.ReadLine().ToLower());
}



Evento evento1 = new Evento(titolo, data, capienzaMassima);

evento1.PrenotaPosti(postiDaPrenotare);

Console.WriteLine("Numero posti prenotati: " + evento1.GetNumeroPostiPrenotati());
Console.WriteLine("Numero numero posti disponibili: " + evento1.GetPostiDisponibili());

bool uscita = false;
while (!uscita)
{
    Console.Write("Vuoi disdire posti? (si/no): ");
    string scelta = Console.ReadLine().ToLower();

    switch (scelta)
    {
        case "si":
            Console.Write("Quanti posti vuoi disdire?: ");
            int postiDaDisdire = int.Parse(Console.ReadLine().ToLower());
            while (postiDaDisdire == null)
            {
                postiDaDisdire = int.Parse(Console.ReadLine().ToLower());
            }
            evento1.DisdiciPosti(postiDaDisdire);
            Console.WriteLine("Numero posti prenotati: " + evento1.GetNumeroPostiPrenotati());
            Console.WriteLine("Numero numero posti disponibili: " + evento1.GetPostiDisponibili());
            break;
        case "no":
            Console.WriteLine("Grazie");
            Console.WriteLine("");
            uscita = true;
            break;
        default:
            Console.WriteLine("Mi dispiace opzione non contemplata");
            break;
    }
}