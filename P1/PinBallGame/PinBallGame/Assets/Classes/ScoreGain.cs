using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreGain : MonoBehaviour
{

    public void OnCollisionEnter(Collision collision)
{
    if (gameObject.tag == "Bumper")
        {
        ScoreGain2.scoreGainUp += 1;
        }
    }
}

