class SamplePrgrams
{
    public void display(int[] ele)
    {
        foreach(int var in ele)
        {
            Console.WriteLine(var + " ");
        }
    }
}
class program
{
    void Main(string[] args)
    {
        SamplePrgrams sp = new SamplePrgrams();
        int[] ints = { 1, 2, 3 };
        char[] ch = { 'a', 'b', 'c' };
        string[] s = { "harsha", "bc" };

        sp.display(ints);
    }
}