namespace DesafioPOO.Models {
    public class Nokia : Smartphone{

        public Nokia(): base("(44)1098-7654", " Nokia Tijol�o", "151413121110987/65", 2) {
        }

        public override void InstalarAplicativo(String nomeApp) {
            Console.WriteLine($"Iniciando instala��o da aplica��o {nomeApp} para Android...");
        }

    }
}