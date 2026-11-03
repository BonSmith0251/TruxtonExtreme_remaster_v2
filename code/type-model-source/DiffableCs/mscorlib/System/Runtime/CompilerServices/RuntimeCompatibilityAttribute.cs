namespace System.Runtime.CompilerServices;

[AttributeUsage(AttributeTargets::Assembly (1), Inherited = False, AllowMultiple = False)]
[Token(Token = "0x2000489")]
public sealed class RuntimeCompatibilityAttribute : Attribute
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001259")]
	private bool <WrapNonExceptionThrows>k__BackingField; //Field offset: 0x10

	[Token(Token = "0x17000402")]
	public bool WrapNonExceptionThrows
	{
		[Address(RVA = "0x1160480", Offset = "0x115F880", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60020ED")]
		 set { } //Length: 4
	}

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x60020EC")]
	public RuntimeCompatibilityAttribute() { }

	[Address(RVA = "0x1160480", Offset = "0x115F880", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60020ED")]
	public void set_WrapNonExceptionThrows(bool value) { }

}

