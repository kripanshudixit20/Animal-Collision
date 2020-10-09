using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectMouseClick : MonoBehaviour
{
    [SerializeField]
    GameObject Animal0;
    [SerializeField]
    GameObject Animal1;
    [SerializeField]
    GameObject Animal2;
    [SerializeField]
    GameObject Animal3;
    [SerializeField]
    GameObject Animal4;
    [SerializeField]
    GameObject Animal5;

    GameObject currentCharacter;

    int randomX, randomY;
    

    // Start is called before the first frame update
    void Start()
    {
        // Spawn a character at the middle of the screen
        currentCharacter = Instantiate<GameObject>(Animal1, Vector3.zero, Quaternion.identity);

        randomX = Random.Range(0, 10);
        randomY = Random.Range(0, 10);

        currentCharacter.GetComponent<Rigidbody2D>().AddForce(new Vector2(randomX, randomY), ForceMode2D.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        // Check if the left mouse button is clicked
        if (Input.GetMouseButtonDown(0))
        {
            // Get the position of the currently instantiated character
            Vector3 currentPosition = currentCharacter != null ? currentCharacter.transform.position : Vector3.zero;

            // Instantiating a random character
            int randomNumber = Random.Range(0, 6);
            if (randomNumber == 0)
            {
                currentCharacter = Instantiate(Animal0, currentPosition, Quaternion.identity);

                randomX = Random.Range(0, 10);
                randomY = Random.Range(0, 10);

                currentCharacter.GetComponent<Rigidbody2D>().AddForce(new Vector2(randomX, randomY), ForceMode2D.Impulse);
            }
            else if (randomNumber == 0)
            {
                currentCharacter = Instantiate(Animal1, currentPosition, Quaternion.identity);

                randomX = Random.Range(0, 10);
                randomY = Random.Range(0, 10);

                currentCharacter.GetComponent<Rigidbody2D>().AddForce(new Vector2(randomX, randomY), ForceMode2D.Impulse);
            }
            else if (randomNumber == 1)
            {
                currentCharacter = Instantiate(Animal2, currentPosition, Quaternion.identity);

                randomX = Random.Range(0, 10);
                randomY = Random.Range(0, 10);

                currentCharacter.GetComponent<Rigidbody2D>().AddForce(new Vector2(randomX, randomY), ForceMode2D.Impulse);
            }
            else if (randomNumber == 2)
            {
                currentCharacter = Instantiate(Animal3, currentPosition, Quaternion.identity);

                randomX = Random.Range(0, 10);
                randomY = Random.Range(0, 10);

                currentCharacter.GetComponent<Rigidbody2D>().AddForce(new Vector2(randomX, randomY), ForceMode2D.Impulse);
            }
            else if (randomNumber == 3)
            {
                currentCharacter = Instantiate(Animal5, currentPosition, Quaternion.identity);

                randomX = Random.Range(0, 10);
                randomY = Random.Range(0, 10);

                currentCharacter.GetComponent<Rigidbody2D>().AddForce(new Vector2(randomX, randomY), ForceMode2D.Impulse);
            }
            else if (randomNumber == 4)
            {
                currentCharacter = Instantiate(Animal4, currentPosition, Quaternion.identity);

                randomX = Random.Range(0, 10);
                randomY = Random.Range(0, 10);

                currentCharacter.GetComponent<Rigidbody2D>().AddForce(new Vector2(randomX, randomY), ForceMode2D.Impulse);
            }
            else if (randomNumber == 5)
            {
                currentCharacter = Instantiate(Animal5, currentPosition, Quaternion.identity);

                randomX = Random.Range(0, 10);
                randomY = Random.Range(0, 10);

                currentCharacter.GetComponent<Rigidbody2D>().AddForce(new Vector2(randomX, randomY), ForceMode2D.Impulse);
            }
        }
    }
}
