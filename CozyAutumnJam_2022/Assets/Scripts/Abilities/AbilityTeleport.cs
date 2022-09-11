using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityTeleport : MonoBehaviour, IAbility
{
    [SerializeField] CardScriptableObject cardInformation;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ActivateAbility()
    {
        CharacterScript.Instance.TeleportPlayer();
    }
}
