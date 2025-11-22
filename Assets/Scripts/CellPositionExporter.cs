using UnityEngine;

public class CellPositionExporter : MonoBehaviour
{
    // Drag Cell01..Cell52 here in order
    public RectTransform[] cells;

    [ContextMenu("Export Cell Positions")]
    void Export()
    {
        Debug.Log("=== CELL POSITIONS START ===");
        for (int i = 0; i < cells.Length; i++)
        {
            Vector2 p = cells[i].anchoredPosition;
            Debug.Log($"Cell{i + 1}: new Vector2({p.x}f, {p.y}f),");
        }
        Debug.Log("=== CELL POSITIONS END ===");
    }
}
