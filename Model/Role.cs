namespace GestionStock.Model
{
    internal class Role
    {
        private int id { get; set; }
        private string name { get; set; }

        public Role(string name)
        {
            this.name = name;
        }

        public Role(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}