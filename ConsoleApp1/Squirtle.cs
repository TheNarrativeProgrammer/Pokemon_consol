using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Squirtle : Pokemon
    {

        //**CONSTRUCTORS**
        public Squirtle()               //default constructor
        {
            //initialize member variables
            this.mHP = 30;                          //Name and Health
            this.mName = "Squirtle";
            this.mLevel = 5;                        //Level and Experience Points
            this.mEXPoints = 0;
            this.mType = Type.Water;            //Type and weakenss
            this.mWeakness = Weakness.Grass;
            this.mAttack_Damage = 7;                //Attacks   
            this.mAttack_AccuracyDemoninator = 10;
            this.mAttack_BuffMultiplier = 1;
            this.mAttack_WeaknessMultiplier = 1;
            this.mAttack_StrengthSubtractor = 0;
        }

        public Squirtle(string InName)               //param constructor
        {
            //initialize member variables
            this.mHP = 30;                          //Name and Health
            this.mName = InName;
            this.mLevel = 5;                        //Level and Experience Points
            this.mEXPoints = 0;
            this.mType = Type.Water;            //Type and weakenss
            this.mWeakness = Weakness.Grass;
            this.mAttack_Damage = 7;                //Attacks   
            this.mAttack_AccuracyDemoninator = 10;
            this.mAttack_BuffMultiplier = 1;
            this.mAttack_WeaknessMultiplier = 1;
            this.mAttack_StrengthSubtractor = 0;
        }

    }
}
