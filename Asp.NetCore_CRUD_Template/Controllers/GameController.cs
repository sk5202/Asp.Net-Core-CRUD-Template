using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Asp.NetCore_CRUD_Template.Models;
using Asp.NetCore_CRUD_Template.Data;
using Asp.NetCore_CRUD_Template.Core;
using Microsoft.AspNetCore.Http;

namespace Asp.NetCore_CRUD_Template.Controllers
{
    public class GameController : Controller
    {
        private GameContext context;

        public GameController(GameContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var s = context.Set<Game>().ToList();

            IEnumerable<GameModel> model = context.Set<Game>().ToList().Select(s => new GameModel
            {
                Id = s.Id,
                Name = s.name,
               
            });
            return View("Index", model);
        }

        [HttpGet]
        public IActionResult AddEditGame(long? id)
        {
            GameModel model = new GameModel();
            if (id.HasValue)
            {
                Game Game = context.Set<Game>().SingleOrDefault(c => c.Id == id.Value);
                if (Game != null)
                {
                    model.Id = Game.Id;
                    model.Name = Game.name;
                  
                }
            }
            return View("~/Views/Game/_AddEditGame.cshtml", model);
        }

        [HttpPost]
        public ActionResult AddEditGame(long? id, GameModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    
                    if(id == 0)
                    {
                        Game Game = new Game()
                        {
                            name = model.Name
                        };

                        context.Add(Game);
                    }
                    else
                    {
                        var game = context.Set<Game>().SingleOrDefault(c => c.Id == id);
                        if (game != null)
                        {
                            game.name = model.Name;                            
                        }
                    }
                    
                    
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return RedirectToAction("Index");
        }

      
        [HttpPost]
        public IActionResult DeleteGame(int id)
        {
            Game Game = context.Set<Game>().SingleOrDefault(c => c.Id == id);
            context.Entry(Game).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            context.SaveChanges();
            return Json("success");
        }
    }
}
