namespace System;

[Token(Token = "0x20000EF")]
public struct HashCode
{
	[Token(Token = "0x40003E6")]
	private static readonly uint s_seed; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40003E7")]
	private uint _v1; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40003E8")]
	private uint _v2; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40003E9")]
	private uint _v3; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x40003EA")]
	private uint _v4; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40003EB")]
	private uint _queue1; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40003EC")]
	private uint _queue2; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40003ED")]
	private uint _queue3; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x40003EE")]
	private uint _length; //Field offset: 0x1C

	[Address(RVA = "0x2025E60", Offset = "0x2025260", Length = "0x53")]
	[Token(Token = "0x6000792")]
	private static HashCode() { }

	[Address(RVA = "0x20256A0", Offset = "0x2024AA0", Length = "0x19D")]
	[Token(Token = "0x600078E")]
	private void Add(int value) { }

	[Address(RVA = "0x815530", Offset = "0x814930", Length = "0x8C")]
	[Token(Token = "0x600078D")]
	public void Add(T value) { }

	[Address(RVA = "0x818970", Offset = "0x817D70", Length = "0x14B")]
	[Token(Token = "0x6000780")]
	public static int Combine(T1 value1, T2 value2) { }

	[Address(RVA = "0x818AC0", Offset = "0x817EC0", Length = "0x1AC")]
	[Token(Token = "0x6000781")]
	public static int Combine(T1 value1, T2 value2, T3 value3) { }

	[Address(RVA = "0x818C70", Offset = "0x818070", Length = "0x2D4")]
	[Token(Token = "0x6000782")]
	public static int Combine(T1 value1, T2 value2, T3 value3, T4 value4) { }

	[Address(RVA = "0x818660", Offset = "0x817A60", Length = "0x30B")]
	[Token(Token = "0x6000783")]
	public static int Combine(T1 value1, T2 value2, T3 value3, T4 value4, T5 value5) { }

	[Address(RVA = "0x818F50", Offset = "0x818350", Length = "0x3A5")]
	[Token(Token = "0x6000784")]
	public static int Combine(T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6) { }

	[Address(RVA = "0x819E30", Offset = "0x819230", Length = "0x46B")]
	[Token(Token = "0x6000785")]
	public static int Combine(T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8) { }

	[Address(RVA = "0x2025840", Offset = "0x2024C40", Length = "0x4E")]
	[Obsolete("HashCode is a mutable struct and should not be compared with other HashCodes.", True)]
	[Token(Token = "0x6000791")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x2025890", Offset = "0x2024C90", Length = "0x27")]
	[Token(Token = "0x600077F")]
	private static uint GenerateGlobalSeed() { }

	[Address(RVA = "0x20258C0", Offset = "0x2024CC0", Length = "0x4E")]
	[Obsolete("HashCode is a mutable struct and should not be compared with other HashCodes. Use ToHashCode to retrieve the computed hash code.", True)]
	[Token(Token = "0x6000790")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2025910", Offset = "0x2024D10", Length = "0xC4")]
	[Token(Token = "0x6000787")]
	private static void Initialize(out uint v1, out uint v2, out uint v3, out uint v4) { }

	[Address(RVA = "0x20259E0", Offset = "0x2024DE0", Length = "0x52")]
	[Token(Token = "0x600078B")]
	private static uint MixEmptyState() { }

	[Address(RVA = "0x2025A40", Offset = "0x2024E40", Length = "0x22")]
	[Token(Token = "0x600078C")]
	private static uint MixFinal(uint hash) { }

	[Address(RVA = "0x2025A70", Offset = "0x2024E70", Length = "0x97")]
	[Token(Token = "0x600078A")]
	private static uint MixState(uint v1, uint v2, uint v3, uint v4) { }

	[Address(RVA = "0x2025B10", Offset = "0x2024F10", Length = "0x62")]
	[Token(Token = "0x6000789")]
	private static uint QueueRound(uint hash, uint queuedValue) { }

	[Address(RVA = "0x2025B80", Offset = "0x2024F80", Length = "0x19")]
	[Token(Token = "0x6000786")]
	private static uint Rol(uint value, int count) { }

	[Address(RVA = "0x2025BA0", Offset = "0x2024FA0", Length = "0x62")]
	[Token(Token = "0x6000788")]
	private static uint Round(uint hash, uint input) { }

	[Address(RVA = "0x2025C10", Offset = "0x2025010", Length = "0x250")]
	[Token(Token = "0x600078F")]
	public int ToHashCode() { }

}

