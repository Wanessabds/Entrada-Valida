Console.WriteLine("Entrada Valida");
int numerodigitado = -1;

while(numerodigitado <0 || numerodigitado >9)
{
    Console.ForegroundColor = ConsoleColor.DarkMagenta;
    Console.WriteLine ("digite um número entre 1 e 9 (ou 0 para cancelar)...: ");
    Console.ForegroundColor = ConsoleColor.Black;
    numerodigitado = Convert.ToInt32 (Console.ReadLine());
}
if (numerodigitado==0)
{
    Console.WriteLine("\noperação cancelada. ");
}
else
{
    Console.WriteLine($"\nnumero selecionado = {numerodigitado}");
}
Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.WriteLine ("volte sempre!");
