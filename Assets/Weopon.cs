using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weopon : MonoBehaviour
{
    public Transform firePoint;
    public bool isShooting = false;


    // Update is called once per frame
    void Update()
    {  
        Elf_Controller elf = new Elf_Controller();
        isShooting = elf.isWalking;
    }
}
