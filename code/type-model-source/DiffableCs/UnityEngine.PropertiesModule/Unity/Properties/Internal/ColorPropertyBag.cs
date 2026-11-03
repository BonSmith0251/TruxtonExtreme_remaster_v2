namespace Unity.Properties.Internal;

[Token(Token = "0x2000070")]
internal class ColorPropertyBag : ContainerPropertyBag<Color>
{
	[Token(Token = "0x2000074")]
	private class AProperty : Property<Color, Single>
	{

		[Token(Token = "0x17000058")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x600027C")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000057")]
		public virtual string Name
		{
			[Address(RVA = "0x3141270", Offset = "0x3140670", Length = "0x2C")]
			[Token(Token = "0x600027B")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3141230", Offset = "0x3140630", Length = "0x39")]
		[Token(Token = "0x600027F")]
		public AProperty() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x600027C")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x3141270", Offset = "0x3140670", Length = "0x2C")]
		[Token(Token = "0x600027B")]
		public virtual string get_Name() { }

		[Address(RVA = "0x3141210", Offset = "0x3140610", Length = "0x6")]
		[Token(Token = "0x600027D")]
		public virtual float GetValue(ref Color container) { }

		[Address(RVA = "0x3141220", Offset = "0x3140620", Length = "0x6")]
		[Token(Token = "0x600027E")]
		public virtual void SetValue(ref Color container, float value) { }

	}

	[Token(Token = "0x2000073")]
	private class BProperty : Property<Color, Single>
	{

		[Token(Token = "0x17000056")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x6000277")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000055")]
		public virtual string Name
		{
			[Address(RVA = "0x31414F0", Offset = "0x31408F0", Length = "0x2C")]
			[Token(Token = "0x6000276")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x31414B0", Offset = "0x31408B0", Length = "0x39")]
		[Token(Token = "0x600027A")]
		public BProperty() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6000277")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x31414F0", Offset = "0x31408F0", Length = "0x2C")]
		[Token(Token = "0x6000276")]
		public virtual string get_Name() { }

		[Address(RVA = "0x3141490", Offset = "0x3140890", Length = "0x6")]
		[Token(Token = "0x6000278")]
		public virtual float GetValue(ref Color container) { }

		[Address(RVA = "0x31414A0", Offset = "0x31408A0", Length = "0x6")]
		[Token(Token = "0x6000279")]
		public virtual void SetValue(ref Color container, float value) { }

	}

	[Token(Token = "0x2000072")]
	private class GProperty : Property<Color, Single>
	{

		[Token(Token = "0x17000054")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x6000272")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000053")]
		public virtual string Name
		{
			[Address(RVA = "0x31421A0", Offset = "0x31415A0", Length = "0x2C")]
			[Token(Token = "0x6000271")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x3142160", Offset = "0x3141560", Length = "0x39")]
		[Token(Token = "0x6000275")]
		public GProperty() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6000272")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x31421A0", Offset = "0x31415A0", Length = "0x2C")]
		[Token(Token = "0x6000271")]
		public virtual string get_Name() { }

		[Address(RVA = "0x3142140", Offset = "0x3141540", Length = "0x6")]
		[Token(Token = "0x6000273")]
		public virtual float GetValue(ref Color container) { }

		[Address(RVA = "0x3142150", Offset = "0x3141550", Length = "0x6")]
		[Token(Token = "0x6000274")]
		public virtual void SetValue(ref Color container, float value) { }

	}

	[Token(Token = "0x2000071")]
	private class RProperty : Property<Color, Single>
	{

		[Token(Token = "0x17000052")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x600026D")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000051")]
		public virtual string Name
		{
			[Address(RVA = "0x315FB80", Offset = "0x315EF80", Length = "0x2C")]
			[Token(Token = "0x600026C")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x315FB40", Offset = "0x315EF40", Length = "0x39")]
		[Token(Token = "0x6000270")]
		public RProperty() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x600026D")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x315FB80", Offset = "0x315EF80", Length = "0x2C")]
		[Token(Token = "0x600026C")]
		public virtual string get_Name() { }

		[Address(RVA = "0xA502C0", Offset = "0xA4F6C0", Length = "0x5")]
		[Token(Token = "0x600026E")]
		public virtual float GetValue(ref Color container) { }

		[Address(RVA = "0x315FB30", Offset = "0x315EF30", Length = "0x5")]
		[Token(Token = "0x600026F")]
		public virtual void SetValue(ref Color container, float value) { }

	}


	[Address(RVA = "0x31418D0", Offset = "0x3140CD0", Length = "0x1CF")]
	[Token(Token = "0x600026B")]
	public ColorPropertyBag() { }

}

