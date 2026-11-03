namespace Unity.Properties.Internal;

[Token(Token = "0x2000095")]
internal class BoundsIntPropertyBag : ContainerPropertyBag<BoundsInt>
{
	[Token(Token = "0x2000096")]
	private class PositionProperty : Property<BoundsInt, Vector3Int>
	{

		[Token(Token = "0x1700008A")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x6000302")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000089")]
		public virtual string Name
		{
			[Address(RVA = "0x3142BF0", Offset = "0x3141FF0", Length = "0x2C")]
			[Token(Token = "0x6000301")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3142BB0", Offset = "0x3141FB0", Length = "0x39")]
		[Token(Token = "0x6000305")]
		public PositionProperty() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6000302")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x3142BF0", Offset = "0x3141FF0", Length = "0x2C")]
		[Token(Token = "0x6000301")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1BBE240", Offset = "0x1BBD640", Length = "0x14")]
		[Token(Token = "0x6000303")]
		public virtual Vector3Int GetValue(ref BoundsInt container) { }

		[Address(RVA = "0x3141840", Offset = "0x3140C40", Length = "0x11")]
		[Token(Token = "0x6000304")]
		public virtual void SetValue(ref BoundsInt container, Vector3Int value) { }

	}

	[Token(Token = "0x2000097")]
	private class SizeProperty : Property<BoundsInt, Vector3Int>
	{

		[Token(Token = "0x1700008C")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x6000307")]
			 get { } //Length: 3
		}

		[Token(Token = "0x1700008B")]
		public virtual string Name
		{
			[Address(RVA = "0x31609C0", Offset = "0x315FDC0", Length = "0x2C")]
			[Token(Token = "0x6000306")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3160980", Offset = "0x315FD80", Length = "0x39")]
		[Token(Token = "0x600030A")]
		public SizeProperty() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6000307")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x31609C0", Offset = "0x315FDC0", Length = "0x2C")]
		[Token(Token = "0x6000306")]
		public virtual string get_Name() { }

		[Address(RVA = "0x3141FB0", Offset = "0x31413B0", Length = "0x15")]
		[Token(Token = "0x6000308")]
		public virtual Vector3Int GetValue(ref BoundsInt container) { }

		[Address(RVA = "0x3141FD0", Offset = "0x31413D0", Length = "0x12")]
		[Token(Token = "0x6000309")]
		public virtual void SetValue(ref BoundsInt container, Vector3Int value) { }

	}


	[Address(RVA = "0x3141520", Offset = "0x3140920", Length = "0x11F")]
	[Token(Token = "0x6000300")]
	public BoundsIntPropertyBag() { }

}

