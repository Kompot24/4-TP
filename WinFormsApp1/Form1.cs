namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        List<Vehicles> vehiclesList = new List<Vehicles>();
        public Form1()
        {
            InitializeComponent();
            ShowInfo();
        }

        private void btnRefill_Click(object sender, EventArgs e)
        {
            this.vehiclesList.Clear();
            var rnd = new Random();
            for (var i = 0; i < 10; i++)
            {
                switch (rnd.Next() % 3)
                {
                    case 0:
                        this.vehiclesList.Add(new Car
                        {
                            countDoors = rnd.Next() % 7 + 2,
                            amountWheels = rnd.Next() % 25 + 3,
                            type = (CarType)rnd.Next(4)
                        });
                        break;
                    case 1:
                        this.vehiclesList.Add(new Airplane
                        {
                            maxFlightAltitude = rnd.Next() % 13001 + 300,
                            amountWheels = rnd.Next() % 33 + 6,
                            type = (AirplaneEngineType)rnd.Next(3)
                        });
                        break;
                    case 2:
                        this.vehiclesList.Add(new Bike
                        {
                            wheelRadius = rnd.Next() % 30 + 6,
                            amountWheels = rnd.Next() % 5 + 1,
                            type = (BikeType)rnd.Next(3)
                        });
                        break;
                }
            }
            ShowInfo();
        }

        private void ShowInfo()
        {
            int carCount = 0;
            int airplaneCount = 0;
            int bikeCount = 0;

            foreach (var vehicles in this.vehiclesList)
            {
                if (vehicles is Car)
                {
                    carCount++;
                }
                else if (vehicles is Airplane)
                {
                    airplaneCount++;
                }
                else if (vehicles is Bike)
                {
                    bikeCount++;
                }

            }
            txtInfo.Text = "Машн\tСмлёт\tВело";
            txtInfo.Text += "\n";
            txtInfo.Text += String.Format("{0}\t{1}\t{2}", carCount, airplaneCount, bikeCount);
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            if (this.vehiclesList.Count == 0)
            {
                txtOut.Text = "Пусто Q_Q";
                return;
            }

            var vehicle = this.vehiclesList[0];

            this.vehiclesList.RemoveAt(0);
            
            txtOut.Text = vehicle.GetInfo();

            ShowInfo();
        }
    }
}
