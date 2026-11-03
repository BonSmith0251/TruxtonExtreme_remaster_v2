namespace System.ComponentModel.Design.Serialization;

[AttributeUsage(1028, AllowMultiple = True, Inherited = True)]
[Obsolete("This attribute has been deprecated. Use DesignerSerializerAttribute instead.  For example, to specify a root designer for CodeDom, use DesignerSerializerAttribute(...,typeof(TypeCodeDomSerializer)).  https://go.microsoft.com/fwlink/?linkid=14202")]
[Token(Token = "0x20001D4")]
public sealed class RootDesignerSerializerAttribute : Attribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40006F0")]
	private string _typeId; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40006F1")]
	private readonly bool <Reloadable>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40006F2")]
	private readonly string <SerializerTypeName>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40006F3")]
	private readonly string <SerializerBaseTypeName>k__BackingField; //Field offset: 0x28

	[Token(Token = "0x1700022B")]
	public string SerializerBaseTypeName
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000BA8")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700022C")]
	public virtual object TypeId
	{
		[Address(RVA = "0x268DBC0", Offset = "0x268CFC0", Length = "0x9D")]
		[Token(Token = "0x6000BA9")]
		 get { } //Length: 157
	}

	[Address(RVA = "0x268DB50", Offset = "0x268CF50", Length = "0x61")]
	[Token(Token = "0x6000BA7")]
	public RootDesignerSerializerAttribute(string serializerTypeName, string baseSerializerTypeName, bool reloadable) { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000BA8")]
	public string get_SerializerBaseTypeName() { }

	[Address(RVA = "0x268DBC0", Offset = "0x268CFC0", Length = "0x9D")]
	[Token(Token = "0x6000BA9")]
	public virtual object get_TypeId() { }

}

