using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectingBonuses : MonoBehaviour
{

    public void OnTriggerEnter(Collider Col)
    {
        if(Col.gameObject.tag == "Bonus")
        {
            Debug.Log("Bonus collected!");
            Bonuses.bonuses += 1;
            Destroy(Col.gameObject);
        }
    }
}
