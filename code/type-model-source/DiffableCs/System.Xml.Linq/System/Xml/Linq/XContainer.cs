namespace System.Xml.Linq;

[Token(Token = "0x2000009")]
public abstract class XContainer : XNode
{
	[CompilerGenerated]
	[Token(Token = "0x200000B")]
	private sealed class <Nodes>d__18 : IEnumerable<XNode>, IEnumerable, IEnumerator<XNode>, IDisposable, IEnumerator
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400000E")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400000F")]
		private XNode <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000010")]
		private int <>l__initialThreadId; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000011")]
		public XContainer <>4__this; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000012")]
		private XNode <n>5__2; //Field offset: 0x30

		[Token(Token = "0x17000009")]
		private override XNode System.Collections.Generic.IEnumerator<System.Xml.Linq.XNode>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x600003C")]
			private get { } //Length: 5
		}

		[Token(Token = "0x1700000A")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x600003E")]
			private get { } //Length: 5
		}

		[Address(RVA = "0xA66430", Offset = "0xA65830", Length = "0x2E")]
		[DebuggerHidden]
		[Token(Token = "0x6000039")]
		public <Nodes>d__18(int <>1__state) { }

		[Address(RVA = "0x2406BB0", Offset = "0x2405FB0", Length = "0x203")]
		[Token(Token = "0x600003B")]
		private override bool MoveNext() { }

		[Address(RVA = "0x2406DC0", Offset = "0x24061C0", Length = "0x9C")]
		[DebuggerHidden]
		[Token(Token = "0x600003F")]
		private override IEnumerator<XNode> System.Collections.Generic.IEnumerable<System.Xml.Linq.XNode>.GetEnumerator() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x600003C")]
		private override XNode System.Collections.Generic.IEnumerator<System.Xml.Linq.XNode>.get_Current() { }

		[Address(RVA = "0x2406DC0", Offset = "0x24061C0", Length = "0x9C")]
		[DebuggerHidden]
		[Token(Token = "0x6000040")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x600003E")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x2406E60", Offset = "0x2406260", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x600003D")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x600003A")]
		private override void System.IDisposable.Dispose() { }

	}

	[Token(Token = "0x200000A")]
	private sealed class ContentReader
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000009")]
		private readonly NamespaceCache _eCache; //Field offset: 0x10
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400000A")]
		private readonly NamespaceCache _aCache; //Field offset: 0x20
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400000B")]
		private readonly IXmlLineInfo _lineInfo; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x400000C")]
		private XContainer _currentContainer; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x400000D")]
		private string _baseUri; //Field offset: 0x40

		[Address(RVA = "0x5C1790", Offset = "0x5C0B90", Length = "0x31")]
		[Token(Token = "0x6000035")]
		public ContentReader(XContainer rootContainer) { }

		[Address(RVA = "0x2405740", Offset = "0x2404B40", Length = "0xCF")]
		[Token(Token = "0x6000036")]
		public ContentReader(XContainer rootContainer, XmlReader r, LoadOptions o) { }

		[Address(RVA = "0x2404CA0", Offset = "0x24040A0", Length = "0xD4")]
		[Token(Token = "0x6000037")]
		public bool ReadContentFrom(XContainer rootContainer, XmlReader r) { }

		[Address(RVA = "0x2403DB0", Offset = "0x24031B0", Length = "0x110")]
		[Token(Token = "0x6000038")]
		public bool ReadContentFrom(XContainer rootContainer, XmlReader r, LoadOptions o) { }

	}

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000008")]
	internal object content; //Field offset: 0x28

	[Token(Token = "0x17000008")]
	public XNode LastNode
	{
		[Address(RVA = "0x240A460", Offset = "0x2409860", Length = "0x166")]
		[Token(Token = "0x600001E")]
		 get { } //Length: 358
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x600001C")]
	internal XContainer() { }

	[Address(RVA = "0x240A300", Offset = "0x2409700", Length = "0x15E")]
	[Token(Token = "0x600001D")]
	internal XContainer(XContainer other) { }

	[Address(RVA = "0x2408A10", Offset = "0x2407E10", Length = "0x3A1")]
	[Token(Token = "0x600001F")]
	public void Add(object content) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000022")]
	internal override void AddAttribute(XAttribute a) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000023")]
	internal override void AddAttributeSkipNotify(XAttribute a) { }

	[Address(RVA = "0x2408000", Offset = "0x2407400", Length = "0x32A")]
	[Token(Token = "0x6000024")]
	internal void AddContentSkipNotify(object content) { }

	[Address(RVA = "0x24083D0", Offset = "0x24077D0", Length = "0x97")]
	[Token(Token = "0x6000025")]
	internal void AddNode(XNode n) { }

	[Address(RVA = "0x2408330", Offset = "0x2407730", Length = "0x97")]
	[Token(Token = "0x6000026")]
	internal void AddNodeSkipNotify(XNode n) { }

	[Address(RVA = "0x2408620", Offset = "0x2407A20", Length = "0x3EC")]
	[Token(Token = "0x6000027")]
	internal void AddString(string s) { }

	[Address(RVA = "0x2408470", Offset = "0x2407870", Length = "0x1A4")]
	[Token(Token = "0x6000028")]
	internal void AddStringSkipNotify(string s) { }

	[Address(RVA = "0x2408EB0", Offset = "0x24082B0", Length = "0x121")]
	[Token(Token = "0x6000029")]
	internal void AppendNode(XNode n) { }

	[Address(RVA = "0x2408DC0", Offset = "0x24081C0", Length = "0xEF")]
	[Token(Token = "0x600002A")]
	internal void AppendNodeSkipNotify(XNode n) { }

	[Address(RVA = "0x2408FE0", Offset = "0x24083E0", Length = "0xE5")]
	[Token(Token = "0x600002B")]
	internal virtual void AppendText(StringBuilder sb) { }

	[Address(RVA = "0x24090D0", Offset = "0x24084D0", Length = "0x10B")]
	[Token(Token = "0x600002C")]
	internal void ConvertTextToNode() { }

	[Address(RVA = "0x240A460", Offset = "0x2409860", Length = "0x166")]
	[Token(Token = "0x600001E")]
	public XNode get_LastNode() { }

	[Address(RVA = "0x24091E0", Offset = "0x24085E0", Length = "0x436")]
	[Token(Token = "0x600002D")]
	internal static string GetStringValue(object value) { }

	[Address(RVA = "0x2409620", Offset = "0x2408A20", Length = "0x71")]
	[IteratorStateMachine(typeof(<Nodes>d__18))]
	[Token(Token = "0x6000020")]
	public IEnumerable<XNode> Nodes() { }

	[Address(RVA = "0x24096A0", Offset = "0x2408AA0", Length = "0x10D")]
	[Token(Token = "0x600002E")]
	internal void ReadContentFrom(XmlReader r) { }

	[Address(RVA = "0x24097B0", Offset = "0x2408BB0", Length = "0x2AF")]
	[Token(Token = "0x600002F")]
	internal void ReadContentFrom(XmlReader r, LoadOptions o) { }

	[Address(RVA = "0x2409A60", Offset = "0x2408E60", Length = "0x20A")]
	[Token(Token = "0x6000030")]
	internal void RemoveNode(XNode n) { }

	[Address(RVA = "0x2409D50", Offset = "0x2409150", Length = "0x441")]
	[Token(Token = "0x6000021")]
	public void RemoveNodes() { }

	[Address(RVA = "0x2409C70", Offset = "0x2409070", Length = "0xD8")]
	[Token(Token = "0x6000031")]
	private void RemoveNodesSkipNotify() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000032")]
	internal override void ValidateNode(XNode node, XNode previous) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000033")]
	internal override void ValidateString(string s) { }

	[Address(RVA = "0x240A1A0", Offset = "0x24095A0", Length = "0x159")]
	[Token(Token = "0x6000034")]
	internal void WriteContentTo(XmlWriter writer) { }

}

