using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreAdd : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        ScoreController.scoreValue++;
    }
}
