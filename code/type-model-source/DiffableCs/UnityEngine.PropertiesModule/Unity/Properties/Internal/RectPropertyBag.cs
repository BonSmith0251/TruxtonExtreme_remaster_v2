namespace Unity.Properties.Internal;

[Token(Token = "0x2000088")]
internal class RectPropertyBag : ContainerPropertyBag<Rect>
{
	[Token(Token = "0x200008C")]
	private class HeightProperty : Property<Rect, Single>
	{

		[Token(Token = "0x1700007C")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x60002DC")]
			 get { } //Length: 3
		}

		[Token(Token = "0x1700007B")]
		public virtual string Name
		{
			[Address(RVA = "0x3142700", Offset = "0x3141B00", Length = "0x2C")]
			[Token(Token = "0x60002DB")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3142650", Offset = "0x3141A50", Length = "0x39")]
		[Token(Token = "0x60002DF")]
		public HeightProperty() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x60002DC")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x3142700", Offset = "0x3141B00", Length = "0x2C")]
		[Token(Token = "0x60002DB")]
		public virtual string get_Name() { }

		[Address(RVA = "0x3142550", Offset = "0x3141950", Length = "0x45")]
		[Token(Token = "0x60002DD")]
		public virtual float GetValue(ref Rect container) { }

		[Address(RVA = "0x31425A0", Offset = "0x31419A0", Length = "0x52")]
		[Token(Token = "0x60002DE")]
		public virtual void SetValue(ref Rect container, float value) { }

	}

	[Token(Token = "0x200008B")]
	private class WidthProperty : Property<Rect, Single>
	{

		[Token(Token = "0x1700007A")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x60002D7")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000079")]
		public virtual string Name
		{
			[Address(RVA = "0x3165210", Offset = "0x3164610", Length = "0x2C")]
			[Token(Token = "0x60002D6")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x31651D0", Offset = "0x31645D0", Length = "0x39")]
		[Token(Token = "0x60002DA")]
		public WidthProperty() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x60002D7")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x3165210", Offset = "0x3164610", Length = "0x2C")]
		[Token(Token = "0x60002D6")]
		public virtual string get_Name() { }

		[Address(RVA = "0x3165040", Offset = "0x3164440", Length = "0x45")]
		[Token(Token = "0x60002D8")]
		public virtual float GetValue(ref Rect container) { }

		[Address(RVA = "0x31650E0", Offset = "0x31644E0", Length = "0x52")]
		[Token(Token = "0x60002D9")]
		public virtual void SetValue(ref Rect container, float value) { }

	}

	[Token(Token = "0x2000089")]
	private class XProperty : Property<Rect, Single>
	{

		[Token(Token = "0x17000076")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x60002CD")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000075")]
		public virtual string Name
		{
			[Address(RVA = "0x3165620", Offset = "0x3164A20", Length = "0x2C")]
			[Token(Token = "0x60002CC")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x31654D0", Offset = "0x31648D0", Length = "0x39")]
		[Token(Token = "0x60002D0")]
		public XProperty() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x60002CD")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x3165620", Offset = "0x3164A20", Length = "0x2C")]
		[Token(Token = "0x60002CC")]
		public virtual string get_Name() { }

		[Address(RVA = "0x3165270", Offset = "0x3164670", Length = "0x44")]
		[Token(Token = "0x60002CE")]
		public virtual float GetValue(ref Rect container) { }

		[Address(RVA = "0x3165370", Offset = "0x3164770", Length = "0x51")]
		[Token(Token = "0x60002CF")]
		public virtual void SetValue(ref Rect container, float value) { }

	}

	[Token(Token = "0x200008A")]
	private class YProperty : Property<Rect, Single>
	{

		[Token(Token = "0x17000078")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x60002D2")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000077")]
		public virtual string Name
		{
			[Address(RVA = "0x3165AD0", Offset = "0x3164ED0", Length = "0x2C")]
			[Token(Token = "0x60002D1")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3165850", Offset = "0x3164C50", Length = "0x39")]
		[Token(Token = "0x60002D5")]
		public YProperty() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x60002D2")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x3165AD0", Offset = "0x3164ED0", Length = "0x2C")]
		[Token(Token = "0x60002D1")]
		public virtual string get_Name() { }

		[Address(RVA = "0x31656F0", Offset = "0x3164AF0", Length = "0x45")]
		[Token(Token = "0x60002D3")]
		public virtual float GetValue(ref Rect container) { }

		[Address(RVA = "0x3165790", Offset = "0x3164B90", Length = "0x52")]
		[Token(Token = "0x60002D4")]
		public virtual void SetValue(ref Rect container, float value) { }

	}


	[Address(RVA = "0x315FD80", Offset = "0x315F180", Length = "0x1CF")]
	[Token(Token = "0x60002CB")]
	public RectPropertyBag() { }

}

