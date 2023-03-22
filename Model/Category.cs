namespace GestionStock.Model
{
    internal class Category
    {
        public int id { get; set; }
        public string name { get; set; }

        public Category(string name)
        {
            this.name = name;
        }

        public Category(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}