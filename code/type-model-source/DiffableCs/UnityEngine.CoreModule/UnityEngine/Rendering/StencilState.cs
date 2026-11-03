namespace UnityEngine.Rendering;

[Token(Token = "0x20003F8")]
public struct StencilState : IEquatable<StencilState>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000D27")]
	private byte m_Enabled; //Field offset: 0x0
	[FieldOffset(Offset = "0x1")]
	[Token(Token = "0x4000D28")]
	private byte m_ReadMask; //Field offset: 0x1
	[FieldOffset(Offset = "0x2")]
	[Token(Token = "0x4000D29")]
	private byte m_WriteMask; //Field offset: 0x2
	[FieldOffset(Offset = "0x3")]
	[Token(Token = "0x4000D2A")]
	private byte m_Padding; //Field offset: 0x3
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000D2B")]
	private byte m_CompareFunctionFront; //Field offset: 0x4
	[FieldOffset(Offset = "0x5")]
	[Token(Token = "0x4000D2C")]
	private byte m_PassOperationFront; //Field offset: 0x5
	[FieldOffset(Offset = "0x6")]
	[Token(Token = "0x4000D2D")]
	private byte m_FailOperationFront; //Field offset: 0x6
	[FieldOffset(Offset = "0x7")]
	[Token(Token = "0x4000D2E")]
	private byte m_ZFailOperationFront; //Field offset: 0x7
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000D2F")]
	private byte m_CompareFunctionBack; //Field offset: 0x8
	[FieldOffset(Offset = "0x9")]
	[Token(Token = "0x4000D30")]
	private byte m_PassOperationBack; //Field offset: 0x9
	[FieldOffset(Offset = "0xA")]
	[Token(Token = "0x4000D31")]
	private byte m_FailOperationBack; //Field offset: 0xA
	[FieldOffset(Offset = "0xB")]
	[Token(Token = "0x4000D32")]
	private byte m_ZFailOperationBack; //Field offset: 0xB

	[Token(Token = "0x1700047D")]
	public CompareFunction compareFunctionBack
	{
		[Address(RVA = "0x30CEE70", Offset = "0x30CE270", Length = "0x7")]
		[Token(Token = "0x6001EB4")]
		 get { } //Length: 7
		[Address(RVA = "0x1BB2EC0", Offset = "0x1BB22C0", Length = "0x4")]
		[Token(Token = "0x6001EB5")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000479")]
	public CompareFunction compareFunctionFront
	{
		[Address(RVA = "0x30CEE80", Offset = "0x30CE280", Length = "0x7")]
		[Token(Token = "0x6001EAC")]
		 get { } //Length: 7
		[Address(RVA = "0x1E16980", Offset = "0x1E15D80", Length = "0x4")]
		[Token(Token = "0x6001EAD")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000475")]
	public static StencilState defaultValue
	{
		[Address(RVA = "0x30CEE90", Offset = "0x30CE290", Length = "0x84")]
		[Token(Token = "0x6001E9F")]
		 get { } //Length: 132
	}

	[Token(Token = "0x17000476")]
	public bool enabled
	{
		[Address(RVA = "0x30CEF20", Offset = "0x30CE320", Length = "0x4C")]
		[Token(Token = "0x6001EA2")]
		 get { } //Length: 76
		[Address(RVA = "0x30CEFF0", Offset = "0x30CE3F0", Length = "0x58")]
		[Token(Token = "0x6001EA3")]
		 set { } //Length: 88
	}

	[Token(Token = "0x1700047F")]
	public StencilOp failOperationBack
	{
		[Address(RVA = "0x30CEF70", Offset = "0x30CE370", Length = "0x7")]
		[Token(Token = "0x6001EB8")]
		 get { } //Length: 7
		[Address(RVA = "0x2C1D6C0", Offset = "0x2C1CAC0", Length = "0x4")]
		[Token(Token = "0x6001EB9")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700047B")]
	public StencilOp failOperationFront
	{
		[Address(RVA = "0x30CEF80", Offset = "0x30CE380", Length = "0x7")]
		[Token(Token = "0x6001EB0")]
		 get { } //Length: 7
		[Address(RVA = "0x30CF050", Offset = "0x30CE450", Length = "0x4")]
		[Token(Token = "0x6001EB1")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700047E")]
	public StencilOp passOperationBack
	{
		[Address(RVA = "0x30CEF90", Offset = "0x30CE390", Length = "0x7")]
		[Token(Token = "0x6001EB6")]
		 get { } //Length: 7
		[Address(RVA = "0x1BB2F50", Offset = "0x1BB2350", Length = "0x4")]
		[Token(Token = "0x6001EB7")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700047A")]
	public StencilOp passOperationFront
	{
		[Address(RVA = "0x30CEFA0", Offset = "0x30CE3A0", Length = "0x7")]
		[Token(Token = "0x6001EAE")]
		 get { } //Length: 7
		[Address(RVA = "0x30CF060", Offset = "0x30CE460", Length = "0x4")]
		[Token(Token = "0x6001EAF")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000477")]
	public byte readMask
	{
		[Address(RVA = "0x30CEFB0", Offset = "0x30CE3B0", Length = "0x7")]
		[Token(Token = "0x6001EA4")]
		 get { } //Length: 7
		[Address(RVA = "0x290B440", Offset = "0x290A840", Length = "0x4")]
		[Token(Token = "0x6001EA5")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000478")]
	public byte writeMask
	{
		[Address(RVA = "0x30CEFC0", Offset = "0x30CE3C0", Length = "0x7")]
		[Token(Token = "0x6001EA6")]
		 get { } //Length: 7
		[Address(RVA = "0x290B1E0", Offset = "0x290A5E0", Length = "0x4")]
		[Token(Token = "0x6001EA7")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000480")]
	public StencilOp zFailOperationBack
	{
		[Address(RVA = "0x30CEFD0", Offset = "0x30CE3D0", Length = "0x7")]
		[Token(Token = "0x6001EBA")]
		 get { } //Length: 7
		[Address(RVA = "0x30CF070", Offset = "0x30CE470", Length = "0x4")]
		[Token(Token = "0x6001EBB")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700047C")]
	public StencilOp zFailOperationFront
	{
		[Address(RVA = "0x30CEFE0", Offset = "0x30CE3E0", Length = "0x7")]
		[Token(Token = "0x6001EB2")]
		 get { } //Length: 7
		[Address(RVA = "0x30CF080", Offset = "0x30CE480", Length = "0x4")]
		[Token(Token = "0x6001EB3")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x30CEE10", Offset = "0x30CE210", Length = "0x5C")]
	[Token(Token = "0x6001EA0")]
	public StencilState(bool enabled = true, byte readMask = 255, byte writeMask = 255, CompareFunction compareFunction = 8, StencilOp passOperation = 0, StencilOp failOperation = 0, StencilOp zFailOperation = 0) { }

	[Address(RVA = "0x30CED40", Offset = "0x30CE140", Length = "0xC7")]
	[Token(Token = "0x6001EA1")]
	public StencilState(bool enabled, byte readMask, byte writeMask, CompareFunction compareFunctionFront, StencilOp passOperationFront, StencilOp failOperationFront, StencilOp zFailOperationFront, CompareFunction compareFunctionBack, StencilOp passOperationBack, StencilOp failOperationBack, StencilOp zFailOperationBack) { }

	[Address(RVA = "0x30CEA40", Offset = "0x30CDE40", Length = "0x6A")]
	[Token(Token = "0x6001EBC")]
	public override bool Equals(StencilState other) { }

	[Address(RVA = "0x30CEAB0", Offset = "0x30CDEB0", Length = "0x146")]
	[Token(Token = "0x6001EBD")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x30CEE70", Offset = "0x30CE270", Length = "0x7")]
	[Token(Token = "0x6001EB4")]
	public CompareFunction get_compareFunctionBack() { }

	[Address(RVA = "0x30CEE80", Offset = "0x30CE280", Length = "0x7")]
	[Token(Token = "0x6001EAC")]
	public CompareFunction get_compareFunctionFront() { }

	[Address(RVA = "0x30CEE90", Offset = "0x30CE290", Length = "0x84")]
	[Token(Token = "0x6001E9F")]
	public static StencilState get_defaultValue() { }

	[Address(RVA = "0x30CEF20", Offset = "0x30CE320", Length = "0x4C")]
	[Token(Token = "0x6001EA2")]
	public bool get_enabled() { }

	[Address(RVA = "0x30CEF70", Offset = "0x30CE370", Length = "0x7")]
	[Token(Token = "0x6001EB8")]
	public StencilOp get_failOperationBack() { }

	[Address(RVA = "0x30CEF80", Offset = "0x30CE380", Length = "0x7")]
	[Token(Token = "0x6001EB0")]
	public StencilOp get_failOperationFront() { }

	[Address(RVA = "0x30CEF90", Offset = "0x30CE390", Length = "0x7")]
	[Token(Token = "0x6001EB6")]
	public StencilOp get_passOperationBack() { }

	[Address(RVA = "0x30CEFA0", Offset = "0x30CE3A0", Length = "0x7")]
	[Token(Token = "0x6001EAE")]
	public StencilOp get_passOperationFront() { }

	[Address(RVA = "0x30CEFB0", Offset = "0x30CE3B0", Length = "0x7")]
	[Token(Token = "0x6001EA4")]
	public byte get_readMask() { }

	[Address(RVA = "0x30CEFC0", Offset = "0x30CE3C0", Length = "0x7")]
	[Token(Token = "0x6001EA6")]
	public byte get_writeMask() { }

	[Address(RVA = "0x30CEFD0", Offset = "0x30CE3D0", Length = "0x7")]
	[Token(Token = "0x6001EBA")]
	public StencilOp get_zFailOperationBack() { }

	[Address(RVA = "0x30CEFE0", Offset = "0x30CE3E0", Length = "0x7")]
	[Token(Token = "0x6001EB2")]
	public StencilOp get_zFailOperationFront() { }

	[Address(RVA = "0x30CEC00", Offset = "0x30CE000", Length = "0xFB")]
	[Token(Token = "0x6001EBE")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1BB2EC0", Offset = "0x1BB22C0", Length = "0x4")]
	[Token(Token = "0x6001EB5")]
	public void set_compareFunctionBack(CompareFunction value) { }

	[Address(RVA = "0x1E16980", Offset = "0x1E15D80", Length = "0x4")]
	[Token(Token = "0x6001EAD")]
	public void set_compareFunctionFront(CompareFunction value) { }

	[Address(RVA = "0x30CEFF0", Offset = "0x30CE3F0", Length = "0x58")]
	[Token(Token = "0x6001EA3")]
	public void set_enabled(bool value) { }

	[Address(RVA = "0x2C1D6C0", Offset = "0x2C1CAC0", Length = "0x4")]
	[Token(Token = "0x6001EB9")]
	public void set_failOperationBack(StencilOp value) { }

	[Address(RVA = "0x30CF050", Offset = "0x30CE450", Length = "0x4")]
	[Token(Token = "0x6001EB1")]
	public void set_failOperationFront(StencilOp value) { }

	[Address(RVA = "0x1BB2F50", Offset = "0x1BB2350", Length = "0x4")]
	[Token(Token = "0x6001EB7")]
	public void set_passOperationBack(StencilOp value) { }

	[Address(RVA = "0x30CF060", Offset = "0x30CE460", Length = "0x4")]
	[Token(Token = "0x6001EAF")]
	public void set_passOperationFront(StencilOp value) { }

	[Address(RVA = "0x290B440", Offset = "0x290A840", Length = "0x4")]
	[Token(Token = "0x6001EA5")]
	public void set_readMask(byte value) { }

	[Address(RVA = "0x290B1E0", Offset = "0x290A5E0", Length = "0x4")]
	[Token(Token = "0x6001EA7")]
	public void set_writeMask(byte value) { }

	[Address(RVA = "0x30CF070", Offset = "0x30CE470", Length = "0x4")]
	[Token(Token = "0x6001EBB")]
	public void set_zFailOperationBack(StencilOp value) { }

	[Address(RVA = "0x30CF080", Offset = "0x30CE480", Length = "0x4")]
	[Token(Token = "0x6001EB3")]
	public void set_zFailOperationFront(StencilOp value) { }

	[Address(RVA = "0x30CED00", Offset = "0x30CE100", Length = "0x7")]
	[Token(Token = "0x6001EA8")]
	public void SetCompareFunction(CompareFunction value) { }

	[Address(RVA = "0x30CED10", Offset = "0x30CE110", Length = "0x7")]
	[Token(Token = "0x6001EAA")]
	public void SetFailOperation(StencilOp value) { }

	[Address(RVA = "0x30CED20", Offset = "0x30CE120", Length = "0x7")]
	[Token(Token = "0x6001EA9")]
	public void SetPassOperation(StencilOp value) { }

	[Address(RVA = "0x30CED30", Offset = "0x30CE130", Length = "0x7")]
	[Token(Token = "0x6001EAB")]
	public void SetZFailOperation(StencilOp value) { }

}

