using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OscarDamageCalculatorUIHerm
{
    internal class SwordDamage
    {
        public SwordDamage(int roll)
        {
            this.roll = roll;
            CalculateDamage();
        }

        /// <summary>
        /// Value always added to damage.
        /// </summary>
        public const int BASE_DAMAGE = 3;

        /// <summary>
        /// Value added to damage if sword is flaming.
        /// </summary>
        public const int FLAME_DAMAGE = 2;

        private int roll;
        /// <summary>
        /// 3d6 roll value to count damage.
        /// </summary>
        public int Roll
        {
            get { return roll; }
            set
            {
                roll = value;
                CalculateDamage();
            }
        }

        private bool flaming;
        /// <summary>
        /// Is sword flaming.
        /// </summary>
        public bool Flaming
        {
            get { return flaming; }
            set
            {
                flaming = value;
                CalculateDamage();
            }
        }

        /// <summary>
        /// Is sword magic.
        /// </summary>
        private bool magic;
        public bool Magic
        {
            get { return magic; }
            set
            {
                magic = value;
                CalculateDamage();
            }
        }

        /// <summary>
        /// Damage delt with sword.
        /// </summary>
        public int Damage { get; private set; }

        /// <summary>
        /// Used to calculate damage. If sword is magic multiply roll by 1,75. If sword is flaming add FLAME+DAMAGE;
        /// </summary>
        public void CalculateDamage()
        {

            decimal magicMultiplier = 1;
            if (magic) magicMultiplier = 1.75m;
            Damage = (int)(Roll * magicMultiplier) + BASE_DAMAGE;
            if (flaming) Damage += FLAME_DAMAGE;
        }
    }
}
