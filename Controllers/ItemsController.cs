using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ShopManager.Entities;
using ShopManager.Repositories;

namespace ShopManager.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
  public class ItemsController : ControllerBase
  {
      private readonly IItemsRepository repository;

      public ItemsController(IItemsRepository repository)
      {
          this.repository = repository;
      }
      
      [HttpGet]
      public IEnumerable<Item> GetItems(){
         var items = repository.GetItems();

         return items;
      }

      [HttpGet("{id}")]
      public ActionResult<Item> GetItem(Guid id){
          var item = repository.GetItem(id);

          if (item == null){
              return NotFound();
          }
          return item;
      }
  }
}