
using GestoreEventi;

//------ MILESTONE 1 / 2 ---------
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
        Console.Write("Aggiungi data [gg/mm/aaaa]: ");
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

//------ MILESTONE 3 / 4 ---------

List<Evento> eventoLista = new List<Evento>();

Console.Write("Aggiungi il nome del tuo programma eventi: ");
string? nomeEvento = Console.ReadLine().ToLower();
while (nomeEvento == null)
{
    nomeEvento = Console.ReadLine().ToLower();
}

Console.Write("Quanti eventi vuoi aggiungere? : ");
int numeriEventi = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < numeriEventi; i++)
{


    Console.Write("Aggiungi il nome del {0}° evento : ", i+1);
    string? nome = Console.ReadLine().ToLower();
    while (nome == null)
    {
        nome = Console.ReadLine().ToLower();
    }

    Console.Write("Aggiungi posti totali : ");
    int postiTotali = Convert.ToInt32(Console.ReadLine());

    bool esci = false;
    while (!esci)
    {
        DateTime dataOra = DateTime.Now;
        bool formatoDataCorretto = false;
        while (!formatoDataCorretto)
        {
            Console.Write("Aggiungi data [gg/mm/aaaa] : ");
            try
            {
                dataOra = DateTime.Parse(Console.ReadLine());
                
                formatoDataCorretto = true;
            }
            catch (Exception)
            {
                Console.WriteLine("Il formato non è corretto");
            }
        }

        eventoLista.Add(new Evento(nome, dataOra, postiTotali));
        esci = true;
       
    }
}

ProgrammaEventi lista = new ProgrammaEventi(nomeEvento, eventoLista);
lista.Stampa();


Console.Write("Inserisci data per sapere che eventi ci saranno: ");

DateTime dataScelta = DateTime.Now;
bool uscit = false;
while (!uscit)
{
    try
    {
        dataScelta = DateTime.Parse(Console.ReadLine().ToString());
        uscit = true;
    }
    catch (Exception)
    {
        Console.WriteLine("Il formato non è corretto");
    }
}

lista.StampaEvento(dataScelta);
lista.ListaVuota();


