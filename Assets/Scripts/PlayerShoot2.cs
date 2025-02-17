using UnityEngine;
using UnityEngine.Experimental.AI;

public class PlayerShoot2 : MonoBehaviour
{
    public GameObject preFab2;
    public Transform bulletTrash;
    public Transform bulletSpawn;


    private const float Timer = 0.5f;
    private float _currentTime = 0.5f;
    private bool _canShoot = true;
    private void Update()
    {
        TimerMethod();
        Shoot();
    }



    private void TimerMethod()
    {
        if (!_canShoot)
        {
            _currentTime -= Time.deltaTime;

            if (_currentTime < 0)
            {
                _canShoot = true;
                _currentTime = Timer;
            }
        }
    }
    private void Shoot()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1) && _canShoot)
        {
            GameObject bullet2 = Instantiate(preFab2, bulletSpawn.position, Quaternion.identity);

            bullet2.transform.SetParent(bulletTrash);

            _canShoot = false;
        }
    }
}

