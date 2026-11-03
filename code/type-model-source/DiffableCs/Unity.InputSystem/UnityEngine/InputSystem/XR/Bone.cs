namespace UnityEngine.InputSystem.XR;

[Token(Token = "0x20000F2")]
public struct Bone
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40005AE")]
	public uint m_ParentBoneIndex; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40005AF")]
	public Vector3 m_Position; //Field offset: 0x4
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40005B0")]
	public Quaternion m_Rotation; //Field offset: 0x10

	[Token(Token = "0x17000334")]
	public uint parentBoneIndex
	{
		[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
		[Token(Token = "0x6000C71")]
		 get { } //Length: 3
		[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
		[Token(Token = "0x6000C72")]
		 set { } //Length: 3
	}

	[Token(Token = "0x17000335")]
	public Vector3 position
	{
		[Address(RVA = "0xAEF5B0", Offset = "0xAEE9B0", Length = "0x13")]
		[Token(Token = "0x6000C73")]
		 get { } //Length: 19
		[Address(RVA = "0x29B4BA0", Offset = "0x29B3FA0", Length = "0x10")]
		[Token(Token = "0x6000C74")]
		 set { } //Length: 16
	}

	[Token(Token = "0x17000336")]
	public Quaternion rotation
	{
		[Address(RVA = "0x5D1860", Offset = "0x5D0C60", Length = "0xB")]
		[Token(Token = "0x6000C75")]
		 get { } //Length: 11
		[Address(RVA = "0x6622B0", Offset = "0x6616B0", Length = "0x8")]
		[Token(Token = "0x6000C76")]
		 set { } //Length: 8
	}

	[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
	[Token(Token = "0x6000C71")]
	public uint get_parentBoneIndex() { }

	[Address(RVA = "0xAEF5B0", Offset = "0xAEE9B0", Length = "0x13")]
	[Token(Token = "0x6000C73")]
	public Vector3 get_position() { }

	[Address(RVA = "0x5D1860", Offset = "0x5D0C60", Length = "0xB")]
	[Token(Token = "0x6000C75")]
	public Quaternion get_rotation() { }

	[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
	[Token(Token = "0x6000C72")]
	public void set_parentBoneIndex(uint value) { }

	[Address(RVA = "0x29B4BA0", Offset = "0x29B3FA0", Length = "0x10")]
	[Token(Token = "0x6000C74")]
	public void set_position(Vector3 value) { }

	[Address(RVA = "0x6622B0", Offset = "0x6616B0", Length = "0x8")]
	[Token(Token = "0x6000C76")]
	public void set_rotation(Quaternion value) { }

}

