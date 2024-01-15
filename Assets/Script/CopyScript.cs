using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CopyScript : MonoBehaviour
{
    public Text DamageText;

    public Text Hit1DamageText;
    public Text Hit2DamageText;
    public Text Hit3DamageText;
    public Text Hit4DamageText;
    public Text Hit5DamageText;
    public Text Hit6DamageText;
    public Text Hit7DamageText;

    void Start()
    {
        
    }
    void Update()
    {
        
    }
    public void CopyHit1Damage()
    {
        TextEditor textEditor = new TextEditor();
        textEditor.text = Hit1DamageText.text;
        textEditor.SelectAll();
        textEditor.Copy();
    }
    public void CopyHit2Damage()
    {
        TextEditor textEditor = new TextEditor();
        textEditor.text = Hit2DamageText.text;
        textEditor.SelectAll();
        textEditor.Copy();
    }
    public void CopyHit3Damage()
    {
        TextEditor textEditor = new TextEditor();
        textEditor.text = Hit3DamageText.text;
        textEditor.SelectAll();
        textEditor.Copy();
    }   
    public void CopyHit4Damage()
    {
        TextEditor textEditor = new TextEditor();
        textEditor.text = Hit4DamageText.text;
        textEditor.SelectAll();
        textEditor.Copy();
    }
    public void CopyHit5Damage()
    {
        TextEditor textEditor = new TextEditor();
        textEditor.text = Hit5DamageText.text;
        textEditor.SelectAll();
        textEditor.Copy();
    }
    public void CopyHit6Damage()
    {
        TextEditor textEditor = new TextEditor();
        textEditor.text = Hit6DamageText.text;
        textEditor.SelectAll();
        textEditor.Copy();
    }
    public void CopyHit7Damage()
    {
        TextEditor textEditor = new TextEditor();
        textEditor.text = Hit7DamageText.text;
        textEditor.SelectAll();
        textEditor.Copy();
    }
    public void CopyToClipboard()
    {
        TextEditor textEditor = new TextEditor();
        textEditor.text = DamageText.text;
        textEditor.SelectAll();
        textEditor.Copy();
    }
}
