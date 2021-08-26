using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "SRO / StaffType")]
public class StaffDataSO : ScriptableObject
{
    public string staffName;
    public int grade;
    public int attackPower;
    public float weight;
    public int flameDamage;
    public int requiredIntelligence;
    public int magicPower;
    public string staffDescription;
    
}
