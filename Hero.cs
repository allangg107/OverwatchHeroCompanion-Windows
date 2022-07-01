using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overwatch_Companion_2._0.Assets
{
    public class Hero
    {
        public int HeroId { get; set; }
        public string HeroName { get; set; }
        public string HeroImage { get; set; }
        public string HeroSmallerImage { get; set; }
        public int HeroDifficulty { get; set; }
        public string HeroStrengths { get; set; }
        public string HeroWeaknesses { get; set; }
        public string HeroHealthArmorShield { get; set; }
        public string HeroLeftClickDamage { get; set; }
        public string HeroRightClickDamage { get; set; }
        public string HeroSpeed { get; set; }
        public string HeroPassiveName { get; set; }
        public string HeroAbility1Name { get; set; }
        public string HeroAbility2Name { get; set; }
        public string HeroUltimateName { get; set; }
        public string HeroPassive { get; set; }
        public string HeroAbility1 { get; set; }
        public string HeroAbility2 { get; set; }
        public string HeroUltimate { get; set; }
        public string HeroTipsAndTricks { get; set; }
        public string HeroClass { get; set; }

    }

    public class HeroManager
    {
        public static List<Hero> GetHeroes()
        {
            var heroes = new List<Hero>();

            //ANA
            heroes.Add(new Hero
            {
                HeroId = 1, 
                HeroName = "Ana",
                HeroImage = "Assets/Ana_portrait.png", 
                HeroSmallerImage = "Assets/Ana_smallerportrait.png",
                HeroDifficulty = 3, 
                HeroStrengths = "Long ranged healing", 
                HeroWeaknesses = "Low damage",
                HeroHealthArmorShield = "200 Health",
                HeroLeftClickDamage = "Ana’s rifle shoots darts that can restore 75 health to her allies or deal 70 damage to her enemies. 1.25 shots per second. 14 rounds. 1.5 second reload. 90 m/s projectile. Can't headshot.",
                HeroRightClickDamage = "Ana zooms in taking 0.25 seconds and zooming out in 0.15 seconds. Shots are hitscan. 1.9 m/s movement speed. Can't headshot.", 
                HeroSpeed = "5.5 meters per second", 
                HeroPassiveName = "None",
                HeroPassive = "", 
                HeroAbility1Name = "Sleep Dart",
                HeroAbility1 = "Ana fires a dart dealing 5 damage, rendering an enemy unconscious for 6 seconds or until they take damage. 0.5 second cast. 12 second cooldown.",
                HeroAbility2Name = "Biotic Grenade",
                HeroAbility2 = "Ana throws a grenade dealing 60 damage to enemies and healing 100 health to allies in a 4 meter area of effect. Affected allies will receive 50% increased healing and enemies have healing disabled for 4 seconds. 10 second cooldown.",
                HeroUltimateName = "Nano Boost",
                HeroUltimate = "Ana hits one of her allies within 40 meters with a combat boost. They recover 250 health, move 30% faster, deal 50% more damage, and take 50% less damage for 8 seconds. 0.15 second cast.",
                HeroTipsAndTricks = "Stay in the back to heal your allies and shoot enemies. Interupt enemy ultimates with Sleep Dart.",
                HeroClass = "support"
            });

            //NEW
            //ASHE
            heroes.Add(new Hero
            {
                HeroId = 2,
                HeroName = "Ashe",
                HeroImage = "Assets/Ashe_portrait.png",
                HeroSmallerImage = "Assets/Ashe_smallerportrait.png",
                HeroDifficulty = 2,
                HeroStrengths = "High damage",
                HeroWeaknesses = "Low mobility",
                HeroHealthArmorShield = "200 Health",
                HeroLeftClickDamage = "Ashe's semi-automatic rifle fires 4 shots per second dealing 40 damage per shot. 12 rounds. 20 meter falloff for 50% damage. 0.5 seconds initial plus 0.3 seconds reload per bullet.",
                HeroRightClickDamage = "Ashe aims down sights and shoots dealing 85 damage. 1.42 shots per second. 30 meter falloff.",
                HeroSpeed = "5.5 meters per second",
                HeroPassiveName = "None",
                HeroPassive = "",
                HeroAbility1Name = "Dynamite",
                HeroAbility1 = "Ashe throws an explosive that detonates after a short delay or immediately when shot. The explosion from Dynamite deals 30 - 75 damage in a 5 meter radius and burns enemies for 100 damage over 5 seconds. 50% self damage. 2 second cast. 10 second cooldown.",
                HeroAbility2Name = "Coach Gun",
                HeroAbility2 = "Ashe blasts enemies in front of her with 15 bullets dealing 6 damage per bullet, knocking them away and propelling herself backward for added mobility. 10 second cooldown. Can't headshot.",
                HeroUltimateName = "B.O.B",
                HeroUltimate = "Ashe summons her trusted omnic sidekick, B.O.B., who charges forward up to 65 meters and knocks enemies into the air dealing 120 damage, then lays down suppressing fire with his arm cannons dealing 112 damage per second. Arm cannon range of 40 meters. Duration 1200 health or 10 seconds after collision.",
                HeroTipsAndTricks = "",
                HeroClass = "damage"
            });

            //NEW
            //BAPTISTE
            heroes.Add(new Hero
            {
                HeroId = 3,
                HeroName = "Baptiste",
                HeroImage = "Assets/Baptiste_portrait.png",
                HeroSmallerImage = "Assets/Baptiste_smallerportrait.png",
                HeroDifficulty = 3,
                HeroStrengths = "Strong healing and team utility",
                HeroWeaknesses = "Will be targeted",
                HeroHealthArmorShield = "200 health",
                HeroLeftClickDamage = "Baptiste’s three-round-burst Biotic Launcher deals 12.5 damage per bullet. Shooting 3 round per second with a 0.35 sceond cooldown. 45 rounds. 1.5 second reload. Hitscan.",
                HeroRightClickDamage = "Baptiste's Biotic launcher also doubles as a healing device, lobbing projectiles that heal for 60 points in a 3 meter radius. Shooting 1.25 shots per second. 10 rounds. 1.5 second reload. Does not self heal.",
                HeroSpeed = "5.5 meters per second",
                HeroPassiveName = "Exo Boots",
                HeroPassive = "Baptist can jump higher after crouching for 1 second.",
                HeroAbility1Name = "Regenerative Burst",
                HeroAbility1 = "Baptiste activates an intense regenerative burst that heals himself and nearby allies for 30 points per second for 5 seconds. 10 meter radius. 0.3 second cast. 15 second cooldown.",
                HeroAbility2Name = "Immortality Field",
                HeroAbility2 = "Baptiste places a generator which projects a 6 meter radius shield with 250 health for 8 sceonds. Allies in the radius restored to 20% of their hp and can't drop below 20% of their hp. 1 second cast time. 20 second cooldown.",
                HeroUltimateName = "Amplification Matrix",
                HeroUltimate = "Baptiste creates a 5 meters wide, 4 meters tall matrix within 30 meters that doubles the damage and healing effects of friendly projectiles that pass through it. Lasts 8 seconds.",
                HeroTipsAndTricks = "Use exo boots in fights against non-hitscan enemies.",
                HeroClass = "support"
            });

            //BASTION
            heroes.Add(new Hero
            {
                HeroId = 4, 
                HeroName = "Bastion",
                HeroImage = "Assets/Bastion_portrait.png", 
                HeroSmallerImage = "Assets/Bastion_smallerportrait.png",
                HeroDifficulty = 1, 
                HeroStrengths = "Deals lots of damage", 
                HeroWeaknesses = "Stationary when in Sentry mode", 
                HeroHealthArmorShield = "200 Health, 100 Armor",
                HeroLeftClickDamage = "In Recon mode, Bastion is fully mobile, outfitted with a submachine gun that fires 8 bullets per second dealing 6-20 damage per shot over 25 - 45 meters. 35 rounds. 1.5 second reload. / In Sentry mode, Bastion is a stationary powerhouse equipped with a gatling gun firing 30 bullet per second dealing 7.5 - 15 damage per shot over 35 - 55 meters. 300 rounds. 2 second reload.",
                HeroRightClickDamage = "Bastion performs Self-Repair healing 75 health per second for 4.3 seconds. 7 second cooldown.", 
                HeroSpeed = "5.5 meters per second",
                HeroPassiveName = "Ironclad", 
                HeroPassive = "Bastion's recieves +20% damage resistance while transformed.",
                HeroAbility1Name = "Reconfigure",
                HeroAbility1 = "Bastion transforms between Recon and Sentry mode. It takes 1 second to transform into sentry and 0.5 seconds into recon. Reloads your weapon. 0 second cooldown.",
                HeroAbility2Name = "None",
                HeroAbility2 = "",
                HeroUltimateName = "Configuration: Tank",
                HeroUltimate = "Bastion takes 1.5 seconds transforming into a tank. Bastion can fire explosive shells at 44 m/s every second dealing 205 damage for direct hits and 70-145 damage in a 4 meter radius. Tank lasts for 8 seconds. While in tank mode, Bastion is immune to knockback.",
                HeroTipsAndTricks = "Keep moving to different locations so enemies don't easily take you out.",
                HeroClass = "damage"
            });

            //NEW
            //BRIGITTE
            heroes.Add(new Hero
            {
                HeroId = 5,
                HeroName = "Brigitte",
                HeroImage = "Assets/Brigitte_portrait.png",
                HeroSmallerImage = "Assets/Brigitte_smallerportrait.png",
                HeroDifficulty = 1,
                HeroStrengths = "Good at protecting important allies",
                HeroWeaknesses = "Weak when isolated",
                HeroHealthArmorShield = "200 Health, 50 Armor",
                HeroLeftClickDamage = "Brigitte’s melee weapon has an extended range of 6 meters, enabling her to strike multiple enemies with a single swing dealing 35 damage. 2 swings per second.",
                HeroRightClickDamage = "Brigitte deploys a frontal energy barrier to absorb 500 points of damage. -30% movement speed (3.85 m/s). Shield regens 100 hp per second. 3 second cooldown if destroyed.",
                HeroSpeed = "5.5 meters per second",
                HeroPassiveName = "Inspire",
                HeroPassive = "When Brigitte strikes an enemy with her flail, all allies within 20 meters are healed for 16.67 health per second for 6 seconds. 1 second cooldown.",
                HeroAbility1Name = "Sheild Bash + Whip Shot",
                HeroAbility1 = "Once her Barrier Shield is deployed, Brigitte can dash forward 6.8 meters to stun an enemy for 1 second and deal 5 points of damage. 7 second cooldown. / Brigitte throws her flail 20 meters, dealing 70 damage and knocking an enemy away from her. 40 m/s projectile speed. 4 second cooldown.",
                HeroAbility2Name = "Repair Pack",
                HeroAbility2 = "Brigitte throws a Repair Pack that can heal an ally for 150 hp. Any healing over that ally’s maximum health provides them with armor instead. 30 m/s projectile speed. 30 meter range. 5 second duration. 6 second cooldown.",
                HeroUltimateName = "Rally",
                HeroUltimate = "Brigitte moves 30% faster (7 m/s) and provides allies with 30 armor per second until a maximum of 150. Speed buff lasts 10 seconds while Armor lasts for 30.",
                HeroTipsAndTricks = "Protect vulnerable allies.",
                HeroClass = "support"
            });

            //D.VA
            heroes.Add(new Hero
            {
                HeroId = 6, 
                HeroName = "D.Va",
                HeroImage = "Assets/Dva_portrait.png", 
                HeroSmallerImage = "Assets/Dva_smallerportrait.png",
                HeroDifficulty = 2, 
                HeroStrengths = "Good Mobility", 
                HeroWeaknesses = "Low Range",
                HeroHealthArmorShield = "Mech: 400 Health, 200 Armor, Hero: 150 Health",
                HeroLeftClickDamage = "D.Va's mech shoots 11 pellets per shot dealing 0.6 - 2 damage per pellet over 10 - 20 meters. 6.67 shots per second. Unlimited rounds. 2.75 m/s movement speed. / While outside of her mech, D.Va can continue the fight with a mid-range automatic blaster that fires 7 rounds per second and dealing 14 damage per shot. ",
                HeroRightClickDamage = "D.Va projects a 15 meter forward facing defense matrix which blocks incoming projectiles for 2 seconds. 2 second cooldown. 8 second recharge.", 
                HeroSpeed = "5.5 meters per second", 
                HeroPassiveName = "Eject",
                HeroPassive = "D.Va takes 1 second to eject out of her mech when destroyed.", 
                HeroAbility1Name = "Boosters",
                HeroAbility1 = "D.Va’s mech booster allow her to move in any direction at 12.5 m/s for 2 seconds. Running through enemies deals 10 damage and knocks them back. 5 second cooldown.",
                HeroAbility2Name = "Micro Missiles",
                HeroAbility2 = "D.Va fires 11 missiles per second for 1.6 seconds dealing 7 damage for direct hits and 4 damage within 1.5 meters. 0.5 second cast. 8 second cooldown.",
                HeroUltimateName = "Self-Destruct / Call Mech",
                HeroUltimate = "D.Va ejects from her mech and sets its reactor to explode in 3 seconds, dealing 0 - 1000 damage within 20 meters. / If her mech is destroyed, D.Va can call down a new mech dealing 50 damage to enemies.",
                HeroTipsAndTricks = "Disrupt the enemy, go behind enemy lines.",
                HeroClass = "tank"
            });

            //NEW
            //DOOMFIST
            heroes.Add(new Hero
            {
                HeroId = 7,
                HeroName = "Doomfist",
                HeroImage = "Assets/Doomfist_portrait.png",
                HeroSmallerImage = "Assets/Doomfist_smallerportrait.png",
                HeroDifficulty = 3,
                HeroStrengths = "Good at taking hits and disrupting enemy movement",
                HeroWeaknesses = "No long range damage",
                HeroHealthArmorShield = "250 Health",
                HeroLeftClickDamage = "Doomfist fires a short-range burst of pellets from the knuckles of his fist dealing 11 damage per pellot. Its ammunition is automatically regenerated over a short time. 4 rounds. 3 shots per second. 0.75 seconds per missing round.",
                HeroRightClickDamage = "After charging up for 1 second, Doomfist lunges forward 6.5 - 20 meters and knocks an enemy back dealing 49 - 100 damage, and dealing additional an additional 50 damage if they impact a wall.",
                HeroSpeed = "5.5 meters per second",
                HeroPassiveName = "The Best Defense...",
                HeroPassive = "Doomfist generates +35 shield per enemy damaged with basic abilities (+75 for ultimate) until a maximum of 150 shields. Shields start to decay after 1 second at 3 shields per second.",
                HeroAbility1Name = "Rising Uppercut",
                HeroAbility1 = "Doomfist uppercuts enemies in front of him into the air dealing 50 damage within a 5 meter radius. 7 second cooldown.",
                HeroAbility2Name = "Seismic Slam",
                HeroAbility2 = "Doomfist leaps forward and smashes into the ground, knocking nearby enemies toward him and dealing 49 - 125 damage withing 8 - 15 meters (depending on height). 6 second cooldown.",
                HeroUltimateName = "Meteor Strike",
                HeroUltimate = "Doomfist leaps into the sky, then crashes to the ground, dealing 300 damage within 2 meters and 20 - 200 damage within 6 meters. 1 second cast. 4 second duration.",
                HeroTipsAndTricks = "Use Rocket Punch to interrupt ultimates or other abilities.",
                HeroClass = "damage"
            });

            //NEW
            //ECHO
            heroes.Add(new Hero
            {
                HeroId = 8,
                HeroName = "Echo",
                HeroImage = "Assets/Echo_portrait.png",
                HeroSmallerImage = "Assets/Echo_smallerportrait.png",
                HeroDifficulty = 2,
                HeroStrengths = "Good at catching and finishing off enemies",
                HeroWeaknesses = "Vulnerable to poor positioning with flight",
                HeroHealthArmorShield = "200 Health",
                HeroLeftClickDamage = "Echo fires 3 shots at once dealing 17 damage per shot. Shooting 3 shots per second. 75 m/s projectile speed. 15 ammo. 1.5 second reload. ",
                HeroRightClickDamage = "Echo fires a 6 sticky bombs that detonate after 1 second dealing 5 damage on impact and 25 damage in a 2 meter radius. Shoots 1 bomb every 0.065 seconds. 50 m/s projectile speed. 6 second cooldown. . ",
                HeroSpeed = "5.5 m/s",
                HeroPassiveName = "Glide",
                HeroPassive = "Echo glides falling at 4 m/s",
                HeroAbility1Name = "Flight",
                HeroAbility1 = "Echo surges forward at 8 m/s, then can fly freely for a short duration. 3 second duration. 6 second cooldown.",
                HeroAbility2Name = "Focusing Beam",
                HeroAbility2 = "Echo channels a beam for 2.5 seconds, dealing 50 damage or 200 damage to targets with less than half health.",
                HeroUltimateName = "Duplicate",
                HeroUltimate = "Echo duplicates a targeted enemy hero within 40 meters and gains use of their abilities for 15 seconds. 0.35 second cast. 1 second recovery.",
                HeroTipsAndTricks = "Understand how to play other heroes to get maximum value from your ultimate.",
                HeroClass = "damage"
            });

            //GENJI
            heroes.Add(new Hero
            {
                HeroId = 9, 
                HeroName = "Genji",
                HeroImage = "Assets/Genji_portrait.png", 
                HeroSmallerImage = "Assets/Genji_smallerportrait.png",
                HeroDifficulty = 3, 
                HeroStrengths = "High Mobility", 
                HeroWeaknesses = "Beam attacks (can't deflect them)",
                HeroHealthArmorShield = "200 Health",
                HeroLeftClickDamage = "Genji throws three shurikens each dealing 28 damage. 24 rounds. 1.5 second reload.",
                HeroRightClickDamage = "Genji throws three shuriken in a wider spread. 1.33 shots per second.",
                HeroSpeed = "6 meters per second", 
                HeroPassiveName = "Cyber-Agility",
                HeroPassive = "Genji can climb walls and perform jumps in mid-air.",
                HeroAbility1Name = "Swift Strike",
                HeroAbility1 = "Genji darts 15 meters forward dealing 50 damage to enemies. If Genji eliminates a target, he can instantly use this ability again. 8 second cooldown.",
                HeroAbility2Name = "Deflect",
                HeroAbility2 = "Genji reflects an oncoming projectiles and sends them back to the enemy for 2 seconds. 8 second cooldown.",
                HeroUltimateName = "Dragonblade",
                HeroUltimate = "Genji brandishes his katana for 6 seconds. Genji can deliver 120 damage strikes to all targets within his 5 meter reach. Genji's speed increases to 8 meters per second.",
                HeroTipsAndTricks = "Use your mobility, try to be unpredictable while shooting at your enemy.",
                HeroClass = "damage"
            });

            //HANZO
            heroes.Add(new Hero
            {
                HeroId = 10, 
                HeroName = "Hanzo",
                HeroImage = "Assets/Hanzo_portrait.png",
                HeroSmallerImage = "Assets/Hanzo_smallerportrait.png",
                HeroDifficulty = 3, 
                HeroStrengths = "Can 1 Shot Most Heroes.", 
                HeroWeaknesses = "Hard to hit arrows.",
                HeroHealthArmorShield = "200 Health",
                HeroLeftClickDamage = "Hanzo nocks and fires an arrow at his target dealing 29-125 damage per shot. 26 - 100 m/s projectile speed. 3.85 m/s movement speed. Stats depended on charge duration. 0.75 seconds until max charge. 0.5 seconds buffer.",
                HeroRightClickDamage = "NA", 
                HeroSpeed = "5.5 meters per second", 
                HeroPassiveName = "Wall Climb + Lunge",
                HeroPassive = "Jump at walls to climb at them. Hanzo can double jump going 7.5 meters. 5 second cooldown.", 
                HeroAbility1Name = "Storm Arrow",
                HeroAbility1 = "Hanzo revieces 6 storm arrows for 5 seconds which deal 70 damage each. He can fire 1 arrow every 0.3 seconds. 10 second cooldown.",
                HeroAbility2Name = "Sonic Arrow",
                HeroAbility2 = "Hanzo launches an arrow that contains a sonar tracking device. Any enemy within 10 meters is revealed. 12 second cooldown.",
                HeroUltimateName = "Dragonstrike",
                HeroUltimate = "Hanzo summons a Spirit Dragon which travels through the air in a line. It passes through walls in its way, dealing 200 damage per second to all enemies it encounters. 4 meter radius. Global range. 1.5 second cast.",
                HeroTipsAndTricks = "Stay in the back of your team and shoot arrows. Focus on important targets like supports.",
                HeroClass = "damage"
            });

            //JUNKRAT
            heroes.Add(new Hero
            {
                HeroId = 11, 
                HeroName = "Junkrat",
                HeroImage = "Assets/Junkrat_portrait.png", 
                HeroSmallerImage = "Assets/Junkrat_smallerportrait.png",
                HeroDifficulty = 2, 
                HeroStrengths = "Area Damage", 
                HeroWeaknesses = "Hard to hit his auto attacks",
                HeroHealthArmorShield = "200 Health",
                HeroLeftClickDamage = "Junkrat's Frag Launcher lobs grenades exploding on their 3rd bounce or when they hit a character dealing 130 damage on direct hits and 12.5 - 80 damage to all enemies in a 2 meter radius. 5 rounds. 1.55 second reload. 25 m/s projectile speed. 1.66 rounds per second. Knocksback enemies and junkrat.",
                HeroRightClickDamage = "Triggers Concussion Mine", 
                HeroSpeed = "5.5 meters per second", 
                HeroPassiveName = "Total Mayhem",
                HeroPassive = "Junkrat's deranged sense of humor persists past his death. If killed, he drops 6 live grenades which each deal 50 damage each within 2 meters. ",
                HeroAbility1Name = "Concussion Mine",
                HeroAbility1 = "Junkrat throws a mine which he can trigger dealing 120 damage to enemies within 3 meters and sending them flying. Can also be used to propel junkrat through the air. 2 rounds. 17.5 m/s projectile speed. 8 second cooldown.",
                HeroAbility2Name = "Steel Trap",
                HeroAbility2 = "Junkrat tosses out a giant, metal-toothed trap. Should an enemy wander within 1 meter of the trap, it clamps on, dealing 80 damage, stunning for 1 second and rooting for another 3 seconds. 10 second cooldown. Traps have 100HP and can be destroyed.",
                HeroUltimateName = "RIP-Tire",
                HeroUltimate = "Junkrat revs up a motorized tire bomb and sends it rolling across the battlefield, climbing over walls and obstacles. He can remotely detonate the RIP-Tire or wait 10 seconds to deal 60-600 damage to enemies caught in within 10 meters of the blast, or just wait for it to explode on its own. 1 second cast.",
                HeroTipsAndTricks = "Stay in the back shooting grenades and dealing damage. Concussion Mine can be used to move around faster. You are vulnerable while using RIP-Tire, so use it from a safe place.",
                HeroClass = "damage"
            });

            //LUCIO
            heroes.Add(new Hero
            {
                HeroId = 12, 
                HeroName = "Lucio",
                HeroImage = "Assets/Lucio_portrait.png", 
                HeroSmallerImage = "Assets/Lucio_smallerportrait.png",
                HeroDifficulty = 1, 
                HeroStrengths = "Area Effect, Healing, Speed Boost", 
                HeroWeaknesses = "Focused often, Hard to hit auto attacks",
                HeroHealthArmorShield = "200 Health",
                HeroLeftClickDamage = "Lúcio can hit his enemies with sonic projectiles dealing 20 damage per projectile. 20 rounds. 1.5 second reload. 0.52 seconds per shot. ",
                HeroRightClickDamage = "Lúcio can knock his enemies back within 8 meters dealing 25 damage with a blast of sound. 4 second cooldown.",
                HeroSpeed = "5.5 meters per second", 
                HeroPassiveName = "Wall Run", 
                HeroPassive = "Jump onto a wall to ride along it. Has +40% movement speed while wall riding.",
                HeroAbility1Name = "Crossfade",
                HeroAbility1 = "Lúcio continuously energizes himself — and teammates within 12 meters — with music. He can switch between two songs: one amplifies movement speed by 20%, while the other regenerates 16.25 (13 self) health per second. 0.8 second buffer.",
                HeroAbility2Name = "Amp It Up",
                HeroAbility2 = "Lúcio increases the volume on his speakers, boosting the effects of his songs for 3 seconds. Increases the healing done to 46.8 (35 self) health per second and the speed to 50%. 12 second cooldown.",
                HeroUltimateName = "Sound Barrier",
                HeroUltimate = "Protective waves radiate out from Lúcio’s Sonic Amplifier, providing him and allies within 30 meters with 750 health shields for 6.25 seconds. 0.8 second cast.",
                HeroTipsAndTricks = "Stay with your team and use your ultimate when pushing or getting pushed.",
                HeroClass = "support"
            });

            //MCCREE
            heroes.Add(new Hero
            {
                HeroId = 13, 
                HeroName = "McCree",
                HeroImage = "Assets/Mccree_portrait.png", 
                HeroSmallerImage = "Assets/Mccree_smallerportrait.png",
                HeroDifficulty = 2, 
                HeroStrengths = "High Burst Damage", 
                HeroWeaknesses = "Weak at long range",
                HeroHealthArmorShield = "200 Health",
                HeroLeftClickDamage = "McCree fires off a round dealing 20-70 damage over 20 - 40 meters. 6 rounds. 1.5 second reload. 2 shots per second.",
                HeroRightClickDamage = "McCree can fan the Peacekeeper’s hammer dealing 25-50 damage per shot to swiftly unload the entire cylinder. .11 seconds per shot. 0.3 second charge. Can't headshot.",
                HeroSpeed = "5.5 meters per second",  
                HeroPassiveName = "None", 
                HeroPassive = "",
                HeroAbility1Name = "Combat Roll",
                HeroAbility1 = "McCree dives 6 meters in the direction he’s moving, effortlessly reloading his Peacekeeper in the process. 6 second cooldown.",
                HeroAbility2Name = "Flashbang",
                HeroAbility2 = "McCree heaves a blinding grenade that explodes after 7 meters. The blast stuns enemies for 0.8 seconds in a 3 meter radius and dealing 25 damage. 0.35 second cast. 10 second cooldown.",
                HeroUltimateName = "Deadeye",
                HeroUltimate = "McCree takes a few precious moments to aim dealing 100-550 damage after aiming for a maximum of 6 seconds; when he’s ready to fire, he shoots every enemy in his line of sight. The weaker his targets are, the faster he’ll line up a killshot. 0.2 second cast. 2 m/s movement speed. ",
                HeroTipsAndTricks = "Pick off enemies trying to flank your team.",
                HeroClass = "damage"
            });

            //MEI
            heroes.Add(new Hero
            {
                HeroId = 14, 
                HeroName = "Mei",
                HeroImage = "Assets/Mei_portrait.png", 
                HeroSmallerImage = "Assets/Mei_smallerportrait.png",
                HeroDifficulty = 2,
                HeroStrengths = "Can freeze enemies, Can temporarily wall of areas", 
                HeroWeaknesses = "Hard to freeze multiple people",
                HeroHealthArmorShield = "250 Health",
                HeroLeftClickDamage = "Mei’s blaster unleashes a concentrated, short-range 10 meter stream of frost that deals 55 damage per second, slows, and ultimately freezes enemies in place after 1.5 seconds. 200 rounds. 20 shots per second. 1.5 second reload. 20 m/s projectile speed.",
                HeroRightClickDamage = "Mei can also use her blaster to shoot icicle-like projectiles dealing 75 damage. Uses 20 rounds per shot. 0.38 second cast. 1.25 shots per second. 120 m/s projectile speed.",
                HeroSpeed = "5.5 meters per second", 
                HeroPassiveName = "None", 
                HeroPassive = "",
                HeroAbility1Name = "Cyro-Freeze",
                HeroAbility1 = "Mei instantly surrounds herself with a block of thick ice. She heals 37.5 health per second for 4 seconds and ignores damage while encased, but cannot move or use abilities. 12 second cooldown.",
                HeroAbility2Name = "Ice Wall",
                HeroAbility2 = "Mei generates an enormous ice wall at a maximum of 35 meters away that obstructs lines of sight, stops movement, and blocks attacks for 5 seconds. 5 wall segments. Each wall segment has 400 health. 10 second cooldown.",
                HeroUltimateName = "Blizzard",
                HeroUltimate = "Mei deploys a weather-modification drone that emits gusts of wind and snow in a 10 meter area for 5 seconds. Enemies caught in the blizzard are slowed and take 20 damage per second over the full duration; those who linger too long are frozen solid. 1.5 second cast.",
                HeroTipsAndTricks = "Protect teamates with ice wall and use your ultimate in combination with your team.",
                HeroClass = "damage"
            });

            //MERCY
            heroes.Add(new Hero
            {
                HeroId = 15, 
                HeroName = "Mercy",
                HeroImage = "Assets/Mercy_portrait.png", 
                HeroSmallerImage = "Assets/Mercy_smallerportrait.png",
                HeroDifficulty = 2,
                HeroStrengths = "Can revive dead allies for a surprise attack",
                HeroWeaknesses = "She is easily targeted",
                HeroHealthArmorShield = "200 Health",
                HeroLeftClickDamage = "Mercy maintains a beam healing an ally 50 (60 while ulting) health per second within 15 meters (range of 30 and radius of 10 meters while ulting). Lasts for 1.4 seconds after losing line of sight. Mercy can also use her Caduceus Blaster dealing 20 damage per shot shooting at 40 m/s (100 while ulting and unlimited ammo). 5 shots per second.",
                HeroRightClickDamage = "Increases damage of an ally by 30% within 15 meters (range of 30 and radius of 10 meters while ulting). Lasts for 2 seconds after losing line of sight.",
                HeroSpeed = "5.5 meters per second", 
                HeroPassiveName = "Angelic Descent + Regeneration",
                HeroPassive = "Mercy can slow the speed of her descent. Mercy also heals 20 health per second after not being damaged for 1 seconds.",
                HeroAbility1Name = "Guardian Angel",
                HeroAbility1 = "Mercy flies towards a targeted ally at 20 m/s for a maximum 30 meter distance. 1.5 second cooldown.",
                HeroAbility2Name = "Resurrect",
                HeroAbility2 = "Mercy brings dead allies within 5 meters back into the fight with full health. 1.75 second cast. 1.375 m/s movement speed. 30 second cooldown.",
                HeroUltimateName = "Valkyrie",
                HeroUltimate = "Valkyrie enhances all of Mercy's abilities and increases her movement speed to 9 m/s for 15 seconds.",
                HeroTipsAndTricks = "Support your team and play safe knowing enemies will target you.",
                HeroClass = "support"
            });

            //NEW
            //MOIRA
            heroes.Add(new Hero
            {
                HeroId = 16,
                HeroName = "Moira",
                HeroImage = "Assets/Moira_portrait.png",
                HeroSmallerImage = "Assets/Moira_smallerportrait.png",
                HeroDifficulty = 2,
                HeroStrengths = "Flexibility in dealing with different situations",
                HeroWeaknesses = "Dies easily in 1v1",
                HeroHealthArmorShield = "200 Health",
                HeroLeftClickDamage = "Using her left hand, Moira expends biotic energy to heal allies in front of her for 80 hp over 4 seconds. 30 m/s projectile speed. 15 meter range. 0.3 second cast. Duration up to 9 seconds.",
                HeroRightClickDamage = "Her right hand fires a 20 meter range beam weapon that saps enemies’ health dealing 50 damage per second and healing Moira 33 health per second. Replenishes her biotic energy.",
                HeroSpeed = "5.5 meters per second",
                HeroPassiveName = "None",
                HeroPassive = "",
                HeroAbility1Name = "Fade",
                HeroAbility1 = "Disappear, move 18.75 m/s, and become invulnerable, but you cannot shoot. Lasts 0.8 seconds. 6 second cooldown.",
                HeroAbility2Name = "Biotic Orb",
                HeroAbility2 = "Moira launches a rebounding biotic sphere; she can choose between a regeneration effect that heals the allies it passes through for 75 health per second, or a decay effect that deals 50 damage per second to enemies. 20 m/s projectile speed (5.5 m/s while tethered. 10 second cooldown.",
                HeroUltimateName = "Coalescence",
                HeroUltimate = "Moira channels a 30 meter range beam that both heals allies for 140 hp per second and bypasses barriers to damage her enemies for 70 hp per second. While channeling this ability, Moira’s movement speed increases to 9 m/s, but she cannot perform any other actions. 0.5 second cast. Lasts 8 seconds.",
                HeroTipsAndTricks = "Use damage orb for poking and healing orb for engagements. Use your ultmate before your teammates die.",
                HeroClass = "support"
            });

            //NEW
            //ORISA
            heroes.Add(new Hero
            {
                HeroId = 17,
                HeroName = "Orisa",
                HeroImage = "Assets/Orisa_portrait.png",
                HeroSmallerImage = "Assets/Orisa_smallerportrait.png",
                HeroDifficulty = 2,
                HeroStrengths = "Protects the team front line",
                HeroWeaknesses = "Can't deal with enemies at range",
                HeroHealthArmorShield = "200 Health, 200 Armor",
                HeroLeftClickDamage = "Orisa’s automatic projectile cannon delivers sustained damage firing 12.5 rounds per second dealing 11 damage each. Her movement decreases 30% (2.75 m/s). 72 m/s projectile speed. 150 rounds. 2.55 second reload.",
                HeroRightClickDamage = "Orisa launches a graviton charge which she can detonate, slowing enemies within 7.5 meters and pulling them towards the explosion. 20 m/s projectile. 0.33 second cast. Lasts 0.45 seconds. 8 second cooldown.",
                HeroSpeed = "5.5 meters per second",
                HeroPassiveName = "None",
                HeroPassive = "",
                HeroAbility1Name = "Fortify ",
                HeroAbility1 = "Orisa temporarily recieves +50% damage reduction and immunity to cc. Lasts 4 seconds. 10 second cooldown (only starts when duration ends).",
                HeroAbility2Name = "Protective Barrier",
                HeroAbility2 = "Orisa throws out a stationary barrier that can protect her and her allies from enemy fire. The barrier has 900 hp and lasts 20 seconds. 19 m/s projectile speed. 8 second cooldown.",
                HeroUltimateName = "Supercharger",
                HeroUltimate = "Orisa deploys a device which increases ally damage output by 50%. Only impacts allies within 25 meters and in line of sight of the device. 1 second cast. 200 hp device. Lasts 15 seconds.",
                HeroTipsAndTricks = "Don't reload too often. Place Supercharger in safe locations.",
                HeroClass = "tank"
            });

            //PHARAH
            heroes.Add(new Hero
            {
                HeroId = 18, 
                HeroName = "Pharah",
                HeroImage = "Assets/Pharah_portrait.png", 
                HeroSmallerImage = "Assets/Pharah_smallerportrait.png",
                HeroDifficulty = 2, 
                HeroStrengths = "High Burst Damage", 
                HeroWeaknesses = "She is easily targeted while in the air",
                HeroHealthArmorShield = "200 Health",
                HeroLeftClickDamage = "Pharah’s primary weapon launches rockets that deal 120 damage on direct hits and 20 - 80 damage (10 - 32.5 self) in a 3 meter radius. 6 rounds. 1.5 second reload. 1.33 shots per second. 35 m/s projectile speed. ",
                HeroRightClickDamage = "NA", 
                HeroSpeed = "5.5 meters per second",
                HeroPassiveName = "Hover jets",
                HeroPassive = "Hold to hover in the air for 2 seconds. 2 second cooldown", 
                HeroAbility1Name = "Concussive Blast",
                HeroAbility1 = "Pharah looses a wrist rocket that knocks back any enemies it strikes in a 8 meter radius. Knockback also affects Pharah. 50 m/s projectile speed. 9 second cooldown.",
                HeroAbility2Name = "Jump jet",
                HeroAbility2 = "Propelled by her suit’s thrusters, Pharah soars 25 meters into the air at 20 m/s. 10 second cooldown",
                HeroUltimateName = "Barrage",
                HeroUltimate = "Pharah directs a continuous salvo of 30 mini-rockets per second dealing 40 damage per rocket for 3 seconds to destroy groups of enemies. Pharah cannot move while Barrage is active. Deals self damage. 28.5 m/s projectile speed.",
                HeroTipsAndTricks = "Stay in the air dealing damage from above (but be careful of snipers).",
                HeroClass = "damage"
            });

            //REAPER
            heroes.Add(new Hero
            {
                HeroId = 19, 
                HeroName = "Reaper",
                HeroImage = "Assets/Reaper_portrait.png", 
                HeroSmallerImage = "Assets/Reaper_smallerportrait.png",
                HeroDifficulty = 1, 
                HeroStrengths = "Good at Flanking and taking out tanks", 
                HeroWeaknesses = "Weak at long range",
                HeroHealthArmorShield = "250 Health",
                HeroLeftClickDamage = "Reaper tears enemies apart with twin shotguns shooting 20 pellets dealing 2.1 - 7 damage each over 10 - 20 meters. 8 rounds. 1.5 second reload. 2 shots per second.. ",
                HeroRightClickDamage = "NA",
                HeroSpeed = "5.5 meters per second",  
                HeroPassiveName = "The Reaping",
                HeroPassive = "40% of damage dealt is restored as hp.",
                HeroAbility1Name = "Wraith Form",
                HeroAbility1 = "Reaper becomes a shadow for a 3 seconds. While active, he takes no damage, is able to pass through enemies and moves 7.1 m/s, but cannot fire his weapons or use other abilities.  8 second cooldown.",
                HeroAbility2Name = "Shadow Step",
                HeroAbility2 = "After marking a destination up to a maximum of 35 meters, Reaper disappears and reappears at that location. 2 second duration. 1.5 second cast. 10 second cooldown.",
                HeroUltimateName = "Death Blossom",
                HeroUltimate = "In a blur of motion, Reaper empties both Hellfire Shotguns at breakneck speed, dealing 170 damage per second to all nearby enemies for 3 seconds in an 8 meter radius.",
                HeroTipsAndTricks = "Target and kill tanks. Shadow Step behind Bastion in Sentry mode to catch him off guard.",
                HeroClass = "damage"
            });

            //REINHARDT
            heroes.Add(new Hero
            {
                HeroId = 20, 
                HeroName = "Reinhardt",
                HeroImage = "Assets/Reinhardt_portrait.png",
                HeroSmallerImage = "Assets/Reinhardt_smallerportrait.png",
                HeroDifficulty = 2, 
                HeroStrengths = "High damage and can push very well", 
                HeroWeaknesses = "Weak at long range",
                HeroHealthArmorShield = "300 Health and 200 Armor",
                HeroLeftClickDamage = "Reinhardt’s Rocket Hammer deals 75 damage in a 5 meter range with every swing. 1.1 swings per second.",
                HeroRightClickDamage = "Reinhardt projects a broad, forward-facing energy shield slowing his movement speed to 2.75 meters per second, which can absorb up to 2000 damage before it is destroyed. Reinhardts shield will regenerate 200 health per second after not being used for 2 seconds. Though Reinhardt can protect himself and his companions behind the shield, he cannot attack while sustaining it. 5 second cooldown if destroyed.",
                HeroSpeed = "5.5 meters per second", 
                HeroPassiveName = "None", 
                HeroPassive = "", 
                HeroAbility1Name = "Charge",
                HeroAbility1 = "Reinhardt charges forth going 16.66 meters per second in a straight line for 3 seconds, grabbing hold of enemies in his path dealing 50 damage. If he collides with a wall, foes he’s carrying suffer 300 damage. 10 second cooldown (3 if interupted).",
                HeroAbility2Name = "Fire Strike",
                HeroAbility2 = "By whipping his Rocket Hammer forward, Reinhardt slings a flaming projectile which pierces and deals 100 damage to any enemies it touches. 26.66 m/s projectile speed. 6 second cooldown.",
                HeroUltimateName = "Earth Shatter",
                HeroUltimate = "Reinhardt forcefully slams his rocket hammer into the ground, dealing 50 damage and knocking down enemies in front of him for 2.5 seconds.",
                HeroTipsAndTricks = "Protect your team with your shield.",
                HeroClass = "tank"
            });

            //ROADHOG
            heroes.Add(new Hero
            {
                HeroId = 21, 
                HeroName = "Roadhog",
                HeroImage = "Assets/Roadhog_portrait.png", 
                HeroSmallerImage = "Assets/Roadhog_smallerportrait.png",
                HeroDifficulty = 2,
                HeroStrengths = "High damage", 
                HeroWeaknesses = "Weak at long range", 
                HeroHealthArmorShield = "600 Health",
                HeroLeftClickDamage = "Roadhog's Scrap Gun fires 25 bits of shrapnel dealing 1.6 - 6 damage per fragment over 11 - 22 meters (45 - 150 damage per shot). 5 rounds. 2 second reload. 1.3 shots per second. 57 m/s projectile speed.",
                HeroRightClickDamage = "Roadhog's Scrap Gun launches a shrapnel ball that detonates farther away, scattering metal fragments from the point of impact. The ball deals 50 damage while the shrapnel stays the same. The drop off changes to 15 - 30 meters. 1.43 shots per second.",
                HeroSpeed = "5.5 meters per second", 
                HeroPassiveName = "None", 
                HeroPassive = "",
                HeroAbility1Name = "Chain Hook",
                HeroAbility1 = "Roadhog hurls his chain at 40 m/s for a maximum distance of 20 meters at a target; if it catches, he yanks them into close range dealing 30 damage. 0.3 second cast. 6 second cooldown.",
                HeroAbility2Name = "Take a Breather",
                HeroAbility2 = "Roadhog restores 300 health for 1 second and gains 50% damage reduction over 2 seconds. 0.6 second cast time. 0.4 seconds recovery. 8 second cooldown.",
                HeroUltimateName = "Whole Hog",
                HeroUltimate = "After cramming a top-loader onto his Scrap Gun, Roadhog pours in ammo. For 5.5 seconds, he can crank out a stream of 128 shrapnel bits that knockback enemies 10 m/s and deal 7 damage per pellet. 4.125 m/s movement speed. 0.5 second cast.",
                HeroTipsAndTricks = "Chain targets and bring them in for an easy kill.",
                HeroClass = "tank"
            });

            //NEW
            //SIGMA
            heroes.Add(new Hero
            {
                HeroId = 22,
                HeroName = "Sigma",
                HeroImage = "Assets/Sigma_portrait.png",
                HeroSmallerImage = "Assets/Sigma_smallerportrait.png",
                HeroDifficulty = 3,
                HeroStrengths = "Protecting important allies and taking damage",
                HeroWeaknesses = "Low damage",
                HeroHealthArmorShield = "300 Heatlh, 100 Shield",
                HeroLeftClickDamage = "Sigma launches two gravitic charges, which bounce off walls and implode after a short duration, damaging direct enemies for 55 and 9 - 30 within a 3 meter radius. 22 range. 0.67 shots per second. ",
                HeroRightClickDamage = "Experimental Barrier",
                HeroSpeed = "5.5 m/s",
                HeroPassiveName = "None",
                HeroPassive = "",
                HeroAbility1Name = "Kinetic Grasp",
                HeroAbility1 = "Sigma freezes incoming projectiles in midair within 3 meters for 2 seconds, converting 60% of their damage into shields (max 400). 12 second cooldown.",
                HeroAbility2Name = "Accretion",
                HeroAbility2 = "Sigma gathers a mass of debris and flings it at an enemy dealing 70 damage on direct hits and  12 - 40 splash within 2.5 meters. Knocks heroes back 4 meters on direct hits and 1 - 2 meters in the explosion radius. Knocks enemies down for 0.8 seconds. 0.65 second cast. 10 second cooldown.",
                HeroUltimateName = "Gravitic Flux",
                HeroUltimate = "Unleashing his full powers, Sigma takes flight, lifts enemies in a targeted 7 meter radius area, and launches them into the sky for 2 seconds daeling 50 damage before slamming them back down in 0.6 seconds dealing an additional 50% of thier max hp. 7.15 m/s movement speed.",
                HeroTipsAndTricks = "Be careful to not get interupted while ulting. Use ablilities carefully because your abilities have long cooldowns. ",
                HeroClass = "tank"
            });

            //SOLDIER_76
            heroes.Add(new Hero
            {
                HeroId = 23, 
                HeroName = "Soldier 76",
                HeroImage = "Assets/Soldier76_portrait.png", 
                HeroSmallerImage = "Assets/Soldier76_smallerportrait.png",
                HeroDifficulty = 1, 
                HeroStrengths = "Good damage, healing, and mobility", 
                HeroWeaknesses = "Weak at longer ranges",
                HeroHealthArmorShield = "200 Health",
                HeroLeftClickDamage = "Soldier: 76’s fully-automatic rifle deals 10 - 20 damage over 30 - 50 meters. 25 rounds. 1.55 second reload. 8.66 shots per second.",
                HeroRightClickDamage = "Tiny rockets spiral out of Soldier: 76’s Pulse Rifle in a single burst. The rockets’ explosion deals 120 damage on direct hits and 40 -80 (20 - 40 self) to enemies in a 3 meter radius. 50 m/s projectile speed. 8 second cooldown. Can headshot.",
                HeroSpeed = "5.5 meters per second", 
                HeroPassiveName = "None", 
                HeroPassive = "",
                HeroAbility1Name = "Sprint",
                HeroAbility1 = "Soldier: 76 can sprint at 8.33 m/s. Can't do any other action during sprint. Can't shoot or reload 0.3 seconds after sprinting.",
                HeroAbility2Name = "Biotic field",
                HeroAbility2 = "Soldier: 76 plants a biotic emitter on the ground that last for 5 seconds. It restores 40 health per second to allies within the 5 meter field. 15 second cooldown",
                HeroUltimateName = "Tactical Visor",
                HeroUltimate = "Soldier: 76’s pinpoint targeting visor “locks” his aim on the threat closest to his crosshairs. If an enemy leaves his line of sight, Soldier: 76 can quickly switch to another target. Tactical Visor lasts for 6 seconds. Reload speed increased to 0.75 seconds. 1.4 second cast.",
                HeroTipsAndTricks = "Fire Helix rockets at the enemy's feet to be more accurate.",
                HeroClass = "damage"
            });

            //NEW
            //Sombra
            heroes.Add(new Hero
            {
                HeroId = 24,
                HeroName = "Sombra",
                HeroImage = "Assets/Sombra_portrait.png",
                HeroSmallerImage = "Assets/Sombra_smallerportrait.png",
                HeroDifficulty = 3,
                HeroStrengths = "Good at disrupting enemies",
                HeroWeaknesses = "No long range damage",
                HeroHealthArmorShield = "200 Health",
                HeroLeftClickDamage = "Sombra’s fully-automatic machine pistol fires 20 rounds per second dealing 2.4 - 8 damage each. Falloff 15 - 35 meters. 60 rounds. 1.5 second reload. 2.7 degree spread angle.",
                HeroRightClickDamage = "Sombra hacks enemies within 15 meters to temporarily stop them from using their abilities for 6 seconds, or hacks first aid kits to spawn faster and make them useless to her opponents for 60 seconds. Taking damage interrupts the hacking. 8 second cooldown on enemies, 6 seconds for healthpack, or 2 seconds if interrupted.",
                HeroSpeed = "5.5 meters per second",
                HeroPassiveName = "Opportunist",
                HeroPassive = "Enemies with less than 50% of their hp are revealed.",
                HeroAbility1Name = "Stealth",
                HeroAbility1 = "Sombra becomes invisible for 6 seconds, during which her speed is boosted 50% (8.8 m/s). Attacking, using offensive abilities, walking within 2 meters of an enemy, or taking damage disables her camouflage. 0.7 second cast. 6 second cooldown.",
                HeroAbility2Name = "Translocator",
                HeroAbility2 = "Sombra tosses out a translocator beacon. She can instantly return to the beacon’s location while it is active you can only have one beacon at a time. (including when it’s in mid-flight). The beacon has 5 hp. 0.7 second cast. 19 m/s projectile speed. 4 second cooldown (2 if self-canceled).",
                HeroUltimateName = "EMP",
                HeroUltimate = "Sombra discharges electromagnetic energy in a 15 meter radius, destroying enemy barriers and shields and hacking all opponents caught in the blast. 0.5 cast. Lasts 6 seconds.",
                HeroTipsAndTricks = "Use translocator for repositioning. Stealth voiceline can be heard 15 meters away.",
                HeroClass = "damage"
            });

            //SYMMETRA
            heroes.Add(new Hero
            {
                HeroId = 25, 
                HeroName = "Symmetra",
                HeroImage = "Assets/Symmetra_portrait.png", 
                HeroSmallerImage = "Assets/Symmetra_smallerportrait.png",
                HeroDifficulty = 2, 
                HeroStrengths = "High Burst Damage", 
                HeroWeaknesses = "Weak at long range", 
                HeroHealthArmorShield = "100 Health, 100 Shield",
                HeroLeftClickDamage = "Symmetra’s weapon emits a 12 meter range beam that homes in on a nearby enemy, dealing continuous damage that increases the longer it is connected 65/130/195. 70 rounds. 1.35 second reload. 7 rounds per second. Gains ammo if used against a barrier.",
                HeroRightClickDamage = "The projector can also release a charged energy ball which deals up to 120 damage on direct hits and 15 - 60 AoE. 1 second to charge and 0.55 seconds between shots. 20 m/s projectile speed. ",
                HeroSpeed = "5.5 meters per second", 
                HeroPassiveName = "None", 
                HeroPassive = "", 
                HeroAbility1Name = "Sentry Turret",
                HeroAbility1 = "Symmetra sets up a small turret with 30 hp that automatically fires speed-reducing blasts slowing 20% and dealing 50 damage per second the nearest enemy within 10 meters. 3 turrets can be built on the battlefield at once. Max 3 turret storage. 1.5 second cast. 10 second cooldown",
                HeroAbility2Name = "Teleporter",
                HeroAbility2 = "Symmetra places a temporary teleporter exit pad at a distance and connects it to a teleporter entry pad at her current location. Allies (and some of their abilities, such as Junkrat’s RIP-Tire) can travel from the entry pad to the exit pad instantly. The teleporter has 50 health and 250 shield. 25 meter range. 0.8 second cast. 2 second deploy. 10 second duration. 12 second cooldown.",
                HeroUltimateName = "Photon Barrier",
                HeroUltimate = "Symmetra deploys a wide-radius generator that provides increased shielding to her entire team. Blocks 5000 points of damage. Lasts 15 seconds or until destroyed. 25 meter range.",
                HeroTipsAndTricks = "Send turrets through teleporter. 1 fully charged shot and 70% charged shot will kill a 200 health hero.",
                HeroClass = "damage"
            });

            //TORBJORN
            heroes.Add(new Hero
            {
                HeroId = 26, 
                HeroName = "Torbjorn",
                HeroImage = "Assets/Torbjorn_portrait.png", 
                HeroSmallerImage = "Assets/Torbjorn_smallerportrait.png",
                HeroDifficulty = 2, 
                HeroStrengths = "Defending chokepoints", 
                HeroWeaknesses = "Weak at long range",
                HeroHealthArmorShield = "200 Health", 
                HeroLeftClickDamage = "Torbjörn fires rivets at long range dealing 70 damage per shot. 1.67 shots per second. 55 m/s projectile speed. 18 rounds. 2 second reload. / Torbjörn uses his multipurpose hammer to build, upgrade and repair turrets healing 50 health. In a pinch, it can also be swung as a weapon dealing 55 damage swinging. 1.25 swings per second.",
                HeroRightClickDamage = "Torbjörn ejects molten metal from his gun in a short, close-range burst shooting 10 pellet dealing 6 - 15 damage each. 10 - 20 meter falloff. 4.15 degree spread. 80 m/s projectile speed. 1.25 rounds per second. ",
                HeroSpeed = "5.5 meters per second", 
                HeroPassiveName = "",
                HeroPassive = "",
                HeroAbility1Name = "Build Turret",
                HeroAbility1 = "Torbjörn constructs an enemy-tracking autocannon. He can use his Forge Hammer to repair or upgrade it, increasing its health and adding a second cannon barrel and a rocket launcher. The turret fires at enemies within 40 meters dealing 14 damage per round shooting 4 shots per second. 250 health. 15 meter deploy range. 3 second deploy time. 5 second cooldown (10 if destroyed). Can't headshot.",
                HeroAbility2Name = "Overload",
                HeroAbility2 = "Torbjörn gains 100 additional health as well as +30% attack speed, movement speed (7.15 m/s), and reload speed for a brief period. 12 second cooldown.",
                HeroUltimateName = "Molten Core",
                HeroUltimate = "Torbjörn creates pools of molten slag that deal 160 damage per second (190 if armored) for 10 second and preventing enemies from moving through key locations. Magma pools last 10 seconds.",
                HeroTipsAndTricks = "Build your turret in a semi-protected spot that can still be an effective killer. Use Overload to survive a Tracer pulse bomb.",
                HeroClass = "damage"
            });

            //TRACER
            heroes.Add(new Hero
            {
                HeroId = 27, 
                HeroName = "Tracer",
                HeroImage = "Assets/Tracer_portrait.png", 
                HeroSmallerImage = "Assets/Tracer_smallerportrait.png",
                HeroDifficulty = 2, 
                HeroStrengths = "High damage and mobility", 
                HeroWeaknesses = "Weak at long range",
                HeroHealthArmorShield = "150 Health", 
                HeroLeftClickDamage = "Tracer rapid-fires both of her pistols shooting 20 shots per second dealing 3.6 - 12 damage per shot. 10 - 20 meter falloff. 40 rounds. 1.15 second reload. ",
                HeroRightClickDamage = "", 
                HeroSpeed = "6 meters per second", 
                HeroPassiveName = "", 
                HeroPassive = "", 
                HeroAbility1Name = "Blink",
                HeroAbility1 = "Tracer zips 7.5 meters horizontally through space in the direction she’s moving. She stores up to three charges of the blink ability and generates 1 charge every 3 seconds. ",
                HeroAbility2Name = "Recall",
                HeroAbility2 = "Tracer bounds backward in time reloading her weapons and returning her health and position on the map to precisely where they were 3 seconds before. 1.25 second duration. 12 second cooldown",
                HeroUltimateName = "Pulse Bomb",
                HeroUltimate = "Tracer lobs a large bomb that adheres to any surface or unfortunate opponent it lands on dealing 5 damage if it sticks. After 1 second, the bomb explodes, dealing 300 damage to all enemies within its 3 meter radius.",
                HeroTipsAndTricks = "Go behind enemy lines and distract them from the objective. After using Pulse Bomb, use Recall to get away. Can rebind blink to right click. ",
                HeroClass = "damage"
            });

            //WIDOWMAKER
            heroes.Add(new Hero
            {
                HeroId = 28, 
                HeroName = "Widowmaker",
                HeroImage = "Assets/Widowmaker_portrait.png", 
                HeroSmallerImage = "Assets/Widowmaker_smallerportrait.png",
                HeroDifficulty = 2, 
                HeroStrengths = "High damage from longe range and good mobility", 
                HeroWeaknesses = "Weak at close range",
                HeroHealthArmorShield = "200 Health",
                HeroLeftClickDamage = "Should targets close to medium range, the rifle can also be fired in fully-automatic mode shooting 10 shots per second and dealing 13 damage per shot. 30 rounds. 1.5 second reload.",
                HeroRightClickDamage = "Widowmaker’s versatile sniper rifle is ideal for scope-aimed shots dealing 120 damage (12 uncharged) to distant targets. Headshot deals 2.5x damage. 0.75 seconds to fully charge and 0.33 seconds to scope in/out. ",
                HeroSpeed = "5.5 meters per second", 
                HeroPassiveName = "None", 
                HeroPassive = "", 
                HeroAbility1Name = "Grappling Hook",
                HeroAbility1 = "Widowmaker launches a grappling hook at 20 m/s towards the location she’s aiming at with a 20 meter range – when the hook connects with a scalable surface, she’s quickly drawn towards it at 16 m/s, allowing her to expand her view of the battlefield and evade or flank targets. 12 second cooldown.",
                HeroAbility2Name = "Venom Mine",
                HeroAbility2 = "Widowmaker adheres a swiftly-arming venom mine to nearly any surface. When a target wanders within 3 meters of the mine’s motion trigger, it explodes, delivering poison gas to all enemies dealing 15 damage per second for 5 seconds. 15 second cooldown. 19 m/s projectile speed. ",
                HeroUltimateName = "Infra-Sight",
                HeroUltimate = "Widowmaker’s recon visor allows her to see the heat signatures of her targets through walls and objects for 15.5 seconds. This enhanced vision is shared with her allies. 0.5 second cast.",
                HeroTipsAndTricks = "Stay in the back and kill priority targets. Grappling Hook can also be used on the ground to move faster.",
                HeroClass = "damage"
            });

            //WINSTON
            heroes.Add(new Hero
            {
                HeroId = 29, 
                HeroName = "Winston",
                HeroImage = "Assets/Winston_portrait.png", 
                HeroSmallerImage = "Assets/Winston_smallerportrait.png",
                HeroDifficulty = 2, 
                HeroStrengths = "Great pusher", 
                HeroWeaknesses = "Weak at long range", 
                HeroHealthArmorShield = "400 Health and 100 armor",
                HeroLeftClickDamage = "Winston’s weapon fires an electric barrage 8 meters forward dealing 60 damage per second to enemies in a 6 meter radius. 100 rounds. 20 rounds per second. 1.5 second reload. ",
                HeroRightClickDamage = "NA", 
                HeroSpeed = "5.5 meters per second", 
                HeroPassiveName = "None",
                HeroPassive = "", 
                HeroAbility1Name = "Jump Pack",
                HeroAbility1 = "Assisted by his energy pack, Winston lunges up to 20 meters through the air, dealing 44 damage and staggering enemies within 5 meters where he lands. 6 second cooldown (2 during Primal Rage).",
                HeroAbility2Name = "Barrier Projector",
                HeroAbility2 = "Winston’s barrier projector extends a bubble-shaped field in a 5 meter radius for 6 seconds that absorbs 600 damage until it's destroyed. 13 second cooldown.",
                HeroUltimateName = "Primal Rage",
                HeroUltimate = "Winston embraces his animal nature, boosting his health to 900 and gaining 100 armor making him very difficult to kill, does 40 damage per swing that also knock back enemies in 4 meters, boosting movement speed to 7.1 m/s, and allowing him to use his Jump Pack ability more frequently. While raging, Winston can only make melee and Jump Pack attacks. Lasts 10 seconds.",
                HeroTipsAndTricks = "Use Primal Rage when low health. Try not to engage with Jump Pack. ",
                HeroClass = "tank"
            });

            //NEW
            //WRECKING BALL
            heroes.Add(new Hero
            {
                HeroId = 30,
                HeroName = "Wrecking Ball",
                HeroImage = "Assets/WreckingBall_portrait.png",
                HeroSmallerImage = "Assets/WreckingBall_smallerportrait.png",
                HeroDifficulty = 3,
                HeroStrengths = "Large area damage",
                HeroWeaknesses = "No long range damage",
                HeroHealthArmorShield = "500 Health, 100 Armor",
                HeroLeftClickDamage = "Wrecking Ball’s automatic assault cannons shoot 25 rounds per second dealing 5 damage each. 15 - 25 meter falloff. 80 rounds. 2.1 second reload.",
                HeroRightClickDamage = "Wrecking Ball launches a grappling claw at 20 m/s, enabling him to anchor to an area and swing from it. If he strikes an enemy with a powered-up swing, they take 50 damage and are knocked back 10 meters.",
                HeroSpeed = "5.5 meters per second",
                HeroPassiveName = "Pile Driver",
                HeroPassive = "Wrecking Ball slams onto the ground below, damaging enemies for 20 - 100 damage in an 8 meter radius and launching them upward. 10 second cooldown.",
                HeroAbility1Name = "Roll",
                HeroAbility1 = "Wrecking Ball transforms into a ball, increasing his movement speed to 10 m/s. Wrecking Ball has no critical hitbox while rolling.",
                HeroAbility2Name = "Adaptive Shield",
                HeroAbility2 = "Wrecking Ball gains a temporary shield for 7 seconds which protects him for 100 damage. Each opponent within 8 meters gives 100 more hp to his shield. 0.3 second cast. 15 second cooldown.",
                HeroUltimateName = "Minefield",
                HeroUltimate = "Wrecking Ball deploys a field of proximity mines which explode on contact with enemies dealing 130 damage in a 6 meter radius. Each mine has 50 Health and lasts for 20 seconds.",
                HeroTipsAndTricks = "Reload while rolling and you will be harder to hit. Temporary shields do not provide enemies with ultimate charge.",
                HeroClass = "tank"
            });

            //ZARYA
            heroes.Add(new Hero
            {
                HeroId = 31, 
                HeroName = "Zarya",
                HeroImage = "Assets/Zarya_portrait.png", 
                HeroSmallerImage = "Assets/Zarya_smallerportrait.png",
                HeroDifficulty = 3, 
                HeroStrengths = "Strong shields and can take a lot of damage", 
                HeroWeaknesses = "Low mobility",
                HeroHealthArmorShield = "200 Health 200 Shield",
                HeroLeftClickDamage = "Zarya’s mighty Particle Cannon unleashes a 15 meter range beam of destructive energy that deals 95 - 190 damage per second. 100 rounds. 20 rounds per second. 1.6 second reload. ",
                HeroRightClickDamage = "Zarya lobs an explosive charge to strike multiple opponents for 45 - 90 (23.5 - 47 self) damage in a 2 meter radius. 25 rounds per shot. 1 shot per second. 23.5 m/s projectile speed.",
                HeroSpeed = "5.5 meters per second", 
                HeroPassiveName = "Energy",
                HeroPassive = "+1 point of energy for every 5 damage blocked. Particle Cannon damage increases by 1% per point of charge (max of 100 energy). Energy decays 1.6% per second.  ",
                HeroAbility1Name = "Particle Barrier",
                HeroAbility1 = "The Particle Cannon can emit a personal barrier that gives Zarya 200 health against incoming attacks for 2 seconds, redirecting their energy to enhance her weapon’s damage and the width of its beam. 10 second cooldown.",
                HeroAbility2Name = "Projected Barrier",
                HeroAbility2 = "The Particle Cannon can emit a barrier that gives an ally within 30 meters 200 health against incoming attacks for 2 seconds, redirecting their energy to enhance her weapon’s damage and the width of its beam. 8 second cooldown.",
                HeroUltimateName = "Graviton Surge",
                HeroUltimate = "Zarya launches a gravity bomb that draws in enemy combatants within 6 meters and deals 5.5 damage per second over 4 seconds. 2 second delay. 25 m/s projectile speed.",
                HeroTipsAndTricks = "Shield your allies and use your ultimate in combination with others.",
                HeroClass = "tank"
            });

            //ZENYATTA
            heroes.Add(new Hero
            {
                HeroId = 32, 
                HeroName = "Zenyatta",
                HeroImage = "Assets/Zenyatta_portrait.png", 
                HeroSmallerImage = "Assets/Zenyatta_smallerportrait.png",
                HeroDifficulty = 3, 
                HeroStrengths = "Good damage and healing", 
                HeroWeaknesses = "Weak out in the open", 
                HeroHealthArmorShield = "50 Health, 100 Shield",
                HeroLeftClickDamage = "Zenyatta projects his destructive energy orbs individually dealing 48 damage per orb. 2.5 shots per second. 20 rounds. 1.5 second reload. 80 m/s projectile speed.",
                HeroRightClickDamage = "Zenyatta gathers his orbs charging 1 orb every .5 seconds for up to 5 orbs. He then projects each orb out every 0.1 seconds. ",
                HeroSpeed = "5.5 meters per second", 
                HeroPassiveName = "None", 
                HeroPassive = "", 
                HeroAbility1Name = "Orb of Harmony",
                HeroAbility1 = "Zenyatta casts an orb over the shoulder of a targeted ally within 40 meters. So long as Zenyatta maintains line of sight, the orb restores 30 health per second to his ally. Only one ally can receive the orb's benefit at a time. 3 second duration if line of sight is broken. 120 m/s projectile speed. 0 second cooldown.",
                HeroAbility2Name = "Orb of Discord",
                HeroAbility2 = "Attaching the orb of discord to an opponent amplifies the amount of damage they receive by 25% for as long as Zenyatta maintains line of sight. Only one opponent can suffer the orb's effects at a time. 3 second duration if line of sight is broken. 120 m/s projectile speed. 0 second cooldown.",
                HeroUltimateName = "Trancendence",
                HeroUltimate = "Zenyatta enters a state of heightened existence for 6 seconds. While transcendent, Zenyatta cannot use abilities or weapons, but is immune to damage and automatically restores his health and that of allies within 10 meters by 300 health per second. Zenyatta moves 11 m/s while using Trancendence.",
                HeroTipsAndTricks = "Animation cancel using Orb of Discord. Melee to cancel your Orb Volley when no enemies are around.",
                HeroClass = "support"
            });

            return heroes;
        }

    }
}
