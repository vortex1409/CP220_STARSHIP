using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CP220___A1___MDORFMAN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    }

    public class starship
    {
        // Fields
        private string ship_type;
        private int shield_level = 100;
        private int health, max_health;
        private string[] condition = new string[] { "Destroyed", "Damaged", "Pristine" };

    }

    public class cruiser : starship
    {

    }

    public class destroyer : starship
    {

    }

    public class ordinance
    {

    }

    public class torpedo : ordinance
    {

    }

    public class ion_bomb: ordinance
    {

    }

    public class laser : ordinance
    {

    }
}
