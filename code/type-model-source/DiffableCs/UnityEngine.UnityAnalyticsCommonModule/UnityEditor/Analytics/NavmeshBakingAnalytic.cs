namespace UnityEditor.Analytics;

[ExcludeFromDocs]
[RequiredByNativeCode(GenerateProxy = True)]
[Token(Token = "0x2000011")]
public class NavmeshBakingAnalytic : AnalyticsEventBase
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000032")]
	private bool new_nav_api; //Field offset: 0x30
	[FieldOffset(Offset = "0x31")]
	[Token(Token = "0x4000033")]
	private bool bake_at_runtime; //Field offset: 0x31
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000034")]
	private int height_meshes_count; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000035")]
	private int offmesh_links_count; //Field offset: 0x38

	[Address(RVA = "0x3478100", Offset = "0x3477500", Length = "0x64")]
	[Token(Token = "0x600001D")]
	public NavmeshBakingAnalytic() { }

	[Address(RVA = "0x3478070", Offset = "0x3477470", Length = "0x8F")]
	[RequiredByNativeCode]
	[Token(Token = "0x600001E")]
	internal static NavmeshBakingAnalytic CreateNavmeshBakingAnalytic() { }

}

