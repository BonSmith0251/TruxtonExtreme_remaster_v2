namespace System;

[Token(Token = "0x2000127")]
public class Random
{
	[ThreadStatic]
	[Token(Token = "0x4000431")]
	private static Random t_threadRandom; //Field offset: 0x80000000
	[Token(Token = "0x4000432")]
	private static readonly Random s_globalRandom; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400042E")]
	private int _inext; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x400042F")]
	private int _inextp; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000430")]
	private Int32[] _seedArray; //Field offset: 0x18

	[Address(RVA = "0x2046C50", Offset = "0x2046050", Length = "0x86")]
	[Token(Token = "0x600097E")]
	private static Random() { }

	[Address(RVA = "0x2046CE0", Offset = "0x20460E0", Length = "0x53")]
	[Token(Token = "0x6000974")]
	public Random() { }

	[Address(RVA = "0x2046D40", Offset = "0x2046140", Length = "0x233")]
	[Token(Token = "0x6000975")]
	public Random(int Seed) { }

	[Address(RVA = "0x2025890", Offset = "0x2024C90", Length = "0x27")]
	[Token(Token = "0x6000979")]
	private static int GenerateGlobalSeed() { }

	[Address(RVA = "0x2046760", Offset = "0x2045B60", Length = "0x1D2")]
	[Token(Token = "0x6000978")]
	private static int GenerateSeed() { }

	[Address(RVA = "0x2046940", Offset = "0x2045D40", Length = "0x4C")]
	[Token(Token = "0x600097B")]
	private double GetSampleForLargeRange() { }

	[Address(RVA = "0x2046990", Offset = "0x2045D90", Length = "0x8F")]
	[Token(Token = "0x6000977")]
	private int InternalSample() { }

	[Address(RVA = "0x2046C20", Offset = "0x2046020", Length = "0x7")]
	[Token(Token = "0x600097A")]
	public override int Next() { }

	[Address(RVA = "0x2046A20", Offset = "0x2045E20", Length = "0x13E")]
	[Token(Token = "0x600097C")]
	public override int Next(int minValue, int maxValue) { }

	[Address(RVA = "0x2046B60", Offset = "0x2045F60", Length = "0xB6")]
	[Token(Token = "0x600097D")]
	public override int Next(int maxValue) { }

	[Address(RVA = "0x2046C30", Offset = "0x2046030", Length = "0x20")]
	[Token(Token = "0x6000976")]
	protected override double Sample() { }

}

