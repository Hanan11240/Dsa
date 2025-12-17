namespace Tower_of_hanoi
{
    internal class Program
    {

        class Shelf
        {
           public  Stack<int> plates = new Stack<int>();
           public string Name { get; set; }
            public Shelf(string name)
            {
                Name = name;
            }
        }


        static void Main(string[] args)
        {

            Shelf source = new Shelf("A");
            Shelf helper = new Shelf("B");
            Shelf destination = new Shelf("c");
            int totalPlates = 3;

            for(int i = totalPlates; i >= 1; i--)
            {
                source.plates.Push(i);
            }

            TowerOfHanio(totalPlates, source, helper, destination);

            SeeShelf(source);
            SeeShelf(helper);
            SeeShelf(destination);

        }


        static void TowerOfHanio(int totalPlates,Shelf source,Shelf helper,Shelf destination)
        {
            if(totalPlates == 1)
            {
                MovePlates(source, destination);
                return;
            }

            TowerOfHanio(totalPlates -1, source, destination,helper);

            MovePlates(source, destination);

            TowerOfHanio(totalPlates -1, helper, source, destination);
        }

        static void MovePlates(Shelf source, Shelf destination) {
            
            int plate  = source.plates.Pop();
            destination.plates.Push(plate);
        }



        static void SeeShelf(Shelf shelf) {

            Console.WriteLine($"{shelf.Name}");

            foreach (var plate in shelf.plates)
            
            {
                Console.Write(plate+ " ");
                Console.WriteLine();
            }
            
        }


      
       
    }
}
