using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace driving_car
{
    public partial class Menu : Form
    {
        //global variable
        public static int num_car = 1;
        Level level = new Level();
        public Menu()
        {
            InitializeComponent();
            SelectCar(num_car, selectedCar);
        }

        private void slcright_Click(object sender, EventArgs e)
        {
            num_car++;
            num_car = num_car == 9 ? 1 : num_car;
            SelectCar(num_car, selectedCar);
        }

        private void slcleft_Click(object sender, EventArgs e)
        {
            num_car--;
            num_car = num_car == 0 ? 8 : num_car;
            SelectCar(num_car, selectedCar);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            level.ShowDialog();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void SelectCar(int carId, PictureBox Car)
        {
            switch (carId)
            {
                case 1:
                    Car.Image = Properties.Resources.carGreen;
                    break;
                case 2:
                    Car.Image = Properties.Resources.carGrey;
                    break;
                case 3:
                    Car.Image = Properties.Resources.carOrange;
                    break;
                case 4:
                    Car.Image = Properties.Resources.carPink;
                    break;
                case 5:
                    Car.Image = Properties.Resources.CarRed;
                    break;
                case 6:
                    Car.Image = Properties.Resources.TruckBlue;
                    break;
                case 7:
                    Car.Image = Properties.Resources.TruckWhite;
                    break;
                case 8:
                    Car.Image = Properties.Resources.ambulance;
                    break;
                default:
                    break;
            }
        }

    }
}
