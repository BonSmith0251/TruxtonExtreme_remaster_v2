namespace UnityEngine.Rendering;

[Token(Token = "0x200002F")]
internal class ConstantBufferSingleton : ConstantBuffer<CBType>
{
	[Token(Token = "0x40000BC")]
	private static ConstantBufferSingleton<CBType> s_Instance; //Field offset: 0x0

	[Token(Token = "0x1700002E")]
	internal static ConstantBufferSingleton<CBType> instance
	{
		[Address(RVA = "0x17C0450", Offset = "0x17BF850", Length = "0x302")]
		[Token(Token = "0x6000477")]
		internal get { } //Length: 770
		[Address(RVA = "0x17C1BF0", Offset = "0x17C0FF0", Length = "0x95")]
		[Token(Token = "0x6000478")]
		internal set { } //Length: 149
	}

	[Address(RVA = "0x17BFC70", Offset = "0x17BF070", Length = "0x11A")]
	[Token(Token = "0x600047A")]
	public ConstantBufferSingleton`1() { }

	[Address(RVA = "0x17C0450", Offset = "0x17BF850", Length = "0x302")]
	[Token(Token = "0x6000477")]
	internal static ConstantBufferSingleton<CBType> get_instance() { }

	[Address(RVA = "0x17BF7F0", Offset = "0x17BEBF0", Length = "0x88")]
	[Token(Token = "0x6000479")]
	public virtual void Release() { }

	[Address(RVA = "0x17C1BF0", Offset = "0x17C0FF0", Length = "0x95")]
	[Token(Token = "0x6000478")]
	internal static void set_instance(ConstantBufferSingleton<CBType> value) { }

}

