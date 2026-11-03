namespace System.Security;

[ComVisible(True)]
[MonoTODO("CAS support is experimental (and unsupported).")]
[Token(Token = "0x20002CF")]
public class PermissionSet : ISecurityEncodable, ICollection, IEnumerable, IDeserializationCallback
{
	[Token(Token = "0x4000C10")]
	private static Object[] psUnrestricted; //Field offset: 0x0
	[Token(Token = "0x4000C15")]
	private static Object[] action; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000C11")]
	private PermissionState state; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000C12")]
	private ArrayList list; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000C13")]
	private bool _declsec; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000C14")]
	private Boolean[] _ignored; //Field offset: 0x28

	[Token(Token = "0x1700024F")]
	public override int Count
	{
		[Address(RVA = "0x1EAA5B0", Offset = "0x1EA99B0", Length = "0x2A")]
		[Token(Token = "0x60017A6")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000250")]
	public override bool IsSynchronized
	{
		[Address(RVA = "0x1EAA5E0", Offset = "0x1EA99E0", Length = "0x2A")]
		[Token(Token = "0x60017A7")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000251")]
	public override object SyncRoot
	{
		[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
		[Token(Token = "0x60017A8")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x1EAA1E0", Offset = "0x1EA95E0", Length = "0x1A7")]
	[Token(Token = "0x60017AC")]
	private static PermissionSet() { }

	[Address(RVA = "0x1EAA390", Offset = "0x1EA9790", Length = "0x9D")]
	[Token(Token = "0x600179D")]
	internal PermissionSet(IPermission perm) { }

	[Address(RVA = "0x1EAA430", Offset = "0x1EA9830", Length = "0x66")]
	[Token(Token = "0x600179B")]
	internal PermissionSet() { }

	[Address(RVA = "0x1EAA4A0", Offset = "0x1EA98A0", Length = "0x10D")]
	[Token(Token = "0x600179C")]
	public PermissionSet(PermissionState state) { }

	[Address(RVA = "0x1EA9420", Offset = "0x1EA8820", Length = "0x76")]
	[Token(Token = "0x60017A0")]
	internal void CasOnlyDemand(int skip) { }

	[Address(RVA = "0x1EA94A0", Offset = "0x1EA88A0", Length = "0x191")]
	[Token(Token = "0x600179E")]
	public override void CopyTo(Array array, int index) { }

	[Address(RVA = "0x1EA9640", Offset = "0x1EA8A40", Length = "0x1F5")]
	[Token(Token = "0x600179F")]
	public override void Demand() { }

	[Address(RVA = "0x1EA9840", Offset = "0x1EA8C40", Length = "0x1CE")]
	[ComVisible(False)]
	[Token(Token = "0x60017AA")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x1EAA5B0", Offset = "0x1EA99B0", Length = "0x2A")]
	[Token(Token = "0x60017A6")]
	public override int get_Count() { }

	[Address(RVA = "0x1EAA5E0", Offset = "0x1EA99E0", Length = "0x2A")]
	[Token(Token = "0x60017A7")]
	public override bool get_IsSynchronized() { }

	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[Token(Token = "0x60017A8")]
	public override object get_SyncRoot() { }

	[Address(RVA = "0x1EA9A10", Offset = "0x1EA8E10", Length = "0x2A")]
	[Token(Token = "0x60017A1")]
	public override IEnumerator GetEnumerator() { }

	[Address(RVA = "0x1EA9A40", Offset = "0x1EA8E40", Length = "0x46")]
	[ComVisible(False)]
	[Token(Token = "0x60017AB")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1EA9A90", Offset = "0x1EA8E90", Length = "0x280")]
	[Token(Token = "0x60017A2")]
	public bool IsEmpty() { }

	[Address(RVA = "0xF54050", Offset = "0xF53450", Length = "0x8")]
	[Token(Token = "0x60017A3")]
	public bool IsUnrestricted() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[MonoTODO("may not be required")]
	[Token(Token = "0x60017A9")]
	private override void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	[Address(RVA = "0x1EA9D20", Offset = "0x1EA9120", Length = "0x3C")]
	[Token(Token = "0x60017A4")]
	public virtual string ToString() { }

	[Address(RVA = "0x1EA9D60", Offset = "0x1EA9160", Length = "0x47D")]
	[Token(Token = "0x60017A5")]
	public override SecurityElement ToXml() { }

}

