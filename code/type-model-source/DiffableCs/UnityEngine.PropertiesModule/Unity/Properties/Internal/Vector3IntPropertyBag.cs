namespace Unity.Properties.Internal;

[Token(Token = "0x2000084")]
internal class Vector3IntPropertyBag : ContainerPropertyBag<Vector3Int>
{
	[Token(Token = "0x2000085")]
	private class XProperty : Property<Vector3Int, Int32>
	{

		[Token(Token = "0x17000070")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x60002BD")]
			 get { } //Length: 3
		}

		[Token(Token = "0x1700006F")]
		public virtual string Name
		{
			[Address(RVA = "0x31655F0", Offset = "0x31649F0", Length = "0x2C")]
			[Token(Token = "0x60002BC")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3165490", Offset = "0x3164890", Length = "0x39")]
		[Token(Token = "0x60002C0")]
		public XProperty() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x60002BD")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x31655F0", Offset = "0x31649F0", Length = "0x2C")]
		[Token(Token = "0x60002BC")]
		public virtual string get_Name() { }

		[Address(RVA = "0x17D3A70", Offset = "0x17D2E70", Length = "0x3")]
		[Token(Token = "0x60002BE")]
		public virtual int GetValue(ref Vector3Int container) { }

		[Address(RVA = "0x3165310", Offset = "0x3164710", Length = "0x4")]
		[Token(Token = "0x60002BF")]
		public virtual void SetValue(ref Vector3Int container, int value) { }

	}

	[Token(Token = "0x2000086")]
	private class YProperty : Property<Vector3Int, Int32>
	{

		[Token(Token = "0x17000072")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x60002C2")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000071")]
		public virtual string Name
		{
			[Address(RVA = "0x3165AA0", Offset = "0x3164EA0", Length = "0x2C")]
			[Token(Token = "0x60002C1")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3165890", Offset = "0x3164C90", Length = "0x39")]
		[Token(Token = "0x60002C5")]
		public YProperty() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x60002C2")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x3165AA0", Offset = "0x3164EA0", Length = "0x2C")]
		[Token(Token = "0x60002C1")]
		public virtual string get_Name() { }

		[Address(RVA = "0x31656E0", Offset = "0x3164AE0", Length = "0x4")]
		[Token(Token = "0x60002C3")]
		public virtual int GetValue(ref Vector3Int container) { }

		[Address(RVA = "0x3165840", Offset = "0x3164C40", Length = "0x5")]
		[Token(Token = "0x60002C4")]
		public virtual void SetValue(ref Vector3Int container, int value) { }

	}

	[Token(Token = "0x2000087")]
	private class ZProperty : Property<Vector3Int, Int32>
	{

		[Token(Token = "0x17000074")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x60002C7")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000073")]
		public virtual string Name
		{
			[Address(RVA = "0x3165C40", Offset = "0x3165040", Length = "0x2C")]
			[Token(Token = "0x60002C6")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3165BC0", Offset = "0x3164FC0", Length = "0x39")]
		[Token(Token = "0x60002CA")]
		public ZProperty() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x60002C7")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x3165C40", Offset = "0x3165040", Length = "0x2C")]
		[Token(Token = "0x60002C6")]
		public virtual string get_Name() { }

		[Address(RVA = "0x3165B60", Offset = "0x3164F60", Length = "0x4")]
		[Token(Token = "0x60002C8")]
		public virtual int GetValue(ref Vector3Int container) { }

		[Address(RVA = "0x3165B70", Offset = "0x3164F70", Length = "0x5")]
		[Token(Token = "0x60002C9")]
		public virtual void SetValue(ref Vector3Int container, int value) { }

	}


	[Address(RVA = "0x3164B00", Offset = "0x3163F00", Length = "0x177")]
	[Token(Token = "0x60002BB")]
	public Vector3IntPropertyBag() { }

}

