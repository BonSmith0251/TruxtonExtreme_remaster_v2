namespace UnityEngine;

[Token(Token = "0x20000C4")]
[UsedByNativeCode]
public struct BoundsInt : IEquatable<BoundsInt>, IFormattable
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400023B")]
	private Vector3Int m_Position; //Field offset: 0x0
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x400023C")]
	private Vector3Int m_Size; //Field offset: 0xC

	[Token(Token = "0x170000E9")]
	public Vector3Int position
	{
		[Address(RVA = "0xAEF0B0", Offset = "0xAEE4B0", Length = "0x12")]
		[IsReadOnly]
		[Token(Token = "0x6000574")]
		 get { } //Length: 18
		[Address(RVA = "0x28A7D50", Offset = "0x28A7150", Length = "0xF")]
		[Token(Token = "0x6000575")]
		 set { } //Length: 15
	}

	[Token(Token = "0x170000EA")]
	public Vector3Int size
	{
		[Address(RVA = "0x2C646C0", Offset = "0x2C63AC0", Length = "0x13")]
		[IsReadOnly]
		[Token(Token = "0x6000576")]
		 get { } //Length: 19
		[Address(RVA = "0x2E7FCE0", Offset = "0x2E7F0E0", Length = "0x6A")]
		[Token(Token = "0x6000577")]
		 set { } //Length: 106
	}

	[Address(RVA = "0x665C80", Offset = "0x665080", Length = "0x20")]
	[Token(Token = "0x6000578")]
	public BoundsInt(Vector3Int position, Vector3Int size) { }

	[Address(RVA = "0x2FF1980", Offset = "0x2FF0D80", Length = "0x9B")]
	[IsReadOnly]
	[Token(Token = "0x600057B")]
	public virtual bool Equals(object other) { }

	[Address(RVA = "0x6BDE90", Offset = "0x6BD290", Length = "0x2D5")]
	[IsReadOnly]
	[Token(Token = "0x600057C")]
	public override bool Equals(BoundsInt other) { }

	[Address(RVA = "0x6BDE90", Offset = "0x6BD290", Length = "0x2D5")]
	[IsReadOnly]
	[Token(Token = "0x600057D")]
	public bool Equals(in BoundsInt other) { }

	[Address(RVA = "0xAEF0B0", Offset = "0xAEE4B0", Length = "0x12")]
	[IsReadOnly]
	[Token(Token = "0x6000574")]
	public Vector3Int get_position() { }

	[Address(RVA = "0x2C646C0", Offset = "0x2C63AC0", Length = "0x13")]
	[IsReadOnly]
	[Token(Token = "0x6000576")]
	public Vector3Int get_size() { }

	[Address(RVA = "0x2FF1A20", Offset = "0x2FF0E20", Length = "0xAE")]
	[IsReadOnly]
	[Token(Token = "0x600057E")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x28A7D50", Offset = "0x28A7150", Length = "0xF")]
	[Token(Token = "0x6000575")]
	public void set_position(Vector3Int value) { }

	[Address(RVA = "0x2E7FCE0", Offset = "0x2E7F0E0", Length = "0x6A")]
	[Token(Token = "0x6000577")]
	public void set_size(Vector3Int value) { }

	[Address(RVA = "0x2FF1BB0", Offset = "0x2FF0FB0", Length = "0xD")]
	[IsReadOnly]
	[Token(Token = "0x6000579")]
	public virtual string ToString() { }

	[Address(RVA = "0x2FF1AD0", Offset = "0x2FF0ED0", Length = "0xD8")]
	[IsReadOnly]
	[Token(Token = "0x600057A")]
	public override string ToString(string format, IFormatProvider formatProvider) { }

}

