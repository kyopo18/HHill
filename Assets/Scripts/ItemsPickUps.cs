using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ItemsPickUps : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void TatoNade()
    {
        // A Grenade that is an actual potato.
        // small blast radius used to clear groups of enemies.
        // faster rate of detonation than a potato masher. 3 seconds
        // round in shape.
        // extremely high rolling capability as in down the hill.
        // Heavier nades are more powerful but harder to throw.
        // Tatonade varies in size at random.
    }

    private void TatoMasher()
    {
        // similar to the Tatonade is different in shape longer in shape with a longer detonation time. 6 seconds.
        // can be thrown back at enemy if fast enough. 
        // can be used to disable armored units.
        // rolls around in an arc.
        // Heavier tatomashers are more powerful but harder to throw.
        // Tatomasher varies in size at random.
    }

    private void CallInFry()
    {
        // One fry called in from DriveThru used to devastate structures such as onion rings and obstacles like drink cups and damage enemies.likened to a missile attack
    }

    private void CallInFries()
    {
        // Volley of fries called in from The DriveThru used to destroy structures onion rings drink cups and enemies. likened to a volley of missiles.
    }

    private void PlasticDrinkLid()
    {
        // A pick up riot shield that stays on the character that deteriorates with damage.
        // Can be used as blunt melee weapon.
        // Can be combined with spoon, fork or spork to act as melee combo.
        // Used as a shield or weapon blunt force.
    }

    private void MetalDrinkLid()
    {
        // A pick up riot shield that stays on the character that deteriorates with damage.
        // Used as riot shield with high durability
        // Can be used as blunt melee weapon.
        // Can be combined with spoon, fork or spork to act as melee combo.
        // Used as a shield or weapon blunt force.
        // does not take up space in ruck sack.
    }

    private void Preservatives()
    {
        // MSG Increases Health
        // BananaPepper Boosts Morale
        // Salt Increases Flarmor (flavor armor) sometimes increases health a small portion.
        // Paprika does nothing ability wise and is used for aesthetic purposes and used to buy new weapons. Paprika is not collected in a rucksack. Paprika is stacked to buy in game aesthetics.
        // Paprika is the in game currency that the characters fight over. Paprika is called "P" for short.
        // in varying sizes
        // can be picked up and carried in a ruck sack.
        // SpicySeasoning : boosts morale and small health boost. 
    }

    private void GMOnionRingGMOR()
    {
        // Suceptible to melee attacks.
        // Suceptible to Tatonades and Potatomashers.
        // Can leave the bunker if explosive thrown in.
        // Fries kill on contact.
        // Considered a structure.
        // Deployable GMOR for one.
        // Ridiculously large enough to hold one soldier due to genetic modification for use as a bunker.
        // Instead of using as a bunker, roll it down the hill and let physics determine where it falls.
        // Acts as a static obstacle.
        // Acts as a moving obstacle.
        // Pushes with force to push back.
        // Causes injury to player and enemies.
        // When stationary Acts as a shield to sit in or stand behind
        // While bunkering in an onion ring increases the fire rate but character movement prevented only character view can change.
        // Can be a type that was fried for longer to increase crunch(durability) and roughness (protects against melee attacks. Roughness prevents entrance into.
        // Dug in mode is done with any type of [spoon]. fortifys the bunker increasing defense and fire rate. Makes getting out of tougher if grenade is thrown.
        // called GMOR
    }

    private void RegularOnionRing()
    {
        // Acts as a deployable obstacle similar to a Sandbag.
        // can be rolled vertically down the hill.
    }

    private void CrunchyOnionRing()
    {
        // A double fried Ring high in durability and roughness.
        // Roughness increases damage from the outside if thrown or flung.
        // can be rolled down the hill.
    }

    private void RecyclablePaper()
    {
        // Used to make spit balls. 1.5 seconds long duration to make.  thrown or spat to create blinding effect on enemies.
        // pulled from [obstacles] Drink cup, napkins, menus.
        // pulled from PlaceMat Dinner menu.
    }

    private void Spitball()
    {
        // Can be picked up does not count as [Rucksack] [slot].

        // Used as [ammo] for the straw of all types.
        // used to [blind] enemies temporarily.
        // If a [spit ball] misses, can be [picked up] by any [player] for use or carry in a rucksack spitball slot maximum 1 spitball.
        // A Spit ball that hits any player can not be used again.
        // If no straw available, a spit ball can be thrown instead.
        // causes a comical amount of insignificant damage neverthless damage caused.. Spitballs are used to taunt bad players.
        // when using a straw on a spit ball a sniper like effect is in the character view for greater accuracy.
    }

    private void NuggetSaucePackets()
    {
        // Sauces for chicken nuggets or consumption by the character as Flarmor.
        // Sauce packets can be opened and flung with a spoon or fork.
        // Types of sauce have differing effects.

        // Mayo : provides armor : flung to reduce mobility of enemies.

        // Mustard : provides armor : when flung causes extreme blindness and disorientation. (a take on mustard gas, can be used as a type of flashbang)

        // BBQ : provides armor on consumption : when combined with explosives or flame as a weapon causes extra damage and erodes armors.

        // Sweet and Sour : a consumable that helps increase health and armor slightly. Can be flung as a support item to teammates. If flung onto an enemy helps enemy but descreases enemy mobility.

        // An item to taunt enemies.

        // Honey Garlic : a consumable that helps increase morale and health largely. rare item.

        // Honey Mustard : causes larger increase in health on consumption but decreases mobility and visibility for a duration if consumed. flung for decreased mobility. and disorientation.
        // 
        // Hot sauce : increases morale dramatically and move speed and rate of fire when consumed but damages health and armor slightly on consumption.

        // Can be flung to create blindness and damage. corrodes enemy armors. in a splash.

        // Garlic : Morale booster : flung to reduce mobility.

        // Spicy Mayo : Morale boosting and armor boosting slight damage to health on consumption. when used on an enemy decreases movement and corrodes armor and health.

        // All sauces can and their effects can be combined to create new sauces under the player upgrades.

        // Individual Sauces take up 1 slot of space in the rucksack.


    }

    private void Nuggets()
    {
       // Sauces can be added to a chicken nugget and the effect of the sauce added to the nugget.
       // Nuggets are flung with spoon or fork.
       // All knives have no flinging capability.
       // dipped nuggets carry the effect of dipping fully.
       // nuggets that are dipped can be flung but shorter distances because of weight.
       // Acts as obstacle and blocks incoming fire or used as flung object.
       // attaching a spit ball to a nugget to a drink lid creates a stronger drink lid shield and blunt melee object. The nugget falls off after a few seconds and can be picked up again.
       // sauces can also attach nuggets to drink lid shields.
       // the effect of the sauce is added to the drink lid shield temporarily while the nugget is attached.
       // the duration of nuggets sticking is based on the viscosity of a sauce. spit is considered a sauce.
       // A sauced nugget can be picked up as a sauced item.
       // sauced items can not be resauced.
       // sauced items disintegrate if sauced twice.
       // Only sauces are combined in the player editor as abilities for future use.

    }

    private void Strips()
    {
        // Strips are nuggets with more damage when flung. Strips have awkward movement when used as projectiles making strips unpredicatble.
        // Strips are harder to fling.
    }

    private void Kimchi()
    {
        // Ultra rare item.....boosts everything but a little spicy. when consumed.
        // Can convert into a melee weapon with spiciness corrosion effects.
        // if used as condiment used as bravado.
        // can be flung for damage but not reccomended.
        // can be skewered by a melee weapon with poke (but not straws) and used as a stronger melee weapon
    }

    private void GrandmasKimChi()
    {
        //The rarest item in the entire game. GREATLY increases all buffs for a maximum duration. when consumed.
        // Can convert into a melee weapon with spiceness and corrosion effects.
        // can be condiment as well.
        // can be flung for damage but not reccomended.
        // can be skewered by a melee weapon with poke (but not straws) and used as a stronger melee weapon
    }

    private void Wasabi()
    {
        // Creates disorientation. Can be flung.
        // Increases paprika spawns.
    }


}
