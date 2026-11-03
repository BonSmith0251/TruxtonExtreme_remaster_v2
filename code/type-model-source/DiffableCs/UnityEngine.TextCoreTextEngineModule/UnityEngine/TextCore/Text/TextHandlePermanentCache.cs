namespace UnityEngine.TextCore.Text;

[Token(Token = "0x2000061")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
internal class TextHandlePermanentCache
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400039E")]
	internal LinkedList<TextCacheEntry> s_Cache; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400039F")]
	private object syncRoot; //Field offset: 0x18

	[Address(RVA = "0x31C4620", Offset = "0x31C3A20", Length = "0xAC")]
	[Token(Token = "0x6000305")]
	public TextHandlePermanentCache() { }

	[Address(RVA = "0x31C4070", Offset = "0x31C3470", Length = "0x314")]
	[Token(Token = "0x6000302")]
	public void AddToCache(TextHandle textHandle) { }

	[Address(RVA = "0x31C4390", Offset = "0x31C3790", Length = "0x1CD")]
	[Token(Token = "0x6000303")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	public void RemoveFromCache(TextHandle textHandle) { }

	[Address(RVA = "0x31C4560", Offset = "0x31C3960", Length = "0xB4")]
	[Token(Token = "0x6000304")]
	private void ResetEntryState(TextHandle handle) { }

}

