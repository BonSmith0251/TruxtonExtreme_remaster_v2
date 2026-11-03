namespace System.Xml.Schema;

[Token(Token = "0x2000239")]
public abstract class XmlSchemaParticle : XmlSchemaAnnotated
{
	[Token(Token = "0x200023B")]
	private class EmptyParticle : XmlSchemaParticle
	{

		[Token(Token = "0x17000630")]
		internal virtual bool IsEmpty
		{
			[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
			[Token(Token = "0x6001643")]
			internal get { } //Length: 3
		}

		[Address(RVA = "0x24910B0", Offset = "0x24904B0", Length = "0xA9")]
		[Token(Token = "0x6001644")]
		public EmptyParticle() { }

		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6001643")]
		internal virtual bool get_IsEmpty() { }

	}

	[Flags]
	[Token(Token = "0x200023A")]
	private enum Occurs : int
	{
		None = 0,
		Min = 1,
		Max = 2,
	}

	[Token(Token = "0x4000BBA")]
	internal static readonly XmlSchemaParticle Empty; //Field offset: 0x0
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000BB7")]
	private decimal minOccurs; //Field offset: 0x50
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000BB8")]
	private decimal maxOccurs; //Field offset: 0x60
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000BB9")]
	private Occurs flags; //Field offset: 0x70

	[Token(Token = "0x1700062E")]
	internal override bool IsEmpty
	{
		[Address(RVA = "0x2498F70", Offset = "0x2498370", Length = "0x7F")]
		[Token(Token = "0x600163E")]
		internal get { } //Length: 127
	}

	[Token(Token = "0x1700062D")]
	[XmlIgnore]
	public decimal MaxOccurs
	{
		[Address(RVA = "0x20D8470", Offset = "0x20D7870", Length = "0xB")]
		[Token(Token = "0x600163C")]
		 get { } //Length: 11
		[Address(RVA = "0x24993B0", Offset = "0x24987B0", Length = "0x19A")]
		[Token(Token = "0x600163D")]
		 set { } //Length: 410
	}

	[Token(Token = "0x1700062B")]
	[XmlAttribute("maxOccurs")]
	public string MaxOccursString
	{
		[Address(RVA = "0x2498FF0", Offset = "0x24983F0", Length = "0x114")]
		[Token(Token = "0x6001638")]
		 get { } //Length: 276
		[Address(RVA = "0x2499180", Offset = "0x2498580", Length = "0x22D")]
		[Token(Token = "0x6001639")]
		 set { } //Length: 557
	}

	[Token(Token = "0x1700062C")]
	[XmlIgnore]
	public decimal MinOccurs
	{
		[Address(RVA = "0xFF9390", Offset = "0xFF8790", Length = "0xB")]
		[Token(Token = "0x600163A")]
		 get { } //Length: 11
		[Address(RVA = "0x24996C0", Offset = "0x2498AC0", Length = "0x13D")]
		[Token(Token = "0x600163B")]
		 set { } //Length: 317
	}

	[Token(Token = "0x1700062A")]
	[XmlAttribute("minOccurs")]
	public string MinOccursString
	{
		[Address(RVA = "0x2499110", Offset = "0x2498510", Length = "0x6E")]
		[Token(Token = "0x6001636")]
		 get { } //Length: 110
		[Address(RVA = "0x2499550", Offset = "0x2498950", Length = "0x167")]
		[Token(Token = "0x6001637")]
		 set { } //Length: 359
	}

	[Token(Token = "0x1700062F")]
	internal override string NameString
	{
		[Address(RVA = "0x11EDDE0", Offset = "0x11ED1E0", Length = "0x12")]
		[Token(Token = "0x600163F")]
		internal get { } //Length: 18
	}

	[Address(RVA = "0x2498DE0", Offset = "0x24981E0", Length = "0x104")]
	[Token(Token = "0x6001642")]
	private static XmlSchemaParticle() { }

	[Address(RVA = "0x2498EF0", Offset = "0x24982F0", Length = "0x78")]
	[Token(Token = "0x6001641")]
	protected XmlSchemaParticle() { }

	[Address(RVA = "0x2498F70", Offset = "0x2498370", Length = "0x7F")]
	[Token(Token = "0x600163E")]
	internal override bool get_IsEmpty() { }

	[Address(RVA = "0x20D8470", Offset = "0x20D7870", Length = "0xB")]
	[Token(Token = "0x600163C")]
	public decimal get_MaxOccurs() { }

	[Address(RVA = "0x2498FF0", Offset = "0x24983F0", Length = "0x114")]
	[Token(Token = "0x6001638")]
	public string get_MaxOccursString() { }

	[Address(RVA = "0xFF9390", Offset = "0xFF8790", Length = "0xB")]
	[Token(Token = "0x600163A")]
	public decimal get_MinOccurs() { }

	[Address(RVA = "0x2499110", Offset = "0x2498510", Length = "0x6E")]
	[Token(Token = "0x6001636")]
	public string get_MinOccursString() { }

	[Address(RVA = "0x11EDDE0", Offset = "0x11ED1E0", Length = "0x12")]
	[Token(Token = "0x600163F")]
	internal override string get_NameString() { }

	[Address(RVA = "0x2498C60", Offset = "0x2498060", Length = "0x173")]
	[Token(Token = "0x6001640")]
	internal XmlQualifiedName GetQualifiedName() { }

	[Address(RVA = "0x24993B0", Offset = "0x24987B0", Length = "0x19A")]
	[Token(Token = "0x600163D")]
	public void set_MaxOccurs(decimal value) { }

	[Address(RVA = "0x2499180", Offset = "0x2498580", Length = "0x22D")]
	[Token(Token = "0x6001639")]
	public void set_MaxOccursString(string value) { }

	[Address(RVA = "0x24996C0", Offset = "0x2498AC0", Length = "0x13D")]
	[Token(Token = "0x600163B")]
	public void set_MinOccurs(decimal value) { }

	[Address(RVA = "0x2499550", Offset = "0x2498950", Length = "0x167")]
	[Token(Token = "0x6001637")]
	public void set_MinOccursString(string value) { }

}

