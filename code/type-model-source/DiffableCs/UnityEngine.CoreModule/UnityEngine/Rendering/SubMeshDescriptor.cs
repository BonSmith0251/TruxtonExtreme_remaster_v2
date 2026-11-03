namespace UnityEngine.Rendering;

[Token(Token = "0x2000358")]
public struct SubMeshDescriptor
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000998")]
	private Bounds <bounds>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000999")]
	private MeshTopology <topology>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x400099A")]
	private int <indexStart>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400099B")]
	private int <indexCount>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x400099C")]
	private int <baseVertex>k__BackingField; //Field offset: 0x24
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400099D")]
	private int <firstVertex>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x400099E")]
	private int <vertexCount>k__BackingField; //Field offset: 0x2C

	[Token(Token = "0x170003C2")]
	public int baseVertex
	{
		[Address(RVA = "0xEA4200", Offset = "0xEA3600", Length = "0x4")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6001A0A")]
		 get { } //Length: 4
		[Address(RVA = "0x5C4BB0", Offset = "0x5C3FB0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6001A0B")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170003BE")]
	public Bounds bounds
	{
		[Address(RVA = "0xAEF030", Offset = "0xAEE430", Length = "0x14")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6001A02")]
		 get { } //Length: 20
		[Address(RVA = "0x308A050", Offset = "0x3089450", Length = "0x11")]
		[CompilerGenerated]
		[Token(Token = "0x6001A03")]
		 set { } //Length: 17
	}

	[Token(Token = "0x170003C3")]
	public int firstVertex
	{
		[Address(RVA = "0xE30F80", Offset = "0xE30380", Length = "0x4")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6001A0C")]
		 get { } //Length: 4
		[Address(RVA = "0xFDA900", Offset = "0xFD9D00", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6001A0D")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170003C1")]
	public int indexCount
	{
		[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6001A08")]
		 get { } //Length: 4
		[Address(RVA = "0x109C830", Offset = "0x109BC30", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6001A09")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170003C0")]
	public int indexStart
	{
		[Address(RVA = "0xFE29D0", Offset = "0xFE1DD0", Length = "0x4")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6001A06")]
		 get { } //Length: 4
		[Address(RVA = "0xFE2A80", Offset = "0xFE1E80", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6001A07")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170003BF")]
	public MeshTopology topology
	{
		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6001A04")]
		 get { } //Length: 4
		[Address(RVA = "0xF4AFB0", Offset = "0xF4A3B0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6001A05")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170003C4")]
	public int vertexCount
	{
		[Address(RVA = "0xE0D780", Offset = "0xE0CB80", Length = "0x4")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6001A0E")]
		 get { } //Length: 4
		[Address(RVA = "0xE0D7E0", Offset = "0xE0CBE0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6001A0F")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x308A010", Offset = "0x3089410", Length = "0x33")]
	[Token(Token = "0x6001A01")]
	public SubMeshDescriptor(int indexStart, int indexCount, MeshTopology topology = 0) { }

	[Address(RVA = "0xEA4200", Offset = "0xEA3600", Length = "0x4")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6001A0A")]
	public int get_baseVertex() { }

	[Address(RVA = "0xAEF030", Offset = "0xAEE430", Length = "0x14")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6001A02")]
	public Bounds get_bounds() { }

	[Address(RVA = "0xE30F80", Offset = "0xE30380", Length = "0x4")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6001A0C")]
	public int get_firstVertex() { }

	[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6001A08")]
	public int get_indexCount() { }

	[Address(RVA = "0xFE29D0", Offset = "0xFE1DD0", Length = "0x4")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6001A06")]
	public int get_indexStart() { }

	[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6001A04")]
	public MeshTopology get_topology() { }

	[Address(RVA = "0xE0D780", Offset = "0xE0CB80", Length = "0x4")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6001A0E")]
	public int get_vertexCount() { }

	[Address(RVA = "0x5C4BB0", Offset = "0x5C3FB0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6001A0B")]
	public void set_baseVertex(int value) { }

	[Address(RVA = "0x308A050", Offset = "0x3089450", Length = "0x11")]
	[CompilerGenerated]
	[Token(Token = "0x6001A03")]
	public void set_bounds(Bounds value) { }

	[Address(RVA = "0xFDA900", Offset = "0xFD9D00", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6001A0D")]
	public void set_firstVertex(int value) { }

	[Address(RVA = "0x109C830", Offset = "0x109BC30", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6001A09")]
	public void set_indexCount(int value) { }

	[Address(RVA = "0xFE2A80", Offset = "0xFE1E80", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6001A07")]
	public void set_indexStart(int value) { }

	[Address(RVA = "0xF4AFB0", Offset = "0xF4A3B0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6001A05")]
	public void set_topology(MeshTopology value) { }

	[Address(RVA = "0xE0D7E0", Offset = "0xE0CBE0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6001A0F")]
	public void set_vertexCount(int value) { }

	[Address(RVA = "0x3089CB0", Offset = "0x30890B0", Length = "0x353")]
	[Token(Token = "0x6001A10")]
	public virtual string ToString() { }

}

