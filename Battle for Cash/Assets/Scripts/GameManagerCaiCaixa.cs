using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerCaiCaixa : MonoBehaviour
{

    public GameObject PrefabCaixa;
     GameObject CaixaTimerComponents;

    public int CaixaSpawnChanceX;
    public int CaixaSpawnChanceY;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {

            CaixaSpawnChanceX = Random.Range(-10, 10);
            CaixaSpawnChanceY = Random.Range(-10, 10);

            CaixaTimerComponents = Instantiate(PrefabCaixa, new Vector3(CaixaSpawnChanceX, 10, CaixaSpawnChanceY), Quaternion.identity);
            Destroy(CaixaTimerComponents.GetComponent<Rigidbody>(),5);
        }
    }
}
