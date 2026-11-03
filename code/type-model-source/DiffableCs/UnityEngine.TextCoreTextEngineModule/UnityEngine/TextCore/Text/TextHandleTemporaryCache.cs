namespace UnityEngine.TextCore.Text;

[Token(Token = "0x2000064")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
internal class TextHandleTemporaryCache
{
	[Token(Token = "0x40003A4")]
	internal const int s_MinFramesInCache = 2; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40003A3")]
	internal LinkedList<TextCacheEntry> s_Cache; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40003A5")]
	internal int currentFrame; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40003A6")]
	private object syncRoot; //Field offset: 0x20

	[Address(RVA = "0x31C5400", Offset = "0x31C4800", Length = "0xAC")]
	[Token(Token = "0x6000310")]
	public TextHandleTemporaryCache() { }

	[Address(RVA = "0x31C46D0", Offset = "0x31C3AD0", Length = "0x581")]
	[Token(Token = "0x600030A")]
	public void AddTextInfoToCache(TextHandle textHandle, int hashCode) { }

	[Address(RVA = "0x31C4C60", Offset = "0x31C4060", Length = "0x16C")]
	[Token(Token = "0x6000309")]
	public void ClearTemporaryCache() { }

	[Address(RVA = "0x31C4DD0", Offset = "0x31C41D0", Length = "0x1F9")]
	[Token(Token = "0x600030E")]
	private void RecycleTextInfoFromCache(TextHandle textHandle) { }

	[Address(RVA = "0x31C4FD0", Offset = "0x31C43D0", Length = "0x135")]
	[Token(Token = "0x600030D")]
	private void RefreshCaching(TextHandle textHandle) { }

	[Address(RVA = "0x31C5110", Offset = "0x31C4510", Length = "0x1FC")]
	[Token(Token = "0x600030B")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal void RemoveFromCache(TextHandle handle) { }

	[Address(RVA = "0x31C5310", Offset = "0x31C4710", Length = "0xC9")]
	[Token(Token = "0x600030C")]
	internal void ResetEntryState(TextHandle handle) { }

	[Address(RVA = "0x31C53E0", Offset = "0x31C47E0", Length = "0x19")]
	[Token(Token = "0x600030F")]
	public void UpdateCurrentFrame() { }

}

