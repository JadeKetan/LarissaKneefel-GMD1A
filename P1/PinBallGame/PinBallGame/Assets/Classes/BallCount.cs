using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Ballcount : MonoBehaviour
{
    public Text tekst;
    public static int balls;

    // Use this for initialization
    void Start()
    {

        balls = 3;

        tekst.text = balls.ToString("balls: ") + balls;

    }

    void Update()
    {
        tekst.text = balls.ToString("balls: ") + balls;

    }
}