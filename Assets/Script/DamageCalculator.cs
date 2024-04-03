using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DamageCalculator : MonoBehaviour
{
    //Base DMG
    public float SkillMultiplier; //d�gats en % du skill 
    public float ExtraMultiplier; //Sp�cifique : apparait par exemple sur dang heng avec les ennemis ralentis
    public float ScalingAttribute; //Stats sur laquelle le skills scale le plus souvent c'est ATK
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
    public static float Base100PercentOfDef = 1.00f; //Toujours �gal a 1

    public float DefMultiplier;

    //RES MULTIPLIER
    public static float Base100PercentOfRESMultiplier = 1.00f; //toujours 1
    public float RESPercentage; //Tout les ennemis ont 20% de res donc 80%. Sauf si il y a une faiblesse c'est 0% a cette �l�ment donc 100%. Si il est r�sistant il a 40% de res a cette �l�ment donc 60%.La RES ne peut pas aller sous -100% et ne pas d�passer environ 90%
    public float RESPENPercentage;

    public float RESMultiplier;

    //DMGTakenMultiplier
    public static float Base100PercentOfDamageTakenMultiplier = 1.00f;
    public float ElementalDamageTakenPercentage;
    public float AllTypeDamageTakenPercentage;

    public float DamageTakenMultiplier; //ne peut d�passer 350%

    //Universal DMG Reduction Multiplier
    public float UniversalDamageReductionMultiplier;//90% quand pas break. 100% quand break
    public bool IsBreak;

    //WeakenMultiplier
    public static float Base100PercentOfWeakenMultiplier = 1.00f;//toujours 1
    public float WeakenMultiplierPercentage;

    public float DamageInOutput;

    public float CritRate;
    public float CritDamage;


    public float CritRateChance;
    public bool HasCrit;

    public Text DamageOutputText;

    public float DamageRepartitionAtHit1;//14,2f
    public float DamageRepartitionAtHit2;
    public float DamageRepartitionAtHit3;
    public float DamageRepartitionAtHit4;
    public float DamageRepartitionAtHit5;
    public float DamageRepartitionAtHit6;
    public float DamageRepartitionAtHit7;

    public float DamageAtHit1;
    public float DamageAtHit2;
    public float DamageAtHit3;
    public float DamageAtHit4;
    public float DamageAtHit5;
    public float DamageAtHit6;
    public float DamageAtHit7;

    public float BaseEnnemyLevel;
    public float SpecialEnnemyLevel;

    public float BaseEnnemyDef;
    public float SpecialEnnemyDef;

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

    public Text WeakenMultiplierPercentageText;

    public Text CritRateText;
    public Text CritDamageText;

    public Text DamageTextOfDamageRepartitionInputField1;
    public Text DamageTextOfDamageRepartitionInputField2;
    public Text DamageTextOfDamageRepartitionInputField3;
    public Text DamageTextOfDamageRepartitionInputField4;
    public Text DamageTextOfDamageRepartitionInputField5;
    public Text DamageTextOfDamageRepartitionInputField6;
    public Text DamageTextOfDamageRepartitionInputField7;

    public Text CritBoolDamageRepartitionInputField1;
    public Text CritBoolDamageRepartitionInputField2;
    public Text CritBoolDamageRepartitionInputField3;
    public Text CritBoolDamageRepartitionInputField4;
    public Text CritBoolDamageRepartitionInputField5;
    public Text CritBoolDamageRepartitionInputField6;
    public Text CritBoolDamageRepartitionInputField7;

    public Text Hit1DamageText;
    public Text Hit2DamageText;
    public Text Hit3DamageText;
    public Text Hit4DamageText;
    public Text Hit5DamageText;
    public Text Hit6DamageText;
    public Text Hit7DamageText;

    public Text BaseEnnemyLevelText;
    public Text SpecialEnnemyLevelText;

    public Text BaseEnnemyDefText;
    public Text SpecialEnnemyDefText;

    public CopyScript CopyScript;
    void Start()
    {
        AttackerLevel = 0;

        SkillMultiplier = 0.00f;//ex 1.50f = 150%
        ExtraMultiplier = 0.00f;
        ScalingAttribute = 0;//atk
        ExtraDamage = 0;

        Base100PercentOfDamagePercentMultiplier = 1.00f;
        ElementalDamagePercent = 0.0000f;
        AllTypeDamagePercent = 0.00f;//Erudition du moc va ici
        DOTDamagePercent = 0.00f;
        OtherDamagePercent = 0.00f;
        BaseDef = 0;
        RESPercentage = 0.00f;//0 si une faiblesse, 0.20 si pas de faiblesse, 0.40 si resistant
        RESPENPercentage = 0.00f;//je sais pas si c'est possible d'avoir des sommes ici

        LoadPlayerPrefs();
    }

    
    void Update()
    {
        
    }
    public void CalculateDamage()
    {
        BaseDamage = (SkillMultiplier + ExtraMultiplier) * ScalingAttribute + ExtraDamage;
        DamagePercentMultiplier = (Base100PercentOfDamagePercentMultiplier + (ElementalDamagePercent + AllTypeDamagePercent + DOTDamagePercent + OtherDamagePercent));
        DEF = (BaseDef * (Base100PercentOfDef + 0.00f - (DefReduction + DefIgnore)) + DefFlat);
        if (DEF < 0)
        {
            DEF = 0;
        }
        DefMultiplier = (Base100PercentOfDef - (DEF / (DEF + 200 + 10 * AttackerLevel)));
        if (RESPercentage < -1.00f)
        {
            RESPercentage = -1.00f;
        }
        else if (RESPercentage > 0.90f)
        {
            RESPercentage = 0.90f;
        }
        RESMultiplier = Base100PercentOfRESMultiplier - (RESPercentage - RESPENPercentage);
        DamageTakenMultiplier = (Base100PercentOfDamageTakenMultiplier + ElementalDamageTakenPercentage + AllTypeDamageTakenPercentage);
        if (DamageTakenMultiplier > 3.50f)
        {
            DamageTakenMultiplier = 3.50f;
        }
        DamageInOutput = (BaseDamage * DamagePercentMultiplier * DefMultiplier * RESMultiplier * DamageTakenMultiplier * UniversalDamageReductionMultiplier * WeakenMultiplierPercentage);
        CalculateEachHitDamage();
    }
    void CalculateEachHitDamage()
    {
        DamageAtHit1 = DamageInOutput * DamageRepartitionAtHit1;
        CritRateChance = Random.Range(0.0f, 100.0f);
        if (CritRate >= CritRateChance)
        {
            DamageAtHit1 = DamageAtHit1 * (1 + CritDamage);
            HasCrit = true;
        }
        else
        {
            HasCrit = false;
        }
        CritBoolDamageRepartitionInputField1.text = HasCrit.ToString();

        DamageAtHit2 = DamageInOutput * DamageRepartitionAtHit2;
        CritRateChance = Random.Range(0.0f, 100.0f);
        if (CritRate >= CritRateChance)
        {
            DamageAtHit2 = DamageAtHit2 * (1 + CritDamage);
            HasCrit = true;
        }
        else
        {
            HasCrit = false;
        }
        CritBoolDamageRepartitionInputField2.text = HasCrit.ToString();

        DamageAtHit3 = DamageInOutput * DamageRepartitionAtHit3;
        CritRateChance = Random.Range(0.0f, 100.0f);
        if (CritRate >= CritRateChance)
        {
            DamageAtHit3 = DamageAtHit3 * (1 + CritDamage);
            HasCrit = true;
        }
        else
        {
            HasCrit = false;
        }
        CritBoolDamageRepartitionInputField3.text = HasCrit.ToString();

        DamageAtHit4 = DamageInOutput * DamageRepartitionAtHit4;
        CritRateChance = Random.Range(0.0f, 100.0f);
        if (CritRate >= CritRateChance)
        {
            DamageAtHit4 = DamageAtHit4 * (1 + CritDamage);
            HasCrit = true;
        }
        else if (CritRate < CritRateChance)
        {
            HasCrit = false;
        }
        CritBoolDamageRepartitionInputField4.text = HasCrit.ToString();

        DamageAtHit5 = DamageInOutput * DamageRepartitionAtHit5;
        CritRateChance = Random.Range(0.0f, 100.0f);
        if (CritRate >= CritRateChance)
        {
            DamageAtHit5 = DamageAtHit5 * (1 + CritDamage);
            HasCrit = true;
        }
        else
        {
            HasCrit = false;
        }
        CritBoolDamageRepartitionInputField5.text = HasCrit.ToString();

        DamageAtHit6 = DamageInOutput * DamageRepartitionAtHit6;
        CritRateChance = Random.Range(0.0f, 100.0f);
        if (CritRate >= CritRateChance)
        {
            DamageAtHit6 = DamageAtHit6 * (1 + CritDamage);
            HasCrit = true;
        }
        else
        {
            HasCrit = false;
        }
        CritBoolDamageRepartitionInputField6.text = HasCrit.ToString();

        DamageAtHit7 = DamageInOutput * DamageRepartitionAtHit7;
        CritRateChance = Random.Range(0.0f, 100.0f);
        if (CritRate >= CritRateChance)
        {
            DamageAtHit7 = DamageAtHit7 * (1 + CritDamage);
            HasCrit = true;
        }
        else
        {
            HasCrit = false;
        }
        CritBoolDamageRepartitionInputField7.text = HasCrit.ToString();

        DisplayAllHitDamage();
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

        DamageInOutput = (DamageAtHit1 + DamageAtHit2 + DamageAtHit3 + DamageAtHit4 + DamageAtHit5 + DamageAtHit6 + DamageAtHit7);
        DamageOutputText.text = DamageInOutput.ToString();
    }
    public void SaveinPlayerPrefs()
    {
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

        PlayerPrefs.SetFloat("WeakenMultiplierPercentage", WeakenMultiplierPercentage);

        PlayerPrefs.SetFloat("CritRate", CritRate);
        PlayerPrefs.SetFloat("CritDamage", CritDamage);

        PlayerPrefs.SetFloat("DamageRepartitionAtHit1", DamageRepartitionAtHit1);
        PlayerPrefs.SetFloat("DamageRepartitionAtHit2", DamageRepartitionAtHit2);
        PlayerPrefs.SetFloat("DamageRepartitionAtHit3", DamageRepartitionAtHit3);
        PlayerPrefs.SetFloat("DamageRepartitionAtHit4", DamageRepartitionAtHit4);
        PlayerPrefs.SetFloat("DamageRepartitionAtHit5", DamageRepartitionAtHit5);
        PlayerPrefs.SetFloat("DamageRepartitionAtHit6", DamageRepartitionAtHit6);
        PlayerPrefs.SetFloat("DamageRepartitionAtHit7", DamageRepartitionAtHit7);

        PlayerPrefs.SetFloat("DamageAtHit1", DamageAtHit1);
        PlayerPrefs.SetFloat("DamageAtHit2", DamageAtHit2);
        PlayerPrefs.SetFloat("DamageAtHit3", DamageAtHit3);
        PlayerPrefs.SetFloat("DamageAtHit4", DamageAtHit4);
        PlayerPrefs.SetFloat("DamageAtHit5", DamageAtHit5);
        PlayerPrefs.SetFloat("DamageAtHit6", DamageAtHit6);
        PlayerPrefs.SetFloat("DamageAtHit7", DamageAtHit7);
        PlayerPrefs.SetFloat("DamageAtOutput", DamageInOutput);

        PlayerPrefs.SetFloat("BaseEnnemyLevel", BaseEnnemyLevel);
        PlayerPrefs.SetFloat("SpecialEnnemyLevel", SpecialEnnemyLevel);

        PlayerPrefs.SetFloat("BaseEnnemyDef", BaseEnnemyDef);
        PlayerPrefs.SetFloat("SpecialEnnemyDef", SpecialEnnemyDef);
    }
    public void LoadPlayerPrefs()
    {
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
        AttackerLevel = PlayerPrefs.GetFloat("AttackerLevel", 1);

        RESPercentage = PlayerPrefs.GetFloat("RESPercentage", 0);
        RESPENPercentage = PlayerPrefs.GetFloat("RESPENPercentage", 0);

        ElementalDamageTakenPercentage = PlayerPrefs.GetFloat("ElementalDamageTakenPercentage", 0);
        AllTypeDamageTakenPercentage = PlayerPrefs.GetFloat("AllTypeDamageTakenPercentage", 0);

        UniversalDamageReductionMultiplier = PlayerPrefs.GetFloat("UniversalDamageReductionMultiplier", 0.90f);

        WeakenMultiplierPercentage = PlayerPrefs.GetFloat("WeakenMultiplierPercentage", 1.00f);

        CritRate = PlayerPrefs.GetFloat("CritRate", 0);
        CritDamage = PlayerPrefs.GetFloat("CritDamage", 0);

        DamageRepartitionAtHit1 = PlayerPrefs.GetFloat("DamageRepartitionAtHit1", 0);
        DamageRepartitionAtHit2 = PlayerPrefs.GetFloat("DamageRepartitionAtHit2", 0);
        DamageRepartitionAtHit3 = PlayerPrefs.GetFloat("DamageRepartitionAtHit3", 0);
        DamageRepartitionAtHit4 = PlayerPrefs.GetFloat("DamageRepartitionAtHit4", 0);
        DamageRepartitionAtHit5 = PlayerPrefs.GetFloat("DamageRepartitionAtHit5", 0);
        DamageRepartitionAtHit6 = PlayerPrefs.GetFloat("DamageRepartitionAtHit6", 0);
        DamageRepartitionAtHit7 = PlayerPrefs.GetFloat("DamageRepartitionAtHit7", 0);

        DamageAtHit1 = PlayerPrefs.GetFloat("DamageAtHit1", 0);
        DamageAtHit2 = PlayerPrefs.GetFloat("DamageAtHit2", 0);
        DamageAtHit3 = PlayerPrefs.GetFloat("DamageAtHit3", 0);
        DamageAtHit4 = PlayerPrefs.GetFloat("DamageAtHit4", 0);
        DamageAtHit5 = PlayerPrefs.GetFloat("DamageAtHit5", 0);
        DamageAtHit6 = PlayerPrefs.GetFloat("DamageAtHit6", 0);
        DamageAtHit7 = PlayerPrefs.GetFloat("DamageAtHit7", 0);

        BaseEnnemyLevel = PlayerPrefs.GetFloat("BaseEnnemyLevel", 0);
        SpecialEnnemyLevel = PlayerPrefs.GetFloat("SpecialEnnemyLevel", 0);

        BaseEnnemyDef = PlayerPrefs.GetFloat("BaseEnnemyDef", 0);
        SpecialEnnemyDef = PlayerPrefs.GetFloat("SpecialEnnemyDef", 0);

        LoadTextWithValue();
    }
    public void LoadTextWithValue()
    {
        SkillMultiplierText.text = (SkillMultiplier * 100).ToString();
        ExtraMultiplierText.text = (ExtraMultiplier * 100).ToString();
        ScalingAttributeText.text = ScalingAttribute.ToString();
        ExtraDamageText.text = ExtraDamage.ToString();

        ElementalDamagePercentText.text = (ElementalDamagePercent * 100).ToString();
        AllTypeDamagePercentText.text = (AllTypeDamagePercent * 100).ToString();
        DOTDamagePercentText.text = (DOTDamagePercent * 100).ToString();
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

        WeakenMultiplierPercentageText.text = (WeakenMultiplierPercentage * 100).ToString();

        CritRateText.text = CritRate.ToString();
        CritDamageText.text = (CritDamage * 100).ToString();

        DamageTextOfDamageRepartitionInputField1.text = (DamageRepartitionAtHit1 * 100).ToString();
        DamageTextOfDamageRepartitionInputField2.text = (DamageRepartitionAtHit2 * 100).ToString();
        DamageTextOfDamageRepartitionInputField3.text = (DamageRepartitionAtHit3 * 100).ToString();
        DamageTextOfDamageRepartitionInputField4.text = (DamageRepartitionAtHit4 * 100).ToString();
        DamageTextOfDamageRepartitionInputField5.text = (DamageRepartitionAtHit5 * 100).ToString();
        DamageTextOfDamageRepartitionInputField6.text = (DamageRepartitionAtHit6 * 100).ToString();
        DamageTextOfDamageRepartitionInputField7.text = (DamageRepartitionAtHit7 * 100).ToString();

        Hit1DamageText.text = DamageAtHit1.ToString();
        Hit2DamageText.text = DamageAtHit2.ToString();
        Hit3DamageText.text = DamageAtHit3.ToString();
        Hit4DamageText.text = DamageAtHit4.ToString();
        Hit5DamageText.text = DamageAtHit5.ToString();
        Hit6DamageText.text = DamageAtHit6.ToString();
        Hit7DamageText.text = DamageAtHit7.ToString();

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