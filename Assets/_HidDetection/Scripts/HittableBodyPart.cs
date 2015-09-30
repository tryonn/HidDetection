using UnityEngine;
using System.Collections;

// class que identifica em qual parte do corpo 
// foi acertado o objeto (bala, faca.... etc)

// Enemu com as partes do corpo que seram acertada para serem identificada
public enum BodyIdentification
{
    Head,
    Chest,
    Hand

}

public class HittableBodyPart : MonoBehaviour {
    [SerializeField] private BodyIdentification bodyIdentification;

    private BaseCharacter baseCharacter;

    private void Awake()
    {
        baseCharacter = GetComponentInParent<BaseCharacter>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        baseCharacter.OnBeingHit(bodyIdentification);
    }
}
