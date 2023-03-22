namespace GestionStock.Model
{
    internal class Supplier
    {
        public int id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string phone_number { get; set; }

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