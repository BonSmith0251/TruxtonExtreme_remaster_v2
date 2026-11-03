namespace System.ComponentModel;

[ComVisible(True)]
[Token(Token = "0x20001AF")]
public abstract class MemberDescriptor
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400067B")]
	private string name; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400067C")]
	private string displayName; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400067D")]
	private int nameHash; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400067E")]
	private AttributeCollection attributeCollection; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400067F")]
	private Attribute[] attributes; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000680")]
	private Attribute[] originalAttributes; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000681")]
	private bool attributesFiltered; //Field offset: 0x40
	[FieldOffset(Offset = "0x41")]
	[Token(Token = "0x4000682")]
	private bool attributesFilled; //Field offset: 0x41
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x4000683")]
	private int metadataVersion; //Field offset: 0x44
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000684")]
	private string category; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000685")]
	private string description; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000686")]
	private object lockCookie; //Field offset: 0x58

	[Token(Token = "0x170001FD")]
	protected override Attribute[] AttributeArray
	{
		[Address(RVA = "0x2665A60", Offset = "0x2664E60", Length = "0x24")]
		[Token(Token = "0x6000A60")]
		 get { } //Length: 36
		[Address(RVA = "0x2665D00", Offset = "0x2665100", Length = "0xC1")]
		[Token(Token = "0x6000A61")]
		 set { } //Length: 193
	}

	[Token(Token = "0x170001FE")]
	public override AttributeCollection Attributes
	{
		[Address(RVA = "0x2665A90", Offset = "0x2664E90", Length = "0xE5")]
		[Token(Token = "0x6000A62")]
		 get { } //Length: 229
	}

	[Token(Token = "0x17000201")]
	public override string DisplayName
	{
		[Address(RVA = "0x2665B80", Offset = "0x2664F80", Length = "0x125")]
		[Token(Token = "0x6000A65")]
		 get { } //Length: 293
	}

	[Token(Token = "0x170001FF")]
	public override string Name
	{
		[Address(RVA = "0x2665CB0", Offset = "0x26650B0", Length = "0x43")]
		[Token(Token = "0x6000A63")]
		 get { } //Length: 67
	}

	[Token(Token = "0x17000200")]
	protected override int NameHashCode
	{
		[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
		[Token(Token = "0x6000A64")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x26658E0", Offset = "0x2664CE0", Length = "0x179")]
	[Token(Token = "0x6000A5E")]
	protected MemberDescriptor(string name, Attribute[] attributes) { }

	[Address(RVA = "0x26654C0", Offset = "0x26648C0", Length = "0x415")]
	[Token(Token = "0x6000A5F")]
	protected MemberDescriptor(MemberDescriptor oldMemberDescriptor, Attribute[] newAttributes) { }

	[Address(RVA = "0x2664790", Offset = "0x2663B90", Length = "0xB9")]
	[Token(Token = "0x6000A66")]
	private void CheckAttributesValid() { }

	[Address(RVA = "0x2664850", Offset = "0x2663C50", Length = "0x6D")]
	[Token(Token = "0x6000A67")]
	protected override AttributeCollection CreateAttributeCollection() { }

	[Address(RVA = "0x26648C0", Offset = "0x2663CC0", Length = "0x29A")]
	[Token(Token = "0x6000A68")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x2664B60", Offset = "0x2663F60", Length = "0x125")]
	[Token(Token = "0x6000A69")]
	protected override void FillAttributes(IList attributeList) { }

	[Address(RVA = "0x2664C90", Offset = "0x2664090", Length = "0x50B")]
	[Token(Token = "0x6000A6A")]
	private void FilterAttributesIfNeeded() { }

	[Address(RVA = "0x2665260", Offset = "0x2664660", Length = "0x83")]
	[Token(Token = "0x6000A6B")]
	protected static MethodInfo FindMethod(Type componentClass, string name, Type[] args, Type returnType) { }

	[Address(RVA = "0x26651A0", Offset = "0x26645A0", Length = "0xB4")]
	[Token(Token = "0x6000A6C")]
	protected static MethodInfo FindMethod(Type componentClass, string name, Type[] args, Type returnType, bool publicOnly) { }

	[Address(RVA = "0x2665A60", Offset = "0x2664E60", Length = "0x24")]
	[Token(Token = "0x6000A60")]
	protected override Attribute[] get_AttributeArray() { }

	[Address(RVA = "0x2665A90", Offset = "0x2664E90", Length = "0xE5")]
	[Token(Token = "0x6000A62")]
	public override AttributeCollection get_Attributes() { }

	[Address(RVA = "0x2665B80", Offset = "0x2664F80", Length = "0x125")]
	[Token(Token = "0x6000A65")]
	public override string get_DisplayName() { }

	[Address(RVA = "0x2665CB0", Offset = "0x26650B0", Length = "0x43")]
	[Token(Token = "0x6000A63")]
	public override string get_Name() { }

	[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
	[Token(Token = "0x6000A64")]
	protected override int get_NameHashCode() { }

	[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
	[Token(Token = "0x6000A6D")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x26652F0", Offset = "0x26646F0", Length = "0x115")]
	[Token(Token = "0x6000A6E")]
	protected override object GetInvocationTarget(Type type, object instance) { }

	[Address(RVA = "0x2665410", Offset = "0x2664810", Length = "0xAC")]
	[Token(Token = "0x6000A6F")]
	protected static ISite GetSite(object component) { }

	[Address(RVA = "0x2665D00", Offset = "0x2665100", Length = "0xC1")]
	[Token(Token = "0x6000A61")]
	protected override void set_AttributeArray(Attribute[] value) { }

}

