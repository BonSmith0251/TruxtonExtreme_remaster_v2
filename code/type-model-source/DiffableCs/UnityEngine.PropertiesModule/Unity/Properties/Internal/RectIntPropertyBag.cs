namespace Unity.Properties.Internal;

[Token(Token = "0x200008D")]
internal class RectIntPropertyBag : ContainerPropertyBag<RectInt>
{
	[Token(Token = "0x2000091")]
	private class HeightProperty : Property<RectInt, Int32>
	{

		[Token(Token = "0x17000084")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x60002F1")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000083")]
		public virtual string Name
		{
			[Address(RVA = "0x31426D0", Offset = "0x3141AD0", Length = "0x2C")]
			[Token(Token = "0x60002F0")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3142690", Offset = "0x3141A90", Length = "0x39")]
		[Token(Token = "0x60002F4")]
		public HeightProperty() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x60002F1")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x31426D0", Offset = "0x3141AD0", Length = "0x2C")]
		[Token(Token = "0x60002F0")]
		public virtual string get_Name() { }

		[Address(RVA = "0x3142500", Offset = "0x3141900", Length = "0x43")]
		[Token(Token = "0x60002F2")]
		public virtual int GetValue(ref RectInt container) { }

		[Address(RVA = "0x3142600", Offset = "0x3141A00", Length = "0x4F")]
		[Token(Token = "0x60002F3")]
		public virtual void SetValue(ref RectInt container, int value) { }

	}

	[Token(Token = "0x2000090")]
	private class WidthProperty : Property<RectInt, Int32>
	{

		[Token(Token = "0x17000082")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x60002EC")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000081")]
		public virtual string Name
		{
			[Address(RVA = "0x3165240", Offset = "0x3164640", Length = "0x2C")]
			[Token(Token = "0x60002EB")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3165190", Offset = "0x3164590", Length = "0x39")]
		[Token(Token = "0x60002EF")]
		public WidthProperty() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x60002EC")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x3165240", Offset = "0x3164640", Length = "0x2C")]
		[Token(Token = "0x60002EB")]
		public virtual string get_Name() { }

		[Address(RVA = "0x3165090", Offset = "0x3164490", Length = "0x43")]
		[Token(Token = "0x60002ED")]
		public virtual int GetValue(ref RectInt container) { }

		[Address(RVA = "0x3165140", Offset = "0x3164540", Length = "0x4F")]
		[Token(Token = "0x60002EE")]
		public virtual void SetValue(ref RectInt container, int value) { }

	}

	[Token(Token = "0x200008E")]
	private class XProperty : Property<RectInt, Int32>
	{

		[Token(Token = "0x1700007E")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x60002E2")]
			 get { } //Length: 3
		}

		[Token(Token = "0x1700007D")]
		public virtual string Name
		{
			[Address(RVA = "0x31656B0", Offset = "0x3164AB0", Length = "0x2C")]
			[Token(Token = "0x60002E1")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3165550", Offset = "0x3164950", Length = "0x39")]
		[Token(Token = "0x60002E5")]
		public XProperty() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x60002E2")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x31656B0", Offset = "0x3164AB0", Length = "0x2C")]
		[Token(Token = "0x60002E1")]
		public virtual string get_Name() { }

		[Address(RVA = "0x31652C0", Offset = "0x31646C0", Length = "0x42")]
		[Token(Token = "0x60002E3")]
		public virtual int GetValue(ref RectInt container) { }

		[Address(RVA = "0x3165320", Offset = "0x3164720", Length = "0x4E")]
		[Token(Token = "0x60002E4")]
		public virtual void SetValue(ref RectInt container, int value) { }

	}

	[Token(Token = "0x200008F")]
	private class YProperty : Property<RectInt, Int32>
	{

		[Token(Token = "0x17000080")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x60002E7")]
			 get { } //Length: 3
		}

		[Token(Token = "0x1700007F")]
		public virtual string Name
		{
			[Address(RVA = "0x3165A70", Offset = "0x3164E70", Length = "0x2C")]
			[Token(Token = "0x60002E6")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3165950", Offset = "0x3164D50", Length = "0x39")]
		[Token(Token = "0x60002EA")]
		public YProperty() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x60002E7")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x3165A70", Offset = "0x3164E70", Length = "0x2C")]
		[Token(Token = "0x60002E6")]
		public virtual string get_Name() { }

		[Address(RVA = "0x3165740", Offset = "0x3164B40", Length = "0x43")]
		[Token(Token = "0x60002E8")]
		public virtual int GetValue(ref RectInt container) { }

		[Address(RVA = "0x31657F0", Offset = "0x3164BF0", Length = "0x4F")]
		[Token(Token = "0x60002E9")]
		public virtual void SetValue(ref RectInt container, int value) { }

	}


	[Address(RVA = "0x315FBB0", Offset = "0x315EFB0", Length = "0x1CF")]
	[Token(Token = "0x60002E0")]
	public RectIntPropertyBag() { }

}

