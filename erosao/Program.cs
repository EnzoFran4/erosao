class erosao
{
    static void Main(string[] args)
    {
        List <string> ListaString = new List <string> ();   
        ListaString.Add ("a");
        ListaString.Add ("b");  
        ListaString.Add ("c");

         foreach (string str in ListaString)
        {
            Console.WriteLine (str);    
        }
    }
}
