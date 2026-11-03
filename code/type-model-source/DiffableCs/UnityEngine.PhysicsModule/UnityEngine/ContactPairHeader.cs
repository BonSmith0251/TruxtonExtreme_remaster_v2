namespace UnityEngine;

[IsReadOnly]
[Token(Token = "0x2000014")]
[UsedByNativeCode]
public struct ContactPairHeader
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000045")]
	internal readonly EntityId m_BodyID; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000046")]
	internal readonly EntityId m_OtherBodyID; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000047")]
	internal readonly IntPtr m_StartPtr; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000048")]
	internal readonly uint m_NbPairs; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000049")]
	internal readonly CollisionPairHeaderFlags m_Flags; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400004A")]
	internal readonly Vector3 m_RelativeVelocity; //Field offset: 0x18

	[Token(Token = "0x1700001A")]
	public Component body
	{
		[Address(RVA = "0x3135D00", Offset = "0x3135100", Length = "0x4A")]
		[Token(Token = "0x6000083")]
		 get { } //Length: 74
	}

	[Token(Token = "0x1700001C")]
	internal bool hasRemovedBody
	{
		[Address(RVA = "0x3135D50", Offset = "0x3135150", Length = "0x14")]
		[Token(Token = "0x6000085")]
		internal get { } //Length: 20
	}

	[Token(Token = "0x1700001B")]
	public Component otherBody
	{
		[Address(RVA = "0x3135D70", Offset = "0x3135170", Length = "0x4B")]
		[Token(Token = "0x6000084")]
		 get { } //Length: 75
	}

	[Address(RVA = "0x3135D00", Offset = "0x3135100", Length = "0x4A")]
	[Token(Token = "0x6000083")]
	public Component get_body() { }

	[Address(RVA = "0x3135D50", Offset = "0x3135150", Length = "0x14")]
	[Token(Token = "0x6000085")]
	internal bool get_hasRemovedBody() { }

	[Address(RVA = "0x3135D70", Offset = "0x3135170", Length = "0x4B")]
	[Token(Token = "0x6000084")]
	public Component get_otherBody() { }

	[Address(RVA = "0x3135CF0", Offset = "0x31350F0", Length = "0xA")]
	[Token(Token = "0x6000086")]
	public ContactPair GetContactPair(int index) { }

	[Address(RVA = "0x3135C70", Offset = "0x3135070", Length = "0x77")]
	[Token(Token = "0x6000087")]
	internal ContactPair* GetContactPair_Internal(int index) { }

}

