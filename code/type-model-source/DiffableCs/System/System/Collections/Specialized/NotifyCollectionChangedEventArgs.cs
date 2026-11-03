namespace System.Collections.Specialized;

[Token(Token = "0x20001E3")]
public class NotifyCollectionChangedEventArgs : EventArgs
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400071C")]
	private NotifyCollectionChangedAction _action; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400071D")]
	private IList _newItems; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400071E")]
	private IList _oldItems; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400071F")]
	private int _newStartingIndex; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000720")]
	private int _oldStartingIndex; //Field offset: 0x2C

	[Address(RVA = "0x268B300", Offset = "0x268A700", Length = "0x12B")]
	[Token(Token = "0x6000C28")]
	public NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action) { }

	[Address(RVA = "0x268AFC0", Offset = "0x268A3C0", Length = "0x338")]
	[Token(Token = "0x6000C29")]
	public NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, object changedItem, int index) { }

	[Address(RVA = "0x268B610", Offset = "0x268AA10", Length = "0x214")]
	[Token(Token = "0x6000C2A")]
	public NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, object newItem, object oldItem, int index) { }

	[Address(RVA = "0x268B430", Offset = "0x268A830", Length = "0x1D1")]
	[Token(Token = "0x6000C2B")]
	public NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, IList newItems, IList oldItems, int startingIndex) { }

	[Address(RVA = "0x268AD70", Offset = "0x268A170", Length = "0x98")]
	[Token(Token = "0x6000C2D")]
	private void InitializeAdd(NotifyCollectionChangedAction action, IList newItems, int newStartingIndex) { }

	[Address(RVA = "0x268AC60", Offset = "0x268A060", Length = "0x10B")]
	[Token(Token = "0x6000C2C")]
	private void InitializeAddOrRemove(NotifyCollectionChangedAction action, IList changedItems, int startingIndex) { }

	[Address(RVA = "0x268AE10", Offset = "0x268A210", Length = "0x10D")]
	[Token(Token = "0x6000C2F")]
	private void InitializeMoveOrReplace(NotifyCollectionChangedAction action, IList newItems, IList oldItems, int startingIndex, int oldStartingIndex) { }

	[Address(RVA = "0x268AF20", Offset = "0x268A320", Length = "0x98")]
	[Token(Token = "0x6000C2E")]
	private void InitializeRemove(NotifyCollectionChangedAction action, IList oldItems, int oldStartingIndex) { }

}

