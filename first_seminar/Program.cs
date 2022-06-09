int number = Convert.ToInt32(Console.ReadLine());
int count = number * -1;
while (count <= number)
{
    Console.Write(count + ", ");
    count++;
}