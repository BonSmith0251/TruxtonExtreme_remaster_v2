namespace UnityEngine.Rendering;

[Token(Token = "0x2000077")]
internal struct InstanceAllocators
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000214")]
	private InstanceAllocator m_InstanceAlloc_MeshRenderer; //Field offset: 0x0
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000215")]
	private InstanceAllocator m_InstanceAlloc_SpeedTree; //Field offset: 0x20
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000216")]
	private InstanceAllocator m_SharedInstanceAlloc; //Field offset: 0x40

	[Address(RVA = "0x2CE2A10", Offset = "0x2CE1E10", Length = "0xF8")]
	[Token(Token = "0x6000210")]
	public InstanceHandle AllocateInstance(InstanceType type) { }

	[Address(RVA = "0x2CE2B10", Offset = "0x2CE1F10", Length = "0x4F")]
	[Token(Token = "0x6000212")]
	public SharedInstanceHandle AllocateSharedInstance() { }

	[Address(RVA = "0x2CE2B60", Offset = "0x2CE1F60", Length = "0xEE")]
	[Token(Token = "0x600020C")]
	public void Dispose() { }

	[Address(RVA = "0x2CE2C50", Offset = "0x2CE2050", Length = "0xDF")]
	[Token(Token = "0x6000211")]
	public void FreeInstance(InstanceHandle instance) { }

	[Address(RVA = "0x2CE2D30", Offset = "0x2CE2130", Length = "0x80")]
	[Token(Token = "0x6000213")]
	public void FreeSharedInstance(SharedInstanceHandle instance) { }

	[Address(RVA = "0x2CE2DB0", Offset = "0x2CE21B0", Length = "0x8E")]
	[Token(Token = "0x600020D")]
	private InstanceAllocator GetInstanceAllocator(InstanceType type) { }

	[Address(RVA = "0x2CE2E40", Offset = "0x2CE2240", Length = "0x7E")]
	[Token(Token = "0x600020E")]
	public int GetInstanceHandlesLength(InstanceType type) { }

	[Address(RVA = "0x2CE2EC0", Offset = "0x2CE22C0", Length = "0xC3")]
	[Token(Token = "0x600020F")]
	public int GetInstancesLength(InstanceType type) { }

	[Address(RVA = "0x2CE2F90", Offset = "0x2CE2390", Length = "0x66")]
	[Token(Token = "0x600020B")]
	public void Initialize() { }

}

