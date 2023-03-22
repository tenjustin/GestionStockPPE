using GestionStock.Controller;

namespace GestionStock
{
    public partial class Connexion : Form
    {
        ConnexionController conneController = new ConnexionController();
        public Connexion()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (conneController.ValidateUser(usernameTb.Text, textBox1.Text))
            {
                ProductForm nextForm = new ProductForm();

                // Cr�e un nouveau thread pour ex�cuter le nouveau formulaire
                Thread newFormThread = new Thread(() => Program.RunForm(nextForm));

                // D�marre le nouveau thread
                newFormThread.SetApartmentState(ApartmentState.STA);
                newFormThread.Start();

                // Ferme le formulaire actuel
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.");
            }
        }
    }
}