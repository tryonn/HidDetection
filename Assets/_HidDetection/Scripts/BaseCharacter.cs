using UnityEngine;
using System.Collections;
using System;

public class BaseCharacter : MonoBehaviour
{
    // Esse atributo será visualizado em outro local
    // um action como se fosse um delegate
    public Action<BodyIdentification> BeingHitEvent;

    internal void OnBeingHit(BodyIdentification bodyIdentification)
    {
        if (BeingHitEvent != null)
            BeingHitEvent(bodyIdentification);
    }
}
