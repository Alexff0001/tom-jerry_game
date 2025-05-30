using UnityEngine;

public class Health : MonoBehaviour
{
    //Значение здоровья
    public int health;
    //Максимальное значение здоровья
    public int maxHealth;

    //Функция получения урона
    public void TakeHit(int damage)
    {
        health -= damage;

        //Если здоровье меньше 0 - уничтожить объект на котором весит этот скрипт
        if (health <= 0)
        {
            Destroy(gameObject);
        }

    }
}
