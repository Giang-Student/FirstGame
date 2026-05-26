using UnityEngine;

public class Gun : MonoBehaviour

{
    [SerializeField] private Aim aim;

    [SerializeField] private Character owner;

    // [SerializeField] private float maxDistance = 10f; // khoảng cách tối đa mà gun có thể tồn tại

    public Transform FirePoint;

    public GameObject bulletPrefab;

    // time  to calculate how many bullet fired per second

    [SerializeField] private float fireRate;

    [SerializeField] private float time=0;

    public void setAim(Aim aim)
    {
        this.aim = aim;
    }

    public void setOwner(Character owner)
    {
        this.owner = owner;
    }

    public void setFireRate(float fireRate)
    {
        this.fireRate = fireRate;
    }

    public void setTime(float time)
    {
        this.time = time;
    }

    public void setFirePoint(Transform FirePoint)
    {
        this.FirePoint = FirePoint;
    }

    public void setBulletPrefab(GameObject bulletPrefab)
    {
        this.bulletPrefab = bulletPrefab;
    }

    public Aim getAim()
    {
        return aim;
    }

    public Character getOwner()
    {
        return owner;
    }

    public float getFireRate()
    {
        return fireRate;
    }

    public float getTime()
    {
        return time;
    }

    public Transform getFirePoint()
    {
        return FirePoint;
    }

    public GameObject getBulletPrefab()
    {
        return bulletPrefab;
    }

    public void aimTarget(Vector3 target)
    {
        // lấy vị trí mục tiêu rồi dùng tan để tính góc xoay cho gun

        Vector3 direction = target - transform.position;

        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.Euler(0, 0, angle);
    }

    public void positionGun(Character owner)
    {
        // đặt vị trí gun theo vị trí của nhân vật

        transform.position = new Vector3 (
            owner.transform.position.x,
            owner.transform.position.y,
            owner.transform.position.z-1
        );
    }

    public void flip()
    {
        if (aim.getMousePosition().x < owner.transform.position.x)
        {
            transform.Rotate(180f, 0f, 0f);
        }
    }

    public bool coolDownFire()
    {
        time += Time.deltaTime;

        float nextTimeToFire = 1f / fireRate;

        if(time >= nextTimeToFire)
        {
            if (owner.getFireCondition())
            {
                time = 0;

                return true;
            }
        }

        return false;
    }

    public void shoot()
    {
        {
            Instantiate(
                bulletPrefab,
                FirePoint.position,
                FirePoint.rotation
            );
        }
    }

    private void Update()
    {
        aimTarget(owner.getAimTarget());

        positionGun(getOwner());

        flip();

        if(coolDownFire())
        {
            if(owner.getFireCondition())
            {
                shoot();
            }
        }

        if(owner.getIsDead())
        {
            Destroy(gameObject);
        }

        // float distance = Vector3.Distance(FirePoint.position, transform.position);

        // if (distance >= maxDistance)
        // {
        //     Destroy(gameObject);
        // }
    }
}