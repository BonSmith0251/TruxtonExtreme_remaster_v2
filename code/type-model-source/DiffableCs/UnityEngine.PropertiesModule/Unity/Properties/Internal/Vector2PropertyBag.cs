namespace Unity.Properties.Internal;

[Token(Token = "0x2000075")]
internal class Vector2PropertyBag : ContainerPropertyBag<Vector2>
{
	[Token(Token = "0x2000076")]
	private class XProperty : Property<Vector2, Single>
	{

		[Token(Token = "0x1700005A")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x6000282")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000059")]
		public virtual string Name
		{
			[Address(RVA = "0x3165590", Offset = "0x3164990", Length = "0x2C")]
			[Token(Token = "0x6000281")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x31653D0", Offset = "0x31647D0", Length = "0x39")]
		[Token(Token = "0x6000285")]
		public XProperty() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6000282")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x3165590", Offset = "0x3164990", Length = "0x2C")]
		[Token(Token = "0x6000281")]
		public virtual string get_Name() { }

		[Address(RVA = "0xA502C0", Offset = "0xA4F6C0", Length = "0x5")]
		[Token(Token = "0x6000283")]
		public virtual float GetValue(ref Vector2 container) { }

		[Address(RVA = "0x315FB30", Offset = "0x315EF30", Length = "0x5")]
		[Token(Token = "0x6000284")]
		public virtual void SetValue(ref Vector2 container, float value) { }

	}

	[Token(Token = "0x2000077")]
	private class YProperty : Property<Vector2, Single>
	{

		[Token(Token = "0x1700005C")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x6000287")]
			 get { } //Length: 3
		}

		[Token(Token = "0x1700005B")]
		public virtual string Name
		{
			[Address(RVA = "0x3165B00", Offset = "0x3164F00", Length = "0x2C")]
			[Token(Token = "0x6000286")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3165990", Offset = "0x3164D90", Length = "0x39")]
		[Token(Token = "0x600028A")]
		public YProperty() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6000287")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x3165B00", Offset = "0x3164F00", Length = "0x2C")]
		[Token(Token = "0x6000286")]
		public virtual string get_Name() { }

		[Address(RVA = "0x3142140", Offset = "0x3141540", Length = "0x6")]
		[Token(Token = "0x6000288")]
		public virtual float GetValue(ref Vector2 container) { }

		[Address(RVA = "0x3142150", Offset = "0x3141550", Length = "0x6")]
		[Token(Token = "0x6000289")]
		public virtual void SetValue(ref Vector2 container, float value) { }

	}


	[Address(RVA = "0x31649E0", Offset = "0x3163DE0", Length = "0x11F")]
	[Token(Token = "0x6000280")]
	public Vector2PropertyBag() { }

}

