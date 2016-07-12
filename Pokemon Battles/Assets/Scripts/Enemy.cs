using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour
{
    public float speed = 50.0f;
    private GameObject _player;
    private Transform _target;

    Vector3 originalPosition;

    // Use this for initialization
    void Start ()
    {
        originalPosition = this.transform.localPosition;
        _player = GameObject.FindGameObjectWithTag("Player");
        _target = _player.transform;
    }
	
	// Update is called once per frame
	void Update ()
    {
        transform.position = Vector3.MoveTowards(transform.position, _target.position, speed * Time.deltaTime);
    }

    void OnCollisionEnter(Collision col)
    {
        Debug.Log("Hit");
        this.transform.localPosition = originalPosition;
    }
}
