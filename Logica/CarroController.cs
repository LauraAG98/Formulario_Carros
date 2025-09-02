using Datos;
using Datos.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class CarroController
    {
        BaseDatos baseDatos;

        public CarroController() { 
            baseDatos = new BaseDatos();
        }

        public string GuardarDatos(string placa, string modelo, string marca, string color) {
            string resultado = "";

            resultado = baseDatos.GuardarDatos(placa, modelo, marca, color);

            return resultado;
        }

        public List<CarrosEntity> VerCarros() {
            List<CarrosEntity> listaCarros = baseDatos.VerCarros();

            return listaCarros;
        }

        public CarrosEntity buscarDatos(string placa) {
            return baseDatos.buscarDatos(placa);
        }

        public string actualizarDatos(string placa, string modelo, string marca, string color) { 

            return baseDatos.actualizarDatos(placa,modelo,marca,color);
        }

        public string eliminarDatos(string placa) {
            return baseDatos.eliminarDatos(placa);
        }
    }
}