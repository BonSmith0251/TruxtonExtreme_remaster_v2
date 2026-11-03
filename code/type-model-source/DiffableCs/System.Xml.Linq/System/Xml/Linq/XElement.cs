namespace System.Xml.Linq;

[Token(Token = "0x200000F")]
[XmlSchemaProvider(null, IsAny = True)]
[XmlTypeConvertor("ConvertForAssignment")]
public class XElement : XContainer, IXmlSerializable
{
	[CompilerGenerated]
	[Token(Token = "0x2000010")]
	private sealed class <GetAttributes>d__116 : IEnumerable<XAttribute>, IEnumerable, IEnumerator<XAttribute>, IDisposable, IEnumerator
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400001D")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400001E")]
		private XAttribute <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400001F")]
		private int <>l__initialThreadId; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000020")]
		public XElement <>4__this; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000021")]
		private XName name; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000022")]
		public XName <>3__name; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000023")]
		private XAttribute <a>5__2; //Field offset: 0x40

		[Token(Token = "0x1700001B")]
		private override XAttribute System.Collections.Generic.IEnumerator<System.Xml.Linq.XAttribute>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x600007F")]
			private get { } //Length: 5
		}

		[Token(Token = "0x1700001C")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000081")]
			private get { } //Length: 5
		}

		[Address(RVA = "0xA66430", Offset = "0xA65830", Length = "0x2E")]
		[DebuggerHidden]
		[Token(Token = "0x600007C")]
		public <GetAttributes>d__116(int <>1__state) { }

		[Address(RVA = "0x24069E0", Offset = "0x2405DE0", Length = "0xD5")]
		[Token(Token = "0x600007E")]
		private override bool MoveNext() { }

		[Address(RVA = "0x2406AC0", Offset = "0x2405EC0", Length = "0xAD")]
		[DebuggerHidden]
		[Token(Token = "0x6000082")]
		private override IEnumerator<XAttribute> System.Collections.Generic.IEnumerable<System.Xml.Linq.XAttribute>.GetEnumerator() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x600007F")]
		private override XAttribute System.Collections.Generic.IEnumerator<System.Xml.Linq.XAttribute>.get_Current() { }

		[Address(RVA = "0x2406AC0", Offset = "0x2405EC0", Length = "0xAD")]
		[DebuggerHidden]
		[Token(Token = "0x6000083")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000081")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x2406B70", Offset = "0x2405F70", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000080")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x600007D")]
		private override void System.IDisposable.Dispose() { }

	}

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400001B")]
	internal XName name; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400001C")]
	internal XAttribute lastAttr; //Field offset: 0x38

	[Token(Token = "0x17000016")]
	public bool HasAttributes
	{
		[Address(RVA = "0xF51B30", Offset = "0xF50F30", Length = "0x9")]
		[Token(Token = "0x6000064")]
		 get { } //Length: 9
	}

	[Token(Token = "0x17000017")]
	public bool IsEmpty
	{
		[Address(RVA = "0x240CFC0", Offset = "0x240C3C0", Length = "0x9")]
		[Token(Token = "0x6000065")]
		 get { } //Length: 9
	}

	[Token(Token = "0x17000018")]
	public XName Name
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[Token(Token = "0x6000066")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000019")]
	public virtual XmlNodeType NodeType
	{
		[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
		[Token(Token = "0x6000067")]
		 get { } //Length: 6
	}

	[Token(Token = "0x1700001A")]
	public string Value
	{
		[Address(RVA = "0x240CFD0", Offset = "0x240C3D0", Length = "0x100")]
		[Token(Token = "0x6000068")]
		 get { } //Length: 256
		[Address(RVA = "0x240D0E0", Offset = "0x240C4E0", Length = "0x7C")]
		[Token(Token = "0x6000069")]
		 set { } //Length: 124
	}

	[Address(RVA = "0x240CF40", Offset = "0x240C340", Length = "0x7E")]
	[Token(Token = "0x6000061")]
	public XElement(XName name) { }

	[Address(RVA = "0x240CD20", Offset = "0x240C120", Length = "0x183")]
	[Token(Token = "0x6000062")]
	public XElement(XElement other) { }

	[Address(RVA = "0x240CEB0", Offset = "0x240C2B0", Length = "0x8E")]
	[Token(Token = "0x6000063")]
	public XElement(XStreamingElement other) { }

	[Address(RVA = "0x240B570", Offset = "0x240A970", Length = "0x25D")]
	[Token(Token = "0x6000071")]
	internal virtual void AddAttribute(XAttribute a) { }

	[Address(RVA = "0x240B3F0", Offset = "0x240A7F0", Length = "0x171")]
	[Token(Token = "0x6000072")]
	internal virtual void AddAttributeSkipNotify(XAttribute a) { }

	[Address(RVA = "0x240B860", Offset = "0x240AC60", Length = "0x179")]
	[Token(Token = "0x6000073")]
	internal void AppendAttribute(XAttribute a) { }

	[Address(RVA = "0x240B7D0", Offset = "0x240ABD0", Length = "0x82")]
	[Token(Token = "0x6000074")]
	internal void AppendAttributeSkipNotify(XAttribute a) { }

	[Address(RVA = "0x240B9E0", Offset = "0x240ADE0", Length = "0x30")]
	[Token(Token = "0x600006A")]
	public XAttribute Attribute(XName name) { }

	[Address(RVA = "0x240BA20", Offset = "0x240AE20", Length = "0x84")]
	[Token(Token = "0x600006B")]
	public IEnumerable<XAttribute> Attributes() { }

	[Address(RVA = "0x240BAB0", Offset = "0x240AEB0", Length = "0x1B6")]
	[Token(Token = "0x6000075")]
	internal virtual XNode CloneNode() { }

	[Address(RVA = "0xF51B30", Offset = "0xF50F30", Length = "0x9")]
	[Token(Token = "0x6000064")]
	public bool get_HasAttributes() { }

	[Address(RVA = "0x240CFC0", Offset = "0x240C3C0", Length = "0x9")]
	[Token(Token = "0x6000065")]
	public bool get_IsEmpty() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[Token(Token = "0x6000066")]
	public XName get_Name() { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x6000067")]
	public virtual XmlNodeType get_NodeType() { }

	[Address(RVA = "0x240CFD0", Offset = "0x240C3D0", Length = "0x100")]
	[Token(Token = "0x6000068")]
	public string get_Value() { }

	[Address(RVA = "0x240BC70", Offset = "0x240B070", Length = "0x8E")]
	[IteratorStateMachine(typeof(<GetAttributes>d__116))]
	[Token(Token = "0x6000076")]
	private IEnumerable<XAttribute> GetAttributes(XName name) { }

	[Address(RVA = "0x240BD00", Offset = "0x240B100", Length = "0x118")]
	[Token(Token = "0x6000077")]
	private string GetNamespaceOfPrefixInScope(string prefix, XElement outOfScope) { }

	[Address(RVA = "0x240BE20", Offset = "0x240B220", Length = "0x2C2")]
	[Token(Token = "0x600006C")]
	public string GetPrefixOfNamespace(XNamespace ns) { }

	[Address(RVA = "0x240C760", Offset = "0x240BB60", Length = "0x91")]
	[Token(Token = "0x6000078")]
	private void ReadElementFrom(XmlReader r, LoadOptions o) { }

	[Address(RVA = "0x240C0F0", Offset = "0x240B4F0", Length = "0x663")]
	[Token(Token = "0x6000079")]
	private void ReadElementFromImpl(XmlReader r, LoadOptions o) { }

	[Address(RVA = "0x240D0E0", Offset = "0x240C4E0", Length = "0x7C")]
	[Token(Token = "0x6000069")]
	public void set_Value(string value) { }

	[Address(RVA = "0x240C800", Offset = "0x240BC00", Length = "0x79")]
	[Token(Token = "0x600007A")]
	internal void SetEndElementLineInfo(int lineNumber, int linePosition) { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x600006E")]
	private override XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	[Address(RVA = "0x240C880", Offset = "0x240BC80", Length = "0x21E")]
	[Token(Token = "0x600006F")]
	private override void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	[Address(RVA = "0x240CAA0", Offset = "0x240BEA0", Length = "0x14")]
	[Token(Token = "0x6000070")]
	private override void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	[Address(RVA = "0x240CAC0", Offset = "0x240BEC0", Length = "0x198")]
	[Token(Token = "0x600007B")]
	internal virtual void ValidateNode(XNode node, XNode previous) { }

	[Address(RVA = "0x240CC60", Offset = "0x240C060", Length = "0xBA")]
	[Token(Token = "0x600006D")]
	public virtual void WriteTo(XmlWriter writer) { }

}

