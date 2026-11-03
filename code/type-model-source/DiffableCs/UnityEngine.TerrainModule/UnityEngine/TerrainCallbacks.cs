namespace UnityEngine;

[MovedFrom("UnityEngine.Experimental.TerrainAPI")]
[Token(Token = "0x2000003")]
public static class TerrainCallbacks
{
	[Token(Token = "0x2000004")]
	internal sealed class HeightmapChangedCallback : MulticastDelegate
	{

		[Address(RVA = "0x3167AE0", Offset = "0x3166EE0", Length = "0xB5")]
		[Token(Token = "0x600000D")]
		public HeightmapChangedCallback(object object, IntPtr method) { }

		[Address(RVA = "0x21524B0", Offset = "0x21518B0", Length = "0x2B")]
		[Token(Token = "0x600000E")]
		public override void Invoke(Terrain terrain, RectInt heightRegion, bool synched) { }

	}

	[Token(Token = "0x2000005")]
	internal sealed class TextureChangedCallback : MulticastDelegate
	{

		[Address(RVA = "0x316B7A0", Offset = "0x316ABA0", Length = "0xB5")]
		[Token(Token = "0x600000F")]
		public TextureChangedCallback(object object, IntPtr method) { }

		[Address(RVA = "0x316B760", Offset = "0x316AB60", Length = "0x34")]
		[Token(Token = "0x6000010")]
		public override void Invoke(Terrain terrain, string textureName, RectInt texelRegion, bool synched) { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000001")]
	private static HeightmapChangedCallback heightmapChanged; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000002")]
	private static TextureChangedCallback textureChanged; //Field offset: 0x8

	[Address(RVA = "0x3167CC0", Offset = "0x31670C0", Length = "0x15F")]
	[RequiredByNativeCode]
	[Token(Token = "0x600000B")]
	internal static void InvokeHeightmapChangedCallback(TerrainData terrainData, RectInt heightRegion, bool synched) { }

	[Address(RVA = "0x3167E20", Offset = "0x3167220", Length = "0x164")]
	[RequiredByNativeCode]
	[Token(Token = "0x600000C")]
	internal static void InvokeTextureChangedCallback(TerrainData terrainData, string textureName, RectInt texelRegion, bool synched) { }

}

