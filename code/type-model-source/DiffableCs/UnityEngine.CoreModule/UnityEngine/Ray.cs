namespace UnityEngine;

[Token(Token = "0x20000C7")]
public struct Ray : IFormattable
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000240")]
	private Vector3 m_Origin; //Field offset: 0x0
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000241")]
	private Vector3 m_Direction; //Field offset: 0xC

	[Token(Token = "0x170000EE")]
	public Vector3 direction
	{
		[Address(RVA = "0x2C646C0", Offset = "0x2C63AC0", Length = "0x13")]
		[IsReadOnly]
		[Token(Token = "0x6000598")]
		 get { } //Length: 19
	}

	[Token(Token = "0x170000ED")]
	public Vector3 origin
	{
		[Address(RVA = "0xAEF0B0", Offset = "0xAEE4B0", Length = "0x12")]
		[IsReadOnly]
		[Token(Token = "0x6000596")]
		 get { } //Length: 18
		[Address(RVA = "0x28A7D50", Offset = "0x28A7150", Length = "0xF")]
		[Token(Token = "0x6000597")]
		 set { } //Length: 15
	}

	[Address(RVA = "0x300F4F0", Offset = "0x300E8F0", Length = "0x2A")]
	[Token(Token = "0x6000595")]
	public Ray(Vector3 origin, Vector3 direction) { }

	[Address(RVA = "0x2C646C0", Offset = "0x2C63AC0", Length = "0x13")]
	[IsReadOnly]
	[Token(Token = "0x6000598")]
	public Vector3 get_direction() { }

	[Address(RVA = "0xAEF0B0", Offset = "0xAEE4B0", Length = "0x12")]
	[IsReadOnly]
	[Token(Token = "0x6000596")]
	public Vector3 get_origin() { }

	[Address(RVA = "0x300F3A0", Offset = "0x300E7A0", Length = "0x35")]
	[IsReadOnly]
	[Token(Token = "0x6000599")]
	public Vector3 GetPoint(float distance) { }

	[Address(RVA = "0x28A7D50", Offset = "0x28A7150", Length = "0xF")]
	[Token(Token = "0x6000597")]
	public void set_origin(Vector3 value) { }

	[Address(RVA = "0x300F3E0", Offset = "0x300E7E0", Length = "0xD")]
	[IsReadOnly]
	[Token(Token = "0x600059A")]
	public virtual string ToString() { }

	[Address(RVA = "0x300F3F0", Offset = "0x300E7F0", Length = "0xF8")]
	[IsReadOnly]
	[Token(Token = "0x600059B")]
	public override string ToString(string format, IFormatProvider formatProvider) { }

}

