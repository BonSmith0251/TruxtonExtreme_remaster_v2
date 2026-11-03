namespace UnityEngine.Experimental.Rendering;

[Token(Token = "0x200000E")]
internal class XRLayoutStack : IDisposable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000036")]
	private readonly Stack<XRLayout> m_Stack; //Field offset: 0x10

	[Token(Token = "0x17000009")]
	public XRLayout top
	{
		[Address(RVA = "0x2BC8F20", Offset = "0x2BC8320", Length = "0x44")]
		[Token(Token = "0x6000034")]
		 get { } //Length: 68
	}

	[Address(RVA = "0x2BC8EA0", Offset = "0x2BC82A0", Length = "0x77")]
	[Token(Token = "0x6000037")]
	public XRLayoutStack() { }

	[Address(RVA = "0x2BC8B50", Offset = "0x2BC7F50", Length = "0x88")]
	[Token(Token = "0x6000036")]
	public override void Dispose() { }

	[Address(RVA = "0x2BC8F20", Offset = "0x2BC8320", Length = "0x44")]
	[Token(Token = "0x6000034")]
	public XRLayout get_top() { }

	[Address(RVA = "0x2BC8BE0", Offset = "0x2BC7FE0", Length = "0x9B")]
	[Token(Token = "0x6000033")]
	public XRLayout New() { }

	[Address(RVA = "0x2BC8C80", Offset = "0x2BC8080", Length = "0x213")]
	[Token(Token = "0x6000035")]
	public void Release() { }

}

