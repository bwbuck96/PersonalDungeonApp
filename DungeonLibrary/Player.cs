using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    //public is an access modifier. It determines WHERE this class can be used in our application.
    //Since we want to make Player objects in our Dungeon Console App project, we need this class
    //to be public.
    public class Player
    {
        //FIELDS
        //Fields are nothing more than variables to store information related to this kind of object.
        //The access for fields is ALWAYS private.
        //Naming convention. _fieldName
        private string _playerName;
        private int _hitChance;
        private int _block;
        private int _life;
        private int _maxLife;
        private Race _characterRace;
        private Weapon _equippedWeapon;
        //PROPERTIES
        //Publicly available gatekeepers of the information in the fields.
        //Define the rules for interacting with the fields & their values.
        public string PlayerName
        {
            get { return _playerName; }
            set { _playerName = value; }
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
        public Race CharacterRace
        {
            get { return _characterRace; }
            set { _characterRace = value; }
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

        public Player(string playerName, int block, int hitChance, int life, int maxLife, Race characterRace, Weapon equippedWeapon)
        {
            //ASSIGNMENT
            //Property = parameter;
            //PascalCase = camelCase;
            //Business Rule items should be at the bottom of the list.
            PlayerName = playerName;
            Block = block;
            HitChance = hitChance;
            MaxLife = maxLife;
            CharacterRace = characterRace;
            EquippedWeapon = equippedWeapon;
            Life = life; //Life depends on MaxLife, so MaxLife MUST be set first.

        }
        public override string ToString()
        {
            //  return base.ToString(); 
            string description = "";

            switch (CharacterRace)
            {
                case Race.Orc:
                    description = "A burly, green-skinned, brute bred for violence. Orcs are considered to be dumb, mean, and ugly. Orcs are particuarly proud of being ugly.";
                    break;
                case Race.Hobbit:
                    description = "Kind-hearted hill folk who enjoy tea and second breakfast, along with the occasional adventure. Fond of dwarves and fearful of spiders.";
                    break;
                case Race.Elf:
                    description = "Tall, nature loving, forest dwellers who shunned civillization. Skilled in magic and rarely friendly with other races.";
                    break;
                case Race.Human:
                    description = "The most common race of the realm, widely considered to be the weakest race with the greatest potential of them all. Easily tempted by magic jewelry.";
                    break;
                case Race.Dwarf:
                    description = "Short, stout, and built like a brick house. Master crafstmen amongst the forge. Rock and Stone.";
                    break;
                case Race.Gnome:
                    description = "The smallest of the races, both in stature and bulk. Known for thievery and expert tinkering.";
                    break;
                case Race.HalfGiant:
                    description = "Large, oftentimes brutal creatures. Barely considered sentient amongst the other races, Half Giants are widely avoided.";
                    break;
                case Race.Tiefling:
                    description = "Often considered the most clear form of Evil amongst all of the sentient races. Judged prematurely by many, \t\tthe true conscience of Tieflings are as wide and varied as any other race.";
                    break;
                case Race.UndeadHuman:
                    description = "A grotesque warping of the natural order. Undead Humans no longer have the potential for growth, but in exchange they retain their mental senses beyond the grave.";
                    break;
                case Race.UndeadElf:
                    description = "Considered abominations amongst their living counterparts, Elves are extremely rare amongst the undead. Their magic becomes warped into a dark and monstrous force, often corrupting their mind into a twisted fascimile of who they once were.";
                    break;
                case Race.UndeadDwarf:
                    description = "Amongst the Undead, Dwarves are considered to be the most unpredictable. Dwarves can continue living their lives with almost no change upon becoming Undead, however, as soon as one realizes they have become a walking cadaver, they will immediately embrace true death.";
                    break;
            }

            return string.Format("\t\t\tPLAYER INFO\n xXxXx {0} xXxXx\n" +
                "Life: {1} of {2}\nHit Chance: {3}%\n" +
                "Block: {4}\nDescription: {5}\n\n\nEquipped Weapon: {6}",
                PlayerName,
                Life,
                MaxLife,
                HitChance,
                Block,
                description,
                EquippedWeapon
                );

        }

    }
}
