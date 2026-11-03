namespace UnityEngine.Rendering.Universal;

[DefaultMember("Item")]
[Token(Token = "0x20000F3")]
internal struct Fixed2
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400058B")]
	public T item1; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400058C")]
	public T item2; //Field offset: 0x0

	[Token(Token = "0x170001C5")]
	public T Item
	{
		[Address(RVA = "0x9E1650", Offset = "0x9E0A50", Length = "0x9")]
		[Token(Token = "0x6000691")]
		 get { } //Length: 9
		[Address(RVA = "0x9E29E0", Offset = "0x9E1DE0", Length = "0x9")]
		[Token(Token = "0x6000692")]
		 set { } //Length: 9
	}

	[Address(RVA = "0x1BC2F40", Offset = "0x1BC2340", Length = "0x37")]
	[Token(Token = "0x600068F")]
	public Fixed2`1(T item1) { }

	[Address(RVA = "0x12F1450", Offset = "0x12F0850", Length = "0xA")]
	[Token(Token = "0x6000690")]
	public Fixed2`1(T item1, T item2) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Token(Token = "0x6000693")]
	private static void CheckRange(int index) { }

	[Address(RVA = "0x9E1650", Offset = "0x9E0A50", Length = "0x9")]
	[Token(Token = "0x6000691")]
	public T get_Item(int index) { }

	[Address(RVA = "0x9E29E0", Offset = "0x9E1DE0", Length = "0x9")]
	[Token(Token = "0x6000692")]
	public void set_Item(int index, T value) { }

}

