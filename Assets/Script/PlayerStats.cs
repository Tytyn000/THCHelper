using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerStat", menuName = "PlayerStat")]
public class PlayerStats : ScriptableObject
{
    public int HealthPoints;
    public int Def;
    public int Level;
    public float SPD;

    public float BasicATKLev1Multiplier;
    public float BasicATKLev2Multiplier;
    public float BasicATKLev3Multiplier;
    public float BasicATKLev4Multiplier;
    public float BasicATKLev5Multiplier;
    public float BasicATKLev6Multiplier;
    public float BasicATKLev7Multiplier;

    public bool HasEnhancedBasicATK;

    public float SkillLev1Multiplier;
    public float SkillLev2Multiplier;
    public float SkillLev3Multiplier;
    public float SkillLev4Multiplier;
    public float SkillLev5Multiplier;
    public float SkillLev6Multiplier;
    public float SkillLev7Multiplier;
    public float SkillLev8Multiplier;
    public float SkillLev9Multiplier;
    public float SkillLev10Multiplier;
    public float SkillLev11Multiplier;
    public float SkillLev12Multiplier;

    public bool HasEnhacedSkills;

    public float UltimateLev1Multiplier;
    public float UltimateLev2Multiplier;
    public float UltimateLev3Multiplier;
    public float UltimateLev4Multiplier;
    public float UltimateLev5Multiplier;
    public float UltimateLev6Multiplier;
    public float UltimateLev7Multiplier;
    public float UltimateLev8Multiplier;
    public float UltimateLev9Multiplier;
    public float UltimateLev10Multiplier;
    public float UltimateLev11Multiplier;
    public float UltimateLev12Multiplier;

    public float TalentLev1Multiplier;
    public float TalentLev2Multiplier;
    public float TalentLev3Multiplier;
    public float TalentLev4Multiplier;
    public float TalentLev5Multiplier;
    public float TalentLev6Multiplier;
    public float TalentLev7Multiplier;
    public float TalentLev8Multiplier;
    public float TalentLev9Multiplier;
    public float TalentLev10Multiplier;
    public float TalentLev11Multiplier;
    public float TalentLev12Multiplier;

    public float TechniqueMultiplier;

    public bool IsA2TracesUnlocked;
    public bool IsA4TracesUnlocked;
    public bool IsA6TracesUnlocked;

    public int CostToLaunchUltimate;
    public bool HasASecondUltimate;
    public int CostToLaunchSecondUltimate;

    public int EnergyRegenerationWithBasicATK;
    public int EnergyRegenerationWithSkills;
    public int EnergyRegenerationWithUltimate;
    public int EnergyRegenerationWithTalent;
    public int EnergyRegenerationWithTechnique;

}
