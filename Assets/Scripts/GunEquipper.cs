using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunEquipper : MonoBehaviour
{
    public static string activeWeaponType;

    public GameObject pistol;
    public GameObject assaultRifle;
    public GameObject shotgun;

    public GameObject activeGun;
    // Start is called before the first frame update
    void Start()
    {
        activeWeaponType = Constants.Pistol;
        activeGun = pistol;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void loadWeapon(GameObject weapon)
    {
        pistol.SetActive(false);
        assaultRifle.SetActive(false);
        shotgun.SetActive(false);

        weapon.SetActive(true);
        activeGun = weapon;
    }
}
