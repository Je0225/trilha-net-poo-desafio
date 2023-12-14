using DesafioPOO.Models;

Iphone iphone = new Iphone();
Nokia nokia  = new Nokia();

List<Smartphone>  smartphones = new List<Smartphone>();
smartphones.Add(iphone);
smartphones.Add(nokia);

foreach (Smartphone cells in smartphones) {
    Console.WriteLine(cells.ToString());
    if (cells == nokia) {
        cells.InstalarAplicativo("Jogo da cobrinha");
    } else {
        cells.InstalarAplicativo("Dio.me");
    }
    cells.Ligar();
    cells.ReceberLigacao();
    Console.WriteLine("__________________________________________________________________");
}