namespace UnityEngine.Rendering.UnifiedRayTracing;

[Token(Token = "0x200002E")]
internal struct GeometryPoolEntryInfo
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000111")]
	public bool valid; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000112")]
	public uint refCount; //Field offset: 0x4

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x600008C")]
	public static GeometryPoolEntryInfo NewDefault() { }

}

