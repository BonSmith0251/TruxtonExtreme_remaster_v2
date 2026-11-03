namespace TMPro;

[Token(Token = "0x200003D")]
public static class TMP_DefaultControls
{
	[Token(Token = "0x200003E")]
	internal struct Resources
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001A0")]
		public Sprite standard; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40001A1")]
		public Sprite background; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40001A2")]
		public Sprite inputField; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40001A3")]
		public Sprite knob; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40001A4")]
		public Sprite checkmark; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40001A5")]
		public Sprite dropdown; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40001A6")]
		public Sprite mask; //Field offset: 0x30

	}

	[Token(Token = "0x4000198")]
	private const float kWidth = 160; //Field offset: 0x0
	[Token(Token = "0x4000199")]
	private const float kThickHeight = 30; //Field offset: 0x0
	[Token(Token = "0x400019A")]
	private const float kThinHeight = 20; //Field offset: 0x0
	[Token(Token = "0x400019B")]
	private static Vector2 s_TextElementSize; //Field offset: 0x0
	[Token(Token = "0x400019C")]
	private static Vector2 s_ThickElementSize; //Field offset: 0x8
	[Token(Token = "0x400019D")]
	private static Vector2 s_ThinElementSize; //Field offset: 0x10
	[Token(Token = "0x400019E")]
	private static Color s_DefaultSelectableColor; //Field offset: 0x18
	[Token(Token = "0x400019F")]
	private static Color s_TextColor; //Field offset: 0x28

	[Address(RVA = "0x2EB22A0", Offset = "0x2EB16A0", Length = "0xAC")]
	[Token(Token = "0x60001B4")]
	private static TMP_DefaultControls() { }

	[Address(RVA = "0x93F680", Offset = "0x93EA80", Length = "0x42")]
	[Token(Token = "0x60001B3")]
	private static T AddComponent(GameObject go) { }

	[Address(RVA = "0x2EAFBA0", Offset = "0x2EAEFA0", Length = "0x3B5")]
	[Token(Token = "0x60001AF")]
	public static GameObject CreateButton(Resources resources) { }

	[Address(RVA = "0x2EAFF60", Offset = "0x2EAF360", Length = "0x12A1")]
	[Token(Token = "0x60001B2")]
	public static GameObject CreateDropdown(Resources resources) { }

	[Address(RVA = "0x2EB1210", Offset = "0x2EB0610", Length = "0x84E")]
	[Token(Token = "0x60001B1")]
	public static GameObject CreateInputField(Resources resources) { }

	[Address(RVA = "0x2EB1A60", Offset = "0x2EB0E60", Length = "0x372")]
	[Token(Token = "0x60001AE")]
	public static GameObject CreateScrollbar(Resources resources) { }

	[Address(RVA = "0x2EB1DE0", Offset = "0x2EB11E0", Length = "0xA5")]
	[Token(Token = "0x60001B0")]
	public static GameObject CreateText(Resources resources) { }

	[Address(RVA = "0x2EB1E90", Offset = "0x2EB1290", Length = "0x9D")]
	[Token(Token = "0x60001A8")]
	private static GameObject CreateUIElementRoot(string name, Vector2 size) { }

	[Address(RVA = "0x2EB1F30", Offset = "0x2EB1330", Length = "0xB5")]
	[Token(Token = "0x60001A9")]
	private static GameObject CreateUIObject(string name, GameObject parent) { }

	[Address(RVA = "0x2EB1FF0", Offset = "0x2EB13F0", Length = "0x4F")]
	[Token(Token = "0x60001AB")]
	private static void SetDefaultColorTransitionValues(Selectable slider) { }

	[Address(RVA = "0x2EB2040", Offset = "0x2EB1440", Length = "0x91")]
	[Token(Token = "0x60001AA")]
	private static void SetDefaultTextValues(TMP_Text lbl) { }

	[Address(RVA = "0x2EB20E0", Offset = "0x2EB14E0", Length = "0xD0")]
	[Token(Token = "0x60001AD")]
	private static void SetLayerRecursively(GameObject go, int layer) { }

	[Address(RVA = "0x2EB21C0", Offset = "0x2EB15C0", Length = "0xDD")]
	[Token(Token = "0x60001AC")]
	private static void SetParentAndAlign(GameObject child, GameObject parent) { }

}

