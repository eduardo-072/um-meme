const string resposta_sim = "SIM";
const string resposta_nao = "NÃO";

string EstaSeMovendo = "";
string deveria = "";

Console.WriteLine("ESTÁ SE MEXENDO?");
EstaSeMovendo = Console.ReadLine();

if (EstaSeMovendo == resposta_sim){
   Console.WriteLine("DEVERIA?");
   deveria = Console.ReadLine();

if (deveria == resposta_sim){
    Console.WriteLine("OK");

}else{
    deveria = Console.ReadLine()!.ToUpper();
    Console.WriteLine("USE SILVER TAPE");
}
}else{
    Console.WriteLine("DEVERIA?");
    deveria = Console.ReadLine()!.ToUpper();

if (deveria == resposta_sim){
    Console.WriteLine("OK");

}else{
    deveria = Console.ReadLine()!.ToUpper();
    Console.WriteLine("USE SILVER TAPE");

}
}