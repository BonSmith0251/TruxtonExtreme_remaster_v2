namespace UnityEngine.Scripting.APIUpdating;

[Token(Token = "0x200025C")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
internal struct MovedFromAttributeData
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40007C6")]
	public string className; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40007C7")]
	public string nameSpace; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40007C8")]
	public string assembly; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40007C9")]
	public bool classHasChanged; //Field offset: 0x18
	[FieldOffset(Offset = "0x19")]
	[Token(Token = "0x40007CA")]
	public bool nameSpaceHasChanged; //Field offset: 0x19
	[FieldOffset(Offset = "0x1A")]
	[Token(Token = "0x40007CB")]
	public bool assemblyHasChanged; //Field offset: 0x1A
	[FieldOffset(Offset = "0x1B")]
	[Token(Token = "0x40007CC")]
	public bool autoUdpateAPI; //Field offset: 0x1B

	[Address(RVA = "0x3079EC0", Offset = "0x30792C0", Length = "0x86")]
	[Token(Token = "0x6001846")]
	public void Set(bool autoUpdateAPI, string sourceNamespace = null, string sourceAssembly = null, string sourceClassName = null) { }

}

