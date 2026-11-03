namespace UnityEngine;

[NativeHeader("Runtime/Export/Random/Random.bindings.h")]
[Token(Token = "0x2000176")]
public static class Random
{
	[Token(Token = "0x2000177")]
	internal struct State
	{
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		[Token(Token = "0x400060F")]
		private int s0; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[SerializeField]
		[Token(Token = "0x4000610")]
		private int s1; //Field offset: 0x4
		[FieldOffset(Offset = "0x8")]
		[SerializeField]
		[Token(Token = "0x4000611")]
		private int s2; //Field offset: 0x8
		[FieldOffset(Offset = "0xC")]
		[SerializeField]
		[Token(Token = "0x4000612")]
		private int s3; //Field offset: 0xC

	}


	[StaticAccessor("GetScriptingRand()", StaticAccessorType::Dot (0))]
	[Token(Token = "0x170002BE")]
	public static State state
	{
		[Address(RVA = "0x306FA60", Offset = "0x306EE60", Length = "0x3C")]
		[Token(Token = "0x6001217")]
		 get { } //Length: 60
		[Address(RVA = "0x306FB10", Offset = "0x306EF10", Length = "0x33")]
		[Token(Token = "0x6001218")]
		 set { } //Length: 51
	}

	[Token(Token = "0x170002BF")]
	public static float value
	{
		[Address(RVA = "0x306FAA0", Offset = "0x306EEA0", Length = "0x2A")]
		[FreeFunction]
		[Token(Token = "0x600121C")]
		 get { } //Length: 42
	}

	[Address(RVA = "0x306FA60", Offset = "0x306EE60", Length = "0x3C")]
	[Token(Token = "0x6001217")]
	public static State get_state() { }

	[Address(RVA = "0x306FA20", Offset = "0x306EE20", Length = "0x33")]
	[Token(Token = "0x600121D")]
	private static void get_state_Injected(out State ret) { }

	[Address(RVA = "0x306FAA0", Offset = "0x306EEA0", Length = "0x2A")]
	[FreeFunction]
	[Token(Token = "0x600121C")]
	public static float get_value() { }

	[Address(RVA = "0x306F950", Offset = "0x306ED50", Length = "0x31")]
	[NativeMethod("SetSeed")]
	[StaticAccessor("GetScriptingRand()", StaticAccessorType::Dot (0))]
	[Token(Token = "0x6001216")]
	public static void InitState(int seed) { }

	[Address(RVA = "0x306F990", Offset = "0x306ED90", Length = "0x3E")]
	[FreeFunction]
	[Token(Token = "0x600121B")]
	private static int RandomRangeInt(int minInclusive, int maxExclusive) { }

	[Address(RVA = "0x306F9D0", Offset = "0x306EDD0", Length = "0x4A")]
	[FreeFunction]
	[Token(Token = "0x6001219")]
	public static float Range(float minInclusive, float maxInclusive) { }

	[Address(RVA = "0x306F990", Offset = "0x306ED90", Length = "0x3E")]
	[Token(Token = "0x600121A")]
	public static int Range(int minInclusive, int maxExclusive) { }

	[Address(RVA = "0x306FB10", Offset = "0x306EF10", Length = "0x33")]
	[Token(Token = "0x6001218")]
	public static void set_state(State value) { }

	[Address(RVA = "0x306FAD0", Offset = "0x306EED0", Length = "0x33")]
	[Token(Token = "0x600121E")]
	private static void set_state_Injected(in State value) { }

}

