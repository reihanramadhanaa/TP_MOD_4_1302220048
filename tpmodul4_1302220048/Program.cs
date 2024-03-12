internal class Program
{
    private static void Main(string[] args)
    {
        tpmodul4_1302220048.KodePos kodePosObj = new tpmodul4_1302220048.KodePos();
        string kodePosSamoja = kodePosObj.GetKodePos("Samoja");
        Console.WriteLine("Kode Pos Samoja: " + kodePosSamoja);
    }
}