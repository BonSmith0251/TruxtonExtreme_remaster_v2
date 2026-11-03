namespace KANAI.UI;

[CreateAssetMenu(menuName = "KANAI/UI/LocalizeText", fileName = "UILocalizeTexts")]
[Token(Token = "0x2000013")]
public class UICreditsData : ScriptableObject
{
	[Token(Token = "0x2000015")]
	internal enum COUNTRYID : int
	{
		ALL = 0,
		JPONLY = 1,
		NONJP = 2,
	}

	[Token(Token = "0x2000014")]
	internal enum DATAID : int
	{
		MESSAGE = 0,
		POST = 1,
		NAME = 2,
		PICTURE = 3,
	}

	[Token(Token = "0x2000016")]
	internal class Sheet
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000064")]
		public DATAID id; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x4000065")]
		public COUNTRYID cid; //Field offset: 0x14
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000066")]
		public string str; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000067")]
		public string str2; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000068")]
		public string str3; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000069")]
		public float margin; //Field offset: 0x30
		[FieldOffset(Offset = "0x34")]
		[Token(Token = "0x400006A")]
		public Vector2 picSize; //Field offset: 0x34

		[Address(RVA = "0x1E16D20", Offset = "0x1E16120", Length = "0x72")]
		[Token(Token = "0x6000077")]
		public Sheet() { }

		[Address(RVA = "0x1E16B20", Offset = "0x1E15F20", Length = "0x179")]
		[Token(Token = "0x6000076")]
		public Sheet CreateDecodedSheet() { }

	}

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400005A")]
	public List<Sheet> palette; //Field offset: 0x18

	[Address(RVA = "0x1E19A70", Offset = "0x1E18E70", Length = "0x77")]
	[Token(Token = "0x6000075")]
	public UICreditsData() { }

	[Address(RVA = "0x1E197B0", Offset = "0x1E18BB0", Length = "0xA9")]
	[Token(Token = "0x6000072")]
	public void Add(Sheet aSheet) { }

	[Address(RVA = "0x1E19860", Offset = "0x1E18C60", Length = "0x1C3")]
	[Token(Token = "0x6000074")]
	public Sheet GetSheet(int idx) { }

	[Address(RVA = "0x1E19A30", Offset = "0x1E18E30", Length = "0x3C")]
	[Token(Token = "0x6000073")]
	public int SheetNum() { }

}

