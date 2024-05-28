namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone" OK
    public class Nokia : Smartphone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo" OK
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {

        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo \"{nomeApp}\" no Nokia");
        }
    }
}