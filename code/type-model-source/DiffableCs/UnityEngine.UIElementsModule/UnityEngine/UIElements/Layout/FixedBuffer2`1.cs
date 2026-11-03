namespace UnityEngine.UIElements.Layout;

[DefaultMember("Item")]
[Token(Token = "0x2000611")]
internal struct FixedBuffer2
{
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x4001634")]
	private T __0; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x4001635")]
	private T __1; //Field offset: 0x0

	[Token(Token = "0x17000AEC")]
	public T Item
	{
		[Address(RVA = "0x1BC5720", Offset = "0x1BC4B20", Length = "0x65")]
		[Token(Token = "0x6002B6C")]
		 get { } //Length: 101
	}

	[Address(RVA = "0x1BC5720", Offset = "0x1BC4B20", Length = "0x65")]
	[Token(Token = "0x6002B6C")]
	public T get_Item(int index) { }

}

