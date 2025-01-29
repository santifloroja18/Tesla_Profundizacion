namespace TeslaACDC.Business.Interfaces; 

using TeslaACDC.Data.Models;
public interface IAlbumService
{
  Task<BaseMessage<Album>> GetAlbumList();
  Task<BaseMessage<Album>> PostAlbum();
  Task<BaseMessage<Album>> GetAlbumById(int id);
  Task<BaseMessage<Album>> GetAlbumByName(string name);
  Task<BaseMessage<Album>> GetAlbumsByYear(int year);
  Task<BaseMessage<Album>> GetAlbumsBetweenYears(int yearOne, int yearTwo);
  Task<BaseMessage<Album>> GetAlbumsByGenre(int? genreId, string? genre);
  Task<BaseMessage<Album>> GetAlbumsByArtist(string artist);
}