namespace Unity.Properties.Internal;

[Token(Token = "0x2000098")]
internal class SystemVersionPropertyBag : ContainerPropertyBag<Version>
{
	[Token(Token = "0x200009B")]
	private class BuildProperty : Property<Version, Int32>
	{

		[Token(Token = "0x17000092")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
			[Token(Token = "0x6000318")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000091")]
		public virtual string Name
		{
			[Address(RVA = "0x3141810", Offset = "0x3140C10", Length = "0x2C")]
			[Token(Token = "0x6000317")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3141780", Offset = "0x3140B80", Length = "0x89")]
		[Token(Token = "0x6000316")]
		public BuildProperty() { }

		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6000318")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x3141810", Offset = "0x3140C10", Length = "0x2C")]
		[Token(Token = "0x6000317")]
		public virtual string get_Name() { }

		[Address(RVA = "0x3141760", Offset = "0x3140B60", Length = "0x19")]
		[Token(Token = "0x6000319")]
		public virtual int GetValue(ref Version container) { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x600031A")]
		public virtual void SetValue(ref Version container, int value) { }

	}

	[Token(Token = "0x2000099")]
	private class MajorProperty : Property<Version, Int32>
	{

		[Token(Token = "0x1700008E")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
			[Token(Token = "0x600030E")]
			 get { } //Length: 3
		}

		[Token(Token = "0x1700008D")]
		public virtual string Name
		{
			[Address(RVA = "0x31427E0", Offset = "0x3141BE0", Length = "0x2C")]
			[Token(Token = "0x600030D")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3142750", Offset = "0x3141B50", Length = "0x89")]
		[Token(Token = "0x600030C")]
		public MajorProperty() { }

		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x600030E")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x31427E0", Offset = "0x3141BE0", Length = "0x2C")]
		[Token(Token = "0x600030D")]
		public virtual string get_Name() { }

		[Address(RVA = "0x3142730", Offset = "0x3141B30", Length = "0x19")]
		[Token(Token = "0x600030F")]
		public virtual int GetValue(ref Version container) { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x6000310")]
		public virtual void SetValue(ref Version container, int value) { }

	}

	[Token(Token = "0x200009A")]
	private class MinorProperty : Property<Version, Int32>
	{

		[Token(Token = "0x17000090")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
			[Token(Token = "0x6000313")]
			 get { } //Length: 3
		}

		[Token(Token = "0x1700008F")]
		public virtual string Name
		{
			[Address(RVA = "0x31428C0", Offset = "0x3141CC0", Length = "0x2C")]
			[Token(Token = "0x6000312")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3142830", Offset = "0x3141C30", Length = "0x89")]
		[Token(Token = "0x6000311")]
		public MinorProperty() { }

		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6000313")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x31428C0", Offset = "0x3141CC0", Length = "0x2C")]
		[Token(Token = "0x6000312")]
		public virtual string get_Name() { }

		[Address(RVA = "0x3142810", Offset = "0x3141C10", Length = "0x19")]
		[Token(Token = "0x6000314")]
		public virtual int GetValue(ref Version container) { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x6000315")]
		public virtual void SetValue(ref Version container, int value) { }

	}

	[Token(Token = "0x200009C")]
	private class RevisionProperty : Property<Version, Int32>
	{

		[Token(Token = "0x17000094")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
			[Token(Token = "0x600031D")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000093")]
		public virtual string Name
		{
			[Address(RVA = "0x3160950", Offset = "0x315FD50", Length = "0x2C")]
			[Token(Token = "0x600031C")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x31608C0", Offset = "0x315FCC0", Length = "0x89")]
		[Token(Token = "0x600031B")]
		public RevisionProperty() { }

		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x600031D")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x3160950", Offset = "0x315FD50", Length = "0x2C")]
		[Token(Token = "0x600031C")]
		public virtual string get_Name() { }

		[Address(RVA = "0x31608A0", Offset = "0x315FCA0", Length = "0x19")]
		[Token(Token = "0x600031E")]
		public virtual int GetValue(ref Version container) { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x600031F")]
		public virtual void SetValue(ref Version container, int value) { }

	}


	[Address(RVA = "0x31609F0", Offset = "0x315FDF0", Length = "0x2F5")]
	[Token(Token = "0x600030B")]
	public SystemVersionPropertyBag() { }

}

