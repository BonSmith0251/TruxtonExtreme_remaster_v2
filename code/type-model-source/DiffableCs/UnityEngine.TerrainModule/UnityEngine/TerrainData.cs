namespace UnityEngine;

[NativeHeader("Modules/Terrain/Public/TerrainDataScriptingInterface.h")]
[NativeHeader("TerrainScriptingClasses.h")]
[Token(Token = "0x2000008")]
[UsedByNativeCode]
public sealed class TerrainData : object
{
	[Token(Token = "0x2000009")]
	private enum BoundaryValueType : int
	{
		MaxHeightmapRes = 0,
		MinDetailResPerPatch = 1,
		MaxDetailResPerPatch = 2,
		MaxDetailPatchCount = 3,
		MaxCoveragePerRes = 4,
		MinAlphamapRes = 5,
		MaxAlphamapRes = 6,
		MinBaseMapRes = 7,
		MaxBaseMapRes = 8,
	}

	[Token(Token = "0x400000E")]
	internal static readonly int k_MaximumResolution; //Field offset: 0x0
	[Token(Token = "0x400000F")]
	internal static readonly int k_MinimumDetailResolutionPerPatch; //Field offset: 0x4
	[Token(Token = "0x4000010")]
	internal static readonly int k_MaximumDetailResolutionPerPatch; //Field offset: 0x8
	[Token(Token = "0x4000011")]
	internal static readonly int k_MaximumDetailPatchCount; //Field offset: 0xC
	[Token(Token = "0x4000012")]
	internal static readonly int k_MinimumAlphamapResolution; //Field offset: 0x10
	[Token(Token = "0x4000013")]
	internal static readonly int k_MaximumAlphamapResolution; //Field offset: 0x14
	[Token(Token = "0x4000014")]
	internal static readonly int k_MinimumBaseMapResolution; //Field offset: 0x18
	[Token(Token = "0x4000015")]
	internal static readonly int k_MaximumBaseMapResolution; //Field offset: 0x1C

	[Token(Token = "0x1700000E")]
	public Bounds bounds
	{
		[Address(RVA = "0x3168990", Offset = "0x3167D90", Length = "0xB5")]
		[NativeName("GetHeightmap().CalculateBounds")]
		[Token(Token = "0x600001F")]
		 get { } //Length: 181
	}

	[Token(Token = "0x17000009")]
	public int heightmapResolution
	{
		[Address(RVA = "0x3168A50", Offset = "0x3167E50", Length = "0x97")]
		[Token(Token = "0x600001A")]
		 get { } //Length: 151
	}

	[Token(Token = "0x1700000B")]
	public Vector3 heightmapScale
	{
		[Address(RVA = "0x3168B40", Offset = "0x3167F40", Length = "0xB1")]
		[NativeName("GetHeightmap().GetScale")]
		[Token(Token = "0x600001C")]
		 get { } //Length: 177
	}

	[Token(Token = "0x17000008")]
	public RenderTexture heightmapTexture
	{
		[Address(RVA = "0x3168C40", Offset = "0x3168040", Length = "0xB1")]
		[NativeName("GetHeightmap().GetHeightmapTexture")]
		[Token(Token = "0x6000019")]
		 get { } //Length: 177
	}

	[Token(Token = "0x1700000C")]
	public int holesResolution
	{
		[Address(RVA = "0x3168D00", Offset = "0x3168100", Length = "0x99")]
		[Token(Token = "0x600001D")]
		 get { } //Length: 153
	}

	[Token(Token = "0x1700000A")]
	private int internalHeightmapResolution
	{
		[Address(RVA = "0x3168A50", Offset = "0x3167E50", Length = "0x97")]
		[NativeName("GetHeightmap().GetResolution")]
		[Token(Token = "0x600001B")]
		private get { } //Length: 151
	}

