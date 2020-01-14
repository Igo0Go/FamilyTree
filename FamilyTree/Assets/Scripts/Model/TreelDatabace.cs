using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class TreelDatabace
{
    public static Dictionary<int, PersonData> PersonDataSet { get; set; }
    public static Dictionary<int, PersonItem> PersonItemSet { get; set; }
    public static Dictionary<int, RelationNodeParentToForward> ChildrenNodeSet { get; set; }
    public static Dictionary<int, RelationNodeForwardToChildren> ParentNodeSet { get; set; }

    /// <summary>
    /// 0 - Id для PersonData
    /// 1 - Id для Элементов отрисовки
    /// </summary>
    public static List<int> Counters { get; set; } = new List<int>();
}
