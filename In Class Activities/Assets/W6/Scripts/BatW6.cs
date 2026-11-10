using UnityEngine;

// Write the BatW6 class here.
public class BatW6 : MonoBehaviour
{

    [SerializeField] private float _speed = 3.0f;
    [SerializeField] private Transform _target;


    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, _target.position, _speed * Time.deltaTime);
    }

    public void StartChasing()
    {
          this.enabled = true;
    }

    public void StopChasing()
    {
        this.enabled = false;
    }
}
