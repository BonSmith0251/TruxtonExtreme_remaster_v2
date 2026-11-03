namespace UnityEngine.TerrainUtils;

[MovedFrom("UnityEngine.Experimental.TerrainAPI")]
[Token(Token = "0x200000E")]
public static class TerrainUtility
{
	[CompilerGenerated]
	[Token(Token = "0x200000F")]
	private sealed class <>c__DisplayClass2_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400002B")]
		public bool onlyAutoConnectedTerrains; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000045")]
		public <>c__DisplayClass2_0() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000010")]
	private sealed class <>c__DisplayClass2_1
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400002C")]
		public Terrain t; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400002D")]
		public <>c__DisplayClass2_0 CS$<>8__locals1; //Field offset: 0x18

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000046")]
		public <>c__DisplayClass2_1() { }

		[Address(RVA = "0x316BAB0", Offset = "0x316AEB0", Length = "0x17C")]
		[Token(Token = "0x6000047")]
		internal bool <CollectTerrains>b__0(Terrain x) { }

	}


	[Address(RVA = "0x316A8A0", Offset = "0x3169CA0", Length = "0x590")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000044")]
	public static void AutoConnect() { }

	[Address(RVA = "0x316AE40", Offset = "0x316A240", Length = "0x19E")]
	[Token(Token = "0x6000042")]
	internal static void ClearConnectivity() { }

	[Address(RVA = "0x316AFE0", Offset = "0x316A3E0", Length = "0x2B2")]
	[Token(Token = "0x6000043")]
	internal static Dictionary<Int32, TerrainMap> CollectTerrains(bool onlyAutoConnectedTerrains = true) { }

	[Address(RVA = "0x316B2A0", Offset = "0x316A6A0", Length = "0x6A")]
	[Token(Token = "0x6000041")]
	internal static bool ValidTerrainsExist() { }

}

