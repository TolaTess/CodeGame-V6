
using UnityEngine;

public class WeaponController : MonoBehaviour
{

    public float damage = 10f;
    public float range = 100f;
    [SerializeField]
    private ParticleSystem gunParticle;

    [SerializeField]
    private AudioSource gunAudio;

    private Camera fpsCam;

    void Start()
    {
        fpsCam = FindObjectOfType<Camera>();
    }

    /// <summary>
    /// Update camara to the mouseposition and use plane calculation to get the vector of the mouse position.
    /// store camera raylegth in a new variable and look at the variable's transform. 
    /// if control button pressed, shoot.
    /// </summary>
    void Update()
    {
        Ray newfpsCam = fpsCam.ScreenPointToRay(Input.mousePosition);
        Plane newPlane = new Plane(Vector3.down, Vector3.zero);
        float rayLength;

        if (newPlane.Raycast(newfpsCam, out rayLength))
        {
            Vector3 shootPoint = newfpsCam.GetPoint(rayLength);
            transform.LookAt(shootPoint);
        }
        if (Input.GetButtonDown("Fire1") || Input.GetKeyDown(KeyCode.T))
        {
            Shoot();
           
        }
    }
    /// <summary>
    /// 
    /// shoot method to play particle and audio
    /// also send a raycast out to the target - using TargetScript
    /// if target is not null, target to take damage
    /// </summary>
    void Shoot()
    {
        gunParticle.Play();
        gunAudio.Play();

         RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, range))
        {
            JavaTarget1 target = hit.transform.GetComponent<JavaTarget1>();
            MarkovChain target2 = hit.transform.GetComponent<MarkovChain>();

            if (target!= null )
            {
                target.DamageToTarget(damage);
            }

            if (target2 != null)
            {
                target2.DamageToTarget2(damage);
            }

        }


    }
}
  