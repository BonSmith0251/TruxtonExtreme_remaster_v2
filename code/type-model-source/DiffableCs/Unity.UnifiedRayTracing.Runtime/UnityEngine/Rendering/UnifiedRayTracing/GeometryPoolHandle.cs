namespace UnityEngine.Rendering.UnifiedRayTracing;

[Token(Token = "0x200002D")]
internal struct GeometryPoolHandle : IEquatable<GeometryPoolHandle>
{
	[Token(Token = "0x4000110")]
	public static readonly GeometryPoolHandle Invalid; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400010F")]
	public int index; //Field offset: 0x0

	[Token(Token = "0x17000009")]
	public bool valid
	{
		[Address(RVA = "0x2F4F840", Offset = "0x2F4EC40", Length = "0x7")]
		[IsReadOnly]
		[Token(Token = "0x6000089")]
		 get { } //Length: 7
	}

	[Address(RVA = "0x2F571A0", Offset = "0x2F565A0", Length = "0x39")]
	[Token(Token = "0x600008B")]
	private static GeometryPoolHandle() { }

	[Address(RVA = "0x6041D0", Offset = "0x6035D0", Length = "0x6")]
	[Token(Token = "0x600008A")]
	public override bool Equals(GeometryPoolHandle other) { }

	[Address(RVA = "0x2F4F840", Offset = "0x2F4EC40", Length = "0x7")]
	[IsReadOnly]
	[Token(Token = "0x6000089")]
	public bool get_valid() { }

}

