using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Player : MonoBehaviour
{
    private Rigidbody rigid = null;

    public IPlayerInput PlayerInput { get; set; }

    private void Awake()
    {
        rigid = GetComponent<Rigidbody>();
        rigid.useGravity = false;
    }

    private void Update()
    {
        var vertical = PlayerInput.Vertical;
        var moveSpeed = 100f;

        rigid.AddForce(0, 0, vertical * moveSpeed);
    }
}