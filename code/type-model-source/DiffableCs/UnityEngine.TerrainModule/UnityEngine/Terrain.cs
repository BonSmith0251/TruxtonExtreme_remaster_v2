namespace UnityEngine;

[NativeHeader("Runtime/Interfaces/ITerrainManager.h")]
[NativeHeader("TerrainScriptingClasses.h")]
[NativeHeader("Modules/Terrain/Public/Terrain.h")]
[StaticAccessor("GetITerrainManager()", StaticAccessorType::Arrow (1))]
[Token(Token = "0x2000002")]
[UsedByNativeCode]
public sealed class Terrain : Behaviour
{

	[NativeProperty("ActiveTerrainsScriptingArray")]
	[Token(Token = "0x17000004")]
	public static Terrain[] activeTerrains
	{
		[Address(RVA = "0x316B4D0", Offset = "0x316A8D0", Length = "0x2A")]
		[Token(Token = "0x6000005")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000002")]
	public bool allowAutoConnect
	{
		[Address(RVA = "0x316B540", Offset = "0x316A940", Length = "0x76")]
		[Token(Token = "0x6000002")]
		 get { } //Length: 118
	}

	[Token(Token = "0x17000003")]
	public int groupingID
	{
		[Address(RVA = "0x316B600", Offset = "0x316AA00", Length = "0x76")]
		[Token(Token = "0x6000003")]
		 get { } //Length: 118
	}

	[Token(Token = "0x17000001")]
	public TerrainData terrainData
	{
		[Address(RVA = "0x316B6C0", Offset = "0x316AAC0", Length = "0x90")]
		[Token(Token = "0x6000001")]
		 get { } //Length: 144
	}

	[Address(RVA = "0x5B7910", Offset = "0x5B6D10", Length = "0x7")]
	[Token(Token = "0x6000006")]
	public Terrain() { }

	[Address(RVA = "0x316B4D0", Offset = "0x316A8D0", Length = "0x2A")]
	[Token(Token = "0x6000005")]
	public static Terrain[] get_activeTerrains() { }

	[Address(RVA = "0x316B540", Offset = "0x316A940", Length = "0x76")]
	[Token(Token = "0x6000002")]
	public bool get_allowAutoConnect() { }

	[Address(RVA = "0x316B500", Offset = "0x316A900", Length = "0x33")]
	[Token(Token = "0x6000008")]
	private static bool get_allowAutoConnect_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x316B600", Offset = "0x316AA00", Length = "0x76")]
	[Token(Token = "0x6000003")]
	public int get_groupingID() { }

	[Address(RVA = "0x316B5C0", Offset = "0x316A9C0", Length = "0x33")]
	[Token(Token = "0x6000009")]
	private static int get_groupingID_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x316B6C0", Offset = "0x316AAC0", Length = "0x90")]
	[Token(Token = "0x6000001")]
	public TerrainData get_terrainData() { }

	[Address(RVA = "0x316B680", Offset = "0x316AA80", Length = "0x33")]
	[Token(Token = "0x6000007")]
	private static IntPtr get_terrainData_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x316B380", Offset = "0x316A780", Length = "0x145")]
	[Token(Token = "0x6000004")]
	public void SetNeighbors(Terrain left, Terrain top, Terrain right, Terrain bottom) { }

	[Address(RVA = "0x316B310", Offset = "0x316A710", Length = "0x62")]
	[Token(Token = "0x600000A")]
	private static void SetNeighbors_Injected(IntPtr _unity_self, IntPtr left, IntPtr top, IntPtr right, IntPtr bottom) { }

}

