using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DamageCalculator : MonoBehaviour
{
    //Base DMG
    public float SkillMultiplier; //dégats en % du skill 
    public float ExtraMultiplier; //Spécifique : apparait par exemple sur dang heng avec les ennemis ralentis
    public int ScalingAttribute; //Stats sur laquelle le skills scale le plus souvent c'est ATK
    public float ExtraDamage; //dgts flat sur certains skills : 
    
    public float BaseDamage;

    //DMG% MULTIPLIER
    public static float Base100PercentOfDamagePercentMultiplier = 1f; //toujours 1
    public float ElementalDamagePercent; //Bonus Elementaires
    public float AllTypeDamagePercent; //ex Grand Duc + 20% sur les suivis
    public float DOTDamagePercent;
    public float OtherDamagePercent; //Buff TingYun
    
    public float DamagePercentMultiplier;

    //DEF MULTIPLIER
    public int AttackerLevel; //niveau de l'attaquant
    public int Flat200 = 200;
    public int Flat10 = 10;
    //pour trouver la def il faut une autre formule
    //DEF
    public float DEF; //est utiliser plus haut
    public int BaseDef; //Def de base
    public float DefReduction; //
    public float DefIgnore;
    public int DefFlat;
    public static float Base100PercentOfDef = 1.00f; //Toujours égal a 1

    public float DefMultiplier;

    //RES MULTIPLIER
    public static float Base100PercentOfRESMultiplier = 1.00f; //toujours 1
    public float RESPercentage; //Tout les ennemis ont 20% de res donc 80%. Sauf si il y a une faiblesse c'est 0% a cette élément donc 100%. Si il est résistant il a 40% de res a cette élément donc 60%.La RES ne peut pas aller sous -100% et ne pas dépasser environ 90%
    public float RESPENPercentage;

    public float RESMultiplier;

    //DMGTakenMultiplier
    public static float Base100PercentOfDamageTakenMultiplier = 1.00f;
    public float ElementalDamageTakenPercentage;
    public float AllTypeDamageTakenPercentage;

    public float DamageTakenMultiplier; //ne peut dépasser 350%

    //Universal DMG Reduction Multiplier
    public float UniversalDamageReductionMultiplier;//90% quand pas break. 100% quand break
    public bool IsBreak;

    //WeakenMultiplier
    public static float Base100PercentOfWeakenMultiplier = 1.00f;//toujours 1
    public float WeakenMultiplierPercentage;

    public float DamageInOutput;

    public Text DamageOutputText;
    void Start()
    {
        AttackerLevel = 0;

        SkillMultiplier = 0.00f;//ex 1.50f = 150%
        ExtraMultiplier = 0.00f;
        ScalingAttribute = 0;//atk
        ExtraDamage = 0.00f;

        Base100PercentOfDamagePercentMultiplier = 1.00f;
        ElementalDamagePercent = 0.0000f;
        AllTypeDamagePercent = 0.00f;//Erudition du moc va ici
        DOTDamagePercent = 0.00f;
        OtherDamagePercent = 0.00f;

        BaseDef = 0;
        RESPercentage = 0.00f;//0 si une faiblesse, 0.20 si pas de faiblesse, 0.40 si resistant
        RESPENPercentage = 0.00f;//je sais pas si c'est possible d'avoir des sommes ici

        IsBreak = false;

        CalculateDamage();
    }

    
    void Update()
    {
        
    }
    public void CalculateDamage()
    {
        BaseDamage = (SkillMultiplier + ExtraMultiplier) * ScalingAttribute + ExtraDamage;
        DamagePercentMultiplier = (Base100PercentOfDamagePercentMultiplier + (ElementalDamagePercent + AllTypeDamagePercent + DOTDamagePercent + OtherDamagePercent));
        DEF = (BaseDef * (Base100PercentOfDef + 0.00f - (DefReduction + DefIgnore)) + DefFlat);
        DefMultiplier = (Base100PercentOfDef - (DEF / (DEF + 200 + 10 * AttackerLevel)));
        RESMultiplier = Base100PercentOfRESMultiplier - (RESPercentage - RESPENPercentage);
        DamageTakenMultiplier = (Base100PercentOfDamageTakenMultiplier + ElementalDamageTakenPercentage + AllTypeDamageTakenPercentage);

        DamageInOutput = (BaseDamage * DamagePercentMultiplier * DefMultiplier * RESMultiplier * DamageTakenMultiplier * UniversalDamageReductionMultiplier);
        DamageOutputText.text = DamageInOutput.ToString();
    }
}