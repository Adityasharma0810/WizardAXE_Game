using UnityEngine;


public class EnemyController : MonoBehaviour
{
    [SerializeField]
    private GameObject _enemyPrefab;
    [SerializeField]
    private int _enemyCount = 6;
    [SerializeField]
    private Transform _spawnTopLeft, _spawnTopRight, _spawnBottomLeft, _spawnBottomRight;
    // Start is called once before the first execution of Update after the MonoBehaviour is created



    void Start()
    {
        for (int i = 0; i < _enemyCount; i++)
        {
            SpawnEnemy();
        }


    }




    private void SpawnEnemy()
    {
        Vector3 spawnPosition = SelectRandomPosition();
        GameObject enemyObject = Instantiate(_enemyPrefab, spawnPosition, Quaternion.identity);
        Enemy enemy = enemyObject.GetComponent<Enemy>();
        if(enemy != null)
        {
            enemy.OnDie += SpawnEnemy;
        }
    
    }





    private Vector3 SelectRandomPosition()
    {
        Transform selectedTransform = null;
        int randomValue = Random.Range(0, 4); //0,1,2,3 these are the expected valuse , we are using random lib from unity package
        SpawnPointType spawnType = (SpawnPointType)randomValue;
        switch (spawnType)
        {
            case SpawnPointType.TopLeft:
                selectedTransform = _spawnTopLeft;
                break;
            case SpawnPointType.TopRight:
                selectedTransform = _spawnTopRight;
                break;
            case SpawnPointType.BottomLeft:
                selectedTransform = _spawnBottomLeft;
                break;
            case SpawnPointType.BottomRight:
                selectedTransform = _spawnBottomRight;
                break;

        }



        return selectedTransform.position + (Vector3)Random.insideUnitCircle;
    }







    // Update is called once per frame




    void Update()
    {

    }
}
public enum SpawnPointType
{
    TopLeft=0,
    TopRight=1,
    BottomLeft=2,
    BottomRight = 3



}



