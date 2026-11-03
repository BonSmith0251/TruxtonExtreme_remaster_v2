namespace UnityEngine.Tilemaps;

[RequiredByNativeCode]
[Token(Token = "0x2000005")]
public abstract class TileBase : ScriptableObject
{

	[Address(RVA = "0x5B3AF0", Offset = "0x5B2EF0", Length = "0x7")]
	[Token(Token = "0x600001C")]
	protected TileBase() { }

	[Address(RVA = "0x8E85F0", Offset = "0x8E79F0", Length = "0x5")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000017")]
	public override bool GetTileAnimationData(Vector3Int position, ITilemap tilemap, ref TileAnimationData tileAnimationData) { }

	[Address(RVA = "0x31CFBE0", Offset = "0x31CEFE0", Length = "0x90")]
	[Token(Token = "0x6000018")]
	private TileAnimationData GetTileAnimationDataNoRef(Vector3Int position, ITilemap tilemap) { }

	[Address(RVA = "0x31CFC70", Offset = "0x31CF070", Length = "0x3F")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000019")]
	private void GetTileAnimationDataRef(Vector3Int position, ITilemap tilemap, ref TileAnimationData tileAnimationData, ref bool hasAnimation) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000015")]
	public override void GetTileData(Vector3Int position, ITilemap tilemap, ref TileData tileData) { }

	[Address(RVA = "0x31CFCB0", Offset = "0x31CF0B0", Length = "0xD4")]
	[Token(Token = "0x6000016")]
	private TileData GetTileDataNoRef(Vector3Int position, ITilemap tilemap) { }

	[Address(RVA = "0x31CFD90", Offset = "0x31CF190", Length = "0x1D5")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000014")]
	public override void RefreshTile(Vector3Int position, ITilemap tilemap) { }

	[Address(RVA = "0x8E85F0", Offset = "0x8E79F0", Length = "0x5")]
	[RequiredByNativeCode]
	[Token(Token = "0x600001A")]
	public override bool StartUp(Vector3Int position, ITilemap tilemap, GameObject go) { }

	[Address(RVA = "0x31CFF70", Offset = "0x31CF370", Length = "0x3F")]
	[RequiredByNativeCode]
	[Token(Token = "0x600001B")]
	private void StartUpRef(Vector3Int position, ITilemap tilemap, GameObject go, ref bool startUpInvokedByUser) { }

}

