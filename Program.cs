using ScreenSound_04.Modelos;
using System.Text.Json;
using ScreenSound_04.Filtros;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;

        LinqFilter.FiltrarMusicasEmCSharp(musicas);

        //musicas[1].ExibirDetalhesDaMusica();
        //LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        //LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
        //LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "hip hop");
        //LinqFilter.FiltrarMusicasDeUmArtista(musicas, "Eminem");


        //var musicasPreferidasDoDavid = new MusicasPreferidas("David");
        //musicasPreferidasDoDavid.AdicionarMusicasFavoritas(musicas[5]);
        //musicasPreferidasDoDavid.AdicionarMusicasFavoritas(musicas[14]);
        //musicasPreferidasDoDavid.AdicionarMusicasFavoritas(musicas[202]);
        //musicasPreferidasDoDavid.AdicionarMusicasFavoritas(musicas[1000]);
        //musicasPreferidasDoDavid.AdicionarMusicasFavoritas(musicas[134]);

        //musicasPreferidasDoDavid.ExibirMusicasFavoritas();

        //musicasPreferidasDoDavid.GerarArquivoJson();


    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}