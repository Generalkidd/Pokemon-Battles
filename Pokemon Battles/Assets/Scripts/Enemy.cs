using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour
{
    public float speed = 50.0f;
    private GameObject _player;
    private Transform _target;

    private bool move = false;

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
        if (move == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, _target.position, speed * Time.deltaTime);
        }
    }

    void OnCollisionEnter(Collision col)
    {
        move = false;
        this.transform.localPosition = originalPosition;
    }

    void OnSelect()
    {
        move = true;
    }
}
