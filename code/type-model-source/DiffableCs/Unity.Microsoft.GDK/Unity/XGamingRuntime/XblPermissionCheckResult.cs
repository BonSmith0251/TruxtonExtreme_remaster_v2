namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x20001BF")]
public class XblPermissionCheckResult
{
	[CompilerGenerated]
	[Token(Token = "0x20001C0")]
	private sealed class <>c
	{
		[Token(Token = "0x400048F")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000490")]
		public static Func<XblPermissionDenyReasonDetails, XblPermissionDenyReasonDetails> <>9__0_0; //Field offset: 0x8

		[Address(RVA = "0x2B80660", Offset = "0x2B7FA60", Length = "0x67")]
		[Token(Token = "0x6000972")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000973")]
		public <>c() { }

		[Address(RVA = "0x2B7F710", Offset = "0x2B7EB10", Length = "0x79")]
		[Token(Token = "0x6000974")]
		internal XblPermissionDenyReasonDetails <.ctor>b__0_0(XblPermissionDenyReasonDetails x) { }

	}

	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400048A")]
	private bool <IsAllowed>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400048B")]
	private ulong <TargetXuid>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400048C")]
	private XblAnonymousUserType <TargetUserType>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x400048D")]
	private XblPermission <PermissionRequested>k__BackingField; //Field offset: 0x24
	[CompilerGenerated]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400048E")]
	private XblPermissionDenyReasonDetails[] <Reasons>k__BackingField; //Field offset: 0x28

	[Token(Token = "0x17000196")]
	public private bool IsAllowed
	{
		[Address(RVA = "0x10AACB0", Offset = "0x10AA0B0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000968")]
		 get { } //Length: 5
		[Address(RVA = "0x1160480", Offset = "0x115F880", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000969")]
		private set { } //Length: 4
	}

	[Token(Token = "0x17000199")]
	public private XblPermission PermissionRequested
	{
		[Address(RVA = "0xEA4200", Offset = "0xEA3600", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600096E")]
		 get { } //Length: 4
		[Address(RVA = "0x5C4BB0", Offset = "0x5C3FB0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600096F")]
		private set { } //Length: 4
	}

	[Token(Token = "0x1700019A")]
	public private XblPermissionDenyReasonDetails[] Reasons
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000970")]
		 get { } //Length: 5
		[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000971")]
		private set { } //Length: 13
	}

	[Token(Token = "0x17000198")]
	public private XblAnonymousUserType TargetUserType
	{
		[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600096C")]
		 get { } //Length: 4
		[Address(RVA = "0x109C830", Offset = "0x109BC30", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600096D")]
		private set { } //Length: 4
	}

	[Token(Token = "0x17000197")]
	public private ulong TargetXuid
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600096A")]
		 get { } //Length: 5
		[Address(RVA = "0xF4AFC0", Offset = "0xF4A3C0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600096B")]
		private set { } //Length: 5
	}

	[Address(RVA = "0x2B8A6E0", Offset = "0x2B89AE0", Length = "0x17A")]
	[Token(Token = "0x6000967")]
	internal XblPermissionCheckResult(XblPermissionCheckResult interopStruct) { }

	[Address(RVA = "0x10AACB0", Offset = "0x10AA0B0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000968")]
	public bool get_IsAllowed() { }

	[Address(RVA = "0xEA4200", Offset = "0xEA3600", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x600096E")]
	public XblPermission get_PermissionRequested() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000970")]
	public XblPermissionDenyReasonDetails[] get_Reasons() { }

	[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x600096C")]
	public XblAnonymousUserType get_TargetUserType() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600096A")]
	public ulong get_TargetXuid() { }

	[Address(RVA = "0x1160480", Offset = "0x115F880", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000969")]
	private void set_IsAllowed(bool value) { }

	[Address(RVA = "0x5C4BB0", Offset = "0x5C3FB0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x600096F")]
	private void set_PermissionRequested(XblPermission value) { }

	[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000971")]
	private void set_Reasons(XblPermissionDenyReasonDetails[] value) { }

	[Address(RVA = "0x109C830", Offset = "0x109BC30", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x600096D")]
	private void set_TargetUserType(XblAnonymousUserType value) { }

	[Address(RVA = "0xF4AFC0", Offset = "0xF4A3C0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600096B")]
	private void set_TargetXuid(ulong value) { }

}

