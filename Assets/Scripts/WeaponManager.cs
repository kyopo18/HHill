using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;



//public class WeaponManager : MonoBehaviour

// Damage dealt by the weapon


//in the future straws can attach to melee weapons to create longer more effective weapons.
//{ 
// Damage dealt by the weapon 
//public float damage = 10f;


// Every character comes with a plastic fork.

// With enough Paprika the default plastic fork can be upgraded to a default Spork or fork and knife combo.
// A weapon is not an item for the rucksack.
// Two ranged weapons can be carried with enough seasoning.
// Two melee weapons can be carried with enough seasoning.
// A seasoned "meat" (veteran) can hold up to 2 small side arms called "sidedishes".
// Only two melee weapons can be carried. A drink lid counts as a melee weapon.


// Start is called before the first frame update
//void Start()
//{

//}

//// Update is called once per frame
//void Update()
//{

//}

//    private void PlasticFork()
//    { 


//        private bool hasBeenUsed = false;

//        // Method to use the weapon
//        public void UsedPlasticFork()
//        {
//            if (!hasBeenUsed)
//            {
//                // Perform actions when the weapon is used, such as dealing damage to a target
//                Debug.Log("Weapon used!");

//                // For example, you might add code here to damage an enemy
//                // Assuming there's an Enemy script with a TakeDamage method
//                // enemy.TakeDamage(damage);

//                // Mark the weapon as used
//                hasBeenUsed = true;

//                // Destroy the weapon object after use
//                Destroy(gameObject);
//            }
//            else
//            {
//                Debug.Log("Weapon has already been used and destroyed.");
//            }
//        }

//}


// Used as a short ranged melee weapon to poke with blind capability and stab with limited durability. The default melee weapon.
// can fling all onion rings.
// does not slice
// weak blunt force


//private void MetalFork()
//{       
//    // Used as a short ranged melee weapon to poke with blind capability and stab with limited durability. The default melee weapon of seasoned meats.
//        // can fling all onion rings.
//        // does not slice
//        // weak blunt force

//    // learn to rotate as an attack
//    // poke
//    // stab
//    // rotate
//    // stuck in enemy percent on chance
//}

//    //private void PlasticSpoon()
//    {
//        // Used as a melee weapon to pick up and throw enemies around or or hit with blunt force. Limited durability. 1 use
//        // Used to dig in while in an GMOnionRing. Creates a Dug in bunker. 3 seconds to dig in.
//        // can fling all onion rings.
//        // does not slice
//        // weak blunt force but more force than forks.
//    }

//    //private void MetalSpoon()
//    {
//        // Used as a melee weapon to pick up and throw enemies around or or hit with blunt force. max durability. 3 uses
//        // Used to dig in while in an GMOnionRing. Creates a Dug in bunker. 3 seconds to dig in.
//        // can fling all onion rings.
//        // does not slice
//        // weak blunt force but more force than forks.
//    }

//    //private void PlasticButterKnife()
//    {
//        // By itself the plastic knife can be used for sawing and weak blunt force attack
//        // In use with a PlasticFork and PlasticKnife it can act as a defensive barrier while moving.
//        // In use with a PlasticFork and PlatsticKnife can be used to melee combo enemies.
//        // can not fling onion rings 
//        // can saw onion rings.
//        // slices weakly.
//    }

//    private void MetalButterKnife()
//    {
//        // Used for sawing enemies into two
//        // Used to melee cut enemies.
//        // Very rare.
//        // can poke and blind with max blind durations.
//        // can be combined with a fork other knife or drink lid to combo enemies.
//        // Despite appearance can be damaged with use.
//        // Highest durability.
//        // Can saw onion rings.
//        // slices
//    }

//    //private void SteakKnife()
//    {
//        // Legendary Melee Weapon with 5 uses.
//        // Extremely rare
//        // Almost mythical 
//        // Only one steak knife can be carried at any time.
//        // can saw onion rings.
//        // pokes
//        // stabs
//        // slices
//        // saws
//    }

//    //private void PlasticSpork()
//    {
//        // Lower Durability     1 uses
//        // Used as a melee weapon.
//        // For blunt force
//        // For stabbing
//        // For Digging
//        // For Throwing
//        // For item scooping
//    }

//    //private void MetalSpork()
//    {
//        // High Durability 3 uses
//        // Used as a melee weapon.
//        // For blunt force
//        // For stabbing
//        // For Digging
//        // For Throwing
//        // Item scooping. scoop an item from a distance.
//    }

//    //private void PaperStraw()
//    {
//        // long ranged weak melee weapon with small damage value with low durability. Can [poke] or be used as a blunt weapon. Destroyed on 1 use.
//        // Used to poke eyes to blind characters. A poked character is a blinded character.
//        // Type of straw determines length of blind.
//        // can not be combined as combo melee item.
//    }

//    //private void PlasticStraw()
//    {
//        // long ranged medium strength melee weapon with medium damage value and longer durability. Can poke or be used as a blunt weapon. Destroyed on 2 uses.
//        // Can use to fire a spit ball. Spit balls blind enemies for a brief moment.
//        // Used to poke eyes to blind characters. A poked character is a blinded character.
//        // Type of straw determines length of blind. increased blind stat.
//        // can not be combined as comboed melee item.
//    }

//    //private void MetalStraw()
//    {
//        // long ranged maximum strength melee weapon with full damgate value and longest durability. Can poke or be used as a blunt weapon. Destroyed on 3 uses.
//        // can be used to deflect bullets if seasoned veteran skill is high enough.
//        // despite seeming to be indestructible is destructible with enough uses.
//        // Used to poke eyes to blind characters. A poked character is a blinded character.
//        // maximum blind stat.
//        // can not be combined as combo melee item.
//    }

//    //private void TatoNade()
//    {
//        // A Grenade that is an actual potato.
//        // small blast radius used to clear groups of enemies.
//        // faster rate of detonation than a potato masher. 3 seconds
//        // round in shape.
//        // extremely high rolling capability as in down the hill.
//        // Heavier nades are more powerful but harder to throw.
//        // Tatonade varies in size at random.
//        // Explosives [rip apart] characters and obstacles.
//        // Explostive object.
//    }

//    //private void TatoMasher()
//    {
//        // similar to the Tatonade is different in shape longer in shape with a longer detonation time. 6 seconds.
//        // can be thrown back at enemy if fast enough. 
//        // can be used to disable armored units.
//        // rolls around in an arc.
//        // Heavier tatomashers are more powerful but harder to throw.
//        // Tatomasher varies in size at random.
//        // Explosives [rip apart] characters and obstacles.
//        // Explosive object.
//    }

//    private void FlameThrower()
//    {
//        // A flamethrower with [grilling], [burning], [basting] and [searing] effects.
//        // combined with flung bbq sauce on enemy adds extra baste damage. sauce must be used to baste an enemy. different sauces baste differently.
//        // basting causes permanent blindness till player eliminated.
//        // searing causes permanent damage to armor bar and health bar stats permanently based on searing level in one action till character eliminated..
//        // grilling reduces health and armor over time for short duration of time causing permanent damage to health and armor not as bas as searing.
//        // anything metal spoon fork spork chopstick can be heated by a flamethrower. the hot melee weapon can be used to sear an enemy.
//    }

//    private void Chopsticks()
//    {
//        // All purpose melee weapon can skewer kimchi and be used as the ultimate melee weapon next to steak knife.
//        // can be combined with another chopstick for melee combos
//        // plastic, wood or metal
//    }

// private void ToothPick()
//{
////A wooden Toothpick that can be thrown or used once, mainly used for throwing..
//}


//}
