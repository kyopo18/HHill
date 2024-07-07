//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class TutorialLoader : MonoBehaviour
//{
//    HotDogPlayer hotDogPlayer;
//    HBEnemy hBEnemy;

//    // Start is called before the first frame update
//    void Start()
//    {
//        // int = -10000000 - 1000000
//        // float = 100000000.5f < 1000000
//        // bool = true or false
//        // string = ""
//        // char[]
//        // char = ''
//        // double = float but 100000000000.0 and 10000000000000.0
//        // long = int but longer range

//        GameObject example = new GameObject(); // example procedural
        
//        HotDogPlayer hdp = new HotDogPlayer(10);
//        HBEnemy hBEnemy = new HBEnemy();
//        RangedBullet rangedBullet = new RangedBullet();
//        RangedWeapon rangedWeapon = new RangedWeapon(10, 2, 3.14f, rangedBullet, 3f);
        
//        hdp.Move();
//        hdp.speed = 10f;
//        HotDogPlayer hdp2 = new HotDogPlayer(10);
//        hdp2.speed = 12f;
//        hdp2.Move();

//        hdp.HDhealth.TakeDamage(10); //example of accessing method from another script
//    }

//    //// Update is called once per frame
//    //void Update()
//    //{
//    //    hotDogPlayer.Move();
//    //}
//}


