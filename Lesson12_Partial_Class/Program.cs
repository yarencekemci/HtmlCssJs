using Lesson12_Partial_Class;

namespace Lesson12_partial_class;

internal class Program
{
    static void Main(string[] args)
    {
        

        ButunPartial butunP = new ButunPartial();//15.000 satır kod varsa bunu partial ile 3 class şeklinde bölerek ayırabiliriz aşağıdaki gibi

        Partial3 p3 = new Partial3();//5000+5000+5000//Partial3,Partial2,Partial1
        Partial2 p2 = new Partial2();//5000+5000//Partial1,Partial2 
        Partial1 p1 = new Partial1();//5000//Partial1

        SudaYasayan suYasa = new SudaYasayan();//SudaYasayan,Balina,Canli 3 tane class proplarını kullanarak islem yapar

    }
}