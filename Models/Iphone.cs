namespace DesafioPOO.Models {
    public class Iphone : Smartphone {
        public Iphone(): base("(45)1234-4567", "Apple Iphone 14", "123456789112345/16", 5) {
        }

        public override void InstalarAplicativo(String nomeApp) {
            Console.WriteLine($"Iniciando instalação da aplicação {nomeApp} para IOS...");
        }

    }
}