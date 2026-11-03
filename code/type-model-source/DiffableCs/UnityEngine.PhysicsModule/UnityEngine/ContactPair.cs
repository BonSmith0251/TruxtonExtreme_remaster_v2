namespace UnityEngine;

[IsReadOnly]
[Token(Token = "0x2000015")]
[UsedByNativeCode]
public struct ContactPair
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400004B")]
	internal readonly EntityId m_ColliderID; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x400004C")]
	internal readonly EntityId m_OtherColliderID; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400004D")]
	internal readonly IntPtr m_StartPtr; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400004E")]
	internal readonly uint m_NbPoints; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x400004F")]
	internal readonly CollisionPairFlags m_Flags; //Field offset: 0x14
	[FieldOffset(Offset = "0x16")]
	[Token(Token = "0x4000050")]
	internal readonly CollisionPairEventFlags m_Events; //Field offset: 0x16
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000051")]
	internal readonly Vector3 m_ImpulseSum; //Field offset: 0x18

	[Token(Token = "0x1700001D")]
	public Collider collider
	{
		[Address(RVA = "0x3136040", Offset = "0x3135440", Length = "0x7C")]
		[Token(Token = "0x6000088")]
		 get { } //Length: 124
	}

	[Token(Token = "0x17000022")]
	internal bool hasRemovedCollider
	{
		[Address(RVA = "0x3135D50", Offset = "0x3135150", Length = "0x14")]
		[Token(Token = "0x600008D")]
		internal get { } //Length: 20
	}

	[Token(Token = "0x1700001F")]
	public bool isCollisionEnter
	{
		[Address(RVA = "0x31360C0", Offset = "0x31354C0", Length = "0x8")]
		[Token(Token = "0x600008A")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000020")]
	public bool isCollisionExit
	{
		[Address(RVA = "0x31360D0", Offset = "0x31354D0", Length = "0x8")]
		[Token(Token = "0x600008B")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000021")]
	public bool isCollisionStay
	{
		[Address(RVA = "0x31360E0", Offset = "0x31354E0", Length = "0x8")]
		[Token(Token = "0x600008C")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700001E")]
	public Collider otherCollider
	{
		[Address(RVA = "0x31360F0", Offset = "0x31354F0", Length = "0x7E")]
		[Token(Token = "0x6000089")]
		 get { } //Length: 126
	}

	[Address(RVA = "0x3135DC0", Offset = "0x31351C0", Length = "0x1EB")]
	[Token(Token = "0x600008E")]
	internal int ExtractContactsArray(ContactPoint[] managedContainer, bool flipped) { }

	[Address(RVA = "0x3136040", Offset = "0x3135440", Length = "0x7C")]
	[Token(Token = "0x6000088")]
	public Collider get_collider() { }

	[Address(RVA = "0x3135D50", Offset = "0x3135150", Length = "0x14")]
	[Token(Token = "0x600008D")]
	internal bool get_hasRemovedCollider() { }

	[Address(RVA = "0x31360C0", Offset = "0x31354C0", Length = "0x8")]
	[Token(Token = "0x600008A")]
	public bool get_isCollisionEnter() { }

	[Address(RVA = "0x31360D0", Offset = "0x31354D0", Length = "0x8")]
	[Token(Token = "0x600008B")]
	public bool get_isCollisionExit() { }

	[Address(RVA = "0x31360E0", Offset = "0x31354E0", Length = "0x8")]
	[Token(Token = "0x600008C")]
	public bool get_isCollisionStay() { }

	[Address(RVA = "0x31360F0", Offset = "0x31354F0", Length = "0x7E")]
	[Token(Token = "0x6000089")]
	public Collider get_otherCollider() { }

	[Address(RVA = "0x3136030", Offset = "0x3135430", Length = "0xA")]
	[Token(Token = "0x600008F")]
	public ContactPairPoint GetContactPoint(int index) { }

	[Address(RVA = "0x3135FB0", Offset = "0x31353B0", Length = "0x77")]
	[Token(Token = "0x6000090")]
	internal ContactPairPoint* GetContactPoint_Internal(int index) { }

}

