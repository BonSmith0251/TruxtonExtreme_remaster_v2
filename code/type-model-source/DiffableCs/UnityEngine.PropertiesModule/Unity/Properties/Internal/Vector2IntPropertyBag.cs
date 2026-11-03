namespace Unity.Properties.Internal;

[Token(Token = "0x2000081")]
internal class Vector2IntPropertyBag : ContainerPropertyBag<Vector2Int>
{
	[Token(Token = "0x2000082")]
	private class XProperty : Property<Vector2Int, Int32>
	{

		[Token(Token = "0x1700006C")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x60002B2")]
			 get { } //Length: 3
		}

		[Token(Token = "0x1700006B")]
		public virtual string Name
		{
			[Address(RVA = "0x3165680", Offset = "0x3164A80", Length = "0x2C")]
			[Token(Token = "0x60002B1")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3165450", Offset = "0x3164850", Length = "0x39")]
		[Token(Token = "0x60002B5")]
		public XProperty() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x60002B2")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x3165680", Offset = "0x3164A80", Length = "0x2C")]
		[Token(Token = "0x60002B1")]
		public virtual string get_Name() { }

		[Address(RVA = "0x17D3A70", Offset = "0x17D2E70", Length = "0x3")]
		[Token(Token = "0x60002B3")]
		public virtual int GetValue(ref Vector2Int container) { }

		[Address(RVA = "0x3165310", Offset = "0x3164710", Length = "0x4")]
		[Token(Token = "0x60002B4")]
		public virtual void SetValue(ref Vector2Int container, int value) { }

	}

	[Token(Token = "0x2000083")]
	private class YProperty : Property<Vector2Int, Int32>
	{

		[Token(Token = "0x1700006E")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x60002B7")]
			 get { } //Length: 3
		}

		[Token(Token = "0x1700006D")]
		public virtual string Name
		{
			[Address(RVA = "0x3165A40", Offset = "0x3164E40", Length = "0x2C")]
			[Token(Token = "0x60002B6")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x31659D0", Offset = "0x3164DD0", Length = "0x39")]
		[Token(Token = "0x60002BA")]
		public YProperty() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x60002B7")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x3165A40", Offset = "0x3164E40", Length = "0x2C")]
		[Token(Token = "0x60002B6")]
		public virtual string get_Name() { }

		[Address(RVA = "0x31656E0", Offset = "0x3164AE0", Length = "0x4")]
		[Token(Token = "0x60002B8")]
		public virtual int GetValue(ref Vector2Int container) { }

		[Address(RVA = "0x3165840", Offset = "0x3164C40", Length = "0x5")]
		[Token(Token = "0x60002B9")]
		public virtual void SetValue(ref Vector2Int container, int value) { }

	}


	[Address(RVA = "0x31648C0", Offset = "0x3163CC0", Length = "0x11F")]
	[Token(Token = "0x60002B0")]
	public Vector2IntPropertyBag() { }

}

