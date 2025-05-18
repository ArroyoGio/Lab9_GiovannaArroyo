using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //velocidad del movimiento del player
    public float speed = 6f;

    //update lo llamamos una vez por cada frame
    void Update()
    {
        //movimiento horizontal, derecha e izquierda ---- A y D
        float horizontal = Input.GetAxis("Horizontal");

        //movimiento vertical, arriba y abajo ---- W y S
        float vertical = Input.GetAxis("Vertical");

        //vector que representa el movimiento del jugador en el plano XZ (no se mueve en Y)
        Vector3 movement = new Vector3(horizontal, 0, vertical);

        //mueve al jugador multiplicando por la velocidad y por el tiempo entre frames
        transform.Translate(movement* speed * Time.deltaTime);
    }
}
