
using UnityEngine;

public class Gun : MonoBehaviour
//  : LongRangeWeapon
// {
// [SerializeField] private Aim aim;
// [SerializeField] private Character character;

// public Gun(string weaponName, int damage, float fireRate,
//  Bullet bulletPrefab, Transform firePoint, int ammo) 
//  : base(weaponName, damage, fireRate, bulletPrefab,firePoint, ammo)
// {
// }


// public Aim getAim()
// {
//     return aim;
// }
// public Character getCharacter()
// {
//     return character;
// }
// public void aimTarget(Aim aim)
// {
//     // lấy vị trí mục tiêu rồi dùng tan để tính góc xoay cho gun
//     Vector3 target = aim.getMousePosition();
//     Vector3 direction = target - transform.position;
//     float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
//     transform.rotation = Quaternion.Euler(0, 0, angle);
// }
// public void positionGun(Character character)
// {
//     // đặt vị trí gun theo vị trí của nhân vật
//     transform.position = character.transform.position;
// }
// public void shoot()
// {
//     Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
// }
// private void Update()
// {
//     aimTarget(getAim());
//     positionGun(getCharacter());
// }
// }
{
    [SerializeField] private Aim aim;
    [SerializeField] private Character character;
    // [SerializeField] private float maxDistance = 10f; // khoảng cách tối đa mà gun có thể tồn tại
    public Transform FirePoint;
    public GameObject bulletPrefab;
    // time  to calculate how many bullet fired per second
    [SerializeField] private float fireRate;
    public Aim getAim()
    {
        return aim;
    }
    public Character getCharacter()
    {
        return character;
    }
    public void aimTarget(Aim aim)
    {
        // lấy vị trí mục tiêu rồi dùng tan để tính góc xoay cho gun
        Vector3 target = aim.getMousePosition();
        Vector3 direction = target - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, angle);
    }
    public void positionGun(Character character)
    {
        // đặt vị trí gun theo vị trí của nhân vật
        transform.position = character.transform.position;
    }
    public void flip()
    {
        if (aim.getMousePosition().x < character.transform.position.x)
        {
            transform.Rotate(180f, 0f, 0f);
        }
    }
    [SerializeField] private float time=0;
    private void Update()
    {
        aimTarget(getAim());
        positionGun(getCharacter());
        flip();
        if(coolDownFire())
        {
            shoot();
        }
        ;
        // float distance = Vector3.Distance(FirePoint.position, transform.position);

        // if (distance >= maxDistance)
        // {
        //     Destroy(gameObject);
        // }

    }
    public bool coolDownFire()
    {

        time += Time.deltaTime;
        float nextTimeToFire = 1f / fireRate;
        if(time >= nextTimeToFire)
        {
            if (Input.GetButton("Fire1"))
            {
                time = 0;
                return true;
            }
        }
        return false;
    }
    public void shoot()
    {
        if (Input.GetButton("Fire1"))
        {
            Instantiate(bulletPrefab, FirePoint.position, FirePoint.rotation);
        }
    }
}