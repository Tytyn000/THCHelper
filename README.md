# TheortCraftHelper
This is a basic damage calculator for the game "Honkai Star Rail".
It contains only the basic functionalities to calculate damage at the moment. It cannot calculate break damage. It is not 100% accurate, and the damage calculated by this software may differ from that in the game.
I am not affiliated with Mihoyo/Hoyoverse. The names of the characters and enemies, as well as the damage formula, do not belong to me.


Information of how to use : 

About the different panels:
    Base Damage:
        - The SkillMultiplier is the total multiplier of the skill. This skill can be anything: a Basic ATK, a Skill, an Ultimate, etc. For example, for JingLiu's Skill at level 10, it is 200%.
        - The Extra Multiplier is the total multiplier of additional effects. For example, Dang Heng's Ultimate's DMG multiplier increases on slowed enemies.
        - The scaling attribute is the statistic used to scale the skill. In most cases, it's ATK. For Blade, it is HP and ATK, so put the sum of these two stats.
        - The Extra Damage is flat additional damage that is on some skills.

    Damage % Multiplier:
        - Elemental Damage is the total Elemental Damage. For example, a sphere at max level gives 38.80%.
        - All Type Damage is a part of the bonus Damage. For example, Tingyun and Bronya buffs go here, as well as the effect of the 4 Musketeers set.
        - DOT Damage is also a part of the bonus Damage. For example, the light cone "Woof! Walk Time!" can go here.
        - Other Damage is also a part of the bonus Damage. Put all the bonuses that are not already mentioned here.
        Note:
            In the damage formula, this is the sum of everything, so the order in the panel is not important.

   DEF Multiplier:
    - Base DEF is the DEF of the enemy. The DEF of the majority is 200 + (EnemyLevel * 10). There is an exception for some enemies like the trot and the trotter where the DEF is 300 + (EnemyLevel * 15).
    - DEF Reduction is the DEF reduction that is on the enemy. This can be triggered by characters like Pela or Silverwolf. It can also be triggered by LightCone like "Resolution Shines As Pearls of Sweat."
    - DEF Ignore is the DEF ignore of the character. This can be triggered by sets like Genius of Brilliant Stars.
    - The DEF Flat is the flat DEF of the enemy. For now, I don't know if enemies have additional DEF in addition to the DEF formula.
    - The AttackerLevel is just the level of the attacker.

    RES Multiplier:
        - The RES is the resistance of the enemy. If the enemy is weak to the element, its RES will be 0. If it has no weakness, its RES is equal to 20%. And if it is resistant to that element, the RES is equal to 40%.
        - The RES PEN is the resistance penetration of the character. For example, Seele in her buffed stats gets RES PEN.
        Important Note:
            - If SilverWolf applies his skill correctly on an enemy and it is the correct weakness but the enemy is resistant, it will be 40 - 20, therefore 20% RES.
            - I noticed that the SilverWolf bug that implements which decreases All type RES is like increasing the RES PEN by that number or decreasing RES by that number. In my case, it is 9.3%, and the result is the same no matter if I increase or decrease (only one of the two modifications at the same time).

    Damage Taken Multiplier:
        - These two panels will not be frequently used, but just remember that there are only a few characters that can input values like Welt, Sampo, etc.

    Damage Reduction Multiplier:
        - To simplify, if the enemy has Toughness > 0, it will be 90. If its Toughness is equal to 0 (is broken), the value will be 100.

    Weaken Multiplier:
        - Only a few characters can influence the Weaken Multiplier like Natasha, so in most cases, it will be 100%.

    Crit Rate && Crit Damage:
        - Just fill in the Crit Rate and Crit Damage.


Damage Repartition Between Each Hit:
    Many skills in Honkai Star Rail deal damage more than once, like Dang Heng's Basic ATK, which deals 45% and 55% damage respectively.
    Each instance of damage has a separate crit chance. The first hit can crit, and the second may not, and vice versa.
    This panel takes the multiplier of each hit up to 7 times for better results. For example, JingLiu's skill when she is not in Spectral Transmigration state deals only 1 instance of damage. Therefore, the first input field will be 100, and all the other ones will be 0.
    For Herta's skill, it's 30% on the first hit and 70% on the second hit. Therefore, the first input field will be 70, the second one 30, and all the others 0.
    The sum of every input field must be equal to 100% (exception for certain skills like Topaz where it will be approximately 99.9% due to math issues).
    For characters like Topaz, instead of percentages, you can fill in fractions like 1/7.
    The fractions available are 0/7, 1/7, 2/7, 3/7, 4/7, 5/7, 6/7, 7/7.
    The different text in the Damage Repartition Between Each Hit Panel shows if this hit crits or not.

About Save:
    Save Current Data:
        When you save and quit the application and come back later, the saved values are displayed. However, these are only indicative values, and technically, the values are still stored in the script but physically, the input fields are void of value. Therefore, if you save with these input fields void, it will save 0 as the value wherever it is not filled. So make sure before saving that every input field is correctly filled.

    Save Button Near Damage:
        This button copies the value of the damage field.

About the damage difference:
    The damage between this software and HSR can vary. In my tests, the difference did not go up to 1%. This issue is due to incorrect values in-game and the use of decimal values that increase the difference.

About keyboard shortcuts:
    CTRL S: Save current data
    CTRL Q: Close the app without saving
    F12: Copy the total expected damage
    F1: Copy the result of Damage Repartition At Hit 1
    F2: Copy the result of Damage Repartition At Hit 2
    F3: Copy the result of Damage Repartition At Hit 3
    F4: Copy the result of Damage Repartition At Hit 4
    F5: Copy the result of Damage Repartition At Hit 5
    F6: Copy the result of Damage Repartition At Hit 6
    F7: Copy the result of Damage Repartition At Hit 7

About other things:
    There is a voluntary empty space below.
    Not a definitive version; updates can arrive with a better UI, more possibilities, and precision.

Special thanks:
    Thanks to https://www.prydwen.gg and the people who helped me with their explanations of the damage formula.
    If you use this software, I hope you enjoy it and find it useful.
