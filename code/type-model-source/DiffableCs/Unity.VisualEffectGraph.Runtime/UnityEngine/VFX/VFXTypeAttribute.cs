namespace UnityEngine.VFX;

[AttributeUsage(AttributeTargets::Struct (8), AllowMultiple = False)]
[Token(Token = "0x200000F")]
public class VFXTypeAttribute : Attribute
{
	[Flags]
	[Token(Token = "0x2000010")]
	internal enum Usage : int
	{
		Default = 1,
		GraphicsBuffer = 2,
		ExcludeFromProperty = 4,
	}

	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400002F")]
	private Usage <usages>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000030")]
	private string <name>k__BackingField; //Field offset: 0x18

	[Token(Token = "0x17000003")]
	internal string name
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000021")]
		internal get { } //Length: 5
		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000022")]
		private set { } //Length: 13
	}

	[Token(Token = "0x17000002")]
	internal Usage usages
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[CompilerGenerated]
		[Token(Token = "0x600001F")]
		internal get { } //Length: 85
		[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000020")]
		private set { } //Length: 4
	}

	[Address(RVA = "0x229A1A0", Offset = "0x22995A0", Length = "0x40")]
	[Token(Token = "0x600001E")]
	public VFXTypeAttribute(Usage usages = 1, string name = null) { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000021")]
	internal string get_name() { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[CompilerGenerated]
	[Token(Token = "0x600001F")]
	internal Usage get_usages() { }

	[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000022")]
	private void set_name(string value) { }

	[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000020")]
	private void set_usages(Usage value) { }

}

