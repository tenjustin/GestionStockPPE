namespace GestionStock.Model
{
    internal class Supplier
    {
        private int id { get; set; }
        private string name { get; set; }
        private string address { get; set; }
        private string phone_number { get; set; }

        public Supplier(string name, string address, string phone_number)
        {
            this.name = name;
            this.address = address;
            this.phone_number = phone_number;
        }

        public Supplier(int id, string name, string address, string phone_number)
        {
            this.id = id;
            this.name = name;
            this.address = address;
            this.phone_number = phone_number;
        }
    }
}