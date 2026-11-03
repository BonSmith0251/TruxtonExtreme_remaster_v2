namespace System.Reflection;

[ClassInterface(ClassInterfaceType::None (0))]
[ComDefaultInterface(typeof(_Module))]
[ComVisible(True)]
[Token(Token = "0x200051E")]
internal class RuntimeModule : Module
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001481")]
	internal IntPtr _impl; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001482")]
	internal Assembly assembly; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001483")]
	internal string fqname; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001484")]
	internal string name; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001485")]
	internal string scopename; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001486")]
	internal bool is_resource; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4001487")]
	internal int token; //Field offset: 0x3C

	[Token(Token = "0x170004ED")]
	public virtual Assembly Assembly
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x60024E4")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170004EF")]
	public virtual Guid ModuleVersionId
	{
		[Address(RVA = "0x1F688A0", Offset = "0x1F67CA0", Length = "0x30")]
		[Token(Token = "0x60024E6")]
		 get { } //Length: 48
	}

	[Token(Token = "0x170004EE")]
	public virtual string ScopeName
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[Token(Token = "0x60024E5")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x1F68850", Offset = "0x1F67C50", Length = "0x49")]
	[Token(Token = "0x60024EF")]
	public RuntimeModule() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x60024E4")]
	public virtual Assembly get_Assembly() { }

	[Address(RVA = "0x1F688A0", Offset = "0x1F67CA0", Length = "0x30")]
	[Token(Token = "0x60024E6")]
	public virtual Guid get_ModuleVersionId() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[Token(Token = "0x60024E5")]
	public virtual string get_ScopeName() { }

	[Address(RVA = "0x1F68570", Offset = "0x1F67970", Length = "0x59")]
	[Token(Token = "0x60024E8")]
	public virtual Object[] GetCustomAttributes(bool inherit) { }

	[Address(RVA = "0x1F68500", Offset = "0x1F67900", Length = "0x6B")]
	[Token(Token = "0x60024E9")]
	public virtual Object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	[Address(RVA = "0x1F685D0", Offset = "0x1F679D0", Length = "0x5")]
	[Token(Token = "0x60024EE")]
	private static void GetGuidInternal(IntPtr module, Byte[] guid) { }

	[Address(RVA = "0x1F685E0", Offset = "0x1F679E0", Length = "0x78")]
	[Token(Token = "0x60024ED")]
	internal virtual Guid GetModuleVersionId() { }

	[Address(RVA = "0x1F68660", Offset = "0x1F67A60", Length = "0x105")]
	[Token(Token = "0x60024EB")]
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x1F68770", Offset = "0x1F67B70", Length = "0x6B")]
	[Token(Token = "0x60024EC")]
	internal RuntimeAssembly GetRuntimeAssembly() { }

	[Address(RVA = "0x1F687E0", Offset = "0x1F67BE0", Length = "0x6B")]
	[Token(Token = "0x60024EA")]
	public virtual bool IsDefined(Type attributeType, bool inherit) { }

	[Address(RVA = "0x11ED420", Offset = "0x11EC820", Length = "0x5")]
	[Token(Token = "0x60024E7")]
	public virtual bool IsResource() { }

}

