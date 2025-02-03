using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HexGrid : MonoBehaviour
{

    [SerializeField] public int width = 6;
	[SerializeField] public int height = 6;

	[SerializeField] public HexCell cellPrefab;

    HexCell[] cells;

	void Awake () 
    {
		cells = new HexCell[height * width];

		for (int y = 0, i = 0; y < height; y++) {
			for (int x = 0; x < width; x++) {
				CreateCell(x, y, i++);
			}
		}
	}
	
	void CreateCell (int x, int y, int i) 
    {
		Vector3 position;
		position.x = x * HexMetrics.outerRadius;
		position.y = y * HexMetrics.outerRadius;
		position.z = 0f;

		HexCell cell = cells[i] = Instantiate<HexCell>(cellPrefab);
		//cell.transform.SetParent(transform, false);
		cell.transform.position = position;
	}
}

public static class HexMetrics
{
    public const float outerRadius = 1f;

	public const float innerRadius = outerRadius * 0.886f;

    public static Vector3[] corners = 
    {
		new Vector3(0f, 0f, outerRadius),
		new Vector3(innerRadius, 0f, 0.5f * outerRadius),
		new Vector3(innerRadius, 0f, -0.5f * outerRadius),
		new Vector3(0f, 0f, -outerRadius),
		new Vector3(-innerRadius, 0f, -0.5f * outerRadius),
		new Vector3(-innerRadius, 0f, 0.5f * outerRadius)
	};
}
