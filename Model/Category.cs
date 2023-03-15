namespace GestionStock.Model
{
    internal class Category
    {
        private int id { get; set; }
        private string name { get; set; }

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