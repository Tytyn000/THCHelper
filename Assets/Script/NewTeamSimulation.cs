using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewTeamSimulation : MonoBehaviour
{
    public int NumberOfCharacterInTeam;

    public string FirstCharacterName;
    public string SecondCharacterName;
    public string ThirdCharacterName;
    public string FourthCharacterName;

    public float SPD;

    public Text BasicATKMultiplierText;
    public Text BasicATKLevText;

    public Text SkillLevText;
    public Text SkillMultiplierText;

    public Text UltimateLevText;
    public Text UltimateMultiplierText;

    public Text TalenLevText;
    public Text TalentMultiplierText;

    public bool IsFirstCharacterA2TracesUnlocked;
    public bool IsFirstCharacterA4TracesUnlocked;
    public bool IsFirstCharacterA6TracesUnlocked;

    public PlayerStats JingYuanMultiplier;
    public PlayerStats PelaMultiplier;

    void Start()
    {

    }

    void Update()
    {
        if (FirstCharacterName.ToLower() == "arlan")
        {

        }
        else if (FirstCharacterName.ToLower() == "jing yuan")
        {

        }
    }
    public void CreateNewTeamSimulation()//bouton
    {
       

    }
    public void GetFirstCharacter(int IndexOfFirstCharacter)
    {
        if (IndexOfFirstCharacter == 0)
        {
            FirstCharacterName = "Arlan";
        }
        else if (IndexOfFirstCharacter == 1)
        {
            FirstCharacterName = "Asta";
        }
        else if (IndexOfFirstCharacter == 2)
        {
            FirstCharacterName = "Bailu";
        }
        else if (IndexOfFirstCharacter == 3)
        {
            FirstCharacterName = "Bronya";
        }
        else if (IndexOfFirstCharacter == 4)
        {
            FirstCharacterName = "Clara";
        }
        else if (IndexOfFirstCharacter == 5)
        {
            FirstCharacterName = "Dang Heng";
        }
        else if (IndexOfFirstCharacter == 6)
        {
            FirstCharacterName = "Gepard";
        }
        else if (IndexOfFirstCharacter == 7)
        {
            FirstCharacterName = "Herta";
        }
        else if (IndexOfFirstCharacter == 8)
        {
            FirstCharacterName = "Himeko";
        }
        else if (IndexOfFirstCharacter == 9)
        {
            FirstCharacterName = "Hook";
        }
        else if (IndexOfFirstCharacter == 10)
        {
            FirstCharacterName = "Jing Yuan";
        }
        else if (IndexOfFirstCharacter == 11)
        {
            FirstCharacterName = "March 7th";
        }
        else if (IndexOfFirstCharacter == 12)
        {
            FirstCharacterName = "Natasha";
        }
        else if (IndexOfFirstCharacter == 13)
        {
            FirstCharacterName = "Pela";
        }
        else if (IndexOfFirstCharacter == 14)
        {
            FirstCharacterName = "Qingque";
        }
        else if (IndexOfFirstCharacter == 15)
        {
            FirstCharacterName = "Sampo";
        }
        else if (IndexOfFirstCharacter == 16)
        {
            FirstCharacterName = "Seele";
        }
        else if (IndexOfFirstCharacter == 17)
        {
            FirstCharacterName = "Serval";
        }
        else if (IndexOfFirstCharacter == 18)
        {
            FirstCharacterName = "Sushang";
        }
        else if (IndexOfFirstCharacter == 19)
        {
            FirstCharacterName = "TingYun";
        }
        else if (IndexOfFirstCharacter == 20)
        {
            FirstCharacterName = "Welt";
        }
        else if (IndexOfFirstCharacter == 21)
        {
            FirstCharacterName = "Yanking";
        }
        else if (IndexOfFirstCharacter == 22)
        {
            FirstCharacterName = null;
        }
    }
    public void GetSecondCharacterIndex(int SecondCharacterIndex)
    {
        if (SecondCharacterIndex == 0)
        {
            SecondCharacterName = "Arlan";
        }
        else if (SecondCharacterIndex == 1)
        {
            SecondCharacterName = "Asta";
        }
        else if (SecondCharacterIndex == 2)
        {
            SecondCharacterName = "Bailu";
        }
        else if (SecondCharacterIndex == 3)
        {
            SecondCharacterName = "Bronya";
        }
        else if (SecondCharacterIndex == 4)
        {
            SecondCharacterName = "Clara";
        }
        else if (SecondCharacterIndex == 5)
        {
            SecondCharacterName = "Dang Heng";
        }
        else if (SecondCharacterIndex == 6)
        {
            SecondCharacterName = "Gepard";
        }
        else if (SecondCharacterIndex == 7)
        {
            SecondCharacterName = "Herta";
        }
        else if (SecondCharacterIndex == 8)
        {
            SecondCharacterName = "Himeko";
        }
        else if (SecondCharacterIndex == 9)
        {
            SecondCharacterName = "Hook";
        }
        else if (SecondCharacterIndex == 10)
        {
            SecondCharacterName = "Jing Yuan";
        }
        else if (SecondCharacterIndex == 11)
        {
            SecondCharacterName = "March 7th";
        }
        else if (SecondCharacterIndex == 12)
        {
            SecondCharacterName = "Natasha";
        }
        else if (SecondCharacterIndex == 13)
        {
            SecondCharacterName = "Pela";
        }
        else if (SecondCharacterIndex == 14)
        {
            SecondCharacterName = "Qingque";
        }
        else if (SecondCharacterIndex == 15)
        {
            SecondCharacterName = "Sampo";
        }
        else if (SecondCharacterIndex == 16)
        {
            SecondCharacterName = "Seele";
        }
        else if (SecondCharacterIndex == 17)
        {
            SecondCharacterName = "Serval";
        }
        else if (SecondCharacterIndex == 18)
        {
            SecondCharacterName = "Sushang";
        }
        else if (SecondCharacterIndex == 19)
        {
            SecondCharacterName = "TingYun";
        }
        else if (SecondCharacterIndex == 20)
        {
            SecondCharacterName = "Welt";
        }
        else if (SecondCharacterIndex == 21)
        {
            SecondCharacterName = "Yanking";
        }
        else if (SecondCharacterIndex == 22)
        {
            SecondCharacterName = null;
        }
    }
    public void GetThirdCharacterIndex(int ThirdCharacterIndex)
    {
        if (ThirdCharacterIndex == 0)
        {
            ThirdCharacterName = "Arlan";
        }
        else if (ThirdCharacterIndex == 1)
        {
            ThirdCharacterName = "Asta";
        }
        else if (ThirdCharacterIndex == 2)
        {
            ThirdCharacterName = "Bailu";
        }
        else if (ThirdCharacterIndex == 3)
        {
            ThirdCharacterName = "Bronya";
        }
        else if (ThirdCharacterIndex == 4)
        {
            ThirdCharacterName = "Clara";
        }
        else if (ThirdCharacterIndex == 5)
        {
            ThirdCharacterName = "Dang Heng";
        }
        else if (ThirdCharacterIndex == 6)
        {
            ThirdCharacterName = "Gepard";
        }
        else if (ThirdCharacterIndex == 7)
        {
            ThirdCharacterName = "Herta";
        }
        else if (ThirdCharacterIndex == 8)
        {
            ThirdCharacterName = "Himeko";
        }
        else if (ThirdCharacterIndex == 9)
        {
            ThirdCharacterName = "Hook";
        }
        else if (ThirdCharacterIndex == 10)
        {
            ThirdCharacterName = "Jing Yuan";
        }
        else if (ThirdCharacterIndex == 11)
        {
            ThirdCharacterName = "March 7th";
        }
        else if (ThirdCharacterIndex == 12)
        {
            ThirdCharacterName = "Natasha";
        }
        else if (ThirdCharacterIndex == 13)
        {
            ThirdCharacterName = "Pela";
        }
        else if (ThirdCharacterIndex == 14)
        {
            ThirdCharacterName = "Qingque";
        }
        else if (ThirdCharacterIndex == 15)
        {
            ThirdCharacterName = "Sampo";
        }
        else if (ThirdCharacterIndex == 16)
        {
            ThirdCharacterName = "Seele";
        }
        else if (ThirdCharacterIndex == 17)
        {
            ThirdCharacterName = "Serval";
        }
        else if (ThirdCharacterIndex == 18)
        {
            ThirdCharacterName = "Sushang";
        }
        else if (ThirdCharacterIndex == 19)
        {
            ThirdCharacterName = "TingYun";
        }
        else if (ThirdCharacterIndex == 20)
        {
            ThirdCharacterName = "Welt";
        }
        else if (ThirdCharacterIndex == 21)
        {
            ThirdCharacterName = "Yanking";
        }
        else if (ThirdCharacterIndex == 22)
        {
            ThirdCharacterName = null;
        }
    }
    public void GetFourthCharacterIndex(int FourthCharacterIndex)
    {
        if (FourthCharacterIndex == 0)
        {
            FourthCharacterName = "Arlan";
        }
        else if (FourthCharacterIndex == 1)
        {
            FourthCharacterName = "Asta";
        }
        else if (FourthCharacterIndex == 2)
        {
            FourthCharacterName = "Bailu";
        }
        else if (FourthCharacterIndex == 3)
        {
            FourthCharacterName = "Bronya";
        }
        else if (FourthCharacterIndex == 4)
        {
            FourthCharacterName = "Clara";
        }
        else if (FourthCharacterIndex == 5)
        {
            FourthCharacterName = "Dang Heng";
        }
        else if (FourthCharacterIndex == 6)
        {
            FourthCharacterName = "Gepard";
        }
        else if (FourthCharacterIndex == 7)
        {
            FourthCharacterName = "Herta";
        }
        else if (FourthCharacterIndex == 8)
        {
            FourthCharacterName = "Himeko";
        }
        else if (FourthCharacterIndex == 9)
        {
            FourthCharacterName = "Hook";
        }
        else if (FourthCharacterIndex == 10)
        {
            FourthCharacterName = "Jing Yuan";
        }
        else if (FourthCharacterIndex == 11)
        {
            FourthCharacterName = "March 7th";
        }
        else if (FourthCharacterIndex == 12)
        {
            FourthCharacterName = "Natasha";
        }
        else if (FourthCharacterIndex == 13)
        {
            FourthCharacterName = "Pela";
        }
        else if (FourthCharacterIndex == 14)
        {
            FourthCharacterName = "Qingque";
        }
        else if (FourthCharacterIndex == 15)
        {
            FourthCharacterName = "Sampo";
        }
        else if (FourthCharacterIndex == 16)
        {
            FourthCharacterName = "Seele";
        }
        else if (FourthCharacterIndex == 17)
        {
            FourthCharacterName = "Serval";
        }
        else if (FourthCharacterIndex == 18)
        {
            FourthCharacterName = "Sushang";
        }
        else if (FourthCharacterIndex == 19)
        {
            FourthCharacterName = "TingYun";
        }
        else if (FourthCharacterIndex == 20)
        {
            FourthCharacterName = "Welt";
        }
        else if (FourthCharacterIndex == 21)
        {
            FourthCharacterName = "Yanking";
        }
        else if (FourthCharacterIndex == 22)
        {
            FourthCharacterName = null;
        }
    }
    public void BasicATKSliderValueOfFirstCharacter(float CurrentBasicLevel)
    {
        CurrentBasicLevel = Mathf.RoundToInt(CurrentBasicLevel);
        BasicATKLevText.text = "Basic Level : " + CurrentBasicLevel.ToString();
        if (FirstCharacterName.ToLower() == "jing yuan")
        {
            if (CurrentBasicLevel == 1)
            {
                BasicATKMultiplierText.text = JingYuanMultiplier.BasicATKLev1Multiplier + "%".ToString();
            }
            else if (CurrentBasicLevel == 2)
            {
                BasicATKMultiplierText.text = JingYuanMultiplier.BasicATKLev2Multiplier + "%".ToString();
            }
            else if (CurrentBasicLevel == 3)
            {
                BasicATKMultiplierText.text = JingYuanMultiplier.BasicATKLev3Multiplier + "%".ToString();
            }
            else if (CurrentBasicLevel == 4)
            {
                BasicATKMultiplierText.text = JingYuanMultiplier.BasicATKLev4Multiplier + "%".ToString();
            }
            else if (CurrentBasicLevel == 5)
            {
                BasicATKMultiplierText.text = JingYuanMultiplier.BasicATKLev5Multiplier + "%".ToString();
            }
            else if (CurrentBasicLevel == 6)
            {
                BasicATKMultiplierText.text = JingYuanMultiplier.BasicATKLev6Multiplier + "%".ToString();
            }
            else if (CurrentBasicLevel == 7)
            {
                BasicATKMultiplierText.text = JingYuanMultiplier.BasicATKLev7Multiplier + "%".ToString();
            }
        }
        else if (FirstCharacterName.ToLower() == "pela")
        {
            if (CurrentBasicLevel == 1)
            {
                BasicATKMultiplierText.text = PelaMultiplier.BasicATKLev1Multiplier + "%".ToString();
            }
            else if (CurrentBasicLevel == 2)
            {
                BasicATKMultiplierText.text = PelaMultiplier.BasicATKLev2Multiplier + "%".ToString();
            }
            else if (CurrentBasicLevel == 3)
            {
                BasicATKMultiplierText.text = PelaMultiplier.BasicATKLev3Multiplier + "%".ToString();
            }
            else if (CurrentBasicLevel == 4)
            {
                BasicATKMultiplierText.text = PelaMultiplier.BasicATKLev4Multiplier + "%".ToString();
            }
            else if (CurrentBasicLevel == 5)
            {
                BasicATKMultiplierText.text = PelaMultiplier.BasicATKLev5Multiplier + "%".ToString();
            }
            else if (CurrentBasicLevel == 6)
            {
                BasicATKMultiplierText.text = PelaMultiplier.BasicATKLev6Multiplier + "%".ToString();
            }
            else if (CurrentBasicLevel == 7)
            {
                BasicATKMultiplierText.text = PelaMultiplier.BasicATKLev7Multiplier + "%".ToString();
            }
        }
    }
    public void SkillSliderValueOfFirstCharacter(float CurrentSkillLevel)
    {
        CurrentSkillLevel = Mathf.RoundToInt(CurrentSkillLevel);
        SkillLevText.text = "Skill Level : " + CurrentSkillLevel.ToString();
        if (FirstCharacterName.ToLower() == "jing yuan")
        {
            if (CurrentSkillLevel == 1)
            {
                SkillMultiplierText.text = JingYuanMultiplier.SkillLev1Multiplier + "%".ToString();
            }
            else if (CurrentSkillLevel == 2)
            {
                SkillMultiplierText.text = JingYuanMultiplier.SkillLev2Multiplier + "%".ToString();
            }
            else if (CurrentSkillLevel == 3)
            {
                SkillMultiplierText.text = JingYuanMultiplier.SkillLev3Multiplier + "%".ToString();
            }
            else if (CurrentSkillLevel == 4)
            {
                SkillMultiplierText.text = JingYuanMultiplier.SkillLev4Multiplier + "%".ToString();
            }
            else if (CurrentSkillLevel == 5)
            {
                SkillMultiplierText.text = JingYuanMultiplier.SkillLev5Multiplier + "%".ToString();
            }
            else if (CurrentSkillLevel == 6)
            {
                SkillMultiplierText.text = JingYuanMultiplier.SkillLev6Multiplier + "%".ToString();
            }
            else if (CurrentSkillLevel == 7)
            {
                SkillMultiplierText.text = JingYuanMultiplier.SkillLev7Multiplier + "%".ToString();
            }
            else if (CurrentSkillLevel == 8)
            {
                SkillMultiplierText.text = JingYuanMultiplier.SkillLev8Multiplier + "%".ToString();
            }
            else if (CurrentSkillLevel == 9)
            {
                SkillMultiplierText.text = JingYuanMultiplier.SkillLev9Multiplier + "%".ToString();
            }
            else if (CurrentSkillLevel == 10)
            {
                SkillMultiplierText.text = JingYuanMultiplier.SkillLev10Multiplier + "%".ToString();
            }
            else if (CurrentSkillLevel == 11)
            {
                SkillMultiplierText.text = JingYuanMultiplier.SkillLev11Multiplier + "%".ToString();
            }
            else if (CurrentSkillLevel == 12)
            {
                SkillMultiplierText.text = JingYuanMultiplier.SkillLev12Multiplier + "%".ToString();
            }
        }
        else if (FirstCharacterName.ToLower() == "pela")
        {

            if (CurrentSkillLevel == 1)
            {
                SkillMultiplierText.text = PelaMultiplier.SkillLev1Multiplier + "%".ToString();
            }
            else if (CurrentSkillLevel == 2)
            {
                SkillMultiplierText.text = PelaMultiplier.SkillLev2Multiplier + "%".ToString();
            }
            else if (CurrentSkillLevel == 3)
            {
                SkillMultiplierText.text = PelaMultiplier.SkillLev3Multiplier + "%".ToString();
            }
            else if (CurrentSkillLevel == 4)
            {
                SkillMultiplierText.text = PelaMultiplier.SkillLev4Multiplier + "%".ToString();
            }
            else if (CurrentSkillLevel == 5)
            {
                SkillMultiplierText.text = PelaMultiplier.SkillLev5Multiplier + "%".ToString();
            }
            else if (CurrentSkillLevel == 6)
            {
                SkillMultiplierText.text = PelaMultiplier.SkillLev6Multiplier + "%".ToString();
            }
            else if (CurrentSkillLevel == 7)
            {
                SkillMultiplierText.text = PelaMultiplier.SkillLev7Multiplier + "%".ToString();
            }
            else if (CurrentSkillLevel == 8)
            {
                SkillMultiplierText.text = PelaMultiplier.SkillLev8Multiplier + "%".ToString();
            }
            else if (CurrentSkillLevel == 9)
            {
                SkillMultiplierText.text = PelaMultiplier.SkillLev9Multiplier + "%".ToString();
            }
            else if (CurrentSkillLevel == 10)
            {
                SkillMultiplierText.text = PelaMultiplier.SkillLev10Multiplier + "%".ToString();
            }
            else if (CurrentSkillLevel == 11)
            {
                SkillMultiplierText.text = PelaMultiplier.SkillLev11Multiplier + "%".ToString();
            }
            else if (CurrentSkillLevel == 12)
            {
                SkillMultiplierText.text = PelaMultiplier.SkillLev12Multiplier + "%".ToString();
            }
        }
    }
    public void UltimateSliderValueOfFirstCharacter(float CurrentUltimateLevel)
    {
        CurrentUltimateLevel = Mathf.RoundToInt(CurrentUltimateLevel);
        UltimateLevText.text = "Ultimate Level : " + CurrentUltimateLevel.ToString();
        if (FirstCharacterName.ToLower() == "jing yuan")
        {
            if (CurrentUltimateLevel == 1)
            {
                UltimateMultiplierText.text = JingYuanMultiplier.UltimateLev1Multiplier + "%".ToString();
            }
            if (CurrentUltimateLevel == 2)
            {
                UltimateMultiplierText.text = JingYuanMultiplier.UltimateLev2Multiplier + "%".ToString();
            }
            if (CurrentUltimateLevel == 3)
            {
                UltimateMultiplierText.text = JingYuanMultiplier.UltimateLev3Multiplier + "%".ToString();
            }
            if (CurrentUltimateLevel == 4)
            {
                UltimateMultiplierText.text = JingYuanMultiplier.UltimateLev4Multiplier + "%".ToString();
            }
            if (CurrentUltimateLevel == 5)
            {
                UltimateMultiplierText.text = JingYuanMultiplier.UltimateLev5Multiplier + "%".ToString();
            }
            if (CurrentUltimateLevel == 6)
            {
                UltimateMultiplierText.text = JingYuanMultiplier.UltimateLev6Multiplier + "%".ToString();
            }
            if (CurrentUltimateLevel == 7)
            {
                UltimateMultiplierText.text = JingYuanMultiplier.UltimateLev7Multiplier + "%".ToString();
            }
            if (CurrentUltimateLevel == 8)
            {
                UltimateMultiplierText.text = JingYuanMultiplier.UltimateLev8Multiplier + "%".ToString();
            }
            if (CurrentUltimateLevel == 9)
            {
                UltimateMultiplierText.text = JingYuanMultiplier.UltimateLev9Multiplier + "%".ToString();
            }
            if (CurrentUltimateLevel == 10)
            {
                UltimateMultiplierText.text = JingYuanMultiplier.UltimateLev10Multiplier + "%".ToString();
            }
            if (CurrentUltimateLevel == 11)
            {
                UltimateMultiplierText.text = JingYuanMultiplier.UltimateLev11Multiplier + "%".ToString();
            }
            if (CurrentUltimateLevel == 12)
            {
                UltimateMultiplierText.text = JingYuanMultiplier.UltimateLev12Multiplier + "%".ToString();
            }
        }
        else if (FirstCharacterName.ToLower() == "pela")
        {
            if (CurrentUltimateLevel == 1)
            {
                UltimateMultiplierText.text = PelaMultiplier.UltimateLev1Multiplier + "%".ToString();
            }
            if (CurrentUltimateLevel == 2)
            {
                UltimateMultiplierText.text = PelaMultiplier.UltimateLev2Multiplier + "%".ToString();
            }
            if (CurrentUltimateLevel == 3)
            {
                UltimateMultiplierText.text = PelaMultiplier.UltimateLev3Multiplier + "%".ToString();
            }
            if (CurrentUltimateLevel == 4)
            {
                UltimateMultiplierText.text = PelaMultiplier.UltimateLev4Multiplier + "%".ToString();
            }
            if (CurrentUltimateLevel == 5)
            {
                UltimateMultiplierText.text = PelaMultiplier.UltimateLev5Multiplier + "%".ToString();
            }
            if (CurrentUltimateLevel == 6)
            {
                UltimateMultiplierText.text = PelaMultiplier.UltimateLev6Multiplier + "%".ToString();
            }
            if (CurrentUltimateLevel == 7)
            {
                UltimateMultiplierText.text = PelaMultiplier.UltimateLev7Multiplier + "%".ToString();
            }
            if (CurrentUltimateLevel == 8)
            {
                UltimateMultiplierText.text = PelaMultiplier.UltimateLev8Multiplier + "%".ToString();
            }
            if (CurrentUltimateLevel == 9)
            {
                UltimateMultiplierText.text = PelaMultiplier.UltimateLev9Multiplier + "%".ToString();
            }
            if (CurrentUltimateLevel == 10)
            {
                UltimateMultiplierText.text = PelaMultiplier.UltimateLev10Multiplier + "%".ToString();
            }
            if (CurrentUltimateLevel == 11)
            {
                UltimateMultiplierText.text = PelaMultiplier.UltimateLev11Multiplier + "%".ToString();
            }
            if (CurrentUltimateLevel == 12)
            {
                UltimateMultiplierText.text = PelaMultiplier.UltimateLev12Multiplier + "%".ToString();
            }
        }
    }
    public void TalentSliderValueOfFirstCharacter(float CurrentTalenLevel)
    {
        CurrentTalenLevel = Mathf.RoundToInt(CurrentTalenLevel);
        TalenLevText.text = "Talent Level : " + CurrentTalenLevel.ToString();
        if (FirstCharacterName.ToLower() == "jing yuan")
        {
            if (CurrentTalenLevel == 1)
            {
                TalentMultiplierText.text  = JingYuanMultiplier.TalentLev1Multiplier + "%".ToString();
            }
            if (CurrentTalenLevel == 2)
            {
                TalentMultiplierText.text = JingYuanMultiplier.TalentLev2Multiplier + "%".ToString();
            }
            if (CurrentTalenLevel == 3)
            {
                TalentMultiplierText.text = JingYuanMultiplier.TalentLev3Multiplier + "%".ToString();
            }
            if (CurrentTalenLevel == 4)
            {
                TalentMultiplierText.text = JingYuanMultiplier.TalentLev4Multiplier + "%".ToString();
            }
            if (CurrentTalenLevel == 5)
            {
                TalentMultiplierText.text = JingYuanMultiplier.TalentLev5Multiplier + "%".ToString();
            }
            if (CurrentTalenLevel == 6)
            {
                TalentMultiplierText.text = JingYuanMultiplier.TalentLev6Multiplier + "%".ToString();
            }
            if (CurrentTalenLevel == 7)
            {
                TalentMultiplierText.text = JingYuanMultiplier.TalentLev7Multiplier + "%".ToString();
            }
            if (CurrentTalenLevel == 8)
            {
                TalentMultiplierText.text = JingYuanMultiplier.TalentLev8Multiplier + "%".ToString();
            }
            if (CurrentTalenLevel == 9)
            {
                TalentMultiplierText.text = JingYuanMultiplier.TalentLev9Multiplier + "%".ToString();
            }
            if (CurrentTalenLevel == 10)
            {
                TalentMultiplierText.text = JingYuanMultiplier.TalentLev10Multiplier + "%".ToString();
            }
            if (CurrentTalenLevel == 11)
            {
                TalentMultiplierText.text = JingYuanMultiplier.TalentLev11Multiplier + "%".ToString();
            }
            if (CurrentTalenLevel == 12)
            {
                TalentMultiplierText.text = JingYuanMultiplier.TalentLev12Multiplier + "%".ToString();
            }
        }
        else if (FirstCharacterName.ToLower() == "pela")
        {
            if (CurrentTalenLevel == 1)
            {
                TalentMultiplierText.text = PelaMultiplier.TalentLev1Multiplier + "%".ToString();
            }
            if (CurrentTalenLevel == 2)
            {
                TalentMultiplierText.text = PelaMultiplier.TalentLev2Multiplier + "%".ToString();
            }
            if (CurrentTalenLevel == 3)
            {
                TalentMultiplierText.text = PelaMultiplier.TalentLev3Multiplier + "%".ToString();
            }
            if (CurrentTalenLevel == 4)
            {
                TalentMultiplierText.text = PelaMultiplier.TalentLev4Multiplier + "%".ToString();
            }
            if (CurrentTalenLevel == 5)
            {
                TalentMultiplierText.text = PelaMultiplier.TalentLev5Multiplier + "%".ToString();
            }
            if (CurrentTalenLevel == 6)
            {
                TalentMultiplierText.text = PelaMultiplier.TalentLev6Multiplier + "%".ToString();
            }
            if (CurrentTalenLevel == 7)
            {
                TalentMultiplierText.text = PelaMultiplier.TalentLev7Multiplier + "%".ToString();
            }
            if (CurrentTalenLevel == 8)
            {
                TalentMultiplierText.text = PelaMultiplier.TalentLev8Multiplier + "%".ToString();
            }
            if (CurrentTalenLevel == 9)
            {
                TalentMultiplierText.text = PelaMultiplier.TalentLev9Multiplier + "%".ToString();
            }
            if (CurrentTalenLevel == 10)
            {
                TalentMultiplierText.text = PelaMultiplier.TalentLev10Multiplier + "%".ToString();
            }
            if (CurrentTalenLevel == 11)
            {
                TalentMultiplierText.text = PelaMultiplier.TalentLev11Multiplier + "%".ToString();
            }
            if (CurrentTalenLevel == 12)
            {
                TalentMultiplierText.text = PelaMultiplier.TalentLev12Multiplier + "%".ToString();
            }
        }
    }
    public void IsFirstCharacterA2TraceUnlocked(bool A2TraceState)
    {
        IsFirstCharacterA2TracesUnlocked = A2TraceState;
        if (FirstCharacterName.ToLower() == "jing yuan")
        {
            //faire un truc pour jing yuan 
        }
        else if (FirstCharacterName.ToLower() == "pela")
        {
            //faire un truc pour pela
        }
    }
    public void IsFirstCharacterA4TraceUnlocked(bool A4TraceState)
    {
        IsFirstCharacterA4TracesUnlocked = A4TraceState;
        if (FirstCharacterName.ToLower() == "jing yuan")
        {
            //faire un truc pour jing yuan 
        }
        else if (FirstCharacterName.ToLower() == "pela")
        {
            //faire un truc pour pela
        }
    }
    public void IsFirstCharacterA6TraceUnlocked(bool A6TraceState)
    {
        IsFirstCharacterA6TracesUnlocked = A6TraceState;
        if (FirstCharacterName.ToLower() == "jing yuan")
        {
            //faire un truc pour jing yuan 
        }
        else if (FirstCharacterName.ToLower() == "pela")
        {
            //faire un truc pour pela
        }
    }
    /*ordre d'ajout des persos
     * 02/01/23 jing yuan
     * 02/01/23 pela
     */
}
