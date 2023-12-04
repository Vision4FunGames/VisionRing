using UnityEngine;

public class PillarPuzzleController : MonoBehaviour
{
    public GameObject[] pillars;
    public AudioClip grindSound;  // Assign the grind sound in the Inspector
    private int[] correctRotations = { 180, 0, 180 };
    private int[] currentRotations;
    private bool isRotating = false;
    public GameObject forcefield;
    private bool solved = false;

    void Start()
    {
        currentRotations = new int[pillars.Length];

        for (int i = 0; i < pillars.Length; i++)
        {
            int index = i;
            pillars[i].AddComponent<BoxCollider>(); // Add a BoxCollider for raycasting
            AudioSource audioSource = pillars[i].AddComponent<AudioSource>(); // Add AudioSource
            audioSource.playOnAwake = false; // Disable play on awake

            // Subscribe to the OnMouseDown event
            pillars[i].GetComponent<BoxCollider>().enabled = true;
            pillars[i].GetComponent<BoxCollider>().isTrigger = true;
            pillars[i].GetComponent<BoxCollider>().size = new Vector3(1, 1, 1);
            pillars[i].AddComponent<PillarClickHandler>().Init(this, index, audioSource);
            currentRotations[i] = (int)pillars[index].transform.rotation.eulerAngles.y;
        }
    }

    public void OnPillarClicked(int index)
    {
        if (!isRotating && !solved)
        {
            StartCoroutine(RotatePillarSmoothly(index, 1f));
        }
    }

    System.Collections.IEnumerator RotatePillarSmoothly(int index, float duration)
    {
        isRotating = true;

        float elapsed = 0f;
        float startRotation = pillars[index].transform.rotation.eulerAngles.y;
        float targetRotation = (startRotation + 120) % 360;

        // Play the grind sound
        pillars[index].GetComponent<AudioSource>().PlayOneShot(grindSound);

        while (elapsed < duration)
        {
            float newRotation = Mathf.LerpAngle(startRotation, targetRotation, elapsed / duration);
            pillars[index].transform.rotation = Quaternion.Euler(0, newRotation, 0);
            elapsed += Time.deltaTime;
            yield return null;
        }

        // Ensure the final rotation is exact
        pillars[index].transform.rotation = Quaternion.Euler(0, targetRotation, 0);
        currentRotations[index] = (int)targetRotation;

        // Stop playing the grind sound
        pillars[index].GetComponent<AudioSource>().Stop();

        isRotating = false;

        if (CheckCorrectRotations())
        {
            solved = true;
            forcefield.SetActive(false);

        }
    }

    bool CheckCorrectRotations()
    {
        for (int i = 0; i < pillars.Length; i++)
        {
            if (currentRotations[i] != correctRotations[i])
            {
                return false;
            }
        }
        return true;
    }
}

public class PillarClickHandler : MonoBehaviour
{
    private PillarPuzzleController puzzleController;
    private int pillarIndex;
    private AudioSource audioSource;

    public void Init(PillarPuzzleController controller, int index, AudioSource source)
    {
        puzzleController = controller;
        pillarIndex = index;
        audioSource = source;
    }

    void OnMouseDown()
    {
        puzzleController.OnPillarClicked(pillarIndex);
    }
}
