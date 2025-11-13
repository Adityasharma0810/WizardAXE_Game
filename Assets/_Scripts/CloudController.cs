using UnityEngine;

public class CloudController : MonoBehaviour
{
    [SerializeField]
    private Transform[] _clouds;
    [SerializeField]
    private float _speed = 1.0f;
    [SerializeField]

    private float _xlimit = 12.5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < _clouds.Length; i++)
        {
            _clouds[i].position = _clouds[i].position + Vector3.right * Time.deltaTime * _speed;
            if (_clouds[i].position.x > _xlimit)
            {
                _clouds[i].position -= new Vector3(2*_xlimit, 0, 0);
            }
        }
        
    }
}
