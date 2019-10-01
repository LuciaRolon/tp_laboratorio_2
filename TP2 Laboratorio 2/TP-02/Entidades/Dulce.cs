﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_2019
{
    public class Dulce : Producto
    { 
        /// <summary>
        /// Crea un objeto de tipo Dulce.
        /// </summary>
        /// <param name="marca">Marca del Dulce</param>
        /// <param name="codigo">Codigo de Barras</param>
        /// <param name="color">Color del Paquete</param>
        public Dulce(EMarca marca, string codigo, ConsoleColor color)
            :base(codigo, marca, color)
        {
            
        }

        /// <summary>
        /// Los dulces tienen 80 calorías
        /// </summary>
        protected override short CantidadCalorias
        {
            get
            {
                return 80;
            }
        }
        /// <summary>
        /// Publica todos los datos del Dulce.
        /// </summary>
        /// <returns>Devuelve la información como string.</returns>
        public override sealed string Mostrar()
        {      
            StringBuilder str = new StringBuilder();
            str.AppendFormat("Dulce - {0}, Calorias: {1}", base.Mostrar(), this.CantidadCalorias);
            str.AppendLine("");
            str.AppendLine("---------------------");
            return str.ToString();
        }
    }
}