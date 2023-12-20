using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


    public class ClassEstacionamento
    {
        
        private float _valorHora;
        private float _taxaDeEstacionamento;

        // Lista para armazenar objetos Carro
        public List<Carro> CarrosEstacionados { get; set; }

        // Construtor da classe
        public ClassEstacionamento(float taxaDeEstacionamento=0, float valorHora=0)
        {
            // Inicializa a lista no construtor
            CarrosEstacionados = new List<Carro>();
            _taxaDeEstacionamento = taxaDeEstacionamento;
            _valorHora = valorHora;
        }

        public float ValorHora
        { 
            get { return _valorHora ;}
        }

        public float TaxaDeEstacionamento
        { 
            get { return _taxaDeEstacionamento; }
        }

        
        // Método que verifica se um carro está estacionado
        public bool VerificaCarroEstacionado(string placa)
        {          
             return (CarrosEstacionados.Exists(c => c.Placa == placa));       
        }
        
        // Método para adicionar um carro ao estacionamento
        public void AdicionarCarro(string placa)
        {
                // Adiciona o carro à lista com o horário de entrada atual
                Carro novoCarro = new Carro(placa, DateTime.Now);
                CarrosEstacionados.Add(novoCarro);
                Console.WriteLine($"Carro com a placa {placa} estacionado com sucesso às {DateTime.Now}.");

        }

        // Método para imprimir informações sobre todos os carros estacionados
        public void ImprimirCarrosEstacionados()
        {
            Console.WriteLine("Carros estacionados:");
            foreach (var carro in CarrosEstacionados)
            {
                Console.WriteLine($"Placa: {carro.Placa}, Horário de entrada: {carro.HorarioEntrada}");
            }
        }

        public void FecharConta(string placa)
        {
            
            Carro carro = CarrosEstacionados.Find(c => c.Placa == placa);
            DateTime horaSaida = DateTime.Now;

            TimeSpan duracao = horaSaida - carro.HorarioEntrada;

            int tempo = duracao.Hours;

            float valor = (float)tempo * ValorHora;

            Console.WriteLine($"Duração: {tempo} horas; Valor a ser pago: {valor}");

            CarrosEstacionados.Remove(carro);


        }

    }