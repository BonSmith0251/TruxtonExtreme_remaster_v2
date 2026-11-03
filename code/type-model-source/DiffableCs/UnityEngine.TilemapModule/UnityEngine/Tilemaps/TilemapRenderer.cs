namespace UnityEngine.Tilemaps;

[NativeHeader("Modules/Tilemap/TilemapRendererJobs.h")]
[NativeHeader("Modules/Tilemap/Public/TilemapMarshalling.h")]
[NativeHeader("Modules/Grid/Public/GridMarshalling.h")]
[NativeType(Header = "Modules/Tilemap/Public/TilemapRenderer.h")]
[RequireComponent(typeof(Tilemap))]
[Token(Token = "0x200000B")]
public sealed class TilemapRenderer : Renderer
{

	[Address(RVA = "0x31D0600", Offset = "0x31CFA00", Length = "0xBA")]
	[Token(Token = "0x6000032")]
	internal void OnSpriteAtlasRegistered(SpriteAtlas atlas) { }

	[Address(RVA = "0x31D05B0", Offset = "0x31CF9B0", Length = "0x42")]
	[Token(Token = "0x6000033")]
	private static void OnSpriteAtlasRegistered_Injected(IntPtr _unity_self, IntPtr atlas) { }

	[Address(RVA = "0x31D06C0", Offset = "0x31CFAC0", Length = "0x6D")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000030")]
	internal void RegisterSpriteAtlasRegistered() { }

	[Address(RVA = "0x31D0730", Offset = "0x31CFB30", Length = "0x6D")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000031")]
	internal void UnregisterSpriteAtlasRegistered() { }

}

