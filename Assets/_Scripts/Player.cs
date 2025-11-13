using UnityEngine;
using UnityEngine.Events;
public class Player : MonoBehaviour
{
    [SerializeField]
    private string _horizontalAxis = "Horizontal", _verticalAxis = "Vertical";
    [SerializeField]
    private Rigidbody2D _rb2d;

    private Vector2 _input;
    private float _moveSpeed = 5f;
    [SerializeField]
    private float _speed = 3f;

    public UnityEvent OnPlayerDie;

    private void FixedUpdate()
    {
        _rb2d.linearVelocity = _input * _moveSpeed;
    }

    void Update()
    {
        float horizontalInput = Input.GetAxisRaw(_horizontalAxis); // left and right
        float verticalInput = Input.GetAxisRaw(_verticalAxis);     // up and down
        _input = new Vector2(horizontalInput, verticalInput);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (OnPlayerDie != null)
        {
            OnPlayerDie.Invoke();
        }
        ScoreManager.instance.UpdateGameOverText();
        Destroy(gameObject);
    }
}

public class MyRigidBody
{
    public float velocityX = 0;
    public float velocityY = 0;
}

