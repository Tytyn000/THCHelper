using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class DamageCalculator : MonoBehaviour
{
    //Dégats classiques :

    //Base DMG
    public float SkillMultiplier; //d�gats en % du skill 
    public float ExtraMultiplier; //Sp�cifique : apparait par exemple sur dang heng avec les ennemis ralentis
    public float ScalingAttribute; //Stats sur laquelle le skills scale le plus souvent c'est ATK
    public float ExtraDamage; //dgts flat sur certains skills : 
    
    public float BaseDamage;

    //DMG% MULTIPLIER
    public float ElementalDamagePercent; //Bonus Elementaires
    public float AllTypeDamagePercent; //ex Grand Duc + 20% sur les suivis
    public float DOTDamagePercent;
    public float OtherDamagePercent; //Buff TingYun
    
    public float DamagePercentMultiplier;

    //DEF MULTIPLIER
    public float AttackerLevel; //niveau de l'attaquant
    public int EnemyLevel; //niveau de l'ennemi
    //pour trouver la def il faut une autre formule
    //DEF
    public float DEF; //est utiliser plus haut
    public float BaseDef; //Def de base
    public float DefReduction;
    public float DefIgnore;
    public float DefFlat;

    public float DefMultiplier;

    //RES MULTIPLIER
    public float RESPercentage; //Tout les ennemis ont 20% de res donc 80%. Sauf si il y a une faiblesse c'est 0% a cette �l�ment donc 100%. Si il est r�sistant il a 40% de res a cette �l�ment donc 60%.La RES ne peut pas aller sous -100% et ne pas d�passer environ 90%
    public float RESPENPercentage;

    public float RESMultiplier;

    //DMGTakenMultiplier
    public float ElementalDamageTakenPercentage;
    public float AllTypeDamageTakenPercentage;

    public float DamageTakenMultiplier; //ne peut dépasser 350%

    //Universal DMG Reduction Multiplier
    public float UniversalDamageReductionMultiplier;//généralement 1, rare comme clara

    //Broken Multiplier
    public float BrokenMultiplier; //0.90f quand pas break, 1.00f quand break
    public bool IsBreak;

    //WeakenMultiplier
    public float WeakenMultiplierPercentage;

    public float DamageInOutput;

    public float CritRate;
    public float CritDamage;

    //Dégats de break :

    public float BreakDamage;

    public float AbilityMultiplier; //Commun avec le SuperBreak, vaut 1 si pas précisé
    public float BreakElementMultiplier;
    public float TargetToughness;
    public float ToughnessMultiplier;

    public float BreakEffect;
    public float BreakDamageIncrease;

    public float TypeToThisElementVulnerability;
    public float AllTypeVulnerability;
    public float BreakDamageVulnerability;
    public float DotDamageVulnerability;

    public float VulnerabilityMultiplier;

    public float[] LevelMultiplier = //commun avec le SuperBreak
    { 0f,      54.0000f,  58.0000f,  62.0000f,  67.5264f, // 0–4
    70.5094f,  73.5228f,  76.5660f,  79.6385f,  82.7395f,   // 5–9
    85.8684f,  91.4944f,  97.0680f,  102.5892f, 108.0579f,  // 10–14
    113.4743f, 118.8383f, 124.1499f, 129.4091f, 134.6159f,  // 15–19
    139.7703f, 149.3323f, 158.8011f, 168.1768f, 177.4594f,  // 20–24
    186.6489f, 195.7452f, 204.7484f, 213.6585f, 222.4754f,  // 25–29
    231.1992f, 246.4276f, 261.1810f, 275.4733f, 289.3179f,  // 30–34
    302.7275f, 315.7144f, 328.2905f, 340.4671f, 352.2554f,  // 35–39
    363.6658f, 408.1240f, 451.7883f, 494.6798f, 536.8188f,  // 40–44
    578.2249f, 618.9172f, 658.9138f, 698.2325f, 736.8905f,  // 45–49
    774.9041f, 871.0599f, 964.8705f, 1056.4206f,1145.7910f, // 50–54
    1233.0585f,1318.2965f,1401.5750f,1482.9608f,1562.5178f, // 55–59
    1640.3068f,1752.3215f,1861.9011f,1969.1242f,2074.0659f, // 60–64
    2176.7983f,2277.3904f,2375.9085f,2472.4160f,2566.9739f, // 65–69
    2659.6406f,2780.3044f,2898.6022f,3014.6029f,3128.3729f, // 70–74
    3239.9758f,3349.4730f,3456.9236f,3562.3843f,3665.9099f, // 75–79
    3767.5533f,3957.8618f,4155.2118f,4359.8638f,4572.0878f, // 80–84
    4792.1641f,5020.3833f,5257.0466f,5502.4664f,5756.9667f, // 85–89
    6020.8836f,6294.5654f,6578.3734f,6872.6823f,7177.8806f, // 90–94
    7494.3713f};                                            // 95

    //dégats de Superbreak :

    public float SuperBreakDamage;

    public float SuperBreakDamageIncrease;

    public float ToughnessReduction;

    public float BaseToughnessReduction;
    public float AdditiveToughnessReduction;

    public float ToughnessReductionIncrease;

    public float WeaknessBreakEfficiency;
    public float ToughnessVulnerability;

    //dégâts d'Allégresse :

    public float ElationDamage;

    public float Elation;

    public float PunchlineMultiplier;
    public float CertifiedBanger;
    public float Punchline;
    public string PunchlineMultiplierSource;

    public float MerryMakeMultiplier;
    public float MerryMake;

    //Autres :

    public Text DamageOutputText;

    public float DamageRepartitionAtHit1;//10,0f
    public float DamageRepartitionAtHit2;
    public float DamageRepartitionAtHit3;
    public float DamageRepartitionAtHit4;
    public float DamageRepartitionAtHit5;
    public float DamageRepartitionAtHit6;
    public float DamageRepartitionAtHit7;
    public float DamageRepartitionAtHit8;
    public float DamageRepartitionAtHit9;
    public float DamageRepartitionAtHit10;

    public float DamageAtHit1;
    public float DamageAtHit2;
    public float DamageAtHit3;
    public float DamageAtHit4;
    public float DamageAtHit5;
    public float DamageAtHit6;
    public float DamageAtHit7;
    public float DamageAtHit8;
    public float DamageAtHit9;
    public float DamageAtHit10;

    public float BaseEnnemyLevel;
    public float SpecialEnnemyLevel;

    public float BaseEnnemyDef;
    public float SpecialEnnemyDef;

    //dégats classiques :

    public Text SkillMultiplierText;
    public Text ExtraMultiplierText;
    public Text ScalingAttributeText;
    public Text ExtraDamageText;

    public Text ElementalDamagePercentText;
    public Text AllTypeDamagePercentText;
    public Text DOTDamagePercentText;
    public Text OtherDamagePercentText;

    public Text BaseDefText;
    public Text DefReductionText;
    public Text DefIgnoreText;
    public Text DefFlatText;
    public Text AttackerLevelText;
    
    public Text RESPercentageText;
    public Text RESPENPercentageText;

    public Text ElementalDamageTakenPercentageText;
    public Text AllTypeDamageTakenPercentageText;

    public Text UniversalDamageReductionMultiplierText;

    public Text BrokenMultiplierText;

    public Text WeakenMultiplierPercentageText;

    public Text CritRateText;
    public Text CritDamageText;

    //Dégats de Break :

    public Text TargetToughnessText;

    public Text AbilityMultiplierText;
    public Text BreakEffectText;
    public Text BreakDamageIncreaseText;

    public Text TypeToThisElementVulnerabilityText;
    public Text AllTypeVulnerabilityText;
    public Text BreakDamageVulnerabilityText;

    //Dégats de SuperBreak :

    public Text SecondAbilityMultiplierText;

    public Text BaseToughnessReductionText;
    public Text AdditiveToughnessReductionText;
    public Text ToughnessReductionIncreaseText;
    public Text WeaknessBreakEfficiencyText;
    public Text ToughnessVulnerabilityText;

    public Text SecondBreakEffectText;
    public Text SecondBreakDamageIncreaseText;
    public Text SuperBreakDamageIncreaseText;

    //Dégâts d'Allégresse : 

    public Text ThirdAbilityMultiplierText;

    public Text ElationText;

    public Text CertifiedBangerText;
    public Text PunchlineText;

    public Text MerryMakeText;

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

    public Toggle CritOnHit1Toggle;
    public Toggle CritOnHit2Toggle;
    public Toggle CritOnHit3Toggle;
    public Toggle CritOnHit4Toggle;
    public Toggle CritOnHit5Toggle;
    public Toggle CritOnHit6Toggle;
    public Toggle CritOnHit7Toggle;
    public Toggle CritOnHit8Toggle;
    public Toggle CritOnHit9Toggle;
    public Toggle CritOnHit10Toggle;

    public Text DamageTextOfDamageRepartitionInputField1;
    public Text DamageTextOfDamageRepartitionInputField2;
    public Text DamageTextOfDamageRepartitionInputField3;
    public Text DamageTextOfDamageRepartitionInputField4;
    public Text DamageTextOfDamageRepartitionInputField5;
    public Text DamageTextOfDamageRepartitionInputField6;
    public Text DamageTextOfDamageRepartitionInputField7;
    public Text DamageTextOfDamageRepartitionInputField8;
    public Text DamageTextOfDamageRepartitionInputField9;
    public Text DamageTextOfDamageRepartitionInputField10;

    public Text Hit1DamageText;
    public Text Hit2DamageText;
    public Text Hit3DamageText;
    public Text Hit4DamageText;
    public Text Hit5DamageText;
    public Text Hit6DamageText;
    public Text Hit7DamageText;
    public Text Hit8DamageText;
    public Text Hit9DamageText;
    public Text Hit10DamageText;

    public Text BaseEnnemyLevelText;
    public Text SpecialEnnemyLevelText;

    public Text BaseEnnemyDefText;
    public Text SpecialEnnemyDefText;

    public CopyScript CopyScript;

    void Start()
    {
        AttackerLevel = 0;

        SkillMultiplier = 0f;//ex 1.50f = 150%
        ExtraMultiplier = 0.00f;
        ScalingAttribute = 0;//atk
        ExtraDamage = 0;

        ElementalDamagePercent = 0.0000f;
        AllTypeDamagePercent = 0.00f;//Erudition du moc va ici
        DOTDamagePercent = 0.00f;
        OtherDamagePercent = 0.00f;
        BaseDef = 0;
        RESPercentage = 0.00f;//0 si une faiblesse, 0.20 si pas de faiblesse, 0.40 si resistant
        RESPENPercentage = 0.00f;

        BreakElementMultiplier = 2f;

        DamageType = "RegularDamage";

        PunchlineMultiplierSource = "CertifiedBangerState";

        LoadPlayerPrefs();
    }

    void Update()
    {

    }

    public void CalculateDamage()
    {
        DEF = (BaseDef * (1.00f - (DefReduction + DefIgnore)) + DefFlat);
        if (DEF < 0) { DEF *= -1; }
        DefMultiplier = 1.0f - (DEF / (DEF + 200f + 10f * AttackerLevel));
        if (RESPercentage < -1.00f) { RESPercentage = -1.00f; } else if (RESPercentage > 0.90f) { RESPercentage = 0.90f; }
        RESMultiplier = 1.00f - (RESPercentage - RESPENPercentage);

        if (DamageType == "RegularDamage" || DamageType == "")
        {
            BaseDamage = (SkillMultiplier + ExtraMultiplier) * ScalingAttribute + ExtraDamage;
            DamagePercentMultiplier = (1.00f + (ElementalDamagePercent + AllTypeDamagePercent + DOTDamagePercent + OtherDamagePercent));
            DamageTakenMultiplier = (1.00f + ElementalDamageTakenPercentage + AllTypeDamageTakenPercentage);
            if (DamageTakenMultiplier > 3.50f)
            {
                DamageTakenMultiplier = 3.50f;
            }
            DamageInOutput = Mathf.RoundToInt(BaseDamage * DamagePercentMultiplier * DefMultiplier * RESMultiplier * DamageTakenMultiplier * UniversalDamageReductionMultiplier * BrokenMultiplier * WeakenMultiplierPercentage);
        }
        else if (DamageType == "BreakDamage")
        {
            ToughnessMultiplier = (TargetToughness / 40) + 0.5f;
            if (BreakElementMultiplier == 0) { BreakElementMultiplier = 2; } //Par défaut physique
            BaseDamage = BreakElementMultiplier * LevelMultiplier[(int)AttackerLevel] * ToughnessMultiplier;

            VulnerabilityMultiplier = 1.00f + TypeToThisElementVulnerability + AllTypeVulnerability + BreakDamageVulnerability;

            BreakDamage = Mathf.RoundToInt(BaseDamage * AbilityMultiplier * (1 + BreakEffect) * (1 + BreakDamageIncrease) * DefMultiplier * RESMultiplier * VulnerabilityMultiplier * UniversalDamageReductionMultiplier * BrokenMultiplier);
            DamageInOutput = BreakDamage;
        }
        else if (DamageType == "SuperBreakDamage")
        {
            if (WeaknessBreakEfficiency > 3.00f) { WeaknessBreakEfficiency = 3.00f; }
            ToughnessReduction = (BaseToughnessReduction + AdditiveToughnessReduction) * (1 + ToughnessReductionIncrease) * (1 + WeaknessBreakEfficiency + ToughnessVulnerability) * 1;

            VulnerabilityMultiplier = 1.00f + TypeToThisElementVulnerability + AllTypeVulnerability + BreakDamageVulnerability;

            SuperBreakDamage = Mathf.RoundToInt((ToughnessReduction / 10) * LevelMultiplier[(int)AttackerLevel] * 1 * (1 + BreakEffect) * (1 + BreakDamageIncrease) * (1 + SuperBreakDamageIncrease) * DefMultiplier * RESMultiplier * VulnerabilityMultiplier * UniversalDamageReductionMultiplier * BrokenMultiplier);
            DamageInOutput = SuperBreakDamage;
        }
        else if (DamageType == "ElationDamage")
        {
            BaseDamage = AbilityMultiplier * LevelMultiplier[(int)AttackerLevel] * (1 + Elation);

            if (PunchlineMultiplierSource == "CertifiedBangerSource")
            {
                PunchlineMultiplier = 1 + (CertifiedBanger * 5 / CertifiedBanger + 240);
            }
            else
            {
                PunchlineMultiplier = 1 + (Punchline * 5 / Punchline + 240);
            }

            MerryMakeMultiplier = 1 + MerryMake;

            ElationDamage = BaseDamage * PunchlineMultiplier * MerryMakeMultiplier * WeakenMultiplierPercentage * DefMultiplier * RESMultiplier * UniversalDamageReductionMultiplier * BrokenMultiplier;
            DamageInOutput = ElationDamage;
        }
        CalculateEachHitDamage();
    }

    void CalculateAdditiveBreakDamage()
    {
        DEF = (BaseDef * (1.00f - (DefReduction + DefIgnore)) + DefFlat);
        if (DEF < 0) { DEF *= -1; }
        DefMultiplier = 1.0f - (DEF / (DEF + 200f + 10f * AttackerLevel));
        if (RESPercentage < -1.00f) { RESPercentage = -1.00f; } else if (RESPercentage > 0.90f) { RESPercentage = 0.90f; }
        RESMultiplier = 1.00f - (RESPercentage - RESPENPercentage);

        ToughnessMultiplier = (TargetToughness / 40) + 0.5f;
        BaseDamage = BreakElementMultiplier * LevelMultiplier[(int)AttackerLevel] * ToughnessMultiplier;

        VulnerabilityMultiplier = 1.00f + TypeToThisElementVulnerability + AllTypeVulnerability + BreakDamageVulnerability;
        //Ability Multiplier != de Skill Multiplier
        BreakDamage = Mathf.RoundToInt(BaseDamage * AbilityMultiplier * (1 + BreakEffect) * (1 + BreakDamageIncrease) * DefMultiplier * RESMultiplier * VulnerabilityMultiplier * UniversalDamageReductionMultiplier * BrokenMultiplier);
        DamageInOutput = BreakDamage;
    }
    void CalculateAdditiveSuperBreakDamage()
    {
        DEF = (BaseDef * (1.00f - (DefReduction + DefIgnore)) + DefFlat);
        if (DEF < 0) { DEF *= -1; }
        DefMultiplier = 1.0f - (DEF / (DEF + 200f + 10f * AttackerLevel));
        if (RESPercentage < -1.00f) { RESPercentage = -1.00f; } else if (RESPercentage > 0.90f) { RESPercentage = 0.90f; }
        RESMultiplier = 1.00f - (RESPercentage - RESPENPercentage);

        if (WeaknessBreakEfficiency > 3.00f) { WeaknessBreakEfficiency = 3.00f; }
        ToughnessReduction = (BaseToughnessReduction + AdditiveToughnessReduction) * (1 + ToughnessReductionIncrease) * (1 + WeaknessBreakEfficiency + ToughnessVulnerability) * AbilityMultiplier;

        VulnerabilityMultiplier = 1.00f + TypeToThisElementVulnerability + AllTypeVulnerability + BreakDamageVulnerability;

        SuperBreakDamage = Mathf.RoundToInt(ToughnessReduction / 10 * LevelMultiplier[(int)AttackerLevel] * AbilityMultiplier * (1 + BreakEffect) * (1 + BreakDamageIncrease) * (1 + SuperBreakDamageIncrease) * DefMultiplier * RESMultiplier * VulnerabilityMultiplier * UniversalDamageReductionMultiplier * 1 /*BrokenMultiplier*/);
        DamageInOutput = SuperBreakDamage;
    }
    void CalculateAdditiveElationDamage()
    {
        DEF = (BaseDef * (1.00f - (DefReduction + DefIgnore)) + DefFlat);
        if (DEF < 0) { DEF *= -1; }
        DefMultiplier = 1.0f - (DEF / (DEF + 200f + 10f * AttackerLevel));
        if (RESPercentage < -1.00f) { RESPercentage = -1.00f; } else if (RESPercentage > 0.90f) { RESPercentage = 0.90f; }
        RESMultiplier = 1.00f - (RESPercentage - RESPENPercentage);

        BaseDamage = AbilityMultiplier * LevelMultiplier[(int)AttackerLevel] * (1 + Elation);

        if (PunchlineMultiplierSource == "CertifiedBangerState")
        {
            PunchlineMultiplier = 1 + (CertifiedBanger * 5 / CertifiedBanger + 240);
        }
        else
        {
            PunchlineMultiplier = 1 + (Punchline * 5 / Punchline + 240);
        }

        MerryMakeMultiplier = 1 + MerryMake;

        ElationDamage = BaseDamage * PunchlineMultiplier * MerryMakeMultiplier * WeakenMultiplierPercentage * DefMultiplier * RESMultiplier * UniversalDamageReductionMultiplier * BrokenMultiplier;
        DamageInOutput = ElationDamage;
    }
    void AddTypeOfDamage()
    {
        //Hit 1:
        if (BreakOnHit1 && DamageType != "BreakDamage")
        {
            CalculateAdditiveBreakDamage();
            DamageAtHit1 += BreakDamage;
        }
        if (SuperBreakOnHit1 && DamageType != "SuperBreakDamage")
        {
            CalculateAdditiveSuperBreakDamage();
            DamageAtHit1 += SuperBreakDamage;
        }
        if (ElationOnHit1 && DamageType != "ElationDamage")
        {
            CalculateAdditiveElationDamage();
            DamageAtHit1 += ElationDamage;
        }

        //Hit 2:
        if (BreakOnHit2 && DamageType != "BreakDamage")
        {
            CalculateAdditiveBreakDamage();
            DamageAtHit2 += BreakDamage;
        }
        if (SuperBreakOnHit2 && DamageType != "SuperBreakDamage")
        {
            CalculateAdditiveSuperBreakDamage();
            DamageAtHit2 += SuperBreakDamage;
        }
        if (ElationOnHit2 && DamageType != "ElationDamage")
        {
            CalculateAdditiveElationDamage();
            DamageAtHit2 += ElationDamage;
        }

        //Hit 3:
        if (BreakOnHit3 && DamageType != "BreakDamage")
        {
            CalculateAdditiveBreakDamage();
            DamageAtHit3 += BreakDamage;
        }
        if (SuperBreakOnHit3 && DamageType != "SuperBreakDamage")
        {
            CalculateAdditiveSuperBreakDamage();
            DamageAtHit3 += SuperBreakDamage;
        }
        if (ElationOnHit3 && DamageType != "ElationDamage")
        {
            CalculateAdditiveElationDamage();
            DamageAtHit3 += ElationDamage;
        }

        //Hit 4:
        if (BreakOnHit4 && DamageType != "BreakDamage")
        {
            CalculateAdditiveBreakDamage();
            DamageAtHit4 += BreakDamage;
        }
        if (SuperBreakOnHit4 && DamageType != "SuperBreakDamage")
        {
            CalculateAdditiveSuperBreakDamage();
            DamageAtHit4 += SuperBreakDamage;
        }
        if (ElationOnHit4 && DamageType != "ElationDamage")
        {
            CalculateAdditiveElationDamage();
            DamageAtHit4 += ElationDamage;
        }

        //Hit 5:
        if (BreakOnHit5 && DamageType != "BreakDamage")
        {
            CalculateAdditiveBreakDamage();
            DamageAtHit5 += BreakDamage;
        }
        if (SuperBreakOnHit5 && DamageType != "SuperBreakDamage")
        {
            CalculateAdditiveSuperBreakDamage();
            DamageAtHit5 += SuperBreakDamage;
        }
        if (ElationOnHit5 && DamageType != "ElationDamage")
        {
            CalculateAdditiveElationDamage();
            DamageAtHit5 += ElationDamage;
        }

        //Hit 6:
        if (BreakOnHit6 && DamageType != "BreakDamage")
        {
            CalculateAdditiveBreakDamage();
            DamageAtHit6 += BreakDamage;
        }
        if (SuperBreakOnHit6 && DamageType != "SuperBreakDamage")
        {
            CalculateAdditiveSuperBreakDamage();
            DamageAtHit6 += SuperBreakDamage;
        }
        if (ElationOnHit6 && DamageType != "ElationDamage")
        {
            CalculateAdditiveElationDamage();
            DamageAtHit6 += ElationDamage;
        }

        //Hit 7:
        if (BreakOnHit7 && DamageType != "BreakDamage")
        {
            CalculateAdditiveBreakDamage();
            DamageAtHit7 += BreakDamage;
        }
        if (SuperBreakOnHit7 && DamageType != "SuperBreakDamage")
        {
            CalculateAdditiveSuperBreakDamage();
            DamageAtHit7 += SuperBreakDamage;
        }
        if (ElationOnHit7 && DamageType != "ElationDamage")
        {
            CalculateAdditiveElationDamage();
            DamageAtHit7 += ElationDamage;
        }

        //Hit 8:
        if (BreakOnHit8 && DamageType != "BreakDamage")
        {
            CalculateAdditiveBreakDamage();
            DamageAtHit8 += BreakDamage;
        }
        if (SuperBreakOnHit8 && DamageType != "SuperBreakDamage")
        {
            CalculateAdditiveSuperBreakDamage();
            DamageAtHit8 += SuperBreakDamage;
        }
        if (ElationOnHit8 && DamageType != "ElationDamage")
        {
            CalculateAdditiveElationDamage();
            DamageAtHit8 += ElationDamage;
        }

        //Hit 9:
        if (BreakOnHit9 && DamageType != "BreakDamage")
        {
            CalculateAdditiveBreakDamage();
            DamageAtHit9 += BreakDamage;
        }
        if (SuperBreakOnHit9 && DamageType != "SuperBreakDamage")
        {
            CalculateAdditiveSuperBreakDamage();
            DamageAtHit9 += SuperBreakDamage;
        }
        if (ElationOnHit9 && DamageType != "ElationDamage")
        {
            CalculateAdditiveElationDamage();
            DamageAtHit9 += ElationDamage;
        }

        //Hit 10:
        if (BreakOnHit10 && DamageType != "BreakDamage")
        {
            CalculateAdditiveBreakDamage();
            DamageAtHit10 += BreakDamage;
        }
        if (SuperBreakOnHit10 && DamageType != "SuperBreakDamage")
        {
            CalculateAdditiveSuperBreakDamage();
            DamageAtHit10 += SuperBreakDamage;
        }
        if (ElationOnHit10 && DamageType != "ElationDamage")
        {
            CalculateAdditiveElationDamage();
            DamageAtHit10 += ElationDamage;
        }

        DisplayAllHitDamage();
    }

    void CalculateEachHitDamage()
    {
        DamageAtHit1 =  Mathf.RoundToInt(DamageInOutput * DamageRepartitionAtHit1);
        if (CritOnHit1Toggle.isOn)
        {
            if (DamageType == "RegularDamage" || DamageType == "ElationDamage" || DamageType == "")
            {
                DamageAtHit1 = Mathf.RoundToInt(DamageAtHit1 * (1 + CritDamage));
            }
        }

        //Hit 2 :
        DamageAtHit2 = Mathf.RoundToInt(DamageInOutput * DamageRepartitionAtHit2);
        if (CritOnHit2Toggle.isOn)
        {
            if (DamageType == "RegularDamage" || DamageType == "ElationDamage" || DamageType == "")
            {
                DamageAtHit2 = Mathf.RoundToInt(DamageAtHit2 * (1 + CritDamage));
            }
        }

        DamageAtHit3 = Mathf.RoundToInt(DamageInOutput * DamageRepartitionAtHit3);
        if (CritOnHit3Toggle.isOn)
        {
            if (DamageType == "RegularDamage" || DamageType == "ElationDamage" || DamageType == "")
            {
                DamageAtHit3 = Mathf.RoundToInt(DamageAtHit3 * (1 + CritDamage));
            }

        }

        DamageAtHit4 = Mathf.RoundToInt(DamageInOutput * DamageRepartitionAtHit4);
        if (CritOnHit4Toggle.isOn)
        {
            if (DamageType == "RegularDamage" || DamageType == "ElationDamage" || DamageType == "")
            {
                DamageAtHit4 = Mathf.RoundToInt(DamageAtHit4 * (1 + CritDamage));
            }
        }

        DamageAtHit5 = Mathf.RoundToInt(DamageInOutput * DamageRepartitionAtHit5);
        if (CritOnHit5Toggle.isOn)
        {
            if (DamageType == "RegularDamage" || DamageType == "ElationDamage" || DamageType == "")
            {
                DamageAtHit5 = Mathf.RoundToInt(DamageAtHit5 * (1 + CritDamage));
            }
        }

        DamageAtHit6 = Mathf.RoundToInt(DamageInOutput * DamageRepartitionAtHit6);
        if (CritOnHit6Toggle.isOn)
        {
            if (DamageType == "RegularDamage" || DamageType == "ElationDamage" || DamageType == "")
            {
                DamageAtHit6 = Mathf.RoundToInt(DamageAtHit6 * (1 + CritDamage));
            }
        }

        DamageAtHit7 = Mathf.RoundToInt(DamageInOutput * DamageRepartitionAtHit7);
        if (CritOnHit7Toggle.isOn)
        {
            if (DamageType == "RegularDamage" || DamageType == "ElationDamage" || DamageType == "")
            {
                DamageAtHit7 = Mathf.RoundToInt(DamageAtHit7 * (1 + CritDamage));
            }
        }

        DamageAtHit8 = Mathf.RoundToInt(DamageInOutput * DamageRepartitionAtHit8);
        if (CritOnHit8Toggle.isOn)
        {
            if (DamageType == "RegularDamage" || DamageType == "ElationDamage" || DamageType == "")
            {
                DamageAtHit8 = Mathf.RoundToInt(DamageAtHit8 * (1 + CritDamage));
            }
        }

        DamageAtHit9 = Mathf.RoundToInt(DamageInOutput * DamageRepartitionAtHit9);
        if (CritOnHit9Toggle.isOn)
        {
            if (DamageType == "RegularDamage" || DamageType == "ElationDamage" || DamageType == "")
            {
                DamageAtHit9 = Mathf.RoundToInt(DamageAtHit9 * (1 + CritDamage));
            }
        }

        DamageAtHit10 = Mathf.RoundToInt(DamageInOutput * DamageRepartitionAtHit10);
        if (CritOnHit10Toggle.isOn)
        {
            if (DamageType == "RegularDamage" || DamageType == "ElationDamage" || DamageType == "")
            {
                DamageAtHit10 = Mathf.RoundToInt(DamageAtHit10 * (1 + CritDamage));
            }
        }

        AddTypeOfDamage();
    }

    void DisplayAllHitDamage()
    {
        Hit1DamageText.text = DamageAtHit1.ToString();
        Hit2DamageText.text = DamageAtHit2.ToString();
        Hit3DamageText.text = DamageAtHit3.ToString();
        Hit4DamageText.text = DamageAtHit4.ToString();
        Hit5DamageText.text = DamageAtHit5.ToString();
        Hit6DamageText.text = DamageAtHit6.ToString();
        Hit7DamageText.text = DamageAtHit7.ToString();
        Hit8DamageText.text = DamageAtHit8.ToString();
        Hit9DamageText.text = DamageAtHit9.ToString();
        Hit10DamageText.text = DamageAtHit10.ToString();

        DamageInOutput = Mathf.RoundToInt(DamageAtHit1 + DamageAtHit2 + DamageAtHit3 + DamageAtHit4 + DamageAtHit5 + DamageAtHit6 + DamageAtHit7 + DamageAtHit8 + DamageAtHit9 + DamageAtHit10);
        DamageOutputText.text = DamageInOutput.ToString();
    }
    public void SaveinPlayerPrefs()
    {
        //dégats classiques :

        PlayerPrefs.SetFloat("SkillMultiplier", SkillMultiplier);
        PlayerPrefs.SetFloat("ExtraMultiplier", ExtraMultiplier);
        PlayerPrefs.SetFloat("ScalingAttribute", ScalingAttribute);
        PlayerPrefs.SetFloat("ExtraDamage", ExtraDamage);

        PlayerPrefs.SetFloat("ElementalDamagePercent", ElementalDamagePercent);
        PlayerPrefs.SetFloat("AllTypeDamagePercent", AllTypeDamagePercent);
        PlayerPrefs.SetFloat("DOTDamagePercent", DOTDamagePercent);
        PlayerPrefs.SetFloat("OtherDamagePercent", OtherDamagePercent);

        PlayerPrefs.SetFloat("BaseDef", BaseDef);
        PlayerPrefs.SetFloat("DefReduction", DefReduction);
        PlayerPrefs.SetFloat("DefIgnore", DefIgnore);
        PlayerPrefs.SetFloat("DefFlat", DefFlat);
        PlayerPrefs.SetFloat("AttackerLevel", AttackerLevel);

        PlayerPrefs.SetFloat("RESPercentage", RESPercentage);
        PlayerPrefs.SetFloat("RESPENPercentage", RESPENPercentage);

        PlayerPrefs.SetFloat("ElementalDamageTakenPercentage", ElementalDamageTakenPercentage);
        PlayerPrefs.SetFloat("AllTypeDamageTakenPercentage", AllTypeDamageTakenPercentage);

        PlayerPrefs.SetFloat("UniversalDamageReductionMultiplier", UniversalDamageReductionMultiplier);

        PlayerPrefs.SetFloat("BrokenMultiplier", BrokenMultiplier);

        PlayerPrefs.SetFloat("WeakenMultiplierPercentage", WeakenMultiplierPercentage);

        PlayerPrefs.SetFloat("CritRate", CritRate);
        PlayerPrefs.SetFloat("CritDamage", CritDamage);

        //dégats de Break :

        PlayerPrefs.SetFloat("AbilityMultiplier", AbilityMultiplier);
        PlayerPrefs.SetFloat("BreakElementMultiplier", BreakElementMultiplier);
        PlayerPrefs.SetFloat("TargetToughness", TargetToughness);

        PlayerPrefs.SetFloat("BreakEffect", BreakEffect);
        PlayerPrefs.SetFloat("BreakDamageIncrease", BreakDamageIncrease);

        PlayerPrefs.SetFloat("TypeToThisElementVulnerability", TypeToThisElementVulnerability);
        PlayerPrefs.SetFloat("AllTypeVulnerability", AllTypeVulnerability);
        PlayerPrefs.SetFloat("BreakDamageVulnerability", BreakDamageVulnerability);
        PlayerPrefs.SetFloat("DotDamageVulnerability", DotDamageVulnerability);

        //dégats de SuperBreak :

        PlayerPrefs.SetFloat("BaseToughnessReduction", BaseToughnessReduction);
        PlayerPrefs.SetFloat("AdditiveToughnessReduction", AdditiveToughnessReduction);

        PlayerPrefs.SetFloat("ToughnessReductionIncrease", ToughnessReductionIncrease);

        PlayerPrefs.SetFloat("WeaknessBreakEfficiency", WeaknessBreakEfficiency);
        PlayerPrefs.SetFloat("ToughnessVulnerability", ToughnessVulnerability);

        PlayerPrefs.SetFloat("SuperBreakDamageIncrease", SuperBreakDamageIncrease);

        //Dégâts d'Allégresse : 

        PlayerPrefs.SetFloat("Elation", Elation);

        PlayerPrefs.SetFloat("CertifiedBanger", CertifiedBanger);
        PlayerPrefs.SetFloat("Punchline", Punchline);

        PlayerPrefs.SetFloat("MerryMake", MerryMake);

        //Autres :

        PlayerPrefs.SetString("DamageType", DamageType);

        PlayerPrefs.SetFloat("DamageRepartitionAtHit1", DamageRepartitionAtHit1);
        PlayerPrefs.SetFloat("DamageRepartitionAtHit2", DamageRepartitionAtHit2);
        PlayerPrefs.SetFloat("DamageRepartitionAtHit3", DamageRepartitionAtHit3);
        PlayerPrefs.SetFloat("DamageRepartitionAtHit4", DamageRepartitionAtHit4);
        PlayerPrefs.SetFloat("DamageRepartitionAtHit5", DamageRepartitionAtHit5);
        PlayerPrefs.SetFloat("DamageRepartitionAtHit6", DamageRepartitionAtHit6);
        PlayerPrefs.SetFloat("DamageRepartitionAtHit7", DamageRepartitionAtHit7);
        PlayerPrefs.SetFloat("DamageRepartitionAtHit8", DamageRepartitionAtHit8);
        PlayerPrefs.SetFloat("DamageRepartitionAtHit9", DamageRepartitionAtHit9);
        PlayerPrefs.SetFloat("DamageRepartitionAtHit10", DamageRepartitionAtHit10);

        PlayerPrefs.SetFloat("DamageAtHit1", DamageAtHit1);
        PlayerPrefs.SetFloat("DamageAtHit2", DamageAtHit2);
        PlayerPrefs.SetFloat("DamageAtHit3", DamageAtHit3);
        PlayerPrefs.SetFloat("DamageAtHit4", DamageAtHit4);
        PlayerPrefs.SetFloat("DamageAtHit5", DamageAtHit5);
        PlayerPrefs.SetFloat("DamageAtHit6", DamageAtHit6);
        PlayerPrefs.SetFloat("DamageAtHit7", DamageAtHit7);
        PlayerPrefs.SetFloat("DamageAtHit8", DamageAtHit8);
        PlayerPrefs.SetFloat("DamageAtHit9", DamageAtHit9);
        PlayerPrefs.SetFloat("DamageAtHit10", DamageAtHit10);

        PlayerPrefs.SetFloat("DamageAtOutput", DamageInOutput);

        PlayerPrefs.SetFloat("BaseEnnemyLevel", BaseEnnemyLevel);
        PlayerPrefs.SetFloat("SpecialEnnemyLevel", SpecialEnnemyLevel);

        PlayerPrefs.SetFloat("BaseEnnemyDef", BaseEnnemyDef);
        PlayerPrefs.SetFloat("SpecialEnnemyDef", SpecialEnnemyDef);
    }
    public void LoadPlayerPrefs()
    {
        //Dégats classiques :

        SkillMultiplier = PlayerPrefs.GetFloat("SkillMultiplier", 0);
        ExtraMultiplier = PlayerPrefs.GetFloat("ExtraMultiplier", 0);
        ScalingAttribute = PlayerPrefs.GetFloat("ScalingAttribute", 0);
        ExtraDamage = PlayerPrefs.GetFloat("ExtraDamage", 0);

        ElementalDamagePercent = PlayerPrefs.GetFloat("ElementalDamagePercent", 0);
        AllTypeDamagePercent = PlayerPrefs.GetFloat("AllTypeDamagePercent", 0);
        DOTDamagePercent = PlayerPrefs.GetFloat("DOTDamagePercent", 0);
        OtherDamagePercent = PlayerPrefs.GetFloat("OtherDamagePercent", 0);

        BaseDef = PlayerPrefs.GetFloat("BaseDef", 0);
        DefReduction = PlayerPrefs.GetFloat("DefReduction", 0);
        DefIgnore = PlayerPrefs.GetFloat("DefIgnore", 0);
        DefFlat = PlayerPrefs.GetFloat("DefFlat", 0);
        AttackerLevel = PlayerPrefs.GetFloat("AttackerLevel", 0);

        RESPercentage = PlayerPrefs.GetFloat("RESPercentage", 0);
        RESPENPercentage = PlayerPrefs.GetFloat("RESPENPercentage", 0);

        ElementalDamageTakenPercentage = PlayerPrefs.GetFloat("ElementalDamageTakenPercentage", 0);
        AllTypeDamageTakenPercentage = PlayerPrefs.GetFloat("AllTypeDamageTakenPercentage", 0);

        UniversalDamageReductionMultiplier = PlayerPrefs.GetFloat("UniversalDamageReductionMultiplier", 0);
        
        BrokenMultiplier = PlayerPrefs.GetFloat("BrokenMultiplier", 0);

        WeakenMultiplierPercentage = PlayerPrefs.GetFloat("WeakenMultiplierPercentage", 0);

        CritRate = PlayerPrefs.GetFloat("CritRate", 0);
        CritDamage = PlayerPrefs.GetFloat("CritDamage", 0);

        //Dégats de Break :

        AbilityMultiplier = PlayerPrefs.GetFloat("AbilityMultiplier", 0);
        BreakElementMultiplier = PlayerPrefs.GetFloat("BreakElementMultiplier", 2);
        TargetToughness = PlayerPrefs.GetFloat("TargetToughness", 0);

        BreakEffect = PlayerPrefs.GetFloat("BreakEffect", 0);
        BreakDamageIncrease = PlayerPrefs.GetFloat("BreakDamageIncrease", 0);

        TypeToThisElementVulnerability = PlayerPrefs.GetFloat("TypeToThisElementVulnerability", 0);
        AllTypeVulnerability = PlayerPrefs.GetFloat("AllTypeVulnerability", 0);
        BreakDamageVulnerability = PlayerPrefs.GetFloat("BreakDamageVulnerability", 0);
        DotDamageVulnerability = PlayerPrefs.GetFloat("DotDamageVulnerability", 0);

        //Dégats de SuperBreak :

        BaseToughnessReduction = PlayerPrefs.GetFloat("BaseToughnessReduction", 0);
        AdditiveToughnessReduction = PlayerPrefs.GetFloat("AdditiveToughnessReduction", 0);
        
        ToughnessReductionIncrease = PlayerPrefs.GetFloat("ToughnessReductionIncrease", 0);
        
        WeaknessBreakEfficiency = PlayerPrefs.GetFloat("WeaknessBreakEfficiency", 0);
        ToughnessVulnerability = PlayerPrefs.GetFloat("ToughnessVulnerability", 0);

        SuperBreakDamageIncrease = PlayerPrefs.GetFloat("SuperBreakDamageIncrease", 0);

        //Dégâts d'Allégresse :

        Elation = PlayerPrefs.GetFloat("Elation", 0);

        CertifiedBanger = PlayerPrefs.GetFloat("CertifiedBanger", 0);
        Punchline = PlayerPrefs.GetFloat("Punchline", 0);

        MerryMake = PlayerPrefs.GetFloat("MerryMake", 0);

        //Autres :

        DamageType = PlayerPrefs.GetString("DamageType", "RegularDamage");

        DamageRepartitionAtHit1 = PlayerPrefs.GetFloat("DamageRepartitionAtHit1", 0);
        DamageRepartitionAtHit2 = PlayerPrefs.GetFloat("DamageRepartitionAtHit2", 0);
        DamageRepartitionAtHit3 = PlayerPrefs.GetFloat("DamageRepartitionAtHit3", 0);
        DamageRepartitionAtHit4 = PlayerPrefs.GetFloat("DamageRepartitionAtHit4", 0);
        DamageRepartitionAtHit5 = PlayerPrefs.GetFloat("DamageRepartitionAtHit5", 0);
        DamageRepartitionAtHit6 = PlayerPrefs.GetFloat("DamageRepartitionAtHit6", 0);
        DamageRepartitionAtHit7 = PlayerPrefs.GetFloat("DamageRepartitionAtHit7", 0);
        DamageRepartitionAtHit8 = PlayerPrefs.GetFloat("DamageRepartitionAtHit8", 0);
        DamageRepartitionAtHit9 = PlayerPrefs.GetFloat("DamageRepartitionAtHit9", 0);
        DamageRepartitionAtHit10 = PlayerPrefs.GetFloat("DamageRepartitionAtHit10", 0);

        DamageAtHit1 = PlayerPrefs.GetFloat("DamageAtHit1", 0);
        DamageAtHit2 = PlayerPrefs.GetFloat("DamageAtHit2", 0);
        DamageAtHit3 = PlayerPrefs.GetFloat("DamageAtHit3", 0);
        DamageAtHit4 = PlayerPrefs.GetFloat("DamageAtHit4", 0);
        DamageAtHit5 = PlayerPrefs.GetFloat("DamageAtHit5", 0);
        DamageAtHit6 = PlayerPrefs.GetFloat("DamageAtHit6", 0);
        DamageAtHit7 = PlayerPrefs.GetFloat("DamageAtHit7", 0);
        DamageAtHit8 = PlayerPrefs.GetFloat("DamageAtHit8", 0);
        DamageAtHit9 = PlayerPrefs.GetFloat("DamageAtHit9", 0);
        DamageAtHit10 = PlayerPrefs.GetFloat("DamageAtHit10", 0);

        BaseEnnemyLevel = PlayerPrefs.GetFloat("BaseEnnemyLevel", 0);
        SpecialEnnemyLevel = PlayerPrefs.GetFloat("SpecialEnnemyLevel", 0);

        BaseEnnemyDef = PlayerPrefs.GetFloat("BaseEnnemyDef", 0);
        SpecialEnnemyDef = PlayerPrefs.GetFloat("SpecialEnnemyDef", 0);

        LoadTextWithValue();
    }
    public void LoadTextWithValue()
    {
        //Dégats classiques :

        SkillMultiplierText.text = (SkillMultiplier * 100).ToString();
        ExtraMultiplierText.text = (ExtraMultiplier * 100).ToString();
        ScalingAttributeText.text = ScalingAttribute.ToString();
        ExtraDamageText.text = ExtraDamage.ToString();

        ElementalDamagePercentText.text = (ElementalDamagePercent * 100).ToString();
        AllTypeDamagePercentText.text = (AllTypeDamagePercent * 100).ToString();
        OtherDamagePercentText.text = (OtherDamagePercent * 100).ToString();

        BaseDefText.text = BaseDef.ToString();
        DefReductionText.text = (DefReduction * 100).ToString();
        DefIgnoreText.text = (DefIgnore * 100).ToString();
        DefFlatText.text = DefFlat.ToString();
        AttackerLevelText.text = AttackerLevel.ToString();

        RESPercentageText.text = (RESPercentage * 100).ToString();
        RESPENPercentageText.text = (RESPENPercentage * 100).ToString();

        ElementalDamageTakenPercentageText.text = (ElementalDamageTakenPercentage * 100).ToString();
        AllTypeDamageTakenPercentageText.text = (AllTypeDamageTakenPercentage * 100).ToString();

        UniversalDamageReductionMultiplierText.text = (UniversalDamageReductionMultiplier * 100).ToString();

        BrokenMultiplierText.text = (BrokenMultiplier * 100).ToString();

        WeakenMultiplierPercentageText.text = (WeakenMultiplierPercentage * 100).ToString();

        CritRateText.text = CritRate.ToString();
        CritDamageText.text = (CritDamage * 100).ToString();

        //Dégats de Break :

        TargetToughnessText.text = TargetToughness.ToString();
        AbilityMultiplierText.text = (AbilityMultiplier * 100).ToString();

        BreakEffectText.text = (BreakEffect * 100).ToString();
        BreakDamageIncreaseText.text = (BreakDamageIncrease * 100).ToString();

        TypeToThisElementVulnerabilityText.text = (TypeToThisElementVulnerability * 100).ToString();
        AllTypeVulnerabilityText.text = (AllTypeVulnerability * 100).ToString();
        BreakDamageVulnerabilityText.text = (BreakDamageVulnerability * 100).ToString();

        //Dégats de SuperBreak :

        BaseToughnessReductionText.text = BaseToughnessReduction.ToString();
        AdditiveToughnessReductionText.text = AdditiveToughnessReduction.ToString();
        ToughnessReductionIncreaseText.text = (ToughnessReductionIncrease * 100).ToString();
        WeaknessBreakEfficiencyText.text = (WeaknessBreakEfficiency * 100).ToString();
        ToughnessVulnerabilityText.text = (ToughnessVulnerability * 100).ToString();

        SecondAbilityMultiplierText.text = (AbilityMultiplier * 100).ToString();

        SecondBreakEffectText.text = (BreakEffect * 100).ToString();
        SecondBreakDamageIncreaseText.text = (BreakDamageIncrease * 100).ToString();
        SuperBreakDamageIncreaseText.text = (SuperBreakDamageIncrease * 100).ToString();

        //Dégâts d'Allégresse : 

        ThirdAbilityMultiplierText.text = (AbilityMultiplier * 100).ToString();

        ElationText.text = (Elation * 100).ToString();

        CertifiedBangerText.text = (CertifiedBanger * 100).ToString();
        PunchlineText.text = (Punchline * 100).ToString();

        MerryMakeText.text = (MerryMake * 100).ToString();

        //Autres :

        DamageTextOfDamageRepartitionInputField1.text = (DamageRepartitionAtHit1 * 100).ToString();
        DamageTextOfDamageRepartitionInputField2.text = (DamageRepartitionAtHit2 * 100).ToString();
        DamageTextOfDamageRepartitionInputField3.text = (DamageRepartitionAtHit3 * 100).ToString();
        DamageTextOfDamageRepartitionInputField4.text = (DamageRepartitionAtHit4 * 100).ToString();
        DamageTextOfDamageRepartitionInputField5.text = (DamageRepartitionAtHit5 * 100).ToString();
        DamageTextOfDamageRepartitionInputField6.text = (DamageRepartitionAtHit6 * 100).ToString();
        DamageTextOfDamageRepartitionInputField7.text = (DamageRepartitionAtHit7 * 100).ToString();
        DamageTextOfDamageRepartitionInputField8.text = (DamageRepartitionAtHit8 * 100).ToString();
        DamageTextOfDamageRepartitionInputField9.text = (DamageRepartitionAtHit9 * 100).ToString();
        DamageTextOfDamageRepartitionInputField10.text = (DamageRepartitionAtHit10 * 100).ToString();

        Hit1DamageText.text = DamageAtHit1.ToString();
        Hit2DamageText.text = DamageAtHit2.ToString();
        Hit3DamageText.text = DamageAtHit3.ToString();
        Hit4DamageText.text = DamageAtHit4.ToString();
        Hit5DamageText.text = DamageAtHit5.ToString();
        Hit6DamageText.text = DamageAtHit6.ToString();
        Hit7DamageText.text = DamageAtHit7.ToString();
        Hit8DamageText.text = DamageAtHit8.ToString();
        Hit9DamageText.text = DamageAtHit9.ToString();
        Hit10DamageText.text = DamageAtHit10.ToString();

        BaseEnnemyLevelText.text = BaseEnnemyLevel.ToString();
        SpecialEnnemyLevelText.text = SpecialEnnemyLevel.ToString();

        BaseEnnemyDefText.text = BaseEnnemyDef.ToString();
        SpecialEnnemyDefText.text = SpecialEnnemyDef.ToString();

        CopyScript.BaseEnnemyLevel = BaseEnnemyLevel;
        CopyScript.SpecialEnnemyLevel = SpecialEnnemyLevel;

        CopyScript.BaseEnnemyDef = BaseEnnemyDef;
        CopyScript.SpecialEnnemyDef = SpecialEnnemyDef;
    }
}