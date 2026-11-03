namespace Cysharp.Threading.Tasks;

[IsReadOnly]
[Token(Token = "0x2000015")]
public struct AsyncUnit : IEquatable<AsyncUnit>
{
	[Token(Token = "0x400004B")]
	public static readonly AsyncUnit Default; //Field offset: 0x0

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000084")]
	private static AsyncUnit() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6000082")]
	public override bool Equals(AsyncUnit other) { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6000081")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x272E510", Offset = "0x272D910", Length = "0x2C")]
	[Token(Token = "0x6000083")]
	public virtual string ToString() { }

}

