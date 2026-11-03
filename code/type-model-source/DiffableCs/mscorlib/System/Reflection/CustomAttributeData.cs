namespace System.Reflection;

[ComVisible(True)]
[Token(Token = "0x2000512")]
public class CustomAttributeData
{
	[Token(Token = "0x2000513")]
	private class LazyCAttrData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4001450")]
		internal Assembly assembly; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4001451")]
		internal IntPtr data; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4001452")]
		internal uint data_length; //Field offset: 0x20

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6002429")]
		public LazyCAttrData() { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400144C")]
	private ConstructorInfo ctorInfo; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400144D")]
	private IList<CustomAttributeTypedArgument> ctorArgs; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400144E")]
	private IList<CustomAttributeNamedArgument> namedArgs; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400144F")]
	private LazyCAttrData lazyData; //Field offset: 0x28

	[Token(Token = "0x170004BB")]
	public Type AttributeType
	{
		[Address(RVA = "0x1F29870", Offset = "0x1F28C70", Length = "0x2A")]
		[Token(Token = "0x6002424")]
		 get { } //Length: 42
	}

	[ComVisible(True)]
	[Token(Token = "0x170004B8")]
	public override ConstructorInfo Constructor
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x600241C")]
		 get { } //Length: 5
	}

	[ComVisible(True)]
	[Token(Token = "0x170004B9")]
	public override IList<CustomAttributeTypedArgument> ConstructorArguments
	{
		[Address(RVA = "0x1F53F90", Offset = "0x1F53390", Length = "0x1A")]
		[Token(Token = "0x600241D")]
		 get { } //Length: 26
	}

	[Token(Token = "0x170004BA")]
	public override IList<CustomAttributeNamedArgument> NamedArguments
	{
		[Address(RVA = "0x1F53FB0", Offset = "0x1F533B0", Length = "0x1A")]
		[Token(Token = "0x600241E")]
		 get { } //Length: 26
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6002416")]
	protected CustomAttributeData() { }

	[Address(RVA = "0x1F53E10", Offset = "0x1F53210", Length = "0xCF")]
	[Token(Token = "0x6002417")]
	internal CustomAttributeData(ConstructorInfo ctorInfo, Assembly assembly, IntPtr data, uint data_length) { }

	[Address(RVA = "0x1F53EE0", Offset = "0x1F532E0", Length = "0xAE")]
	[Token(Token = "0x6002418")]
	internal CustomAttributeData(ConstructorInfo ctorInfo) { }

	[Address(RVA = "0xA96E10", Offset = "0xA96210", Length = "0x6B")]
	[Token(Token = "0x6002419")]
	internal CustomAttributeData(ConstructorInfo ctorInfo, IList<CustomAttributeTypedArgument> ctorArgs, IList<CustomAttributeNamedArgument> namedArgs) { }

	[Address(RVA = "0x1F52B70", Offset = "0x1F51F70", Length = "0x527")]
	[Token(Token = "0x6002427")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x1F29870", Offset = "0x1F28C70", Length = "0x2A")]
	[Token(Token = "0x6002424")]
	public Type get_AttributeType() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x600241C")]
	public override ConstructorInfo get_Constructor() { }

	[Address(RVA = "0x1F53F90", Offset = "0x1F53390", Length = "0x1A")]
	[Token(Token = "0x600241D")]
	public override IList<CustomAttributeTypedArgument> get_ConstructorArguments() { }

	[Address(RVA = "0x1F53FB0", Offset = "0x1F533B0", Length = "0x1A")]
	[Token(Token = "0x600241E")]
	public override IList<CustomAttributeNamedArgument> get_NamedArguments() { }

	[Address(RVA = "0x1F53140", Offset = "0x1F52540", Length = "0x4C")]
	[Token(Token = "0x6002423")]
	public static IList<CustomAttributeData> GetCustomAttributes(ParameterInfo target) { }

	[Address(RVA = "0x1F530F0", Offset = "0x1F524F0", Length = "0x4C")]
	[Token(Token = "0x6002422")]
	public static IList<CustomAttributeData> GetCustomAttributes(Module target) { }

	[Address(RVA = "0x1F531E0", Offset = "0x1F525E0", Length = "0x4C")]
	[Token(Token = "0x600241F")]
	public static IList<CustomAttributeData> GetCustomAttributes(Assembly target) { }

	[Address(RVA = "0x1F53190", Offset = "0x1F52590", Length = "0x4C")]
	[Token(Token = "0x6002420")]
	public static IList<CustomAttributeData> GetCustomAttributes(MemberInfo target) { }

	[Address(RVA = "0x1F530A0", Offset = "0x1F524A0", Length = "0x4C")]
	[Token(Token = "0x6002421")]
	internal static IList<CustomAttributeData> GetCustomAttributesInternal(RuntimeType target) { }

	[Address(RVA = "0x1F53230", Offset = "0x1F52630", Length = "0x474")]
	[Token(Token = "0x6002428")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1F536C0", Offset = "0x1F52AC0", Length = "0x14A")]
	[Token(Token = "0x600241B")]
	private void ResolveArguments() { }

	[Address(RVA = "0x1F536B0", Offset = "0x1F52AB0", Length = "0x5")]
	[Token(Token = "0x600241A")]
	private static void ResolveArgumentsInternal(ConstructorInfo ctor, Assembly assembly, IntPtr data, uint data_length, out Object[] ctorArgs, out Object[] namedArgs) { }

	[Address(RVA = "0x1F53810", Offset = "0x1F52C10", Length = "0x5F0")]
	[Token(Token = "0x6002425")]
	public virtual string ToString() { }

	[Address(RVA = "0x7BA120", Offset = "0x7B9520", Length = "0x149")]
	[Token(Token = "0x6002426")]
	private static T[] UnboxValues(Object[] values) { }

}

