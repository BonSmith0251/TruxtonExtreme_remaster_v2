namespace UnityEngine.UIElements.Layout;

[DefaultMember("Item")]
[Token(Token = "0x2000612")]
internal struct FixedBuffer4
{
	[Token(Token = "0x400163A")]
	public const int Length = 4; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x4001636")]
	private T __0; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x4001637")]
	private T __1; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x4001638")]
	private T __2; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x4001639")]
	private T __3; //Field offset: 0x0

	[Token(Token = "0x17000AED")]
	public T Item
	{
		[Address(RVA = "0x1BC58D0", Offset = "0x1BC4CD0", Length = "0x69")]
		[Token(Token = "0x6002B6D")]
		 get { } //Length: 105
	}

	[Address(RVA = "0x1BC58D0", Offset = "0x1BC4CD0", Length = "0x69")]
	[Token(Token = "0x6002B6D")]
	public T get_Item(int index) { }

}

