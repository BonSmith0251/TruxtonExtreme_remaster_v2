namespace System.Data;

[Token(Token = "0x2000025")]
public class InternalDataCollectionBase : ICollection, IEnumerable
{
	[Token(Token = "0x40000E8")]
	internal static readonly CollectionChangeEventArgs s_refreshEventArgs; //Field offset: 0x0

	[Browsable(False)]
	[Token(Token = "0x17000071")]
	public override int Count
	{
		[Address(RVA = "0x23291D0", Offset = "0x23285D0", Length = "0x3C")]
		[Token(Token = "0x6000310")]
		 get { } //Length: 60
	}

	[Browsable(False)]
	[Token(Token = "0x17000072")]
	public override bool IsSynchronized
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6000313")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000074")]
	protected override ArrayList List
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x6000316")]
		 get { } //Length: 3
	}

	[Browsable(False)]
	[Token(Token = "0x17000073")]
	public override object SyncRoot
	{
		[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
		[Token(Token = "0x6000315")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x2329150", Offset = "0x2328550", Length = "0x7C")]
	[Token(Token = "0x6000318")]
	private static InternalDataCollectionBase() { }

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000317")]
	public InternalDataCollectionBase() { }

	[Address(RVA = "0x2328FB0", Offset = "0x23283B0", Length = "0x54")]
	[Token(Token = "0x6000311")]
	public override void CopyTo(Array ar, int index) { }

	[Address(RVA = "0x23291D0", Offset = "0x23285D0", Length = "0x3C")]
	[Token(Token = "0x6000310")]
	public override int get_Count() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000313")]
	public override bool get_IsSynchronized() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6000316")]
	protected override ArrayList get_List() { }

	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[Token(Token = "0x6000315")]
	public override object get_SyncRoot() { }

	[Address(RVA = "0x2329010", Offset = "0x2328410", Length = "0x3C")]
	[Token(Token = "0x6000312")]
	public override IEnumerator GetEnumerator() { }

	[Address(RVA = "0x2329050", Offset = "0x2328450", Length = "0xF5")]
	[Token(Token = "0x6000314")]
	internal int NamesEqual(string s1, string s2, bool fCaseSensitive, CultureInfo locale) { }

}

