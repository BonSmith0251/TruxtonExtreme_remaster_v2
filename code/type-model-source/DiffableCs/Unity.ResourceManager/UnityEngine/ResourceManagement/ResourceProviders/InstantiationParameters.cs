namespace UnityEngine.ResourceManagement.ResourceProviders;

[Token(Token = "0x2000057")]
public struct InstantiationParameters
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000F6")]
	private Vector3 m_Position; //Field offset: 0x0
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x40000F7")]
	private Quaternion m_Rotation; //Field offset: 0xC
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000F8")]
	private Transform m_Parent; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40000F9")]
	private bool m_InstantiateInWorldPosition; //Field offset: 0x28
	[FieldOffset(Offset = "0x29")]
	[Token(Token = "0x40000FA")]
	private bool m_SetPositionRotation; //Field offset: 0x29

	[Token(Token = "0x1700004E")]
	public bool InstantiateInWorldPosition
	{
		[Address(RVA = "0x5BB290", Offset = "0x5BA690", Length = "0x5")]
		[Token(Token = "0x6000200")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700004D")]
	public Transform Parent
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x60001FF")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700004B")]
	public Vector3 Position
	{
		[Address(RVA = "0xAEF0B0", Offset = "0xAEE4B0", Length = "0x12")]
		[Token(Token = "0x60001FD")]
		 get { } //Length: 18
	}

	[Token(Token = "0x1700004C")]
	public Quaternion Rotation
	{
		[Address(RVA = "0x28A7D30", Offset = "0x28A7130", Length = "0xB")]
		[Token(Token = "0x60001FE")]
		 get { } //Length: 11
	}

	[Token(Token = "0x1700004F")]
	public bool SetPositionRotation
	{
		[Address(RVA = "0x5BB2A0", Offset = "0x5BA6A0", Length = "0x5")]
		[Token(Token = "0x6000201")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2E419F0", Offset = "0x2E40DF0", Length = "0xAC")]
	[Token(Token = "0x6000202")]
	public InstantiationParameters(Transform parent, bool instantiateInWorldSpace) { }

	[Address(RVA = "0x2E41AA0", Offset = "0x2E40EA0", Length = "0x3B")]
	[Token(Token = "0x6000203")]
	public InstantiationParameters(Vector3 position, Quaternion rotation, Transform parent) { }

	[Address(RVA = "0x5BB290", Offset = "0x5BA690", Length = "0x5")]
	[Token(Token = "0x6000200")]
	public bool get_InstantiateInWorldPosition() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x60001FF")]
	public Transform get_Parent() { }

	[Address(RVA = "0xAEF0B0", Offset = "0xAEE4B0", Length = "0x12")]
	[Token(Token = "0x60001FD")]
	public Vector3 get_Position() { }

	[Address(RVA = "0x28A7D30", Offset = "0x28A7130", Length = "0xB")]
	[Token(Token = "0x60001FE")]
	public Quaternion get_Rotation() { }

	[Address(RVA = "0x5BB2A0", Offset = "0x5BA6A0", Length = "0x5")]
	[Token(Token = "0x6000201")]
	public bool get_SetPositionRotation() { }

	[Address(RVA = "0x84BFC0", Offset = "0x84B3C0", Length = "0x197")]
	[Token(Token = "0x6000204")]
	public TObject Instantiate(TObject source) { }

}

