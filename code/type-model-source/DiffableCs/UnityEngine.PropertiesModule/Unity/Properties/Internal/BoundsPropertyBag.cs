namespace Unity.Properties.Internal;

[Token(Token = "0x2000092")]
internal class BoundsPropertyBag : ContainerPropertyBag<Bounds>
{
	[Token(Token = "0x2000093")]
	private class CenterProperty : Property<Bounds, Vector3>
	{

		[Token(Token = "0x17000086")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x60002F7")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000085")]
		public virtual string Name
		{
			[Address(RVA = "0x31418A0", Offset = "0x3140CA0", Length = "0x2C")]
			[Token(Token = "0x60002F6")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3141860", Offset = "0x3140C60", Length = "0x39")]
		[Token(Token = "0x60002FA")]
		public CenterProperty() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x60002F7")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x31418A0", Offset = "0x3140CA0", Length = "0x2C")]
		[Token(Token = "0x60002F6")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1BBE240", Offset = "0x1BBD640", Length = "0x14")]
		[Token(Token = "0x60002F8")]
		public virtual Vector3 GetValue(ref Bounds container) { }

		[Address(RVA = "0x3141840", Offset = "0x3140C40", Length = "0x11")]
		[Token(Token = "0x60002F9")]
		public virtual void SetValue(ref Bounds container, Vector3 value) { }

	}

	[Token(Token = "0x2000094")]
	private class ExtentsProperty : Property<Bounds, Vector3>
	{

		[Token(Token = "0x17000088")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x60002FC")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000087")]
		public virtual string Name
		{
			[Address(RVA = "0x3142030", Offset = "0x3141430", Length = "0x2C")]
			[Token(Token = "0x60002FB")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3141FF0", Offset = "0x31413F0", Length = "0x39")]
		[Token(Token = "0x60002FF")]
		public ExtentsProperty() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x60002FC")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x3142030", Offset = "0x3141430", Length = "0x2C")]
		[Token(Token = "0x60002FB")]
		public virtual string get_Name() { }

		[Address(RVA = "0x3141FB0", Offset = "0x31413B0", Length = "0x15")]
		[Token(Token = "0x60002FD")]
		public virtual Vector3 GetValue(ref Bounds container) { }

		[Address(RVA = "0x3141FD0", Offset = "0x31413D0", Length = "0x12")]
		[Token(Token = "0x60002FE")]
		public virtual void SetValue(ref Bounds container, Vector3 value) { }

	}


	[Address(RVA = "0x3141640", Offset = "0x3140A40", Length = "0x11F")]
	[Token(Token = "0x60002F5")]
	public BoundsPropertyBag() { }

}

