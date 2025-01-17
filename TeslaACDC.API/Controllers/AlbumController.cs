using Microsoft.AspNetCore.Mvc;
using TeslaACDC.Model;

[ApiController]
[Route("api/[controller]")]
public class AlbumController : ControllerBase{

  [HttpGet]
  [Route("GetArrayAlbums")]
  public async Task<IActionResult> GetArrayAlbums()
  {
    List<Album> albums = new List<Album>();
    albums.Add(new Album{
      name = "I'm Still Standing",
      year = 1998,
      artist = "Elton John"
    });
    albums.Add(new Album{
      name = "My Way",
      year = 1969,
      artist = "Frank Sinatra"
    });

    return Ok(albums);
  }

  [HttpPost]
  [Route("PostArrayAlbums")]
  public async Task<IActionResult> PostArrayAlbums(List<Album> albums)
  {
    return Ok(albums);
  }

}