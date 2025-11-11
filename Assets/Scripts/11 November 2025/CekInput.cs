//using System.Numerics;
//using Unity.Mathematics;
using UnityEngine;

public class CekInput : MonoBehaviour
{
    public GameObject _TimbulTenggelam;
    public GameObject _untukSpawn;
    public GameObject _targetHancur;
    public GameObject _kotakBerwarna;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Tombol spasi ditekan");
        }

        if (Input.GetKeyDown(KeyCode.O))
        {
            Debug.Log("Tombol O ditekan, objek muncul");
            _TimbulTenggelam.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            Debug.Log("Tombol P ditekan, objek hilang");
            _TimbulTenggelam.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Tombol enter ditekan, objek muncul secara acak");
            //Instantiate(_untukSpawn);            
            Vector3 spawnPosition = new Vector3(Random.Range(-7, 7), Random.Range(-4, 4), 0);
            Quaternion spawnRotation = Quaternion.Euler(0, 0, Random.Range(0, 180));
            Instantiate(_untukSpawn, spawnPosition, spawnRotation);
        }

        if (Input.GetKeyDown(KeyCode.M))
        {
            GameObject hancurkan = GameObject.Find("SpawnCapsule(Clone)");
            Debug.Log("Tombol M ditekan, objek hancur");
            Destroy(_targetHancur);
            Destroy(hancurkan);
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            Debug.Log("Tombol C ditekan, warna berubah");
            SpriteRenderer _localSpriteRenderer = _kotakBerwarna.GetComponent<SpriteRenderer>();
            Color WarnaAcak = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
            _localSpriteRenderer.color = WarnaAcak;
        }
    }
}
