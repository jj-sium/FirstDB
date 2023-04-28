# FirstDB

## Passi del progetto

#### Il progetto di FirstDB è basato sul lavoro del database, avendo creato la cartella ghinelli.johan.4h.firstdb, cercando chinookdb su google (https://www.sqlitetutorial.net) e avendo scaricato il proprio database siamo riusciti a lavorare con il database.

#### Siamo andati sulla cartella che nel mentre è stata aperta con visual studio, abbiamo ovviamente fatto dotnet new console e abbiamo scritto una parte di codice per poi collegarlo al nostro database scaricato, abbiamo scaricato l'estensione di SQLite per SQLiteConnection che dava errore.

#### Apriamo la cartella di csproj, abbiamo aperto il terminale e abbiamo aggiunto alla riga dei comandi il comando "dotnet add package sqlite-net-pcl" per mettere la funzione sqlite.

#### Scriviamo un'altro pezzo di codice dove mettiamo il collegamento dal chinookdb dove abbiamo aggiunto:
#### 
    public class Artist
    {
      public int ArtistId { get; set; }
      public string Name { get; set; }
    }
#### ArtistId e Name sono dei dati del database.
#### In fine utilizzando il debug e mettendo un punto di interruzione, per guardare se funziona il codice con il dotnet run.
#### Infatti guardando il debug, riusciamo a vedere che su tblArtists possiamo vedere che c'è il nome dell'artista e il nome delle tracce.

##Grazie per aver ascoltato la spiegazione scritta dall'alunno Ghinelli Johan, Alunno di Conti M. e Sartini M.
