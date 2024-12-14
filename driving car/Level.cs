using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace driving_car
{

    public partial class Level : Form
    {
        public static int level = 1;
        public static int carSpeed = 5;
        public static int roadSpeed = 5;
        public static int trafficSpeed = 5;

        public Level()
        {
            InitializeComponent();
        }

        private void lvl1_Click(object sender, EventArgs e)
        {
            level1();
            DrivingCar drivingCar = new DrivingCar();
            drivingCar.ShowDialog();
            this.Close();
        }

        private void backtomenu_Click(object sender, EventArgs e)
        {
            Menu Menu = new Menu();
            this.Close();
            Menu.ShowDialog();
        }

        private void lvl2_Click(object sender, EventArgs e)
        {
            level2();
            DrivingCar drivingCar = new DrivingCar();
            drivingCar.ShowDialog();
            this.Close();
        }

        private void lvl3_Click(object sender, EventArgs e)
        {
            level3();
            DrivingCar drivingCar = new DrivingCar();
            drivingCar.ShowDialog();
            this.Close();
        }

        private void lvl4_Click(object sender, EventArgs e)
        {
            level4();
            DrivingCar drivingCar = new DrivingCar();
            drivingCar.ShowDialog();
            this.Close();
        }

        private void lvl5_Click(object sender, EventArgs e)
        {
            level5();
            DrivingCar drivingCar = new DrivingCar();
            drivingCar.ShowDialog();
            this.Close();
        }

        private void lvl6_Click(object sender, EventArgs e)
        {
            level6();
            DrivingCar drivingCar = new DrivingCar();
            drivingCar.ShowDialog();
            this.Close();
        }

        public void level1()
        {
            level = 1;
            carSpeed = 5;
            roadSpeed = 5;
            trafficSpeed = 5;
        }

        public void level2()
        {
            level = 2;
            carSpeed = 5;
            roadSpeed = 6;
            trafficSpeed = 6;
        }

        public void level3()
        {
            level = 3;
            carSpeed = 6;
            roadSpeed = 6;
            trafficSpeed = 7;
        }

        public void level4()
        {
            level = 4;
            carSpeed = 6;
            roadSpeed = 7;
            trafficSpeed = 8;
        }

        public void level5()
        {
            level = 5;
            carSpeed = 7;
            roadSpeed = 8;
            trafficSpeed = 9;
        }

        public void level6()
        {
            level = 6;
            carSpeed = 7;
            roadSpeed = 9;
            trafficSpeed = 10;
        }
    }
}
