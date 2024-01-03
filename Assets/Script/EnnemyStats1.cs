using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemyStats1 : MonoBehaviour
{
    public int Level;
    public int Def;
    public int BaseDef = 200;
    void Start()
    {
        Level = 50;
        CalculateDef();
    }
    void Update()
    {
        
    }
    public void CalculateDef()
    {
        Def = (BaseDef + 10 * Level);
        print(Def);
    }
}
