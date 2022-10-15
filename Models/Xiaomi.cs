namespace DesafioPOO.Models
{
    public class Xiaomi : Smartphone
    {
        public Xiaomi(string numero, string modelo, string iMEI, string memoria) : base(numero, modelo, iMEI, memoria)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Play store: Instalado o aplicativo {nomeApp} em menos de 1 segundo com sucesso.");
        }
    }
}