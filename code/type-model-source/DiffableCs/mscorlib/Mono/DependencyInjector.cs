namespace Mono;

[Token(Token = "0x200002C")]
internal static class DependencyInjector
{
	[Token(Token = "0x4000104")]
	private static object locker; //Field offset: 0x0
	[Token(Token = "0x4000105")]
	private static ISystemDependencyProvider systemDependency; //Field offset: 0x8

	[Token(Token = "0x17000003")]
	internal static ISystemDependencyProvider SystemProvider
	{
		[Address(RVA = "0x1E5C5D0", Offset = "0x1E5B9D0", Length = "0x362")]
		[Token(Token = "0x6000040")]
		internal get { } //Length: 866
	}

	[Address(RVA = "0x1E5C550", Offset = "0x1E5B950", Length = "0x73")]
	[Token(Token = "0x6000043")]
	private static DependencyInjector() { }

	[Address(RVA = "0x1E5C5D0", Offset = "0x1E5B9D0", Length = "0x362")]
	[Token(Token = "0x6000040")]
	internal static ISystemDependencyProvider get_SystemProvider() { }

	[Address(RVA = "0x1E5C280", Offset = "0x1E5B680", Length = "0x126")]
	[Token(Token = "0x6000042")]
	private static ISystemDependencyProvider ReflectionLoad() { }

	[Address(RVA = "0x1E5C3B0", Offset = "0x1E5B7B0", Length = "0x192")]
	[Token(Token = "0x6000041")]
	internal static void Register(ISystemDependencyProvider provider) { }

}

