using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Pokemon
    {

        //**MEMBER VARIABLES**
        public int mHP;                //Name and Health
        public string mName;
        public string[] mPokeNameString = {"Unknown Pokemon","Squirtle", "Charmander", "Bulbasaur", "Caterpie", "Pikachau",};
        public string mPokeName;
        public int mLevel;             //Level and Experience Points
        public int mEXPoints;
        public enum Type               //Type and weakenss
        {
            Water,
            Fire,
            Grass,
            Colorless,
            Electric,
        };
        public Type mType;

        public enum Weakness
        {
            Grass,
            Water,
            Fire,
            None,
            
        }
        public Weakness mWeakness;

        public int mAttack_Damage;     //Attack Stats         
        public int mAttack_AccuracyDemoninator;
        public int mAttack_BuffMultiplier;
        public int mAttack_WeaknessMultiplier;
        public int mAttack_StrengthSubtractor;
        public bool mDidAttackLand;


        //**CONSTRUCTORS**
        public Pokemon()               //default constructor
        {
            //initialize member variables
            this.mHP = 26;                          //Name and Health
            this.mName = "Wild Caterpie";
            this.mPokeName = mPokeNameString[4];
            this.mLevel = 3;                        //Level and Experience Points
            this.mEXPoints = 0;
            this.mType = Type.Grass;            //Type and weakenss
            this.mWeakness = Weakness.Fire;
            this.mAttack_Damage = 2;                //Attacks   
            this.mAttack_AccuracyDemoninator = 10;
            this.mAttack_BuffMultiplier = 1;
            this.mAttack_WeaknessMultiplier = 1;
            this.mAttack_StrengthSubtractor = 0;
            this.mDidAttackLand = true;
        }

        //**FUNCTIONS**

        //*MODIFICATIONS TO ATTACK FUNCTIONS.

                                                                                                                        //WEAKNESS AND STRENGTH OF OPPONENT - change damage mods
        public void CalcWeakStrongDamageAffects(Type InTypeOfOpponent)
        {
            //Determine if Players pokemon is strong or weak against opponents type.    
            switch (this.mType)                                         //If opponent is weak - Double damage       
            {                                                           //if opponet is strong - subtract 2 from damage
                case Type.Grass:                                                                                                     //player    vs  opponent
                    {
                        if (InTypeOfOpponent == Type.Water)              //OPPONENT IS WEAK                                          //grass     vs  Water
                        {
                            this.mAttack_WeaknessMultiplier = 2;
                        }
                        if (InTypeOfOpponent == Type.Fire)              //OPPONENT IS STRONG                                        //grass     vs  fire
                        {
                            this.mAttack_StrengthSubtractor = 2;
                        }
                        break;
                    }
                case Type.Water:
                    {
                        if (InTypeOfOpponent == Type.Fire)              //OPPONENT IS WEAK                                          //water     vs  fire
                        {
                            this.mAttack_WeaknessMultiplier = 2;
                        }
                        if (InTypeOfOpponent == Type.Grass)              //OPPONENT IS STRONG                                       //water     vs  grass
                        {
                            this.mAttack_StrengthSubtractor = 2;
                        }
                        break;
                    }
                case Type.Fire:
                    {
                        if (InTypeOfOpponent == Type.Grass)              //OPPONENT IS WEAK                                          //fire     vs  grass
                        {
                            this.mAttack_WeaknessMultiplier = 2;
                        }
                        if (InTypeOfOpponent == Type.Water)              //OPPONENT IS STRONG                                        //fire     vs  water
                        {
                            this.mAttack_StrengthSubtractor = 2;
                        }
                        break;
                    }
                case Type.Electric:
                    {
                        if (InTypeOfOpponent == Type.Water)              //OPPONENT IS WEAK                                          //fire     vs  grass
                        {
                            this.mAttack_WeaknessMultiplier = 2;
                        }
                        //if (InTypeOfOpponent == Type.Grass)              //OPPONENT IS STRONG                                        //fire     vs  water
                        //{
                        //    this.mAttack_StrengthSubtractor = 2;
                        //}
                        break;
                    }
                case Type.Colorless:
                    {
                        this.mAttack_WeaknessMultiplier = 2;             //OPPONENT IS WEAK                                          //Colorless  vs  all

                        this.mAttack_StrengthSubtractor = 0;            //OPPONENT IS STRONG                                        //Colorless   vs  all   
                        break;
                    }
                        default:
                    {
                        Console.WriteLine("In default, in attack swich statment and no weakness or strong affect to damage applied");
                        break;
                    }
            }
        }

                                                                                                                                //ACCURACY OF ATTACK
        public virtual bool CalculateAccuracyOfAttack()
        {
            Random randomNumObject = new Random();
            int AccuracyResult = randomNumObject.Next(1, this.mAttack_AccuracyDemoninator);
            Console.WriteLine(AccuracyResult);

            //Determine if Attack hit. If Result is 1, then attack misses. Any other number attack lands.
            bool DidAttackLand = true;
            if (AccuracyResult == 1)
            {
                DidAttackLand = false;
            }
            return DidAttackLand;
        }

        //*ATTACK FUNCTIONS*

                                                                                                                                //ATTACK - DAMAGING
        public virtual int AttackOffensive(Pokemon InDefendingPokemon, int InCountAttacks)
        {
            int DamageToOponent = 0;

            if (InCountAttacks <= 1)                                     //check weakness only on frist attack. Weakness doesn't change, so only perform check once.
            {
                CalcWeakStrongDamageAffects(InDefendingPokemon.mType);
            }
         
            //calc damage
            this.mDidAttackLand = CalculateAccuracyOfAttack();              //Call CalculateAccuracyOfAttack to determine if attack landed. Damage is 0 if attack missed (false)

            if (this.mDidAttackLand == true) 
            {
            DamageToOponent = ((this.mAttack_Damage * this.mAttack_WeaknessMultiplier * this.mAttack_BuffMultiplier) - this.mAttack_StrengthSubtractor);
            }
            else 
            {
                Console.WriteLine("FOR ERROR CHECKING. REMOVE AFTER GAME FINISHED. your attack missed.");
            }

            //reset buff multiplier to 1 and subtractor
            this.mAttack_BuffMultiplier = 1;
            this.mAttack_StrengthSubtractor = 0;

            Console.WriteLine("FOR ERROR CHECKING. In attack function");
            return DamageToOponent;
        }

                                                                                                                                //ATTACK - ACCURACY
        public virtual void AttackAccuracy(Pokemon InPokemon)
        {
             this.mDidAttackLand = CalculateAccuracyOfAttack();                 //Call CalculateAccuracyOfAttack to determine if attack landed. Damage is 0 if attack missed (false)

            if (this.mDidAttackLand == true)
            {
                InPokemon.mAttack_AccuracyDemoninator -= 1;             //Change the demoninator of opponents accuracy calulation, making a miss more likely.
                if(InPokemon.mAttack_AccuracyDemoninator<=4)
                {
                    InPokemon.mAttack_AccuracyDemoninator = 4;          //cap the affect on accuracy at a demoninator of 4
                }
            }
            else
            {
                Console.WriteLine("FOR ERROR TESTING. REMOVE AFTER GAME FINISHED. your attack missed.");
            }
        }

                                                                                                                                //ATTACK - BUFF 
        public virtual void AttackBuff()
        {
            //Change the demoninator of opponents accuracy calulation. This is used in CalculateAccuracyOfAttack. Changing Demoninator makes a miss more likely.
            this.mAttack_BuffMultiplier = 3;
            this.mDidAttackLand = true;
        }


        
        
    }
}
