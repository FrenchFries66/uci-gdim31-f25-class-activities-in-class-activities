using UnityEngine;

// Write the BatW6 class here.
public class BatW6 : MonoBehaviour
{

    [SerializeField] private float _speed = 3.0f;
    private Transform _target;
    private bool _isChasing = false;

    private void Start()
    {
        _target = GameObject.Find("Cat").transform;
        StartChasing();
    }

    private void Update()
    {
        if (_isChasing)
        {
            transform.position = Vector2.MoveTowards(transform.position, _target.position, _speed * Time.deltaTime);
        }
    }

    public void StartChasing()
    {
        _isChasing = true;
    }

    public void StopChasing()
    {
        _isChasing = false;
    }
}
