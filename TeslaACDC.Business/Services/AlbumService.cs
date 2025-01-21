using System;
using TeslaACDC.Business.Interfaces;
using TeslaACDC.Data.Models;

namespace TeslaACDC.Business.Services;

public class AlbumService : IAlbumService
{
    public async Task<List<Data.Models.Album>> AddAlbum()
    {
        throw new NotImplementedException();
    }

    public async Task<List<Album>> GetList()
    {
        Album album = new ()
        {
            name = "I'm Still Standing",
            year = 1998,
            artist = "Elton John"
        };
        return new List<Album>{album}; 
    }
}
