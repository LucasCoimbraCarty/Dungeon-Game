using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private string enemyName;
    [SerializeField] protected float moveSpeed;
    private float healthPoint;
    [SerializeField] private float maxHealthPoint;

    protected Transform target;
    [SerializeField] protected float distance;
    protected SpriteRenderer spriteRenderer;

    void Start()
    {
        healthPoint = maxHealthPoint;
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        Introduction();
    }

    void Update()
    {
        Move();
        TurnDirection();
    }

    protected virtual void Introduction()
    {
        Debug.Log("My name is " + enemyName + ". I have " + maxHealthPoint + " health points." + moveSpeed + " is my speed.");
    }

    protected virtual void Move()
    {
        if (Vector2.Distance(transform.position, target.position) < distance)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, moveSpeed * Time.deltaTime);
        }
    }

    private void TurnDirection()
    {
        if (transform.position.x > target.position.x)
        {
            spriteRenderer.flipX = true;
        }
        else
        {
            spriteRenderer.flipX = false;
        }
    }
    
}
