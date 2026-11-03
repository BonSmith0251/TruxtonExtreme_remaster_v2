namespace UnityEngine.U2D;

[Extension]
[NativeHeader("Runtime/Graphics/SpriteFrame.h")]
[NativeHeader("Runtime/2D/Common/SpriteDataAccess.h")]
[Token(Token = "0x200043D")]
public static class SpriteDataAccessExtensions
{

	[Address(RVA = "0x912D70", Offset = "0x912170", Length = "0x2BC")]
	[Token(Token = "0x6001FA4")]
	private static void CheckAttributeTypeMatchesAndThrow(VertexAttribute channel) { }

	[Address(RVA = "0x30CE740", Offset = "0x30CDB40", Length = "0xC8")]
	[Token(Token = "0x6001FA8")]
	private static SpriteChannelInfo GetChannelInfo(Sprite sprite, VertexAttribute channel) { }

	[Address(RVA = "0x30CE6F0", Offset = "0x30CDAF0", Length = "0x50")]
	[Token(Token = "0x6001FAA")]
	private static void GetChannelInfo_Injected(IntPtr sprite, VertexAttribute channel, out SpriteChannelInfo ret) { }

	[Address(RVA = "0x30CE920", Offset = "0x30CDD20", Length = "0x119")]
	[Extension]
	[Token(Token = "0x6001FA6")]
	public static NativeArray<UInt16> GetIndices(Sprite sprite) { }

	[Address(RVA = "0x30CE860", Offset = "0x30CDC60", Length = "0xB9")]
	[Token(Token = "0x6001FA7")]
	private static SpriteChannelInfo GetIndicesInfo(Sprite sprite) { }

	[Address(RVA = "0x30CE810", Offset = "0x30CDC10", Length = "0x42")]
	[Token(Token = "0x6001FA9")]
	private static void GetIndicesInfo_Injected(IntPtr sprite, out SpriteChannelInfo ret) { }

	[Address(RVA = "0x913160", Offset = "0x912560", Length = "0xF8")]
	[Extension]
	[Token(Token = "0x6001FA5")]
	public static NativeSlice<T> GetVertexAttribute(Sprite sprite, VertexAttribute channel) { }

}

