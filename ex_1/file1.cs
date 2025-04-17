static private void NamesWithLengthThree()
{
    string[] people = { "Tom", "Alice", "Bob", "Sam", "Tim", "Tomas", "Bill" };
    var result = from p in people
                 where p.Length == 3
                 select p;

    Console.WriteLine("Имена длиной 3 символа:");
    foreach (var name in result)
    {
        Console.WriteLine(name);
    }
}