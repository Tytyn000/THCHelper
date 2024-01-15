# THCHelper
This is a basic damage calculator for the game "Honkai Star Rail".
It contains only the basic things for calculate damage. It is not 100% accurate and the damage between this software and in game may not be the same.
I'm not affiliated with Mihoyo/Hoyoverse. The names of the characters and enemies present, as well as the damage formula do not belong to me. 
Thanks to https://www.prydwen.gg and the people who helped me with their explanations of the damage formula.
If you using this software I hope you enjoy it and you find it useful. 


Information of how to use : 

About the different panel :
    Base Damage : 
        The SkillMultiplier is the total multiplier of the skill, this skill can be everything a Basic ATK, a Skill, An Ultimate etc... Ex : For JingLiu Skill at level 10 it is 200%.
        The Extra Mutliplier is the total mutliplier of extra mutliplier. Ex Dang Heng who gets his Ultimate's DMG multiplier increases on slowed ennemy.
        The scaling attribute is the statistic used to scale the skill. In most of cases it's ATK. For Blade it is HP and ATK so put the sum of this 2 stats.
        The Extra Damage is flat additional damage that is on some skills.
    Damage % Mutliplier : 
        Elemental Damage is the total Elemental Damage. Ex : a spere at max level gives 38,80 %.
        All Type Damage is a part the bonus Damage. Ex : Tingyun and bronya buffs go here as well as the effect of the 4 musketeers set.
        DOT Damage is also a part of the bonus Damage. Ex : The light cone "Woof! Walk Time!" can go here.
        Other Damage is also a part a the bonus Damage. Here put all the bonus that are not already mentioned.
        Note : 
            In the damage Formula this is the sum of everything therefore the order in the panel are not important.
    DEF Multiplier : 
        Base DEF is the DEF of the ennemy. The DEF of the majority is 200 + (EnnemyLevel * 10). There is an exeption for some ennemy like the trot and the trotter where 
        the DEF is 300 + (EnnemyLevel * 15).
        DEF Reduction is the def reduction that are on the ennemy. This can be trigger by character like Pela or Silverwolf. It can also be trigger by LightCone like Resolution Shines As Pearls of Sweat.
        DEF Ignore is the def ignore of the character. This can be trigger by set like Genius of Brilliant Stars.
        The DEF Flat is the def flat of the ennemy. For the moment I don't know if ennemy has additional def in addition to the DEF formula.
        The AttackerLevel is juste the Level of the Attacker.
    RES Mutliplier : 
        The RES is the res of the ennemy. If the ennemy is weak at the element it RES will be 0. Else if it has no weakness it RES is equal to 20%. And if it resistant to that element
        the RES is equal to 40%. 
        The RES PEN is the RES PEN of the character. Ex : Seele in her buffed stats gets RES PEN.
        Important Note : 
            If SilverWolf apply correctly his skill on an ennemy and it is the good weakeness but the ennemy are resistant it will be 40 - 20 therefore 20% RES. 
            I noticed that the SilverWolf bug that implement wich decrease All type RES is like increase the RES PEN by that number or decrease RES by that number. In my case it is 9.3% and 
            the result it is the same no matter I increase or decrease (only 1 of the 2 modifications at the same time). 
    Damage Taken Multiplier : 
        This 2 panel will not be frequentely use but just remember that there is only few character that can put value in like Welt, Sampo etc...
    Damage Reduction Mutliplier : 
        To be simple if the ennemy has Toughness > 0 it will be 90. Else if it's Toughness is equal to 0 (is break) the value will be 100.
    Weaken Multiplier : 
        Only few character can influence the Weaken Multiplier like Natasha therefore in most of cases it will be 100%.
    Crit Rate && Crit Damage : 
        Just filled with the Crit Rate and Crit Damage.
    Damage Repartition Between Each Hit : 
        Many of the skills in Honkai Star rail do damage more than once like Dang Heng Basic ATK that do 45% and 55% damage respectively.
        Each instances of damage have a separed crit. The first hit can crit and the second not and vice versa. 
        This panel take the multiplier of each hit up to 7 times for better result. For exemple JingLiu skill when she is not in Spectral Transmigration state
        deal only 1 instances of damage. Therefore the first input field it will be 100 and all the other one 0.
        Ex : For Herta skill it's 30% at the first hit and 70 at the second hit. Therefore the first input field 
        will be 70 the second one 30 and all the other one 0. 
        The sum of every Input Field must be equal to 100%(exeption for certains skill like topaz where it will be approximately 98-99% due to maths issues).
        For characters like topaz instead of 14.....% you can filled with fraction like 1/7.
        The fractions available are 0/7, 1/7, 2/7, 3/7, 4/7, 5/7, 6/7, 7/7.
        The different text in Damage Repartition Between Each Hit Panel show if this hit crit or not.
About Save : 
    Save Current Data : 
        When you save and quit the application when you come back the saved value are displayed. But this is only indicative value and technically 
        the value are still on the script but physically the input field are void of value. Therefore if you save with this input field void it will 
        save 0 as value wherever it is not filled. So make sure before save every input field are correctely filled.
    Save Button Near Damage : 
        This button copy the value of damage field.

About the damage difference : 
    The damage between this software and HSR can vary. In my test the difference did not go up 1%. This issues is due at
    incorrect value in game and using of decimal value that increase the difference.
    SkillMultiplier, Extra Damage, DEF Flat and AttackerLevel can only take integer value. 
About keyboard shortcut : 
    CTRL S : Save current data
    CTRL Q : Close the app without saving
    F12: Copy the total expected damage
    F1: Copy the result of the DamageRepartitionAtHit1
    F2: Copy the result of the DamageRepartitionAtHit2
    F3: Copy the result of the DamageRepartitionAtHit3
    F4: Copy the result of the DamageRepartitionAtHit4
    F5: Copy the result of the DamageRepartitionAtHit5
    F6: Copy the result of the DamageRepartitionAtHit6
    F7: Copy the result of the DamageRepartitionAtHit7
About other things : 
    There is a voluntary empty space below.
    Not a definitive version.