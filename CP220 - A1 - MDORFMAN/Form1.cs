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
        private string _ship_type;
        private int _shield_level = 100;
        private int _health, _max_health;
        private string _condition;
        private int ordinance;
        private int firing_damage;

        // Properties
        public string ship_type
        {
            get { return _ship_type; }
            set { _ship_type = value; }
        }

        public int shield_level
        {
            get { return _shield_level; }
            set { _shield_level = value; }
        }

        public int health
        {
            get { return _health; }
            set { _health = value; }
        }

        public int max_health
        {
            get { return _max_health; }
            set { _max_health = value; }
        }

        public string condition
        {
            get { return _condition; }
            set { _condition = value; }
        }

        // Constuctor
        public starship
        {

        }

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
