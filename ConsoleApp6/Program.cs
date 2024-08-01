class Person
{
    public int age;
    public Person (int age)
    {
        this.age = age;
    }
    public void Print()
    {
        Console.WriteLine(age);
    }
}
class Child : Person
{
    public Child (int age) : base (age)
    {

    }

}


public class Program
{
    static void Main ()
    {
        Console.WriteLine("biba");
    }
}
//добавил комментарий