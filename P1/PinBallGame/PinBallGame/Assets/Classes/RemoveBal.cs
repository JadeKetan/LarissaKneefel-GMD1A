using UnityEngine;
using System.Collections;

public class Removebal : MonoBehaviour
{

    public void OnCollisionEnter(Collision collision)
    {

        Ballcount.balls = Ballcount.balls - 1;

    }
}