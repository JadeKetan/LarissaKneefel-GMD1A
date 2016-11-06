using UnityEngine;
using System.Collections;

public class LaunchBall : MonoBehaviour
{
    public float secondsCount;//tijd in seconden (0,0) wegens wat precisere getallen
    public bool activated = false;//bool voor indrukken spatie
    public float maxTime = 1.5f;//maximale seconden dat ingedrukt kan worden
    public int maxForce = 400;//maximale kracht voor het afschieten
    public Vector3 richting = new Vector3(0, 0, -1);//de richting waar het object naartoe word geschoten
    public Rigidbody ball;//het gamobject dat word afgeschoten


    void Start()
    {

    }
    void Update()
    { 
        if (Input.GetButtonDown("Jump"))//als spatie word ingedrukt
        {
            secondsCount = 0;//waarde waar hij de float op zet
            activated = true;//zet bool op true
        }
        if (Input.GetButtonUp("Jump"))//als spatie word losgelaten
        {
            activated = false;//bool word false
            ball.AddForce(richting * secondsCount * maxForce);//voeg force aan object toe met(richting * tijd in seconden * maximale kracht)
        }
        if (activated == true && secondsCount < maxTime)//als bool gelijk is aan true en float is kleiner dan de maxTime
        {
            secondsCount = secondsCount + Time.deltaTime;//float word float + tijd per frame
        }
    }
}