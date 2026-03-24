using UnityEngine;
using UnityEngine.UI;

// Ryan Smith Management Script

public class Management : MonoBehaviour
{
    [Header("3D Models")]
    [SerializeField] GameObject[] levelPrefabs; // Must Be Arranged In Same Order As Previous Scene
    [SerializeField] GameObject[] characterPrefabs; 

    [Header("Chosen Level & Character")]
    [SerializeField] int requiredLevel;  // Index Number For Previously Choosen Level
    [SerializeField] int requiredCharacter;

    [Header("Positions")]
    [SerializeField] GameObject levelPosition; // For Correct Transform 
    [SerializeField] GameObject characterPosition;  

    [Header("Required Character Icon")]
    [SerializeField] RawImage[] characterIcons; // Must Correspond With Character Type Index
    [SerializeField] RawImage requiredCharacterIcon; // Image To Swap With Icon


    //-----------------------------------Start is called once upon creation-------------------------
    private void Awake()
    {
        requiredLevel = Level.selectedLevel; 
        requiredCharacter = Character.selectedCharacter; // Gathers Selected Characters's Index Number

        Instantiate(levelPrefabs[requiredLevel], levelPosition.transform); // Places Correct Level Model With Correct Position, Size & Rotation
        Instantiate(characterPrefabs[requiredCharacter], characterPosition.transform); 

        requiredCharacterIcon = characterIcons[requiredCharacter]; // Shows The Corresponding Character Icon On HUD
    }
}