	[Token(Token = "0x1700000D")]
	public Vector3 size
	{
		[Address(RVA = "0x3168E30", Offset = "0x3168230", Length = "0xB1")]
		[NativeName("GetHeightmap().GetSize")]
		[Token(Token = "0x600001E")]
		 get { } //Length: 177
	}

	[Token(Token = "0x1700000F")]
	public TreeInstance[] treeInstances
	{
		[Address(RVA = "0x3168EF0", Offset = "0x31682F0", Length = "0x9")]
		[Token(Token = "0x6000024")]
		 get { } //Length: 9
	}

	[Token(Token = "0x17000010")]
	public TreePrototype[] treePrototypes
	{
		[Address(RVA = "0x3168F40", Offset = "0x3168340", Length = "0x97")]
		[FreeFunction("TerrainDataScriptingInterface::GetTreePrototypes", HasExplicitThis = True)]
		[Token(Token = "0x6000026")]
		 get { } //Length: 151
	}

	[Token(Token = "0x17000011")]
	internal Terrain[] users
	{
		[Address(RVA = "0x3169020", Offset = "0x3168420", Length = "0x97")]
		[Token(Token = "0x6000028")]
		internal get { } //Length: 151
	}

	[Address(RVA = "0x3168760", Offset = "0x3167B60", Length = "0x1DA")]
	[Token(Token = "0x6000029")]
	private static TerrainData() { }

	[Address(RVA = "0x3168990", Offset = "0x3167D90", Length = "0xB5")]
	[NativeName("GetHeightmap().CalculateBounds")]
	[Token(Token = "0x600001F")]
	public Bounds get_bounds() { }

	[Address(RVA = "0x3168940", Offset = "0x3167D40", Length = "0x42")]
	[Token(Token = "0x600002E")]
	private static void get_bounds_Injected(IntPtr _unity_self, out Bounds ret) { }

	[Address(RVA = "0x3168A50", Offset = "0x3167E50", Length = "0x97")]
	[Token(Token = "0x600001A")]
	public int get_heightmapResolution() { }

	[Address(RVA = "0x3168B40", Offset = "0x3167F40", Length = "0xB1")]
	[NativeName("GetHeightmap().GetScale")]
	[Token(Token = "0x600001C")]
	public Vector3 get_heightmapScale() { }

	[Address(RVA = "0x3168AF0", Offset = "0x3167EF0", Length = "0x42")]
	[Token(Token = "0x600002C")]
	private static void get_heightmapScale_Injected(IntPtr _unity_self, out Vector3 ret) { }

	[Address(RVA = "0x3168C40", Offset = "0x3168040", Length = "0xB1")]
	[NativeName("GetHeightmap().GetHeightmapTexture")]
	[Token(Token = "0x6000019")]
	public RenderTexture get_heightmapTexture() { }

	[Address(RVA = "0x3168C00", Offset = "0x3168000", Length = "0x33")]
	[Token(Token = "0x600002A")]
	private static IntPtr get_heightmapTexture_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3168D00", Offset = "0x3168100", Length = "0x99")]
	[Token(Token = "0x600001D")]
	public int get_holesResolution() { }

	[Address(RVA = "0x3168A50", Offset = "0x3167E50", Length = "0x97")]
	[NativeName("GetHeightmap().GetResolution")]
	[Token(Token = "0x600001B")]
	private int get_internalHeightmapResolution() { }

	[Address(RVA = "0x3168DA0", Offset = "0x31681A0", Length = "0x33")]
	[Token(Token = "0x600002B")]
	private static int get_internalHeightmapResolution_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3168E30", Offset = "0x3168230", Length = "0xB1")]
	[NativeName("GetHeightmap().GetSize")]
	[Token(Token = "0x600001E")]
	public Vector3 get_size() { }

	[Address(RVA = "0x3168DE0", Offset = "0x31681E0", Length = "0x42")]
	[Token(Token = "0x600002D")]
	private static void get_size_Injected(IntPtr _unity_self, out Vector3 ret) { }

