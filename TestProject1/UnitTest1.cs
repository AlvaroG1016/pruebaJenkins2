using APItest.Controllers;
using APItest.Models;
using APItest.Services;
using Microsoft.AspNetCore.Mvc;

namespace TestProject1
{
    public class UnitTest1
    {
        private readonly MotorcycleController _controller;
        private readonly IMotorcycleService _service;

        public UnitTest1()
        {
            _service = new MotorcycleService();
            _controller = new MotorcycleController(_service);

        }

        [Fact]
        public void Get_Ok()
        {
            var result = _controller.Get(); //esta es la accion que vamos a evaluar
            Assert.IsType<OkObjectResult>(result);
        
        }
        [Fact]
        public void Get_Quantity()
        {
            var result = (OkObjectResult)_controller.Get();

            var motorcycles = Assert.IsType<List<Motorcycle>>(result.Value);
            Assert.True(motorcycles.Count > 0);

        }
        [Fact]
        public void GetById_Ok()
        {
            int id = 1;  //Preparacion de Escenario

            var result = _controller.getById(id); //Ejecución 

            Assert.IsType<OkObjectResult>(result);//Hecho 
        }
        [Fact]
        public void GetById_Exist()
        {
            int id = 1;
            //Se castea para trabajar sobre la data 
            var result = (OkObjectResult)_controller.getById(id);
            //Lo primero es evaluar si es del tipo motorcycle por medio del value
            var motorcycle = Assert.IsType<Motorcycle>(result?.Value);
            //validamos que este sea disinto a null
            Assert.True(motorcycle != null);
            //evaluamos si el id es el mismo id que enviamos
            Assert.Equal(motorcycle?.Id, id); // 
        

        }
    }
}