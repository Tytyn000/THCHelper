using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadInputField : MonoBehaviour
{
    //Base DMG
    public float SkillMultiplier; //dégats en % du skill 
    public float ExtraMultiplier; //Spécifique : apparait par exemple sur dang heng avec les ennemis ralentis
    public float ScalingAttribute; //Stats sur laquelle le skills scale le plus souvent c'est ATK
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
    public float AttackerLevel; //niveau de l'attaquant
    public int Flat200 = 200;
    public int Flat10 = 10;
    //pour trouver la def il faut une autre formule
    //DEF
    public float DEF; //est utiliser plus haut
    public float BaseDef; //Def de base
    public float DefReduction; //
    public float DefIgnore;
    public float DefFlat;
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

    public float InputField1DamageRepartition;
    public float InputField2DamageRepartition;
    public float InputField3DamageRepartition;
    public float InputField4DamageRepartition;
    public float InputField5DamageRepartition;
    public float InputField6DamageRepartition;
    public float InputField7DamageRepartition;

    public float BaseEnnemyLevel;
    public float SpecialEnnemyLevel;

    public DamageCalculator DamageCalculator;
    public CopyScript CopyScript;
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
        if (float.TryParse(scalingAttribute, out ScalingAttribute))
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
        if (float.TryParse(attackerLevel, out AttackerLevel))
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
        if (float.TryParse(baseDef, out BaseDef))
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
        if (float.TryParse(defFlat, out DefFlat))
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
            Debug.Log("CritRate : " + CritRate);
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
            Debug.Log("CritDamage : " + CritDamage);
        }
        else
        {
            Debug.LogError("Attention valeur non conforme pour le dgts crit");
        }
    }
    public void ReadInputField1DamageRepartition(string inputField1DamageRepartition)
    {
        switch (inputField1DamageRepartition)
        {
            case "0/7" or "0 / 7":
                InputField1DamageRepartition = 0;
                InputField1DamageRepartition *= 100;
                return;
            case "1/7"or "1 / 7":
                InputField1DamageRepartition = 1f / 7f;
                InputField1DamageRepartition *= 100;
                return;
            case "2/7" or "2 / 7":    
                InputField1DamageRepartition = 2f / 7f;
                InputField1DamageRepartition *= 100;
                return;
            case "3/7" or "3 / 7":
                InputField1DamageRepartition = 3f / 7f;
                InputField1DamageRepartition *= 100;
                return;
            case "4/7" or "4 / 7":
                InputField1DamageRepartition = 4f / 7f;
                InputField1DamageRepartition *= 100;
                return;
            case "5/7" or "5 / 7":
                InputField1DamageRepartition = 5f / 7f;
                InputField1DamageRepartition *= 100;
                return;
            case "6/7" or "6 / 7":
                InputField1DamageRepartition = 6f / 7f;
                InputField1DamageRepartition *= 100;
                return;
            case "7/7" or "7 / 7":
                InputField1DamageRepartition = 1;
                InputField1DamageRepartition *= 100;
                return;
            default:
                print("attention valeur non comprise");
                break;
        }
        if (float.TryParse(inputField1DamageRepartition, out InputField1DamageRepartition))
        {
            Debug.Log("InputField1DamageRepartition : " + InputField1DamageRepartition);
        }
    }
    public void ReadInputField2DamageRepartition(string inputField2DamageRepartition)
    {
        switch (inputField2DamageRepartition)
        {
            case "0/7" or "0 / 7":
                InputField2DamageRepartition = 0;
                return;
            case "1/7" or "1 / 7":
                InputField2DamageRepartition = 1f / 7f;
                print(InputField2DamageRepartition);
                return;
            case "2/7" or "2 / 7":
                InputField2DamageRepartition = 2f / 7f;
                InputField2DamageRepartition = InputField2DamageRepartition * 100;
                return;
            case "3/7" or "3 / 7":
                InputField2DamageRepartition = 3f / 7f;
                InputField2DamageRepartition = InputField2DamageRepartition * 100;
                return;
            case "4/7" or "4 / 7":
                InputField2DamageRepartition = 4f / 7f;
                InputField2DamageRepartition = InputField2DamageRepartition * 100;
                return;
            case "5/7" or "5 / 7":
                InputField2DamageRepartition = 5f / 7f;
                InputField2DamageRepartition = InputField2DamageRepartition * 100;
                return;
            case "6/7" or "6 / 7":
                InputField2DamageRepartition = 6f / 7f;
                InputField2DamageRepartition = InputField2DamageRepartition * 100;
                return;
            case "7/7" or "7 / 7":
                InputField2DamageRepartition = 7f / 7f;
                InputField2DamageRepartition = InputField2DamageRepartition * 100;
                return;
            default:
                print("attention valeur non comprise");
                break;
        }
        if (float.TryParse(inputField2DamageRepartition, out InputField2DamageRepartition))
        {
            Debug.Log("InputField2DamageRepartition : " + InputField2DamageRepartition);
        }
    }
    public void ReadInputField3DamageReparition(string inputField3DamageReparition)
    {
        switch (inputField3DamageReparition)
        {
            case "0/7" or "0 / 7":
                InputField3DamageRepartition = 0;
                InputField3DamageRepartition *= 100;
                return;
            case "1/7" or "1 / 7":
                InputField3DamageRepartition = 1f / 7f;
                InputField3DamageRepartition *= 100;
                return;
            case "2/7" or "2 / 7":
                InputField3DamageRepartition = 2f / 7f;
                InputField3DamageRepartition *= 100;
                return;
            case "3/7" or "3 / 7":
                InputField3DamageRepartition = 3f / 7f;
                InputField3DamageRepartition *= 100;
                return;
            case "4/7" or "4 / 7":
                InputField3DamageRepartition = 4f / 7f;
                InputField3DamageRepartition *= 100;
                return;
            case "5/7" or "5 / 7":
                InputField3DamageRepartition = 5f / 7f;
                InputField3DamageRepartition *= 100;
                return;
            case "6/7" or "6 / 7":
                InputField3DamageRepartition = 6f / 7f;
                InputField3DamageRepartition *= 100;
                return;
            case "7/7" or "7 / 7":
                InputField3DamageRepartition = 1;
                InputField3DamageRepartition *= 100;
                return;
            default:
                print("attention valeur non comprise");
                break;
        }
        if (float.TryParse(inputField3DamageReparition, out InputField3DamageRepartition))
        {
            Debug.Log("InputField3DamageRepartition : " + InputField3DamageRepartition);
        }
    }
    public void ReadInputField4DamageRepartition(string inputField4DamageRepartition)
    {
        switch (inputField4DamageRepartition)
        {
            case "0/7" or "0 / 7":
                InputField4DamageRepartition = 0;
                InputField4DamageRepartition *= 100;
                return;
            case "1/7" or "1 / 7":
                InputField4DamageRepartition = 1f / 7f;
                InputField4DamageRepartition *= 100;
                return;
            case "2/7" or "2 / 7":
                InputField4DamageRepartition = 2f / 7f;
                InputField4DamageRepartition *= 100;
                return;
            case "3/7" or "3 / 7":
                InputField4DamageRepartition = 3f / 7f;
                InputField4DamageRepartition *= 100;
                return;
            case "4/7" or "4 / 7":
                InputField4DamageRepartition = 4f / 7f;
                InputField4DamageRepartition *= 100;
                return;
            case "5/7" or "5 / 77":
                InputField4DamageRepartition = 5f / 7f;
                InputField4DamageRepartition *= 100;
                return;
            case "6/7" or "6 / 7":
                InputField4DamageRepartition = 6f / 7f;
                InputField4DamageRepartition *= 100;
                return;
            case "7/7" or "7 / 7":
                InputField4DamageRepartition = 1;
                InputField4DamageRepartition *= 100;
                return;
            default:
                print("attention valeur non comprise");
                break;
        }
        if (float.TryParse(inputField4DamageRepartition, out InputField4DamageRepartition))
        {
            Debug.Log("InputField4DamageRepartition : " + InputField4DamageRepartition);
        }
    }
    public void ReadInputField5DamageRepartition(string inputField5DamageRepartition)
    {
        switch (inputField5DamageRepartition)
        {
            case "0/7" or "0 / 7":
                InputField5DamageRepartition = 0;
                InputField5DamageRepartition *= 100;
                return;
            case "1/7" or "1 / 7":
                InputField5DamageRepartition = 1f / 7f;
                InputField5DamageRepartition *= 100;
                return;
            case "2/7" or "2 / 7":
                InputField5DamageRepartition = 2f / 7f;
                InputField5DamageRepartition *= 100;
                return;
            case "3/7" or "3 / 7":
                InputField5DamageRepartition = 3f / 7f;
                InputField5DamageRepartition *= 100;
                return;
            case "4/7" or "4 / 7":
                InputField5DamageRepartition = 4f / 7f;
                InputField5DamageRepartition *= 100;
                return;
            case "5/7" or "5 / 7":
                InputField5DamageRepartition = 5f / 7f;
                InputField5DamageRepartition *= 100;
                return;
            case "6/7" or "6 / 7":
                InputField5DamageRepartition = 6f / 7f;
                InputField5DamageRepartition *= 100;
                return;
            case "7/7" or "7 / 7":
                InputField5DamageRepartition = 1;
                InputField5DamageRepartition *= 100;
                return;
            default:
                print("attention valeur non comprise");
                break;
        }
        if (float.TryParse(inputField5DamageRepartition, out InputField5DamageRepartition))
        {
            Debug.Log("InputField5DamageRepartition : " + InputField5DamageRepartition);
        }
    }
    public void ReadInputField6DamageRepartition(string inputField6DamageRepartition)
    {
        switch (inputField6DamageRepartition)
        {
            case "0/7" or "0 / 7":
                InputField6DamageRepartition = 0;
                InputField6DamageRepartition *= 100;
                return;
            case "1/7" or "1 / 20":
                InputField6DamageRepartition = 1f / 7f;
                InputField6DamageRepartition *= 100;
                return;
            case "2/7" or "2 / 7":
                InputField6DamageRepartition = 2f / 7f;
                InputField6DamageRepartition *= 100;
                return;
            case "3/7" or "3 / 7":
                InputField6DamageRepartition = 3f / 7f;
                InputField6DamageRepartition *= 100;
                return;
            case "4/7" or "4 / 7":
                InputField6DamageRepartition = 4f / 7f;
                InputField6DamageRepartition *= 100;
                return;
            case "5/7" or "5 / 7":
                InputField6DamageRepartition = 5f / 7f;
                InputField6DamageRepartition *= 100;
                return;
            case "6/7" or "6 / 7":
                InputField6DamageRepartition = 6f / 7f;
                InputField6DamageRepartition *= 100;
                return;
            case "7/7" or "7 / 7":
                InputField6DamageRepartition = 1;
                InputField6DamageRepartition *= 100;
                return;
            default:
                print("attention valeur non comprise");
                break;
        }
        if (float.TryParse(inputField6DamageRepartition, out InputField6DamageRepartition))
        {
            Debug.Log("InputField6DamageRepartition : " + InputField6DamageRepartition);
        }
    }
    public void ReadInputField7DamageRepartition(string inputField7DamageRepartition)
    {
        switch (inputField7DamageRepartition)
        {
            case "0/7" or "0 / 7":
                InputField7DamageRepartition = 0;
                InputField7DamageRepartition *= 100;
                return;
            case "1/7" or "1 / 20":
                InputField7DamageRepartition = 1f / 7f;
                InputField7DamageRepartition *= 100;
                return;
            case "2/7" or "2 / 20":
                InputField7DamageRepartition = 2f / 7f;
                InputField7DamageRepartition *= 100;
                return;
            case "3/7" or "3 / 7":
                InputField7DamageRepartition = 3f / 7f;
                InputField7DamageRepartition *= 100;
                return;
            case "4/7" or "4 / 7":
                InputField7DamageRepartition = 4f / 7f;
                InputField7DamageRepartition *= 100;
                return;
            case "5/7" or "5 / 7":
                InputField7DamageRepartition = 5f / 7f;
                InputField7DamageRepartition *= 100;
                return;
            case "6/7" or "6 / 7":
                InputField7DamageRepartition = 6f / 7f;
                InputField7DamageRepartition *= 100;
                return;
            case "7/7" or "7 / 7":
                InputField7DamageRepartition = 1;
                InputField7DamageRepartition *= 100;
                return;
            default:
                print("attention valeur non comprise");
                break;
        }
        if (float.TryParse(inputField7DamageRepartition, out InputField7DamageRepartition))
        {
            Debug.Log("InputField7DamageRepartition : " + InputField7DamageRepartition);
        }
    }

    public void ReadBaseEnnemyDef(string baseEnnemyDef)
    {
        if (float.TryParse(baseEnnemyDef, out BaseEnnemyLevel))
        {
            print("BaseEnnemyLevel : " + BaseEnnemyLevel);
            CopyScript.ComputeBaseEnnemyDef();
        }
    }
    public void ReadSpecialEnnemyDef(string specialEnnemyDef)
    {
        if (float.TryParse(specialEnnemyDef, out SpecialEnnemyLevel))
        {
            print("SpecialEnnemyLevel : " +  SpecialEnnemyLevel);
            CopyScript.ComputeSpecialEnnemyDef();
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

        DamageCalculator.DamageRepartitionAtHit1 = (InputField1DamageRepartition / 100);
        DamageCalculator.DamageRepartitionAtHit2 = (InputField2DamageRepartition / 100);
        DamageCalculator.DamageRepartitionAtHit3 = (InputField3DamageRepartition / 100);
        DamageCalculator.DamageRepartitionAtHit4 = (InputField4DamageRepartition / 100);
        DamageCalculator.DamageRepartitionAtHit5 = (InputField5DamageRepartition / 100);
        DamageCalculator.DamageRepartitionAtHit6 = (InputField6DamageRepartition / 100);
        DamageCalculator.DamageRepartitionAtHit7 = (InputField7DamageRepartition / 100);

        DamageCalculator.BaseEnnemyLevel = BaseEnnemyLevel;
        DamageCalculator.SpecialEnnemyLevel = SpecialEnnemyLevel;

        DamageCalculator.BaseEnnemyDef = CopyScript.BaseEnnemyDef;
        DamageCalculator.SpecialEnnemyDef = CopyScript.SpecialEnnemyDef;

        DamageCalculator.SaveinPlayerPrefs();
    }
}
