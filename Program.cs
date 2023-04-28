using SQLite;

Console.WriteLine("Hello, DBWorld!");
// Connessione al db
SQLiteConnection cn1 = new SQLiteConnection("chinook.db");
var tblArtists = cn1.Query<Artist>("select * from artists");
Console.WriteLine($"In questa tabella ci sono {tblArtists.Count} record!");

//-------------
public class Artist
{
    public int ArtistId { get; set; }
    public string Name { get; set; }
}