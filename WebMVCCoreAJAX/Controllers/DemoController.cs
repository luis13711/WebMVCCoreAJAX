using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebMVCCoreAJAX.Models;

namespace WebMVCCoreAJAX.Controllers
{
    [Route("demo")]
    public class DemoController : Controller
    {
        private readonly WorkoutContext _db;
        public DemoController(WorkoutContext db)
        {
            _db = db;
        }

        [Route("")]
        [Route("index")]
        [Route("~/")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("demo1")]
        public IActionResult Demo1()
        {
            return new JsonResult("Hello");
        }

        //[Route("guardarImagen/{data}")]
        [HttpGet("{data}")]
        public  IActionResult guardarImagen(String data)
        {
            
            return new JsonResult(" " + data);
        }


        [Route("create2/{nombre}&{apellido}")]
        public IActionResult Create2(string nombre, string apellido)
        {
            Book book = new Book();
            book.Id = 0;
            book.Name = nombre+apellido;

            if (ModelState.IsValid)
            {
                _db.Add(book);
                _db.SaveChanges();
            }
            string cadena = JsonConvert.SerializeObject(book);
            return new JsonResult(" " + cadena);
        }

        [Route("create/{name}")]
        public IActionResult Create(string name)
        {
            Book book = new Book();
            book.Id = 0;
            book.Name = name;

            if (ModelState.IsValid)
            {
                _db.Add(book);
                _db.SaveChanges();
            }
            string cadena = JsonConvert.SerializeObject(book);
            return new JsonResult(" " + cadena);
        }

        [Route("demo2/{fullName}")]
        public IActionResult Demo2(string fullName)
        {
            return new JsonResult("Hello " + fullName);
        }

        [Route("demo3")]
        public IActionResult Demo3()
        {
            var product = new Product()
            {
                Id = "p01",
                Name = "name 1",
                Price = 123
            };
            return new JsonResult(product);
        }

        [Route("demo4")]
        public IActionResult Demo4()
        {
            var products = new List<Product>()
            {
                new Product() {
                    Id = "p01",
                    Name = "name 1",
                    Price = 123
                },
                new Product() {
                    Id = "p02",
                    Name = "name 2",
                    Price = 456
                },
                new Product() {
                    Id = "p03",
                    Name = "name 3",
                    Price = 789
                }
            };
            return new JsonResult(products);
        }

    }

    public class RegistroImagen
    {
        private string data;

        public string Data { get => data; set => data = value; }
    }

}