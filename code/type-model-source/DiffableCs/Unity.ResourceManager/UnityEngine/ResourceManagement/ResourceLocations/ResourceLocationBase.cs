namespace UnityEngine.ResourceManagement.ResourceLocations;

[Token(Token = "0x200006F")]
public class ResourceLocationBase : IResourceLocation
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000124")]
	private string m_Name; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000125")]
	private string m_Id; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000126")]
	private string m_ProviderId; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000127")]
	private object m_Data; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000128")]
	private int m_DependencyHashCode; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000129")]
	private int m_HashCode; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400012A")]
	private Type m_Type; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400012B")]
	private List<IResourceLocation> m_Dependencies; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400012C")]
	private string m_PrimaryKey; //Field offset: 0x48

	[Token(Token = "0x1700006E")]
	public override object Data
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x600027A")]
		 get { } //Length: 5
		[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
		[Token(Token = "0x600027B")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700006C")]
	public override IList<IResourceLocation> Dependencies
	{
		[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
		[Token(Token = "0x6000278")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000070")]
	public override int DependencyHashCode
	{
		[Address(RVA = "0xB0A070", Offset = "0xB09470", Length = "0x4")]
		[Token(Token = "0x600027E")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700006D")]
	public override bool HasDependencies
	{
		[Address(RVA = "0x2E48AD0", Offset = "0x2E47ED0", Length = "0x45")]
		[Token(Token = "0x6000279")]
		 get { } //Length: 69
	}

	[Token(Token = "0x1700006A")]
	public override string InternalId
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x6000276")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700006F")]
	public override string PrimaryKey
	{
		[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
		[Token(Token = "0x600027C")]
		 get { } //Length: 5
		[Address(RVA = "0x115C990", Offset = "0x115BD90", Length = "0xD")]
		[Token(Token = "0x600027D")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700006B")]
	public override string ProviderId
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x6000277")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000071")]
	public override Type ResourceType
	{
		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[Token(Token = "0x600027F")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2E48850", Offset = "0x2E47C50", Length = "0x27B")]
	[Token(Token = "0x6000282")]
	public ResourceLocationBase(string name, string id, string providerId, Type t, IResourceLocation[] dependencies) { }

	[Address(RVA = "0x2E485D0", Offset = "0x2E479D0", Length = "0x22F")]
	[Token(Token = "0x6000283")]
	public void ComputeDependencyHash() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x600027A")]
	public override object get_Data() { }

	[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
	[Token(Token = "0x6000278")]
	public override IList<IResourceLocation> get_Dependencies() { }

	[Address(RVA = "0xB0A070", Offset = "0xB09470", Length = "0x4")]
	[Token(Token = "0x600027E")]
	public override int get_DependencyHashCode() { }

	[Address(RVA = "0x2E48AD0", Offset = "0x2E47ED0", Length = "0x45")]
	[Token(Token = "0x6000279")]
	public override bool get_HasDependencies() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x6000276")]
	public override string get_InternalId() { }

	[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
	[Token(Token = "0x600027C")]
	public override string get_PrimaryKey() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x6000277")]
	public override string get_ProviderId() { }

	[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
	[Token(Token = "0x600027F")]
	public override Type get_ResourceType() { }

	[Address(RVA = "0x2E48800", Offset = "0x2E47C00", Length = "0x49")]
	[Token(Token = "0x6000280")]
	public override int Hash(Type t) { }

	[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
	[Token(Token = "0x600027B")]
	public void set_Data(object value) { }

	[Address(RVA = "0x115C990", Offset = "0x115BD90", Length = "0xD")]
	[Token(Token = "0x600027D")]
	public void set_PrimaryKey(string value) { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x6000281")]
	public virtual string ToString() { }

}

