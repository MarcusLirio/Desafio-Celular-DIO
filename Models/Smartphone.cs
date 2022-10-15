namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        private string Modelo { get; set; }
        private string IMEI { get; set; }
        private string Memoria { get; set; }

        protected Smartphone(string numero, string modelo, string iMEI, string memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = iMEI;
            Memoria = memoria;
        }

        private string ClassesName => this.GetType().Name;

        public void Ligar()
        {
            Console.WriteLine($"{ClassesName}: Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine($"{ClassesName}: Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}