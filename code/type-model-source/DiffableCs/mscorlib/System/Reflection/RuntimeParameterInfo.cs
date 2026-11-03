namespace System.Reflection;

[ClassInterface(ClassInterfaceType::None (0))]
[ComDefaultInterface(typeof(_ParameterInfo))]
[ComVisible(True)]
[Token(Token = "0x200051F")]
internal class RuntimeParameterInfo : ParameterInfo
{
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001488")]
	internal MarshalAsAttribute marshalAs; //Field offset: 0x40

	[Token(Token = "0x170004F0")]
	public virtual object DefaultValue
	{
		[Address(RVA = "0x1F69B00", Offset = "0x1F68F00", Length = "0x31E")]
		[Token(Token = "0x60024F4")]
		 get { } //Length: 798
	}

	[Address(RVA = "0x1F69850", Offset = "0x1F68C50", Length = "0x9B")]
	[Token(Token = "0x60024F0")]
	internal RuntimeParameterInfo(string name, Type type, int position, int attrs, object defaultValue, MemberInfo member, MarshalAsAttribute marshalAs) { }

	[Address(RVA = "0x1F69980", Offset = "0x1F68D80", Length = "0x170")]
	[Token(Token = "0x60024F2")]
	internal RuntimeParameterInfo(ParameterInfo pinfo, MemberInfo member) { }

	[Address(RVA = "0x1F698F0", Offset = "0x1F68CF0", Length = "0x8C")]
	[Token(Token = "0x60024F3")]
	internal RuntimeParameterInfo(Type type, MemberInfo member, MarshalAsAttribute marshalAs) { }

	[Address(RVA = "0x1F688D0", Offset = "0x1F67CD0", Length = "0x1EA")]
	[Token(Token = "0x60024F1")]
	internal static void FormatParameters(StringBuilder sb, ParameterInfo[] p, CallingConventions callingConvention, bool serialization) { }

	[Address(RVA = "0x1F69B00", Offset = "0x1F68F00", Length = "0x31E")]
	[Token(Token = "0x60024F4")]
	public virtual object get_DefaultValue() { }

	[Address(RVA = "0x1F68B20", Offset = "0x1F67F20", Length = "0x4C")]
	[Token(Token = "0x60024F5")]
	public virtual Object[] GetCustomAttributes(bool inherit) { }

	[Address(RVA = "0x1F68AC0", Offset = "0x1F67EC0", Length = "0x5C")]
	[Token(Token = "0x60024F6")]
	public virtual Object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	[Address(RVA = "0x1F68B70", Offset = "0x1F67F70", Length = "0xB2")]
	[Token(Token = "0x60024F7")]
	internal object GetDefaultValueImpl(ParameterInfo pinfo) { }

	[Address(RVA = "0x1F69250", Offset = "0x1F68650", Length = "0x317")]
	[Token(Token = "0x60024F9")]
	internal Object[] GetPseudoCustomAttributes() { }

	[Address(RVA = "0x1F68C30", Offset = "0x1F68030", Length = "0x612")]
	[Token(Token = "0x60024FA")]
	internal CustomAttributeData[] GetPseudoCustomAttributesData() { }

	[Address(RVA = "0x1F69570", Offset = "0x1F68970", Length = "0x6B")]
	[Token(Token = "0x60024F8")]
	public virtual bool IsDefined(Type attributeType, bool inherit) { }

	[Address(RVA = "0x1F695E0", Offset = "0x1F689E0", Length = "0x1A0")]
	[Token(Token = "0x60024FB")]
	internal static ParameterInfo New(ParameterInfo pinfo, MemberInfo member) { }

	[Address(RVA = "0x1F69790", Offset = "0x1F68B90", Length = "0xBB")]
	[Token(Token = "0x60024FC")]
	internal static ParameterInfo New(Type type, MemberInfo member, MarshalAsAttribute marshalAs) { }

}

