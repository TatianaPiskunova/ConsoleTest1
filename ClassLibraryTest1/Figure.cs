namespace ClassLibraryTest1
{
   public abstract class Figure
    {
      
        private string? name { get; set; }
        public Figure(string name)
        {
            this.name = name;
        }
        public abstract void Area();

    }

    

}
