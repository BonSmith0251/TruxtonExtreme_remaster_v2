namespace UnityEngine.Rendering;

[GenerateHLSL(PackingRules::Exact (0), True, False, False, 1, False, False, False, -1, ".\\Library\\PackageCache\\com.unity.render-pipelines.core@d6dfd1e235d5\\Runtime\\GPUDriven\\InstanceOcclusionCuller.cs", needAccessors = False)]
[Token(Token = "0x20000A9")]
internal struct IndirectDrawInfo
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000320")]
	public uint indexCount; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000321")]
	public uint firstIndex; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000322")]
	public uint baseVertex; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000323")]
	public uint firstInstanceGlobalIndex; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000324")]
	public uint maxInstanceCountAndTopology; //Field offset: 0x10

}

