namespace UnityEngine;

[NativeType("Runtime/Graphics/RefreshRate.h")]
[Token(Token = "0x20000D8")]
public struct RefreshRate : IEquatable<RefreshRate>, IComparable<RefreshRate>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000261")]
	public uint numerator; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000262")]
	public uint denominator; //Field offset: 0x4

	[Token(Token = "0x17000114")]
	public double value
	{
		[Address(RVA = "0x3011930", Offset = "0x3010D30", Length = "0x1A")]
		[Token(Token = "0x600062F")]
		 get { } //Length: 26
	}

	[Address(RVA = "0x30117F0", Offset = "0x3010BF0", Length = "0x5F")]
	[Token(Token = "0x6000631")]
	public override int CompareTo(RefreshRate other) { }

	[Address(RVA = "0x3011850", Offset = "0x3010C50", Length = "0x3B")]
	[Token(Token = "0x6000630")]
	public override bool Equals(RefreshRate other) { }

	[Address(RVA = "0x3011930", Offset = "0x3010D30", Length = "0x1A")]
	[Token(Token = "0x600062F")]
	public double get_value() { }

	[Address(RVA = "0x3011890", Offset = "0x3010C90", Length = "0x97")]
	[Token(Token = "0x6000632")]
	public virtual string ToString() { }

}

