using Microsoft.AspNetCore.Mvc;
using TeslaACDC.Business.Interfaces;
using TeslaACDC.Business.Services;
using TeslaACDC.Controllers;
using TeslaACDC.Data.Models;

[ApiController]
[Route("api/[controller]")]
public class AlbumController : ControllerBase{

  private readonly IAlbumService _albumService;

  public AlbumController(IAlbumService albumService)
  {
    _albumService = albumService;
  }

  [HttpGet]
  [Route("GetArrayAlbums")]
  public async Task<IActionResult> GetAlbums()
  {
    var lista = await _albumService.GetList();

    return Ok(lista);
  }

  [HttpPost]
  [Route("PostArrayAlbums")]
  public async Task<IActionResult> PostArrayAlbums(List<Album> albums)
  {
    return Ok(albums);
  }

}