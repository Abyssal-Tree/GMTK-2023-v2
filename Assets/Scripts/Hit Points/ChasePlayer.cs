using UnityEngine;

public class ChasePlayer : MonoBehaviour
{

    [SerializeField] private float speed;
    [SerializeField] private Transform root;

    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponentInParent<Rigidbody>();
    }

    private void Update()
    {
        var playerPos = Player.Instance.transform.position;
        var dir = playerPos - transform.position;
        dir.Normalize();
        root.right = dir;
        rb.velocity = dir * speed;
    }
}