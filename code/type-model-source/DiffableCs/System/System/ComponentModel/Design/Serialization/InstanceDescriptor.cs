namespace System.ComponentModel.Design.Serialization;

[Token(Token = "0x20001D3")]
public sealed class InstanceDescriptor
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40006ED")]
	private readonly ICollection <Arguments>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40006EE")]
	private readonly bool <IsComplete>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40006EF")]
	private readonly MemberInfo <MemberInfo>k__BackingField; //Field offset: 0x20

	[Token(Token = "0x17000229")]
	public ICollection Arguments
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000BA4")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700022A")]
	public MemberInfo MemberInfo
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000BA5")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2683A20", Offset = "0x2682E20", Length = "0x1A")]
	[Token(Token = "0x6000BA2")]
	public InstanceDescriptor(MemberInfo member, ICollection arguments) { }

	[Address(RVA = "0x2683A40", Offset = "0x2682E40", Length = "0x698")]
	[Token(Token = "0x6000BA3")]
	public InstanceDescriptor(MemberInfo member, ICollection arguments, bool isComplete) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000BA4")]
	public ICollection get_Arguments() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000BA5")]
	public MemberInfo get_MemberInfo() { }

	[Address(RVA = "0x2683600", Offset = "0x2682A00", Length = "0x41D")]
	[Token(Token = "0x6000BA6")]
	public object Invoke() { }

}

