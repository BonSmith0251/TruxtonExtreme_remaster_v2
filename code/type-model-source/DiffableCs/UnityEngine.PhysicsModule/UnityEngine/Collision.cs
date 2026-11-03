namespace UnityEngine;

[Token(Token = "0x2000003")]
public class Collision
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000007")]
	private ContactPairHeader m_Header; //Field offset: 0x10
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000008")]
	private ContactPair m_Pair; //Field offset: 0x38
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000009")]
	private bool m_Flipped; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400000A")]
	private ContactPoint[] m_LegacyContacts; //Field offset: 0x68

	[Token(Token = "0x17000004")]
	public Component body
	{
		[Address(RVA = "0x3135A50", Offset = "0x3134E50", Length = "0x73")]
		[Token(Token = "0x6000004")]
		 get { } //Length: 115
	}

	[Token(Token = "0x17000005")]
	public Collider collider
	{
		[Address(RVA = "0x3135AD0", Offset = "0x3134ED0", Length = "0x26")]
		[Token(Token = "0x6000005")]
		 get { } //Length: 38
	}

	[Token(Token = "0x17000008")]
	public ContactPoint[] contacts
	{
		[Address(RVA = "0x3135B00", Offset = "0x3134F00", Length = "0x6A")]
		[Token(Token = "0x6000008")]
		 get { } //Length: 106
	}

	[Token(Token = "0x17000007")]
	internal bool Flipped
	{
		[Address(RVA = "0x28A42A0", Offset = "0x28A36A0", Length = "0x4")]
		[Token(Token = "0x6000007")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x17000006")]
	public GameObject gameObject
	{
		[Address(RVA = "0x3135B70", Offset = "0x3134F70", Length = "0x9D")]
		[Token(Token = "0x6000006")]
		 get { } //Length: 157
	}

	[Token(Token = "0x17000003")]
	public Vector3 relativeVelocity
	{
		[Address(RVA = "0x3135C10", Offset = "0x3135010", Length = "0x55")]
		[Token(Token = "0x6000003")]
		 get { } //Length: 85
	}

	[Address(RVA = "0x31359F0", Offset = "0x3134DF0", Length = "0x5A")]
	[Token(Token = "0x6000009")]
	public Collision() { }

	[Address(RVA = "0x3135780", Offset = "0x3134B80", Length = "0x260")]
	[Token(Token = "0x600000A")]
	internal Collision(in ContactPairHeader header, in ContactPair pair, bool flipped) { }

	[Address(RVA = "0x3135A50", Offset = "0x3134E50", Length = "0x73")]
	[Token(Token = "0x6000004")]
	public Component get_body() { }

	[Address(RVA = "0x3135AD0", Offset = "0x3134ED0", Length = "0x26")]
	[Token(Token = "0x6000005")]
	public Collider get_collider() { }

	[Address(RVA = "0x3135B00", Offset = "0x3134F00", Length = "0x6A")]
	[Token(Token = "0x6000008")]
	public ContactPoint[] get_contacts() { }

	[Address(RVA = "0x3135B70", Offset = "0x3134F70", Length = "0x9D")]
	[Token(Token = "0x6000006")]
	public GameObject get_gameObject() { }

	[Address(RVA = "0x3135C10", Offset = "0x3135010", Length = "0x55")]
	[Token(Token = "0x6000003")]
	public Vector3 get_relativeVelocity() { }

	[Address(RVA = "0x3135720", Offset = "0x3134B20", Length = "0x5B")]
	[Token(Token = "0x600000B")]
	internal void Reuse(in ContactPairHeader header, in ContactPair pair) { }

	[Address(RVA = "0x28A42A0", Offset = "0x28A36A0", Length = "0x4")]
	[Token(Token = "0x6000007")]
	internal void set_Flipped(bool value) { }

}

