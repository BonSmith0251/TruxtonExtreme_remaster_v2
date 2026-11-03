namespace UnityEngine.Scripting.APIUpdating;

[AttributeUsage(5148)]
[Token(Token = "0x200025D")]
public class MovedFromAttribute : Attribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40007CD")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal MovedFromAttributeData data; //Field offset: 0x10

	[Address(RVA = "0x3079F50", Offset = "0x3079350", Length = "0x57")]
	[Token(Token = "0x6001847")]
	public MovedFromAttribute(bool autoUpdateAPI, string sourceNamespace = null, string sourceAssembly = null, string sourceClassName = null) { }

	[Address(RVA = "0x3079FB0", Offset = "0x30793B0", Length = "0x7D")]
	[Token(Token = "0x6001848")]
	public MovedFromAttribute(string sourceNamespace) { }

}

