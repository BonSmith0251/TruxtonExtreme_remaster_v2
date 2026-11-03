namespace UnityEngine.UIElements;

[Token(Token = "0x2000514")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
internal class UxmlImageAttributeDescription : UxmlAttributeDescription
{
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40010AB")]
	private Type m_AssetType; //Field offset: 0x40
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40010AC")]
	private Background <defaultValue>k__BackingField; //Field offset: 0x48

	[Token(Token = "0x170009D5")]
	public Background defaultValue
	{
		[Address(RVA = "0x32C46F0", Offset = "0x32C3AF0", Length = "0x1A")]
		[CompilerGenerated]
		[Token(Token = "0x600259D")]
		 set { } //Length: 26
	}

	[Address(RVA = "0x32C4650", Offset = "0x32C3A50", Length = "0x98")]
	[Token(Token = "0x600259C")]
	public UxmlImageAttributeDescription() { }

	[Address(RVA = "0x32C44A0", Offset = "0x32C38A0", Length = "0x1A0")]
	[Token(Token = "0x600259E")]
	public Background GetValueFromBag(IUxmlAttributes bag, CreationContext cc) { }

	[Address(RVA = "0x32C46F0", Offset = "0x32C3AF0", Length = "0x1A")]
	[CompilerGenerated]
	[Token(Token = "0x600259D")]
	public void set_defaultValue(Background value) { }

}

