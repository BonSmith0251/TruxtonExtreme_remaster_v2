namespace System.Collections;

[Token(Token = "0x200059F")]
public sealed class Comparer : IComparer, ISerializable
{
	[Token(Token = "0x40017A1")]
	public static readonly Comparer Default; //Field offset: 0x0
	[Token(Token = "0x40017A2")]
	public static readonly Comparer DefaultInvariant; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40017A0")]
	private CompareInfo _compareInfo; //Field offset: 0x10

	[Address(RVA = "0x1FC0EA0", Offset = "0x1FC02A0", Length = "0x1DB")]
	[Token(Token = "0x6002936")]
	private static Comparer() { }

	[Address(RVA = "0x1FC1200", Offset = "0x1FC0600", Length = "0x94")]
	[Token(Token = "0x6002932")]
	public Comparer(CultureInfo culture) { }

	[Address(RVA = "0x1FC1080", Offset = "0x1FC0480", Length = "0x17C")]
	[Token(Token = "0x6002933")]
	private Comparer(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x1FC0C60", Offset = "0x1FC0060", Length = "0x19C")]
	[Token(Token = "0x6002935")]
	public override int Compare(object a, object b) { }

	[Address(RVA = "0x1FC0E00", Offset = "0x1FC0200", Length = "0x99")]
	[Token(Token = "0x6002934")]
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

}

