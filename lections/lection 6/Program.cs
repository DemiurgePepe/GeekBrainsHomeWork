void Towers(string  with = "1", string on = "3", string some = "2", int count = 3)
{

    if( count>1) Towers(with,some,on, count -1);
    Console.WriteLine($"{with}>>{on}");
    if(count>1) Towers(some,on,with, count-1);
    Console.WriteLine();
}
Towers();

// DataTime dt = DateTime.Now;
// decimal fRec = 0;
// decimal FibonaccRecursion(int n)
// {
//     fRec++;
//     return n==0 || n==1 ? 1 :FibonaccRecursion(n-1)+FibonaccRecursion(n-2);
// }
// for (int n = 10; n < 40; n++)
// {
//     Console.WriteLine($"FibonaccRecursion({n})= {FibonaccRecursion(n)} fRec={fRec}");
//     fRec=0;
// }
// System.Console.WriteLine((DateTime.Now-dt).TotalMilliseconds);
