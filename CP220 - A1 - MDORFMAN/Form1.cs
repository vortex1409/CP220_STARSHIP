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

        cruiser P1 = new cruiser("RN Kirov", 100, "Pristine");
        destroyer P2 = new destroyer("USS Sampson", 50, "Pristine");
        torpedo GenericTorpedo = new torpedo();
        laser GenericLaser = new laser();
        ion_bomb GenericIonBomb = new ion_bomb();
        
        public Form1()
        {
            InitializeComponent();
            UpdateStats();
            CheckVars();
        }

        public void CheckVars()
        {
            Console.WriteLine("P1 Health = " + P1.health);
            Console.WriteLine("P1 Max Health = " + P1.max_health);
            Console.WriteLine("P1 Shield = " + P1.shield_level);
            Console.WriteLine("P1 Type = " + P1.ship_type);
            Console.WriteLine("P1 Condition = " + P1.condition);

            Console.WriteLine("P2 Health = " + P2.health);
            Console.WriteLine("P2 Max Health = " + P2.max_health);
            Console.WriteLine("P2 Shield = " + P2.shield_level);
            Console.WriteLine("P2 Type = " + P2.ship_type);
            Console.WriteLine("P2 Condition = " + P2.condition);
        }

        private void UpdateStats()
        {
            p1HealthBar.Value = P1.health;
            p2HealthBar.Value = P2.health;
            p1ShieldBar.Value = P1.shield_level;
            p2ShieldBar.Value = P2.shield_level;
        }

        private void btnLaser1_Click(object sender, EventArgs e)
        {
            P1.fire(P2, GenericLaser.DamageOutput(P1.firing_damage));
            UpdateStats();
        }

        private void btnTorp1_Click(object sender, EventArgs e)
        {

        }

        private void btnIon1_Click(object sender, EventArgs e)
        {

        }

        private void btnReload1_Click(object sender, EventArgs e)
        {
            P1.load();
        }

        private void btnLaser2_Click(object sender, EventArgs e)
        {
            P2.fire(P1, GenericLaser.DamageOutput(P2.firing_damage));
            UpdateStats();
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

        private void btnCheckVar_Click(object sender, EventArgs e)
        {
            CheckVars();
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
        public starship(string ShipType, int MaxHealth, string Condition)
        {
            firing_damage = 1;
            shield_level = 100;
        }

        // Methods
        public bool fire(starship target, int dmg)
        {
            if(condition != condition_type[0])
            {
                if (ordinance > 0)
                {
                    ordinance = ordinance - 1;
                    takehit(target, dmg);
                    return true;
                }
                else
                {
                    MessageBox.Show("LOAD THE GUN IDIOT");
                    return false;
                }
            }
            else
            {
                return false;
            }
            
        }

        public void takehit(starship target, int dmg)
        {
            if(target.shield_level > 0)
            {
                target.shield_level = target.shield_level - dmg;

                //if (target.shield_level < 0)
                //{
                //    int tmp = Math.Abs(shield_level);
                //    target.health = target.health - tmp;
                //}
            }
            else if (target.shield_level <= 0)
            {
                target.health = target.health - dmg;
            }

            if(target.health <= 0)
            {
                target.condition = condition_type[0];
            }
            else if(target.health < target.max_health || target.health > 0)
            {
                target.condition = condition_type[1];
            }
            else if(target.health == max_health)
            {
                target.condition = condition_type[2];
            }

            Form1 ctrl = new Form1();

            ctrl.WarLog.Items.Clear();
            ctrl.WarLog.Items.Add("Ship Was Attacked");
            ctrl.WarLog.Items.Add("Ship Type: " + target.ship_type);
            ctrl.WarLog.Items.Add("Shields: " + target.shield_level + "/100");
            ctrl.WarLog.Items.Add("Health: " + target.health + "/" + target.max_health);
            ctrl.WarLog.Items.Add("Condition: " + target.condition);
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
        public cruiser(string ShipType, int MaxHealth, string Condition) 
            : base(ShipType, MaxHealth, Condition)
        {
            this.ship_type = ShipType;
            this.max_health = MaxHealth;
            this.health = MaxHealth;
            this.condition = Condition;
        }
    }

    public class destroyer : starship
    {
        // Fields
        public int firing_damage = 10;

        // Constructor
        public destroyer(string ShipType, int MaxHealth, string Condition) 
            : base(ShipType, MaxHealth, Condition)
        {
            this.ship_type = ShipType;
            this.max_health = MaxHealth;
            this.health = MaxHealth;
            this.condition = Condition;
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
