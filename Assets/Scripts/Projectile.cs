using Unity.VisualScripting;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] Transform Player;
    [SerializeField] float moveSpeed = 0.01f;
    Vector3 Playerposition;

    void Awake()
    {
        gameObject.SetActive(false);   
    }
    void Start()
    {
        Playerposition = Player.transform.position;
    }

    void Update()
    {
        Projectilemovement();
        DestroyWhenReached();
    }

    void Projectilemovement()
    {
         transform.position = Vector3.MoveTowards(transform.position, Playerposition, Time.deltaTime * moveSpeed);
    }

    void DestroyWhenReached()
    {
        if (Playerposition == transform.position)
        {
            Destroy(gameObject);
        }
    }
}
