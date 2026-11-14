
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Inputs.Haptics;

public class CubeSpawner : MonoBehaviour
{
    public GameObject targetCubePrefab;

    public float bpm = 100f;
    public float levelDuration = 90f;

    public bool enableHaptics = true;
    public bool enableHitSound = true;

    public AudioSource musicSource;
    public ScoreManager scoreManager;

    public HapticImpulsePlayer rightHaptics;
    public HapticImpulsePlayer leftHaptics;

    private float nextSpawnTime = 0f;

    void Start()
    {
        // Spawn every two beats
        float secondsPerBeat = 60f / bpm;
        nextSpawnTime = secondsPerBeat * 2f;
    }

    void Update()
    {
        if (musicSource == null || !musicSource.isPlaying)
            return;

        float musicTime = musicSource.time;
        float secondsPerBeat = 60f / bpm;
        float spawnInterval = secondsPerBeat * 2f;

        // Stop spawning after 90 seconds
        if (musicTime >= levelDuration)
            return;

        // Spawn cubes at regular beat intervals
        if (musicTime >= nextSpawnTime)
        {
            SpawnCube();
            nextSpawnTime += spawnInterval;
        }
    }

    void SpawnCube()
    {
        int randomLane = Random.Range(0, 3);

        float xPosition = (randomLane - 1) * 0.6f;

        Vector3 spawnPosition = new Vector3(
            xPosition, 1.3f, 8f
        );

        GameObject newCube = Instantiate(
            targetCubePrefab,
            spawnPosition,
            Quaternion.identity
        );

        TargetHit targetHit = newCube.GetComponent<TargetHit>();

        targetHit.scoreManager = scoreManager;
        targetHit.rightHaptics = rightHaptics;
        targetHit.leftHaptics = leftHaptics;
        targetHit.enableHaptics = enableHaptics;
        targetHit.enableHitSound = enableHitSound;
    }
}
