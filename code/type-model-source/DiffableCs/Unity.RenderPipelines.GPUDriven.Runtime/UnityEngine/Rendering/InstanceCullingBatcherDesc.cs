namespace UnityEngine.Rendering;

[Token(Token = "0x2000055")]
internal struct InstanceCullingBatcherDesc
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000174")]
	public OnCullingCompleteCallback onCompleteCallback; //Field offset: 0x0

	[Address(RVA = "0x2CE4900", Offset = "0x2CE3D00", Length = "0x23")]
	[Token(Token = "0x6000172")]
	public static InstanceCullingBatcherDesc NewDefault() { }

}

