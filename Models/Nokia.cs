namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {

        public Nokia(){}
        public Nokia(string numero, string modelo, int imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o {nomeApp} no NOKIA");
        }
    }
}