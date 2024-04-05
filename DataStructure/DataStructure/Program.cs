
class program
{
   static void Main(string[] args)
    {
        HashSet<string> list = new HashSet<string>();
        HashSet<string> set = new HashSet<string>();

        list.Add("a");
        list.Add("b");
        list.Add("c");

        set.Add("d");
        set.Add("a");
        set.Add("f");

        list.Intersect(set);
        list.ExceptWith(set);
        list.UnionWith(set);

        foreach(var item in list)
        {
            Console.WriteLine(item);
        }
    }
}