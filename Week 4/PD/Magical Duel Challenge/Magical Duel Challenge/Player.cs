using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Magical_Duel_Challenge
{
    internal class Player
    {
        public string name;
        public float hp;
        public float maxhp;
        public float energy;
        public float maxenergy;
        public float armor;
        List<Stats> skillStatistics = new List<Stats>();
        Stats skill;

        public Player(string name, float health, float energy, float armor)
        {
            this.hp = health;
            this.maxhp = health;
            this.maxenergy = energy;
            this.armor = armor;
            this.energy = energy;
            this.name = name;
        }

        public void updateAttributes(string name, float health, float energy, float armor)
        {
            // ensure that the values or health and energy aren't greater than max and can't be less than 0 as well.
            this.name = name;
            this.hp = health;
            this.energy=energy;
            this.armor = armor;
        }

        public void updatehealth(float health)
        {
            this.hp += health;
        }
        public void updateenergy(float energy)
        {
            this.energy += energy;
        }
        public void updatearmor(float armor)
        {
            this.armor = armor;
        }
        public void updatename(string name)
        {
            this.name = name;
        }

        public void learnSkill(Stats s)
        {
            skillStatistics.Add(s);
            skill = s;
        }

        public void showInfo()
        {
            Console.WriteLine($"Player Name: {name}\nHP: {hp}\nEnergy: {energy}\nArmor: {armor}");
        }
        public string Attack(Player p)
        {
            if (skill.cost > energy)
            {
                return $"{name} attempted to use {skill.name}, but didn't have enough energy!";
            }

            energy -= skill.cost;

            // Calculate Effectivearmor without modifying the target's actual armor
            float effectivearmor = Math.Max(p.armor - skill.penetration, 0);
            float damageMultiplier = (100 - effectivearmor) / 100;
            float damage = skill.damage * damageMultiplier;
            p.hp -= damage;

            string result = $"{name} used skill {skill.name}, {skill.description}, against {p.name}, doing {damage:F2} damage!";

            // Apply heal and append message if applicable
            if (skill.heal > 0)
            {
                hp += skill.heal;
                result += $" {name} healed for {skill.heal} health!";
            }

            // Append target's status
            if (p.hp <= 0)
            {
                result += $" {p.name} died!";
            }
            else
            {
                double hpPercentage = (p.hp / p.maxhp) * 100;
                result += $" {p.name} is at {hpPercentage:F2}% health.";
            }

            return result;
        }

    }
}
