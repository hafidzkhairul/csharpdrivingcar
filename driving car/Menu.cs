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
        public Menu()
        {
            InitializeComponent();
            SelectCar(num_car, selectedCar);
        }

        private void slcright_Click(object sender, EventArgs e)
        {
            num_car++;
            num_car = num_car == 11 ? 1 : num_car;
            SelectCar(num_car, selectedCar);
        }

        private void slcleft_Click(object sender, EventArgs e)
        {
            num_car--;
            num_car = num_car == 0 ? 10 : num_car;
            SelectCar(num_car, selectedCar);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Level level = new Level();
            level.Show();
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
                    Car.Image = Properties.Resources.car11;
                    break;
                case 2:
                    Car.Image = Properties.Resources.car21;
                    break;
                case 3:
                    Car.Image = Properties.Resources.car31;
                    break;
                case 4:
                    Car.Image = Properties.Resources.car41;
                    break;
                case 5:
                    Car.Image = Properties.Resources.car51;
                    break;
                case 6:
                    Car.Image = Properties.Resources.car61;
                    break;
                case 7:
                    Car.Image = Properties.Resources.car71;
                    break;
                case 8:
                    Car.Image = Properties.Resources.car81;
                    break;
                case 9:
                    Car.Image = Properties.Resources.car91;
                    break;
                case 10:
                    Car.Image = Properties.Resources.car101;
                    break;
                default:
                    break;
            }
        }
    }
}
