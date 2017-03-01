﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

/*
    Project: Assignment 1
    Description: Space War
    Name: Michael Dorfman
    Class: CP220 - OOP 2
    Date: 02/28/2017 - 2:48 PM (EST)
*/

namespace CP220___A1___MDORFMAN
{
    public partial class Form1 : Form
    {
        cruiser P1 = new cruiser("RN Kirov", 100);
        destroyer P2 = new destroyer("USS Sampson", 50);
        torpedo GenericTorpedo = new torpedo();
        laser GenericLaser = new laser();
        ion_bomb GenericIonBomb = new ion_bomb();

        private string[] weapon_type = new string[] { "Laser", "Torpedo", "Ion Bomb" };

        public Form1()
        {
            InitializeComponent();
            UpdateStats();
            CheckVars();
        }
        public void CheckVars()
        {
            Console.WriteLine("P1 Name: " + P1.name);
            Console.WriteLine("P1 Type = " + P1.ship_type);
            Console.WriteLine("P1 Health = " + P1.health);
            Console.WriteLine("P1 Max Health = " + P1.max_health);
            Console.WriteLine("P1 Shield = " + P1.shield_level);
            Console.WriteLine("P1 Condition = " + P1.condition);
            Console.WriteLine("P1 Ammo = " + Convert.ToString(P1.ammo_count()));

            Console.WriteLine("P1 Name: " + P2.name);
            Console.WriteLine("P2 Type = " + P2.ship_type);
            Console.WriteLine("P2 Health = " + P2.health);
            Console.WriteLine("P2 Max Health = " + P2.max_health);
            Console.WriteLine("P2 Shield = " + P2.shield_level);
            
            Console.WriteLine("P2 Condition = " + P2.condition);
            Console.WriteLine("P2 Ammo = " + Convert.ToString(P2.ammo_count()));
        }
        public void WarLogUpdater(string attacker, string target, string weapon, int damage)
        {   
            if(P1.ammo_count() != 0 || P2.ammo_count() != 0)
            {
                WarLog.Items.Add("=== | NEW EVENT | ===");
                WarLog.Items.Add(attacker + " attacked " + target);
                WarLog.Items.Add("Weapon Used: " + weapon);
                WarLog.Items.Add("Damage Delt: " + damage);
                WarLog.Items.Add("=== === === === === ===");
            }
            else
            {
                MessageBox.Show("Attack was not carried out");
            }
            
        }
        public void ClearLog()
        {
            WarLog.Items.Clear();
        }
        private void UpdateStats()
        {
            if(P1.health <= 0)
            {
                p1HealthBar.Value = 0;
            }
            else
            {
                p1HealthBar.Value = P1.health;
            }

            if (P2.health <= 0)
            {
                p2HealthBar.Value = 0;
            }
            else
            {
                p2HealthBar.Value = P2.health;
            }

            if (P1.shield_level <= 0)
            {
                p1ShieldBar.Value = 0;
            }
            else
            {
                p1ShieldBar.Value = P1.shield_level;
            }

            if (P2.shield_level <= 0)
            {
                p2ShieldBar.Value = 0;
            }
            else
            {
                p2ShieldBar.Value = P2.shield_level;
            }

        }
        private void btnLaser1_Click(object sender, EventArgs e)
        {
            P1.fire(P2, GenericLaser.DamageOutput(P1.firing_damage));
            UpdateStats();
            WarLogUpdater(P1.name, P2.name, weapon_type[0], GenericLaser.DamageOutput(P1.firing_damage));
        }
        private void btnTorp1_Click(object sender, EventArgs e)
        {
            P1.fire(P2, GenericTorpedo.DamageOutput(P1.firing_damage));
            UpdateStats();
            WarLogUpdater(P1.name, P2.name, weapon_type[1], GenericTorpedo.DamageOutput(P1.firing_damage));
        }
        private void btnIon1_Click(object sender, EventArgs e)
        {
            P1.fire(P2, GenericIonBomb.DamageOutput(P1.firing_damage));
            UpdateStats();
            WarLogUpdater(P1.name, P2.name, weapon_type[2], GenericIonBomb.DamageOutput(P1.firing_damage));
        }
        private void btnReload1_Click(object sender, EventArgs e)
        {
            P1.load();
        }
        private void btnLaser2_Click(object sender, EventArgs e)
        {
            P2.fire(P1, GenericLaser.DamageOutput(P2.firing_damage));
            UpdateStats();
            WarLogUpdater(P2.name, P1.name, weapon_type[0], GenericLaser.DamageOutput(P2.firing_damage));
        }
        private void btnTorp2_Click(object sender, EventArgs e)
        {
            P2.fire(P1, GenericTorpedo.DamageOutput(P2.firing_damage));
            UpdateStats();
            WarLogUpdater(P2.name, P1.name, weapon_type[1], GenericTorpedo.DamageOutput(P2.firing_damage));
        }
        private void btnIon2_Click(object sender, EventArgs e)
        {
            P2.fire(P1, GenericLaser.DamageOutput(P2.firing_damage));
            UpdateStats();
            WarLogUpdater(P2.name, P1.name, weapon_type[2], GenericIonBomb.DamageOutput(P2.firing_damage));
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
        private string _name;

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
        public string name 
        {
            get { return _name; }
            set { _name = value; }
        }

        // Constuctor
        public starship(string ShipName, int MaxHealth)
        {
            firing_damage = 1;
            shield_level = 100;
            name = ShipName;
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
                MessageBox.Show("SHIP IS DESTROYED CANNOT FIRE");
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

            Console.WriteLine("Ship Was Attacked");
            Console.WriteLine("Ship Type: " + target.ship_type);
            Console.WriteLine("Shields: " + target.shield_level + "/100");
            Console.WriteLine("Health: " + target.health + "/" + target.max_health);
            Console.WriteLine("Condition: " + target.condition);

        }
        public void load()
        {
            ordinance = ordinance + 2;
        }
        public int ammo_count()
        {
            return ordinance;
        }
    }

    public class cruiser : starship
    {
        // Fields
        public int firing_damage = 5;

        // Constructor
        public cruiser(string ShipName, int MaxHealth) 
            : base(ShipName, MaxHealth)
        {
            this.ship_type = "Cruiser";
            this.max_health = MaxHealth;
            this.health = MaxHealth;
            this.condition = "Pristine";
        }
    }

    public class destroyer : starship
    {
        // Fields
        public int firing_damage = 10;

        // Constructor
        public destroyer(string ShipName, int MaxHealth) 
            : base(ShipName, MaxHealth)
        {
            this.ship_type = "Destroyer";
            this.max_health = MaxHealth;
            this.health = MaxHealth;
            this.condition = "Pristine";
        }
    }   

    public interface ordinance
    {
        int DamageOutput(int Base);
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

    
}
