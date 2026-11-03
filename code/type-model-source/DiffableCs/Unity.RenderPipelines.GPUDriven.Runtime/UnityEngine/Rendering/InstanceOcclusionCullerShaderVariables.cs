namespace UnityEngine.Rendering;

[GenerateHLSL(PackingRules::Exact (0), True, False, False, 1, False, False, False, -1, ".\\Library\\PackageCache\\com.unity.render-pipelines.core@d6dfd1e235d5\\Runtime\\GPUDriven\\InstanceOcclusionCullerShaderVariables.cs", needAccessors = False, generateCBuffer = True)]
[Token(Token = "0x20000B5")]
internal struct InstanceOcclusionCullerShaderVariables
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000368")]
	public uint _DrawInfoAllocIndex; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000369")]
	public uint _DrawInfoCount; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400036A")]
	public uint _InstanceInfoAllocIndex; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x400036B")]
	public uint _InstanceInfoCount; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400036C")]
	public int _BoundingSphereInstanceDataAddress; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x400036D")]
	public int _DebugCounterIndex; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400036E")]
	public int _InstanceMultiplierShift; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x400036F")]
	public int _InstanceOcclusionCullerPad0; //Field offset: 0x1C

}

