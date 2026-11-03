namespace System.Collections;

[Token(Token = "0x20005B2")]
public class CaseInsensitiveComparer : IComparer
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40017BB")]
	private CompareInfo _compareInfo; //Field offset: 0x10

	[Token(Token = "0x17000632")]
	public static CaseInsensitiveComparer Default
	{
		[Address(RVA = "0x1FBFDF0", Offset = "0x1FBF1F0", Length = "0xEC")]
		[Token(Token = "0x6002991")]
		 get { } //Length: 236
	}

	[Address(RVA = "0x1FBFCC0", Offset = "0x1FBF0C0", Length = "0x81")]
	[Token(Token = "0x600298F")]
	public CaseInsensitiveComparer() { }

	[Address(RVA = "0x1FBFD50", Offset = "0x1FBF150", Length = "0x94")]
	[Token(Token = "0x6002990")]
	public CaseInsensitiveComparer(CultureInfo culture) { }

	[Address(RVA = "0x1FBFA80", Offset = "0x1FBEE80", Length = "0x230")]
	[Token(Token = "0x6002992")]
	public override int Compare(object a, object b) { }

	[Address(RVA = "0x1FBFDF0", Offset = "0x1FBF1F0", Length = "0xEC")]
	[Token(Token = "0x6002991")]
	public static CaseInsensitiveComparer get_Default() { }

}

