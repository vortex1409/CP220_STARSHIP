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

        cruiser P1 = new cruiser("RN Kirov", 100);
        destroyer P2 = new destroyer("USS Sampson", 50);
        torpedo GenericTorpedo = new torpedo();
        laser GenericLaser = new laser();
        ion_bomb GenericIonBomb = new ion_bomb();

        public Form1()
        {
            InitializeComponent();
            p1HealthBar.Value = P1.max_health;
            p2HealthBar.Value = P2.max_health;
            p1ShieldBar.Value = P1.shield_level;
            p2ShieldBar.Value = P2.shield_level;

            Console.WriteLine(P1.max_health);

        }

        private void btnLaser1_Click(object sender, EventArgs e)
        {
            P2.takehit(GenericLaser.DamageOutput(P1.firing_damage));
            p2HealthBar.Value = p2HealthBar.Value - GenericLaser.DamageOutput(P1.firing_damage);
            WarLog.Items.Add("Damage Outputed: " + Convert.ToString(GenericLaser.DamageOutput(P1.firing_damage)));
        }

        private void btnTorp1_Click(object sender, EventArgs e)
        {

        }

        private void btnIon1_Click(object sender, EventArgs e)
        {

        }

        private void btnReload1_Click(object sender, EventArgs e)
        {

        }

        private void btnLaser2_Click(object sender, EventArgs e)
        {

        }

        private void btnTorp2_Click(object sender, EventArgs e)
        {
            
        }

        private void btnIon2_Click(object sender, EventArgs e)
        {

        }

        private void btnReload2_Click(object sender, EventArgs e)
        {
            P2.load();
        }
    }

    public class starship
    {

        // Variables & Arrays
        private string[] condition_type = new string[] { "Destroyed", "Damaged", "Pristine" };

        // Fields
        private string _ship_type;
        private int _shield_level;
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
            shield_level = 100;
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
                int tmp = 0 + Math.Abs(shield_level);
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
        // Fields
        public int firing_damage = 5;

        // Constructor
        public cruiser(string ShipType, int MaxHealth) 
            : base(ShipType, MaxHealth)
        {
            this.max_health = MaxHealth;
        }
    }

    public class destroyer : starship
    {
        // Fields
        public int firing_damage = 10;

        // Constructor
        public destroyer(string ShipType, int MaxHealth) 
            : base(ShipType, MaxHealth)
        {
            this.max_health = MaxHealth;
        }
    }   

    public interface ordinance
    {
        int DamageOutput(int Base);
    }

    public class torpedo : ordinance
    {
        // Torpedo does Base Damage + 10
        public int DamageOutput(int Base)
        {
            int output;
            return output = Base + 10;
        }
    }

    public class ion_bomb: ordinance
    {
        // Ion Bomb does Base Damage + 50
        public int DamageOutput(int Base)
        {
            int output;
            return output = Base + 50;
        }
    }

    public class laser : ordinance
    {
        // Laser does Base Damage + 5
        public int DamageOutput(int Base)
        {
            int output;
            return output = Base + 5;
        }
    }
}
