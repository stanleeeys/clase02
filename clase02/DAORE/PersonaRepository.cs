using clase02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace clase02.DAORE
{
    public class PersonaRepository
    {
         public List<ClsPersona> obtenerPersona()
        {
            return new List<ClsPersona>()
            {
                new ClsPersona()
                {
                    Id= 1,
                    Nombre = "Stanley"
                },

                new ClsPersona()
                {
                    Id = 2,
                    Nombre = "Rey"
                },

                new ClsPersona()
                {
                    Id = 3,
                    Nombre = "Wil"
                }

            };
        }



    }
}