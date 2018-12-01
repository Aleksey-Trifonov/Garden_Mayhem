using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defender : MonoBehaviour {

    public void AddStarsEvent(int amount)
    {
        FindObjectOfType<StarDisplay>().AddStars(amount);
    }

}
