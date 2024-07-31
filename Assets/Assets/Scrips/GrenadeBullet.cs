using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrenadeBullet : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject explosionPrefab;
    public float explosionRadius;
    public float explosionForce;
    public int damage;

    private void OnCollisionEnter(Collision collision)
    {
        Instantiate(explosionPrefab, transform.position, transform.rotation);
        Destroy(gameObject);
    }
    private void BlowObjects()
    {
        Collider[] affectedObjects = Physics.OverlapSphere(transform.position, explosionRadius);
        for (int i = 0; i < affectedObjects.Length; i++)
        {
            DeliverDamage(affectedObjects[i]);
            AddForceToObjects(affectedObjects[i]);
            
        }
    }
    private void DeliverDamage(Collider victim)
    {
        Health health = victim.GetComponent<Health>();
        if (health != null)
        {
            health.TakeDamage(damage);
        }
    }
    private void AddForceToObjects(Collider affectedObject)
    {
        Rigidbody rigidbody = affectedObject.attachedRigidbody;
        if (rigidbody)
        {
            rigidbody.AddExplosionForce(explosionForce, transform.position, explosionRadius, 1, ForceMode.Impulse);
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