	[Address(RVA = "0x3168EF0", Offset = "0x31682F0", Length = "0x9")]
	[Token(Token = "0x6000024")]
	public TreeInstance[] get_treeInstances() { }

	[Address(RVA = "0x3168F40", Offset = "0x3168340", Length = "0x97")]
	[FreeFunction("TerrainDataScriptingInterface::GetTreePrototypes", HasExplicitThis = True)]
	[Token(Token = "0x6000026")]
	public TreePrototype[] get_treePrototypes() { }

	[Address(RVA = "0x3168F00", Offset = "0x3168300", Length = "0x33")]
	[Token(Token = "0x6000032")]
	private static TreePrototype[] get_treePrototypes_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3169020", Offset = "0x3168420", Length = "0x97")]
	[Token(Token = "0x6000028")]
	internal Terrain[] get_users() { }

	[Address(RVA = "0x3168FE0", Offset = "0x31683E0", Length = "0x33")]
	[Token(Token = "0x6000034")]
	private static Terrain[] get_users_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3167FD0", Offset = "0x31673D0", Length = "0x97")]
	[NativeName("GetSplatDatabase().GetAlphamapResolution")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000027")]
	internal float GetAlphamapResolutionInternal() { }

	[Address(RVA = "0x3167F90", Offset = "0x3167390", Length = "0x33")]
	[Token(Token = "0x6000033")]
	private static float GetAlphamapResolutionInternal_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3168070", Offset = "0x3167470", Length = "0x31")]
	[StaticAccessor("TerrainDataScriptingInterface", StaticAccessorType::DoubleColon (2))]
	[ThreadSafe]
	[Token(Token = "0x6000018")]
	private static int GetBoundaryValue(BoundaryValueType type) { }

	[Address(RVA = "0x31680B0", Offset = "0x31674B0", Length = "0x16B")]
	[Token(Token = "0x6000020")]
	public Single[2] GetHeights(int xBase, int yBase, int width, int height) { }

	[Address(RVA = "0x3168220", Offset = "0x3167620", Length = "0x164")]
	[Token(Token = "0x6000022")]
	public Boolean[2] GetHoles(int xBase, int yBase, int width, int height) { }

	[Address(RVA = "0x31683F0", Offset = "0x31677F0", Length = "0xC8")]
	[FreeFunction("TerrainDataScriptingInterface::GetHeights", HasExplicitThis = True)]
	[Token(Token = "0x6000021")]
	private Single[2] Internal_GetHeights(int xBase, int yBase, int width, int height) { }

	[Address(RVA = "0x3168390", Offset = "0x3167790", Length = "0x60")]
	[Token(Token = "0x600002F")]
	private static Single[2] Internal_GetHeights_Injected(IntPtr _unity_self, int xBase, int yBase, int width, int height) { }

	[Address(RVA = "0x3168520", Offset = "0x3167920", Length = "0xC8")]
	[FreeFunction("TerrainDataScriptingInterface::GetHoles", HasExplicitThis = True)]
	[Token(Token = "0x6000023")]
	private Boolean[2] Internal_GetHoles(int xBase, int yBase, int width, int height) { }

	[Address(RVA = "0x31684C0", Offset = "0x31678C0", Length = "0x60")]
	[Token(Token = "0x6000030")]
	private static Boolean[2] Internal_GetHoles_Injected(IntPtr _unity_self, int xBase, int yBase, int width, int height) { }

	[Address(RVA = "0x3168640", Offset = "0x3167A40", Length = "0x11E")]
	[NativeName("GetTreeDatabase().GetInstances")]
	[Token(Token = "0x6000025")]
	private TreeInstance[] Internal_GetTreeInstances() { }

	[Address(RVA = "0x31685F0", Offset = "0x31679F0", Length = "0x42")]
	[Token(Token = "0x6000031")]
	private static void Internal_GetTreeInstances_Injected(IntPtr _unity_self, out BlittableArrayWrapper ret) { }

}

