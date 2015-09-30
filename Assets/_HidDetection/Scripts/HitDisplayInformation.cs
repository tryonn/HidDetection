using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class HitDisplayInformation : MonoBehaviour {
    [SerializeField] private BaseCharacter baseCharacter;

    private Text label;

    private void Awake()
    {
        label = GetComponent<Text>();
    }

    private void OnEnable()
    {
        baseCharacter.BeingHitEvent += OnBeingHit;
    }

    private void OnBeingHit(BodyIdentification bodyIdentification)
    {
        switch (bodyIdentification)
        {
            case BodyIdentification.Chest:
                Debug.Log(bodyIdentification);
                break;
            case BodyIdentification.Hand:
                Debug.Log(bodyIdentification);
                break;
            case BodyIdentification.Head:
                Debug.Log(bodyIdentification);
                break;

        }

        label.text = string.Format("Hit {0}", bodyIdentification);
    }
}
