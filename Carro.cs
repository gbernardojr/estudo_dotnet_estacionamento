using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

    public class Carro
    {
        private string _placa;
        private DateTime _horarioEntrada;

        public string Placa {
            get { return _placa; }
        }

        public DateTime HorarioEntrada {
            get { return _horarioEntrada;}
        }

        public Carro(string placa, DateTime horarioEntrada){
            _placa = placa;
            _horarioEntrada = horarioEntrada;
        }
        public Carro(string placa){
            _placa = placa;
        }

    }