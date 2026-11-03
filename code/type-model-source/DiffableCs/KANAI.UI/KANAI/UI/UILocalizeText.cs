namespace KANAI.UI;

[CreateAssetMenu(menuName = "KANAI/UI/LocalizeText", fileName = "UILocalizeTexts")]
[Token(Token = "0x200002F")]
public class UILocalizeText : ScriptableObject
{
	[CompilerGenerated]
	[Token(Token = "0x2000031")]
	private sealed class <>c__DisplayClass4_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400015C")]
		public string vkey; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000144")]
		public <>c__DisplayClass4_0() { }

		[Address(RVA = "0x1D73DE0", Offset = "0x1D731E0", Length = "0x25")]
		[Token(Token = "0x6000145")]
		internal bool <ContainsKey>b__0(Sheet p) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000032")]
	private sealed class <>c__DisplayClass5_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400015D")]
		public string vkey; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000146")]
		public <>c__DisplayClass5_0() { }

		[Address(RVA = "0x1D73DE0", Offset = "0x1D731E0", Length = "0x25")]
		[Token(Token = "0x6000147")]
		internal bool <GetSheet>b__0(Sheet p) { }

	}

	[Token(Token = "0x2000030")]
	internal class Sheet
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000151")]
		public string targetKey; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000152")]
		public string Jp; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000153")]
		public string En; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000154")]
		public string Zhcn; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000155")]
		public string Zhtw; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000156")]
		public string Es; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000157")]
		public string Kr; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000158")]
		public string De; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4000159")]
		public string Fr; //Field offset: 0x50
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x400015A")]
		public string Pt; //Field offset: 0x58
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x400015B")]
		public string Eses; //Field offset: 0x60

		[Address(RVA = "0x1D39B10", Offset = "0x1D38F10", Length = "0x36")]
		[Token(Token = "0x6000143")]
		public Sheet() { }

		[Address(RVA = "0x1E16990", Offset = "0x1E15D90", Length = "0x18D")]
		[Token(Token = "0x6000142")]
		public Sheet CreateDecodedSheet() { }

		[Address(RVA = "0x1E16CA0", Offset = "0x1E160A0", Length = "0x54")]
		[Token(Token = "0x6000141")]
		public string GetString(Area area) { }

	}

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000150")]
	public List<Sheet> palette; //Field offset: 0x18

	[Address(RVA = "0x1E22B30", Offset = "0x1E21F30", Length = "0x77")]
	[Token(Token = "0x6000140")]
	public UILocalizeText() { }

	[Address(RVA = "0x1E22670", Offset = "0x1E21A70", Length = "0xA9")]
	[Token(Token = "0x600013B")]
	public void Add(Sheet aSheet) { }

	[Address(RVA = "0x1E22720", Offset = "0x1E21B20", Length = "0xD1")]
	[Token(Token = "0x600013D")]
	public bool ContainsKey(string vkey) { }

	[Address(RVA = "0x1E22800", Offset = "0x1E21C00", Length = "0xA9")]
	[Token(Token = "0x600013C")]
	public void EncodeAdd(Sheet aSheet) { }

	[Address(RVA = "0x1E228B0", Offset = "0x1E21CB0", Length = "0xF2")]
	[Token(Token = "0x600013E")]
	public Sheet GetSheet(string vkey) { }

	[Address(RVA = "0x1E229B0", Offset = "0x1E21DB0", Length = "0x15C")]
	[Token(Token = "0x600013F")]
	public string GetString(string vkey, Area area) { }

}

