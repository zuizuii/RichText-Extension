using UnityEngine;

namespace Zuizui.Extensions.Richtext
{
	public static class RichTextExtension
	{
		//TODO: const string MATERIAL = "<material={0}>{1}</material>";
		//TODO: const string QUAD = "<quad ={0}>{1}</color>";

		/// <summary>
		/// Renders the text in boldface.	
		/// </summary>
		/// <param name="obj">Original object</param>
		public static string Bold(this object obj) => $"<b>{obj}</b>";

		/// <summary>
		/// Renders the text in italics.	
		/// </summary>
		/// <param name="obj">Original object</param>
		public static string Italic(this object obj) => $"<i>{obj}</i>";

		/// <summary>
		/// Sets the size of the text according to the parameter value, given in pixels.	
		/// </summary>
		/// <param name="obj">Original object</param>
		/// <param name="size">Desired text size in pixels</param>
		public static string Size(this object obj, float size) => $"<size={size}>{obj}</size>";

		#region Colors

		public static string Color(this object obj, string hexColor) => $"<color={hexColor}>{obj}</color>";
		public static string Color(this object obj, Color color) => $"<color={ColorToHex(color)}>{obj}</color>";
		public static string Color(this object obj, Color32 color32) => $"<color={ColorToHex(color32)}>{obj}</color>";

		/// <summary> Paint it Aqua!</summary>
		/// <summary> #00ffffff (same as cyan)</summary>
		public static string Aqua(this object obj) => ColorProcessor(obj, "aqua");

		/// <summary> Paint it Black!</summary>
		/// <summary> #000000ff</summary>
		public static string Black(this object obj) => ColorProcessor(obj, "black");

		/// <summary> Paint it Blue!</summary>
		/// <summary> #0000ffff</summary>
		public static string Blue(this object obj) => ColorProcessor(obj, "blue");

		/// <summary> Paint it Brown!</summary>
		/// <summary> #a52a2aff</summary>
		public static string Brown(this object obj) => ColorProcessor(obj, "brown");

		/// <summary> Paint it Cyan!</summary>
		/// <summary> #00ffffff (same as aqua)</summary>
		public static string Cyan(this object obj) => ColorProcessor(obj, "cyan");

		/// <summary> Paint it Dark Blue!</summary>
		/// <summary> #0000a0ff</summary>
		public static string DarkBlue(this object obj) => ColorProcessor(obj, "darkblue");

		/// <summary> Paint it Fuchsia!</summary>
		/// <summary> #ff00ffff</summary>
		public static string Fuchsia(this object obj) => ColorProcessor(obj, "fuchsia");

		/// <summary> Paint it Green!</summary>
		/// <summary> #008000ff</summary>
		public static string Green(this object obj) => ColorProcessor(obj, "green");

		/// <summary> Paint it Grey!</summary>
		/// <summary> #808080ff</summary>
		public static string Grey(this object obj) => ColorProcessor(obj, "grey");

		/// <summary> Paint it Light Blue!</summary>
		/// <summary> #add8e6ff</summary>
		public static string LightBlue(this object obj) => ColorProcessor(obj, "lightblue");

		/// <summary> Paint it Lime!</summary>
		/// <summary> #00ff00ff</summary>
		public static string Lime(this object obj) => ColorProcessor(obj, "lime");

		/// <summary> Paint it Magenta!</summary>
		/// <summary> #ff00ffff</summary>
		public static string Magenta(this object obj) => ColorProcessor(obj, "magenta");

		/// <summary> Paint it Maroon!</summary>
		/// <summary> #800000ff</summary>
		public static string Maroon(this object obj) => ColorProcessor(obj, "maroon");

		/// <summary> Paint it Navy!</summary>
		/// <summary> #000080ff</summary>
		public static string Navy(this object obj) => ColorProcessor(obj, "navy");

		/// <summary> Paint it Olive!</summary>
		/// <summary> #808000ff</summary>
		public static string Olive(this object obj) => ColorProcessor(obj, "olive");

		/// <summary> Paint it Orange!</summary>
		/// <summary> #ffa500ff</summary>
		public static string Orange(this object obj) => ColorProcessor(obj, "orange");

		/// <summary> Paint it Purple!</summary>
		/// <summary> #800080ff</summary>
		public static string Purple(this object obj) => ColorProcessor(obj, "purple");

		/// <summary> Paint it Red!</summary>
		/// <summary> #ff0000ff</summary>
		public static string Red(this object obj) => ColorProcessor(obj, "red");

		/// <summary> Paint it Silver!</summary>
		/// <summary> #c0c0c0ff</summary>
		public static string Silver(this object obj) => ColorProcessor(obj, "silver");

		/// <summary> Paint it Teal!</summary>
		/// <summary> #008080ff</summary>
		public static string Teal(this object obj) => ColorProcessor(obj, "teal");

		/// <summary> Paint it White!</summary>
		/// <summary> #ffffffff</summary>
		public static string White(this object obj) => ColorProcessor(obj, "white");

		/// <summary> Paint it Yellow!</summary>
		/// <summary> #ffff00ff</summary>
		public static string Yellow(this object obj) => ColorProcessor(obj, "yellow");

		static string ColorProcessor(object obj, string color) => $"<color={color}>{obj}</color>";

		static string ColorToHex(Color color)
		{
			Color32 color32 = color;
			return ColorToHex(color32);
		}

		static string ColorToHex(Color32 color32)
		{
			return "#" + color32.r.ToString("X2") + color32.g.ToString("X2") + color32.b.ToString("X2") + color32.a.ToString("X2");
		}

		static Color HexToColor(string hexVal)
		{
			Color newCol = UnityEngine.Color.black;
			ColorUtility.TryParseHtmlString(hexVal, out newCol);
			return newCol;
		}

		#endregion
	}
}