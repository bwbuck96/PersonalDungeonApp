using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace DungeonLibrary
{
    public class Monster
    {
        private string _monsterName;
        private int _hitChance;
        private int _block;
        private int _life;
        private int _maxLife;
        private MonsterBreed _monsterBreed;
        private Weapon _equippedWeapon;

        public string MonsterName
        {
            get { return _monsterName; }
            set { _monsterName = value; }
        }
        public int HitChance
        {
            get { return _hitChance; }
            set { _hitChance = value; }
        }
        public int Block
        {
            get { return _block; }
            set { _block = value; }
        }
        public int MaxLife
        {
            get { return _maxLife; }
            set { _maxLife = value; }
        }
        public MonsterBreed MonsterBreed
        {
            get { return _monsterBreed; }
            set { _monsterBreed = value; }
        }
        public Weapon EquippedWeapon
        {
            get { return _equippedWeapon; }
            set { _equippedWeapon = value; }
        }

        //Properties and Fields that require Custom "Business Rules"
        //properties and fields that require business rules should come AFTER properties/fields that use the default.
        public int Life
        {
            get { return _life; }
            set
            {
                //Business rule example. Life should not be more than MaxLife
                if (value <= MaxLife)
                {
                    _life = value;
                }
                else
                { _life = MaxLife; }
            }
        }
        //CONSTRUCTORS!
        //Special methods used to create objects of this type.
        //Access is ALWAYS public
        //Naming Convention: PascalCase - MUST match the name of the class

        //Fully Qualified Constructor, All properties are accounted for with Parameters.

        public Monster(string monsterName, int block, int hitChance, int life, int maxLife, Race monsterBreed, Weapon equippedWeapon)
        {
            //ASSIGNMENT
            //Property = parameter;
            //PascalCase = camelCase;
            //Business Rule items should be at the bottom of the list.
            MonsterName = monsterName;
            Block = block;
            HitChance = hitChance;
            MaxLife = maxLife;
            MonsterBreed = MonsterBreed;
            EquippedWeapon = equippedWeapon;
            Life = life; //Life depends on MaxLife, so MaxLife MUST be set first.

        }
        public override string ToString()
        {
            //  return base.ToString(); 
            string description = "";

            switch (MonsterBreed)
            {
                case MonsterBreed.Orc:
                    description = "A burly, green-skinned, brute bred for violence. Orcs are considered to be dumb, mean, and ugly. Orcs are particuarly proud of being ugly.";
                    break;
                case MonsterBreed.Hobbit:
                    description = "Kind-hearted hill folk who enjoy tea and second breakfast, along with the occasional adventure. Fond of dwarves and fearful of spiders.";
                    break;
                case MonsterBreed.Elf:
                    description = "Tall, nature loving, forest dwellers who shunned civillization. Skilled in magic and rarely friendly with other races.";
                    break;
                case MonsterBreed.Human:
                    description = "The most common race of the realm, widely considered to be the weakest race with the greatest potential of them all. Easily tempted by magic jewelry.";
                    break;
                case MonsterBreed.Dwarf:
                    description = "Short, stout, and built like a brick house. Master crafstmen amongst the forge. Rock and Stone.";
                    break;
                case MonsterBreed.Gnome:
                    description = "The smallest of the races, both in stature and bulk. Known for thievery and expert tinkering.";
                    break;
                case MonsterBreed.HalfGiant:
                    description = "Large, oftentimes brutal creatures. Barely considered sentient amongst the other races, Half Giants are widely avoided.";
                    break;
                case MonsterBreed.Tiefling:
                    description = "Often considered the most clear form of Evil amongst all of the sentient races. Judged prematurely by many, the true conscience of Tieflings are as wide and varied as any other race.";
                    break;
                case MonsterBreed.UndeadHuman:
                    description = "A grotesque warping of the natural order. Undead Humans no longer have the potential for growth, but in exchange they retain their mental senses beyond the grave.";
                    break;
                case MonsterBreed.UndeadElf:
                    description = "Considered abominations amongst their living counterparts, Elves are extremely rare amongst the undead. Their magic becomes warped into a dark and monstrous force, often corrupting their mind into a twisted fascimile of who they once were.";
                    break;
                case MonsterBreed.UndeadDwarf:
                    description = "Amongst the Undead, Dwarves are considered to be the most unpredictable. Dwarves can continue living their lives with almost no change upon becoming Undead, however, as soon as one realizes they have become a walking cadaver, they will immediately embrace true death.";
                    break;
                case MonsterBreed.Slime:
                    //TODO 20 Generate descriptions for monsters!
                    description = "A small green slime, immune to most forms of physical and magical damge.";
                    break;
                case MonsterBreed.Bat:
                    description = "A small green slime, immune to most forms of physical and magical damge.";
                    break;
                case MonsterBreed.Rat:
                    description = "A small green slime, immune to most forms of physical and magical damge.";
                    break;
                case MonsterBreed.Goblin:
                    description = "A small green slime, immune to most forms of physical and magical damge.";
                    break;
                case MonsterBreed.Kobold:
                    description = "A small green slime, immune to most forms of physical and magical damge.";
                    break;
                case MonsterBreed.RedDragon:
                    description = "A small green slime, immune to most forms of physical and magical damge.";
                    break;
                case MonsterBreed.Crab:
                    description = "A small green slime, immune to most forms of physical and magical damge.";
                    break;
                case MonsterBreed.Snake:
                    description = "A small green slime, immune to most forms of physical and magical damge.";
                    break;
                case MonsterBreed.PhaseHound:
                    description = "A small green slime, immune to most forms of physical and magical damge.";
                    break;
                case MonsterBreed.Spider:
                    description = "A small green slime, immune to most forms of physical and magical damge.";
                    break;
                case MonsterBreed.Zombie:
                    description = "A small green slime, immune to most forms of physical and magical damge.";
                    break;
                case MonsterBreed.Vampire:
                    description = "A small green slime, immune to most forms of physical and magical damge.";
                    break;
                case MonsterBreed.Werewolf:
                    description = "A small green slime, immune to most forms of physical and magical damge.";
                    break;
                case MonsterBreed.Demon:
                    description = "A small green slime, immune to most forms of physical and magical damge.";
                    break;
                case MonsterBreed.Warlock:
                    description = "A small green slime, immune to most forms of physical and magical damge.";
                    break;
                case MonsterBreed.Witch:
                    description = "A small green slime, immune to most forms of physical and magical damge.";
                    break;
                case MonsterBreed.LurkingHorror:
                    description = "A small green slime, immune to most forms of physical and magical damge.";
                    break;
                case MonsterBreed.Beholder:
                    description = "A small green slime, immune to most forms of physical and magical damge.";
                    break;

            }

            return string.Format("\t\t\tMONSTER INFO\n xXxXx {0} xXxXx\n" +
                "Life: {1} of {2}\nHit Chance: {3}%\n" +
                "Weapon: {4}\nBlock: {5}\nDescription: {6}",
                MonsterName,
                Life,
                MaxLife,
                HitChance,
                EquippedWeapon.Name,
                Block,
                description);

        }


    }
}
