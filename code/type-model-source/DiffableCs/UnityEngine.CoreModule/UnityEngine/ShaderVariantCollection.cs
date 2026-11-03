namespace UnityEngine;

[Token(Token = "0x20001E5")]
public sealed class ShaderVariantCollection : object
{
	[Token(Token = "0x20001E6")]
	internal struct ShaderVariant
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006D1")]
		public Shader shader; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40006D2")]
		public PassType passType; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40006D3")]
		public String[] keywords; //Field offset: 0x10

	}


	[Token(Token = "0x17000307")]
	public bool isWarmedUp
	{
		[Address(RVA = "0x3089740", Offset = "0x3088B40", Length = "0x77")]
		[NativeName("IsWarmedUp")]
		[Token(Token = "0x6001559")]
		 get { } //Length: 119
	}

	[Token(Token = "0x17000304")]
	public int shaderCount
	{
		[Address(RVA = "0x3089800", Offset = "0x3088C00", Length = "0x77")]
		[Token(Token = "0x6001556")]
		 get { } //Length: 119
	}

	[Token(Token = "0x17000305")]
	public int variantCount
	{
		[Address(RVA = "0x30898C0", Offset = "0x3088CC0", Length = "0x77")]
		[Token(Token = "0x6001557")]
		 get { } //Length: 119
	}

	[Token(Token = "0x17000306")]
	public int warmedUpVariantCount
	{
		[Address(RVA = "0x3089980", Offset = "0x3088D80", Length = "0x77")]
		[Token(Token = "0x6001558")]
		 get { } //Length: 119
	}

	[Address(RVA = "0x3089690", Offset = "0x3088A90", Length = "0x6E")]
	[Token(Token = "0x6001561")]
	public ShaderVariantCollection() { }

	[Address(RVA = "0x3088EC0", Offset = "0x30882C0", Length = "0xD5")]
	[Token(Token = "0x6001562")]
	public bool Add(ShaderVariant variant) { }

	[Address(RVA = "0x3088DE0", Offset = "0x30881E0", Length = "0xD4")]
	[Token(Token = "0x600155A")]
	private bool AddVariant(Shader shader, PassType passType, String[] keywords) { }

	[Address(RVA = "0x3088D70", Offset = "0x3088170", Length = "0x62")]
	[Token(Token = "0x6001569")]
	private static bool AddVariant_Injected(IntPtr _unity_self, IntPtr shader, PassType passType, String[] keywords) { }

	[Address(RVA = "0x3088FE0", Offset = "0x30883E0", Length = "0x77")]
	[NativeName("ClearVariants")]
	[Token(Token = "0x600155D")]
	public void Clear() { }

	[Address(RVA = "0x3088FA0", Offset = "0x30883A0", Length = "0x33")]
	[Token(Token = "0x600156C")]
	private static void Clear_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x30891B0", Offset = "0x30885B0", Length = "0xD5")]
	[Token(Token = "0x6001564")]
	public bool Contains(ShaderVariant variant) { }

	[Address(RVA = "0x30890D0", Offset = "0x30884D0", Length = "0xD4")]
	[Token(Token = "0x600155C")]
	private bool ContainsVariant(Shader shader, PassType passType, String[] keywords) { }

	[Address(RVA = "0x3089060", Offset = "0x3088460", Length = "0x62")]
	[Token(Token = "0x600156B")]
	private static bool ContainsVariant_Injected(IntPtr _unity_self, IntPtr shader, PassType passType, String[] keywords) { }

	[Address(RVA = "0x3089740", Offset = "0x3088B40", Length = "0x77")]
	[NativeName("IsWarmedUp")]
	[Token(Token = "0x6001559")]
	public bool get_isWarmedUp() { }

	[Address(RVA = "0x3089700", Offset = "0x3088B00", Length = "0x33")]
	[Token(Token = "0x6001568")]
	private static bool get_isWarmedUp_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3089800", Offset = "0x3088C00", Length = "0x77")]
	[Token(Token = "0x6001556")]
	public int get_shaderCount() { }

	[Address(RVA = "0x30897C0", Offset = "0x3088BC0", Length = "0x33")]
	[Token(Token = "0x6001565")]
	private static int get_shaderCount_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x30898C0", Offset = "0x3088CC0", Length = "0x77")]
	[Token(Token = "0x6001557")]
	public int get_variantCount() { }

	[Address(RVA = "0x3089880", Offset = "0x3088C80", Length = "0x33")]
	[Token(Token = "0x6001566")]
	private static int get_variantCount_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3089980", Offset = "0x3088D80", Length = "0x77")]
	[Token(Token = "0x6001558")]
	public int get_warmedUpVariantCount() { }

	[Address(RVA = "0x3089940", Offset = "0x3088D40", Length = "0x33")]
	[Token(Token = "0x6001567")]
	private static int get_warmedUpVariantCount_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3089290", Offset = "0x3088690", Length = "0x33")]
	[NativeName("CreateFromScript")]
	[Token(Token = "0x6001560")]
	private static void Internal_Create(ShaderVariantCollection svc) { }

	[Address(RVA = "0x3089420", Offset = "0x3088820", Length = "0xD5")]
	[Token(Token = "0x6001563")]
	public bool Remove(ShaderVariant variant) { }

	[Address(RVA = "0x3089340", Offset = "0x3088740", Length = "0xD4")]
	[Token(Token = "0x600155B")]
	private bool RemoveVariant(Shader shader, PassType passType, String[] keywords) { }

	[Address(RVA = "0x30892D0", Offset = "0x30886D0", Length = "0x62")]
	[Token(Token = "0x600156A")]
	private static bool RemoveVariant_Injected(IntPtr _unity_self, IntPtr shader, PassType passType, String[] keywords) { }

	[Address(RVA = "0x3089610", Offset = "0x3088A10", Length = "0x77")]
	[NativeName("WarmupShaders")]
	[Token(Token = "0x600155E")]
	public void WarmUp() { }

	[Address(RVA = "0x30895D0", Offset = "0x30889D0", Length = "0x33")]
	[Token(Token = "0x600156D")]
	private static void WarmUp_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3089540", Offset = "0x3088940", Length = "0x84")]
	[NativeName("WarmupShadersProgressively")]
	[Token(Token = "0x600155F")]
	public bool WarmUpProgressively(int variantCount) { }

	[Address(RVA = "0x3089500", Offset = "0x3088900", Length = "0x40")]
	[Token(Token = "0x600156E")]
	private static bool WarmUpProgressively_Injected(IntPtr _unity_self, int variantCount) { }

}

