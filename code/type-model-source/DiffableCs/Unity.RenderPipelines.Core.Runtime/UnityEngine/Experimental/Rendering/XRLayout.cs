namespace UnityEngine.Experimental.Rendering;

[Token(Token = "0x200000D")]
public class XRLayout
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000035")]
	private readonly List<ValueTuple`2<Camera, XRPass>> m_ActivePasses; //Field offset: 0x10

	[Address(RVA = "0x2BC99F0", Offset = "0x2BC8DF0", Length = "0x77")]
	[Token(Token = "0x6000032")]
	public XRLayout() { }

	[Address(RVA = "0x2BC8F70", Offset = "0x2BC8370", Length = "0x23A")]
	[Token(Token = "0x600002C")]
	public void AddCamera(Camera camera, bool enableXR) { }

	[Address(RVA = "0x2BC91B0", Offset = "0x2BC85B0", Length = "0x133")]
	[Token(Token = "0x600002F")]
	internal void AddPass(Camera camera, XRPass xrPass) { }

	[Address(RVA = "0x2BC92F0", Offset = "0x2BC86F0", Length = "0x125")]
	[Token(Token = "0x6000030")]
	internal void Clear() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x600002E")]
	public List<ValueTuple`2<Camera, XRPass>> GetActivePasses() { }

	[Address(RVA = "0x2BC9420", Offset = "0x2BC8820", Length = "0x51F")]
	[Token(Token = "0x6000031")]
	internal void LogDebugInfo() { }

	[Address(RVA = "0x2BC9940", Offset = "0x2BC8D40", Length = "0xAF")]
	[Token(Token = "0x600002D")]
	public void ReconfigurePass(XRPass xrPass, Camera camera) { }

}

