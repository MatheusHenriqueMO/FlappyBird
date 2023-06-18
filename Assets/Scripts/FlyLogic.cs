using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyLogic : MonoBehaviour
{
    public float flyForce;
    private Rigidbody2D rg2D;
    public GameOver game;
    // Start is called before the first frame update
    void Start()
    {
        rg2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Fly();
    }

    void Fly(){
        if(Input.GetMouseButtonDown(0)){
            rg2D.velocity = Vector2.up * flyForce;
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        game.GameOverActive();
    }

}
