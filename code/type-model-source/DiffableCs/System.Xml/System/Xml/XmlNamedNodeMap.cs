namespace System.Xml;

[Token(Token = "0x20000A1")]
public class XmlNamedNodeMap : IEnumerable
{
	[DefaultMember("Item")]
	[Token(Token = "0x20000A2")]
	public struct SmallXmlNodeList
	{
		[Token(Token = "0x20000A3")]
		private class SingleObjectEnumerator : IEnumerator
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x4000485")]
			private object loneValue; //Field offset: 0x10
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4000486")]
			private int position; //Field offset: 0x18

			[Token(Token = "0x17000252")]
			public override object Current
			{
				[Address(RVA = "0x2536CF0", Offset = "0x25360F0", Length = "0x55")]
				[Token(Token = "0x60008E1")]
				 get { } //Length: 85
			}

			[Address(RVA = "0x2536CB0", Offset = "0x25360B0", Length = "0x38")]
			[Token(Token = "0x60008E0")]
			public SingleObjectEnumerator(object value) { }

			[Address(RVA = "0x2536CF0", Offset = "0x25360F0", Length = "0x55")]
			[Token(Token = "0x60008E1")]
			public override object get_Current() { }

			[Address(RVA = "0x2536C90", Offset = "0x2536090", Length = "0x1A")]
			[Token(Token = "0x60008E2")]
			public override bool MoveNext() { }

			[Address(RVA = "0x195A120", Offset = "0x1959520", Length = "0x8")]
			[Token(Token = "0x60008E3")]
			public override void Reset() { }

		}

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000484")]
		private object field; //Field offset: 0x0

		[Token(Token = "0x17000250")]
		public int Count
		{
			[Address(RVA = "0x25372E0", Offset = "0x25366E0", Length = "0x83")]
			[Token(Token = "0x60008DA")]
			 get { } //Length: 131
		}

		[Token(Token = "0x17000251")]
		public object Item
		{
			[Address(RVA = "0x2537370", Offset = "0x2536770", Length = "0x120")]
			[Token(Token = "0x60008DB")]
			 get { } //Length: 288
		}

		[Address(RVA = "0x2536D50", Offset = "0x2536150", Length = "0x143")]
		[Token(Token = "0x60008DC")]
		public void Add(object value) { }

		[Address(RVA = "0x25372E0", Offset = "0x25366E0", Length = "0x83")]
		[Token(Token = "0x60008DA")]
		public int get_Count() { }

		[Address(RVA = "0x2537370", Offset = "0x2536770", Length = "0x120")]
		[Token(Token = "0x60008DB")]
		public object get_Item(int index) { }

		[Address(RVA = "0x2536EA0", Offset = "0x25362A0", Length = "0x101")]
		[Token(Token = "0x60008DF")]
		public IEnumerator GetEnumerator() { }

		[Address(RVA = "0x2536FB0", Offset = "0x25363B0", Length = "0x1FD")]
		[Token(Token = "0x60008DE")]
		public void Insert(int index, object value) { }

		[Address(RVA = "0x25371B0", Offset = "0x25365B0", Length = "0x12D")]
		[Token(Token = "0x60008DD")]
		public void RemoveAt(int index) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000482")]
	internal XmlNode parent; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000483")]
	internal SmallXmlNodeList nodes; //Field offset: 0x18

	[Token(Token = "0x1700024F")]
	public override int Count
	{
		[Address(RVA = "0x2538990", Offset = "0x2537D90", Length = "0xB")]
		[Token(Token = "0x60008D1")]
		 get { } //Length: 11
	}

	[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
	[Token(Token = "0x60008CE")]
	internal XmlNamedNodeMap(XmlNode parent) { }

	[Address(RVA = "0x2537E90", Offset = "0x2537290", Length = "0x19E")]
	[Token(Token = "0x60008D5")]
	internal override XmlNode AddNode(XmlNode node) { }

	[Address(RVA = "0x2537DC0", Offset = "0x25371C0", Length = "0xC0")]
	[Token(Token = "0x60008D6")]
	internal override XmlNode AddNodeForLoad(XmlNode node, XmlDocument doc) { }

	[Address(RVA = "0x2538030", Offset = "0x2537430", Length = "0xF6")]
	[Token(Token = "0x60008D3")]
	internal int FindNodeOffset(string name) { }

	[Address(RVA = "0x2538130", Offset = "0x2537530", Length = "0x132")]
	[Token(Token = "0x60008D4")]
	internal int FindNodeOffset(string localName, string namespaceURI) { }

	[Address(RVA = "0x2538990", Offset = "0x2537D90", Length = "0xB")]
	[Token(Token = "0x60008D1")]
	public override int get_Count() { }

	[Address(RVA = "0x2538270", Offset = "0x2537670", Length = "0xB")]
	[Token(Token = "0x60008D2")]
	public override IEnumerator GetEnumerator() { }

	[Address(RVA = "0x2538280", Offset = "0x2537680", Length = "0x175")]
	[Token(Token = "0x60008CF")]
	public override XmlNode GetNamedItem(string name) { }

	[Address(RVA = "0x2538400", Offset = "0x2537800", Length = "0x1AC")]
	[Token(Token = "0x60008D9")]
	internal override XmlNode InsertNodeAt(int i, XmlNode node) { }

	[Address(RVA = "0x25385B0", Offset = "0x25379B0", Length = "0x171")]
	[Token(Token = "0x60008D7")]
	internal override XmlNode RemoveNodeAt(int i) { }

	[Address(RVA = "0x2538730", Offset = "0x2537B30", Length = "0x68")]
	[Token(Token = "0x60008D8")]
	internal XmlNode ReplaceNodeAt(int i, XmlNode node) { }

	[Address(RVA = "0x25387A0", Offset = "0x2537BA0", Length = "0x1EE")]
	[Token(Token = "0x60008D0")]
	public override XmlNode SetNamedItem(XmlNode node) { }

}

