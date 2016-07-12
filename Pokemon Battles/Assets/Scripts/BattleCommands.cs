using UnityEngine;
using System.Collections;

public class BattleCommands : MonoBehaviour
{
    Vector3 originalPosition;
    // Use this for initialization
    void Start ()
    {
        originalPosition = this.transform.localPosition;
    }
    
    void OnAttack()
    {
        OnReset();   
    }

    void OnDodge()
    {
        OnReset();
    }

    void OnEvade()
    {
        OnReset();
    }

    void OnReset()
    {
        // Put the sphere back into its original local position.
        this.transform.localPosition = new Vector3(100, 100, 100);
    }
}
