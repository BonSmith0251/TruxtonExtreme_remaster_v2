namespace UnityEngine.Tilemaps;

[NativeHeader("Modules/Tilemap/Public/TilemapMarshalling.h")]
[NativeHeader("Modules/Grid/Public/GridMarshalling.h")]
[NativeHeader("Modules/Tilemap/Public/TilemapTile.h")]
[NativeHeader("Modules/Grid/Public/Grid.h")]
[NativeHeader("Runtime/Graphics/SpriteFrame.h")]
[NativeType(Header = "Modules/Tilemap/Public/Tilemap.h")]
[RequireComponent(typeof(Transform))]
[Token(Token = "0x2000006")]
public sealed class Tilemap : GridLayout
{
	[RequiredByNativeCode]
	[Token(Token = "0x2000007")]
	internal struct SyncTile
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000014")]
		internal Vector3Int m_Position; //Field offset: 0x0
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000015")]
		internal TileBase m_Tile; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000016")]
		internal TileData m_TileData; //Field offset: 0x18

	}

	[Token(Token = "0x2000008")]
	public struct SyncTileCallbackSettings
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000017")]
		internal bool hasSyncTileCallback; //Field offset: 0x0
		[FieldOffset(Offset = "0x1")]
		[Token(Token = "0x4000018")]
		internal bool hasPositionsChangedCallback; //Field offset: 0x1
		[FieldOffset(Offset = "0x2")]
		[Token(Token = "0x4000019")]
		internal bool isBufferSyncTile; //Field offset: 0x2

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000010")]
	private static Action<Tilemap, SyncTile[]> tilemapTileChanged; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000011")]
	private static Action<Tilemap, NativeArray`1<Vector3Int>> tilemapPositionsChanged; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000012")]
	private static Action<Tilemap, NativeArray`1<Vector3Int>> loopEndedForTileAnimation; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000013")]
	private bool m_BufferSyncTile; //Field offset: 0x18

	[Token(Token = "0x17000007")]
	internal bool bufferSyncTile
	{
		[Address(RVA = "0x2F8BCB0", Offset = "0x2F8B0B0", Length = "0x7")]
		[Token(Token = "0x600001D")]
		internal get { } //Length: 7
	}

	[Address(RVA = "0x31D07A0", Offset = "0x31CFBA0", Length = "0xAE")]
	[RequiredByNativeCode]
	[Token(Token = "0x600002A")]
	private void DoLoopEndedForTileAnimationCallback(int count, IntPtr positionsIntPtr) { }

	[Address(RVA = "0x31D0850", Offset = "0x31CFC50", Length = "0xAE")]
	[RequiredByNativeCode]
	[Token(Token = "0x600002D")]
	private void DoPositionsChangedCallback(int count, IntPtr positionsIntPtr) { }

	[Address(RVA = "0x31D0900", Offset = "0x31CFD00", Length = "0x59")]
	[RequiredByNativeCode]
	[Token(Token = "0x600002C")]
	private void DoSyncTileCallback(SyncTile[] syncTiles) { }

	[Address(RVA = "0x2F8BCB0", Offset = "0x2F8B0B0", Length = "0x7")]
	[Token(Token = "0x600001D")]
	internal bool get_bufferSyncTile() { }

	[Address(RVA = "0x31D0960", Offset = "0x31CFD60", Length = "0x43")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000029")]
	internal void GetLoopEndedForTileAnimationCallbackSettings(ref bool hasEndLoopForTileAnimationCallback) { }

	[Address(RVA = "0x31D09B0", Offset = "0x31CFDB0", Length = "0x8A")]
	[RequiredByNativeCode]
	[Token(Token = "0x600002B")]
	internal void GetSyncTileCallbackSettings(ref SyncTileCallbackSettings settings) { }

	[Address(RVA = "0x31D07A0", Offset = "0x31CFBA0", Length = "0xAE")]
	[Token(Token = "0x600001F")]
	private void HandleLoopEndedForTileAnimationCallback(int count, IntPtr positionsIntPtr) { }

	[Address(RVA = "0x31D0850", Offset = "0x31CFC50", Length = "0xAE")]
	[Token(Token = "0x6000024")]
	private void HandlePositionsChangedCallback(int count, IntPtr positionsIntPtr) { }

	[Address(RVA = "0x31D0900", Offset = "0x31CFD00", Length = "0x59")]
	[Token(Token = "0x6000023")]
	private void HandleSyncTileCallback(SyncTile[] syncTiles) { }

	[Address(RVA = "0x31D0A40", Offset = "0x31CFE40", Length = "0x3B")]
	[Token(Token = "0x600001E")]
	internal static bool HasLoopEndedForTileAnimationCallback() { }

	[Address(RVA = "0x31D0A80", Offset = "0x31CFE80", Length = "0x3B")]
	[Token(Token = "0x6000022")]
	internal static bool HasPositionsChangedCallback() { }

	[Address(RVA = "0x31D0AC0", Offset = "0x31CFEC0", Length = "0x3A")]
	[Token(Token = "0x6000021")]
	internal static bool HasSyncTileCallback() { }

	[Address(RVA = "0x31D0B50", Offset = "0x31CFF50", Length = "0x85")]
	[NativeMethod(Name = "RefreshTileAsset")]
	[Token(Token = "0x6000027")]
	public void RefreshTile(Vector3Int position) { }

	[Address(RVA = "0x31D0B00", Offset = "0x31CFF00", Length = "0x42")]
	[Token(Token = "0x600002E")]
	private static void RefreshTile_Injected(IntPtr _unity_self, in Vector3Int position) { }

	[Address(RVA = "0x31D0C40", Offset = "0x31D0040", Length = "0x95")]
	[FreeFunction(Name = "TilemapBindings::RefreshTileAssetsNative", HasExplicitThis = True)]
	[Token(Token = "0x6000028")]
	internal void RefreshTilesNative(Void* positions, int count) { }

	[Address(RVA = "0x31D0BE0", Offset = "0x31CFFE0", Length = "0x52")]
	[Token(Token = "0x600002F")]
	private static void RefreshTilesNative_Injected(IntPtr _unity_self, Void* positions, int count) { }

	[Address(RVA = "0x31D0CE0", Offset = "0x31D00E0", Length = "0xA9")]
	[Token(Token = "0x6000020")]
	private void SendLoopEndedForTileAnimationCallback(NativeArray<Vector3Int> positions) { }

	[Address(RVA = "0x31D0D90", Offset = "0x31D0190", Length = "0xA9")]
	[Token(Token = "0x6000026")]
	private void SendTilemapPositionsChangedCallback(NativeArray<Vector3Int> positions) { }

	[Address(RVA = "0x31D0E40", Offset = "0x31D0240", Length = "0x9E")]
	[Token(Token = "0x6000025")]
	private void SendTilemapTileChangedCallback(SyncTile[] syncTiles) { }

}

