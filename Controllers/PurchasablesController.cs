using System;
using System.Collections.Generic;
using burgershack_winter20.Models;
using Microsoft.AspNetCore.Mvc;
using winter20_burgershack.Interfaces;
using winter20_burgershack.Services;

namespace burgershack_winter20.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class PurchasablesController : ControllerBase
  {

    private readonly MenuService _service;

    public PurchasablesController(MenuService service)
    {
      _service = service;
    }
    [HttpGet("menu")]
    public ActionResult<IEnumerable<MenuItem>> GetAll()
    {
      try
      {
        var data = _service.getAll();
        return Ok(data);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpGet]
    public ActionResult<IEnumerable<IPurchasable>> GetAllPurchasable()
    {
      try
      {
        var data = _service.getAll();
        return Ok(data);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
  }
}