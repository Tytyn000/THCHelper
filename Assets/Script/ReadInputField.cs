using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ReadInputField : MonoBehaviour
{
    //Dégats classique :

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
    //pour trouver la def il faut une autre formule
    //DEF
    public float DEF; //est utiliser plus haut
    public float BaseDef; //Def de base
    public float DefReduction; //
    public float DefIgnore;
    public float DefFlat;

    public float DefMultiplier;

    //RES MULTIPLIER
    public static float Base100PercentOfRESMultiplier = 1.00f; //toujours 1
    public float RESPercentage; //Tout les ennemis ont 20% de res donc 80%. Sauf si il y a une faiblesse c'est 0% a cette élément donc 100%. Si il est résistant il a 40% de res a cette élément donc 60%.La RES ne peut pas aller sous -100% et ne pas dépasser environ 90%
    public float RESPENPercentage;

    public float RESMultiplier;

    //DMGTakenMultiplier
    public float ElementalDamageTakenPercentage;
    public float AllTypeDamageTakenPercentage;

    public float DamageTakenMultiplier; //ne peut dépasser 350%

    //Universal DMG Reduction Multiplier
    public float UniversalDamageReductionMultiplier;

    //Broken Multiplier
    public float BrokenMultiplier;

    //WeakenMultiplier
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
    public float InputField8DamageRepartition;
    public float InputField9DamageRepartition;
    public float InputField10DamageRepartition;

    public float BaseEnnemyLevel;
    public float SpecialEnnemyLevel;

    public DamageCalculator DamageCalculator;
    public CopyScript CopyScript;

    //Dégats de break :
    //Certaines variables sont communes avec les dégats classique

    //BaseDamage
    public float AbilityMultiplier;
    public float BreakElementMultiplier;
    public float TargetToughness;

    public float BreakEffect;
    public float BreakDamageIncrease;

    //VulnerabilityMultiplier
    public float TypeToThisElementVulnerability;//ex, une faiblesse uniquement au feu
    public float AllTypeVulnerability;
    public float BreakDamageVulnerability;
    public float DotDamageVulnerability;

    //Dégats de SuperBreak :
    //Certaines variables sont communes avec les dégats classique et break

    //ToughnessReduction
    public float BaseToughnessReduction;
    public float AdditiveToughnessReduction;
    public float ToughnessReductionIncrease;
    public float WeaknessBreakEfficiency;
    public float ToughnessVulnerability;

    public float SuperBreakDamageIncrease;

    //Dégats d'Allégresse

    //Base Damage
    public float Elation;

    //Punchline Multiplier
    public float CertifiedBanger;
    public float Punchline;
    public string PunchlineMultiplierSource;

    //Merrymake Multiplier
    public float MerryMake;

    //Autres :

    public string DamageType;

    public bool BreakOnHit1;
    public bool SuperBreakOnHit1;
    public bool ElationOnHit1;

    public bool BreakOnHit2;
    public bool SuperBreakOnHit2;
    public bool ElationOnHit2;

    public bool BreakOnHit3;
    public bool SuperBreakOnHit3;
    public bool ElationOnHit3;

    public bool BreakOnHit4;
    public bool SuperBreakOnHit4;
    public bool ElationOnHit4;

    public bool BreakOnHit5;
    public bool SuperBreakOnHit5;
    public bool ElationOnHit5;

    public bool BreakOnHit6;
    public bool SuperBreakOnHit6;
    public bool ElationOnHit6;

    public bool BreakOnHit7;
    public bool SuperBreakOnHit7;
    public bool ElationOnHit7;

    public bool BreakOnHit8;
    public bool SuperBreakOnHit8;
    public bool ElationOnHit8;

    public bool BreakOnHit9;
    public bool SuperBreakOnHit9;
    public bool ElationOnHit9;

    public bool BreakOnHit10;
    public bool SuperBreakOnHit10;
    public bool ElationOnHit10;

    void Start()
    {
        print("Utiliser , a la place des . pour séparer");
    }

    void Update()
    {

    }

    //Lecture du champ des dégats classique

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
    /*public void ReadDOTDamagePercentInInputField(string dotDamagePercent)
    {
        if (float.TryParse(dotDamagePercent, out DOTDamagePercent))
        {
            Debug.Log("DOTDamagePercent : " + DOTDamagePercent);
        }
        else
        {
            Debug.LogError("Attention valeur non conforme pour le DOTDamagePercent");
        }
    }*/
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
    public void ReadBrokenMultiplier(string brokenMultiplier)
    {
        if (float.TryParse(brokenMultiplier, out BrokenMultiplier))
        {
            Debug.Log("BrokenMultiplier : " + BrokenMultiplier);
        }
        else
        {
            Debug.LogError("Attention valeur non conforme pour le BrokenMultiplier");
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

    //Lecture du champ des dégats de break

    public void ReadAbilityMultiplier(string abilityMultiplier)//100 si pas précisé, Ability Multiplier != Skill Multiplier [...] Commun au SuperBreak
    {
        if (float.TryParse(abilityMultiplier, out AbilityMultiplier))
        {
            Debug.Log("AbilityMultiplier : " + AbilityMultiplier);
        }
        else
        {
            Debug.LogError("Valeur non conforme pour AbilityMultiplier");
        }
    }
    
    public void ReadTargetToughness(string targetToughness)
    {
        if (float.TryParse(targetToughness, out TargetToughness))
        {
            Debug.Log("TargetToughness : " + TargetToughness);
        }
        else
        {
            Debug.LogError("Valeur non conforme pour la TargetToughness");
        }
    }

    public void ReadBreakElement(Dropdown dropdown)
    {
        BreakElementMultiplier = 2f;//Physique par défaut
        int index = dropdown.value;
        switch (index)
        {
            case 0:
                BreakElementMultiplier = 2f;//Physique
                break;
            case 1:
                BreakElementMultiplier = 2f;//Feu
                print("Feu");
                break;
            case 2:
                BreakElementMultiplier = 1f;//Glace
                break;
            case 3:
                BreakElementMultiplier = 1f;//Foudre
                break;
            case 4:
                BreakElementMultiplier = 1.5f;//Vent
                break;
            case 5:
                BreakElementMultiplier = 0.5f;//Quantique
                break;
            case 6:
                BreakElementMultiplier = 0.5f;//Imaginaire
                break;
            default:
                print("Element non existant");
                break;
        }
    }

    public void ReadBreakEffet(string breakEffect)
    {
        if (float.TryParse(breakEffect, out BreakEffect))
        {
            Debug.Log("BreakEffect : " + BreakEffect);
        }
        else
        {
            Debug.LogError("Valeur non conforme pour le BreakEffect");
        }
    }
    public void ReadBreakDamageIncrease(string breakDamageIncrease)
    {
        if (float.TryParse(breakDamageIncrease, out BreakDamageIncrease))
        {
            Debug.Log("BreakDamageIncrease : " + BreakDamageIncrease);
        }
        else
        {
            Debug.LogError("Valeur non conforme pour le BreakDamageIncrease");
        }
    }
    public void ReadTypeToThisElementVulnerability(string typeToThisElementVulnerability)
    {
        if (float.TryParse(typeToThisElementVulnerability, out TypeToThisElementVulnerability))
        {
            Debug.Log("TypeToThisElementVulnerability : " + TypeToThisElementVulnerability);
        }
        else
        {
            Debug.LogError("Valeur non conforme pour le TypeToThisElementVulnerability");
        }
    }
    public void ReadAllTypeVulnerability(string allTypeVulnerability)
    {
        if (float.TryParse(allTypeVulnerability, out AllTypeVulnerability))
        {
            Debug.Log("AllTypeVulnerability : " + AllTypeVulnerability);
        }
        else
        {
            Debug.LogError("Valeur non conforme pour le AllTypeVulnerability");
        }
    }
    public void ReadBreakDamageVulnerability(string breakDamageVulnerability)//uniquement pour break et pas dot
    {
        if (float.TryParse(breakDamageVulnerability, out BreakDamageVulnerability))
        {
            Debug.Log("BreakDamageVulnerability : " + BreakDamageVulnerability);
        }
        else
        {
            Debug.LogError("Valeur non conforme pour le BreakDamageVulnerability");
        }
    }
    public void ReadDotDamageVulnerability(string dotDamageVulnerability)//uniquement pour dot et pas break
    {
        if (float.TryParse(dotDamageVulnerability, out DotDamageVulnerability))
        {
            Debug.Log("DotDamageVulnerability : " + DotDamageVulnerability);
        }
        else
        {
            Debug.LogError("Valeur non conforme pour le DotDamageVulnerability");
        }
    }

    //Lecture du champ des dégats de superbreak

    public void ReadBaseToughnessReduction(string baseToughnessReduction)
    {
        if (float.TryParse(baseToughnessReduction, out BaseToughnessReduction))
        {
            Debug.Log("BaseToughnessReduction : " + BaseToughnessReduction);
        }
        else
        {
            Debug.LogError("Valeur non conforme pour le BaseToughnessReduction");
        }
    }
    public void ReadAdditiveToughnessReduction(string additiveToughnessReduction)
    {
        if (float.TryParse(additiveToughnessReduction, out AdditiveToughnessReduction))
        {
            Debug.Log("AdditiveToughnessReduction : " + AdditiveToughnessReduction);
        }
        else
        {
            Debug.LogError("Valeur non conforme pour le AdditiveToughnessReduction");
        }
    }
    public void ReadToughnessReductionIncrease(string toughnessReductionIncrease)
    {
        if (float.TryParse(toughnessReductionIncrease, out ToughnessReductionIncrease))
        {
            Debug.Log("ToughnessReductionIncrease : " + ToughnessReductionIncrease);
        }
        else
        {
            Debug.LogError("Valeur non conforme pour le ToughnessReductionIncrease");
        }
    }
    public void ReadWeaknessBreakEfficiency(string weaknessBreakEfficiency)
    {
        if (float.TryParse(weaknessBreakEfficiency, out WeaknessBreakEfficiency))
        {
            Debug.Log("WeaknessBreakEfficiency : " + WeaknessBreakEfficiency);
        }
        else
        {
            Debug.LogError("Valeur non conforme pour le WeaknessBreakEfficiency");
        }
    }
    public void ReadToughnessVulnerability(string toughnessVulnerability)
    {
        if (float.TryParse(toughnessVulnerability, out ToughnessVulnerability))
        {
            Debug.Log("ToughnessVulnerability : " + ToughnessVulnerability);
        }
        else
        {
            Debug.LogError("Valeur non conforme pour le ToughnessVulnerability");
        }
    }
    public void ReadSuperBreakDamageIncrease(string superBreakDamageIncrease)
    {
        if (float.TryParse(superBreakDamageIncrease, out SuperBreakDamageIncrease))
        {
            Debug.Log("SuperBreakDamageIncrease : " + SuperBreakDamageIncrease);
        }
        else
        {
            Debug.LogError("Valeur non conforme pour le SuperBreakDamageIncrease");
        }
    }

    //Lecture du champ des dégâts d'Allégresse 

    public void ReadElationInputField(string elation)
    {
        if (float.TryParse(elation, out Elation))
        {
            Debug.Log("Elation :" + Elation);
        }
        else
        {
            Debug.LogError("Valeur non conforme pour l'Allégresse");
        }
    }

    public void ReadCertifiedBangerInputField(string certifiedBanger)
    {
        if (float.TryParse(certifiedBanger, out CertifiedBanger))
        {
            Debug.Log("CertifiedBanger : " + CertifiedBanger);
        }
        else
        {
            Debug.LogError("Valeur non conforme pour CertifiedBanger");
        }
    }
    public void ReadPunchlineInputField(string punchline)
    {
        if (float.TryParse(punchline, out Punchline))
        {
            Debug.Log("Punchline : " + Punchline);
        }
        else
        {
            Debug.LogError("Valeur non conforme pour Punchline");
        }
    }
    public void ReadPunchlineMultiplierSource(Dropdown dropdown)
    {
        PunchlineMultiplierSource = "CertifiedBangerState";
        int index = dropdown.value;
        switch (index)
        {
            case 0:
                PunchlineMultiplierSource = "CertifiedBangerState";
                break;
            case 1:
                PunchlineMultiplierSource = "Other";
                break;
            default:
                Debug.LogError("Valeur incorrecte pour CertifiedBangerState");
                break;
        }
    }

    public void ReadMerrymakeMultiplierInputField(string merryMakeMultiplier)
    {
        if (float.TryParse(merryMakeMultiplier, out MerryMake))
        {
            Debug.Log("MerryMakeMultiplier : " + MerryMake);
        }
        else
        {
            Debug.LogError("Valeur non conforme pour le MerryMakeMultiplier");
        }
    }

    //Lecture du champ des résultats

    public void ReadInputField1DamageRepartition(string inputField1DamageRepartition)
    {
        if (float.TryParse(inputField1DamageRepartition, out InputField1DamageRepartition))
        {
            Debug.Log("InputField1DamageRepartition : " + InputField1DamageRepartition);
        }
        else
        {
            Debug.LogError("Valeur non conforme pour InputField1DamageRepartition");
        }
    }
    public void ReadInputField2DamageRepartition(string inputField2DamageRepartition)
    {
        if (float.TryParse(inputField2DamageRepartition, out InputField2DamageRepartition))
        {
            Debug.Log("InputField2DamageRepartition : " + InputField2DamageRepartition);
        }
        else
        {
            Debug.LogError("Valeur non conforme pour InputField2DamageRepartition");
        }
    }
    public void ReadInputField3DamageReparition(string inputField3DamageReparition)
    {
        if (float.TryParse(inputField3DamageReparition, out InputField3DamageRepartition))
        {
            Debug.Log("InputField3DamageRepartition : " + InputField3DamageRepartition);
        }
        else
        {
            Debug.LogError("Valeur non conforme pour InputField3DamageRepartition");
        }
    }
    public void ReadInputField4DamageRepartition(string inputField4DamageRepartition)
    {
        if (float.TryParse(inputField4DamageRepartition, out InputField4DamageRepartition))
        {
            Debug.Log("InputField4DamageRepartition : " + InputField4DamageRepartition);
        }
        else
        {
            Debug.LogError("Valeur non conforme pour InputField4DamageRepartition");
        }
    }
    public void ReadInputField5DamageRepartition(string inputField5DamageRepartition)
    {
        if (float.TryParse(inputField5DamageRepartition, out InputField5DamageRepartition))
        {
            Debug.Log("InputField5DamageRepartition : " + InputField5DamageRepartition);
        }
        else
        {
            Debug.LogError("Valeur non conforme pour InputField5DamageRepartition");
        }
    }
    public void ReadInputField6DamageRepartition(string inputField6DamageRepartition)
    {
        if (float.TryParse(inputField6DamageRepartition, out InputField6DamageRepartition))
        {
            Debug.Log("InputField6DamageRepartition : " + InputField6DamageRepartition);
        }
        else
        {
            Debug.LogError("Valeur non conforme pour InputField6DamageRepartition");
        }
    }
    public void ReadInputField7DamageRepartition(string inputField7DamageRepartition)
    {
        if (float.TryParse(inputField7DamageRepartition, out InputField7DamageRepartition))
        {
            Debug.Log("InputField7DamageRepartition : " + InputField7DamageRepartition);
        }
        else
        {
            Debug.LogError("Valeur non conforme pour InputField7DamageRepartition");
        }
    }
    public void ReadInputField8DamageRepartition(string inputfield8DamageRepartition)
    {
        if (float.TryParse(inputfield8DamageRepartition, out InputField8DamageRepartition))
        {
            Debug.Log("InputField8DamageRepartition :" + InputField8DamageRepartition);
        }
        else
        {
            Debug.LogError("Valeur non conforme pour InputField8DamageRepartition");
        }
    }
    public void ReadInputField9DamageRepartition(string inputfield9DamageRepartition)
    {
        if (float.TryParse(inputfield9DamageRepartition, out InputField9DamageRepartition))
        {
            Debug.Log("InputField9DamageRepartition :" + InputField9DamageRepartition);
        }
        else
        {
            Debug.LogError("Valeur non conforme pour InputField9DamageRepartition");
        }
    }
    public void ReadInputField10DamageRepartition(string inputfield10DamageRepartition)
    {
        if (float.TryParse(inputfield10DamageRepartition, out InputField10DamageRepartition))
        {
            Debug.Log("InputField10DamageRepartition : " + InputField10DamageRepartition);
        }
        else
        {
            Debug.LogError("Valeur non conforme pour InputField10DamageRepartition");
        }
    }

    public void ReadDamageType(Dropdown dropdown)
    {
        DamageType = "RegularDamage";
        int index = dropdown.value;
        switch (dropdown.value)
        {
            case 0:
                DamageType = "RegularDamage";
                break;
            case 1:
                DamageType = "BreakDamage";
                break;
            case 2:
                DamageType = "SuperBreakDamage";
                break;
            case 3:
                DamageType = "ElationDamage";
                break;
            default:
                print("DamageType non existant");
                break;
        }
        print(DamageType);
    }

    public void ReadDamageAtHit1BreakToggleState(Toggle toggle)
    {
        BreakOnHit1 = toggle.isOn;
    }
    public void ReadDamageAtHit1SuperBreakToggleState(Toggle toggle)
    {
        SuperBreakOnHit1 = toggle.isOn;
    }
    public void ReadDamageAtHit1ElationToggleState(Toggle toggle)
    {
        ElationOnHit1 = toggle.isOn;
    }

    public void ReadDamageAtHit2BreakToggleState(Toggle toggle)
    {
        BreakOnHit2 = toggle.isOn;
    }
    public void ReadDamageAtHit2SuperBreakToggleState(Toggle toggle)
    {
        SuperBreakOnHit2 = toggle.isOn;
    }
    public void ReadDamageAtHit2ElationToggleState(Toggle toggle)
    {
        ElationOnHit2 = toggle.isOn;
    }

    public void ReadDamageAtHit3BreakToggleState(Toggle toggle)
    {
        BreakOnHit3 = toggle.isOn;
    }
    public void ReadDamageAtHit3SuperBreakToggleState(Toggle toggle)
    {
        SuperBreakOnHit3 = toggle.isOn;
    }
    public void ReadDamageAtHit3ElationToggleState(Toggle toggle)
    {
        ElationOnHit3 = toggle.isOn;
    }

    public void ReadDamageAtHit4BreakToggleState(Toggle toggle)
    {
            BreakOnHit4 = toggle.isOn;
    }
    public void ReadDamageAtHit4SuperBreakToggleState(Toggle toggle)
    {
        SuperBreakOnHit4 = toggle.isOn;
    }
    public void ReadDamageAtHit4ElationToggleState(Toggle toggle)
    {
        ElationOnHit4 = toggle.isOn;
    }

    public void ReadDamageAtHit5BreakToggleState(Toggle toggle)
    {
        BreakOnHit5 = toggle.isOn;
    }
    public void ReadDamageAtHit5SuperBreakToggleState(Toggle toggle)
    {
        SuperBreakOnHit5 = toggle.isOn;
    }
    public void ReadDamageAtHit5ElationToggleState(Toggle toggle)
    {
        ElationOnHit5 = toggle.isOn;
    }

    public void ReadDamageAtHit6BreakToggleState(Toggle toggle)
    {
        BreakOnHit6 = toggle.isOn;
    }
    public void ReadDamageAtHit6SuperBreakToggleState(Toggle toggle)
    {
        SuperBreakOnHit6 = toggle.isOn;
    }
    public void ReadDamageAtHit6ElationToggleState(Toggle toggle)
    {
        ElationOnHit6 = toggle.isOn;
    }

    public void ReadDamageAtHit7BreakToggleState(Toggle toggle)
    {
        BreakOnHit7 = toggle.isOn;
    }
    public void ReadDamageAtHit7SuperBreakToggleState(Toggle toggle)
    {
        SuperBreakOnHit7 = toggle.isOn;
    }
    public void ReadDamageAtHit7ElationToggleState(Toggle toggle)
    {
        ElationOnHit7 = toggle.isOn;
    }

    public void ReadDamageAtHit8BreakToggleState(Toggle toggle)
    {
        BreakOnHit8 = toggle.isOn;
    }
    public void ReadDamageAtHit8SuperBreakToggleState(Toggle toggle)
    {
        SuperBreakOnHit8 = toggle.isOn;
    }
    public void ReadDamageAtHit8ElationToggleState(Toggle toggle)
    {
        ElationOnHit8 = toggle.isOn;
    }

    public void ReadDamageAtHit9BreakToggleState(Toggle toggle)
    {
        BreakOnHit9 = toggle.isOn;
    }
    public void ReadDamageAtHit9SuperBreakToggleState(Toggle toggle)
    {
        SuperBreakOnHit9 = toggle.isOn;
    }
    public void ReadDamageAtHit9ElationToggleState(Toggle toggle)
    {
        ElationOnHit9 = toggle.isOn;
    }

    public void ReadDamageAtHit10BreakToggleState(Toggle toggle)
    {
        BreakOnHit10 = toggle.isOn;
    }
    public void ReadDamageAtHit10SuperBreakToggleState(Toggle toggle)
    {
        SuperBreakOnHit10 = toggle.isOn;
    }
    public void ReadDamageAtHit10ElationToggleState(Toggle toggle)
    {
        ElationOnHit10 = toggle.isOn;
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
        //Dégats classique :
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

        DamageCalculator.BrokenMultiplier = (BrokenMultiplier / 100);

        DamageCalculator.WeakenMultiplierPercentage = (WeakenMultiplierPercentage / 100);

        DamageCalculator.CritRate = CritRate;
        DamageCalculator.CritDamage = (CritDamage / 100);

        //dégats de Break :

        DamageCalculator.AbilityMultiplier = (AbilityMultiplier / 100);
        DamageCalculator.BreakElementMultiplier = BreakElementMultiplier;
        DamageCalculator.TargetToughness = TargetToughness;

        DamageCalculator.BreakEffect = (BreakEffect / 100);
        DamageCalculator.BreakDamageIncrease = (BreakDamageIncrease / 100);

        DamageCalculator.TypeToThisElementVulnerability = (TypeToThisElementVulnerability / 100);
        DamageCalculator.AllTypeVulnerability = (AllTypeVulnerability / 100);
        DamageCalculator.BreakDamageVulnerability = (BreakDamageVulnerability / 100);
        DamageCalculator.DotDamageVulnerability = (DotDamageVulnerability / 100);

        //dégats de SuperBreak :

        DamageCalculator.BaseToughnessReduction = BaseToughnessReduction;
        DamageCalculator.AdditiveToughnessReduction = AdditiveToughnessReduction;
        DamageCalculator.ToughnessReductionIncrease = (ToughnessReductionIncrease / 100);
        DamageCalculator.WeaknessBreakEfficiency = (WeaknessBreakEfficiency / 100);
        DamageCalculator.ToughnessVulnerability = (ToughnessVulnerability / 100);

        DamageCalculator.SuperBreakDamageIncrease = (SuperBreakDamageIncrease / 100);

        //dégâts d'Allégresse 

        DamageCalculator.Elation = (Elation / 100);

        DamageCalculator.CertifiedBanger = (CertifiedBanger / 100);
        DamageCalculator.Punchline = (Punchline / 100);
        DamageCalculator.PunchlineMultiplierSource = PunchlineMultiplierSource;

        DamageCalculator.MerryMake = (MerryMake / 100);

        //Autres :

        DamageCalculator.DamageType = DamageType;

        DamageCalculator.BreakOnHit1 = BreakOnHit1;
        DamageCalculator.SuperBreakOnHit1 = SuperBreakOnHit1;
        DamageCalculator.ElationOnHit1 = ElationOnHit1;

        DamageCalculator.BreakOnHit2 = BreakOnHit2;
        DamageCalculator.SuperBreakOnHit2 = SuperBreakOnHit2;
        DamageCalculator.ElationOnHit2 = ElationOnHit2;

        DamageCalculator.BreakOnHit3 = BreakOnHit3;
        DamageCalculator.SuperBreakOnHit3 = SuperBreakOnHit3;
        DamageCalculator.ElationOnHit3 = ElationOnHit3;

        DamageCalculator.BreakOnHit4 = BreakOnHit4;
        DamageCalculator.SuperBreakOnHit4 = SuperBreakOnHit4;
        DamageCalculator.ElationOnHit4 = ElationOnHit4;

        DamageCalculator.BreakOnHit5 = BreakOnHit5;
        DamageCalculator.SuperBreakOnHit5 = SuperBreakOnHit5;
        DamageCalculator.ElationOnHit5 = ElationOnHit5;

        DamageCalculator.BreakOnHit6 = BreakOnHit6;
        DamageCalculator.SuperBreakOnHit6 = SuperBreakOnHit6;
        DamageCalculator.ElationOnHit6 = ElationOnHit6;

        DamageCalculator.BreakOnHit7 = BreakOnHit7;
        DamageCalculator.SuperBreakOnHit7 = SuperBreakOnHit7;
        DamageCalculator.ElationOnHit7 = ElationOnHit7;

        DamageCalculator.BreakOnHit8 = BreakOnHit8;
        DamageCalculator.SuperBreakOnHit8 = SuperBreakOnHit8;
        DamageCalculator.ElationOnHit8 = ElationOnHit8;

        DamageCalculator.BreakOnHit9 = BreakOnHit9;
        DamageCalculator.SuperBreakOnHit9 = SuperBreakOnHit9;
        DamageCalculator.ElationOnHit9 = ElationOnHit9;

        DamageCalculator.BreakOnHit10 = BreakOnHit10;
        DamageCalculator.SuperBreakOnHit10 = SuperBreakOnHit10;
        DamageCalculator.ElationOnHit10 = ElationOnHit10;

        DamageCalculator.DamageRepartitionAtHit1 = (InputField1DamageRepartition / 100);
        DamageCalculator.DamageRepartitionAtHit2 = (InputField2DamageRepartition / 100);
        DamageCalculator.DamageRepartitionAtHit3 = (InputField3DamageRepartition / 100);
        DamageCalculator.DamageRepartitionAtHit4 = (InputField4DamageRepartition / 100);
        DamageCalculator.DamageRepartitionAtHit5 = (InputField5DamageRepartition / 100);
        DamageCalculator.DamageRepartitionAtHit6 = (InputField6DamageRepartition / 100);
        DamageCalculator.DamageRepartitionAtHit7 = (InputField7DamageRepartition / 100);
        DamageCalculator.DamageRepartitionAtHit8 = (InputField8DamageRepartition / 100);
        DamageCalculator.DamageRepartitionAtHit9 = (InputField9DamageRepartition / 100);
        DamageCalculator.DamageRepartitionAtHit10 = (InputField10DamageRepartition / 100);

        DamageCalculator.BaseEnnemyLevel = BaseEnnemyLevel;
        DamageCalculator.SpecialEnnemyLevel = SpecialEnnemyLevel;

        DamageCalculator.BaseEnnemyDef = CopyScript.BaseEnnemyDef;
        DamageCalculator.SpecialEnnemyDef = CopyScript.SpecialEnnemyDef;

        DamageCalculator.SaveinPlayerPrefs();
    }
}
