using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class EnemyVFXManager : MonoBehaviour
{
    public VisualEffect footStep;
    public VisualEffect AttackVFX;


    public void PlayAttackVFX()
    {
        AttackVFX.SendEvent("OnPlay");
    }

    public void BurstFootStep()
    {
        footStep.SendEvent("OnPlay");
    }
}