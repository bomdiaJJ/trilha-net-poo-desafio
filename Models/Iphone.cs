namespace DesafioPOO.Models {
    public class IPhone : Smartphone {
        public IPhone(string numero, string modelo, string imei, int memoria)
            : base(numero, modelo, imei, memoria) {}

        public override void InstalarAplicativo(string nomeApp) {
            Console.WriteLine($"Aplicativo \"{nomeApp}\" não pode ser instalado."
            + " Sua versão do iOS não suporta o aplicativo.");
        }
    }
}