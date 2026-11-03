namespace Unity.Cinemachine;

[Obsolete]
[Token(Token = "0x2000122")]
public class HeadingTracker
{
	[Token(Token = "0x2000123")]
	private struct Item
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004BA")]
		public Vector3 velocity; //Field offset: 0x0
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x40004BB")]
		public float weight; //Field offset: 0xC
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40004BC")]
		public float time; //Field offset: 0x10

	}

	[Token(Token = "0x40004B9")]
	private static float mDecayExponent; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40004B1")]
	private Item[] mHistory; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40004B2")]
	private int mTop; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x40004B3")]
	private int mBottom; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40004B4")]
	private int mCount; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40004B5")]
	private Vector3 mHeadingSum; //Field offset: 0x24
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40004B6")]
	private float mWeightSum; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x40004B7")]
	private float mWeightTime; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40004B8")]
	private Vector3 mLastGoodHeading; //Field offset: 0x38

	[Token(Token = "0x1700011E")]
	public int FilterSize
	{
		[Address(RVA = "0xB0EC60", Offset = "0xB0E060", Length = "0x1A")]
		[Token(Token = "0x6000589")]
		 get { } //Length: 26
	}

	[Address(RVA = "0x287E410", Offset = "0x287D810", Length = "0x120")]
	[Token(Token = "0x6000588")]
	public HeadingTracker(int filterSize) { }

	[Address(RVA = "0x287DB50", Offset = "0x287CF50", Length = "0x39C")]
	[Token(Token = "0x600058C")]
	public void Add(Vector3 velocity) { }

	[Address(RVA = "0x287DEF0", Offset = "0x287D2F0", Length = "0x53")]
	[Token(Token = "0x600058A")]
	private void ClearHistory() { }

	[Address(RVA = "0x287E090", Offset = "0x287D490", Length = "0x4B")]
	[Token(Token = "0x600058B")]
	private static float Decay(float time) { }

	[Address(RVA = "0x287DF50", Offset = "0x287D350", Length = "0x13A")]
	[Token(Token = "0x600058E")]
	public void DecayHistory() { }

	[Address(RVA = "0xB0EC60", Offset = "0xB0E060", Length = "0x1A")]
	[Token(Token = "0x6000589")]
	public int get_FilterSize() { }

	[Address(RVA = "0x287E0E0", Offset = "0x287D4E0", Length = "0x166")]
	[Token(Token = "0x600058F")]
	public Vector3 GetReliableHeading() { }

	[Address(RVA = "0x287E250", Offset = "0x287D650", Length = "0x1BB")]
	[Token(Token = "0x600058D")]
	private void PopBottom() { }

}

