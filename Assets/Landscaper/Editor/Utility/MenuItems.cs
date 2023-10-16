using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEditor;
using UnityEngine;

namespace Landscaper.Editor.Utility
{
	public static class MenuItems
	{
		[MenuItem("GameObject/Landscaper/Foliage Area", false, 1)]
		public static void AddFoliageArea()
		{
			GameObject obj = new GameObject("Foliage Area");
			FoliageArea area = obj.AddComponent<FoliageArea>();
			area.FitToGeometry();

			Selection.activeGameObject = obj;
			Undo.RegisterCreatedObjectUndo(obj, "Create Foliage Area");
		}
	}
}
