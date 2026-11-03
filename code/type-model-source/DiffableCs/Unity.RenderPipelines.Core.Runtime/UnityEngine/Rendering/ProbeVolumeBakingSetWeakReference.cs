namespace UnityEngine.Rendering;

[Token(Token = "0x2000131")]
internal class ProbeVolumeBakingSetWeakReference
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40005C8")]
	public int m_InstanceID; //Field offset: 0x10

	[Address(RVA = "0x2C15E10", Offset = "0x2C15210", Length = "0x8D")]
	[Token(Token = "0x6000A8E")]
	public ProbeVolumeBakingSetWeakReference(ProbeVolumeBakingSet bakingSet) { }

	[Address(RVA = "0x25E1A20", Offset = "0x25E0E20", Length = "0x1D")]
	[Token(Token = "0x6000A8F")]
	public ProbeVolumeBakingSetWeakReference() { }

	[Address(RVA = "0x2C15C80", Offset = "0x2C15080", Length = "0x5C")]
	[Token(Token = "0x6000A91")]
	public ProbeVolumeBakingSet Get() { }

	[Address(RVA = "0x2C15CE0", Offset = "0x2C150E0", Length = "0x1B")]
	[Token(Token = "0x6000A92")]
	public bool IsLoaded() { }

	[Address(RVA = "0x2C15D00", Offset = "0x2C15100", Length = "0x86")]
	[Token(Token = "0x6000A90")]
	public void Set(ProbeVolumeBakingSet bakingSet) { }

	[Address(RVA = "0x2C15D90", Offset = "0x2C15190", Length = "0x79")]
	[Token(Token = "0x6000A93")]
	public void Unload() { }

}

