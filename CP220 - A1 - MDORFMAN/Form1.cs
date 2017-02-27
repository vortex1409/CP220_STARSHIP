using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

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

        // Variables & Arrays
        private string[] condition_type = new string[] { "Destroyed", "Damaged", "Pristine" };

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
        public starship(string ShipType, int MaxHealth)
        {
            firing_damage = 1;
        }

        // Methods
        public bool fire(starship target)
        {
            if(condition != condition_type[0])
            {
                if (ordinance > 0)
                {
                    ordinance = ordinance - 1;
                    takehit(firing_damage);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
            
        }

        public void takehit(int dmg)
        {
            shield_level = shield_level - dmg;

            if(shield_level < 0)
            {
                int tmp = 0 + shield_level;
                health = health - tmp;
            }

            if(health <= 0)
            {
                condition = condition_type[0];
            }
            else if(health < max_health || health > 0)
            {
                condition = condition_type[1];
            }
            else if(health == max_health)
            {
                condition = condition_type[2];
            }

            Console.WriteLine("Ship Was Attacked");
            Console.WriteLine("Ship Type: " + ship_type);
            Console.WriteLine("Health: " + health + "/" + max_health);
            Console.WriteLine("Condition: " + condition);

        }

        public void load()
        {
            ordinance = ordinance + 2;
        }

    }

    public class cruiser : starship
    {
        public cruiser(string ShipType, int MaxHealth) 
            : base(ShipType, MaxHealth)
        {

        }
    }

    public class destroyer : starship
    {
        public destroyer(string ShipType, int MaxHealth) 
            : base(ShipType, MaxHealth)
        {

        }
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
