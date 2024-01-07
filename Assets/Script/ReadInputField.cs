using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadInputField : MonoBehaviour
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

    public float DMGPercentMultiplier;

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

    //WeakenMultiplier
    public static float Base100PercentOfWeakenMultiplier = 1.00f;//toujours 1
    public float WeakenMultiplierPercentage;

    public float CritRate;
    public float CritDamage;

    public DamageCalculator DamageCalculator;
    void Start()
    {
        print("Utiliser , a la place des . pour séparer");
    }

    void Update()
    {
        
    }
    public void ReadSkillMultiplierInInputField(string skillMultiplier)
    {
        if (float.TryParse(skillMultiplier, out SkillMultiplier))
        {
            Debug.Log("SkillMultiplier : " + SkillMultiplier);
        }
        else
        {
            Debug.LogError("Attention valeur non conforme pour le SkillMultiplier");
        }
    }
    public void ReadExtraMultiplierInInputField(string extraMultiplier)
    {
        if (float.TryParse(extraMultiplier, out ExtraMultiplier))
        {
            Debug.Log("ExtraMultiplier : " + ExtraMultiplier);
        }
        else
        {
            Debug.LogError("Attention valeur non conforme pour le ExtraMultiplier");
        }
    }
    public void ReadScalingAttributeInInputField(string scalingAttribute)
    {
        if (int.TryParse(scalingAttribute, out ScalingAttribute))
        {
            Debug.Log("ScalingAttribute : " + ScalingAttribute);
        }
        else
        {
            Debug.LogError("Attention valeur non conforme pour le ScalingAttribute");
        }
    }
    public void ReadExtraDamageInInputField(string extraDamage)
    {
        if (float.TryParse(extraDamage, out ExtraDamage))
        {
            Debug.Log("ExtraDMG : " + ExtraDamage);
        }
        else
        {
            Debug.LogError("Attention valeur non conforme pour le ExtraDMG");
        }
    }

    public void ReadElementalDamagePercentInInputField(string elementalDamagePercent)
    {
        if (float.TryParse(elementalDamagePercent, out ElementalDamagePercent))
        {
            Debug.Log("ElementalDMGPercent : " + ElementalDamagePercent);
        }
        else
        {
            Debug.LogError("Attention valeur non conforme pour le ElementalDMGPercent");
        }
    }
    public void ReadAllTypeDamagePercentInInputField(string allTypeDamagePercent)
    {
        if (float.TryParse(allTypeDamagePercent, out AllTypeDamagePercent))
        {
            Debug.Log("AllTypeDMGPercent : " + AllTypeDamagePercent);
        }
        else
        {
            Debug.LogError("Attention valeur non conforme pour le AllTypeDamagePercent");
        }
    }
    public void ReadDOTDamagePercentInInputField(string dotDamagePercent)
    {
        if (float.TryParse(dotDamagePercent, out DOTDamagePercent))
        {
            Debug.Log("DOTDamagePercent : " + DOTDamagePercent);
        }
        else
        {
            Debug.LogError("Attention valeur non conforme pour le DOTDamagePercent");
        }
    }
    public void ReadOtherDamagePercentInInputField(string otherDamagePercent)
    {
        if (float.TryParse(otherDamagePercent, out OtherDamagePercent))
        {
            Debug.Log("OtherDamagePercent : " + OtherDamagePercent);
        }
        else
        {
            Debug.LogError("Attention valeur non conforme pour le OtherDMGPercent");
        }
    }

    public void ReadAttackerLevelInInputField(string attackerLevel)
    {
        if (int.TryParse(attackerLevel, out AttackerLevel))
        {
            Debug.Log("AttackerLevel : " + AttackerLevel);
        }
        else
        {
            Debug.LogError("Attention valeur non conforme pour la BaseDef");
        }
    }

    public void ReadBaseDefInInputField(string baseDef)
    {
        if (int.TryParse(baseDef, out BaseDef))
        {
            Debug.Log("BaseDef : " + BaseDef);
        }
        else
        {
            Debug.LogError("Attention valeur non conforme pour la BaseDef");
        }
    }
    public void ReadDefReductionInInputField(string defReduction)
    {
        if (float.TryParse(defReduction, out DefReduction))
        {
            Debug.Log("DefReduction : " +  DefReduction);
        }
        else
        {
            Debug.LogError("Attention valeur non conforme pour la DefReduction");
        }
    }
    public void ReadDefIgnoreInInputField(string defIgnore)
    {
        if (float.TryParse(defIgnore, out DefIgnore))
        {
            Debug.Log("DefIgnore : " + DefIgnore);
        }
        else
        {
            Debug.LogError("Attention valeur non conforme pour la DefIgnore");
        }
    }
    public void ReadDefFlatInInputField(string defFlat)
    {
        if (int.TryParse(defFlat, out DefFlat))
        {
            Debug.Log("DefFlat : " + DefFlat);
        }
        else
        {
            Debug.LogError("Attention valeur non conforme pour la DefFlat");
        }
    }

    public void ReadRESPercentageInInputField(string resPercentage)
    {
        if (float.TryParse(resPercentage, out RESPercentage))
        {
            Debug.Log("RESPercentage : " + RESPercentage);
        }
        else
        {
            Debug.LogError("Attention valeur non conforme pour le RESPercentage");
        }
    }
    public void ReadRESPENPercentageInInputField(string resPENPercentage)
    {
        if (float.TryParse(resPENPercentage, out RESPENPercentage))
        {
            Debug.Log("RESPENPercentage : " + RESPENPercentage);
        }
        else
        {
            Debug.LogError("Attention valeur non conforme pour la RESPENPercentage");
        }
    }

    public void ReadElementalDMGTakenPercentInInputField(string elementalDMGTakenPercentage)
    {
        if (float.TryParse(elementalDMGTakenPercentage, out ElementalDamageTakenPercentage))
        {
            Debug.Log("ElementalDMGTakenPercentage : " + ElementalDamageTakenPercentage);
        }
        else
        {
            Debug.LogError("Attention valeur non conforme pour le ElementalDMGTakenPercentage");
        }
    }
    public void ReadAllTypeDMGTakenPercentageInInputField(string allTypeDMGTakenPercent)
    {
        if (float.TryParse(allTypeDMGTakenPercent, out AllTypeDamageTakenPercentage))
        {
            Debug.Log("AllTypeDMGTakenPercentage : " + AllTypeDamageTakenPercentage);
        }
        else
        {
            Debug.LogError("Attention valeur non conforme pour le AllTypeDMGTakenPercentage");
        }
    }
    public void ReadUniversalDMGReductionMultiplier(string universalDMGReductionMultiplier)
    {
        if (float.TryParse(universalDMGReductionMultiplier, out UniversalDamageReductionMultiplier))
        {
            Debug.Log("UniversalDMGReductionMultiplier : " + UniversalDamageReductionMultiplier);
        }
        else
        {
            Debug.LogError("Attention valeur non conforme pour le UniversalDMGReductionMultiplier");
        }
    }
    public void ReadWeakenMultiplierPercentage(string weakenMultiplierPercentage)
    {
        if (float.TryParse(weakenMultiplierPercentage, out WeakenMultiplierPercentage))
        {
            Debug.Log("WeakenMultiplierPercentage : " + WeakenMultiplierPercentage);
        }
        else
        {
            Debug.LogError("Attention valeur non conforme pour le WeakenMultiplierPercentage");
        }
    }
    public void ReadCritRate(string critRate)
    {
        if (float.TryParse(critRate, out CritRate))
        {

        }
        else
        {
            Debug.LogError("Attention valeur non conforme pour le tc");
        }
    }
    public void ReadCritDamage(string critDamage)
    {
        if (float.TryParse(critDamage, out CritDamage))
        {

        }
        else
        {
            Debug.LogError("Attention valeur non conforme pour le dgts crit");
        }
    }

    public void SaveCurrentData()//enregistre et envoie les données
    {
        DamageCalculator.SkillMultiplier = (SkillMultiplier / 100);
        DamageCalculator.ExtraMultiplier = (ExtraMultiplier / 100);
        DamageCalculator.ScalingAttribute = ScalingAttribute;
        DamageCalculator.ExtraDamage = ExtraDamage;

        DamageCalculator.ElementalDamagePercent = (ElementalDamagePercent / 100);
        DamageCalculator.AllTypeDamagePercent = (AllTypeDamagePercent / 100);
        DamageCalculator.DOTDamagePercent = (DOTDamagePercent / 100);
        DamageCalculator.OtherDamagePercent = (OtherDamagePercent / 100);

        DamageCalculator.BaseDef = BaseDef;
        DamageCalculator.DefReduction = (DefReduction / 100);
        DamageCalculator.DefIgnore = (DefIgnore / 100);
        DamageCalculator.DefFlat = DefFlat;
        DamageCalculator.AttackerLevel = AttackerLevel;

        DamageCalculator.RESPercentage = (RESPercentage / 100);
        DamageCalculator.RESPENPercentage = (RESPENPercentage / 100);

        DamageCalculator.ElementalDamageTakenPercentage = (ElementalDamageTakenPercentage / 100);
        DamageCalculator.AllTypeDamageTakenPercentage = (AllTypeDamageTakenPercentage / 100);

        DamageCalculator.UniversalDamageReductionMultiplier = (UniversalDamageReductionMultiplier / 100);

        DamageCalculator.WeakenMultiplierPercentage = (WeakenMultiplierPercentage / 100);

        DamageCalculator.CritRate = CritRate;
        DamageCalculator.CritDamage = (CritDamage / 100);
    }
}
