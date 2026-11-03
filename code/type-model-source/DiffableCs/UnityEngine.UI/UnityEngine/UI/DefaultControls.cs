namespace UnityEngine.UI;

[Token(Token = "0x2000011")]
public static class DefaultControls
{
	[Token(Token = "0x2000013")]
	private class DefaultRuntimeFactory : IFactoryControls
	{
		[Token(Token = "0x400003B")]
		public static IFactoryControls Default; //Field offset: 0x0

		[Address(RVA = "0x31D9490", Offset = "0x31D8890", Length = "0x67")]
		[Token(Token = "0x6000071")]
		private static DefaultRuntimeFactory() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000070")]
		public DefaultRuntimeFactory() { }

		[Address(RVA = "0x31D9420", Offset = "0x31D8820", Length = "0x64")]
		[Token(Token = "0x600006F")]
		public override GameObject CreateGameObject(string name, Type[] components) { }

	}

	[Token(Token = "0x2000012")]
	internal interface IFactoryControls
	{

		[Token(Token = "0x600006E")]
		public GameObject CreateGameObject(string name, Type[] components) { }

	}

	[Token(Token = "0x2000014")]
	internal struct Resources
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400003C")]
		public Sprite standard; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400003D")]
		public Sprite background; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400003E")]
		public Sprite inputField; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400003F")]
		public Sprite knob; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000040")]
		public Sprite checkmark; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000041")]
		public Sprite dropdown; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000042")]
		public Sprite mask; //Field offset: 0x30

	}

	[Token(Token = "0x4000031")]
	private static IFactoryControls m_CurrentFactory; //Field offset: 0x0
	[Token(Token = "0x4000032")]
	private const float kWidth = 160; //Field offset: 0x0
	[Token(Token = "0x4000033")]
	private const float kThickHeight = 30; //Field offset: 0x0
	[Token(Token = "0x4000034")]
	private const float kThinHeight = 20; //Field offset: 0x0
	[Token(Token = "0x4000035")]
	private static Vector2 s_ThickElementSize; //Field offset: 0x8
	[Token(Token = "0x4000036")]
	private static Vector2 s_ThinElementSize; //Field offset: 0x10
	[Token(Token = "0x4000037")]
	private static Vector2 s_ImageElementSize; //Field offset: 0x18
	[Token(Token = "0x4000038")]
	private static Color s_DefaultSelectableColor; //Field offset: 0x20
	[Token(Token = "0x4000039")]
	private static Color s_PanelColor; //Field offset: 0x30
	[Token(Token = "0x400003A")]
	private static Color s_TextColor; //Field offset: 0x40

	[Token(Token = "0x17000015")]
	public static IFactoryControls factory
	{
		[Address(RVA = "0x31D93D0", Offset = "0x31D87D0", Length = "0x4E")]
		[Token(Token = "0x600005B")]
		 get { } //Length: 78
	}

	[Address(RVA = "0x31D92B0", Offset = "0x31D86B0", Length = "0x120")]
	[Token(Token = "0x600006D")]
	private static DefaultControls() { }

	[Address(RVA = "0x31D3D90", Offset = "0x31D3190", Length = "0x50B")]
	[Token(Token = "0x6000063")]
	public static GameObject CreateButton(Resources resources) { }

	[Address(RVA = "0x31D42A0", Offset = "0x31D36A0", Length = "0x1894")]
	[Token(Token = "0x600006B")]
	public static GameObject CreateDropdown(Resources resources) { }

	[Address(RVA = "0x31D5B40", Offset = "0x31D4F40", Length = "0x13E")]
	[Token(Token = "0x6000065")]
	public static GameObject CreateImage(Resources resources) { }

	[Address(RVA = "0x31D5C80", Offset = "0x31D5080", Length = "0x821")]
	[Token(Token = "0x600006A")]
	public static GameObject CreateInputField(Resources resources) { }

	[Address(RVA = "0x31D64B0", Offset = "0x31D58B0", Length = "0x36D")]
	[Token(Token = "0x6000062")]
	public static GameObject CreatePanel(Resources resources) { }

	[Address(RVA = "0x31D6820", Offset = "0x31D5C20", Length = "0x13E")]
	[Token(Token = "0x6000066")]
	public static GameObject CreateRawImage(Resources resources) { }

	[Address(RVA = "0x31D74F0", Offset = "0x31D68F0", Length = "0x638")]
	[Token(Token = "0x6000068")]
	public static GameObject CreateScrollbar(Resources resources) { }

	[Address(RVA = "0x31D6960", Offset = "0x31D5D60", Length = "0xB8A")]
	[Token(Token = "0x600006C")]
	public static GameObject CreateScrollView(Resources resources) { }

	[Address(RVA = "0x31D7B30", Offset = "0x31D6F30", Length = "0x975")]
	[Token(Token = "0x6000067")]
	public static GameObject CreateSlider(Resources resources) { }

	[Address(RVA = "0x31D84B0", Offset = "0x31D78B0", Length = "0x1AD")]
	[Token(Token = "0x6000064")]
	public static GameObject CreateText(Resources resources) { }

	[Address(RVA = "0x31D8660", Offset = "0x31D7A60", Length = "0x76B")]
	[Token(Token = "0x6000069")]
	public static GameObject CreateToggle(Resources resources) { }

	[Address(RVA = "0x31D8DD0", Offset = "0x31D81D0", Length = "0x104")]
	[Token(Token = "0x600005C")]
	private static GameObject CreateUIElementRoot(string name, Vector2 size, Type[] components) { }

	[Address(RVA = "0x31D8EE0", Offset = "0x31D82E0", Length = "0xDB")]
	[Token(Token = "0x600005D")]
	private static GameObject CreateUIObject(string name, GameObject parent, Type[] components) { }

	[Address(RVA = "0x31D93D0", Offset = "0x31D87D0", Length = "0x4E")]
	[Token(Token = "0x600005B")]
	public static IFactoryControls get_factory() { }

	[Address(RVA = "0x31D8FC0", Offset = "0x31D83C0", Length = "0x4F")]
	[Token(Token = "0x600005F")]
	private static void SetDefaultColorTransitionValues(Selectable slider) { }

	[Address(RVA = "0x31D9010", Offset = "0x31D8410", Length = "0xD7")]
	[Token(Token = "0x600005E")]
	private static void SetDefaultTextValues(Text lbl) { }

	[Address(RVA = "0x31D90F0", Offset = "0x31D84F0", Length = "0xD0")]
	[Token(Token = "0x6000061")]
	private static void SetLayerRecursively(GameObject go, int layer) { }

	[Address(RVA = "0x31D91D0", Offset = "0x31D85D0", Length = "0xDD")]
	[Token(Token = "0x6000060")]
	private static void SetParentAndAlign(GameObject child, GameObject parent) { }

}

