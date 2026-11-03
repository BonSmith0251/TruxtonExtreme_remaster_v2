namespace System.Runtime.Remoting;

[Token(Token = "0x2000360")]
internal class TypeInfo : IRemotingTypeInfo
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000E20")]
	private string serverType; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000E21")]
	private String[] serverHierarchy; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000E22")]
	private String[] interfacesImplemented; //Field offset: 0x20

	[Token(Token = "0x170002DD")]
	public override string TypeName
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6001B3A")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x1EF2870", Offset = "0x1EF1C70", Length = "0x471")]
	[Token(Token = "0x6001B39")]
	public TypeInfo(Type type) { }

	[Address(RVA = "0x1EF2620", Offset = "0x1EF1A20", Length = "0x244")]
	[Token(Token = "0x6001B3B")]
	public override bool CanCastTo(Type fromType, object o) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6001B3A")]
	public override string get_TypeName() { }

}

