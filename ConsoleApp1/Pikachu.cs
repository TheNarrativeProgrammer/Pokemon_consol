using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Pikachu : Pokemon
    {
        //**CONSTRUCTORS**

        public Pikachu(string InName, string InPokeName)                                                   //Param constructor
        {
            //initialize member variables
            this.mHP = 25;                          //Name and Health
            this.mName = InName;
            this.mPokeName = InPokeName;
            this.mLevel = 3;                        //Level and Experience Points
            this.mEXPoints = 0;
            this.mType = Type.Electric;                //Type and weakenss
            this.mWeakness = Weakness.Grass;
            this.mAttack_Damage = 8;                //Attacks   
            this.mAttack_AccuracyDemoninator = 10;
            this.mAttack_BuffMultiplier = 1;
            this.mAttack_WeaknessMultiplier = 1;
            this.mAttack_StrengthSubtractor = 0;
            this.mDidAttackLand = true;
        }
    }
}
