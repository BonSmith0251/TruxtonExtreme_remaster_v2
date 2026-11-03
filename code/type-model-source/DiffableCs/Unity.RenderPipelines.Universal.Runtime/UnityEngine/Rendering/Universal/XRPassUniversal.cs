namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x20001FC")]
internal class XRPassUniversal : XRPass
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x748")]
	[Token(Token = "0x4000C0A")]
	private bool <isLateLatchEnabled>k__BackingField; //Field offset: 0x748
	[CompilerGenerated]
	[FieldOffset(Offset = "0x749")]
	[Token(Token = "0x4000C0B")]
	private bool <canMarkLateLatch>k__BackingField; //Field offset: 0x749
	[CompilerGenerated]
	[FieldOffset(Offset = "0x74A")]
	[Token(Token = "0x4000C0C")]
	private bool <hasMarkedLateLatch>k__BackingField; //Field offset: 0x74A
	[CompilerGenerated]
	[FieldOffset(Offset = "0x74B")]
	[Token(Token = "0x4000C0D")]
	private bool <canFoveateIntermediatePasses>k__BackingField; //Field offset: 0x74B

	[Token(Token = "0x170002A3")]
	internal bool canFoveateIntermediatePasses
	{
		[Address(RVA = "0x2E18290", Offset = "0x2E17690", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000AD6")]
		internal get { } //Length: 8
		[Address(RVA = "0x2E182D0", Offset = "0x2E176D0", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x6000AD7")]
		internal set { } //Length: 7
	}

	[Token(Token = "0x170002A1")]
	internal bool canMarkLateLatch
	{
		[Address(RVA = "0x2E182A0", Offset = "0x2E176A0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000AD2")]
		internal get { } //Length: 8
		[Address(RVA = "0x2E182E0", Offset = "0x2E176E0", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x6000AD3")]
		internal set { } //Length: 7
	}

	[Token(Token = "0x170002A2")]
	internal bool hasMarkedLateLatch
	{
		[Address(RVA = "0x2E182B0", Offset = "0x2E176B0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000AD4")]
		internal get { } //Length: 8
		[Address(RVA = "0x2E182F0", Offset = "0x2E176F0", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x6000AD5")]
		internal set { } //Length: 7
	}

	[Token(Token = "0x170002A0")]
	internal bool isLateLatchEnabled
	{
		[Address(RVA = "0x2E182C0", Offset = "0x2E176C0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000AD0")]
		internal get { } //Length: 8
		[Address(RVA = "0x2E18300", Offset = "0x2E17700", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x6000AD1")]
		internal set { } //Length: 7
	}

	[Address(RVA = "0x2E18280", Offset = "0x2E17680", Length = "0x7")]
	[Token(Token = "0x6000AD8")]
	public XRPassUniversal() { }

	[Address(RVA = "0x2E18170", Offset = "0x2E17570", Length = "0xA7")]
	[Token(Token = "0x6000ACE")]
	public static XRPass Create(XRPassCreateInfo createInfo) { }

	[Address(RVA = "0x2E18290", Offset = "0x2E17690", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000AD6")]
	internal bool get_canFoveateIntermediatePasses() { }

	[Address(RVA = "0x2E182A0", Offset = "0x2E176A0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000AD2")]
	internal bool get_canMarkLateLatch() { }

	[Address(RVA = "0x2E182B0", Offset = "0x2E176B0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000AD4")]
	internal bool get_hasMarkedLateLatch() { }

	[Address(RVA = "0x2E182C0", Offset = "0x2E176C0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000AD0")]
	internal bool get_isLateLatchEnabled() { }

	[Address(RVA = "0x2E18220", Offset = "0x2E17620", Length = "0x5A")]
	[Token(Token = "0x6000ACF")]
	public virtual void Release() { }

	[Address(RVA = "0x2E182D0", Offset = "0x2E176D0", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x6000AD7")]
	internal void set_canFoveateIntermediatePasses(bool value) { }

	[Address(RVA = "0x2E182E0", Offset = "0x2E176E0", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x6000AD3")]
	internal void set_canMarkLateLatch(bool value) { }

	[Address(RVA = "0x2E182F0", Offset = "0x2E176F0", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x6000AD5")]
	internal void set_hasMarkedLateLatch(bool value) { }

	[Address(RVA = "0x2E18300", Offset = "0x2E17700", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x6000AD1")]
	internal void set_isLateLatchEnabled(bool value) { }

}

