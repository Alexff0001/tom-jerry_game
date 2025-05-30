using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

    public class Counter : MonoBehaviour
    {
        public GameObject Wasted;
        public GameObject Back;
        public TMPro.TMP_Text Life;
        public int lifes;

        void Start()
        {
            Wasted.SetActive(false);
            Back.SetActive(false);
            Life.text = "Осталось: " + lifes.ToString();
        }
        void OnTriggerEnter2D(Collider2D other)
        {
            if (other.tag == "Dead")
            {
                lifes--;
                Life.text = "Осталось: " + lifes.ToString();
                if (lifes == 0)
                {
                    Life.text = "";
                    Back.SetActive(true);
                    Wasted.SetActive(true);

                    Time.timeScale = 0;
                }
            }
        }

    }