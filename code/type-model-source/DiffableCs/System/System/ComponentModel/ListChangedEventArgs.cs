namespace System.ComponentModel;

[Token(Token = "0x2000184")]
public class ListChangedEventArgs : EventArgs
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000636")]
	private readonly ListChangedType <ListChangedType>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000637")]
	private readonly int <NewIndex>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000638")]
	private readonly int <OldIndex>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000639")]
	private readonly PropertyDescriptor <PropertyDescriptor>k__BackingField; //Field offset: 0x20

	[Token(Token = "0x170001CB")]
	public ListChangedType ListChangedType
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[CompilerGenerated]
		[Token(Token = "0x600096A")]
		 get { } //Length: 85
	}

	[Token(Token = "0x170001CC")]
	public int NewIndex
	{
		[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600096B")]
		 get { } //Length: 4
	}

	[Token(Token = "0x170001CD")]
	public int OldIndex
	{
		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600096C")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x2664200", Offset = "0x2663600", Length = "0x6F")]
	[Token(Token = "0x6000966")]
	public ListChangedEventArgs(ListChangedType listChangedType, int newIndex) { }

	[Address(RVA = "0x2664270", Offset = "0x2663670", Length = "0x8F")]
	[Token(Token = "0x6000967")]
	public ListChangedEventArgs(ListChangedType listChangedType, int newIndex, PropertyDescriptor propDesc) { }

	[Address(RVA = "0x2664100", Offset = "0x2663500", Length = "0x74")]
	[Token(Token = "0x6000968")]
	public ListChangedEventArgs(ListChangedType listChangedType, PropertyDescriptor propDesc) { }

	[Address(RVA = "0x2664180", Offset = "0x2663580", Length = "0x78")]
	[Token(Token = "0x6000969")]
	public ListChangedEventArgs(ListChangedType listChangedType, int newIndex, int oldIndex) { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[CompilerGenerated]
	[Token(Token = "0x600096A")]
	public ListChangedType get_ListChangedType() { }

	[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x600096B")]
	public int get_NewIndex() { }

	[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x600096C")]
	public int get_OldIndex() { }

}

