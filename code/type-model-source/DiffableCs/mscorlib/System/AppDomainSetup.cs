namespace System;

[ClassInterface(ClassInterfaceType::None (0))]
[ComVisible(True)]
[Token(Token = "0x20001A4")]
public sealed class AppDomainSetup
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40006BB")]
	private string application_base; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40006BC")]
	private string application_name; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40006BD")]
	private string cache_path; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40006BE")]
	private string configuration_file; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40006BF")]
	private string dynamic_base; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40006C0")]
	private string license_file; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40006C1")]
	private string private_bin_path; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40006C2")]
	private string private_bin_path_probe; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40006C3")]
	private string shadow_copy_directories; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40006C4")]
	private string shadow_copy_files; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40006C5")]
	private bool publisher_policy; //Field offset: 0x60
	[FieldOffset(Offset = "0x61")]
	[Token(Token = "0x40006C6")]
	private bool path_changed; //Field offset: 0x61
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x40006C7")]
	private int loader_optimization; //Field offset: 0x64
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40006C8")]
	private bool disallow_binding_redirects; //Field offset: 0x68
	[FieldOffset(Offset = "0x69")]
	[Token(Token = "0x40006C9")]
	private bool disallow_code_downloads; //Field offset: 0x69
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40006CA")]
	private object _activationArguments; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40006CB")]
	private object domain_initializer; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40006CC")]
	private object application_trust; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x40006CD")]
	private String[] domain_initializer_args; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x40006CE")]
	private bool disallow_appbase_probe; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x40006CF")]
	private Byte[] configuration_bytes; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x40006D0")]
	private Byte[] serialized_non_primitives; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x40006D1")]
	private string manager_assembly; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x40006D2")]
	private string manager_type; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x40006D3")]
	private String[] partial_visible_assemblies; //Field offset: 0xB8
	[CompilerGenerated]
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x40006D4")]
	private string <TargetFrameworkName>k__BackingField; //Field offset: 0xC0

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000F61")]
	public AppDomainSetup() { }

}

