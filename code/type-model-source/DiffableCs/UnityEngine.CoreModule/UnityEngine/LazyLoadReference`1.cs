namespace UnityEngine;

[Token(Token = "0x20001B4")]
public struct LazyLoadReference
{
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x400067F")]
	private int m_InstanceID; //Field offset: 0x0

	[Token(Token = "0x170002EF")]
	public T asset
	{
		[Address(RVA = "0xAFBBB0", Offset = "0xAFAFB0", Length = "0xE7")]
		[Token(Token = "0x60013B1")]
		 get { } //Length: 231
		[Address(RVA = "0xAFBD20", Offset = "0xAFB120", Length = "0xF9")]
		[Token(Token = "0x60013B2")]
		 set { } //Length: 249
	}

	[Token(Token = "0x170002EE")]
	public bool isSet
	{
		[Address(RVA = "0xAFBCA0", Offset = "0xAFB0A0", Length = "0x29")]
		[Token(Token = "0x60013B0")]
		 get { } //Length: 41
	}

	[Address(RVA = "0xAFBBB0", Offset = "0xAFAFB0", Length = "0xE7")]
	[Token(Token = "0x60013B1")]
	public T get_asset() { }

	[Address(RVA = "0xAFBCA0", Offset = "0xAFB0A0", Length = "0x29")]
	[Token(Token = "0x60013B0")]
	public bool get_isSet() { }

	[Address(RVA = "0xAFBCD0", Offset = "0xAFB0D0", Length = "0x48")]
	[Token(Token = "0x60013B3")]
	public static LazyLoadReference<T> op_Implicit(T asset) { }

	[Address(RVA = "0xAFBD20", Offset = "0xAFB120", Length = "0xF9")]
	[Token(Token = "0x60013B2")]
	public void set_asset(T value) { }

}

