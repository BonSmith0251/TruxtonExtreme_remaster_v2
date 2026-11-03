namespace UnityEngine.Rendering.RenderGraphModule;

[DebuggerDisplay("Buffer ({handle.index})")]
[IsReadOnly]
[MovedFrom(True, "UnityEngine.Experimental.Rendering.RenderGraphModule", "UnityEngine.Rendering.RenderGraphModule", null)]
[Token(Token = "0x2000287")]
public struct BufferHandle
{
	[Token(Token = "0x4000B5A")]
	private static BufferHandle s_NullHandle; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000B5B")]
	internal readonly ResourceHandle handle; //Field offset: 0x0

	[Token(Token = "0x17000254")]
	public static BufferHandle nullHandle
	{
		[Address(RVA = "0x2C8D350", Offset = "0x2C8C750", Length = "0x62")]
		[Token(Token = "0x600121A")]
		 get { } //Length: 98
	}

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600121F")]
	private static BufferHandle() { }

	[Address(RVA = "0x28A7D50", Offset = "0x28A7150", Length = "0xF")]
	[Token(Token = "0x600121B")]
	internal BufferHandle(in ResourceHandle h) { }

	[Address(RVA = "0x2C8D290", Offset = "0x2C8C690", Length = "0xBF")]
	[Token(Token = "0x600121C")]
	internal BufferHandle(int handle, bool shared = false) { }

	[Address(RVA = "0x2C8D350", Offset = "0x2C8C750", Length = "0x62")]
	[Token(Token = "0x600121A")]
	public static BufferHandle get_nullHandle() { }

	[Address(RVA = "0x2C8D240", Offset = "0x2C8C640", Length = "0x49")]
	[Token(Token = "0x600121E")]
	public bool IsValid() { }

	[Address(RVA = "0x2C8D3C0", Offset = "0x2C8C7C0", Length = "0x24C")]
	[Token(Token = "0x600121D")]
	public static GraphicsBuffer op_Implicit(BufferHandle buffer) { }

}

