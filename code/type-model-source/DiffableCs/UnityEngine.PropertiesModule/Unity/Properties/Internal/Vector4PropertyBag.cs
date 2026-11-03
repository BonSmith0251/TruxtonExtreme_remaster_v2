namespace Unity.Properties.Internal;

[Token(Token = "0x200007C")]
internal class Vector4PropertyBag : ContainerPropertyBag<Vector4>
{
	[Token(Token = "0x2000080")]
	private class WProperty : Property<Vector4, Single>
	{

		[Token(Token = "0x1700006A")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x60002AC")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000069")]
		public virtual string Name
		{
			[Address(RVA = "0x3165010", Offset = "0x3164410", Length = "0x2C")]
			[Token(Token = "0x60002AB")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3164FD0", Offset = "0x31643D0", Length = "0x39")]
		[Token(Token = "0x60002AF")]
		public WProperty() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x60002AC")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x3165010", Offset = "0x3164410", Length = "0x2C")]
		[Token(Token = "0x60002AB")]
		public virtual string get_Name() { }

		[Address(RVA = "0x3141210", Offset = "0x3140610", Length = "0x6")]
		[Token(Token = "0x60002AD")]
		public virtual float GetValue(ref Vector4 container) { }

		[Address(RVA = "0x3141220", Offset = "0x3140620", Length = "0x6")]
		[Token(Token = "0x60002AE")]
		public virtual void SetValue(ref Vector4 container, float value) { }

	}

	[Token(Token = "0x200007D")]
	private class XProperty : Property<Vector4, Single>
	{

		[Token(Token = "0x17000064")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x600029D")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000063")]
		public virtual string Name
		{
			[Address(RVA = "0x31655C0", Offset = "0x31649C0", Length = "0x2C")]
			[Token(Token = "0x600029C")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3165510", Offset = "0x3164910", Length = "0x39")]
		[Token(Token = "0x60002A0")]
		public XProperty() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x600029D")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x31655C0", Offset = "0x31649C0", Length = "0x2C")]
		[Token(Token = "0x600029C")]
		public virtual string get_Name() { }

		[Address(RVA = "0xA502C0", Offset = "0xA4F6C0", Length = "0x5")]
		[Token(Token = "0x600029E")]
		public virtual float GetValue(ref Vector4 container) { }

		[Address(RVA = "0x315FB30", Offset = "0x315EF30", Length = "0x5")]
		[Token(Token = "0x600029F")]
		public virtual void SetValue(ref Vector4 container, float value) { }

	}

	[Token(Token = "0x200007E")]
	private class YProperty : Property<Vector4, Single>
	{

		[Token(Token = "0x17000066")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x60002A2")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000065")]
		public virtual string Name
		{
			[Address(RVA = "0x3165A10", Offset = "0x3164E10", Length = "0x2C")]
			[Token(Token = "0x60002A1")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x31658D0", Offset = "0x3164CD0", Length = "0x39")]
		[Token(Token = "0x60002A5")]
		public YProperty() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x60002A2")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x3165A10", Offset = "0x3164E10", Length = "0x2C")]
		[Token(Token = "0x60002A1")]
		public virtual string get_Name() { }

		[Address(RVA = "0x3142140", Offset = "0x3141540", Length = "0x6")]
		[Token(Token = "0x60002A3")]
		public virtual float GetValue(ref Vector4 container) { }

		[Address(RVA = "0x3142150", Offset = "0x3141550", Length = "0x6")]
		[Token(Token = "0x60002A4")]
		public virtual void SetValue(ref Vector4 container, float value) { }

	}

	[Token(Token = "0x200007F")]
	private class ZProperty : Property<Vector4, Single>
	{

		[Token(Token = "0x17000068")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x60002A7")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000067")]
		public virtual string Name
		{
			[Address(RVA = "0x3165CA0", Offset = "0x31650A0", Length = "0x2C")]
			[Token(Token = "0x60002A6")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3165B80", Offset = "0x3164F80", Length = "0x39")]
		[Token(Token = "0x60002AA")]
		public ZProperty() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x60002A7")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x3165CA0", Offset = "0x31650A0", Length = "0x2C")]
		[Token(Token = "0x60002A6")]
		public virtual string get_Name() { }

		[Address(RVA = "0x3141490", Offset = "0x3140890", Length = "0x6")]
		[Token(Token = "0x60002A8")]
		public virtual float GetValue(ref Vector4 container) { }

		[Address(RVA = "0x31414A0", Offset = "0x31408A0", Length = "0x6")]
		[Token(Token = "0x60002A9")]
		public virtual void SetValue(ref Vector4 container, float value) { }

	}


	[Address(RVA = "0x3164E00", Offset = "0x3164200", Length = "0x1CF")]
	[Token(Token = "0x600029B")]
	public Vector4PropertyBag() { }

}

