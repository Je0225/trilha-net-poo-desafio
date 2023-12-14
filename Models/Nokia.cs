namespace DesafioPOO.Models {
    public class Nokia : Smartphone{

        public Nokia(): base("(44)1098-7654", " Nokia Tijolão", "151413121110987/65", 2) {
        }

        public override void InstalarAplicativo(String nomeApp) {
            Console.WriteLine($"Iniciando instalação da aplicação {nomeApp} para Android...");
        }

    }
}