using UnityEngine;

public class Player : Character
{

    [SerializeField] private Weapon activeWeapon;
    [SerializeField] private Weapon[] weapons;

    public string ActiveWeaponName
    {
        get { return activeWeapon.weaponName; }
    }
    private int selectedWeaponID = 0;
    public override void Attack(Character toHit)
    {
        toHit.TakeDamage(activeWeapon);

    }

    public void SwitchWeapon()
    {
        selectedWeaponID = (++selectedWeaponID) % weapons.Length;
        activeWeapon = weapons[selectedWeaponID];
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        activeWeapon = weapons[0];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
