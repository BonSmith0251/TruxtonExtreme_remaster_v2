namespace UnityEngine.Rendering;

[Token(Token = "0x2000359")]
[UsedByNativeCode]
public struct VertexAttributeDescriptor : IEquatable<VertexAttributeDescriptor>
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400099F")]
	private VertexAttribute <attribute>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40009A0")]
	private VertexAttributeFormat <format>k__BackingField; //Field offset: 0x4
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40009A1")]
	private int <dimension>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x40009A2")]
	private int <stream>k__BackingField; //Field offset: 0xC

	[Token(Token = "0x170003C5")]
	public VertexAttribute attribute
	{
		[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6001A11")]
		 get { } //Length: 3
		[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
		[CompilerGenerated]
		[Token(Token = "0x6001A12")]
		 set { } //Length: 3
	}

	[Token(Token = "0x170003C7")]
	public int dimension
	{
		[Address(RVA = "0x672E80", Offset = "0x672280", Length = "0x4")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6001A15")]
		 get { } //Length: 4
		[Address(RVA = "0x672EA0", Offset = "0x6722A0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6001A16")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170003C6")]
	public VertexAttributeFormat format
	{
		[Address(RVA = "0x6466B0", Offset = "0x645AB0", Length = "0x4")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6001A13")]
		 get { } //Length: 4
		[Address(RVA = "0x6466F0", Offset = "0x645AF0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6001A14")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170003C8")]
	public int stream
	{
		[Address(RVA = "0x672E90", Offset = "0x672290", Length = "0x4")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6001A17")]
		 get { } //Length: 4
		[Address(RVA = "0x672EB0", Offset = "0x6722B0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6001A18")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x27F6A90", Offset = "0x27F5E90", Length = "0x12")]
	[Token(Token = "0x6001A19")]
	public VertexAttributeDescriptor(VertexAttribute attribute = 0, VertexAttributeFormat format = 0, int dimension = 3, int stream = 0) { }

	[Address(RVA = "0x3097560", Offset = "0x3096960", Length = "0xBD")]
	[Token(Token = "0x6001A1C")]
	public virtual bool Equals(object other) { }

	[Address(RVA = "0x300F620", Offset = "0x300EA20", Length = "0x27")]
	[Token(Token = "0x6001A1D")]
	public override bool Equals(VertexAttributeDescriptor other) { }

	[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6001A11")]
	public VertexAttribute get_attribute() { }

	[Address(RVA = "0x672E80", Offset = "0x672280", Length = "0x4")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6001A15")]
	public int get_dimension() { }

	[Address(RVA = "0x6466B0", Offset = "0x645AB0", Length = "0x4")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6001A13")]
	public VertexAttributeFormat get_format() { }

	[Address(RVA = "0x672E90", Offset = "0x672290", Length = "0x4")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6001A17")]
	public int get_stream() { }

	[Address(RVA = "0x3097620", Offset = "0x3096A20", Length = "0x1C")]
	[Token(Token = "0x6001A1B")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
	[CompilerGenerated]
	[Token(Token = "0x6001A12")]
	public void set_attribute(VertexAttribute value) { }

	[Address(RVA = "0x672EA0", Offset = "0x6722A0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6001A16")]
	public void set_dimension(int value) { }

	[Address(RVA = "0x6466F0", Offset = "0x645AF0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6001A14")]
	public void set_format(VertexAttributeFormat value) { }

	[Address(RVA = "0x672EB0", Offset = "0x6722B0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6001A18")]
	public void set_stream(int value) { }

	[Address(RVA = "0x3097640", Offset = "0x3096A40", Length = "0x20C")]
	[Token(Token = "0x6001A1A")]
	public virtual string ToString() { }

}

