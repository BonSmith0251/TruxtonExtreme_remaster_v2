namespace Unity.Properties.Internal;

[Token(Token = "0x2000078")]
internal class Vector3PropertyBag : ContainerPropertyBag<Vector3>
{
	[Token(Token = "0x2000079")]
	private class XProperty : Property<Vector3, Single>
	{

		[Token(Token = "0x1700005E")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x600028D")]
			 get { } //Length: 3
		}

		[Token(Token = "0x1700005D")]
		public virtual string Name
		{
			[Address(RVA = "0x3165650", Offset = "0x3164A50", Length = "0x2C")]
			[Token(Token = "0x600028C")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3165410", Offset = "0x3164810", Length = "0x39")]
		[Token(Token = "0x6000290")]
		public XProperty() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x600028D")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x3165650", Offset = "0x3164A50", Length = "0x2C")]
		[Token(Token = "0x600028C")]
		public virtual string get_Name() { }

		[Address(RVA = "0xA502C0", Offset = "0xA4F6C0", Length = "0x5")]
		[Token(Token = "0x600028E")]
		public virtual float GetValue(ref Vector3 container) { }

		[Address(RVA = "0x315FB30", Offset = "0x315EF30", Length = "0x5")]
		[Token(Token = "0x600028F")]
		public virtual void SetValue(ref Vector3 container, float value) { }

	}

	[Token(Token = "0x200007A")]
	private class YProperty : Property<Vector3, Single>
	{

		[Token(Token = "0x17000060")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x6000292")]
			 get { } //Length: 3
		}

		[Token(Token = "0x1700005F")]
		public virtual string Name
		{
			[Address(RVA = "0x3165B30", Offset = "0x3164F30", Length = "0x2C")]
			[Token(Token = "0x6000291")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3165910", Offset = "0x3164D10", Length = "0x39")]
		[Token(Token = "0x6000295")]
		public YProperty() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6000292")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x3165B30", Offset = "0x3164F30", Length = "0x2C")]
		[Token(Token = "0x6000291")]
		public virtual string get_Name() { }

		[Address(RVA = "0x3142140", Offset = "0x3141540", Length = "0x6")]
		[Token(Token = "0x6000293")]
		public virtual float GetValue(ref Vector3 container) { }

		[Address(RVA = "0x3142150", Offset = "0x3141550", Length = "0x6")]
		[Token(Token = "0x6000294")]
		public virtual void SetValue(ref Vector3 container, float value) { }

	}

	[Token(Token = "0x200007B")]
	private class ZProperty : Property<Vector3, Single>
	{

		[Token(Token = "0x17000062")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x6000297")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000061")]
		public virtual string Name
		{
			[Address(RVA = "0x3165C70", Offset = "0x3165070", Length = "0x2C")]
			[Token(Token = "0x6000296")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3165C00", Offset = "0x3165000", Length = "0x39")]
		[Token(Token = "0x600029A")]
		public ZProperty() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6000297")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x3165C70", Offset = "0x3165070", Length = "0x2C")]
		[Token(Token = "0x6000296")]
		public virtual string get_Name() { }

		[Address(RVA = "0x3141490", Offset = "0x3140890", Length = "0x6")]
		[Token(Token = "0x6000298")]
		public virtual float GetValue(ref Vector3 container) { }

		[Address(RVA = "0x31414A0", Offset = "0x31408A0", Length = "0x6")]
		[Token(Token = "0x6000299")]
		public virtual void SetValue(ref Vector3 container, float value) { }

	}


	[Address(RVA = "0x3164C80", Offset = "0x3164080", Length = "0x177")]
	[Token(Token = "0x600028B")]
	public Vector3PropertyBag() { }

}

