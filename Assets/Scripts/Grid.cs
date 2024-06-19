using UnityEngine;
using UnityEngine.UI;

public class Grid : MonoBehaviour
{
    [SerializeField] private float _cellSize;
    [SerializeField] private int _sizeX, _sizeY;
    [SerializeField] private Cell _cellPrefab;
    private void Start()
    {
        float startX = -(_sizeX - 1) * _cellSize / 2;
        float startY = -(_sizeY - 1) * _cellSize / 2;
        for (int x = 0; x < _sizeX; x++)
        {
            for (int y = 0; y < _sizeY; y++)
            {
                Cell cell = Instantiate(_cellPrefab, transform);
                cell.transform.localPosition = new Vector2(startX + x * _cellSize, startY + y * _cellSize);
                RectTransform rect = cell.GetComponent<RectTransform>();
                rect.sizeDelta = new Vector2(_cellSize, _cellSize);
            }
        }
        RectTransform rectTransform = GetComponent<RectTransform>();
        rectTransform.sizeDelta = new Vector2(_sizeX * _cellSize, _sizeY * _cellSize);
    }
}