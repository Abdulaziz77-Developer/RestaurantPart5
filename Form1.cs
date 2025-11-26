using RestaurantPart5.Business_Logic;
using RestaurantPart5.Models;
using RestaurantPart5.Models.Drinks;

namespace RestaurantPart5
{
    public partial class Form1 : Form
    {
        Server server = new Server();
        private object locker = new object();
        List<Drink> drinks = new()
        {
            new Tea("Tea"),
            new NoDrink("No Drink"),
            new Pepsi("Peppsi"),
            new Fanta("Fanta")
        };

        public Form1()
        {
            InitializeComponent();
            foreach (var item in drinks)
            {
                cmbxDrinks.Items.Add(item.GetDrinkName);
            }
        }

        private void btnNewRequest_Click(object sender, EventArgs e)
        {
            try
            {
                string drink;
                if (!(int.TryParse(countChicken.Text, out int amountChicken)) ||
                !(int.TryParse(countEgg.Text, out int amountEgg)) ||
                amountEgg < 0 || amountChicken < 0)
                {
                    throw new Exception("The chicken count or egg count cannot be small by zero ");
                }
                if (cmbxDrinks.SelectedItem is null)
                {
                    drink = "No Drink";
                }
                if (string.IsNullOrEmpty(userName.Text))
                {
                    throw new Exception("The name customer cannot be null or empty");
                }
                string name = userName.Text;
                //drink = cmbxDrinks.SelectedItem.ToString() ?? "No Drink";
                drink = cmbxDrinks.SelectedItem.ToString();
                server.TakeOrder(name, amountEgg, amountChicken, drink);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            countChicken.Text = "";
            countEgg.Text = "";
            cmbxDrinks.SelectedItem = null;
        }

        private void sendOrderToCook_Click(object sender, EventArgs e)
        {
             Task.Factory.StartNew(() =>
                server.SendToCook()
            ).ContinueWith(task => ShowResult(task.Result.Result));

        }
        public void ShowResult(List<string> results)
        {
           
            lock (locker)
            {
                this.Invoke((Action)(() => 
                {
                    foreach (var item in results)
                    {
                        orderList.Items.Add(item);
                    }
                }));
            }
        }
    }
}
