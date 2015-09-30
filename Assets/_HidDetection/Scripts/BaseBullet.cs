using UnityEngine;
using System.Collections;

public class BaseBullet : MonoBehaviour {
    [SerializeField] private float speed = 10.0f;
    private Rigidbody rigidbody;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        // velocidade da bala recebe o transforme indicado para frente * a velocidade
        rigidbody.velocity = transform.forward * speed;

        Destroy(gameObject, 3f);
    }
}
