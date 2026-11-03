namespace UnityEngine.Rendering;

[Token(Token = "0x200005D")]
public struct Observable
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400014A")]
	private Action<T> onValueChanged; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400014B")]
	private T m_Value; //Field offset: 0x0

	[Token(Token = "0x14000002")]
	public event Action<T> onValueChanged
	{
		[Address(RVA = "0xE10000", Offset = "0xE0F400", Length = "0x134")]
		[CompilerGenerated]
		[Token(Token = "0x6000543")]
		 add { } //Length: 308
		[Address(RVA = "0xE10220", Offset = "0xE0F620", Length = "0x134")]
		[CompilerGenerated]
		[Token(Token = "0x6000544")]
		 remove { } //Length: 308
	}

	[Token(Token = "0x17000043")]
	public T value
	{
		[Address(RVA = "0xE10140", Offset = "0xE0F540", Length = "0xD1")]
		[Token(Token = "0x6000545")]
		 get { } //Length: 209
		[Address(RVA = "0xE10360", Offset = "0xE0F760", Length = "0x375")]
		[Token(Token = "0x6000546")]
		 set { } //Length: 885
	}

	[Address(RVA = "0xE0FEB0", Offset = "0xE0F2B0", Length = "0x14A")]
	[Token(Token = "0x6000547")]
	public Observable`1(T newValue) { }

	[Address(RVA = "0xE10000", Offset = "0xE0F400", Length = "0x134")]
	[CompilerGenerated]
	[Token(Token = "0x6000543")]
	public void add_onValueChanged(Action<T> value) { }

	[Address(RVA = "0xE10140", Offset = "0xE0F540", Length = "0xD1")]
	[Token(Token = "0x6000545")]
	public T get_value() { }

	[Address(RVA = "0xE10220", Offset = "0xE0F620", Length = "0x134")]
	[CompilerGenerated]
	[Token(Token = "0x6000544")]
	public void remove_onValueChanged(Action<T> value) { }

	[Address(RVA = "0xE10360", Offset = "0xE0F760", Length = "0x375")]
	[Token(Token = "0x6000546")]
	public void set_value(T value) { }

}

